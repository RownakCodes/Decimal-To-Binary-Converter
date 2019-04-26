Module Module1

    Sub Main()
        Console.WriteLine("                                        Denery to 8 bit Binary:")

        Dim input, entered As Integer
        Dim conversion As String

        Console.WriteLine("Enter the number :")
        input = Console.ReadLine()

        conversion = ""
        entered = input


        For x = 0 To 7

            If input > 255 Then
                Console.WriteLine("The number you entered is too big for a 8 bit binary to store!")
                Exit For
            End If


            Select Case x
                Case 0
                    If input >= 128 Then
                        input = input - 128
                        conversion = conversion + "1"
                    Else
                        conversion = conversion + "0"
                    End If

                Case 1

                    If input >= 64 Then
                        input = input - 64
                        conversion = conversion + "1"
                    Else
                        conversion = conversion + "0"
                    End If

                Case 2

                    If input >= 32 Then
                        input = input - 32
                        conversion = conversion + "1"
                    Else
                        conversion = conversion + "0"
                    End If


                Case 3

                    If input >= 16 Then
                        input = input - 16
                        conversion = conversion + "1"
                    Else
                        conversion = conversion + "0"
                    End If


                Case 4

                    If input >= 8 Then
                        input = input - 8
                        conversion = conversion + "1"
                    Else
                        conversion = conversion + "0"
                    End If


                Case 5

                    If input >= 4 Then
                        input = input - 4
                        conversion = conversion + "1"
                    Else
                        conversion = conversion + "0"
                    End If

                Case 6

                    If input >= 2 Then
                        input = input - 2
                        conversion = conversion + "1"
                    Else
                        conversion = conversion + "0"
                    End If


                Case 7

                    If input >= 1 Then
                        input = input - 1
                        conversion = conversion + "1"
                    Else
                        conversion = conversion + "0"
                    End If

            End Select


        Next

        Console.WriteLine("The binary of " & entered & " is : " & conversion)
    End Sub

End Module