<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DABMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DABMain))
        Me.Button1 = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel_Rules = New System.Windows.Forms.GroupBox
        Me.Txt_Rules = New System.Windows.Forms.TextBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.LBL_Time = New System.Windows.Forms.Label
        Me.LBL_LT_CPU = New System.Windows.Forms.Label
        Me.Lbl_cpu_score2 = New System.Windows.Forms.Label
        Me.LBL_UNDO = New System.Windows.Forms.Label
        Me.LBL_LT_PLAY = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Lbl_play_score2 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lbl_cpu2 = New System.Windows.Forms.Label
        Me.lbl_name2 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.p2_img = New System.Windows.Forms.PictureBox
        Me.lbl_name = New System.Windows.Forms.Label
        Me.Lbl_Ply_Score = New System.Windows.Forms.Label
        Me.lbl_cpu = New System.Windows.Forms.Label
        Me.p1_img = New System.Windows.Forms.PictureBox
        Me.Lbl_Cpu_Score = New System.Windows.Forms.Label
        Me.btn_start = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.DOUBLEPLAYERPANAL = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.PB_TURN_2 = New System.Windows.Forms.PictureBox
        Me.PB_TURN_1 = New System.Windows.Forms.PictureBox
        Me.LBL_Turn = New System.Windows.Forms.Label
        Me.LBL_CT_P2 = New System.Windows.Forms.Label
        Me.LBL_CT_P1 = New System.Windows.Forms.Label
        Me.LBLTURN = New System.Windows.Forms.Label
        Me.LBL_Grid = New System.Windows.Forms.Label
        Me.SINGLEPLAYERPANAL = New System.Windows.Forms.Panel
        Me.PB_Cpu_Turn = New System.Windows.Forms.PictureBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Lbl_level = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Button4 = New System.Windows.Forms.Button
        Me.menu_s_1 = New System.Windows.Forms.MenuStrip
        Me.GameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NewGameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LoadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.UndoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SetingisToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FirstTurnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MST_Yor_T = New System.Windows.Forms.ToolStripMenuItem
        Me.MST_RENDT = New System.Windows.Forms.ToolStripMenuItem
        Me.MST_CPUT = New System.Windows.Forms.ToolStripMenuItem
        Me.SelectPenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HumanVSCPUToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HumanVSHumanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HighScoreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.tt = New System.Windows.Forms.ToolTip(Me.components)
        Me.TM_Hilight = New System.Windows.Forms.Timer(Me.components)
        Me.TM_Game = New System.Windows.Forms.Timer(Me.components)
        Me.PB_Bord = New System.Windows.Forms.PictureBox
        Me.Bord_Panel = New System.Windows.Forms.Panel
        Me.SFD = New System.Windows.Forms.SaveFileDialog
        Me.OFD = New System.Windows.Forms.OpenFileDialog
        Me.TM_Rules = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel_Rules.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.p2_img, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.p1_img, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.DOUBLEPLAYERPANAL.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PB_TURN_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_TURN_1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SINGLEPLAYERPANAL.SuspendLayout()
        CType(Me.PB_Cpu_Turn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.menu_s_1.SuspendLayout()
        CType(Me.PB_Bord, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        resources.ApplyResources(Me.Button1, "Button1")
        Me.Button1.Name = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DimGray
        Me.Panel1.Controls.Add(Me.Panel_Rules)
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.btn_start)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.Name = "Panel1"
        '
        'Panel_Rules
        '
        Me.Panel_Rules.Controls.Add(Me.Txt_Rules)
        resources.ApplyResources(Me.Panel_Rules, "Panel_Rules")
        Me.Panel_Rules.ForeColor = System.Drawing.Color.White
        Me.Panel_Rules.Name = "Panel_Rules"
        Me.Panel_Rules.TabStop = False
        '
        'Txt_Rules
        '
        Me.Txt_Rules.BackColor = System.Drawing.Color.DimGray
        Me.Txt_Rules.BorderStyle = System.Windows.Forms.BorderStyle.None
        resources.ApplyResources(Me.Txt_Rules, "Txt_Rules")
        Me.Txt_Rules.ForeColor = System.Drawing.Color.White
        Me.Txt_Rules.Name = "Txt_Rules"
        Me.Txt_Rules.ReadOnly = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.LBL_Time)
        Me.GroupBox3.Controls.Add(Me.LBL_LT_CPU)
        Me.GroupBox3.Controls.Add(Me.Lbl_cpu_score2)
        Me.GroupBox3.Controls.Add(Me.LBL_UNDO)
        Me.GroupBox3.Controls.Add(Me.LBL_LT_PLAY)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Lbl_play_score2)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.lbl_cpu2)
        Me.GroupBox3.Controls.Add(Me.lbl_name2)
        Me.GroupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        resources.ApplyResources(Me.GroupBox3, "GroupBox3")
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.TabStop = False
        '
        'LBL_Time
        '
        resources.ApplyResources(Me.LBL_Time, "LBL_Time")
        Me.LBL_Time.Name = "LBL_Time"
        '
        'LBL_LT_CPU
        '
        resources.ApplyResources(Me.LBL_LT_CPU, "LBL_LT_CPU")
        Me.LBL_LT_CPU.Name = "LBL_LT_CPU"
        '
        'Lbl_cpu_score2
        '
        resources.ApplyResources(Me.Lbl_cpu_score2, "Lbl_cpu_score2")
        Me.Lbl_cpu_score2.Name = "Lbl_cpu_score2"
        '
        'LBL_UNDO
        '
        resources.ApplyResources(Me.LBL_UNDO, "LBL_UNDO")
        Me.LBL_UNDO.Name = "LBL_UNDO"
        '
        'LBL_LT_PLAY
        '
        resources.ApplyResources(Me.LBL_LT_PLAY, "LBL_LT_PLAY")
        Me.LBL_LT_PLAY.Name = "LBL_LT_PLAY"
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.Name = "Label6"
        '
        'Lbl_play_score2
        '
        resources.ApplyResources(Me.Lbl_play_score2, "Lbl_play_score2")
        Me.Lbl_play_score2.Name = "Lbl_play_score2"
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Name = "Label5"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'lbl_cpu2
        '
        resources.ApplyResources(Me.lbl_cpu2, "lbl_cpu2")
        Me.lbl_cpu2.Name = "lbl_cpu2"
        '
        'lbl_name2
        '
        resources.ApplyResources(Me.lbl_name2, "lbl_name2")
        Me.lbl_name2.Name = "lbl_name2"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.p2_img)
        Me.GroupBox2.Controls.Add(Me.lbl_name)
        Me.GroupBox2.Controls.Add(Me.Lbl_Ply_Score)
        Me.GroupBox2.Controls.Add(Me.lbl_cpu)
        Me.GroupBox2.Controls.Add(Me.p1_img)
        Me.GroupBox2.Controls.Add(Me.Lbl_Cpu_Score)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        resources.ApplyResources(Me.GroupBox2, "GroupBox2")
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.TabStop = False
        '
        'p2_img
        '
        Me.p2_img.Image = Global.dots.My.Resources.Resources.C1
        resources.ApplyResources(Me.p2_img, "p2_img")
        Me.p2_img.Name = "p2_img"
        Me.p2_img.TabStop = False
        '
        'lbl_name
        '
        resources.ApplyResources(Me.lbl_name, "lbl_name")
        Me.lbl_name.ForeColor = System.Drawing.Color.White
        Me.lbl_name.Name = "lbl_name"
        '
        'Lbl_Ply_Score
        '
        resources.ApplyResources(Me.Lbl_Ply_Score, "Lbl_Ply_Score")
        Me.Lbl_Ply_Score.ForeColor = System.Drawing.Color.White
        Me.Lbl_Ply_Score.Name = "Lbl_Ply_Score"
        '
        'lbl_cpu
        '
        resources.ApplyResources(Me.lbl_cpu, "lbl_cpu")
        Me.lbl_cpu.ForeColor = System.Drawing.Color.White
        Me.lbl_cpu.Name = "lbl_cpu"
        '
        'p1_img
        '
        resources.ApplyResources(Me.p1_img, "p1_img")
        Me.p1_img.Image = Global.dots.My.Resources.Resources.B
        Me.p1_img.Name = "p1_img"
        Me.p1_img.TabStop = False
        '
        'Lbl_Cpu_Score
        '
        resources.ApplyResources(Me.Lbl_Cpu_Score, "Lbl_Cpu_Score")
        Me.Lbl_Cpu_Score.ForeColor = System.Drawing.Color.White
        Me.Lbl_Cpu_Score.Name = "Lbl_Cpu_Score"
        '
        'btn_start
        '
        Me.btn_start.BackgroundImage = Global.dots.My.Resources.Resources.ng_n
        resources.ApplyResources(Me.btn_start, "btn_start")
        Me.btn_start.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_start.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btn_start.FlatAppearance.BorderSize = 0
        Me.btn_start.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn_start.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn_start.Name = "btn_start"
        Me.btn_start.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.DOUBLEPLAYERPANAL)
        Me.GroupBox1.Controls.Add(Me.LBL_Grid)
        Me.GroupBox1.Controls.Add(Me.SINGLEPLAYERPANAL)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'DOUBLEPLAYERPANAL
        '
        Me.DOUBLEPLAYERPANAL.BackColor = System.Drawing.Color.Transparent
        Me.DOUBLEPLAYERPANAL.Controls.Add(Me.Panel2)
        Me.DOUBLEPLAYERPANAL.Controls.Add(Me.LBL_Turn)
        Me.DOUBLEPLAYERPANAL.Controls.Add(Me.LBL_CT_P2)
        Me.DOUBLEPLAYERPANAL.Controls.Add(Me.LBL_CT_P1)
        Me.DOUBLEPLAYERPANAL.Controls.Add(Me.LBLTURN)
        resources.ApplyResources(Me.DOUBLEPLAYERPANAL, "DOUBLEPLAYERPANAL")
        Me.DOUBLEPLAYERPANAL.Name = "DOUBLEPLAYERPANAL"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.PB_TURN_2)
        Me.Panel2.Controls.Add(Me.PB_TURN_1)
        resources.ApplyResources(Me.Panel2, "Panel2")
        Me.Panel2.Name = "Panel2"
        '
        'PB_TURN_2
        '
        Me.PB_TURN_2.Image = Global.dots.My.Resources.Resources.circle_green
        resources.ApplyResources(Me.PB_TURN_2, "PB_TURN_2")
        Me.PB_TURN_2.Name = "PB_TURN_2"
        Me.PB_TURN_2.TabStop = False
        '
        'PB_TURN_1
        '
        Me.PB_TURN_1.Image = Global.dots.My.Resources.Resources.circle_red
        resources.ApplyResources(Me.PB_TURN_1, "PB_TURN_1")
        Me.PB_TURN_1.Name = "PB_TURN_1"
        Me.PB_TURN_1.TabStop = False
        '
        'LBL_Turn
        '
        resources.ApplyResources(Me.LBL_Turn, "LBL_Turn")
        Me.LBL_Turn.Name = "LBL_Turn"
        '
        'LBL_CT_P2
        '
        resources.ApplyResources(Me.LBL_CT_P2, "LBL_CT_P2")
        Me.LBL_CT_P2.Name = "LBL_CT_P2"
        '
        'LBL_CT_P1
        '
        resources.ApplyResources(Me.LBL_CT_P1, "LBL_CT_P1")
        Me.LBL_CT_P1.Name = "LBL_CT_P1"
        '
        'LBLTURN
        '
        resources.ApplyResources(Me.LBLTURN, "LBLTURN")
        Me.LBLTURN.Name = "LBLTURN"
        '
        'LBL_Grid
        '
        resources.ApplyResources(Me.LBL_Grid, "LBL_Grid")
        Me.LBL_Grid.Name = "LBL_Grid"
        '
        'SINGLEPLAYERPANAL
        '
        Me.SINGLEPLAYERPANAL.BackColor = System.Drawing.Color.Transparent
        Me.SINGLEPLAYERPANAL.Controls.Add(Me.PB_Cpu_Turn)
        Me.SINGLEPLAYERPANAL.Controls.Add(Me.Label14)
        Me.SINGLEPLAYERPANAL.Controls.Add(Me.Lbl_level)
        resources.ApplyResources(Me.SINGLEPLAYERPANAL, "SINGLEPLAYERPANAL")
        Me.SINGLEPLAYERPANAL.Name = "SINGLEPLAYERPANAL"
        '
        'PB_Cpu_Turn
        '
        Me.PB_Cpu_Turn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PB_Cpu_Turn.Image = Global.dots.My.Resources.Resources.up
        resources.ApplyResources(Me.PB_Cpu_Turn, "PB_Cpu_Turn")
        Me.PB_Cpu_Turn.Name = "PB_Cpu_Turn"
        Me.PB_Cpu_Turn.TabStop = False
        '
        'Label14
        '
        resources.ApplyResources(Me.Label14, "Label14")
        Me.Label14.Name = "Label14"
        '
        'Lbl_level
        '
        resources.ApplyResources(Me.Lbl_level, "Lbl_level")
        Me.Lbl_level.Name = "Lbl_level"
        '
        'Label13
        '
        resources.ApplyResources(Me.Label13, "Label13")
        Me.Label13.Name = "Label13"
        '
        'Button4
        '
        resources.ApplyResources(Me.Button4, "Button4")
        Me.Button4.Name = "Button4"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'menu_s_1
        '
        Me.menu_s_1.BackColor = System.Drawing.Color.DimGray
        Me.menu_s_1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GameToolStripMenuItem, Me.SetingisToolStripMenuItem, Me.HighScoreToolStripMenuItem})
        resources.ApplyResources(Me.menu_s_1, "menu_s_1")
        Me.menu_s_1.Name = "menu_s_1"
        '
        'GameToolStripMenuItem
        '
        Me.GameToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.GameToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewGameToolStripMenuItem, Me.SaveToolStripMenuItem, Me.LoadToolStripMenuItem, Me.ToolStripSeparator1, Me.UndoToolStripMenuItem, Me.ToolStripSeparator2, Me.ExitToolStripMenuItem})
        Me.GameToolStripMenuItem.Name = "GameToolStripMenuItem"
        resources.ApplyResources(Me.GameToolStripMenuItem, "GameToolStripMenuItem")
        '
        'NewGameToolStripMenuItem
        '
        Me.NewGameToolStripMenuItem.Name = "NewGameToolStripMenuItem"
        resources.ApplyResources(Me.NewGameToolStripMenuItem, "NewGameToolStripMenuItem")
        '
        'SaveToolStripMenuItem
        '
        resources.ApplyResources(Me.SaveToolStripMenuItem, "SaveToolStripMenuItem")
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        '
        'LoadToolStripMenuItem
        '
        Me.LoadToolStripMenuItem.Name = "LoadToolStripMenuItem"
        resources.ApplyResources(Me.LoadToolStripMenuItem, "LoadToolStripMenuItem")
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        resources.ApplyResources(Me.ToolStripSeparator1, "ToolStripSeparator1")
        '
        'UndoToolStripMenuItem
        '
        resources.ApplyResources(Me.UndoToolStripMenuItem, "UndoToolStripMenuItem")
        Me.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        resources.ApplyResources(Me.ToolStripSeparator2, "ToolStripSeparator2")
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        resources.ApplyResources(Me.ExitToolStripMenuItem, "ExitToolStripMenuItem")
        '
        'SetingisToolStripMenuItem
        '
        Me.SetingisToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.SetingisToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FirstTurnToolStripMenuItem, Me.SelectPenToolStripMenuItem})
        Me.SetingisToolStripMenuItem.Margin = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.SetingisToolStripMenuItem.Name = "SetingisToolStripMenuItem"
        resources.ApplyResources(Me.SetingisToolStripMenuItem, "SetingisToolStripMenuItem")
        '
        'FirstTurnToolStripMenuItem
        '
        Me.FirstTurnToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MST_Yor_T, Me.MST_RENDT, Me.MST_CPUT})
        Me.FirstTurnToolStripMenuItem.Name = "FirstTurnToolStripMenuItem"
        resources.ApplyResources(Me.FirstTurnToolStripMenuItem, "FirstTurnToolStripMenuItem")
        '
        'MST_Yor_T
        '
        Me.MST_Yor_T.Checked = True
        Me.MST_Yor_T.CheckOnClick = True
        Me.MST_Yor_T.CheckState = System.Windows.Forms.CheckState.Checked
        Me.MST_Yor_T.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.MST_Yor_T.Name = "MST_Yor_T"
        resources.ApplyResources(Me.MST_Yor_T, "MST_Yor_T")
        '
        'MST_RENDT
        '
        Me.MST_RENDT.CheckOnClick = True
        Me.MST_RENDT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.MST_RENDT.Name = "MST_RENDT"
        resources.ApplyResources(Me.MST_RENDT, "MST_RENDT")
        '
        'MST_CPUT
        '
        Me.MST_CPUT.CheckOnClick = True
        Me.MST_CPUT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.MST_CPUT.Name = "MST_CPUT"
        resources.ApplyResources(Me.MST_CPUT, "MST_CPUT")
        '
        'SelectPenToolStripMenuItem
        '
        Me.SelectPenToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HumanVSCPUToolStripMenuItem, Me.HumanVSHumanToolStripMenuItem})
        Me.SelectPenToolStripMenuItem.Name = "SelectPenToolStripMenuItem"
        resources.ApplyResources(Me.SelectPenToolStripMenuItem, "SelectPenToolStripMenuItem")
        '
        'HumanVSCPUToolStripMenuItem
        '
        Me.HumanVSCPUToolStripMenuItem.Checked = True
        Me.HumanVSCPUToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.HumanVSCPUToolStripMenuItem.Name = "HumanVSCPUToolStripMenuItem"
        resources.ApplyResources(Me.HumanVSCPUToolStripMenuItem, "HumanVSCPUToolStripMenuItem")
        '
        'HumanVSHumanToolStripMenuItem
        '
        Me.HumanVSHumanToolStripMenuItem.CheckOnClick = True
        Me.HumanVSHumanToolStripMenuItem.Name = "HumanVSHumanToolStripMenuItem"
        resources.ApplyResources(Me.HumanVSHumanToolStripMenuItem, "HumanVSHumanToolStripMenuItem")
        '
        'HighScoreToolStripMenuItem
        '
        Me.HighScoreToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.HighScoreToolStripMenuItem.Margin = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.HighScoreToolStripMenuItem.Name = "HighScoreToolStripMenuItem"
        resources.ApplyResources(Me.HighScoreToolStripMenuItem, "HighScoreToolStripMenuItem")
        '
        'TM_Hilight
        '
        Me.TM_Hilight.Interval = 50
        '
        'TM_Game
        '
        Me.TM_Game.Interval = 1000
        '
        'PB_Bord
        '
        resources.ApplyResources(Me.PB_Bord, "PB_Bord")
        Me.PB_Bord.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PB_Bord.Name = "PB_Bord"
        Me.PB_Bord.TabStop = False
        '
        'Bord_Panel
        '
        Me.Bord_Panel.BackColor = System.Drawing.SystemColors.Info
        resources.ApplyResources(Me.Bord_Panel, "Bord_Panel")
        Me.Bord_Panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Bord_Panel.Name = "Bord_Panel"
        '
        'OFD
        '
        Me.OFD.FileName = "OpenFileDialog1"
        '
        'TM_Rules
        '
        Me.TM_Rules.Interval = 25
        '
        'DABMain
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PB_Bord)
        Me.Controls.Add(Me.Bord_Panel)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.menu_s_1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.menu_s_1
        Me.Name = "DABMain"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel_Rules.ResumeLayout(False)
        Me.Panel_Rules.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.p2_img, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.p1_img, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.DOUBLEPLAYERPANAL.ResumeLayout(False)
        Me.DOUBLEPLAYERPANAL.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PB_TURN_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_TURN_1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SINGLEPLAYERPANAL.ResumeLayout(False)
        Me.SINGLEPLAYERPANAL.PerformLayout()
        CType(Me.PB_Cpu_Turn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.menu_s_1.ResumeLayout(False)
        Me.menu_s_1.PerformLayout()
        CType(Me.PB_Bord, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Bord_Panel As System.Windows.Forms.Panel
    Friend WithEvents btn_start As System.Windows.Forms.Button
    Friend WithEvents lbl_cpu As System.Windows.Forms.Label
    Friend WithEvents Lbl_Cpu_Score As System.Windows.Forms.Label
    Friend WithEvents Lbl_Ply_Score As System.Windows.Forms.Label
    Friend WithEvents lbl_name As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents menu_s_1 As System.Windows.Forms.MenuStrip
    Friend WithEvents GameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewGameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UndoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents p2_img As System.Windows.Forms.PictureBox
    Friend WithEvents p1_img As System.Windows.Forms.PictureBox
    Friend WithEvents PB_Bord As System.Windows.Forms.PictureBox
    Friend WithEvents SetingisToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FirstTurnToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MST_Yor_T As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MST_RENDT As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MST_CPUT As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SelectPenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tt As System.Windows.Forms.ToolTip
    Friend WithEvents TM_Hilight As System.Windows.Forms.Timer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbl_cpu2 As System.Windows.Forms.Label
    Friend WithEvents lbl_name2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Lbl_cpu_score2 As System.Windows.Forms.Label
    Friend WithEvents LBL_UNDO As System.Windows.Forms.Label
    Friend WithEvents LBL_LT_PLAY As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Lbl_play_score2 As System.Windows.Forms.Label
    Friend WithEvents LBL_LT_CPU As System.Windows.Forms.Label
    Friend WithEvents LBL_Time As System.Windows.Forms.Label
    Friend WithEvents TM_Game As System.Windows.Forms.Timer
    Friend WithEvents LBL_Turn As System.Windows.Forms.Label
    Friend WithEvents LBLTURN As System.Windows.Forms.Label
    Friend WithEvents Lbl_level As System.Windows.Forms.Label
    Friend WithEvents LBL_Grid As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents PB_Cpu_Turn As System.Windows.Forms.PictureBox
    Friend WithEvents HumanVSCPUToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HumanVSHumanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SINGLEPLAYERPANAL As System.Windows.Forms.Panel
    Friend WithEvents DOUBLEPLAYERPANAL As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PB_TURN_2 As System.Windows.Forms.PictureBox
    Friend WithEvents PB_TURN_1 As System.Windows.Forms.PictureBox
    Friend WithEvents LBL_CT_P2 As System.Windows.Forms.Label
    Friend WithEvents LBL_CT_P1 As System.Windows.Forms.Label
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SFD As System.Windows.Forms.SaveFileDialog
    Friend WithEvents OFD As System.Windows.Forms.OpenFileDialog
    Friend WithEvents HighScoreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Txt_Rules As System.Windows.Forms.TextBox
    Friend WithEvents Panel_Rules As System.Windows.Forms.GroupBox
    Friend WithEvents TM_Rules As System.Windows.Forms.Timer

End Class
