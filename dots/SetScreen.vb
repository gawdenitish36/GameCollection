Public Class SetScreen
    Public Shared XR, YR As Integer
    Public Shared Sub setFrom(ByVal i As Control)
        i.Width = ((XR * i.Width) / 100)
        i.Height = ((YR * i.Height) / 100)
        SetControls(i)
    End Sub
    Public Shared Sub SetControls(ByVal i As Control)
        For Each con As Control In i.Controls
            SetControls(con)
            con.Width = ((XR * con.Width) / 100)
            con.Height = ((YR * con.Height) / 100)
            con.Location = New Point(((XR * con.Location.X) / 100), ((YR * con.Location.Y) / 100))
            con.Font = New Font(con.Font.FontFamily, (XR * con.Font.Size) / 100)
        Next
    End Sub
End Class
