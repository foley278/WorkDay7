Option Strict On

Module Module1

    Sub Main()
        Dim num As Integer = 1

        Do While num <= 7

            If num > 5 Then
                Continue Do
            End If

            Console.WriteLine(" " & num)
            num = num + 1
        Loop

    End Sub

End Module
