Imports System.Windows.Forms

Public Class DOUBLEPLAYERRESULT


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


    Private Sub MadeResult(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetScreen.setFrom(Me)
        LBL_NAME1.Text = DABMain.lbl_name.Text
        LBL_FINAL_SCORE1.Text = DABMain.Lbl_Ply_Score.Text
        LBL_UNDO1.Text = DABMain.LBL_UNDO.Text
        LBL_TURN1.Text = DABMain.LBL_LT_PLAY.Text

        LBL_NAME2.Text = DABMain.lbl_cpu.Text
        LBL_FINAL_SCORE2.Text = DABMain.Lbl_Cpu_Score.Text
        LBL_UNDO2.Text = DABMain.LBL_UNDO.Text
        LBL_TURN2.Text = DABMain.LBL_LT_CPU.Text

        If Val(DABMain.Lbl_Ply_Score.Text) > Val(DABMain.Lbl_Cpu_Score.Text) Then
            PB_ANIMATE1.Image = My.Resources.cheerleaders5
            PB_ANIMATE2.Image = My.Resources.cryingbaby

            PB_MSG1.Image = My.Resources.you_won
            PB_MSG2.Image = My.Resources.you_lost
        ElseIf Val(DABMain.Lbl_Ply_Score.Text) < Val(DABMain.Lbl_Cpu_Score.Text) Then
            PB_ANIMATE2.Image = My.Resources.cheerleaders5
            PB_ANIMATE1.Image = My.Resources.cryingbaby

            PB_MSG2.Image = My.Resources.you_won
            PB_MSG1.Image = My.Resources.you_lost
        Else
            PB_ANIMATE1.Image = My.Resources.hand_applause
            PB_ANIMATE2.Image = My.Resources.hand_applause

            PB_MSG1.Image = My.Resources.draw_game
            PB_MSG2.Image = My.Resources.draw_game
        End If
    End Sub

  

 
  
End Class
