Public Class ANIMAL
    Private animalType As String
    Private age As Integer
    Private legNumber As Integer

    Public Sub New(ByVal animalType1 As String, ByVal age1 As Integer, ByVal legNumber1 As Integer)
        animalType = animalType1
        age = age1
        legNumber = legNumber1
    End Sub

    Public Sub PrintType()
        Console.WriteLine(animalType)
    End Sub

    Public Sub PrintAge()
        Console.WriteLine(age)
    End Sub
    Public Sub PrintLegNumber()
        Console.WriteLine(legNumber)
    End Sub
End Class
