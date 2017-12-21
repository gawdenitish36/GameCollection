<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainShooter
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainShooter))
        Me.PNl_Board = New System.Windows.Forms.Panel
        Me.Pnl_Main_Board = New System.Windows.Forms.Panel
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PNL_Board_Side = New System.Windows.Forms.Panel
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lbl_fird = New System.Windows.Forms.Label
        Me.lbl_trt = New System.Windows.Forms.Label
        Me.lbl_cvil = New System.Windows.Forms.Label
        Me.lbl_blank = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GBWanted = New System.Windows.Forms.GroupBox
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TimeSloat = New System.Windows.Forms.Timer(Me.components)
        Me.PNl_Board.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.PNL_Board_Side.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PNl_Board
        '
        Me.PNl_Board.BackColor = System.Drawing.Color.Silver
        Me.PNl_Board.Controls.Add(Me.Pnl_Main_Board)
        Me.PNl_Board.Controls.Add(Me.MenuStrip1)
        Me.PNl_Board.Dock = System.Windows.Forms.DockStyle.Left
        Me.PNl_Board.ForeColor = System.Drawing.Color.Maroon
        Me.PNl_Board.Location = New System.Drawing.Point(0, 0)
        Me.PNl_Board.Name = "PNl_Board"
        Me.PNl_Board.Size = New System.Drawing.Size(477, 640)
        Me.PNl_Board.TabIndex = 0
        '
        'Pnl_Main_Board
        '
        Me.Pnl_Main_Board.BackColor = System.Drawing.Color.White
        Me.Pnl_Main_Board.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Pnl_Main_Board.Location = New System.Drawing.Point(124, 169)
        Me.Pnl_Main_Board.Name = "Pnl_Main_Board"
        Me.Pnl_Main_Board.Size = New System.Drawing.Size(200, 100)
        Me.Pnl_Main_Board.TabIndex = 0
        Me.Pnl_Main_Board.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Green
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(477, 29)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.ToolStripSeparator1, Me.OptionsToolStripMenuItem, Me.ToolStripSeparator2, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(66, 25)
        Me.FileToolStripMenuItem.Text = "Game"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.BackColor = System.Drawing.Color.Green
        Me.NewToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(169, 26)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(166, 6)
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.BackColor = System.Drawing.Color.Green
        Me.OptionsToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(169, 26)
        Me.OptionsToolStripMenuItem.Text = "Options"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(166, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.BackColor = System.Drawing.Color.Green
        Me.ExitToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(169, 26)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.HelpToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(58, 25)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'PNL_Board_Side
        '
        Me.PNL_Board_Side.BackColor = System.Drawing.Color.Green
        Me.PNL_Board_Side.Controls.Add(Me.GroupBox1)
        Me.PNL_Board_Side.Controls.Add(Me.GBWanted)
        Me.PNL_Board_Side.Dock = System.Windows.Forms.DockStyle.Right
        Me.PNL_Board_Side.Location = New System.Drawing.Point(465, 0)
        Me.PNL_Board_Side.Name = "PNL_Board_Side"
        Me.PNL_Board_Side.Size = New System.Drawing.Size(236, 640)
        Me.PNL_Board_Side.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbl_fird)
        Me.GroupBox1.Controls.Add(Me.lbl_trt)
        Me.GroupBox1.Controls.Add(Me.lbl_cvil)
        Me.GroupBox1.Controls.Add(Me.lbl_blank)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(2, 396)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(231, 230)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Score"
        '
        'lbl_fird
        '
        Me.lbl_fird.AutoSize = True
        Me.lbl_fird.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fird.Location = New System.Drawing.Point(134, 160)
        Me.lbl_fird.Name = "lbl_fird"
        Me.lbl_fird.Size = New System.Drawing.Size(34, 24)
        Me.lbl_fird.TabIndex = 7
        Me.lbl_fird.Text = "00"
        '
        'lbl_trt
        '
        Me.lbl_trt.AutoSize = True
        Me.lbl_trt.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_trt.Location = New System.Drawing.Point(133, 118)
        Me.lbl_trt.Name = "lbl_trt"
        Me.lbl_trt.Size = New System.Drawing.Size(34, 24)
        Me.lbl_trt.TabIndex = 6
        Me.lbl_trt.Text = "00"
        '
        'lbl_cvil
        '
        Me.lbl_cvil.AutoSize = True
        Me.lbl_cvil.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cvil.Location = New System.Drawing.Point(131, 77)
        Me.lbl_cvil.Name = "lbl_cvil"
        Me.lbl_cvil.Size = New System.Drawing.Size(34, 24)
        Me.lbl_cvil.TabIndex = 5
        Me.lbl_cvil.Text = "00"
        '
        'lbl_blank
        '
        Me.lbl_blank.AutoSize = True
        Me.lbl_blank.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_blank.Location = New System.Drawing.Point(131, 41)
        Me.lbl_blank.Name = "lbl_blank"
        Me.lbl_blank.Size = New System.Drawing.Size(34, 24)
        Me.lbl_blank.TabIndex = 4
        Me.lbl_blank.Text = "00"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(33, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 24)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Civilians: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(36, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 24)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Wanted : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(36, 160)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Fired     : "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(33, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Blank     : "
        '
        'GBWanted
        '
        Me.GBWanted.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBWanted.ForeColor = System.Drawing.Color.White
        Me.GBWanted.Location = New System.Drawing.Point(2, 84)
        Me.GBWanted.Name = "GBWanted"
        Me.GBWanted.Size = New System.Drawing.Size(231, 242)
        Me.GBWanted.TabIndex = 0
        Me.GBWanted.TabStop = False
        Me.GBWanted.Text = "Wanted"
        '
        'Timer1
        '
        Me.Timer1.Interval = 25
        '
        'TimeSloat
        '
        Me.TimeSloat.Interval = 5000
        '
        'MainShooter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(701, 640)
        Me.Controls.Add(Me.PNL_Board_Side)
        Me.Controls.Add(Me.PNl_Board)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainShooter"
        Me.Text = "Shooter"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PNl_Board.ResumeLayout(False)
        Me.PNl_Board.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.PNL_Board_Side.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PNl_Board As System.Windows.Forms.Panel
    Friend WithEvents PNL_Board_Side As System.Windows.Forms.Panel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Pnl_Main_Board As System.Windows.Forms.Panel
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents TimeSloat As System.Windows.Forms.Timer
    Friend WithEvents GBWanted As System.Windows.Forms.GroupBox
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbl_blank As System.Windows.Forms.Label
    Friend WithEvents lbl_fird As System.Windows.Forms.Label
    Friend WithEvents lbl_trt As System.Windows.Forms.Label
    Friend WithEvents lbl_cvil As System.Windows.Forms.Label
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
