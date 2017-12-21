Imports System.IO
Public Class DOUBLEPLAYER
    Dim frmFill As Boolean
    Dim W As Integer
    Dim s1, s2 As String
    Dim Text_TYPE_List As New ArrayList
    Dim IMG1Stat, IMG2Stat As Boolean
    Dim ImgPath1, ImgPath2 As String
    Dim dir() As String = Directory.GetDirectories("Images")



    Private Sub PB_nxt_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs)
        'PB_nxt.Image = My.Resources.n21
    End Sub

    Private Sub PB_nxt_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs)
        'PB_nxt.Image = My.Resources.n2
    End Sub

    Private Sub CB_Image_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_Image.SelectedIndexChanged

        PB_Preview.Image = Image.FromFile("Images\" & CB_Image.SelectedItem.ToString & "\" & s1 & ".png")
        ImgPath1 = "Images\" & CB_Image.SelectedItem.ToString & "\" & s1 & ".png"
        pname_txt.Enabled = False
        If s1 = s2 And s1 <> "" Then
            CB_Image2.Items.Clear()
            For Each i As String In Text_TYPE_List.ToArray
                CB_Image2.Items.Add(i)
            Next
            CB_Image2.Items.Remove(CB_Image.SelectedItem.ToString)
        End If
        IMG1Stat = True
        If IMG1Stat = True And IMG2Stat = True Then
            Grid_size.Enabled = True
        End If
        'PB_nxt.Visible = True
    End Sub

    Private Sub Form2_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed


        If frmFill = False Then
            DABMain.SetingisToolStripMenuItem.Visible = True
            DABMain.SaveToolStripMenuItem.Enabled = False
            DABMain.UndoToolStripMenuItem.Enabled = False
        End If
    End Sub





    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetScreen.setFrom(Me)
        s1 = ""
        s2 = ""
        Dim TXT_TYPE As String
        For Each i As String In dir
            TXT_TYPE = i.Remove(0, i.IndexOf("\") + 1)
            CB_Image.Items.Add(TXT_TYPE)
            CB_Image2.Items.Add(TXT_TYPE)
            Text_TYPE_List.Add(TXT_TYPE)
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

    Private Sub pname2_txt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles pname2_txt.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            If e.KeyChar = " " Then
                e.Handled = True
            End If
        Else
            e.Handled = True
        End If
    End Sub


    Private Sub pname_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pname_txt.TextChanged, pname2_txt.TextChanged
        If pname_txt.Text <> "" And pname2_txt.Text <> "" Then
            CB_Image.Enabled = True
            s1 = pname_txt.Text.Chars(0)
            CB_Image2.Enabled = True
            s2 = pname2_txt.Text.Chars(0)
        Else
            CB_Image.Enabled = False
            CB_Image2.Enabled = False
        End If


    End Sub




    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Play.Click
        DABMain.Panel_Rules.Visible = False
        DABMain.GridSize = CByte(Grid_size.SelectedIndex + 5)
        DABMain.LBL_Grid.Text = DABMain.GridSize & " X " & DABMain.GridSize
        DABMain.Make_Bord()
        DABMain.TM_Game.Start()
        frmFill = True
        DABMain.PL1.Name = pname_txt.Text.ToUpper
        DABMain.lbl_name.Text = DABMain.PL1.Name
        DABMain.PL2.Name = pname2_txt.Text.ToUpper
        DABMain.lbl_cpu.Text = DABMain.PL2.Name
        DABMain.SaveToolStripMenuItem.Enabled = True
        DABMain.UndoToolStripMenuItem.Enabled = True
        If DABMain.FIRST_TURN = 3 Then
            players.Turn = True
            DABMain.LBL_Turn.Text = DABMain.PL2.Name
        ElseIf DABMain.FIRST_TURN = 2 Then
            Dim rd As New Random
            If rd.Next(1, 10) Mod 2 = 0 Then
                players.Turn = True
                DABMain.LBL_Turn.Text = DABMain.PL2.Name
            Else
                players.Turn = False
                DABMain.LBL_Turn.Text = DABMain.PL1.Name
            End If
        Else
            DABMain.LBL_Turn.Text = DABMain.PL1.Name

        End If
        DABMain.p1_img.Image = PB_Preview.Image
        DABMain.p2_img.Image = PB_Preview2.Image
        DABMain.PL1.ImgPath = ImgPath1
        DABMain.PL2.ImgPath = ImgPath2
        Me.Close()
    End Sub

    Private Sub CB_Image2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_Image2.SelectedIndexChanged
        PB_Preview2.Image = Image.FromFile("Images\" & CB_Image2.SelectedItem.ToString & "\" & s2 & ".png")
        ImgPath2 = "Images\" & CB_Image2.SelectedItem.ToString & "\" & s2 & ".png"
        pname2_txt.Enabled = False
        If s1 = s2 And s1 <> "" Then
            CB_Image.Items.Clear()
            For Each i As String In Text_TYPE_List.ToArray
                CB_Image.Items.Add(i)
            Next
            CB_Image.Items.Remove(CB_Image2.SelectedItem.ToString)
        End If
        IMG2Stat = True
        If IMG1Stat = True And IMG2Stat = True Then
            Grid_size.Enabled = True
        End If
    End Sub

   
    Private Sub Grid_size_SelectedIndexChanged1(ByVal sender As Object, ByVal e As System.EventArgs) Handles Grid_size.SelectedIndexChanged
        Btn_Play.Visible = True
    End Sub



   
End Class