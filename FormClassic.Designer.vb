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
        Me.NAcresBuyed = New System.Windows.Forms.NumericUpDown()
        Me.NFeed = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NPlanted = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.NRemaining = New System.Windows.Forms.NumericUpDown()
        Me.BtnFeedAll = New System.Windows.Forms.Button()
        Me.BtnPlantAll = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ImgClose = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.NAcresBuyed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NFeed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NPlanted, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NRemaining, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.ImgClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.SystemColors.Info
        Me.Label1.Location = New System.Drawing.Point(32, 420)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(354, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "How many acres do you wish to buy or sell?"
        '
        'NAcresBuyed
        '
        Me.NAcresBuyed.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.NAcresBuyed.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.NAcresBuyed.Location = New System.Drawing.Point(462, 418)
        Me.NAcresBuyed.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.NAcresBuyed.Minimum = New Decimal(New Integer() {10000, 0, 0, -2147483648})
        Me.NAcresBuyed.Name = "NAcresBuyed"
        Me.NAcresBuyed.Size = New System.Drawing.Size(101, 27)
        Me.NAcresBuyed.TabIndex = 2
        Me.NAcresBuyed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'NFeed
        '
        Me.NFeed.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.NFeed.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.NFeed.Location = New System.Drawing.Point(462, 466)
        Me.NFeed.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.NFeed.Name = "NFeed"
        Me.NFeed.Size = New System.Drawing.Size(101, 27)
        Me.NFeed.TabIndex = 4
        Me.NFeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.SystemColors.Info
        Me.Label2.Location = New System.Drawing.Point(32, 468)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(423, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "How many bushels do you wish to feed your people?"
        '
        'NPlanted
        '
        Me.NPlanted.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.NPlanted.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.NPlanted.Location = New System.Drawing.Point(462, 521)
        Me.NPlanted.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.NPlanted.Name = "NPlanted"
        Me.NPlanted.Size = New System.Drawing.Size(101, 27)
        Me.NPlanted.TabIndex = 6
        Me.NPlanted.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.SystemColors.Info
        Me.Label3.Location = New System.Drawing.Point(32, 523)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(392, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "How many acres do you wish to plant with seed?"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(519, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(592, 204)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = resources.GetString("Label4.Text")
        Me.Label4.Visible = False
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.RichTextBox1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RichTextBox1.ForeColor = System.Drawing.SystemColors.Info
        Me.RichTextBox1.Location = New System.Drawing.Point(21, 65)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(466, 296)
        Me.RichTextBox1.TabIndex = 8
        Me.RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.Button1.Location = New System.Drawing.Point(462, 575)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(237, 42)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.SystemColors.Info
        Me.Label5.Location = New System.Drawing.Point(706, 418)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(159, 20)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Bushels remaining"
        '
        'NRemaining
        '
        Me.NRemaining.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.NRemaining.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.NRemaining.Location = New System.Drawing.Point(608, 418)
        Me.NRemaining.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.NRemaining.Name = "NRemaining"
        Me.NRemaining.ReadOnly = True
        Me.NRemaining.Size = New System.Drawing.Size(91, 27)
        Me.NRemaining.TabIndex = 2
        Me.NRemaining.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'BtnFeedAll
        '
        Me.BtnFeedAll.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BtnFeedAll.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.BtnFeedAll.Location = New System.Drawing.Point(608, 466)
        Me.BtnFeedAll.Name = "BtnFeedAll"
        Me.BtnFeedAll.Size = New System.Drawing.Size(91, 27)
        Me.BtnFeedAll.TabIndex = 10
        Me.BtnFeedAll.Text = "Feed all"
        Me.BtnFeedAll.UseVisualStyleBackColor = False
        '
        'BtnPlantAll
        '
        Me.BtnPlantAll.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BtnPlantAll.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.BtnPlantAll.Location = New System.Drawing.Point(608, 521)
        Me.BtnPlantAll.Name = "BtnPlantAll"
        Me.BtnPlantAll.Size = New System.Drawing.Size(91, 27)
        Me.BtnPlantAll.TabIndex = 10
        Me.BtnPlantAll.Text = "Plant all"
        Me.BtnPlantAll.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Blue
        Me.Panel1.Controls.Add(Me.ImgClose)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1143, 34)
        Me.Panel1.TabIndex = 14
        '
        'ImgClose
        '
        Me.ImgClose.Image = Global.Amok_Rabi.My.Resources.Resources.Button_Close_icon
        Me.ImgClose.Location = New System.Drawing.Point(1108, 0)
        Me.ImgClose.Name = "ImgClose"
        Me.ImgClose.Size = New System.Drawing.Size(32, 34)
        Me.ImgClose.TabIndex = 0
        Me.ImgClose.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(519, 65)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(547, 221)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = resources.GetString("Label6.Text")
        '
        'FormClassic
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1143, 630)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BtnPlantAll)
        Me.Controls.Add(Me.BtnFeedAll)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.NPlanted)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.NFeed)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.NRemaining)
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
        Me.Text = "FormClassic"
        CType(Me.NAcresBuyed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NFeed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NPlanted, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NRemaining, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.ImgClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents NAcresBuyed As NumericUpDown
    Friend WithEvents NFeed As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents NPlanted As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents NRemaining As NumericUpDown
    Friend WithEvents BtnFeedAll As Button
    Friend WithEvents BtnPlantAll As Button
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ImgClose As PictureBox
    Friend WithEvents Label6 As Label
End Class
