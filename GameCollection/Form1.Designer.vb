<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button
        Me.btn_dab = New System.Windows.Forms.Button
        Me.btn_uth = New System.Windows.Forms.Button
        Me.btn_shooter = New System.Windows.Forms.Button
        Me.lbl_dab = New System.Windows.Forms.Label
        Me.lbl_uth = New System.Windows.Forms.Label
        Me.lbl_shooter = New System.Windows.Forms.Label
        Me.lbl_default = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(285, 380)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(25, 25)
        Me.Button1.TabIndex = 0
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btn_dab
        '
        Me.btn_dab.BackColor = System.Drawing.Color.Transparent
        Me.btn_dab.BackgroundImage = CType(resources.GetObject("btn_dab.BackgroundImage"), System.Drawing.Image)
        Me.btn_dab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_dab.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn_dab.FlatAppearance.BorderSize = 10
        Me.btn_dab.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_dab.Location = New System.Drawing.Point(56, 143)
        Me.btn_dab.Name = "btn_dab"
        Me.btn_dab.Size = New System.Drawing.Size(125, 125)
        Me.btn_dab.TabIndex = 1
        Me.btn_dab.UseVisualStyleBackColor = False
        '
        'btn_uth
        '
        Me.btn_uth.BackColor = System.Drawing.Color.Transparent
        Me.btn_uth.BackgroundImage = CType(resources.GetObject("btn_uth.BackgroundImage"), System.Drawing.Image)
        Me.btn_uth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_uth.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn_uth.FlatAppearance.BorderSize = 10
        Me.btn_uth.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_uth.Location = New System.Drawing.Point(236, 143)
        Me.btn_uth.Name = "btn_uth"
        Me.btn_uth.Size = New System.Drawing.Size(125, 125)
        Me.btn_uth.TabIndex = 2
        Me.btn_uth.UseVisualStyleBackColor = False
        '
        'btn_shooter
        '
        Me.btn_shooter.BackColor = System.Drawing.Color.Transparent
        Me.btn_shooter.BackgroundImage = CType(resources.GetObject("btn_shooter.BackgroundImage"), System.Drawing.Image)
        Me.btn_shooter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_shooter.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn_shooter.FlatAppearance.BorderSize = 10
        Me.btn_shooter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_shooter.Location = New System.Drawing.Point(411, 143)
        Me.btn_shooter.Name = "btn_shooter"
        Me.btn_shooter.Size = New System.Drawing.Size(125, 125)
        Me.btn_shooter.TabIndex = 3
        Me.btn_shooter.UseVisualStyleBackColor = False
        '
        'lbl_dab
        '
        Me.lbl_dab.AutoSize = True
        Me.lbl_dab.BackColor = System.Drawing.Color.Transparent
        Me.lbl_dab.Font = New System.Drawing.Font("Comic Sans MS", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_dab.ForeColor = System.Drawing.Color.Yellow
        Me.lbl_dab.Location = New System.Drawing.Point(182, 301)
        Me.lbl_dab.Name = "lbl_dab"
        Me.lbl_dab.Size = New System.Drawing.Size(240, 40)
        Me.lbl_dab.TabIndex = 4
        Me.lbl_dab.Text = "Dots And Boxes"
        Me.lbl_dab.Visible = False
        '
        'lbl_uth
        '
        Me.lbl_uth.AutoSize = True
        Me.lbl_uth.BackColor = System.Drawing.Color.Transparent
        Me.lbl_uth.Font = New System.Drawing.Font("Comic Sans MS", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_uth.ForeColor = System.Drawing.Color.Yellow
        Me.lbl_uth.Location = New System.Drawing.Point(120, 301)
        Me.lbl_uth.Name = "lbl_uth"
        Me.lbl_uth.Size = New System.Drawing.Size(354, 40)
        Me.lbl_uth.TabIndex = 5
        Me.lbl_uth.Text = "Ultimate Treasure Hunt"
        Me.lbl_uth.Visible = False
        '
        'lbl_shooter
        '
        Me.lbl_shooter.AutoSize = True
        Me.lbl_shooter.BackColor = System.Drawing.Color.Transparent
        Me.lbl_shooter.Font = New System.Drawing.Font("Comic Sans MS", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_shooter.ForeColor = System.Drawing.Color.Yellow
        Me.lbl_shooter.Location = New System.Drawing.Point(229, 305)
        Me.lbl_shooter.Name = "lbl_shooter"
        Me.lbl_shooter.Size = New System.Drawing.Size(128, 40)
        Me.lbl_shooter.TabIndex = 6
        Me.lbl_shooter.Text = "Shooter"
        Me.lbl_shooter.Visible = False
        '
        'lbl_default
        '
        Me.lbl_default.AutoSize = True
        Me.lbl_default.BackColor = System.Drawing.Color.Transparent
        Me.lbl_default.Font = New System.Drawing.Font("Comic Sans MS", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_default.ForeColor = System.Drawing.Color.Yellow
        Me.lbl_default.Location = New System.Drawing.Point(196, 298)
        Me.lbl_default.Name = "lbl_default"
        Me.lbl_default.Size = New System.Drawing.Size(194, 40)
        Me.lbl_default.TabIndex = 7
        Me.lbl_default.Text = "Select Game"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(600, 512)
        Me.Controls.Add(Me.lbl_default)
        Me.Controls.Add(Me.lbl_shooter)
        Me.Controls.Add(Me.lbl_uth)
        Me.Controls.Add(Me.lbl_dab)
        Me.Controls.Add(Me.btn_shooter)
        Me.Controls.Add(Me.btn_uth)
        Me.Controls.Add(Me.btn_dab)
        Me.Controls.Add(Me.Button1)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "3 in 1 Games"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btn_dab As System.Windows.Forms.Button
    Friend WithEvents btn_uth As System.Windows.Forms.Button
    Friend WithEvents btn_shooter As System.Windows.Forms.Button
    Friend WithEvents lbl_dab As System.Windows.Forms.Label
    Friend WithEvents lbl_uth As System.Windows.Forms.Label
    Friend WithEvents lbl_shooter As System.Windows.Forms.Label
    Friend WithEvents lbl_default As System.Windows.Forms.Label

End Class
