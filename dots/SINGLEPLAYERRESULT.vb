Imports System.Windows.Forms

Public Class SINGLEPLAYERRESULT

    
    Private Sub MadeResult(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetScreen.setFrom(Me)
        LBL_FINAL_SCORE.Text = DABMain.Lbl_Ply_Score.Text
        LBL_UNDO.Text = DABMain.LBL_UNDO.Text
        LBL_TURN.Text = DABMain.LBL_LT_PLAY.Text
        DABMain.Lbl_Ply_Score.Text = (DABMain.Lbl_Ply_Score.Text) - (5 * DABMain.LBL_UNDO.Text)
        If Val(DABMain.Lbl_Ply_Score.Text) > Val(DABMain.Lbl_Cpu_Score.Text) Then
            PB_ANIMATE.Image = My.Resources.cheerleaders5
            PB_MSG.Image = My.Resources.you_won
        ElseIf Val(DABMain.Lbl_Ply_Score.Text) < Val(DABMain.Lbl_Cpu_Score.Text) Then
            PB_ANIMATE.Image = My.Resources.cryingbaby
            PB_MSG.Image = My.Resources.you_lost
        Else
            PB_ANIMATE.Image = My.Resources.hand_applause
            PB_MSG.Image = My.Resources.draw_game
        End If
        Lbl_final.Text = DABMain.Lbl_Ply_Score.Text
        HighScore.UpdateFinalScore(DABMain.PL1.Name, CInt(Val(DABMain.Lbl_Ply_Score.Text)), DABMain.level)
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        DABMain.Close()
    End Sub

    Private Sub PictureBox2_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox2.MouseDown
        PictureBox2.Image = My.Resources.yesdn
    End Sub

    Private Sub PictureBox3_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox3.MouseDown
        PictureBox3.Image = My.Resources.nodn
    End Sub

    Private Sub PictureBox2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseLeave
        PictureBox2.Image = My.Resources.yesup
    End Sub

    Private Sub PictureBox2_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox2.MouseUp
        PictureBox2.Image = My.Resources.yesup
    End Sub

    Private Sub PictureBox3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox3.MouseLeave
        PictureBox3.Image = My.Resources.noup
    End Sub

    Private Sub PictureBox3_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox3.MouseUp
        PictureBox3.Image = My.Resources.noup
    End Sub

    
End Class
