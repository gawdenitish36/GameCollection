<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SINGLEPLAYERRESULT
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Lbl_final = New System.Windows.Forms.Label
        Me.Final = New System.Windows.Forms.Label
        Me.LBL_TURN = New System.Windows.Forms.Label
        Me.LBL_UNDO = New System.Windows.Forms.Label
        Me.LBL_FINAL_SCORE = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.PB_MSG = New System.Windows.Forms.PictureBox
        Me.PB_ANIMATE = New System.Windows.Forms.PictureBox
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Panel1.SuspendLayout()
        CType(Me.PB_MSG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_ANIMATE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(13, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Score"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label2.Location = New System.Drawing.Point(84, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 19)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Undo"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Lbl_final)
        Me.Panel1.Controls.Add(Me.Final)
        Me.Panel1.Controls.Add(Me.LBL_TURN)
        Me.Panel1.Controls.Add(Me.LBL_UNDO)
        Me.Panel1.Controls.Add(Me.LBL_FINAL_SCORE)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(200, 90)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(280, 128)
        Me.Panel1.TabIndex = 3
        '
        'Lbl_final
        '
        Me.Lbl_final.AutoSize = True
        Me.Lbl_final.Font = New System.Drawing.Font("Comic Sans MS", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_final.ForeColor = System.Drawing.Color.White
        Me.Lbl_final.Location = New System.Drawing.Point(206, 63)
        Me.Lbl_final.Name = "Lbl_final"
        Me.Lbl_final.Size = New System.Drawing.Size(53, 40)
        Me.Lbl_final.TabIndex = 3
        Me.Lbl_final.Text = "00"
        '
        'Final
        '
        Me.Final.AutoSize = True
        Me.Final.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Final.ForeColor = System.Drawing.Color.White
        Me.Final.Location = New System.Drawing.Point(212, 24)
        Me.Final.Name = "Final"
        Me.Final.Size = New System.Drawing.Size(39, 19)
        Me.Final.TabIndex = 2
        Me.Final.Text = "Final"
        '
        'LBL_TURN
        '
        Me.LBL_TURN.AutoSize = True
        Me.LBL_TURN.Font = New System.Drawing.Font("Comic Sans MS", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_TURN.ForeColor = System.Drawing.Color.Blue
        Me.LBL_TURN.Location = New System.Drawing.Point(140, 63)
        Me.LBL_TURN.Name = "LBL_TURN"
        Me.LBL_TURN.Size = New System.Drawing.Size(53, 40)
        Me.LBL_TURN.TabIndex = 1
        Me.LBL_TURN.Text = "00"
        '
        'LBL_UNDO
        '
        Me.LBL_UNDO.AutoSize = True
        Me.LBL_UNDO.Font = New System.Drawing.Font("Comic Sans MS", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_UNDO.ForeColor = System.Drawing.Color.LawnGreen
        Me.LBL_UNDO.Location = New System.Drawing.Point(78, 63)
        Me.LBL_UNDO.Name = "LBL_UNDO"
        Me.LBL_UNDO.Size = New System.Drawing.Size(53, 40)
        Me.LBL_UNDO.TabIndex = 1
        Me.LBL_UNDO.Text = "00"
        '
        'LBL_FINAL_SCORE
        '
        Me.LBL_FINAL_SCORE.AutoSize = True
        Me.LBL_FINAL_SCORE.Font = New System.Drawing.Font("Comic Sans MS", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_FINAL_SCORE.ForeColor = System.Drawing.Color.Red
        Me.LBL_FINAL_SCORE.Location = New System.Drawing.Point(6, 63)
        Me.LBL_FINAL_SCORE.Name = "LBL_FINAL_SCORE"
        Me.LBL_FINAL_SCORE.Size = New System.Drawing.Size(53, 40)
        Me.LBL_FINAL_SCORE.TabIndex = 1
        Me.LBL_FINAL_SCORE.Text = "00"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(146, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 19)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Turn"
        '
        'PB_MSG
        '
        Me.PB_MSG.Image = Global.dots.My.Resources.Resources.you_won
        Me.PB_MSG.Location = New System.Drawing.Point(200, 37)
        Me.PB_MSG.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PB_MSG.Name = "PB_MSG"
        Me.PB_MSG.Size = New System.Drawing.Size(280, 48)
        Me.PB_MSG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PB_MSG.TabIndex = 4
        Me.PB_MSG.TabStop = False
        '
        'PB_ANIMATE
        '
        Me.PB_ANIMATE.Image = Global.dots.My.Resources.Resources.cheerleaders5
        Me.PB_ANIMATE.Location = New System.Drawing.Point(12, 37)
        Me.PB_ANIMATE.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PB_ANIMATE.Name = "PB_ANIMATE"
        Me.PB_ANIMATE.Size = New System.Drawing.Size(174, 182)
        Me.PB_ANIMATE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PB_ANIMATE.TabIndex = 2
        Me.PB_ANIMATE.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Image = Global.dots.My.Resources.Resources.noup
        Me.PictureBox3.Location = New System.Drawing.Point(406, 243)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(79, 48)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 1
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = Global.dots.My.Resources.Resources.yesup
        Me.PictureBox2.Location = New System.Drawing.Point(321, 243)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(79, 48)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.dots.My.Resources.Resources.lblmsg
        Me.PictureBox1.Location = New System.Drawing.Point(3, 243)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(312, 48)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'SINGLEPLAYERRESULT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(492, 311)
        Me.ControlBox = False
        Me.Controls.Add(Me.PB_MSG)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PB_ANIMATE)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SINGLEPLAYERRESULT"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "                                                           GAME OVER.....!!!"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PB_MSG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_ANIMATE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents LBL_TURN As System.Windows.Forms.Label
    Friend WithEvents LBL_UNDO As System.Windows.Forms.Label
    Friend WithEvents LBL_FINAL_SCORE As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PB_MSG As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PB_ANIMATE As System.Windows.Forms.PictureBox
    Friend WithEvents Lbl_final As System.Windows.Forms.Label
    Friend WithEvents Final As System.Windows.Forms.Label

End Class
