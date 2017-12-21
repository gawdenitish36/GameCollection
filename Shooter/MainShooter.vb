Imports System.IO
Public Class MainShooter
    Dim G As Graphics
    Dim BBG As Graphics
    Dim BB As Bitmap
    Dim dRect As Rectangle
    Dim sRect As Rectangle
    Dim TileWidth As Integer = 64
    Dim TileHeight As Integer = 64
    Dim TileMargin As Integer = 5
    Public BoardWidth As Integer = 5
    Dim PBMx, PBMy As Integer
    Dim TrgPen As New Pen(Color.Black, 2.6)

    Dim T_Sec As Integer = TimeOfDay.Second
    Dim MaxTic As Integer
    Dim T_tac As Integer

    Dim BmpCharActor As Bitmap
    Dim BmpTarget As New Bitmap(SGFX.PBtargat.Image)
    Dim Wnd As ArrayList
    Dim TRT As ArrayList
    Dim SVL As ArrayList
    Dim actors As ArrayList
    Dim PBType As Integer = 0
    Dim CurDir As String = Directory.GetCurrentDirectory

    Dim BmpBlast As Bitmap
    Dim BlFrame As Integer = 0
    Dim BlstStat As Boolean

    Dim RD As New Random
    Dim PbCur As New PictureBox

    'Score
    Public SBlank As Integer
    Public STrt As Integer
    Public TStrt As Integer
    Public SCivil As Integer
    Public TScivil As Integer
    Public SFired As Integer
    Public CurBlast As PictureBox
    Public maxWanted As Integer = 2
    Dim Ar_Actors() As String = Directory.GetFiles(CurDir & "\ActorsImages")

    Private Sub Form1_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        If FinalResult.Visible Then
            FinalResult.BringToFront()
        End If
    End Sub





    Private Sub InitGame(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Pnl_Main_Board.Width = TileWidth * BoardWidth
        Pnl_Main_Board.Height = TileHeight * BoardWidth
        SetScreen.XR = (Screen.PrimaryScreen.Bounds.Width * 100) / 1024
        SetScreen.YR = (Screen.PrimaryScreen.Bounds.Height * 100) / 768
        SetScreen.SetControls(Me)
        SetCentere()
        BmpBlast = New Bitmap(SGFX.PBBlast.Image)
        BmpCharActor = New Bitmap(SGFX.PBCharActor.Image)
        TileWidth = Math.Ceiling(Pnl_Main_Board.Width / BoardWidth)
        TileHeight = Math.Ceiling(Pnl_Main_Board.Height / BoardWidth)
        'GetImagesFromDisk()
        'MakeBoard()
        Me.Focus()


    End Sub
    Sub GetImages()
        GBWanted.Controls.Clear()
        TRT = New ArrayList
        SVL = New ArrayList
        actors = New ArrayList
        Dim Ar_SVL As New ArrayList
        Dim Ar_TRT As New ArrayList

        Dim ArL_Actors As New ArrayList

        ArL_Actors.AddRange(Ar_Actors)
        Dim maxAct As Integer = ArL_Actors.Count - 1
        For i As Integer = 0 To maxWanted
            Dim ri As Integer = RD.Next(0, ArL_Actors.Count)
            Ar_TRT.Add(ArL_Actors.Item(ri))
            ArL_Actors.RemoveAt(ri)
        Next
        Ar_SVL.AddRange(ArL_Actors)
        For Each i As String In Ar_SVL
            SVL.Add(Image.FromFile(i))
        Next
        Dim y, x As Integer
        For Each i As String In Ar_TRT
            TRT.Add(Image.FromFile(i))
            Dim pb As New PictureBox
            pb.Height = TileHeight
            pb.Width = TileWidth
            pb.Location = New Point(x * TileWidth + 20, y * TileHeight + 30)
            pb.SizeMode = PictureBoxSizeMode.StretchImage
            pb.BorderStyle = BorderStyle.Fixed3D
            x += 1
            If x = 3 Then
                x = 0
                y += 1
            End If
            pb.Image = Image.FromFile(i)
            GBWanted.Controls.Add(pb)
        Next

    End Sub
    Sub MakeBoard()
        GetImages()
        Pnl_Main_Board.Width = TileWidth * BoardWidth
        Pnl_Main_Board.Height = TileHeight * BoardWidth
        'SetScreen.SetControls(Me)
        SetCentere()
        Pnl_Main_Board.Controls.Clear()
        Pnl_Main_Board.Visible = True
        SBlank = 0
        STrt = 0
        SCivil = 0
        SFired = 0
        TStrt = 0
        TScivil = 0
        lbl_blank.Text = SBlank
        lbl_cvil.Text = SCivil
        lbl_fird.Text = SFired
        lbl_trt.Text = STrt
        Wnd = New ArrayList
        Dim PB As PictureBox
        For x As Integer = 0 To BoardWidth - 1
            For y As Integer = 0 To BoardWidth - 1
                PB = New PictureBox
                PB.Height = TileHeight - TileMargin
                PB.Width = TileWidth - TileMargin
                PB.Location = New Point(x * TileWidth, y * TileHeight)
                'BmpCharActor.MakeTransparent()
                PB.Image = My.Resources.win
                PB.SizeMode = PictureBoxSizeMode.StretchImage
                PB.BorderStyle = BorderStyle.Fixed3D
                AddHandler PB.Click, AddressOf Shoot
                Pnl_Main_Board.Controls.Add(PB)
                Wnd.Add(PB)
                'MsgBox("")
            Next
        Next
        Pnl_Main_Board.Cursor = New Cursor(BmpTarget.GetHicon)
        Timer1.Start()
        TimeSloat.Start()
    End Sub



    Sub SetCentere()
        PNl_Board.Width = Me.Width - PNL_Board_Side.Width
        Pnl_Main_Board.Location = New Point((PNl_Board.Width / 2 - Pnl_Main_Board.Width / 2), (PNl_Board.Height / 2 - Pnl_Main_Board.Height / 2))
    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If BlstStat Then
            sRect = New Rectangle((BlFrame Mod 14) * 64, 0, 64, 64)
            dRect = New Rectangle(0 - TileWidth \ 2, 0 - TileHeight \ 2, TileWidth * 2, TileHeight * 2)
            G.DrawImage(BmpBlast, dRect, sRect, GraphicsUnit.Pixel)
            BlFrame += 1
            If BlFrame >= 14 Then
                BlstStat = False
                BlFrame = 0
                CurBlast.Image = Nothing
            End If

        End If

    End Sub


    Private Sub Shoot(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Click
        If sender.GetType.ToString = "System.Windows.Forms.PictureBox" And BlstStat = False Then
            Wnd.Remove(sender)
            CurBlast = sender
            sender.Enabled = False
            G = sender.CreateGraphics()
            BlstStat = True
            SFired += 1
            UpdateScore(sender)
        End If

    End Sub

    Sub UpdateScore(ByVal sender As Object)
        If sender.Equals(PbCur) Then
            If PBType = 1 Then
                STrt += 1

            Else
                SCivil += 1

            End If
        Else
            SBlank += 1
        End If
        lbl_blank.Text = SBlank
        lbl_cvil.Text = SCivil
        lbl_fird.Text = SFired
        lbl_trt.Text = STrt
    End Sub
    Private Sub OpenNewWindow(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimeSloat.Tick
        If Wnd.Count > 0 Then
            PbCur.Enabled = False
            If RD.Next(0, 2) = 0 Then
                PbCur = Wnd.Item(RD.Next(0, Wnd.Count))
                PbCur.Image = TRT.Item(RD.Next(0, TRT.Count))
                PBType = 1
                TStrt += 1
            Else
                PbCur = Wnd.Item(RD.Next(0, Wnd.Count))
                PbCur.Image = SVL.Item(RD.Next(0, SVL.Count))
                PBType = 2
                TScivil += 1
            End If
            Wnd.Remove(PbCur)
        Else
            If BlstStat = False Then
                TimeSloat.Stop()
                Timer1.Stop()
                PbCur.Enabled = False
                BlstStat = False
                FinalResult.Show(Me)
            End If
        End If

    End Sub

    Private Sub OptionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptionsToolStripMenuItem.Click
        TimeSloat.Stop()
        Timer1.Stop()
        SSeting.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click
        MakeBoard()
    End Sub


    Private Sub HelpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpToolStripMenuItem.Click
        ShooterHelp.ShowDialog()
    End Sub

   
End Class
