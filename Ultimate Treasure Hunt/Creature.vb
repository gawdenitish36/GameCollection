Public Enum CreatureType
    Spaider
    Star
    Gost
End Enum
Public Class Creature
    Public Type As CreatureType
    Public Code As Short
    Public CrtX, CrtY As Integer
    Public CrtDir As Short
    Public CreVisible As Boolean
    Public Sub New(ByVal CrtType As CreatureType)
        If CrtType = CreatureType.Star Then
            Code = 0
        ElseIf CrtType = CreatureType.Gost Then
            Code = 1
        ElseIf CrtType = CreatureType.Spaider Then
            Code = 2
        End If
        CreVisible = True
    End Sub
End Class
