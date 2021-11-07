<Serializable()> Public Class Student
    Public _Name As String
    Public _Surname As String
    Private _Grade As Integer

    Public Sub New(Name As String, Surname As String, Grade As String)
        _Name = Name
        _Surname = Surname
        _Grade = Grade
    End Sub

    Public ReadOnly Property Grade
        Get
            Return _Grade
        End Get
    End Property
End Class