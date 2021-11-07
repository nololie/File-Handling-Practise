Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Public Class Form1
    Private Sub btnRegisterStudent_Click(sender As Object, e As EventArgs) Handles btnRegisterStudent.Click
        Dim Student As Student = New Student(TextBox1.Text, TextBox2.Text, TextBox3.Text)
        Dim FS As FileStream = New FileStream("Destiny Students.txt", FileMode.Create, FileAccess.Write)
        Dim BF As BinaryFormatter = New BinaryFormatter()

        BF.Serialize(FS, Student)

        FS.Close()
        MsgBox("Registered " + Student._Surname + " " + Student._Name)
    End Sub
End Class
