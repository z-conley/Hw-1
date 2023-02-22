' Project name: French numbers
' Author: Zachary Conley
' Date: February 21,2023
' Purpose: This application is used to show the numbers 1 through 5 in the french language when the particular button is clicked
Public Class Form1
    Private Sub Btnexit_Click(sender As Object, e As EventArgs) Handles Btnexit.Click
        'This event handler closes the application once clicked
        Close()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MinimizeBox = False
        MaximizeBox = False

    End Sub

    Private Sub Btnnum1_Click(sender As Object, e As EventArgs) Handles Btnnum1.Click
        Lblfrench.Text = "Un"

    End Sub

    Private Sub Btnnum2_Click(sender As Object, e As EventArgs) Handles Btnnum2.Click
        Lblfrench.Text = "Deux"

    End Sub

    Private Sub Btnnum3_Click(sender As Object, e As EventArgs) Handles Btnnum3.Click
        Lblfrench.Text = "Trois"

    End Sub

    Private Sub Btnnum4_Click(sender As Object, e As EventArgs) Handles Btnnum4.Click
        Lblfrench.Text = "Quatre"

    End Sub

    Private Sub Btnnum5_Click(sender As Object, e As EventArgs) Handles Btnnum5.Click
        Lblfrench.Text = "Cinq"

    End Sub
End Class
