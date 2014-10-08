Option Strict On

Public Class Form1

    Private Sub btnPopulation_Click(sender As Object, e As EventArgs) Handles btnPopulation.Click
        Dim pop As Double
        Dim year As Integer = 2014

        pop = 7000000000

        Do While pop >= 6000000
            pop = pop / 2
            year = year - 50
        Loop


        MessageBox.Show(CStr(year))

    End Sub
End Class
