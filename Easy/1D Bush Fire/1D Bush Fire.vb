Module Solution

    Sub Main ()
        
        Dim N as Integer
        N = Console.ReadLine()

        For i as Integer = 0 To N-1
            Dim a as Integer
            a = 0
            Dim line as String
            line = Console.ReadLine()
            For c As Integer = 0 To line.Length()-1
                If line(c)="f" Then
                    a = a+1
                    c = c+2
                End If
            Next
            Console.WriteLine(a)
        Next
    End Sub
End Module