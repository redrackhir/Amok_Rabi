Imports System.Windows.Forms
Imports System.Runtime.InteropServices

Public Class FormClassic

    Friend Declare Auto Function ReleaseCapture Lib "user32.dll" (
        ByVal hWnd As IntPtr,
        ByVal lpText As String,
        ByVal lpCaption As String,
        ByVal uType As UInteger) As Integer


    Private _year As Integer = 1
    Private _IncomingPeople As Integer
    Private _population As Integer = 100
    Private _acresOwned As Integer = 1000
    Private _bushels As Integer = 2800
    Private _landPrice As Integer
    Private _starved As Integer = 0
    Private _harvested As Integer
    Private _lostBushels As Integer
    Private _remainingBushels As Integer = _bushels
    Private _text(20) As String

    Private Sub GetLandPrice()
        _landPrice = Math.Round((Rnd() * 9) + 17, 0)
    End Sub

    Private Sub IncomingPeople()
        _IncomingPeople = Math.Round((Rnd() * 10), 0)
    End Sub

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Randomize()
        GetLandPrice()
        CalculateRemaining(False)
        ShowInfo()
    End Sub

    ' INFORMATION

    'Hammurabi: I beg To report To you,
    'In Year 1, 0 people starved.
    '5 people came to the city.
    'The city population Is now 100.
    'The city now owns 1000 acres.
    'You harvested 3 bushels per acre.
    'Rats ate 200 bushels.	 
    'You now have 2800 bushels In store.	
    '2800 bushels remaining
    'Land Is trading at 21 bushels per acre.

    Private Sub ShowInfo()
        _text(0) = "\b Hammurabi\b0: I beg To report To you,\line"
        _text(1) = "In Year \b " & _year & "\b0, \b " & _starved & " \b0 people starved.\line"
        _text(2) = "\b " & _IncomingPeople & " \b0 people came to the city.\line"
        _text(3) = String.Format("The city population Is now \b {0} \b0.\line", Format(_population, "#,##0"))
        _text(4) = String.Format("The city now owns \b {0} \b0 acres.\line", Format(_acresOwned, "#,##0"))
        _text(5) = String.Format("You harvested \b {0} \b0 bushels per acre.\line", Format(_harvested, "#,##0"))
        _text(6) = String.Format("Rats ate \b {0} \b0 bushels.\line", Format(_lostBushels, "#,##0"))
        _text(7) = String.Format("You now have \b {0} \b0 bushels In store.\line", Format(_bushels, "#,##0"))
        _text(8) = String.Format("\b {0} \b0 bushels remaining\line", Format(_remainingBushels, "#,##0"))
        _text(9) = "Land Is trading at \b " & _landPrice & " \b0 bushels per acre."

        _text(10) = "\b Hammurabi\b0: Us informo benvolgut senyor,\line"
        _text(11) = "En el any \b " & _year & "\b0, han mort \b " & _starved & " \b0 citudans.\line"
        _text(12) = String.Format("\b {0} \b0 persones estan {1} la ciutat.\line", Math.Abs(_IncomingPeople), IIf(_IncomingPeople < 0, "marxant de", "venint a"))
        _text(13) = String.Format("Tenim una població de \b {0} \b0 ciutadans.\line", Format(_population, "#,##0"))
        _text(14) = String.Format("La ciutat poseeix \b {0} \b0 acres de terra.\line", Format(_acresOwned, "#,##0"))
        _text(15) = String.Format("Hem collit \b {0} \b0 bushels per acre.\line", Format(_harvested, "#,##0"))
        _text(16) = String.Format("Les rates s'han menjat \b {0} \b0 bushels.\line", Format(_lostBushels, "#,##0"))
        _text(17) = String.Format("Als graners tenim \b {0} \b0 bushels enmagatzemats.\line", Format(_bushels, "#,##0"))
        _text(18) = String.Format("Disposem d'un total de \b {0} \b0 bushels, senyor.\line", Format(_remainingBushels, "#,##0"))
        _text(19) = "La terra es cotitza a \b " & _landPrice & " \b0 bushels per acre."

        Dim info As New System.Text.StringBuilder()
        info.AppendLine("{\rtf1\ansi")
        info.AppendLine(_text(10))
        info.AppendLine(_text(11))
        info.AppendLine(_text(12))
        info.AppendLine(_text(13))
        info.AppendLine(_text(14))
        info.AppendLine(_text(15))
        info.AppendLine(_text(16))
        info.AppendLine(_text(17))
        info.AppendLine(_text(18))
        info.AppendLine(_text(19))
        info.AppendLine("}")

        RichTextBox1.Rtf = info.ToString

    End Sub

    '    The Rules:

    'The game lasts 10 years, With a year being one turn.
    'Each year, enter how many bushels of grain to allocate to buying (Or selling) acres of land, feeding your population, And planting crops for the next year.
    'Each person needs 20 bushels of grain each year to live And can till at most 10 acres of land.
    'Each acre of land requires one bushel of grain to plant seeds.
    'The price Of Each acre Of land fluctuates from 17 bushels per acre To 26 bushels.
    'If the conditions In your country ever become bad enough, the people will overthrow you And you won't finish your 10 year term.
    'If you make it To the 11th year, your rule will be evaluated And you'll be ranked against great figures in history.

    Sub NextTurn()
        _year += 1
        CalcNewPopulation()
        CalcNewLand()

        _remainingBushels = _bushels

        NFeed.Value = 0
        NAcresBuyed.Value = 0
        NPlanted.Value = 0

        ShowInfo()
    End Sub

    Private Sub CalcNewLand()
        ' Acres owned
        _acresOwned += NAcresBuyed.Value

        ' Bushels harvested per acre
        _harvested = Math.Round(Rnd() * 4, 0) + 1
        _harvested = IIf(_acresOwned > 0, _harvested, 0)

        ' Calamities (rats at the moment)
        Dim lostPrcnt As Double = Rnd() * 50
        _lostBushels = Math.Round(_harvested * lostPrcnt, 0)

        ' Calc new bushels stock       (Formula: Bushels = Bushels + harvested - feeded - lostByCalamities)
        _bushels = _bushels - NFeed.Value + (_harvested * _acresOwned) - (NAcresBuyed.Value * _landPrice) - _lostBushels

        ' Get new land price
        GetLandPrice()
    End Sub

    Private Sub CalcNewPopulation()
        Dim needed As Integer = _population * 20
        If NFeed.Value = needed Then
            ' All citizens feeded
            _population += _IncomingPeople
            _IncomingPeople = Math.Round(Rnd() * 5, 0)
        End If

        If NFeed.Value < needed Then
            ' Not all
            _IncomingPeople = Math.Round(Rnd() * -10, 0)
            _starved = 10
            _population -= _starved
        End If

        If NFeed.Value > needed Then
            ' Obessed citizens!!
            _population += _IncomingPeople
            _IncomingPeople = Math.Round(Rnd() * 15, 0)
        End If
    End Sub

    Private Sub CalculateRemaining(Optional showWarnings As Boolean = True)
        ' Land buyed/selled
        If NAcresBuyed.Value < (_acresOwned * -1) Then
            If showWarnings Then MessageBox.Show("You only have " & _acresOwned & " acres!!")
            NAcresBuyed.Value = 0
            Exit Sub
        End If
        _remainingBushels = _bushels - (NAcresBuyed.Value * _landPrice)

        ' Feed people
        _remainingBushels -= NFeed.Value

        ' Land planted
        If NPlanted.Value > _acresOwned + NAcresBuyed.Value Then
            If showWarnings Then MessageBox.Show("You only have " & _acresOwned + NAcresBuyed.Value & " acres!!")
            NPlanted.Value = 0
        Else
            _remainingBushels -= NPlanted.Value
        End If

        If _remainingBushels > 0 Then NRemaining.Maximum = _remainingBushels
        If _remainingBushels < 0 Then NRemaining.Minimum = _remainingBushels

        NRemaining.Value = _remainingBushels
    End Sub

    Private Sub NAcresBuyed_ValueChanged(sender As Object, e As EventArgs) Handles NAcresBuyed.ValueChanged
        ' Acres buyed or selled
        CalculateRemaining()
    End Sub

    Private Sub NFeed_ValueChanged(sender As Object, e As EventArgs) Handles NFeed.ValueChanged
        ' bushes to people
        CalculateRemaining()
    End Sub

    Private Sub NPlanted_ValueChanged(sender As Object, e As EventArgs) Handles NPlanted.ValueChanged
        ' Plant seeds
        CalculateRemaining()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        NextTurn()
        'CalculateRemaining()
    End Sub

    Private Sub BtnFeedAll_Click(sender As Object, e As EventArgs) Handles BtnFeedAll.Click
        NFeed.Value = (_population + _IncomingPeople) * 20
    End Sub

    Private Sub BtnPlantAll_Click(sender As Object, e As EventArgs) Handles BtnPlantAll.Click
        NPlanted.Value = _acresOwned + NAcresBuyed.Value
    End Sub

    Private Sub ImgClose_Click(sender As Object, e As EventArgs) Handles ImgClose.Click
        Me.Close()
    End Sub
End Class