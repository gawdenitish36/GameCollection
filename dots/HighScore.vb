Imports System.Windows.Forms
Imports System.IO


Public Class HighScore
    Public SC_Easy As ArrayList
    Public SC_Normal As ArrayList
    Public SC_Hard As ArrayList

    Private Sub HighScore_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        LV_Easy.Items.Clear()
        LV_Normal.Items.Clear()
        LV_Hard.Items.Clear()
    End Sub
    Public Sub UpdateFinalScore(ByVal NM As String, ByVal SC As Integer, ByVal lvl As Int16)
        Dim i As Integer
        Dim HS_Obj As New HScore
        HS_Obj._name = NM
        HS_Obj.score = SC
        HS_Obj._date = Date.Today.ToShortDateString
        If lvl = 1 Then

            i = SC_Easy.Count - 1
            If i >= 0 Then
                While SC_Easy.Item(i).score < SC
                    i -= 1
                    If i < 0 Then
                        Exit While
                    End If
                End While
                SC_Easy.Insert(i + 1, HS_Obj)
                If SC_Easy.Count > 5 Then
                    SC_Easy.RemoveAt(SC_Easy.Count - 1)
                End If
            Else
                SC_Easy.Add(HS_Obj)
            End If
        ElseIf lvl = 2 Then
            i = SC_Normal.Count - 1
            If i >= 0 Then
                While SC_Normal.Item(i).score < SC
                    i -= 1
                    If i < 0 Then
                        Exit While
                    End If
                End While
                SC_Normal.Insert(i + 1, HS_Obj)
                If SC_Normal.Count > 5 Then
                    SC_Normal.RemoveAt(SC_Normal.Count - 1)
                End If
            Else
                SC_Normal.Add(HS_Obj)
            End If
        Else

            i = SC_Hard.Count - 1
            If i >= 0 Then
                While SC_Hard.Item(i).score < SC
                    i -= 1
                    If i < 0 Then
                        Exit While
                    End If
                End While
                SC_Hard.Insert(i + 1, HS_Obj)
                If SC_Hard.Count > 5 Then
                    SC_Hard.RemoveAt(SC_Hard.Count - 1)
                End If
            Else
                SC_Hard.Add(HS_Obj)
            End If
        End If
        SaveScore()
    End Sub
    Public Sub LoadScore()
        Dim FS As New FileStream("Score.txt", FileMode.Open)
        Dim SR As New StreamReader(FS)
        Dim st As String
        Dim I As Integer = 0
        SC_Easy = New ArrayList
        SC_Normal = New ArrayList
        SC_Hard = New ArrayList
        Try

        
            While True
                st = SR.ReadLine
                If st = "N@O@R@M@A@L" Then
                    I = 0
                    Exit While
                Else
                    Dim obj_Easy As New HScore
                    With obj_Easy
                        ._name = st
                        .score = CInt(Val(SR.ReadLine))
                        ._date = SR.ReadLine
                    End With
                    SC_Easy.Add(obj_Easy)
                End If

                If I = 16 Then
                    Throw New Exception
                End If
                I += 1
            End While

            While True
                st = SR.ReadLine
                If st = "H@A@R@D" Then
                    I = 0
                    Exit While
                Else
                    Dim obj_Normal As New HScore
                    With obj_Normal
                        ._name = st
                        .score = CInt(Val(SR.ReadLine))
                        ._date = SR.ReadLine
                    End With
                    SC_Normal.Add(obj_Normal)
                End If
                If I = 16 Then
                    Throw New Exception
                End If
                I += 1
            End While

            While True
                st = SR.ReadLine
                If st = "E@N@D" Then
                    I = 0
                    Exit While
                Else
                    Dim obj_Hard As New HScore
                    With obj_Hard
                        ._name = st
                        .score = CInt(Val(SR.ReadLine))
                        ._date = SR.ReadLine
                    End With
                    SC_Hard.Add(obj_Hard)
                End If
                If I = 16 Then
                    Throw New Exception
                End If
                I += 1
            End While
        Catch ex As Exception
            SR.Close()
            FS.Close()
            FS = New FileStream("Score.txt", FileMode.Truncate)
            Dim SW As New StreamWriter(FS)
            SW.WriteLine("N@O@R@M@A@L")
            SW.WriteLine("H@A@R@D")
            SW.WriteLine("E@N@D")
            MsgBox("Your Score File Is May Be Currupted So It is Reset...!", MsgBoxStyle.Critical, "Information....!!!")
            SW.Close()
            FS.Close()
            LoadScore()
            Exit Sub
        End Try
        SR.Close()
        FS.Close()
    End Sub
    Public Sub SaveScore()
        Dim FS As New FileStream("Score.txt", FileMode.Truncate)
        Dim SW As New StreamWriter(FS)

        For I As Integer = 0 To SC_Easy.Count - 1
            SW.WriteLine(SC_Easy.Item(I)._name)
            SW.WriteLine(SC_Easy.Item(I).score)
            SW.WriteLine(SC_Easy.Item(I)._date)
        Next
        SW.WriteLine("N@O@R@M@A@L")
        For I As Integer = 0 To SC_Normal.Count - 1
            SW.WriteLine(SC_Normal.Item(I)._name)
            SW.WriteLine(SC_Normal.Item(I).score)
            SW.WriteLine(SC_Normal.Item(I)._date)
        Next
        SW.WriteLine("H@A@R@D")
        For I As Integer = 0 To SC_Hard.Count - 1
            SW.WriteLine(SC_Hard.Item(I)._name)
            SW.WriteLine(SC_Hard.Item(I).score)
            SW.WriteLine(SC_Hard.Item(I)._date)
        Next
        SW.WriteLine("E@N@D")
        SW.Close()
        FS.Close()
    End Sub


    Private Sub HighScore_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For I As Integer = 0 To SC_Easy.Count - 1
            LV_Easy.Items.Add(I + 1)
            Dim ar() As String = {SC_Easy.Item(I)._name, SC_Easy.Item(I).score, SC_Easy.Item(I)._date}
            LV_Easy.Items(I).SubItems.AddRange(ar)
        Next
        For I As Integer = 0 To SC_Normal.Count - 1
            LV_Normal.Items.Add(I + 1)
            Dim ar() As String = {SC_Normal.Item(I)._name, SC_Normal.Item(I).score, SC_Normal.Item(I)._date}
            LV_Normal.Items(I).SubItems.AddRange(ar)
        Next
        For I As Integer = 0 To SC_Hard.Count - 1
            LV_Hard.Items.Add(I + 1)
            Dim ar() As String = {SC_Hard.Item(I)._name, SC_Hard.Item(I).score, SC_Hard.Item(I)._date}
            LV_Hard.Items(I).SubItems.AddRange(ar)
        Next

    End Sub



End Class
Public Class HScore
    Public score As Integer
    Public _name, _date As String
End Class

