<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SSeting
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
        Me.TB_dfclty = New System.Windows.Forms.TrackBar
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.txt_dfculty = New System.Windows.Forms.NumericUpDown
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.txt_Gride = New System.Windows.Forms.NumericUpDown
        Me.Label2 = New System.Windows.Forms.Label
        Me.TbGride = New System.Windows.Forms.TrackBar
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.txt_wanted = New System.Windows.Forms.NumericUpDown
        Me.Label3 = New System.Windows.Forms.Label
        Me.tb_wanted = New System.Windows.Forms.TrackBar
        CType(Me.TB_dfclty, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.txt_dfculty, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.txt_Gride, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbGride, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.txt_wanted, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tb_wanted, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Chartreuse
        Me.Label1.Location = New System.Drawing.Point(24, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Difficulty   : "
        '
        'TB_dfclty
        '
        Me.TB_dfclty.LargeChange = 1
        Me.TB_dfclty.Location = New System.Drawing.Point(14, 35)
        Me.TB_dfclty.Maximum = 5
        Me.TB_dfclty.Minimum = 1
        Me.TB_dfclty.Name = "TB_dfclty"
        Me.TB_dfclty.Size = New System.Drawing.Size(300, 45)
        Me.TB_dfclty.TabIndex = 1
        Me.TB_dfclty.Value = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(7, 283)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(157, 44)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Save And StartNew Game"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(181, 285)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(157, 44)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gray
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.txt_dfculty)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TB_dfclty)
        Me.Panel1.Location = New System.Drawing.Point(7, 15)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(332, 85)
        Me.Panel1.TabIndex = 5
        '
        'txt_dfculty
        '
        Me.txt_dfculty.Location = New System.Drawing.Point(275, 13)
        Me.txt_dfculty.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.txt_dfculty.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txt_dfculty.Name = "txt_dfculty"
        Me.txt_dfculty.Size = New System.Drawing.Size(39, 20)
        Me.txt_dfculty.TabIndex = 6
        Me.txt_dfculty.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Gray
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.txt_Gride)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.TbGride)
        Me.Panel2.Location = New System.Drawing.Point(7, 103)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(332, 85)
        Me.Panel2.TabIndex = 7
        '
        'txt_Gride
        '
        Me.txt_Gride.Location = New System.Drawing.Point(275, 13)
        Me.txt_Gride.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.txt_Gride.Minimum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.txt_Gride.Name = "txt_Gride"
        Me.txt_Gride.Size = New System.Drawing.Size(39, 20)
        Me.txt_Gride.TabIndex = 6
        Me.txt_Gride.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Chartreuse
        Me.Label2.Location = New System.Drawing.Point(24, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Grid   : "
        '
        'TbGride
        '
        Me.TbGride.LargeChange = 1
        Me.TbGride.Location = New System.Drawing.Point(14, 35)
        Me.TbGride.Minimum = 5
        Me.TbGride.Name = "TbGride"
        Me.TbGride.Size = New System.Drawing.Size(300, 45)
        Me.TbGride.TabIndex = 1
        Me.TbGride.Value = 5
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Gray
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.txt_wanted)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.tb_wanted)
        Me.Panel3.Location = New System.Drawing.Point(7, 194)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(332, 85)
        Me.Panel3.TabIndex = 8
        '
        'txt_wanted
        '
        Me.txt_wanted.Location = New System.Drawing.Point(275, 13)
        Me.txt_wanted.Maximum = New Decimal(New Integer() {9, 0, 0, 0})
        Me.txt_wanted.Minimum = New Decimal(New Integer() {3, 0, 0, 0})
        Me.txt_wanted.Name = "txt_wanted"
        Me.txt_wanted.Size = New System.Drawing.Size(39, 20)
        Me.txt_wanted.TabIndex = 6
        Me.txt_wanted.Value = New Decimal(New Integer() {3, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Chartreuse
        Me.Label3.Location = New System.Drawing.Point(24, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Wanted List  : "
        '
        'tb_wanted
        '
        Me.tb_wanted.LargeChange = 1
        Me.tb_wanted.Location = New System.Drawing.Point(14, 35)
        Me.tb_wanted.Maximum = 9
        Me.tb_wanted.Minimum = 3
        Me.tb_wanted.Name = "tb_wanted"
        Me.tb_wanted.Size = New System.Drawing.Size(300, 45)
        Me.tb_wanted.TabIndex = 1
        Me.tb_wanted.Value = 3
        '
        'SSeting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(353, 337)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SSeting"
        Me.Text = "Seting"
        CType(Me.TB_dfclty, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.txt_dfculty, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.txt_Gride, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbGride, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.txt_wanted, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tb_wanted, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TB_dfclty As System.Windows.Forms.TrackBar
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txt_dfculty As System.Windows.Forms.NumericUpDown
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txt_Gride As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TbGride As System.Windows.Forms.TrackBar
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents txt_wanted As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tb_wanted As System.Windows.Forms.TrackBar
End Class
