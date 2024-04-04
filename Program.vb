Imports System

Public Class Student
    Public Name As String
    Public Age As Integer
    Public Grade As Double
End Class

Public Class Program
    Private Sub DisplayMenu()
        Console.WriteLine("1. Add student")
        Console.WriteLine("2. Display students")
        Console.WriteLine("3. Delete students")

        Console.Write("Enter your choice: ")
    End Sub

    Private Sub AddStudent(students As List(Of Student))
        Console.Write("Enter student name: ")
        Dim name As String = Console.ReadLine()
        Console.Write("Enter student age: ")
        Dim age As Integer = Int(Console.ReadLine())
        Console.Write("Enter student grade: ")
        Dim grade As Double = Double.Parse(Console.ReadLine())

        students.Add(New Student With {.Name = name, .Age = age, .Grade = grade})
    End Sub

    Private Sub DisplayStudents(students As List(Of Student))
        Console.WriteLine("Name     Age     Grade")
        For Each student As Student In students
            Console.WriteLine($"{student.Name}       {student.Age}      {student.Grade}")
        Next
    End Sub
    Private Sub DeleteStudents(students As List(Of Student))
        Console.Write("Enter the name of the student to delete: ")
        Dim name As String = Console.ReadLine()
        Dim student As Student = students.FirstOrDefault(Function(s) s.Name = name)
        If student IsNot Nothing Then
            students.Remove(student)
        Else
            Console.WriteLine("Student not found")
        End If
    End Sub

    Public Sub Run()
        Dim students As New List(Of Student)
        While True
            DisplayMenu()
            Dim choice As Integer = Int(Console.ReadLine())
            Select Case choice
                Case 1
                    AddStudent(students)
                Case 2
                    DisplayStudents(students)
                Case 3
                    DeleteStudents(students)


                Case Else
                    Console.WriteLine("Invalid choice")
            End Select
        End While
    End Sub
End Class

Module Module1
    Sub Main()
        Dim program As New Program()
        program.Run()
    End Sub
End Module