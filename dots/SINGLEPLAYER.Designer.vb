<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SINGLEPLAYER
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.CB_Image = New System.Windows.Forms.ComboBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.pname_txt = New System.Windows.Forms.TextBox
        Me.lbl_pname = New System.Windows.Forms.Label
        Me.P2 = New System.Windows.Forms.Panel
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.lbl_grid = New System.Windows.Forms.Label
        Me.Grid_size = New System.Windows.Forms.ComboBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.RDB_HARD = New System.Windows.Forms.RadioButton
        Me.lbl_level = New System.Windows.Forms.Label
        Me.RDB_NORMAL = New System.Windows.Forms.RadioButton
        Me.RDB_EASY = New System.Windows.Forms.RadioButton
        Me.TM1 = New System.Windows.Forms.Timer(Me.components)
        Me.TM2 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.PictureBox4 = New System.Windows.Forms.PictureBox
        Me.PB_Preview = New System.Windows.Forms.PictureBox
        Me.PB_nxt = New System.Windows.Forms.PictureBox
        Me.P1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.P2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_Preview, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_nxt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'P1
        '
        Me.P1.Controls.Add(Me.GroupBox2)
        Me.P1.Controls.Add(Me.GroupBox1)
        Me.P1.Controls.Add(Me.PB_nxt)
        Me.P1.Location = New System.Drawing.Point(13, 9)
        Me.P1.Name = "P1"
        Me.P1.Size = New System.Drawing.Size(283, 428)
        Me.P1.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PB_Preview)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.CB_Image)
        Me.GroupBox2.Location = New System.Drawing.Point(23, 138)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(240, 196)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(42, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 21)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Select Text Type:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(135, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 21)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Preview:"
        '
        'CB_Image
        '
        Me.CB_Image.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_Image.Enabled = False
        Me.CB_Image.FormattingEnabled = True
        Me.CB_Image.Location = New System.Drawing.Point(36, 109)
        Me.CB_Image.Name = "CB_Image"
        Me.CB_Image.Size = New System.Drawing.Size(66, 21)
        Me.CB_Image.TabIndex = 9
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.pname_txt)
        Me.GroupBox1.Controls.Add(Me.lbl_pname)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(240, 100)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        '
        'pname_txt
        '
        Me.pname_txt.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold)
        Me.pname_txt.Location = New System.Drawing.Point(66, 44)
        Me.pname_txt.MaxLength = 8
        Me.pname_txt.Name = "pname_txt"
        Me.pname_txt.ShortcutsEnabled = False
        Me.pname_txt.Size = New System.Drawing.Size(108, 28)
        Me.pname_txt.TabIndex = 4
        '
        'lbl_pname
        '
        Me.lbl_pname.AutoSize = True
        Me.lbl_pname.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lbl_pname.ForeColor = System.Drawing.Color.White
        Me.lbl_pname.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbl_pname.Location = New System.Drawing.Point(42, 15)
        Me.lbl_pname.Name = "lbl_pname"
        Me.lbl_pname.Size = New System.Drawing.Size(150, 21)
        Me.lbl_pname.TabIndex = 5
        Me.lbl_pname.Text = "Enter Your Name :"
        '
        'P2
        '
        Me.P2.Controls.Add(Me.GroupBox4)
        Me.P2.Controls.Add(Me.GroupBox3)
        Me.P2.Controls.Add(Me.PictureBox4)
        Me.P2.Location = New System.Drawing.Point(302, 9)
        Me.P2.Name = "P2"
        Me.P2.Size = New System.Drawing.Size(10, 428)
        Me.P2.TabIndex = 4
        Me.P2.Visible = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lbl_grid)
        Me.GroupBox4.Controls.Add(Me.Grid_size)
        Me.GroupBox4.Location = New System.Drawing.Point(16, 274)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(248, 72)
        Me.GroupBox4.TabIndex = 5
        Me.GroupBox4.TabStop = False
        '
        'lbl_grid
        '
        Me.lbl_grid.AutoSize = True
        Me.lbl_grid.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lbl_grid.ForeColor = System.Drawing.Color.White
        Me.lbl_grid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbl_grid.Location = New System.Drawing.Point(31, 27)
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
        Me.Grid_size.Location = New System.Drawing.Point(128, 24)
        Me.Grid_size.Name = "Grid_size"
        Me.Grid_size.Size = New System.Drawing.Size(73, 29)
        Me.Grid_size.TabIndex = 3
        Me.Grid_size.Tag = ""
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RDB_HARD)
        Me.GroupBox3.Controls.Add(Me.lbl_level)
        Me.GroupBox3.Controls.Add(Me.RDB_NORMAL)
        Me.GroupBox3.Controls.Add(Me.PictureBox1)
        Me.GroupBox3.Controls.Add(Me.RDB_EASY)
        Me.GroupBox3.Controls.Add(Me.PictureBox2)
        Me.GroupBox3.Controls.Add(Me.PictureBox3)
        Me.GroupBox3.Location = New System.Drawing.Point(16, 5)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(248, 263)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        '
        'RDB_HARD
        '
        Me.RDB_HARD.AutoSize = True
        Me.RDB_HARD.Location = New System.Drawing.Point(201, 212)
        Me.RDB_HARD.Name = "RDB_HARD"
        Me.RDB_HARD.Size = New System.Drawing.Size(14, 13)
        Me.RDB_HARD.TabIndex = 9
        Me.RDB_HARD.TabStop = True
        Me.RDB_HARD.UseVisualStyleBackColor = True
        '
        'lbl_level
        '
        Me.lbl_level.AutoSize = True
        Me.lbl_level.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lbl_level.ForeColor = System.Drawing.Color.White
        Me.lbl_level.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbl_level.Location = New System.Drawing.Point(71, 16)
        Me.lbl_level.Name = "lbl_level"
        Me.lbl_level.Size = New System.Drawing.Size(111, 21)
        Me.lbl_level.TabIndex = 8
        Me.lbl_level.Text = "Select Level :"
        '
        'RDB_NORMAL
        '
        Me.RDB_NORMAL.AutoSize = True
        Me.RDB_NORMAL.Location = New System.Drawing.Point(201, 139)
        Me.RDB_NORMAL.Name = "RDB_NORMAL"
        Me.RDB_NORMAL.Size = New System.Drawing.Size(14, 13)
        Me.RDB_NORMAL.TabIndex = 9
        Me.RDB_NORMAL.TabStop = True
        Me.RDB_NORMAL.UseVisualStyleBackColor = True
        '
        'RDB_EASY
        '
        Me.RDB_EASY.AutoSize = True
        Me.RDB_EASY.Location = New System.Drawing.Point(201, 61)
        Me.RDB_EASY.Name = "RDB_EASY"
        Me.RDB_EASY.Size = New System.Drawing.Size(14, 13)
        Me.RDB_EASY.TabIndex = 9
        Me.RDB_EASY.TabStop = True
        Me.RDB_EASY.UseVisualStyleBackColor = True
        '
        'TM1
        '
        Me.TM1.Interval = 1
        '
        'TM2
        '
        Me.TM2.Interval = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.dots.My.Resources.Resources.easy
        Me.PictureBox1.Location = New System.Drawing.Point(25, 50)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(143, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.dots.My.Resources.Resources.Normal
        Me.PictureBox2.Location = New System.Drawing.Point(25, 118)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(143, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.dots.My.Resources.Resources.hard
        Me.PictureBox3.Location = New System.Drawing.Point(25, 192)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(143, 50)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 0
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox4.Image = Global.dots.My.Resources.Resources.p1
        Me.PictureBox4.Location = New System.Drawing.Point(72, 352)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(140, 60)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 9
        Me.PictureBox4.TabStop = False
        Me.PictureBox4.Visible = False
        '
        'PB_Preview
        '
        Me.PB_Preview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PB_Preview.Location = New System.Drawing.Point(130, 95)
        Me.PB_Preview.Name = "PB_Preview"
        Me.PB_Preview.Size = New System.Drawing.Size(74, 61)
        Me.PB_Preview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PB_Preview.TabIndex = 11
        Me.PB_Preview.TabStop = False
        '
        'PB_nxt
        '
        Me.PB_nxt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PB_nxt.Image = Global.dots.My.Resources.Resources.n2
        Me.PB_nxt.Location = New System.Drawing.Point(95, 356)
        Me.PB_nxt.Name = "PB_nxt"
        Me.PB_nxt.Size = New System.Drawing.Size(100, 50)
        Me.PB_nxt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PB_nxt.TabIndex = 7
        Me.PB_nxt.TabStop = False
        Me.PB_nxt.Visible = False
        '
        'SINGLEPLAYER
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(309, 444)
        Me.Controls.Add(Me.P2)
        Me.Controls.Add(Me.P1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "SINGLEPLAYER"
        Me.Opacity = 0.7
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.P1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.P2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_Preview, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_nxt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents P1 As System.Windows.Forms.Panel
    Friend WithEvents P2 As System.Windows.Forms.Panel
    Friend WithEvents TM1 As System.Windows.Forms.Timer
    Friend WithEvents TM2 As System.Windows.Forms.Timer
    Friend WithEvents lbl_pname As System.Windows.Forms.Label
    Friend WithEvents pname_txt As System.Windows.Forms.TextBox
    Friend WithEvents PB_nxt As System.Windows.Forms.PictureBox
    Friend WithEvents Grid_size As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_grid As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_level As System.Windows.Forms.Label
    Friend WithEvents RDB_HARD As System.Windows.Forms.RadioButton
    Friend WithEvents RDB_NORMAL As System.Windows.Forms.RadioButton
    Friend WithEvents RDB_EASY As System.Windows.Forms.RadioButton
    Friend WithEvents PB_Preview As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CB_Image As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
End Class
