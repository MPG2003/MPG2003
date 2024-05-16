Public Class Student
        Public Name As String
        Public stu_id As Integer
        Public address As Char

        ' Constructor to initialize the Employee object
        Public Sub New(name As String, stu_id As Integer, address As Char)
            Me.Name = name
            Me.stu_id = stu_id
            Me.address =ad

        End Sub

        ' Function to display student details
        Public Sub DisplayDetails()
            Console.WriteLine("Name: " & Name)
            Console.WriteLine("stu_id: " & stu_id)
        Console.WriteLine("address:" & ad)
        Console.WriteLine()
        End Sub
    End Class

    Module Program
    Sub Main()
        Dim stu As New List(Of students)()

        Dim choice As Integer

        Do
            Console.WriteLine("Menu:")
            Console.WriteLine("1. Add students")
            Console.WriteLine("2. Display All students")
            Console.WriteLine("3. Delete")
            Console.WriteLine("4. Exit")
            Console.Write("Enter your choice: ")
            choice = Console.ReadLine()

            Select Case choice
                Case 1
                    Console.Write("Enter student name: ")
                    Dim name As String = Console.ReadLine()
                    Console.Write("Enter student stu_id: ")
                    Dim Emp_id As Integer = Convert.ToInt32(Console.ReadLine())
                    Console.Write("Enter  address: ")
                    Dim salary As Char = Console.ReadLine()(0)

                    ' Create a new Employee object and add it to the list
                    Dim employee As New Student(name, stu_id, ad)
                    Emp.Add(employee)
                    Console.WriteLine("student added successfully.")
                    Console.WriteLine()
                Case 2
                    If Emp.Count > 0 Then
                        Console.WriteLine("Details of all student:")
                        For Each student As Student In Stu
                            student.DisplayDetails()
                        Next
                    Else
                        Console.WriteLine("No student  added yet.")
                    End If
                    Console.WriteLine()
                Case 3
                    If stu.Count > 0 Then
                        Emp.Clear()
                        Console.WriteLine(" All Succesfully deleted")
                    Else
                        Console.WriteLine("No student added yet.")
                    End If
                    Console.WriteLine()

                Case 4
                    Console.WriteLine("Exiting program...")

                Case Else
                    Console.WriteLine("Invalid choice. Please enter a valid option.")
                    Console.WriteLine()
            End Select

        Loop While choice <> 3
    End Sub
End Module
