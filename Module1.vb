Module Module1

    Sub Main()
        'David M Kinnen
        '19/03/2020
        'A program that uses GOTO statements ... how NOT to program.
        Dim num1, num2, num3 As Integer
        Console.WriteLine("Here is an example of old fashioned BASIC.")
9:      num3 = num1 + num2
        Console.Write("Please enter a value for num1: ")
        num1 = Console.ReadLine()
        Console.Write("Please enter a value for num1: ")
        num2 = Console.ReadLine()
        GoTo 17
        Console.WriteLine($"The value of num1: {num1}, num2: {num2}, and num3: {num3}.")
        GoTo 18
17:     Console.WriteLine($"The value of num1: {num1}, num2: {num2}, and num3: {num3}.")
18:     num1 = 0
        GoTo 9
        Console.ReadLine()
    End Sub

End Module
