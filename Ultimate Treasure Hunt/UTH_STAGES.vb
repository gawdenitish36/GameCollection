Public Class UTH_STAGES
    Public Score As Integer = 0
    Public DEFAULT_IMG As Image = My.Resources.F_mario
    Public DOWN_IMG As Image = My.Resources.F_mario
    Public UP_IMG As Image = My.Resources.B_Mario
    Public LEFT_IMG As Image = My.Resources.L_Mario
    Public RIGHT_IMG As Image = My.Resources.R_Mario
    Dim Flame As Image = My.Resources.flame1
    Dim PB_WIDTH As Integer
    Dim PB_HIEGHT As Integer
    Dim PIPE_WIDTH As Integer
    Dim WALL(50) As Rectangle
    Dim Joints(50) As Rectangle
    Dim Intrupt(20) As Rectangle
    Dim Coin(30) As Rectangle
    Dim PLAYER As Rectangle
    Dim KEY As Rectangle
    Dim Key_Visible As Boolean = True
    Dim PLAY_DIE As Boolean
    Dim I As Integer = 0
    Dim TRESURE As Rectangle
    Dim PX, PY, PPX, PPY As Integer
    Private Sub BOARD_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles BOARD.Paint

        e.Graphics.DrawImage(DEFAULT_IMG, PLAYER)
        e.Graphics.DrawImage(My.Resources.H_LARGE_PIPE, WALL(0))
        e.Graphics.DrawImage(My.Resources.V_LARGE_PIPE, WALL(1))
        e.Graphics.DrawImage(My.Resources.H_LARGE_PIPE, WALL(2))
        e.Graphics.DrawImage(My.Resources.V_LARGE_PIPE, WALL(3))

        e.Graphics.DrawImage(My.Resources.PIPE_JOINTS, Joints(0))
        e.Graphics.DrawImage(My.Resources.PIPE_JOINTS, Joints(1))
        e.Graphics.DrawImage(My.Resources.PIPE_JOINTS, Joints(2))
        e.Graphics.DrawImage(My.Resources.PIPE_JOINTS, Joints(3))

        Draw_Stage1(e.Graphics)
    End Sub

    
    
    Private Sub UTH_STAGES_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        PPX = PX
        PPY = PY
        If e.KeyCode = Keys.Enter And PLAY_DIE = True Then
            DEFAULT_IMG = My.Resources.F_mario
            PX = 30
            PY = 30
            PLAYER.Location = New Point(PX, PY)
            Key_Visible = True
            WALL(9).Width = 140
            PLAY_DIE = False
            BOARD.Refresh()
            TM_INTRUPT.Start()

        ElseIf e.KeyCode = Keys.Up Then
            PY -= 20
            PLAYER.Location = New Point(PX, PY)
            DEFAULT_IMG = UP_IMG
            Check_Wall()
        ElseIf e.KeyCode = Keys.Down Then
            PY += 20
            PLAYER.Location = New Point(PX, PY)
            DEFAULT_IMG = DOWN_IMG
            Check_Wall()
        ElseIf e.KeyCode = Keys.Left Then
            PX -= 20
            PLAYER.Location = New Point(PX, PY)
            DEFAULT_IMG = LEFT_IMG
            Check_Wall()
        ElseIf e.KeyCode = Keys.Right Then
            PX += 20
            PLAYER.Location = New Point(PX, PY)
            DEFAULT_IMG = RIGHT_IMG
            Check_Wall()
        End If

        

    End Sub
    Sub Check_Wall()
        If PLAYER.IntersectsWith(KEY) And Key_Visible = True Then
            WALL(9).Width = 0
            Key_Visible = False
        End If
        For Each rect As Rectangle In WALL
            If PLAYER.IntersectsWith(rect) Then
                PX = PPX
                PY = PPY
                PLAYER.Location = New Point(PX, PY)
                Exit For
            End If
        Next
        For Each rect As Rectangle In Coin
            If PLAYER.IntersectsWith(rect) Then
                Coin(Array.IndexOf(Coin, rect)).Size = New Point(0, 0)
                Exit For
            End If
        Next
    End Sub

    Private Sub UTH_STAGES_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        PB_WIDTH = Me.BOARD.Width
        PB_HIEGHT = Me.BOARD.Height
        PIPE_WIDTH = Me.BOARD.Width / 30
        PX = 30
        PY = 30
        PLAYER = New Rectangle(30, 30, 50, 50)
        'Outer Border
        WALL(0) = New Rectangle(0, 0, PB_WIDTH, PIPE_WIDTH)
        WALL(1) = New Rectangle(PB_WIDTH - 30, 0, PIPE_WIDTH, PB_HIEGHT)
        WALL(2) = New Rectangle(0, PB_HIEGHT - 30, PB_WIDTH, PIPE_WIDTH)
        WALL(3) = New Rectangle(0, 0, PIPE_WIDTH, PB_HIEGHT)
        'Outer Joints
        Joints(0) = New Rectangle(0, 0, PIPE_WIDTH, PIPE_WIDTH)
        Joints(1) = New Rectangle(PB_WIDTH - 30, 0, PIPE_WIDTH, PIPE_WIDTH)
        Joints(2) = New Rectangle(PB_WIDTH - 30, PB_HIEGHT - 30, PIPE_WIDTH, PIPE_WIDTH)
        Joints(3) = New Rectangle(0, PB_HIEGHT - 30, PIPE_WIDTH, PIPE_WIDTH)
        INIT_STAGE1()

        TM_INTRUPT.Start()
    End Sub
    Sub INIT_STAGE1()
        WALL(4) = New Rectangle(20, 100, PB_WIDTH / 2, PIPE_WIDTH)
        Joints(4) = New Rectangle(0, 100, PIPE_WIDTH, PIPE_WIDTH)

        WALL(5) = New Rectangle(500, 0, PIPE_WIDTH, PB_HIEGHT / 2.5)
        Joints(5) = New Rectangle(500, 0, PIPE_WIDTH, PIPE_WIDTH)

        WALL(6) = New Rectangle(120, PB_HIEGHT / 2.5, 400, PIPE_WIDTH)
        Joints(6) = New Rectangle(500, PB_HIEGHT / 2.5, PIPE_WIDTH, PIPE_WIDTH + 10)
        Intrupt(0) = New Rectangle(490, PB_HIEGHT / 2.5 + 30, 50, 110)

        WALL(7) = New Rectangle(20, 350, PB_WIDTH / 1.5 - 30, PIPE_WIDTH)
        Joints(7) = New Rectangle(0, 350, PIPE_WIDTH, PIPE_WIDTH)

        WALL(8) = New Rectangle(630, 0, PIPE_WIDTH, PB_HIEGHT / 1.4)
        Joints(8) = New Rectangle(630, 0, PIPE_WIDTH, PIPE_WIDTH)

        Joints(9) = New Rectangle(250, PB_HIEGHT / 1.5 - 15, PIPE_WIDTH, PIPE_WIDTH + 10)
        Intrupt(1) = New Rectangle(240, PB_HIEGHT / 1.5 + 10, 50, 160)

        WALL(9) = New Rectangle(645, 100, 140, PIPE_WIDTH + 10)
        KEY = New Rectangle(50, 450, 50, 50)

        TRESURE = New Rectangle(680, 20, 80, 80)


        Coin(0) = New Rectangle(200, 150, 40, 40)
        Coin(1) = New Rectangle(150, 150, 40, 40)
        Coin(2) = New Rectangle(100, 150, 40, 40)
        Coin(3) = New Rectangle(550, 50, 40, 40)
        Coin(4) = New Rectangle(550, 100, 40, 40)
        Coin(5) = New Rectangle(550, 150, 40, 40)
    End Sub
    Sub Draw_Stage1(ByVal G As Graphics)
        G.DrawImage(My.Resources.H_LARGE_PIPE, WALL(4))
        G.DrawImage(My.Resources.PIPE_JOINTS, Joints(4))

        G.DrawImage(My.Resources.V_LARGE_PIPE, WALL(5))
        G.DrawImage(My.Resources.PIPE_JOINTS, Joints(5))

        G.DrawImage(My.Resources.H_LARGE_PIPE, WALL(6))
        G.DrawImage(My.Resources.flameThrower, Joints(6))
        G.DrawImage(Flame, Intrupt(0))

        G.DrawImage(My.Resources.H_LARGE_PIPE, WALL(7))
        G.DrawImage(My.Resources.PIPE_JOINTS, Joints(7))

        G.DrawImage(My.Resources.V_LARGE_PIPE, WALL(8))
        G.DrawImage(My.Resources.PIPE_JOINTS, Joints(8))


        G.DrawImage(My.Resources.flameThrower, Joints(9))
        G.DrawImage(Flame, Intrupt(1))

        For j As Integer = 0 To 5
            G.DrawImage(My.Resources.Coin, Coin(j))
        Next


        If Key_Visible = True Then
            G.DrawImage(My.Resources.T_wall, WALL(9))
            G.DrawImage(My.Resources.Key, KEY)
        End If
        G.DrawImage(My.Resources.TSR1, TRESURE)

    End Sub
  

    Private Sub TM_INTRUPT_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TM_INTRUPT.Tick
        If I Mod 2 = 0 Then
            Flame = My.Resources.flame1
        Else
            Flame = My.Resources.flame2
        End If
        If I = 10 Then
            Intrupt(0).Height = 0
            Intrupt(1).Height = 160
        End If
        If I = 20 Then
            I = 0
            Intrupt(1).Height = 0
            Intrupt(0).Height = 110
        End If

        I += 1
        BOARD.Refresh()
        Check_Intrupt()
    End Sub
    Sub Check_Intrupt()
        For Each rect As Rectangle In Intrupt
            If PLAYER.IntersectsWith(rect) Then
                TM_INTRUPT.Stop()
                PLAY_DIE = True
                DEFAULT_IMG = My.Resources.Blood
                BOARD.Refresh()
                Exit Sub
            End If
        Next
    End Sub
End Class