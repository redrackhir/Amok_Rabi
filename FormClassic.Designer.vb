<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormClassic
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormClassic))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NFeed = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NPlanted = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnFeedAll = New System.Windows.Forms.Button()
        Me.BtnPlantAll = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ImgClose = New System.Windows.Forms.PictureBox()
        Me.NAcresBuyed = New System.Windows.Forms.NumericUpDown()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.Button16 = New System.Windows.Forms.Button()
        Me.Button17 = New System.Windows.Forms.Button()
        Me.Button18 = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Button19 = New System.Windows.Forms.Button()
        Me.Button20 = New System.Windows.Forms.Button()
        Me.Button21 = New System.Windows.Forms.Button()
        Me.Button22 = New System.Windows.Forms.Button()
        Me.Button23 = New System.Windows.Forms.Button()
        Me.Button24 = New System.Windows.Forms.Button()
        Me.Button25 = New System.Windows.Forms.Button()
        Me.Button26 = New System.Windows.Forms.Button()
        CType(Me.NFeed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NPlanted, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NAcresBuyed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.SystemColors.Info
        Me.Label1.Location = New System.Drawing.Point(21, 343)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(354, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "How many acres do you wish to buy or sell?"
        '
        'NFeed
        '
        Me.NFeed.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.NFeed.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.NFeed.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.NFeed.Location = New System.Drawing.Point(451, 435)
        Me.NFeed.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.NFeed.Name = "NFeed"
        Me.NFeed.Size = New System.Drawing.Size(101, 37)
        Me.NFeed.TabIndex = 4
        Me.NFeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.SystemColors.Info
        Me.Label2.Location = New System.Drawing.Point(21, 444)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(423, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "How many bushels do you wish to feed your people?"
        '
        'NPlanted
        '
        Me.NPlanted.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.NPlanted.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.NPlanted.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.NPlanted.Location = New System.Drawing.Point(451, 522)
        Me.NPlanted.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.NPlanted.Name = "NPlanted"
        Me.NPlanted.Size = New System.Drawing.Size(101, 37)
        Me.NPlanted.TabIndex = 6
        Me.NPlanted.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.SystemColors.Info
        Me.Label3.Location = New System.Drawing.Point(21, 533)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(392, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "How many acres do you wish to plant with seed?"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.RichTextBox1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RichTextBox1.ForeColor = System.Drawing.SystemColors.Info
        Me.RichTextBox1.Location = New System.Drawing.Point(21, 65)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(466, 242)
        Me.RichTextBox1.TabIndex = 8
        Me.RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.Button1.Location = New System.Drawing.Point(368, 600)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(475, 42)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Next turn"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.SystemColors.Info
        Me.Label5.Location = New System.Drawing.Point(870, 343)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(159, 20)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Bushels remaining"
        '
        'BtnFeedAll
        '
        Me.BtnFeedAll.AutoSize = True
        Me.BtnFeedAll.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BtnFeedAll.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.BtnFeedAll.Location = New System.Drawing.Point(815, 440)
        Me.BtnFeedAll.Name = "BtnFeedAll"
        Me.BtnFeedAll.Size = New System.Drawing.Size(141, 31)
        Me.BtnFeedAll.TabIndex = 10
        Me.BtnFeedAll.Text = "Feed all"
        Me.BtnFeedAll.UseVisualStyleBackColor = False
        '
        'BtnPlantAll
        '
        Me.BtnPlantAll.AutoSize = True
        Me.BtnPlantAll.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BtnPlantAll.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.BtnPlantAll.Location = New System.Drawing.Point(815, 512)
        Me.BtnPlantAll.Name = "BtnPlantAll"
        Me.BtnPlantAll.Size = New System.Drawing.Size(141, 31)
        Me.BtnPlantAll.TabIndex = 10
        Me.BtnPlantAll.Text = "Plant all"
        Me.BtnPlantAll.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DeepPink
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.ImgClose)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1143, 34)
        Me.Panel1.TabIndex = 14
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(1070, 1)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 34)
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.PictureBox1.Size = New System.Drawing.Size(32, 34)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(45, 7)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(172, 19)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Hammurabi - Classic"
        '
        'ImgClose
        '
        Me.ImgClose.Image = CType(resources.GetObject("ImgClose.Image"), System.Drawing.Image)
        Me.ImgClose.Location = New System.Drawing.Point(1108, 0)
        Me.ImgClose.Name = "ImgClose"
        Me.ImgClose.Size = New System.Drawing.Size(32, 34)
        Me.ImgClose.TabIndex = 0
        Me.ImgClose.TabStop = False
        '
        'NAcresBuyed
        '
        Me.NAcresBuyed.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.NAcresBuyed.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.NAcresBuyed.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.NAcresBuyed.Location = New System.Drawing.Point(451, 332)
        Me.NAcresBuyed.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.NAcresBuyed.Minimum = New Decimal(New Integer() {10000, 0, 0, -2147483648})
        Me.NAcresBuyed.Name = "NAcresBuyed"
        Me.NAcresBuyed.Size = New System.Drawing.Size(101, 37)
        Me.NAcresBuyed.TabIndex = 2
        Me.NAcresBuyed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Button6)
        Me.Panel2.Controls.Add(Me.Button7)
        Me.Panel2.Controls.Add(Me.Button8)
        Me.Panel2.Controls.Add(Me.Button9)
        Me.Panel2.Controls.Add(Me.Button5)
        Me.Panel2.Controls.Add(Me.Button4)
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Location = New System.Drawing.Point(568, 321)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(229, 74)
        Me.Panel2.TabIndex = 16
        '
        'Button6
        '
        Me.Button6.AutoSize = True
        Me.Button6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button6.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Button6.Location = New System.Drawing.Point(162, 39)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(65, 32)
        Me.Button6.TabIndex = 8
        Me.Button6.Text = "-1000"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.AutoSize = True
        Me.Button7.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button7.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Button7.Location = New System.Drawing.Point(100, 39)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(56, 32)
        Me.Button7.TabIndex = 7
        Me.Button7.Text = "-100"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.AutoSize = True
        Me.Button8.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button8.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Button8.Location = New System.Drawing.Point(47, 39)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(47, 32)
        Me.Button8.TabIndex = 6
        Me.Button8.Text = "-10"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.AutoSize = True
        Me.Button9.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button9.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Button9.Location = New System.Drawing.Point(3, 39)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(38, 32)
        Me.Button9.TabIndex = 5
        Me.Button9.Text = "-1"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.AutoSize = True
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button5.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Button5.Location = New System.Drawing.Point(162, 3)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(65, 32)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "+1000"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.AutoSize = True
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button4.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Button4.Location = New System.Drawing.Point(100, 3)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(56, 32)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "+100"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.AutoSize = True
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button3.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Button3.Location = New System.Drawing.Point(47, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(47, 32)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "+10"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.AutoSize = True
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button2.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Button2.Location = New System.Drawing.Point(3, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(38, 32)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "+1"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button10
        '
        Me.Button10.AutoSize = True
        Me.Button10.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Button10.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.Button10.Location = New System.Drawing.Point(815, 548)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(141, 31)
        Me.Button10.TabIndex = 17
        Me.Button10.Text = "Plant remain"
        Me.Button10.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Button11)
        Me.Panel3.Controls.Add(Me.Button12)
        Me.Panel3.Controls.Add(Me.Button13)
        Me.Panel3.Controls.Add(Me.Button14)
        Me.Panel3.Controls.Add(Me.Button15)
        Me.Panel3.Controls.Add(Me.Button16)
        Me.Panel3.Controls.Add(Me.Button17)
        Me.Panel3.Controls.Add(Me.Button18)
        Me.Panel3.Location = New System.Drawing.Point(568, 418)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(229, 74)
        Me.Panel3.TabIndex = 18
        '
        'Button11
        '
        Me.Button11.AutoSize = True
        Me.Button11.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button11.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Button11.Location = New System.Drawing.Point(162, 39)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(65, 32)
        Me.Button11.TabIndex = 8
        Me.Button11.Text = "-1000"
        Me.Button11.UseVisualStyleBackColor = False
        '
        'Button12
        '
        Me.Button12.AutoSize = True
        Me.Button12.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button12.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Button12.Location = New System.Drawing.Point(100, 39)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(56, 32)
        Me.Button12.TabIndex = 7
        Me.Button12.Text = "-100"
        Me.Button12.UseVisualStyleBackColor = False
        '
        'Button13
        '
        Me.Button13.AutoSize = True
        Me.Button13.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button13.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Button13.Location = New System.Drawing.Point(47, 39)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(47, 32)
        Me.Button13.TabIndex = 6
        Me.Button13.Text = "-10"
        Me.Button13.UseVisualStyleBackColor = False
        '
        'Button14
        '
        Me.Button14.AutoSize = True
        Me.Button14.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button14.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Button14.Location = New System.Drawing.Point(3, 39)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(38, 32)
        Me.Button14.TabIndex = 5
        Me.Button14.Text = "-1"
        Me.Button14.UseVisualStyleBackColor = False
        '
        'Button15
        '
        Me.Button15.AutoSize = True
        Me.Button15.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button15.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Button15.Location = New System.Drawing.Point(162, 3)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(65, 32)
        Me.Button15.TabIndex = 4
        Me.Button15.Text = "+1000"
        Me.Button15.UseVisualStyleBackColor = False
        '
        'Button16
        '
        Me.Button16.AutoSize = True
        Me.Button16.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button16.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Button16.Location = New System.Drawing.Point(100, 3)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(56, 32)
        Me.Button16.TabIndex = 3
        Me.Button16.Text = "+100"
        Me.Button16.UseVisualStyleBackColor = False
        '
        'Button17
        '
        Me.Button17.AutoSize = True
        Me.Button17.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button17.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Button17.Location = New System.Drawing.Point(47, 3)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(47, 32)
        Me.Button17.TabIndex = 2
        Me.Button17.Text = "+10"
        Me.Button17.UseVisualStyleBackColor = False
        '
        'Button18
        '
        Me.Button18.AutoSize = True
        Me.Button18.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button18.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Button18.Location = New System.Drawing.Point(3, 3)
        Me.Button18.Name = "Button18"
        Me.Button18.Size = New System.Drawing.Size(38, 32)
        Me.Button18.TabIndex = 1
        Me.Button18.Text = "+1"
        Me.Button18.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Button19)
        Me.Panel4.Controls.Add(Me.Button20)
        Me.Panel4.Controls.Add(Me.Button21)
        Me.Panel4.Controls.Add(Me.Button22)
        Me.Panel4.Controls.Add(Me.Button23)
        Me.Panel4.Controls.Add(Me.Button24)
        Me.Panel4.Controls.Add(Me.Button25)
        Me.Panel4.Controls.Add(Me.Button26)
        Me.Panel4.Location = New System.Drawing.Point(568, 508)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(229, 74)
        Me.Panel4.TabIndex = 19
        '
        'Button19
        '
        Me.Button19.AutoSize = True
        Me.Button19.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button19.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Button19.Location = New System.Drawing.Point(162, 39)
        Me.Button19.Name = "Button19"
        Me.Button19.Size = New System.Drawing.Size(65, 32)
        Me.Button19.TabIndex = 8
        Me.Button19.Text = "-1000"
        Me.Button19.UseVisualStyleBackColor = False
        '
        'Button20
        '
        Me.Button20.AutoSize = True
        Me.Button20.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button20.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Button20.Location = New System.Drawing.Point(100, 39)
        Me.Button20.Name = "Button20"
        Me.Button20.Size = New System.Drawing.Size(56, 32)
        Me.Button20.TabIndex = 7
        Me.Button20.Text = "-100"
        Me.Button20.UseVisualStyleBackColor = False
        '
        'Button21
        '
        Me.Button21.AutoSize = True
        Me.Button21.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button21.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Button21.Location = New System.Drawing.Point(47, 39)
        Me.Button21.Name = "Button21"
        Me.Button21.Size = New System.Drawing.Size(47, 32)
        Me.Button21.TabIndex = 6
        Me.Button21.Text = "-10"
        Me.Button21.UseVisualStyleBackColor = False
        '
        'Button22
        '
        Me.Button22.AutoSize = True
        Me.Button22.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button22.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Button22.Location = New System.Drawing.Point(3, 39)
        Me.Button22.Name = "Button22"
        Me.Button22.Size = New System.Drawing.Size(38, 32)
        Me.Button22.TabIndex = 5
        Me.Button22.Text = "-1"
        Me.Button22.UseVisualStyleBackColor = False
        '
        'Button23
        '
        Me.Button23.AutoSize = True
        Me.Button23.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button23.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Button23.Location = New System.Drawing.Point(162, 3)
        Me.Button23.Name = "Button23"
        Me.Button23.Size = New System.Drawing.Size(65, 32)
        Me.Button23.TabIndex = 4
        Me.Button23.Text = "+1000"
        Me.Button23.UseVisualStyleBackColor = False
        '
        'Button24
        '
        Me.Button24.AutoSize = True
        Me.Button24.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button24.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Button24.Location = New System.Drawing.Point(100, 3)
        Me.Button24.Name = "Button24"
        Me.Button24.Size = New System.Drawing.Size(56, 32)
        Me.Button24.TabIndex = 3
        Me.Button24.Text = "+100"
        Me.Button24.UseVisualStyleBackColor = False
        '
        'Button25
        '
        Me.Button25.AutoSize = True
        Me.Button25.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button25.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Button25.Location = New System.Drawing.Point(47, 3)
        Me.Button25.Name = "Button25"
        Me.Button25.Size = New System.Drawing.Size(47, 32)
        Me.Button25.TabIndex = 2
        Me.Button25.Text = "+10"
        Me.Button25.UseVisualStyleBackColor = False
        '
        'Button26
        '
        Me.Button26.AutoSize = True
        Me.Button26.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button26.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Button26.Location = New System.Drawing.Point(3, 3)
        Me.Button26.Name = "Button26"
        Me.Button26.Size = New System.Drawing.Size(38, 32)
        Me.Button26.TabIndex = 1
        Me.Button26.Text = "+1"
        Me.Button26.UseVisualStyleBackColor = False
        '
        'FormClassic
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1143, 700)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BtnPlantAll)
        Me.Controls.Add(Me.BtnFeedAll)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.NPlanted)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.NFeed)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.NAcresBuyed)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormClassic"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormClassic"
        CType(Me.NFeed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NPlanted, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NAcresBuyed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents NFeed As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents NPlanted As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents BtnFeedAll As Button
    Friend WithEvents BtnPlantAll As Button
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ImgClose As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents NAcresBuyed As NumericUpDown
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button11 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents Button13 As Button
    Friend WithEvents Button14 As Button
    Friend WithEvents Button15 As Button
    Friend WithEvents Button16 As Button
    Friend WithEvents Button17 As Button
    Friend WithEvents Button18 As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Button19 As Button
    Friend WithEvents Button20 As Button
    Friend WithEvents Button21 As Button
    Friend WithEvents Button22 As Button
    Friend WithEvents Button23 As Button
    Friend WithEvents Button24 As Button
    Friend WithEvents Button25 As Button
    Friend WithEvents Button26 As Button
    Friend WithEvents PictureBox2 As PictureBox
End Class
