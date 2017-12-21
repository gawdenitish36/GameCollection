Imports System.IO
Public Class DABMain

    Dim Second As Integer = 0
    Dim Minute As Integer = 0
    Dim Hour As Integer = 0

    Dim Game_Type As Boolean
    Public GAME_STAT As Boolean
    Public FIRST_TURN As Byte
    Dim BordUpdateStat As Boolean
    Public level As Int16 = 0
    Dim hline() As Lines
    Dim vline() As Lines
    Public GridSize As Byte
    Dim CellWidth As Integer
    Dim CellHeight As Integer
    Dim ColorOfDot As New Pen(Color.Black, 2.6)
    Const MarginOfDots As Integer = 10
    Dim ColorOfLine As New Pen(Color.Black, 4)
    Dim ColorOfHilight As New Pen(Color.Green, 4)
    Dim Cell() As Cells
    Dim MaxCell As Integer
    Dim MaxLine As Integer
    Public PL1, PL2 As players
    Dim LineCollection As ArrayList
    Dim CellCollection As ArrayList
    Dim CPULastMove As Lines
    Dim CPULastMoveCounter As Int16 = 0
    Dim MouseClikVisible As Boolean = True
    Public CurrentDir As String = ""

    Dim PlayNormalStat As Boolean

    Dim UNDO As New Stack(Of DOUNDO)

    Dim Rules_Text As New TextBox
    Dim Rule_Index As Integer = 0


    Public Sub Make_Bord()


        Dim i, j As Integer
        Dim x1, x2, y1, y2 As Integer
        If Game_Type = False Then
            LineCollection = New ArrayList
            CellCollection = New ArrayList
        End If
        PL1 = New players
        PL1.Name = lbl_name.Text
        PL2 = New players
        PL2.Name = lbl_cpu.Text
        LBL_Turn.Text = PL1.Name
        PB_Bord.Controls.Clear()

        PB_Bord.Visible = True
        Bord_Panel.Controls.Add(PB_Bord)
        PB_Bord.BackColor = Color.White

        PB_Bord.Size = New Point((CellWidth * GridSize) + (MarginOfDots * 2), (CellHeight * GridSize) + (MarginOfDots * 2))
        PB_Bord.Location = New Point((Bord_Panel.Width / 2) - (PB_Bord.Width / 2), (Bord_Panel.Height / 2) - (PB_Bord.Height / 2))
        MaxLine = (GridSize + 1) * GridSize



        ReDim hline(MaxLine)

        x1 = MarginOfDots
        y1 = MarginOfDots
        x2 = MarginOfDots + CellWidth
        y2 = MarginOfDots
        For i = 1 To MaxLine
            hline(i - 1) = New Lines
            hline(i - 1).StartPoint = New Point(x1, y1)
            hline(i - 1).EndPoint = New Point(x2, y2)
            x1 += CellWidth
            x2 = x1 + CellWidth
            If i Mod GridSize = 0 Then
                y1 += CellHeight
                y2 += CellHeight
                x1 = MarginOfDots
                x2 = MarginOfDots + CellWidth
            End If
            If Game_Type = False Then
                LineCollection.Add(hline(i - 1))
            End If
        Next

        ReDim vline(MaxLine)
        x1 = MarginOfDots
        y1 = MarginOfDots
        x2 = MarginOfDots
        y2 = MarginOfDots + CellHeight
        For i = 1 To MaxLine
            vline(i - 1) = New Lines
            vline(i - 1).StartPoint = New Point(x1, y1)
            vline(i - 1).EndPoint = New Point(x2, y2)
            y1 += CellHeight
            y2 = y1 + CellHeight
            If i Mod GridSize = 0 Then
                y1 = MarginOfDots
                y2 = MarginOfDots + CellHeight
                x1 += CellWidth
                x2 += CellWidth
            End If
            If Game_Type = False Then
                LineCollection.Add(vline(i - 1))
            End If
        Next

        MaxCell = (GridSize ^ 2) - 1
        ReDim Cell(MaxCell)
        For i = 1 To MaxCell + 1
            Cell(i - 1) = New Cells()
            Cell(i - 1).LineAbove = hline(i - 1)
            Cell(i - 1).LineUnder = hline(i + GridSize - 1)
            If Game_Type = False Then
                CellCollection.Add(Cell(i - 1))
            End If
        Next

        Dim ii As Integer = 0
        j = 0
        For i = 1 To (MaxCell + 1)
            Cell(ii).LineBehind = vline(i - 1)
            Cell(ii).LineAhead = vline(i + GridSize - 1)
            ii += GridSize
            If i Mod GridSize = 0 Then
                j = j + 1
                ii = j
            End If
        Next
        '}





        PB_Bord.Refresh()

    End Sub

    Private Sub Players_Play_Move(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PB_Bord.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Left And MouseClikVisible = True Then
            GAME_STAT = True
            If BordUpdateStat = False Then
                Undo_Save_Point()
                BordUpdateStat = True
            End If
            Dim Player_Played As Boolean = False
            Dim Last_Play_by_Player As New Lines
            Dim MouseLocation As New Point(e.Location)

            Dim Cell_X As Single = Math.Floor((MouseLocation.X - MarginOfDots) / CellWidth)
            Dim Cell_Y As Single = Math.Floor((MouseLocation.Y - MarginOfDots) / CellHeight)

            If Cell_X >= (GridSize) Or Cell_Y >= (GridSize) Then
                Exit Sub
            End If


            Dim InCell_X As Single = Math.Floor(((MouseLocation.X - MarginOfDots) Mod CellWidth) / (CellWidth / 3))
            Dim InCell_Y As Single = Math.Floor(((MouseLocation.Y - MarginOfDots) Mod CellHeight) / (CellHeight / 3))


            Dim Cell_No As Integer = Math.Abs((Cell_Y * (GridSize)) + Cell_X)

            If (InCell_X = 0) And (InCell_Y = 1) Then
                If Cell(Cell_No).LineBehind.Used = False Then
                    Player_Played = True
                    BordUpdateStat = False
                    If Game_Type = False Then
                        LBL_LT_PLAY.Text = Val(LBL_LT_PLAY.Text) + 1
                        Last_Play_by_Player = Cell(Cell_No).LineBehind
                        LineCollection.Remove(Cell(Cell_No).LineBehind)
                    Else

                    End If
                End If
                Cell(Cell_No).LineBehind.Used = True

            ElseIf (InCell_X = 2) And (InCell_Y = 1) Then
                If Cell(Cell_No).LineAhead.Used = False Then
                    Player_Played = True
                    BordUpdateStat = False
                    If Game_Type = False Then
                        LBL_LT_PLAY.Text = Val(LBL_LT_PLAY.Text) + 1
                        Last_Play_by_Player = Cell(Cell_No).LineAhead
                        LineCollection.Remove(Cell(Cell_No).LineAhead)

                    Else
                    End If
                End If
                Cell(Cell_No).LineAhead.Used = True

            ElseIf (InCell_Y = 0) And (InCell_X = 1) Then
                If Cell(Cell_No).LineAbove.Used = False Then
                    Player_Played = True
                    BordUpdateStat = False
                    If Game_Type = False Then
                        LBL_LT_PLAY.Text = Val(LBL_LT_PLAY.Text) + 1
                        Last_Play_by_Player = Cell(Cell_No).LineAbove
                        LineCollection.Remove(Cell(Cell_No).LineAbove)
                    Else

                    End If
                End If
                Cell(Cell_No).LineAbove.Used = True

            ElseIf (InCell_Y = 2) And (InCell_X = 1) Then
                If Cell(Cell_No).LineUnder.Used = False Then
                    Player_Played = True
                    BordUpdateStat = False
                    If Game_Type = False Then
                        LBL_LT_PLAY.Text = Val(LBL_LT_PLAY.Text) + 1
                        Last_Play_by_Player = Cell(Cell_No).LineUnder
                        LineCollection.Remove(Cell(Cell_No).LineUnder)

                    Else

                    End If
                End If
                Cell(Cell_No).LineUnder.Used = True

            End If

            IncreseCellCounter()
            PB_Bord.Refresh()
            If Game_Type = True Then
                If Player_Played = True Then
                    If players.Turn = False Then
                        LBL_LT_PLAY.Text = Val(LBL_LT_PLAY.Text) + 1
                    Else
                        LBL_LT_CPU.Text = Val(LBL_LT_CPU.Text) + 1
                    End If
                    If CheckComplateBlock(players.Turn) = True Then
                        check_Game_Stat()
                        Exit Sub
                    End If
                    If players.Turn = True Then
                        LBL_Turn.Text = PL1.Name
                        players.Turn = False
                    Else
                        LBL_Turn.Text = PL2.Name
                        players.Turn = True
                    End If

                End If
                Exit Sub
            End If



            If CheckComplateBlock(0) = False And Player_Played = True Then

                Dim LOOP_CT As Integer = 0
                Do
                    MakeLastLineOfBoxe()
                    LOOP_CT += 1
                    IncreseCellCounter()
                    PB_Bord.Refresh()

                Loop While CheckComplateBlock(1) = True And LineCollection.Count > 0
                If LOOP_CT > 1 Then
                    LBL_LT_CPU.Text = Val(LBL_LT_CPU.Text) + LOOP_CT - 1
                End If

                If LineCollection.Count > 0 Then
                    If level = 1 Then
                        Play_As_Easy()
                    ElseIf level = 2 Then
                        Play_As_Normal()
                    Else
                        Play_As_Hard()
                    End If

                    LBL_LT_CPU.Text = Val(LBL_LT_CPU.Text) + 1
                End If
                IncreseCellCounter()
                PB_Bord.Refresh()
                MouseClikVisible = False
                TM_Hilight.Start()

            End If

            If level = 3 And LineCollection.Count < (MaxLine - 4) Then
                Set_Cpu_Count()
            End If
        End If
        check_Game_Stat()
    End Sub
    Sub check_Game_Stat()
        If Val(Lbl_Ply_Score.Text) + Val(Lbl_Cpu_Score.Text) = (MaxCell + 1) * 10 Then

            UNDO.Clear()
            TM_Game.Stop()
            GAME_STAT = False
            PlayNormalStat = False
            MouseClikVisible = False
            SetingisToolStripMenuItem.Visible = True
            Panel_Rules.Visible = True
            SaveToolStripMenuItem.Enabled = False
            UndoToolStripMenuItem.Enabled = False
            If Game_Type = False Then

                SINGLEPLAYERRESULT.ShowDialog(Me)
            Else
                DOUBLEPLAYERRESULT.ShowDialog(Me)
            End If

            ' PB_Animate.Visible = True
        End If
    End Sub

    Sub IncreseCellCounter()
        For i As Integer = 0 To MaxCell
            Cell(i).CellLineUsed = 0
            If Cell(i).LineAbove.Used = True Then : Cell(i).CellLineUsed += 1 : End If
            If Cell(i).LineAhead.Used = True Then : Cell(i).CellLineUsed += 1 : End If
            If Cell(i).LineBehind.Used = True Then : Cell(i).CellLineUsed += 1 : End If
            If Cell(i).LineUnder.Used = True Then : Cell(i).CellLineUsed += 1 : End If
        Next
    End Sub
    Private Function CheckComplateBlock(ByVal PlayerIndex As Boolean) As Boolean
        Dim BOXMADE As Boolean = False
        For i As Integer = 0 To MaxCell
            If Cell(i).CellLineUsed = 4 And Cell(i).CellImageUsed = False Then
                If Game_Type = False Then
                    CellCollection.Remove(Cell(i))
                End If
                Dim PB As New PictureBox
                PB_Bord.Controls.Add(PB)
                PB.Height = CellHeight - MarginOfDots
                PB.Width = CellWidth - MarginOfDots
                PB.BackColor = Color.Transparent

                Cell(i).CellOwner = CByte(CInt(PlayerIndex) * -1)

                If PlayerIndex = 0 Then
                    PB.Image = p1_img.Image
                    Lbl_Ply_Score.Text = CInt(Val(Lbl_Ply_Score.Text)) + 10
                Else
                    PB.Image = p2_img.Image
                    Lbl_Cpu_Score.Text = CInt(Val(Lbl_Cpu_Score.Text)) + 10
                End If

                PB.Location = New Point(Cell(i).LineAbove.StartPoint.X + (MarginOfDots \ 2), Cell(i).LineBehind.StartPoint.Y + (MarginOfDots \ 2))
                PB.SizeMode = PictureBoxSizeMode.StretchImage
                Cell(i).CellImage = PB
                Cell(i).CellImageUsed = True
                BOXMADE = True
            End If
        Next
        Return BOXMADE
    End Function

    Private Sub pb_bord_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PB_Bord.MouseLeave
        For i As Integer = 0 To MaxLine - 1
            vline(i).Hilight = False
            hline(i).Hilight = False
        Next
        PB_Bord.Refresh()
    End Sub

    Private Sub Player_Move_Hilight(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PB_Bord.MouseMove

        PB_Bord.Cursor = Cursors.Hand
        Dim MouseLocation As New Point(e.Location)

        Dim Cell_X As Single = Math.Floor((MouseLocation.X - MarginOfDots) / CellWidth)
        Dim Cell_Y As Single = Math.Floor((MouseLocation.Y - MarginOfDots) / CellHeight)



        If Cell_X >= (GridSize) Or Cell_Y >= (GridSize) Then Exit Sub

        Dim InCell_X As Single = Math.Floor(((MouseLocation.X - MarginOfDots) Mod CellWidth) / (CellWidth / 3))
        Dim InCell_Y As Single = Math.Floor(((MouseLocation.Y - MarginOfDots) Mod CellHeight) / (CellHeight / 3))

        Dim Cell_No As Integer = Math.Abs((Cell_Y * (GridSize)) + Cell_X)


        If (InCell_X = 0) And (InCell_Y = 1) Then

            Cell(Cell_No).LineBehind.Hilight = True

        ElseIf (InCell_X = 2) And (InCell_Y = 1) Then

            Cell(Cell_No).LineAhead.Hilight = True

        ElseIf (InCell_Y = 0) And (InCell_X = 1) Then

            Cell(Cell_No).LineAbove.Hilight = True

        ElseIf (InCell_Y = 2) And (InCell_X = 1) Then

            Cell(Cell_No).LineUnder.Hilight = True

        End If

        PB_Bord.Refresh()

    End Sub

    Private Sub Update_Game_bord(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles PB_Bord.Paint
        drawDots(e.Graphics)
        drawLines(e.Graphics)
    End Sub

    Private Sub drawDots(ByRef g As Graphics)
        For y As Integer = 0 To (GridSize)
            For x As Integer = 0 To (GridSize)
                g.DrawEllipse(ColorOfDot, MarginOfDots + ((CellWidth * x) - ColorOfDot.Width), MarginOfDots + ((CellHeight * y) - ColorOfDot.Width), (2 * ColorOfDot.Width), (2 * ColorOfDot.Width))
            Next
        Next
    End Sub
    Private Sub drawLines(ByRef g As Graphics)


        For i As Integer = 0 To MaxLine - 1
            If hline(i).Used = True Then
                g.DrawLine(ColorOfLine, hline(i).StartPoint, hline(i).EndPoint)
            ElseIf hline(i).Hilight = True Then
                g.DrawLine(ColorOfHilight, hline(i).StartPoint, hline(i).EndPoint)
                hline(i).Hilight = False
            End If
            If vline(i).Used = True Then
                g.DrawLine(ColorOfLine, vline(i).StartPoint, vline(i).EndPoint)
            ElseIf vline(i).Hilight = True Then
                g.DrawLine(ColorOfHilight, vline(i).StartPoint, vline(i).EndPoint)
                vline(i).Hilight = False
            End If
        Next


    End Sub

    Private Sub Form1_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        If CurrentDir <> "" Then
            Directory.SetCurrentDirectory(CurrentDir)
        End If
        If Game_Type = False Then
            If SINGLEPLAYER.Visible = True Then
                SINGLEPLAYER.BringToFront()
            End If

        Else
            If DOUBLEPLAYER.Visible = True Then
                DOUBLEPLAYER.BringToFront()
            End If
        End If
    End Sub

    Private Sub Main_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        HighScore.SaveScore()
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If GAME_STAT = True Then
            Dim res As MsgBoxResult
            res = MsgBox("You Trying TO Close Running Game." & vbNewLine & "Do You Want save This Game?", MsgBoxStyle.YesNoCancel, "Warrning...!!!")
            If res = MsgBoxResult.No Then

            ElseIf res = MsgBoxResult.Yes Then
                If Save_File() = False Then
                    e.Cancel = True
                End If
            Else
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub Initialize_Game(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetScreen.XR = (Screen.PrimaryScreen.Bounds.Width * 100) / 1024
        SetScreen.YR = (Screen.PrimaryScreen.Bounds.Height * 100) / 768
        SetScreen.SetControls(Me)



        Me.Height = My.Computer.Screen.WorkingArea.Height
        Me.Width = My.Computer.Screen.WorkingArea.Width
        Bord_Panel.Width = Me.Width - Panel1.Width
        CurrentDir = Directory.GetCurrentDirectory
        HighScore.LoadScore()
        Me.MinimumSize = Me.Size
        CellWidth = Bord_Panel.Width / 12
        CellHeight = Bord_Panel.Height / 12
        Dim SR As New StreamReader("rules.txt")
        Rules_Text.Text = SR.ReadToEnd
        TM_Rules.Start()


    End Sub















    Private Sub btn_start_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_start.MouseHover
        btn_start.BackgroundImage = My.Resources.ngd
    End Sub

    Private Sub btn_start_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_start.MouseLeave
        btn_start.BackgroundImage = My.Resources.ng_n
    End Sub


    Sub Play_As_Easy()
        Dim Rendom_Line_Type As New Random
        Dim Sub_Line As New Random
        Dim Index As Integer
        Index = Rendom_Line_Type.Next(0, LineCollection.Count)
        LineCollection.Item(Index).used = True
        CPULastMove = LineCollection.Item(Index)
        LineCollection.RemoveAt(Index)
        'MsgBox(Remain_Line_index.Count)
    End Sub


    Sub Play_As_Normal()
        Dim First_Step As Boolean


        Dim Rendom_Line_Type As New Random
        Dim Sub_Line As New Random
        Dim Index As Integer
        Index = Rendom_Line_Type.Next(0, LineCollection.Count)
        If MakeBox(LineCollection.Item(Index)) = False Then
            LineCollection.Item(Index).used = True
            CPULastMove = LineCollection.Item(Index)
            LineCollection.RemoveAt(Index)
            Exit Sub
        End If




        For Each i As Cells In CellCollection
            If i.CellLineUsed < 4 Then
                If i.LineAbove.Used = False Then
                    If MakeBox(i.LineAbove) = False Then
                        First_Step = True
                        i.LineAbove.Used = True
                        CPULastMove = i.LineAbove
                        LineCollection.Remove(i.LineAbove)
                        Exit Sub
                    End If
                End If
                If i.LineUnder.Used = False Then
                    If MakeBox(i.LineUnder) = False Then
                        First_Step = False
                        i.LineUnder.Used = True
                        CPULastMove = i.LineUnder
                        LineCollection.Remove(i.LineUnder)
                        Exit Sub
                    End If
                End If
                If i.LineAhead.Used = False Then
                    If MakeBox(i.LineAhead) = False Then
                        First_Step = False
                        i.LineAhead.Used = True
                        CPULastMove = i.LineAhead
                        LineCollection.Remove(i.LineAhead)
                        Exit Sub
                    End If
                End If
                If i.LineBehind.Used = False Then
                    If MakeBox(i.LineBehind) = False Then
                        First_Step = False
                        i.LineBehind.Used = True
                        CPULastMove = i.LineBehind
                        LineCollection.Remove(i.LineBehind)
                        Exit Sub
                    End If
                End If
            End If
        Next
        If level = 3 Then
            PlayNormalStat = True
        End If

        If level = 2 Then
            Play_As_Easy()
        End If


    End Sub
    Function MakeBox(ByVal Ln As Lines) As Boolean
        Ln.Used = True
        IncreseCellCounter()
        Dim Ans As Boolean = False
        For Each i As Cells In CellCollection
            If i.CellLineUsed >= 3 Then
                Ans = True
                Exit For
            End If
        Next
        Ln.Used = False

        Return Ans
    End Function
    Sub Play_As_Hard()
        If PlayNormalStat = False Then
            Play_As_Normal()
        End If

        If PlayNormalStat = True Then
            Set_Cpu_Count()
            Dim MIN_LINE_CELL As New Lines
            MIN_LINE_CELL.CPULineCount = 100
            For Each Ln As Lines In LineCollection
                If MIN_LINE_CELL.CPULineCount > Ln.CPULineCount Then
                    MIN_LINE_CELL = Ln
                End If
            Next

            MIN_LINE_CELL.Used = True
            CPULastMove = MIN_LINE_CELL
            LineCollection.Remove(MIN_LINE_CELL)
        End If
    End Sub
    Sub Set_Cpu_Count()

        For Each Ln As Lines In LineCollection
            If Ln.Used = False Then
                Ln.Used = True
                Dim CCT As Integer = 0
                Ln.CPULineCount = Made_Line_Count(0, CCT)
                Ln.CPUCellCount = CCT
                Ln.Used = False
            End If
        Next
    End Sub
    Function Made_Line_Count(ByVal lct As Integer, ByRef CCT As Integer) As Integer
        IncreseCellCounter()
        Dim Temp_Line As Lines
        For Each i As Cells In CellCollection
            If i.CellLineUsed = 3 Then
                If i.LineAbove.Used = False Then
                    Temp_Line = i.LineAbove
                ElseIf i.LineAhead.Used = False Then
                    Temp_Line = i.LineAhead
                ElseIf i.LineBehind.Used = False Then
                    Temp_Line = i.LineBehind
                Else
                    Temp_Line = i.LineUnder
                End If
                Temp_Line.Used = True
                lct = Made_Line_Count(lct + 1, CCT)

                If CCT = 0 Then
                    Made_Cell_Count(CCT)
                End If

                Temp_Line.Used = False
                Exit For
            End If
        Next
        IncreseCellCounter()
        Return lct
    End Function
    Sub Made_Cell_Count(ByRef CCT As Integer)
        For Each i As Cells In CellCollection
            If i.CellLineUsed = 4 Then
                CCT = CCT + 1
            End If
        Next
    End Sub
    Sub MakeLastLineOfBoxe()
        Dim Temp_Line As Lines
        For Each i As Cells In CellCollection
            If i.CellLineUsed = 3 Then
                If i.LineAbove.Used = False Then
                    Temp_Line = i.LineAbove
                ElseIf i.LineAhead.Used = False Then
                    Temp_Line = i.LineAhead
                ElseIf i.LineBehind.Used = False Then
                    Temp_Line = i.LineBehind
                Else
                    Temp_Line = i.LineUnder
                End If
                Temp_Line.Used = True
                CPULastMove = Temp_Line
                LineCollection.Remove(Temp_Line)
                Exit Sub
            End If
        Next
    End Sub

    Private Sub PB_Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub





    Private Sub TM_Hilight_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TM_Hilight.Tick

        If CPULastMove.Used = False Then
            CPULastMove.Used = True
            If CPULastMoveCounter = 4 Then
                CPULastMoveCounter = 0
                MouseClikVisible = True
                TM_Hilight.Stop()
            Else
                CPULastMoveCounter += 1
            End If
        Else
            CPULastMove.Used = False
        End If
        PB_Bord.Refresh()

    End Sub

    Private Sub Select_New_Game(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewGameToolStripMenuItem.Click, btn_start.Click
        If GAME_STAT = True Then
            Dim res As MsgBoxResult
            res = MsgBox("Do you real want to leave current game....?", MsgBoxStyle.YesNo, "Warning")
            If res = MsgBoxResult.Yes Then
                TM_Game.Stop()
                Lbl_Cpu_Score.Text = "00"
                Lbl_Ply_Score.Text = "00"
                Bord_Panel.Controls.Clear()
                GAME_STAT = False
                SetingisToolStripMenuItem.Visible = False
                MouseClikVisible = True
                LBL_LT_PLAY.Text = "00"
                LBL_LT_CPU.Text = "00"
                LBL_UNDO.Text = "00"
                Second = 0
                Minute = 0
                Hour = 0
                Panel_Rules.Visible = True
                'PB_Animate.Visible = False
                If Game_Type = False Then
                    SINGLEPLAYER.Show(Me)
                Else
                    DOUBLEPLAYER.Show(Me)
                End If
                UNDO.Clear()
            End If
        Else
            TM_Game.Stop()
            Lbl_Cpu_Score.Text = "00"
            Lbl_Ply_Score.Text = "00"
            Bord_Panel.Controls.Clear()
            GAME_STAT = False
            MouseClikVisible = True
            LBL_LT_PLAY.Text = "00"
            LBL_LT_CPU.Text = "00"
            LBL_UNDO.Text = "00"
            Second = 0
            Minute = 0
            Hour = 0S
            'PB_Animate.Visible = False
            SetingisToolStripMenuItem.Visible = False
            If Game_Type = False Then
                SINGLEPLAYER.Show(Me)
            Else
                DOUBLEPLAYER.Show(Me)
            End If
            UNDO.Clear()
        End If

    End Sub



    Private Sub TM_Game_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TM_Game.Tick
        LBL_Time.Text = Hour & " : " & Minute & " : " & Second
        Second += 1
        If Second = 60 Then
            Second = 0
            Minute += 1
        End If
        If Minute = 60 Then
            Minute = 0
            Hour += 1
        End If

    End Sub

    Private Sub p1_img_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p1_img.Click
        MsgBox(MaxCell)
    End Sub

    Private Sub MST_Yor_T_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MST_Yor_T.Click, MST_RENDT.Click, MST_CPUT.Click
        MST_Yor_T.Checked = False
        MST_RENDT.Checked = False
        MST_CPUT.Checked = False
        sender.Checked = True
        If sender.name.ToString = "MST_Yor_T" Then
            FIRST_TURN = 1
        ElseIf sender.name.ToString = "MST_RENDT" Then
            FIRST_TURN = 2
        Else
            FIRST_TURN = 3
        End If
    End Sub
    Sub Undo_Save_Point()
        Dim objundo As New DOUNDO
        With objundo
            ReDim .hline(MaxLine)
            ReDim .vline(MaxLine)
            For i As Integer = 0 To MaxLine - 1
                .hline(i) = hline(i).Used
                .vline(i) = vline(i).Used
            Next
            ReDim .cell(MaxCell)
            ReDim .CellOwner(MaxCell)
            For i As Integer = 0 To MaxCell
                .cell(i) = Cell(i).CellImageUsed
                .CellOwner(i) = Cell(i).CellOwner
            Next
            .P1Score = CInt(Val(Lbl_Ply_Score.Text))
            .P2Score = CInt(Val(Lbl_Cpu_Score.Text))
            .PlayNormalStat = PlayNormalStat
            .GAME_STAT = GAME_STAT
            .CPULastMove = CPULastMove
            .TURN = players.Turn
        End With
        UNDO.Push(objundo)
    End Sub

    Private Sub UndoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UndoToolStripMenuItem.Click

        If UNDO.Count > 0 And MouseClikVisible = True Then
            Dim objundo As DOUNDO
            objundo = UNDO.Pop
            If Game_Type = False Then
                LineCollection.Clear()
                CellCollection.Clear()
            End If
            With objundo

                For i As Integer = 0 To MaxLine - 1
                    hline(i).Used = .hline(i)
                    vline(i).Used = .vline(i)
                    If hline(i).Used = False Then
                        If Game_Type = False Then
                            LineCollection.Add(hline(i))
                        End If
                    End If
                    If vline(i).Used = False Then
                        If Game_Type = False Then
                            LineCollection.Add(vline(i))
                        End If
                    End If
                Next
                For i As Integer = 0 To MaxCell
                    Cell(i).CellOwner = .CellOwner(i)
                    If .cell(i) = False And Cell(i).CellImageUsed = True Then
                        PB_Bord.Controls.Remove(Cell(i).CellImage)
                    End If
                    Cell(i).CellImageUsed = .cell(i)
                    If Cell(i).CellImageUsed = False Then
                        If Game_Type = False Then
                            CellCollection.Add(Cell(i))
                        End If
                    End If
                Next
                Lbl_Ply_Score.Text = .P1Score
                Lbl_Cpu_Score.Text = .P2Score
                If Game_Type = True Then
                    players.Turn = .TURN
                    If players.Turn = True Then
                        LBL_Turn.Text = PL2.Name
                    Else
                        LBL_Turn.Text = PL1.Name
                    End If

                End If

                PlayNormalStat = .PlayNormalStat
                GAME_STAT = .GAME_STAT
                CPULastMove = .CPULastMove
                LBL_UNDO.Text = CInt(Val(LBL_UNDO.Text)) + 1
            End With

            IncreseCellCounter()
            PB_Bord.Refresh()
        End If

    End Sub

    Private Sub PB_Cpu_Turn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PB_Cpu_Turn.Click
        If GAME_STAT = True Then
            If UNDO.Count > 0 Or FIRST_TURN = 3 Then
                MouseClikVisible = False
                TM_Hilight.Start()
            Else
                MsgBox("CPU Not Play Any Single Move at this Time...!!", MsgBoxStyle.Information, "Not Play")
            End If

        Else
            MsgBox("CPU Not Play Any Single Move at this Time...!!", MsgBoxStyle.Information, "Not Play")
        End If

    End Sub

    Private Sub PB_Cpu_Turn_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PB_Cpu_Turn.MouseDown
        PB_Cpu_Turn.Image = My.Resources.down
    End Sub

    Private Sub PB_Cpu_Turn_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PB_Cpu_Turn.MouseUp
        PB_Cpu_Turn.Image = My.Resources.up
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()

    End Sub



    Private Sub Lbl_Ply_Score_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Lbl_Ply_Score.TextChanged, Lbl_Cpu_Score.TextChanged, lbl_name.TextChanged, lbl_cpu.TextChanged
        Lbl_play_score2.Text = Lbl_Ply_Score.Text
        Lbl_cpu_score2.Text = Lbl_Cpu_Score.Text
        lbl_name2.Text = lbl_name.Text
        lbl_cpu2.Text = lbl_cpu.Text
        If Game_Type = True Then
            LBL_CT_P1.Text = lbl_name2.Text
            LBL_CT_P2.Text = lbl_cpu2.Text
        End If
    End Sub

    Private Sub HumanVSCPUToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HumanVSCPUToolStripMenuItem.Click, HumanVSHumanToolStripMenuItem.Click

        HumanVSCPUToolStripMenuItem.Checked = False
        HumanVSHumanToolStripMenuItem.Checked = False
        sender.Checked = True
        If HumanVSCPUToolStripMenuItem.Checked Then
            Game_Type = False
            SINGLEPLAYERPANAL.Visible = True
            DOUBLEPLAYERPANAL.Visible = False
        Else
            Game_Type = True
            SINGLEPLAYERPANAL.Visible = False
            DOUBLEPLAYERPANAL.Visible = True
            LBL_Turn.Text = lbl_name.Text
        End If
    End Sub


    Private Sub LBL_Turn_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles LBL_Turn.TextChanged

        If LBL_Turn.Text = LBL_CT_P1.Text Then
            PB_TURN_1.Image = My.Resources.circle_green
            PB_TURN_2.Image = My.Resources.circle_red
        Else
            PB_TURN_1.Image = My.Resources.circle_red
            PB_TURN_2.Image = My.Resources.circle_green
        End If
    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        Dim temp As Boolean = Save_File()
        Directory.SetCurrentDirectory(CurrentDir)
    End Sub

    Private Sub LoadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoadToolStripMenuItem.Click
        Dim resload As DialogResult
        If GAME_STAT = True Then
            resload = MsgBox("Do You Want to Load Game?", MsgBoxStyle.YesNo, "Worning...!!")
        End If
        If resload = Windows.Forms.DialogResult.Yes Or GAME_STAT = False Then
            Dim res As DialogResult
            OFD.Filter = ".dab|Dots And Boxes"
            OFD.FileName = "*.dab"
            res = OFD.ShowDialog()
            If res = Windows.Forms.DialogResult.OK Then
                Dim FS As New FileStream(OFD.FileName, FileMode.Open)
                Dim SR As New StreamReader(FS)
                Dim StrVline, StrHline, StrCell, StrCellOwner As String
                Directory.SetCurrentDirectory(CurrentDir)
                With SR
                    GridSize = (CInt(.ReadLine()))
                    StrVline = .ReadLine
                    StrHline = .ReadLine
                    StrCell = .ReadLine
                    StrCellOwner = .ReadLine
                    Game_Type = .ReadLine
                    lbl_name.Text = .ReadLine
                    lbl_cpu.Text = .ReadLine
                    p1_img.Image = Image.FromFile(.ReadLine)
                    p2_img.Image = Image.FromFile(.ReadLine)
                    players.Turn = .ReadLine
                    Lbl_Ply_Score.Text = .ReadLine
                    Lbl_Cpu_Score.Text = .ReadLine
                    LBL_LT_PLAY.Text = .ReadLine
                    LBL_LT_CPU.Text = .ReadLine
                    LBL_UNDO.Text = .ReadLine
                    Second = CInt(.ReadLine)
                    Minute = CInt(.ReadLine)
                    Hour = CInt(.ReadLine)
                    level = CInt(.ReadLine)
                    PlayNormalStat = .ReadLine
                    Make_Bord()
                    For i As Integer = 0 To StrVline.Length - 1
                        vline(i).Used = CInt(Val(StrVline.Chars(i)))
                        hline(i).Used = CInt(Val(StrHline.Chars(i)))
                        If hline(i).Used = True Then
                            If Game_Type = False Then
                                LineCollection.Remove(hline(i))
                            End If
                        End If
                        If vline(i).Used = True Then
                            If Game_Type = False Then
                                LineCollection.Remove(vline(i))
                            End If
                        End If
                    Next
                    For i As Integer = 0 To StrCell.Length - 1
                        Cell(i).CellImageUsed = CInt(Val(StrCell.Chars(i)))
                        Cell(i).CellOwner = CInt(Val(StrCellOwner.Chars(i)))
                        If Cell(i).CellImageUsed = True Then
                            Dim pb As New PictureBox
                            PB_Bord.Controls.Add(pb)
                            pb.Height = CellHeight - MarginOfDots
                            pb.Width = CellWidth - MarginOfDots
                            pb.BackColor = Color.Transparent
                            If Cell(i).CellOwner = 0 Then
                                pb.Image = p1_img.Image
                            Else
                                pb.Image = p2_img.Image
                            End If
                            pb.Location = New Point(Cell(i).LineAbove.StartPoint.X + (MarginOfDots \ 2), Cell(i).LineBehind.StartPoint.Y + (MarginOfDots \ 2))
                            pb.SizeMode = PictureBoxSizeMode.StretchImage
                            Cell(i).CellImage = pb
                        End If
                        If Cell(i).CellImageUsed = True Then
                            If Game_Type = False Then
                                CellCollection.Remove(Cell(i))
                            End If
                        End If
                    Next
                    LBL_Grid.Text = GridSize & " X " & GridSize
                    If Game_Type = False Then
                        DOUBLEPLAYERPANAL.Visible = False
                        SINGLEPLAYERPANAL.Visible = True

                        If level = 1 Then
                            Lbl_level.Text = "EASY"
                        ElseIf level = 2 Then
                            Lbl_level.Text = "NORMAL"
                        ElseIf level = 3 Then
                            Lbl_level.Text = "HARD"
                        End If
                    Else
                        DOUBLEPLAYERPANAL.Visible = True
                        SINGLEPLAYERPANAL.Visible = False
                        If players.Turn = False Then
                            LBL_Turn.Text = PL1.Name
                        Else
                            LBL_Turn.Text = PL2.Name
                        End If
                    End If
                    PB_Bord.Refresh()
                    TM_Game.Start()
                    GAME_STAT = True
                End With
                SetingisToolStripMenuItem.Visible = False
                SaveToolStripMenuItem.Enabled = True
                UndoToolStripMenuItem.Enabled = True
                UNDO.Clear()
                SR.Close()
                FS.Close()
                Panel_Rules.Visible = False
            End If

        End If
    End Sub
    Function Save_File() As Boolean
        Dim res As DialogResult
        Dim SF_res As Boolean = False
        SFD.Filter = ".dab|Dots And Boxes"
        SFD.FileName = Date.Today.Day & "-" & Date.Today.Month & "-" & Date.Today.Year
        SFD.DefaultExt = ".dab"
        res = SFD.ShowDialog()
        If res = Windows.Forms.DialogResult.OK Then
            Dim FS As New FileStream(SFD.FileName, FileMode.CreateNew)
            Dim SW As New StreamWriter(FS)
            Dim str1 As String = "", str2 As String = ""
            Directory.SetCurrentDirectory(CurrentDir)
            With SW

                .WriteLine(GridSize)

                For i As Integer = 0 To MaxLine - 1
                    str1 = str1 & CInt(vline(i).Used) * -1
                    str2 = str2 & CInt(hline(i).Used) * -1
                Next

                .WriteLine(str1)

                .WriteLine(str2)
                str1 = ""
                str2 = ""
                For i As Integer = 0 To MaxCell
                    str1 = str1 & CInt(Cell(i).CellImageUsed) * -1
                    str2 = str2 & Cell(i).CellOwner
                Next

                .WriteLine(str1)

                .WriteLine(str2)

                .WriteLine(Game_Type)

                .WriteLine(PL1.Name)

                .WriteLine(PL2.Name)

                .WriteLine(PL1.ImgPath)

                .WriteLine(PL2.ImgPath)

                .WriteLine(CInt(players.Turn))

                .WriteLine(Lbl_Ply_Score.Text)

                .WriteLine(Lbl_Cpu_Score.Text)

                .WriteLine(LBL_LT_PLAY.Text)

                .WriteLine(LBL_LT_CPU.Text)

                .WriteLine(LBL_UNDO.Text)

                .WriteLine(Second)

                .WriteLine(Minute)

                .WriteLine(Hour)

                .WriteLine(level)

                .WriteLine(PlayNormalStat)
                SW.Close()
                FS.Close()
            End With
            SF_res = True
        End If
        Return SF_res
    End Function





    Private Sub TM_Rules_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TM_Rules.Tick
        If Rule_Index < Rules_Text.Text.Length Then
            Txt_Rules.Text = Txt_Rules.Text & Rules_Text.Text.Chars(Rule_Index)
            Rule_Index += 1
        ElseIf Rule_Index = Rules_Text.Text.Length Then
            TM_Rules.Interval = 10000
            Rule_Index += 1
        Else
            Rule_Index = 0
            Txt_Rules.Clear()
            TM_Rules.Interval = 25
        End If
    End Sub


    Private Sub HighScoreToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HighScoreToolStripMenuItem.Click
        HighScore.ShowDialog(Me)
    End Sub
End Class
