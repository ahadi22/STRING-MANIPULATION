﻿Module Module1

    Sub Main()

        Dim Str1 As String
        Dim Char1 As Char
        Dim i, vowelCounter As Integer


        Str1 = ""
        Char1 = ""
        i = 0
        vowelCounter = 0


        Console.Write("Enter string to process: ")
        Str1 = Console.ReadLine


        For i = 1 To Len(Str1)
            Char1 = Mid(Str1, i, 1)
            Char1 = UCase(Char1)
            If Char1 = "A" Or Char1 = "E" Or _
                Char1 = "I" Or Char1 = "O" Or _
                Char1 = "U" Then

                vowelCounter = vowelCounter + 1
            End If
        Next


        Console.WriteLine("Vowels in string are: " & vowelCounter)


        Console.ReadKey()
    End Sub

End Module
