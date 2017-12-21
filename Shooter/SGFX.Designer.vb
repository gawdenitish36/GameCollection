<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SGFX
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
        Me.PBBlast = New System.Windows.Forms.PictureBox
        Me.PBtargat = New System.Windows.Forms.PictureBox
        Me.PBCharActor = New System.Windows.Forms.PictureBox
        Me.PBreaload = New System.Windows.Forms.PictureBox
        CType(Me.PBBlast, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBtargat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBCharActor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBreaload, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PBBlast
        '
        Me.PBBlast.Image = Global.Shooter.My.Resources.Resources.blast
        Me.PBBlast.Location = New System.Drawing.Point(0, 327)
        Me.PBBlast.Name = "PBBlast"
        Me.PBBlast.Size = New System.Drawing.Size(616, 50)
        Me.PBBlast.TabIndex = 2
        Me.PBBlast.TabStop = False
        '
        'PBtargat
        '
        Me.PBtargat.Image = Global.Shooter.My.Resources.Resources.target
        Me.PBtargat.Location = New System.Drawing.Point(12, 201)
        Me.PBtargat.Name = "PBtargat"
        Me.PBtargat.Size = New System.Drawing.Size(100, 100)
        Me.PBtargat.TabIndex = 1
        Me.PBtargat.TabStop = False
        '
        'PBCharActor
        '
        Me.PBCharActor.Image = Global.Shooter.My.Resources.Resources.T1
        Me.PBCharActor.Location = New System.Drawing.Point(12, 12)
        Me.PBCharActor.Name = "PBCharActor"
        Me.PBCharActor.Size = New System.Drawing.Size(241, 141)
        Me.PBCharActor.TabIndex = 0
        Me.PBCharActor.TabStop = False
        '
        'PBreaload
        '
        Me.PBreaload.Image = Global.Shooter.My.Resources.Resources.reload
        Me.PBreaload.Location = New System.Drawing.Point(118, 201)
        Me.PBreaload.Name = "PBreaload"
        Me.PBreaload.Size = New System.Drawing.Size(100, 100)
        Me.PBreaload.TabIndex = 3
        Me.PBreaload.TabStop = False
        '
        'SGFX
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(617, 410)
        Me.Controls.Add(Me.PBreaload)
        Me.Controls.Add(Me.PBBlast)
        Me.Controls.Add(Me.PBtargat)
        Me.Controls.Add(Me.PBCharActor)
        Me.Name = "SGFX"
        Me.Text = "SGFX"
        CType(Me.PBBlast, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBtargat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBCharActor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBreaload, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PBCharActor As System.Windows.Forms.PictureBox
    Friend WithEvents PBtargat As System.Windows.Forms.PictureBox
    Friend WithEvents PBBlast As System.Windows.Forms.PictureBox
    Friend WithEvents PBreaload As System.Windows.Forms.PictureBox
End Class
