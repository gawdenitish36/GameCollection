<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HighScore
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
        Me.TAB_SCORE = New System.Windows.Forms.TabControl
        Me.TAB_PG_Easy = New System.Windows.Forms.TabPage
        Me.LV_Easy = New System.Windows.Forms.ListView
        Me.Rank = New System.Windows.Forms.ColumnHeader
        Me._Name = New System.Windows.Forms.ColumnHeader
        Me.Score = New System.Windows.Forms.ColumnHeader
        Me._Date = New System.Windows.Forms.ColumnHeader
        Me.TAB_PG_Normal = New System.Windows.Forms.TabPage
        Me.LV_Normal = New System.Windows.Forms.ListView
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.TAB_PG_Hard = New System.Windows.Forms.TabPage
        Me.LV_Hard = New System.Windows.Forms.ListView
        Me.ColumnHeader9 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader10 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader11 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader12 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.TAB_SCORE.SuspendLayout()
        Me.TAB_PG_Easy.SuspendLayout()
        Me.TAB_PG_Normal.SuspendLayout()
        Me.TAB_PG_Hard.SuspendLayout()
        Me.SuspendLayout()
        '
        'TAB_SCORE
        '
        Me.TAB_SCORE.Controls.Add(Me.TAB_PG_Easy)
        Me.TAB_SCORE.Controls.Add(Me.TAB_PG_Normal)
        Me.TAB_SCORE.Controls.Add(Me.TAB_PG_Hard)
        Me.TAB_SCORE.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TAB_SCORE.Location = New System.Drawing.Point(0, 0)
        Me.TAB_SCORE.Name = "TAB_SCORE"
        Me.TAB_SCORE.SelectedIndex = 0
        Me.TAB_SCORE.Size = New System.Drawing.Size(490, 233)
        Me.TAB_SCORE.TabIndex = 0
        '
        'TAB_PG_Easy
        '
        Me.TAB_PG_Easy.Controls.Add(Me.LV_Easy)
        Me.TAB_PG_Easy.Location = New System.Drawing.Point(4, 22)
        Me.TAB_PG_Easy.Name = "TAB_PG_Easy"
        Me.TAB_PG_Easy.Padding = New System.Windows.Forms.Padding(3)
        Me.TAB_PG_Easy.Size = New System.Drawing.Size(480, 233)
        Me.TAB_PG_Easy.TabIndex = 0
        Me.TAB_PG_Easy.Text = "Easy"
        Me.TAB_PG_Easy.UseVisualStyleBackColor = True
        '
        'LV_Easy
        '
        Me.LV_Easy.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Rank, Me._Name, Me.Score, Me._Date})
        Me.LV_Easy.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LV_Easy.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LV_Easy.Location = New System.Drawing.Point(3, 3)
        Me.LV_Easy.Name = "LV_Easy"
        Me.LV_Easy.Size = New System.Drawing.Size(474, 227)
        Me.LV_Easy.TabIndex = 0
        Me.LV_Easy.UseCompatibleStateImageBehavior = False
        Me.LV_Easy.View = System.Windows.Forms.View.Details
        '
        'Rank
        '
        Me.Rank.Text = "Rank"
        Me.Rank.Width = 100
        '
        '_Name
        '
        Me._Name.Text = "Name"
        Me._Name.Width = 130
        '
        'Score
        '
        Me.Score.Text = "Score"
        Me.Score.Width = 100
        '
        '_Date
        '
        Me._Date.Text = "Date"
        Me._Date.Width = 130
        '
        'TAB_PG_Normal
        '
        Me.TAB_PG_Normal.Controls.Add(Me.LV_Normal)
        Me.TAB_PG_Normal.Location = New System.Drawing.Point(4, 22)
        Me.TAB_PG_Normal.Name = "TAB_PG_Normal"
        Me.TAB_PG_Normal.Padding = New System.Windows.Forms.Padding(3)
        Me.TAB_PG_Normal.Size = New System.Drawing.Size(480, 233)
        Me.TAB_PG_Normal.TabIndex = 1
        Me.TAB_PG_Normal.Text = "Normal"
        Me.TAB_PG_Normal.UseVisualStyleBackColor = True
        '
        'LV_Normal
        '
        Me.LV_Normal.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8})
        Me.LV_Normal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LV_Normal.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic)
        Me.LV_Normal.Location = New System.Drawing.Point(3, 3)
        Me.LV_Normal.Name = "LV_Normal"
        Me.LV_Normal.Size = New System.Drawing.Size(474, 227)
        Me.LV_Normal.TabIndex = 1
        Me.LV_Normal.UseCompatibleStateImageBehavior = False
        Me.LV_Normal.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Rank"
        Me.ColumnHeader5.Width = 100
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Name"
        Me.ColumnHeader6.Width = 130
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Score"
        Me.ColumnHeader7.Width = 100
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Date"
        Me.ColumnHeader8.Width = 130
        '
        'TAB_PG_Hard
        '
        Me.TAB_PG_Hard.Controls.Add(Me.LV_Hard)
        Me.TAB_PG_Hard.Location = New System.Drawing.Point(4, 22)
        Me.TAB_PG_Hard.Name = "TAB_PG_Hard"
        Me.TAB_PG_Hard.Padding = New System.Windows.Forms.Padding(3)
        Me.TAB_PG_Hard.Size = New System.Drawing.Size(482, 207)
        Me.TAB_PG_Hard.TabIndex = 2
        Me.TAB_PG_Hard.Text = "Hard"
        Me.TAB_PG_Hard.UseVisualStyleBackColor = True
        '
        'LV_Hard
        '
        Me.LV_Hard.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12})
        Me.LV_Hard.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LV_Hard.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic)
        Me.LV_Hard.Location = New System.Drawing.Point(3, 3)
        Me.LV_Hard.Name = "LV_Hard"
        Me.LV_Hard.Size = New System.Drawing.Size(476, 201)
        Me.LV_Hard.TabIndex = 1
        Me.LV_Hard.UseCompatibleStateImageBehavior = False
        Me.LV_Hard.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Rank"
        Me.ColumnHeader9.Width = 100
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Name"
        Me.ColumnHeader10.Width = 130
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Score"
        Me.ColumnHeader11.Width = 100
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Date"
        Me.ColumnHeader12.Width = 130
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Rank"
        Me.ColumnHeader1.Width = 100
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Name"
        Me.ColumnHeader2.Width = 130
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Score"
        Me.ColumnHeader3.Width = 100
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Date"
        Me.ColumnHeader4.Width = 130
        '
        'HighScore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(490, 233)
        Me.Controls.Add(Me.TAB_SCORE)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "HighScore"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "HighScore"
        Me.TAB_SCORE.ResumeLayout(False)
        Me.TAB_PG_Easy.ResumeLayout(False)
        Me.TAB_PG_Normal.ResumeLayout(False)
        Me.TAB_PG_Hard.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TAB_SCORE As System.Windows.Forms.TabControl
    Friend WithEvents TAB_PG_Easy As System.Windows.Forms.TabPage
    Friend WithEvents TAB_PG_Normal As System.Windows.Forms.TabPage
    Friend WithEvents TAB_PG_Hard As System.Windows.Forms.TabPage
    Friend WithEvents LV_Easy As System.Windows.Forms.ListView
    Friend WithEvents Rank As System.Windows.Forms.ColumnHeader
    Friend WithEvents _Name As System.Windows.Forms.ColumnHeader
    Friend WithEvents Score As System.Windows.Forms.ColumnHeader
    Friend WithEvents _Date As System.Windows.Forms.ColumnHeader
    Friend WithEvents LV_Normal As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents LV_Hard As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader

End Class
