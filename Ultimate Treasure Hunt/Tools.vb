Public Enum ToolsType
    Key
    Life
    Time
    Bullet
End Enum
Public Class Tools
    Public Type As ToolsType
    Public Code As Short
    Public ToolX, ToolY As Integer
    Public ToolVisible As Boolean
    Public Sub New(ByVal ToolType As ToolsType)
        If ToolType = ToolsType.Key Then
            Code = 0
        ElseIf ToolType = ToolsType.Life Then
            Code = 1
        ElseIf ToolType = ToolsType.Time Then
            Code = 2
        ElseIf ToolType = ToolsType.Bullet Then
            Code = 2
        End If
        ToolVisible = True
    End Sub
End Class
