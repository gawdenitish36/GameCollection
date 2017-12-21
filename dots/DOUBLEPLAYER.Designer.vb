<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DOUBLEPLAYER
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.P1 = New System.Windows.Forms.Panel
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.PB_Preview2 = New System.Windows.Forms.PictureBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.CB_Image2 = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.PB_Preview = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.CB_Image = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.pname2_txt = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lbl_grid = New System.Windows.Forms.Label
        Me.Grid_size = New System.Windows.Forms.ComboBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lbl_pname = New System.Windows.Forms.Label
        Me.pname_txt = New System.Windows.Forms.TextBox
        Me.Btn_Play = New System.Windows.Forms.PictureBox
        Me.TM1 = New System.Windows.Forms.Timer(Me.components)
        Me.TM2 = New System.Windows.Forms.Timer(Me.components)
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.P1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.PB_Preview2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PB_Preview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Btn_Play, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'P1
        '
        Me.P1.Controls.Add(Me.GroupBox5)
        Me.P1.Controls.Add(Me.GroupBox4)
        Me.P1.Controls.Add(Me.GroupBox3)
        Me.P1.Controls.Add(Me.GroupBox2)
        Me.P1.Controls.Add(Me.GroupBox1)
        Me.P1.Controls.Add(Me.Btn_Play)
        Me.P1.Location = New System.Drawing.Point(2, 35)
        Me.P1.Name = "P1"
        Me.P1.Size = New System.Drawing.Size(685, 315)
        Me.P1.TabIndex = 0
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.PB_Preview2)
        Me.GroupBox5.Controls.Add(Me.Label5)
        Me.GroupBox5.Controls.Add(Me.CB_Image2)
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Location = New System.Drawing.Point(424, 123)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(240, 187)
        Me.GroupBox5.TabIndex = 18
        Me.GroupBox5.TabStop = False
        '
        'PB_Preview2
        '
        Me.PB_Preview2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PB_Preview2.Location = New System.Drawing.Point(135, 103)
        Me.PB_Preview2.Name = "PB_Preview2"
        Me.PB_Preview2.Size = New System.Drawing.Size(74, 61)
        Me.PB_Preview2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PB_Preview2.TabIndex = 11
        Me.PB_Preview2.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(47, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(144, 21)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Select Text Type:"
        '
        'CB_Image2
        '
        Me.CB_Image2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_Image2.Enabled = False
        Me.CB_Image2.FormattingEnabled = True
        Me.CB_Image2.Location = New System.Drawing.Point(41, 117)
        Me.CB_Image2.Name = "CB_Image2"
        Me.CB_Image2.Size = New System.Drawing.Size(66, 21)
        Me.CB_Image2.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(140, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 21)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Preview:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.PB_Preview)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.CB_Image)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Location = New System.Drawing.Point(23, 123)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(240, 187)
        Me.GroupBox4.TabIndex = 17
        Me.GroupBox4.TabStop = False
        '
        'PB_Preview
        '
        Me.PB_Preview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PB_Preview.Location = New System.Drawing.Point(129, 103)
        Me.PB_Preview.Name = "PB_Preview"
        Me.PB_Preview.Size = New System.Drawing.Size(74, 61)
        Me.PB_Preview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PB_Preview.TabIndex = 11
        Me.PB_Preview.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(41, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 21)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Select Text Type:"
        '
        'CB_Image
        '
        Me.CB_Image.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_Image.Enabled = False
        Me.CB_Image.FormattingEnabled = True
        Me.CB_Image.Location = New System.Drawing.Point(35, 117)
        Me.CB_Image.Name = "CB_Image"
        Me.CB_Image.Size = New System.Drawing.Size(66, 21)
        Me.CB_Image.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(134, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 21)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Preview:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.pname2_txt)
        Me.GroupBox3.Location = New System.Drawing.Point(424, 10)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(240, 100)
        Me.GroupBox3.TabIndex = 16
        Me.GroupBox3.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(41, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(150, 21)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Enter Your Name :"
        '
        'pname2_txt
        '
        Me.pname2_txt.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold)
        Me.pname2_txt.Location = New System.Drawing.Point(65, 53)
        Me.pname2_txt.MaxLength = 8
        Me.pname2_txt.Name = "pname2_txt"
        Me.pname2_txt.Size = New System.Drawing.Size(108, 28)
        Me.pname2_txt.TabIndex = 4
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lbl_grid)
        Me.GroupBox2.Controls.Add(Me.Grid_size)
        Me.GroupBox2.Location = New System.Drawing.Point(269, 10)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(149, 117)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        '
        'lbl_grid
        '
        Me.lbl_grid.AutoSize = True
        Me.lbl_grid.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lbl_grid.ForeColor = System.Drawing.Color.White
        Me.lbl_grid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbl_grid.Location = New System.Drawing.Point(25, 31)
        Me.lbl_grid.Name = "lbl_grid"
        Me.lbl_grid.Size = New System.Drawing.Size(91, 21)
        Me.lbl_grid.TabIndex = 2
        Me.lbl_grid.Text = "Grid Size :"
        '
        'Grid_size
        '
        Me.Grid_size.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Grid_size.Enabled = False
        Me.Grid_size.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Grid_size.FormattingEnabled = True
        Me.Grid_size.Items.AddRange(New Object() {"5x5", "6x6", "7x7", "8x8", "9x9", "10x10"})
        Me.Grid_size.Location = New System.Drawing.Point(34, 63)
        Me.Grid_size.Name = "Grid_size"
        Me.Grid_size.Size = New System.Drawing.Size(73, 29)
        Me.Grid_size.TabIndex = 3
        Me.Grid_size.Tag = ""
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbl_pname)
        Me.GroupBox1.Controls.Add(Me.pname_txt)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(240, 100)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        '
        'lbl_pname
        '
        Me.lbl_pname.AutoSize = True
        Me.lbl_pname.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lbl_pname.ForeColor = System.Drawing.Color.White
        Me.lbl_pname.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbl_pname.Location = New System.Drawing.Point(41, 21)
        Me.lbl_pname.Name = "lbl_pname"
        Me.lbl_pname.Size = New System.Drawing.Size(150, 21)
        Me.lbl_pname.TabIndex = 5
        Me.lbl_pname.Text = "Enter Your Name :"
        '
        'pname_txt
        '
        Me.pname_txt.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold)
        Me.pname_txt.Location = New System.Drawing.Point(65, 50)
        Me.pname_txt.MaxLength = 8
        Me.pname_txt.Name = "pname_txt"
        Me.pname_txt.Size = New System.Drawing.Size(108, 28)
        Me.pname_txt.TabIndex = 4
        '
        'Btn_Play
        '
        Me.Btn_Play.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Play.Image = Global.dots.My.Resources.Resources.p1
        Me.Btn_Play.Location = New System.Drawing.Point(269, 157)
        Me.Btn_Play.Name = "Btn_Play"
        Me.Btn_Play.Size = New System.Drawing.Size(149, 153)
        Me.Btn_Play.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Btn_Play.TabIndex = 9
        Me.Btn_Play.TabStop = False
        Me.Btn_Play.Visible = False
        '
        'TM1
        '
        Me.TM1.Interval = 1
        '
        'TM2
        '
        Me.TM2.Interval = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(117, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 21)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Player 1"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(511, 8)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 21)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Player 2"
        '
        'DOUBLEPLAYER
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(691, 358)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.P1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "DOUBLEPLAYER"
        Me.Opacity = 0.7
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.P1.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.PB_Preview2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.PB_Preview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Btn_Play, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents P1 As System.Windows.Forms.Panel
    Friend WithEvents TM1 As System.Windows.Forms.Timer
    Friend WithEvents TM2 As System.Windows.Forms.Timer
    Friend WithEvents lbl_pname As System.Windows.Forms.Label
    Friend WithEvents pname_txt As System.Windows.Forms.TextBox
    Friend WithEvents PB_Preview As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CB_Image As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Btn_Play As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents pname2_txt As System.Windows.Forms.TextBox
    Friend WithEvents PB_Preview2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CB_Image2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lbl_grid As System.Windows.Forms.Label
    Friend WithEvents Grid_size As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
End Class
