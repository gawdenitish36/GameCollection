<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UTH_STAGES
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
        Me.PNL_STATUS = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.TM_INTRUPT = New System.Windows.Forms.Timer(Me.components)
        Me.LBL_Life = New System.Windows.Forms.Label
        Me.LBL_Coin = New System.Windows.Forms.Label
        Me.LBL_level = New System.Windows.Forms.Label
        Me.Lbl_score = New System.Windows.Forms.Label
        Me.BOARD = New System.Windows.Forms.PictureBox
        Me.PictureBox4 = New System.Windows.Forms.PictureBox
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PNL_STATUS.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.BOARD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PNL_STATUS
        '
        Me.PNL_STATUS.BackColor = System.Drawing.Color.Green
        Me.PNL_STATUS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PNL_STATUS.Controls.Add(Me.PictureBox4)
        Me.PNL_STATUS.Controls.Add(Me.Lbl_score)
        Me.PNL_STATUS.Controls.Add(Me.PictureBox3)
        Me.PNL_STATUS.Controls.Add(Me.LBL_level)
        Me.PNL_STATUS.Controls.Add(Me.LBL_Coin)
        Me.PNL_STATUS.Controls.Add(Me.PictureBox2)
        Me.PNL_STATUS.Controls.Add(Me.LBL_Life)
        Me.PNL_STATUS.Controls.Add(Me.PictureBox1)
        Me.PNL_STATUS.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PNL_STATUS.Location = New System.Drawing.Point(0, 550)
        Me.PNL_STATUS.Name = "PNL_STATUS"
        Me.PNL_STATUS.Size = New System.Drawing.Size(800, 50)
        Me.PNL_STATUS.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.Controls.Add(Me.BOARD)
        Me.Panel1.Controls.Add(Me.PNL_STATUS)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 600)
        Me.Panel1.TabIndex = 2
        '
        'TM_INTRUPT
        '
        Me.TM_INTRUPT.Interval = 50
        '
        'LBL_Life
        '
        Me.LBL_Life.AutoSize = True
        Me.LBL_Life.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_Life.ForeColor = System.Drawing.Color.White
        Me.LBL_Life.Location = New System.Drawing.Point(62, 12)
        Me.LBL_Life.Name = "LBL_Life"
        Me.LBL_Life.Size = New System.Drawing.Size(19, 20)
        Me.LBL_Life.TabIndex = 1
        Me.LBL_Life.Text = "3"
        '
        'LBL_Coin
        '
        Me.LBL_Coin.AutoSize = True
        Me.LBL_Coin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_Coin.ForeColor = System.Drawing.Color.White
        Me.LBL_Coin.Location = New System.Drawing.Point(239, 14)
        Me.LBL_Coin.Name = "LBL_Coin"
        Me.LBL_Coin.Size = New System.Drawing.Size(19, 20)
        Me.LBL_Coin.TabIndex = 3
        Me.LBL_Coin.Text = "0"
        '
        'LBL_level
        '
        Me.LBL_level.AutoSize = True
        Me.LBL_level.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_level.ForeColor = System.Drawing.Color.White
        Me.LBL_level.Location = New System.Drawing.Point(468, 14)
        Me.LBL_level.Name = "LBL_level"
        Me.LBL_level.Size = New System.Drawing.Size(19, 20)
        Me.LBL_level.TabIndex = 4
        Me.LBL_level.Text = "1"
        '
        'Lbl_score
        '
        Me.Lbl_score.AutoSize = True
        Me.Lbl_score.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_score.ForeColor = System.Drawing.Color.White
        Me.Lbl_score.Location = New System.Drawing.Point(684, 14)
        Me.Lbl_score.Name = "Lbl_score"
        Me.Lbl_score.Size = New System.Drawing.Size(19, 20)
        Me.Lbl_score.TabIndex = 4
        Me.Lbl_score.Text = "0"
        '
        'BOARD
        '
        Me.BOARD.BackColor = System.Drawing.Color.Transparent
        Me.BOARD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.BOARD.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BOARD.Image = Global.Ultimate_Treasure_Hunt.My.Resources.Resources.BG
        Me.BOARD.Location = New System.Drawing.Point(0, 0)
        Me.BOARD.Name = "BOARD"
        Me.BOARD.Size = New System.Drawing.Size(800, 550)
        Me.BOARD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BOARD.TabIndex = 1
        Me.BOARD.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.Ultimate_Treasure_Hunt.My.Resources.Resources.Score
        Me.PictureBox4.Location = New System.Drawing.Point(576, 4)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(105, 35)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 5
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Ultimate_Treasure_Hunt.My.Resources.Resources.level
        Me.PictureBox3.Location = New System.Drawing.Point(360, 4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(105, 35)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 5
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Ultimate_Treasure_Hunt.My.Resources.Resources.Coin
        Me.PictureBox2.Location = New System.Drawing.Point(198, 6)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(35, 35)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Ultimate_Treasure_Hunt.My.Resources.Resources.Life
        Me.PictureBox1.Location = New System.Drawing.Point(21, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(35, 35)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'UTH_STAGES
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 612)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "UTH_STAGES"
        Me.Text = "UTH_STAGE1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PNL_STATUS.ResumeLayout(False)
        Me.PNL_STATUS.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.BOARD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PNL_STATUS As System.Windows.Forms.Panel
    Friend WithEvents BOARD As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TM_INTRUPT As System.Windows.Forms.Timer
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LBL_Life As System.Windows.Forms.Label
    Friend WithEvents LBL_Coin As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents LBL_level As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents Lbl_score As System.Windows.Forms.Label
End Class
