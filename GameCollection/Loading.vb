Public Class Loading
    Dim Ct As Integer = 0
    Private Sub Loading_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.TransparencyKey = Me.BackColor
        Timer1.Start()
    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label1.Text = Ct & " %"
        If Ct = 100 Then
            Timer1.Stop()
            Me.Hide()
            Form1.Show()
        End If
        Ct = Ct + 2
    End Sub
End Class