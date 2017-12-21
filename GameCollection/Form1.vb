Public Class Form1
    Dim P_DAB As New Process()
    Dim P_UTH As New Process()
    Dim P_STR As New Process()
    Dim CurPrs As Process
   

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If CurPrs.HasExited Then
            Me.Show()
            Timer1.Stop()
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = Color.Green
        Me.TransparencyKey = Me.BackColor
        Me.Activate()
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        Loading.Close()
    End Sub


    Private Sub btn_shooter_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_shooter.MouseEnter
        sender.FlatStyle = FlatStyle.Standard
        makeInvisible()
        lbl_default.Visible = False
        lbl_shooter.Visible = True
    End Sub
    Private Sub btn_shooter_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_shooter.MouseLeave
        sender.FlatStyle = FlatStyle.Flat
        makeInvisible()
    End Sub

    Private Sub btn_uth_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_uth.MouseEnter
        sender.FlatStyle = FlatStyle.Standard
        makeInvisible()
        lbl_default.Visible = False
        lbl_uth.Visible = True
    End Sub

    Private Sub btn_uth_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_uth.MouseLeave
        sender.FlatStyle = FlatStyle.Flat
        makeInvisible()
    End Sub

    
    Private Sub btn_dab_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_dab.MouseEnter
        sender.FlatStyle = FlatStyle.Standard
        makeInvisible()
        lbl_default.Visible = False
        lbl_dab.Visible = True
    End Sub

    Private Sub btn_dab_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_dab.MouseLeave
        sender.FlatStyle = FlatStyle.Flat
        makeInvisible()
    End Sub
    Sub makeInvisible()
        lbl_shooter.Visible = False
        lbl_uth.Visible = False
        lbl_dab.Visible = False
        lbl_default.Visible = True
    End Sub

    Private Sub btn_dab_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_dab.Click
        Try
            P_DAB.StartInfo.UseShellExecute = False
            P_DAB.StartInfo.FileName = "Dots & Boxes.exe"
            P_DAB.StartInfo.CreateNoWindow = True
            P_DAB.Start()
            Me.Hide()
            CurPrs = P_DAB
            Timer1.Start()
        Catch ex As Exception
            MsgBox((ex.Message))
        End Try
    End Sub

    Private Sub btn_uth_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_uth.Click
        Try
            P_UTH.StartInfo.UseShellExecute = False
            P_UTH.StartInfo.FileName = "Ultimate Treasure Hunt.exe"
            P_UTH.StartInfo.CreateNoWindow = True
            P_UTH.Start()
            Me.Hide()
            CurPrs = P_UTH
            Timer1.Start()
        Catch ex As Exception
            MsgBox((ex.Message))
        End Try
    End Sub

    Private Sub btn_shooter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_shooter.Click
        Try
            P_STR.StartInfo.UseShellExecute = False
            P_STR.StartInfo.FileName = "Shooter.exe"
            P_STR.StartInfo.CreateNoWindow = True
            P_STR.Start()
            Me.Hide()
            CurPrs = P_STR
            Timer1.Start()
        Catch ex As Exception
            MsgBox((ex.Message))
        End Try
    End Sub
End Class
