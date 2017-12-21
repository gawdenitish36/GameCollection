Imports System.IO
Public Class Form1

    Public Rd As New Random
    Public IsRunning As Boolean
    Public IsGameOver As Boolean
    'Format
    Public TileSize As Integer = 32
    Public MarginFromHeight As Integer
    Public MarginFromWidth As Integer
    Public BoardWidth As Integer
    Public BoardHeight As Integer
    'Dim MenuWidth As Integer = 80
    'Dim MenuHeight As Integer = BoardHeight


    'Timer
    Dim T_Tick, MaxTick As Integer
    Dim T_Sec As Integer = TimeOfDay.Second
    Dim T_time As Integer = 0
    Dim GameTime As Single = 100
    Dim MaxGameTime As Integer = 100
    'Grphics For Board
    Dim G As Graphics
    Dim BBG As Graphics
    Dim BB As Bitmap
    'Graphics For Side menu
    ' Dim MG As Graphics
    ' Dim MBBG As Graphics
    ' Dim MBB As Bitmap

    'Tile image
    Dim BmpTile As Bitmap
    Dim MaxTile As Integer = 12
    'MAP
    Public Map(1000, 1000, 10) As Integer
    Public MapX As Integer = 1
    Public MapY As Integer = 1
    Public TempMapX As Integer = 1
    Public TempMapY As Integer = 1
    Public sRect As Rectangle
    Public dRect As Rectangle

    'TOON
    Public BmpToon As Bitmap
    Public Xpos As Integer = 0
    Public Ypos As Integer = 0
    Public TempXpos As Integer = 0
    Public TempYpos As Integer = 0
    Public MoveSpeed As Integer = 4
    Public MoveDir As Integer = 0
    Public LastDir As Integer = 2
    Public ToonFrame As Integer = 0
    Public Guyx As Integer = ((MapX + 2) * TileSize)
    Public GuyY As Integer = ((MapY + 2) * TileSize)
    Public TempToonx As Integer = 2 * TileSize
    Public TempToonY As Integer = 2 * TileSize
    Public ToonX As Integer = 2 * TileSize
    Public ToonY As Integer = 2 * TileSize
    'maze
    Public MazeSize As Integer = 3 * 5
    'Dim Maze() As MazeCell
    'SmallBullet
    Public Rang As Integer = 32 * 2
    Public BmpBullet As Bitmap
    Public BltX As Integer
    Public BltY As Integer
    Public BulletSpeed As Integer
    Public bltCt As Integer
    Public bltDir As Integer
    Public BulletVissible As Boolean
    'Menu
    Public BmpMenu As Bitmap
    Public SelectedItem As Integer = 3
    Public MarX As Integer
    Public MarY As Integer
    Public BmpBg As Bitmap
    Public Mhlt As Boolean


    Public KeyVisible As Boolean
    Public BmpPrs As Bitmap
    Public PRSFRAME As Integer = 0
    Dim GTP As GameType = GameType.Daynamic
    'Creature
    Dim BmpCrt As Bitmap
    Dim CrtFrame As Single = 0
    'slg
    Dim BmpSlg As Bitmap
    Dim SlgFrame As Integer
    Dim MaxCrt As Integer
    Dim Crt() As Creature
    Dim ShowMapState As Boolean

    Dim MazePath As ArrayList
    'Score
    Dim Bmpface As Bitmap
    Dim MaxLife As Integer = 192
    Dim Life As Integer = MaxLife
    Dim Bullet As Integer = 8
    Dim Score As Integer = 0

    Dim Stage As Integer = 0
    'Inpout Name
    Dim GateNameState As Boolean
    Dim PlayerName As String = ""
    Dim ColorState As Boolean
    Dim ShowAllprofileState As Boolean
    Dim CurtDir As String = Directory.GetCurrentDirectory
    Dim ProfilesName As ArrayList
    Dim ProfslItem As Integer = 0

    Dim BmpTrz As Bitmap
    Dim TrzKey As Tools
    Dim BmpTools As Bitmap
    Dim OuterMsg As String = "Initialization"

    'AlertMessage
    Dim AlertMsgStat As Boolean
    Dim MsgNo As Integer
    Dim msgColor1 As New SolidBrush(Color.Black)
    Dim msgColor2 As New SolidBrush(Color.Gray)
    Dim msgColor3 As New SolidBrush(Color.DarkGray)
    'options
    Dim OptStat As Boolean
    Dim BmpControls As Bitmap

    'Won
    Dim BmpWon As Bitmap
    Dim WonMsgStat As Boolean
    Dim WF_Frame As Integer = 0







    Sub AlertMsg(ByVal msn As Integer)
        MsgNo = msn
        Dim Msg As String = ""
        Dim FnC As New SolidBrush(Color.Black)
        Dim temp As SolidBrush = msgColor1
        msgColor1 = msgColor2
        msgColor2 = msgColor3
        msgColor3 = temp
        G.FillRectangle(msgColor1, 32 * 2, 32 * 4, 32 * 8, 32 * 4)
        G.FillRectangle(Brushes.White, 32 * 2 + 20, 32 * 4 + 20, 32 * 8 - 40, 32 * 4 - 40)
        Select Case MsgNo
            Case 0
                Msg = "                     PAUSE...!!" & vbNewLine & vbNewLine & _
                        "Press ''Esc'' To Resume." & vbNewLine & _
                        "Press ''Enter'' Goto Main Menu."
                G.DrawString(Msg, New Font("Arial", 10, FontStyle.Bold), FnC, 32 * 2 + 22, 32 * 4 + 22)
            Case 1
                Msg = "" & vbNewLine & _
                        "Profile is Already Created..!!" & vbNewLine & _
                        "Please Try With Another Name..!"
                G.DrawString(Msg, New Font("Arial", 10, FontStyle.Bold), FnC, 32 * 2 + 22, 32 * 4 + 22)
                G.FillRectangle(Brushes.Gray, 32 * 5 + 12, 32 * 6 + 16, 32, 16)
                G.DrawString(vbNewLine & vbNewLine & vbNewLine & vbTab & "    [OK]", New Font("Arial", 12, FontStyle.Bold), FnC, 32 * 2 + 22, 32 * 4 + 22)
            Case 2
                Msg = "                  Warrning..!!" & vbNewLine & _
                        "Press ''Enter'' to Delete." & vbNewLine & _
                        "''" & ProfilesName.Item(ProfslItem).ToString & "'' Profile......!!"
                G.DrawString(Msg, New Font("Arial", 10, FontStyle.Bold), FnC, 32 * 2 + 22, 32 * 4 + 22)
                G.FillRectangle(Brushes.Gray, 32 * 5 + 12, 32 * 6 + 16, 32, 16)
                G.DrawString(vbNewLine & vbNewLine & vbNewLine & vbTab & "    [OK]", New Font("Arial", 12, FontStyle.Bold), FnC, 32 * 2 + 22, 32 * 4 + 22)

        End Select

    End Sub
    Private Sub Form1_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Dim f1 As New FileStream("ProfileDetails", FileMode.Create)
        Dim sw As New StreamWriter(f1)
        For Each nm As String In ProfilesName
            sw.WriteLine(nm)
        Next
        sw.Close()
        f1.Close()
        System.Diagnostics.Process.GetCurrentProcess.Kill()
    End Sub

    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If WonMsgStat Then
            If e.KeyCode = Keys.Escape Or e.KeyCode = Keys.Enter Then
                WonMsgStat = False
            End If
            Exit Sub
        End If
        If IsGameOver = True And e.KeyCode = Keys.Escape Then
            IsRunning = False
            IsGameOver = False
            MapX = 1
            MapY = 1
            Xpos = 0
            Ypos = 0
            Guyx = ((MapX + 2) * TileSize)
            GuyY = ((MapY + 2) * TileSize)
            ToonX = 2 * TileSize
            ToonY = 2 * TileSize
            TempMapX = 1
            TempMapY = 1
            TempXpos = 0
            TempYpos = 0
            TempToonx = ToonX
            TempToonY = ToonY
            ShowMapState = False
            T_time = 0
        End If
        Select Case True
            Case AlertMsgStat
                Select Case e.KeyCode
                    Case Keys.Escape
                        AlertMsgStat = False
                    Case Keys.Enter
                        AlertMsgStat = False
                        If MsgNo = 0 Then
                            SelectedItem = 3
                            IsRunning = False
                            GTP = GameType.Daynamic
                            KeyVisible = False
                            ReSetGame()
                            PlayerName = ""
                            OuterMsg = "Initialization"
                        ElseIf MsgNo = 2 Then
                            File.Delete(CurtDir & "\Profiles\" & ProfilesName.Item(ProfslItem).ToString)
                            ProfilesName.RemoveAt(ProfslItem)
                            ProfslItem = 0
                        End If

                End Select
                Exit Sub
            Case OptStat
                Select Case e.KeyCode
                    Case Keys.Escape
                        OptStat = False
                End Select

            Case ShowAllprofileState
                Select Case e.KeyCode
                    Case Keys.Up
                        ProfslItem -= 1
                        If ProfslItem < 0 Then ProfslItem = ProfilesName.Count - 1
                    Case Keys.Down
                        ProfslItem += 1
                        If ProfslItem > ProfilesName.Count - 1 Then ProfslItem = 0
                    Case Keys.Enter
                        LoadProfile()
                        LoadMaze()
                        IsRunning = True
                        ShowAllprofileState = False
                    Case Keys.Escape
                        ShowAllprofileState = False
                    Case Keys.Delete
                        AlertMsgStat = True
                End Select
                Exit Sub

            Case GateNameState
                Select Case e.KeyCode
                    Case Keys.Escape
                        PlayerName = ""
                        GateNameState = False
                    Case Keys.Enter
                        If PlayerName.Length > 0 Then
                            If ProfilesName.Contains(PlayerName) Then
                                AlertMsgStat = True
                                PlayerName = ""
                            Else
                                CreatePrifile()
                            End If

                        End If
                    Case Keys.Delete
                        PlayerName = ""
                    Case Keys.Back
                        PlayerName = ""
                    Case Else
                        If e.KeyData.ToString.Length = 1 And PlayerName.Length < 10 Then
                            PlayerName = PlayerName & e.KeyData.ToString
                        End If
                End Select
                Exit Sub


            Case IsRunning
                If KeyVisible Then
                    If e.KeyCode = Keys.M Then
                        ShowMapState = True
                        ShowMap()
                        Exit Sub
                    End If
                    If ShowMapState = False Then
                        Select Case e.KeyCode
                            Case Keys.Up
                                MoveDir = 1
                            Case Keys.Down
                                MoveDir = 2
                            Case Keys.Left
                                MoveDir = 3
                            Case Keys.Right
                                MoveDir = 4
                            Case Keys.Escape
                                AlertMsgStat = True
                                Exit Sub
                            Case Keys.Space
                                If BulletVissible = False And Bullet > 0 Then
                                    Bullet -= 1
                                    BulletVissible = True
                                    BltX = ToonX + 16
                                    BltY = ToonY + 16
                                    bltCt = 0
                                    bltDir = LastDir
                                End If
                                Exit Sub

                            Case Else
                                Exit Sub
                        End Select
                        LastDir = MoveDir
                        TempMapX = MapX
                        TempMapY = MapY
                        TempToonx = ToonX
                        TempToonY = ToonY
                        TempXpos = Xpos
                        TempYpos = Ypos
                    End If
                End If
            Case Else
                Select Case e.KeyCode
                    Case Keys.Up
                        SelectedItem -= 1
                        If SelectedItem < 0 Then SelectedItem = 3
                        If ProfilesName.Count = 0 And SelectedItem = 1 Then
                            SelectedItem -= 1
                        End If
                        If ProfilesName.Count = 12 And SelectedItem = 0 Then
                            SelectedItem = 3
                        End If
                    Case Keys.Down
                        SelectedItem += 1
                        If SelectedItem > 3 Then SelectedItem = 0
                        If ProfilesName.Count = 0 And SelectedItem = 1 Then
                            SelectedItem += 1
                        End If
                        If ProfilesName.Count = 12 And SelectedItem = 0 Then
                            SelectedItem += 1
                        End If
                    Case Keys.Enter
                        Select Case SelectedItem
                            Case 0
                                GateNameState = True
                            Case 1
                                ShowAllprofileState = True
                            Case 2
                                OptStat = True
                            Case 3
                                Me.Close()
                        End Select
                End Select

        End Select
        
    End Sub

    Sub CreatePrifile()
        ReSetGame()
        Stage = 0
        MoveDir = 0
        LastDir = 2
        MazeSize = 3 * (Stage + 5)
        MaxLife = 192

        MaxCrt = MazeSize \ 3
        Bullet = MaxCrt + 1
        Life = MaxLife
        Score = 0
        MaxGameTime = 100
        GameTime = MaxGameTime

        Try
            Dim fl As New FileStream(CurtDir & "\Profiles\" & PlayerName, FileMode.CreateNew)
            ProfilesName.Add(PlayerName)
            fl.Close()
            UpdateProfile()
            Directory.SetCurrentDirectory(CurtDir)
            LoadMaze()
            IsRunning = True
            GateNameState = False
        Catch ex As Exception
            MsgBox("Profile Is Allready Created")
        End Try

    End Sub
    Sub UpdateProfile()
        Dim fl As New FileStream(CurtDir & "\Profiles\" & PlayerName, FileMode.Open)
        Dim sw As New StreamWriter(fl)
        With sw
            .WriteLine(Life)
            .WriteLine(Stage)
            .WriteLine(Bullet)
            .WriteLine(Score)
            .WriteLine(GameTime)
        End With
        sw.Close()
        fl.Close()

    End Sub
    Sub LoadProfile()
        Dim fl As New FileStream(CurtDir & "\Profiles\" & ProfilesName.Item(ProfslItem).ToString, FileMode.Open)
        Dim sr As New StreamReader(fl)
        PlayerName = ProfilesName.Item(ProfslItem).ToString
        With sr
            Life = CInt(.ReadLine())
            Stage = CInt(.ReadLine())
            Bullet = CInt(.ReadLine())
            Score = CInt(.ReadLine())
            GameTime = CInt(.ReadLine())
        End With
        sr.Close()
        fl.Close()
        Stage -= 1
        GoToNextStage()
        ReSetGame()
       
    End Sub
    Sub ShowAllprofile()
        G.FillRectangle(Brushes.CornflowerBlue, 32 * 2, 5, 32 * 7, 32)
        G.DrawString("PROFILES", New Font("Comic Sans MS", 16, FontStyle.Bold), Brushes.Black, 32 * 4 - 10, 5)
        If ProfilesName.Count > 0 Then
            For i As Integer = 0 To ProfilesName.Count - 1
                G.DrawString(ProfilesName.Item(i).ToString, New Font("Comic Sans MS", 14, FontStyle.Bold), Brushes.Green, 32 * 4, 25 * i + 50)
            Next
            G.DrawString(ProfilesName.Item(ProfslItem).ToString, New Font("Comic Sans MS", 14, FontStyle.Bold), Brushes.GreenYellow, 32 * 4, 25 * ProfslItem + 50)
            If AlertMsgStat Then
                AlertMsg(2)
            End If
            G = Graphics.FromImage(BB)
            BBG = Me.CreateGraphics
            BBG.DrawImage(BB, MarginFromWidth, MarginFromHeight, BoardWidth, BoardWidth)
            G.Clear(Color.Black)
        Else
            ShowAllprofileState = False
            SelectedItem = 2
        End If

    End Sub
    Private Sub Form1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp

        MoveDir = 0
        ToonFrame = 0
       


        If e.KeyCode = Keys.M Then
            MaxTile = 12
            MapX = TempMapX
            MapY = TempMapY
            Xpos = TempXpos
            Ypos = TempYpos
            ToonX = Guyx - (MapX * 32 - Xpos)
            ToonY = GuyY - (MapY * 32 - Ypos)
            BB = New Bitmap(32 * MaxTile, 32 * MaxTile)
            ShowMapState = False
        End If

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Show()
        Me.Focus()
        Windows.Forms.Cursor.Hide()
        'MarginFromHeight = Me.Height / 2 - BoardHeight / 2
        'MarginFromWidth = ((Me.Width / 2 - BoardWidth / 2) - MenuWidth / 2)
        If Me.Width >= Me.Height Then
            BoardHeight = Me.Height
            BoardWidth = Me.Height
        Else
            BoardHeight = Me.Width
            BoardWidth = Me.Width
        End If
        MarginFromHeight = Me.Height / 2 - BoardHeight / 2
        MarginFromWidth = Me.Width / 2 - BoardWidth / 2
        BB = New Bitmap(32 * 12, 32 * 12)
        G = Graphics.FromImage(BB)
        BBG = Me.CreateGraphics
        MarY = MarginFromHeight * 32
        MarX = MarginFromWidth
        'MBB = New Bitmap(MenuWidth, MenuHeight)
        '' MG = Graphics.FromImage(BB)
        'MBBG = Me.CreateGraphics

        BmpTile = New Bitmap(GFX.PBTILE.Image)
        BmpToon = New Bitmap(GFX.PBTOON.Image)
        BmpBullet = New Bitmap(GFX.PBBullet.Image)
        BmpMenu = New Bitmap(GFX.PBMenu.Image)
        BmpBg = New Bitmap(GFX.PBMBG.Image)
        BmpPrs = New Bitmap(GFX.PB_PRS.Image)
        BmpCrt = New Bitmap(GFX.PB_BURN.Image)
        Bmpface = New Bitmap(GFX.PBFace.Image)
        BmpTrz = New Bitmap(GFX.PBTrz.Image)
        BmpTools = New Bitmap(GFX.PBTools.Image)
        BmpControls = New Bitmap(GFX.PBControls.Image)
        BmpWon = New Bitmap(GFX.PBWon.Image)
        ProfilesName = New ArrayList
        ReadProfileNames()
        'G = Me.CreateGraphics
        'IsRunning = True
        'Me.SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or ControlStyles.DoubleBuffer, True)
        'Me.UpdateStyles()
        TMGameEngin.Start()

        'GameLoop()

    End Sub
    Sub ReadProfileNames()
        Dim f1 As New FileStream("ProfileDetails", FileMode.Open)
        Dim rd As New StreamReader(f1)
        Dim str As String = rd.ReadLine
        While str <> ""
            ProfilesName.Add(str)
            str = rd.ReadLine
        End While
        rd.Close()
        f1.Close()
    End Sub

    Sub ShowMap()
        MaxTile = MazeSize + 2
        MapX = 1
        MapY = 1
        Xpos = 0
        Ypos = 0
        ToonX = Guyx - 32
        ToonY = GuyY - 32
        BB = New Bitmap(32 * MaxTile, 32 * MaxTile)
    End Sub

    Sub DrawGrphics()


        If GTP = GameType.Daynamic Then
            For x As Integer = -1 To MaxTile
                For y As Integer = -1 To MaxTile
                    GetSourceRect(MapX + x, MapY + y)
                    dRect = New Rectangle((x * TileSize) + Xpos, (y * TileSize) + Ypos, TileSize, TileSize)
                    G.DrawImage(BmpTile, dRect, sRect, GraphicsUnit.Pixel)
                    'G.DrawRectangle(Pens.Black, x * TileSize, y * TileSize, TileSize, TileSize)
                Next
            Next

        Else
            Dim SPB As New SolidBrush(Color.Green)
            For x As Integer = -1 To MaxTile
                For y As Integer = -1 To MaxTile
                    dRect = New Rectangle((x * TileSize) + Xpos, (y * TileSize) + Ypos, TileSize, TileSize)
                    SPB.Color = GetColor(MapX + x, MapY + y)
                    G.FillRectangle(SPB, dRect)
                    'G.DrawRectangle(Pens.Black, x * TileSize, y * TileSize, TileSize, TileSize)
                Next
            Next
        End If
        If BulletVissible = True And IsCreatureInWithBlt() = False Then
            FireBullet(bltDir)
            BmpBullet.MakeTransparent(Color.Magenta)
            G.DrawImage(BmpBullet, dRect, sRect, GraphicsUnit.Pixel)
        End If
        GetToon(LastDir)
        dRect = New Rectangle(ToonX, ToonY, TileSize, TileSize)
        'G.FillRectangle(Brushes.Black, dRect)
        G.DrawImage(BmpToon, dRect, sRect, GraphicsUnit.Pixel)
        If KeyVisible = False And IsGameOver = False Then
            If T_time > 4 Then
                If MaxTick < 15 Then
                    GTP = GameType.Simple
                Else
                    GTP = GameType.Daynamic
                End If
                KeyVisible = True
            End If
           

            G.FillRectangle(Brushes.Black, 0, 0, BoardWidth, BoardWidth)
            Dim init As String = OuterMsg
            For i As Integer = 0 To PRSFRAME
                init = init & "."
            Next
            G.DrawString(init, New Font("Comic Sans MS", 16, FontStyle.Bold), Brushes.CornflowerBlue, 98, 128)
            sRect = New Rectangle(0, PRSFRAME * 32, 128, 32)
            dRect = New Rectangle(96, 160, 192, 32)
            G.DrawImage(BmpPrs, dRect, sRect, GraphicsUnit.Pixel)
            PRSFRAME += 1
            If PRSFRAME = 6 Then
                PRSFRAME = 0
            End If
        Else
            Dim Rect1 As Rectangle
            Rect1 = New Rectangle(ToonX, ToonY, TileSize, TileSize)
            If TrzKey.ToolVisible Then
                sRect = New Rectangle(0, TrzKey.Code * 32, 32, 32)
                dRect = New Rectangle(TrzKey.ToolX - (MapX * 32 - Xpos), TrzKey.ToolY - (MapY * 32 - Ypos), 32, 32)
                BmpTools.MakeTransparent(Color.White)
                G.DrawImage(BmpTools, dRect, sRect, GraphicsUnit.Pixel)
                If Rect1.IntersectsWith(dRect) Then
                    TrzKey.ToolVisible = False
                    GameTime += 20
                    Map(MazeSize + 1, MazeSize, 0) = 5
                End If
            End If


            For i As Integer = 0 To MaxCrt
                If Crt(i).CreVisible Then
                    If ShowMapState = False And AlertMsgStat = False Then
                        IsWay(Crt(i).CrtX, Crt(i).CrtY, Crt(i).CrtDir)
                    End If
                    sRect = New Rectangle(Math.Floor(CrtFrame) * 32, Crt(i).Code * 32, 32, 32)
                    dRect = New Rectangle(Crt(i).CrtX - (MapX * 32 - Xpos), Crt(i).CrtY - (MapY * 32 - Ypos), 32, 32)
                    If Rect1.IntersectsWith(dRect) And AlertMsgStat = False Then
                        Life -= 1
                    End If
                    BmpCrt.MakeTransparent()
                    G.DrawImage(BmpCrt, dRect, sRect, GraphicsUnit.Pixel)
                End If
            Next
            sRect = New Rectangle((Stage Mod 4) * 64, 0, 64, 64)
            dRect = New Rectangle(((MazeSize + 2) * 32) - (MapX * 32 - Xpos), (MazeSize * 32) - (MapY * 32 - Ypos), 32, 32)
            BmpTrz.MakeTransparent(Color.White)
            G.DrawImage(BmpTrz, dRect, sRect, GraphicsUnit.Pixel)
            If Rect1.IntersectsWith(dRect) Then
                GoToNextStage()
            End If
            CrtFrame += 0.5
            If CrtFrame >= 4 Then
                CrtFrame = 0
            End If
        End If
        If ShowMapState = False And KeyVisible Then
            sRect = New Rectangle(0, 0, 32, 32)
            dRect = New Rectangle(4, 4, 32, 32)
            G.DrawImage(Bmpface, dRect, sRect, GraphicsUnit.Pixel)
            'Cr1.CrtX += 1
            'Cr1.CrtY += 1
            G.DrawRectangle(Pens.Red, 38, 4, MaxLife, 12)
            G.FillRectangle(Brushes.Red, 38, 4, Life, 12)
            G.FillRectangle(Brushes.GreenYellow, 38, 20, MaxLife, 14)
            dRect = New Rectangle(32 * 10, 4, 32, 32)
            G.FillPie(Brushes.BlueViolet, dRect, 0, GameTime * (360 / MaxGameTime))
            G.DrawString(GameTime, New Font("Arial", 8, FontStyle.Bold), Brushes.White, 32 * 10 + 6, 12)
            sRect = New Rectangle(8, 0, 8, 8)
            dRect = New Rectangle(44, 24, 8, 8)
            BmpBullet.MakeTransparent()
            G.DrawImage(BmpBullet, dRect, sRect, GraphicsUnit.Pixel)
            G.DrawString("  X " & Bullet & vbTab & "Stage : " & Stage + 1 & vbTab & Score, New Font("Arial", 8, FontStyle.Bold), Brushes.Blue, 48, 20)
        End If
        If Life <= 0 Or GameTime <= 0 Then
            KeyVisible = False
            ShowMapState = True
            IsGameOver = True
            G.DrawString("Game Over....!!", New Font("Ariel", 30, FontStyle.Bold), Brushes.Black, 1 * TileSize, 5 * TileSize)
        End If
        If AlertMsgStat Then
            AlertMsg(0)
        End If
        'G.DrawString("Tick : " & T_Tick & vbCrLf & _
        '"MaxTick : " & MaxTick & vbCrLf, Me.Font, Brushes.Black, 1, 1)

        'MG = Graphics.FromImage(MBB)
        'MBBG = Me.CreateGraphics
        'MBBG.DrawImage(MBB, MarginFromWidth + BoardWidth + 10, MarginFromHeight, MenuWidth, MenuHeight)
        'MG.Clear(Color.Wheat)
        G = Graphics.FromImage(BB)
        BBG = Me.CreateGraphics
        BBG.DrawImage(BB, MarginFromWidth, MarginFromHeight, BoardWidth, BoardWidth)
        G.Clear(Color.DarkGoldenrod)

    End Sub
    Sub GoToNextStage()
        If Stage = 20 Then
            WonMsgStat = True
            IsRunning = False
            KeyVisible = False
            Exit Sub
        End If
        Stage += 1
        UpdateProfile()
        GTP = GameType.Daynamic
        OuterMsg = "Loading"
        KeyVisible = False
        ReSetGame()
        GameTime += 50 + ((Stage + 1) * 10)
        MaxGameTime += 50 + ((Stage + 1) * 10)
        If Stage <= 20 Then
            MazeSize = 3 * (Stage + 5)
        Else
            MazeSize = 3 * 20
        End If
        MaxCrt = MazeSize \ 3
        Bullet += MaxCrt + 1
        Life = MaxLife
        LoadMaze()
    End Sub
    Sub ReSetGame()
        T_time = 0
        MapX = 1
        MapY = 1
        Xpos = 0
        Ypos = 0
        Guyx = ((MapX + 2) * TileSize)
        GuyY = ((MapX + 2) * TileSize)
        ToonX = 2 * TileSize
        ToonY = 2 * TileSize
        TempMapX = 1
        TempMapY = 1
        TempXpos = 0
        TempYpos = 0
        TempToonx = 2 * TileSize
        TempToonY = 2 * TileSize
    End Sub

    Function IsCreatureInWithBlt() As Boolean
        Dim rect1, rect2 As Rectangle
        rect2 = New Rectangle(BltX, BltY, 8, 8)
        For i As Integer = 0 To MaxCrt
            rect1 = New Rectangle(Crt(i).CrtX - (MapX * 32 - Xpos), Crt(i).CrtY - (MapY * 32 - Ypos), TileSize, TileSize)
            'G.FillRectangle(Brushes.Black, rect1)
            If rect1.IntersectsWith(rect2) Then
                If Crt(i).CreVisible Then
                    Crt(i).CreVisible = False
                    BulletVissible = False
                    BltX = 0
                    BltY = 0
                    Score += 100
                    Return True
                End If
            End If
        Next

    End Function
    Sub IsWay(ByRef LocX As Integer, ByRef LocY As Integer, ByRef LocDir As Short)

        Select Case LocDir
            Case 0
                If Map(LocX / TileSize, Math.Ceiling(LocY / TileSize) - 1, 1) = 1 Then
                    LocDir = Rd.Next(1, 4)
                Else
                    LocY -= 1
                End If
            Case 1

                If Map(LocX / TileSize, Math.Floor(LocY / TileSize) + 1, 1) = 1 Then
                    LocDir = Rd.Next(2, 4)
                Else
                    LocY += 1
                End If
            Case 2

                If Map(Math.Ceiling(LocX / TileSize) - 1, LocY / TileSize, 1) = 1 Then
                    LocDir = 0
                Else
                    LocX -= 1
                End If
            Case 3

                If Map(Math.Floor(LocX / TileSize) + 1, LocY / TileSize, 1) = 1 Then
                    LocDir = Rd.Next(0, 3)
                Else
                    LocX += 1
                End If
        End Select

    End Sub
    Sub DrawMenu()

        If Mhlt Then
            Mhlt = False
        Else
            Mhlt = True
        End If
        sRect = New Rectangle(Math.Abs(CInt(Mhlt)) * 960, 0, 960, 960)
        dRect = New Rectangle(0, 0, TileSize * 12, TileSize * 12)
        G.DrawImage(BmpBg, dRect, sRect, GraphicsUnit.Pixel)


        For y As Integer = 0 To 3
            sRect = New Rectangle(0, y * 192, 768, 192)
            dRect = New Rectangle(48 + (TileSize * 4), y * 32 + ((TileSize * 6)), 128, 32)
            BmpMenu.MakeTransparent()
            G.DrawImage(BmpMenu, dRect, sRect, GraphicsUnit.Pixel)
        Next
        sRect = New Rectangle(1 * 768, SelectedItem * 192, 768, 192)
        dRect = New Rectangle(48 + (TileSize * 4), SelectedItem * 32 + ((TileSize * 6)), 128, 32)
        BmpMenu.MakeTransparent()
        G.DrawImage(BmpMenu, dRect, sRect, GraphicsUnit.Pixel)


        'G.DrawString("Tick : " & T_Tick & vbCrLf & _
        '                  "MaxTick : " & MaxTick & vbCrLf, Me.Font, Brushes.Black, 1, 1)

        'G.DrawString("New Game", New Font("Arial", 30, FontStyle.Italic, GraphicsUnit.Pixel), Brushes.Blue, 32, 32)
        G = Graphics.FromImage(BB)
        BBG = Me.CreateGraphics
        BBG.DrawImage(BB, MarginFromWidth, MarginFromHeight, BoardWidth, BoardWidth)
        G.Clear(Color.Black)
    End Sub
    Sub FireBullet(ByVal dir As Integer)
        If bltCt >= Rang Then
            BltX = 0
            BltY = 0
            BulletVissible = False
            Exit Sub
        End If
        Select Case dir
            Case 1
                BltY -= BulletSpeed
            Case 2
                BltY += BulletSpeed
            Case 3
                BltX -= BulletSpeed
            Case 4
                BltX += BulletSpeed
        End Select
        bltCt += BulletSpeed
        sRect = New Rectangle((bltCt Mod 2) * 8, 0, 8, 8)
        dRect = New Rectangle(BltX, BltY, 8, 8)
    End Sub
    Sub GetTick()
        If T_Sec = TimeOfDay.Second Then
            T_Tick += 1
        Else
            MaxTick = T_Tick
            If T_time <= 4 And IsRunning Then
                T_time += 1
            End If
            MoveSpeed = (2 ^ (Math.Abs(Math.Ceiling(MaxTick / 8) - 4) + 1))
            BulletSpeed = MoveSpeed * 2
            T_Tick = 0
            T_Sec = TimeOfDay.Second
            If IsRunning And AlertMsgStat = False Then
                GameTime -= 1
            End If
        End If
    End Sub
    Function GetColor(ByVal x As Integer, ByVal y As Integer) As Color
        Select Case Map(x, y, 0)
            Case 1
                Map(x, y, 1) = 1
                Return Color.DarkGreen
            Case 5
                Map(x, y, 1) = 0
                Return Color.DarkGoldenrod
            Case Else
                Map(x, y, 1) = 1 '0
                Return Color.Green
        End Select
    End Function
    Sub GetSourceRect(ByVal x As Integer, ByVal y As Integer)
        Select Case Map(x, y, 0)
            Case 0
                sRect = New Rectangle(32, 0, TileSize, TileSize)
                'sRect = New Rectangle(32, 0, 1, 1)
                Map(x, y, 1) = 1 '0
            Case 1
                sRect = New Rectangle(96, 96, TileSize, TileSize)
                'sRect = New Rectangle(64, 64, TileSize, TileSize)
                Map(x, y, 1) = 1
            Case 2
                sRect = New Rectangle(0, 64, TileSize, TileSize)
                Map(x, y, 1) = 1 '0
            Case 3
                sRect = New Rectangle(96, 64, TileSize, TileSize)
                Map(x, y, 1) = 1
            Case 4
                sRect = New Rectangle(32, 32, TileSize, TileSize)
                Map(x, y, 1) = 1 '0
            Case 5
                sRect = New Rectangle(512, 512, 1, 1)
                Map(x, y, 1) = 0
            Case 6
                sRect = New Rectangle(256, 32, TileSize, TileSize)
                Map(x, y, 1) = 1
        End Select

    End Sub
    Sub MoveToon(ByVal dir As Integer)
        Select Case dir
            Case 1
                If IsBlocked(0) = False Then
                    ToonFrame += 1
                    GuyY -= MoveSpeed
                    If ToonY < 2 * TileSize Then
                        Ypos += MoveSpeed
                        If Ypos >= TileSize Then
                            Ypos = 0
                            MapY -= 1
                        End If
                    Else
                        ToonY -= MoveSpeed
                    End If
                End If
            Case 2
                If IsBlocked(1) = False Then
                    ToonFrame += 1
                    GuyY += MoveSpeed
                    If ToonY > 9 * TileSize Then
                        Ypos -= MoveSpeed
                        If Ypos <= TileSize * -1 Then
                            Ypos = 0
                            MapY += 1
                        End If
                    Else
                        ToonY += MoveSpeed
                    End If
                End If

            Case 3
                If IsBlocked(2) = False Then
                    ToonFrame += 1
                    Guyx -= MoveSpeed
                    If ToonX < 2 * TileSize Then
                        Xpos += MoveSpeed
                        If Xpos >= TileSize Then
                            Xpos = 0
                            MapX -= 1
                        End If
                    Else
                        ToonX -= MoveSpeed
                    End If
                End If
            Case 4
                If IsBlocked(3) = False Then
                    ToonFrame += 1
                    Guyx += MoveSpeed
                    If ToonX > 9 * TileSize Then
                        Xpos -= MoveSpeed
                        If Xpos <= TileSize * -1 Then
                            Xpos = 0
                            MapX += 1
                        End If
                    Else
                        ToonX += MoveSpeed
                    End If
                End If
        End Select

    End Sub
    Sub GetToon(ByVal dir As Integer)
        Select Case dir
            Case 1
                sRect = New Rectangle(32 * Math.Floor(ToonFrame Mod 3), 96, TileSize, TileSize)
            Case 2
                sRect = New Rectangle(32 * Math.Floor(ToonFrame Mod 3), 0, TileSize, TileSize)
            Case 3
                sRect = New Rectangle(32 * Math.Floor(ToonFrame Mod 3), 32, TileSize, TileSize)
            Case 4
                sRect = New Rectangle(32 * Math.Floor(ToonFrame Mod 3), 64, TileSize, TileSize)
        End Select
    End Sub
    Function IsBlocked(ByVal dir As Integer) As Boolean
        Select Case dir
            Case 0
                If Map(Guyx / TileSize, Math.Ceiling(GuyY / TileSize) - 1, 1) = 1 Then
                    Return True
                End If
            Case 1
                If Map(Guyx / TileSize, Math.Floor(GuyY / TileSize) + 1, 1) = 1 Then
                    Return True
                End If
            Case 2
                If Map(Math.Ceiling(Guyx / TileSize) - 1, GuyY / TileSize, 1) = 1 Then
                    Return True
                End If
            Case 3
                If Map(Math.Floor(Guyx / TileSize) + 1, GuyY / TileSize, 1) = 1 Then
                    Return True
                End If
        End Select
    End Function
    Sub LoadMaze()


        ReDim Crt(MaxCrt)
        ReDim Map(1000, 1000, 10)
        Dim x As Integer
        Dim y As Integer
        Life = MaxLife
        MazePath = New ArrayList
        For x = 0 To MazeSize + 1
            For y = 0 To MazeSize + 1
                Map(x, y, 0) = 0
                Map(x, y, 1) = 1
                Map(x, y, 2) = 0
            Next
        Next
        For x = 2 To MazeSize - 1
            For y = 2 To MazeSize - 1
                If Rd.Next(1, 10) Mod 2 = 0 Then
                    Map(MapX + x, MapY + y, 0) = 4
                End If
                If Rd.Next(1, 10) Mod 3 = 0 Then
                    Map(MapX + x, MapY + y, 0) = 2
                End If
                If Rd.Next(1, 10) Mod 5 = 0 Then
                    Map(MapX + x, MapY + y, 0) = 3
                End If

            Next
        Next
        For x = 1 To MazeSize
            Map(MapX + x, MapY + 1, 0) = 1
            Map(MapX + 1, MapY + x, 0) = 1
            Map(MapX + x, MapY + MazeSize, 0) = 1
            Map(MapX + MazeSize, MapY + x, 0) = 1
        Next

        Dim TotalCell As Integer = (MazeSize / 3) ^ 2
        Dim CellPos As New ArrayList
        Dim StkCell As New Stack(Of Point)
        Dim VisetedCell As Integer = 0
        For x = 2 To MazeSize - 1
            For y = 2 To MazeSize - 1
                Map(MapX + x, MapY + y, 0) = 5
                CellPos.Add(New Point(MapX + x, MapY + y))
                y += 2
            Next
            x += 2
        Next


        Dim CurCell As Point = CellPos.Item(Rd.Next(0, CellPos.Count))
        StkCell.Push(CurCell)
        MazePath.Add(CurCell)
        Map(CurCell.X, CurCell.Y, 2) = 1
        While VisetedCell < TotalCell - 1
            If HasNab(CurCell) Then
                CurCell = BreackWallBetweenNeb(CurCell)
                StkCell.Push(CurCell)
                Map(CurCell.X, CurCell.Y, 2) = 1
                VisetedCell += 1
            Else
                CurCell = StkCell.Pop
            End If
        End While
        Dim pn As Point
        For i As Integer = 0 To MaxCrt
            Crt(i) = New Creature(Rd.Next(0, 4))
            pn = MazePath.Item(Rd.Next(0, MazePath.Count))
            Crt(i).CrtX = pn.X * 32
            Crt(i).CrtY = pn.Y * 32
        Next

        x = MazeSize + 2
        y = MazeSize
        Map(x, y - 1, 0) = 6
        Map(x - 1, y, 0) = 6
        Map(x - 1, y - 1, 0) = 6
        Map(x, y + 1, 0) = 6
        Map(x + 1, y, 0) = 6
        Map(x + 1, y + 1, 0) = 6
        Map(x - 1, y + 1, 0) = 6
        Map(x + 1, y - 1, 0) = 6
        Map(x, y, 0) = 5
        'Map(MazeSize + 1, MazeSize + 2, 0) = 6
        'Map(MazeSize, MazeSize + 2, 0) = 6
        'Map(MazeSize + 2, MazeSize + 2, 0) = 6
        'Map(MazeSize + 1, MazeSize, 0) = 6
        'Map(MazeSize, MazeSize + 1, 0) = 6

        TrzKey = New Tools(ToolsType.Key)
        pn = MazePath.Item(Rd.Next(10, MazePath.Count))
        TrzKey.ToolX = pn.X * 32
        TrzKey.ToolY = pn.Y * 32
    End Sub
    Function BreackWallBetweenNeb(ByVal Loc As Point) As Point
        Dim x As Integer = Loc.X
        Dim y As Integer = Loc.Y
        Dim FP, SP As Point
        Dim MainStore As New ArrayList
        Dim FirstStore As New ArrayList
        Dim SecondStore As New ArrayList
        Dim Ind As Integer
        If x - 3 > 0 And Map(x - 3, y, 2) = 0 Then
            MainStore.Add(New Point(x - 3, y))
            FirstStore.Add(New Point(x - 2, y))
            SecondStore.Add(New Point(x - 1, y))
        End If
        If y - 3 > 0 And Map(x, y - 3, 2) = 0 Then
            MainStore.Add(New Point(x, y - 3))
            FirstStore.Add(New Point(x, y - 2))
            SecondStore.Add(New Point(x, y - 1))
        End If
        If x + 3 <= MazeSize And Map(x + 3, y, 2) = 0 Then
            MainStore.Add(New Point(x + 3, y))
            FirstStore.Add(New Point(x + 2, y))
            SecondStore.Add(New Point(x + 1, y))
        End If
        If y + 3 <= MazeSize And Map(x, y + 3, 2) = 0 Then
            MainStore.Add(New Point(x, y + 3))
            FirstStore.Add(New Point(x, y + 2))
            SecondStore.Add(New Point(x, y + 1))
        End If
        Ind = Rd.Next(0, MainStore.Count)
        FP = FirstStore.Item(Ind)
        SP = SecondStore.Item(Ind)
        Map(FP.X, FP.Y, 0) = 5
        Map(SP.X, SP.Y, 0) = 5
        MazePath.Add(New Point(FP.X, FP.Y))
        MazePath.Add(New Point(SP.X, SP.Y))
        MazePath.Add(New Point(MainStore.Item(Ind).x, MainStore.Item(Ind).y))
        Return MainStore.Item(Ind)

    End Function
    Function HasNab(ByVal Loc As Point) As Boolean
        Dim x As Integer = Loc.X
        Dim y As Integer = Loc.Y
        Dim ct As Integer = 0
        If x - 3 > 0 Then
            If Map(x - 3, y, 2) = 0 Then
                ct += 1
            End If
        End If
        If y - 3 > 0 Then
            If Map(x, y - 3, 2) = 0 Then
                ct += 1
            End If
        End If
        If x + 3 <= MazeSize Then
            If Map(x + 3, y, 2) = 0 Then
                ct += 1
            End If
        End If
        If y + 3 <= MazeSize Then
            If Map(x, y + 3, 2) = 0 Then
                ct += 1
            End If
        End If
        If ct = 0 Then
            Return False
        Else
            Return True
        End If
    End Function
    Sub SetName()


        G.DrawString("Enter Your Name", New Font("Comic Sans MS", 20, FontStyle.Bold), Brushes.Gold, 32 * 3 - 16, 32 * 4 - 16)
        G.FillRectangle(Brushes.DarkBlue, 32 * 4 - 16, 32 * 5, 32 * 5, 32)
        G.DrawString(PlayerName, New Font("Comic Sans MS", 16, FontStyle.Bold), Brushes.GreenYellow, 32 * 4 - 16, 32 * 5)
        If AlertMsgStat Then
            AlertMsg(1)
        End If
        G = Graphics.FromImage(BB)
        BBG = Me.CreateGraphics
        BBG.DrawImage(BB, MarginFromWidth, MarginFromHeight, BoardWidth, BoardWidth)
        G.Clear(Color.Black)
    End Sub
    Sub ShowOptions()
        dRect = New Rectangle(0, 0, 32 * 12, 32 * 7)
        sRect = New Rectangle(0, 0, 1282, 1146)
        G.DrawImage(BmpControls, dRect, sRect, GraphicsUnit.Pixel)
        G.DrawString("_________________________________________________________________", New Font("Arial", 20, FontStyle.Bold), Brushes.Wheat, 0, 32 * 6 + 10)
        G.DrawString("                  Rules", New Font("Arial", 20, FontStyle.Bold), Brushes.DarkGoldenrod, 0, 32 * 7 + 5)
        G.DrawString("_________________________________________________________________", New Font("Arial", 20, FontStyle.Bold), Brushes.Wheat, 0, 32 * 7 + 5)
        G.DrawString("       Play the Game using above controls. First find the key " & vbNewLine & _
        "and knock down the wall of treasure and go to next stage." & vbNewLine & vbNewLine & _
        "    Stay away from the creatures or kill them using bullets." & vbNewLine & _
        "Get treasure in given time and life...!!!", New Font("Arial", 10, FontStyle.Bold), Brushes.White, 0, 32 * 8 + 10)
        G = Graphics.FromImage(BB)
        BBG = Me.CreateGraphics
        BBG.DrawImage(BB, MarginFromWidth, MarginFromHeight, BoardWidth, BoardWidth)
        G.Clear(Color.Black)
    End Sub
    Sub DrawWin()
        sRect = New Rectangle(WF_Frame * 300, 0, 300, 300)
        dRect = New Rectangle(0, 0, TileSize * MaxTile, TileSize * MaxTile)
        G.DrawImage(BmpWon, dRect, sRect, GraphicsUnit.Pixel)
        If WF_Frame >= 16 Then
            WF_Frame = 0
        Else
            WF_Frame += 1
        End If
        G.DrawString("YOU WON...!!", New Font("Arial", 30, FontStyle.Bold), Brushes.CornflowerBlue, TileSize * 2, TileSize * 5)
        G = Graphics.FromImage(BB)
        BBG = Me.CreateGraphics
        BBG.DrawImage(BB, MarginFromWidth, MarginFromHeight, BoardWidth, BoardWidth)
        G.Clear(Color.Black)
    End Sub

    Private Sub GameEngin(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TMGameEngin.Tick
        If WonMsgStat Then
            DrawWin()
        ElseIf ShowAllprofileState Then
            ShowAllprofile()
        ElseIf GateNameState Then
            SetName()
        ElseIf OptStat Then
            ShowOptions()
        ElseIf IsRunning Then
            MoveToon(MoveDir)
            DrawGrphics()
        Else
            DrawMenu()
        End If

        GetTick()

    End Sub

    Private Sub Form1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseClick
        'MsgBox(Crt.CrtX & ":::" & Crt.CrtY)
        'MsgBox("Mapx : " & MapX & vbCrLf & _
        '"MapY : " & MapY & vbCrLf & _
        '"Xpos : " & Xpos & vbCrLf & _
        '"Ypos : " & Ypos & vbCrLf & _
        '"guyx : " & Guyx & vbCrLf & _
        '"guyy : " & GuyY & vbCrLf & _
        ' "Toonx : " & ToonX & vbCrLf & _
        '"toony : " & ToonY & vbCrLf)
    End Sub
End Class
Enum GameType
    Simple
    Daynamic
End Enum
