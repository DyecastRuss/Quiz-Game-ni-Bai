Imports System
Module Program
    Sub Main(args As String())
        Dim Questions As String() = {
            "Who is the President of QCU",
            "What is the meaning of the acronym of QCU",
            "What is OOP"
        }

        Dim options As String() = {
        "A. Dr. Theresita V. Atienza B. Sir Denver Bermil C. Sir Ronnie Gatdula",
        "A. Quezo Carbornara Ubas B. Quezon City University C. Quezon City Unsa",
        "A. Object Orient Programming B. Oo Pogi C. Orasan at Okra na kulay Pink"
        }

        Dim answers() As Char = {"A"c, "B"c, "A"c}
        Dim score As Integer = 0

        Console.WriteLine("QUIZ LANG")
        Console.WriteLine("Choose the correct answer")
        Console.WriteLine()

        For i As Integer = 0 To Questions.Length - 1
            Console.WriteLine(Questions(i))
            Console.WriteLine(options(i))
            Console.Write("Your answer (A, B, C): ")

            Dim userAnswer As Char = Char.ToUpper(Console.ReadLine()(0))

            If userAnswer = Answers(i) Then
                Console.WriteLine("Tama!")
                score += 1
            Else
                Console.WriteLine("Mali! Ang tamang sagot ay ang letrang: " & answers(i))
            End If

            Console.WriteLine()
        Next

        Console.WriteLine("Quiz Over!")
        Console.WriteLine("Your final score is: " & score & " out of " & Questions.Length)
        Console.ReadLine()
    End Sub
End Module
