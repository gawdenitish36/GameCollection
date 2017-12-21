Public Class Cells
    Public LineAbove As Lines
    Public LineUnder As Lines
    Public LineBehind As Lines
    Public LineAhead As Lines
    Public CellImage As PictureBox
    Public CellImageUsed As Boolean
    Public CellLineUsed As Byte
    Public CellOwner As Byte
    Sub New()
        CellLineUsed = 0
        CellImageUsed = False
        CellOwner = 2
    End Sub
  

End Class
