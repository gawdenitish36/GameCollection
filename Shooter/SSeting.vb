Public Class SSeting

   
    Private Sub TB_dfclty_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TB_dfclty.Scroll
        txt_dfculty.Value = TB_dfclty.Value
    End Sub

    Private Sub txt_dfculty_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_dfculty.ValueChanged
        TB_dfclty.Value = txt_dfculty.Value
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click


       
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MainShooter.BoardWidth = txt_Gride.Value
        MainShooter.TimeSloat.Interval = (5000 \ txt_dfculty.Value)
        MainShooter.maxWanted = tb_wanted.Value - 1
        MainShooter.MakeBoard()
        Me.Close()
    End Sub

    Private Sub SSeting_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        MainShooter.TimeSloat.Start()
        MainShooter.Timer1.Start()
    End Sub

    Private Sub SSeting_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TbGride_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TbGride.Scroll
        txt_Gride.Value = TbGride.Value
    End Sub

    Private Sub txt_Gride_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Gride.ValueChanged
        TbGride.Value = txt_Gride.Value
    End Sub

    Private Sub txt_wanted_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_wanted.ValueChanged
        tb_wanted.Value = txt_wanted.Value
    End Sub

    Private Sub tb_wanted_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_wanted.Scroll
        txt_wanted.Value = tb_wanted.Value
    End Sub
End Class