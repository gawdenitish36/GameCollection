Public Class FinalResult
    Dim FN As New Font("Arial", 10, FontStyle.Bold)
    'Trt
    Dim T_Trt As Integer
    Dim Ktrt As Integer
    Dim MTrt As Integer
    Dim Trt As Integer = 0
    'Cvl
    Dim T_Cvl As Integer
    Dim KCvl As Integer
    Dim MCvl As Integer
    Dim Cvl As Integer = 0
    'Blank
    Dim T_Blank As Integer
    Dim KBlank As Integer
    Dim MBlank As Integer
    Dim Blank As Integer = 0




    Dim Rect As Rectangle
    Dim Msg As String = "BEST"
    Dim Ct As Integer = 0
    Dim P1 As New SolidBrush(Color.Gold)
    Dim P2 As New SolidBrush(Color.DarkRed)
    Dim P3 As New SolidBrush(Color.Maroon)
    Dim P4 As New SolidBrush(Color.Orange)
    Dim P5 As New SolidBrush(Color.Brown)
    Dim Avg As Integer
    Dim MX As Integer

    Private Sub DrawFinalResult(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim X As Integer
        Dim Y As Integer = 50
        With e.Graphics
            .Clear(Color.Black)
            '.DrawLine(Pens.White, 0, 99, 300, 99)
            'trt
            X = 30
            .DrawString(Trt & "%", FN, Brushes.White, X, Y - 20)
            .DrawString("Wanted", FN, Brushes.White, X, Y + 105)
            If Trt < MTrt Then
                Trt += 1
            End If
            Rect = New Rectangle(X + 10, Y + 100 - Trt, 20, Trt)

            .FillRectangle(Brushes.Green, Rect)


            'Cvl
            X += 80
            .DrawString(Cvl & "%", FN, Brushes.White, X, Y - 20)
            .DrawString("Civilians", FN, Brushes.White, X, Y + 105)
            If Cvl < MCvl Then
                Cvl += 1
            End If
            Rect = New Rectangle(X + 10, Y + 100 - Cvl, 20, Cvl)

            .FillRectangle(Brushes.Green, Rect)


            'Blank
            X += 80
            .DrawString(Blank & "%", FN, Brushes.White, X, Y - 20)
            .DrawString(" Blank", FN, Brushes.White, X, Y + 105)
            If Blank < MBlank Then
                Blank += 1
            End If
            Rect = New Rectangle(X + 10, Y + 100 - Blank, 20, Blank)
            .DrawLine(Pens.White, 0, Y + 100, 300, Y + 100)
            .FillRectangle(Brushes.Green, Rect)

            If Ct >= 100 Then
                Dim Sp As SolidBrush = P1
                P1 = P2
                P2 = P3
                P3 = P4
                P4 = P5
                P5 = Sp
                .DrawString(Msg, New Font("Arial", 50, FontStyle.Bold), Sp, MX, 200)
            Else
                Ct += 1
            End If
        End With
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.Refresh()
    End Sub

    Private Sub MakeFinalResult(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Trt
        T_Trt = MainShooter.TStrt
        Ktrt = MainShooter.STrt
        Try

            MTrt = Math.Ceiling((Ktrt * 100) / T_Trt)
        Catch ex As Exception
            MTrt = 0
        End Try


        'Cvl
        T_Cvl = MainShooter.TScivil
        KCvl = MainShooter.SCivil
        Try
            MCvl = Math.Ceiling((KCvl * 100) / T_Cvl)
        Catch ex As Exception
            MCvl = 0
        End Try


        'Blank
        T_Blank = MainShooter.BoardWidth ^ 2
        KBlank = MainShooter.SBlank
        Try
            MBlank = Math.Ceiling((KBlank * 100) / T_Blank)
        Catch ex As Exception
            MBlank = 0
        End Try
        MX = 40
        Avg = (MCvl + MBlank) / 2
        If Avg <= 25 And MTrt > 75 Then
            Msg = "BEST"
        ElseIf Avg <= 50 And MTrt > 50 Then
            Msg = "GOOD"
        ElseIf Avg <= 75 And MTrt > 25 Then
            MX = 60
            Msg = "BAD"
        Else
            MX = 10
            Msg = "WORST"
        End If

        Timer1.Start()
    End Sub
End Class