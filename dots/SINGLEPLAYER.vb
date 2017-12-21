Imports System.IO
Public Class SINGLEPLAYER
    Dim frmFill As Boolean
    Dim W As Integer
    Dim s As String
    Dim ImgPath1, ImgPath2 As String
    Dim dir() As String = Directory.GetDirectories("Images")
    Private Sub TM1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TM1.Tick
        If P2.Location = P1.Location Then
            TM1.Stop()
            P1.Visible = False
            ' Button2.Enabled = True
        Else
            P1.Width -= 10
            P2.Width += 10
            P2.Location = New Point(P1.Location.X + P1.Width, P1.Location.Y)
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TM2.Start()
        P1.Visible = True
        W = P2.Width
        P1.Location = P2.Location
        'Button2.Enabled = False
    End Sub

    Private Sub TM2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TM2.Tick
        If W = P1.Width Then
            TM2.Stop()
            P2.Visible = False
            PB_nxt.Enabled = True
        Else
            P2.Location = New Point(P1.Location.X + P1.Width, P1.Location.Y)
            P1.Width += 10
            P2.Width -= 10
        End If

    End Sub

    Private Sub PB_nxt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PB_nxt.Click
        Dim rd As New Random
        Dim i As Integer = 0
        TM1.Start()
        P2.Visible = True
        DABMain.lbl_name.Text = pname_txt.Text.ToUpper
        DABMain.p1_img.Image = PB_Preview.Image
        PB_nxt.Enabled = False
        Do
            i = rd.Next(1, dir.Length)
        Loop While i - 1 = CB_Image.SelectedIndex
        DABMain.p2_img.Image = Image.FromFile(dir(i - 1).ToString & "\c.png")
        ImgPath2 = dir(i - 1).ToString & "\c.png"
    End Sub

    Private Sub PB_nxt_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PB_nxt.MouseHover
        PB_nxt.Image = My.Resources.n21
    End Sub

    Private Sub PB_nxt_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PB_nxt.MouseLeave
        PB_nxt.Image = My.Resources.n2
    End Sub

    Private Sub CB_Image_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_Image.SelectedIndexChanged
        PB_Preview.Image = Image.FromFile("Images\" & CB_Image.SelectedItem.ToString & "\" & s & ".png")
        ImgPath1 = "Images\" & CB_Image.SelectedItem.ToString & "\" & s & ".png"
        pname_txt.Enabled = False
        PB_nxt.Visible = True
    End Sub

    Private Sub Form2_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        If frmFill = False Then
            DABMain.SetingisToolStripMenuItem.Visible = True
            DABMain.SaveToolStripMenuItem.Enabled = False
            DABMain.UndoToolStripMenuItem.Enabled = False
        End If
    End Sub





    Private Sub Initialize_SinglePlayer(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetScreen.setFrom(Me)
        For Each i As String In dir
            CB_Image.Items.Add(i.Remove(0, i.IndexOf("\") + 1))
        Next
    End Sub

    Private Sub pname_txt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles pname_txt.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            If e.KeyChar = " " Then
                e.Handled = True
            End If
        Else
            e.Handled = True
        End If
    End Sub


    Private Sub pname_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pname_txt.TextChanged
        If pname_txt.Text <> "" Then
            CB_Image.Enabled = True
            s = pname_txt.Text.Chars(0)
        Else
            CB_Image.Enabled = False
        End If
    End Sub


    Private Sub RDB_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RDB_EASY.CheckedChanged, RDB_NORMAL.CheckedChanged, RDB_HARD.CheckedChanged
        If sender.Checked = True Then
            If sender.name.ToString = "RDB_EASY" Then
                'MsgBox("1")
                DABMain.Lbl_level.Text = "EASY"
                DABMain.level = 1
            ElseIf sender.name.ToString = "RDB_NORMAL" Then
                'MsgBox("2")
                DABMain.Lbl_level.Text = "NORMAL"
                DABMain.level = 2
            Else
                ' MsgBox("3")
                DABMain.Lbl_level.Text = "HARD"
                DABMain.level = 3

            End If

            Grid_size.Enabled = True
        End If
    End Sub

    Private Sub StartGame(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        DABMain.Panel_Rules.Visible = False
        DABMain.GridSize = CByte(Grid_size.SelectedIndex + 5)
        DABMain.LBL_Grid.Text = DABMain.GridSize & " X " & DABMain.GridSize
        DABMain.Make_Bord()
        DABMain.TM_Game.Start()
        frmFill = True
        DABMain.lbl_name.Text = pname_txt.Text.ToUpper
        DABMain.lbl_cpu.Text = "C.P.U."
        DABMain.SaveToolStripMenuItem.Enabled = True
        DABMain.UndoToolStripMenuItem.Enabled = True
        If DABMain.FIRST_TURN = 3 Then

            DABMain.Play_As_Easy()
            DABMain.GAME_STAT = True
        ElseIf DABMain.FIRST_TURN = 2 Then
            Dim rd As New Random
            If rd.Next(1, 10) Mod 2 = 0 Then
                DABMain.Play_As_Easy()
                DABMain.FIRST_TURN = 3
                DABMain.GAME_STAT = True
            End If

        End If


        DABMain.PL1.ImgPath = ImgPath1
        DABMain.PL2.ImgPath = ImgPath2
        'MsgBox(Main.PL1.ImgPath & vbNewLine & Main.PL2.ImgPath)
        Me.Close()
    End Sub

    Private Sub Grid_size_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Grid_size.SelectedIndexChanged
        PictureBox4.Visible = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

   
   
End Class