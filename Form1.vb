Imports System.Security.Cryptography.X509Certificates

Public Class Form1
    Public Structure RecEmployee
        Public ename As String
        Public DOB As Date
        Public HireDate As Date
    End Structure
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click

        Dim num(5) As Integer
        Dim MyEmployee As New RecEmployee

        num(0) = 6
        num(1) = 19
        num(2) = 1
        num(3) = 10
        num(4) = 12
        MyEmployee.ename = "Geoffery"
        MyEmployee.DOB = #1/1/2001#
        MyEmployee.HireDate = #5/16/2021#
        ' Note MM/DD/YYYY Format

        lstOutput.Items.Add("Employee Name: " & MyEmployee.ename)
        lstOutput.Items.Add("Employee DOB : " & MyEmployee.DOB)
        lstOutput.Items.Add("Employee Hire Date: " & MyEmployee.HireDate)

        For i = 0 To 4
            'CInt(InputBox("Please Enter Number " & CStr(i)))
            lstOutput.Items.Add(num(i))
        Next i
        Array.Reverse(num)
        For i = 1 To 5
            lstOutput.Items.Add(num(i))
        Next i

    End Sub
End Class
