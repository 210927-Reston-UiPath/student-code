Imports System

Module Program
    Sub Main (args As String())
        Console.WriteLine("What does the cat say")
        dim repeat as Boolean = true
        Do While repeat
            Console.WriteLine("What would you like to do?")
            Console.WriteLine("[0] Say Meow")
            Console.WriteLine("[x] Exit")
            Dim input as string = Console.ReadLine()
            Select Case input
                Case "0"
                    Console.WriteLine("Meow       
                    <   o
                          > )
                    <   o") 
                    
                Case "x"
                    Console.WriteLine("Goodbye")
                    repeat = false
            End Select
        Loop
    End Sub
End Module
