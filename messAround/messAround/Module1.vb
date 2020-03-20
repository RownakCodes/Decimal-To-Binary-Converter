Imports System

Module Program
    Sub Main(args As String())
        Dim str, newstr As String
        str = ""
        Dim bin As Integer = 56

        While bin > 0
            str += CStr(bin Mod 2)
            bin = bin \ 2
        End While

        'Code for reversing a string
        newstr = ""
        For index = Len(str) - 1 To 0 Step -1
            newstr = newstr + str(index)
        Next
        Console.WriteLine(newstr)
    End Sub
End Module
