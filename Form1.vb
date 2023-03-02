Public Class Form1
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Dim num(5) As Integer

        num(0) = 6
        num(1) = 19
        num(2) = 1
        num(3) = 10
        num(4) = 12

        For i = 0 To 4
            lstOutput.Items.Add(num(i))
        Next i
        Array.Reverse(num)
        For i = 1 To 5
            lstOutput.Items.Add(num(i))
        Next i
    End Sub
End Class
