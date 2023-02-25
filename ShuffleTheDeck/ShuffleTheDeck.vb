'Christopher Pickens
'RCET0265
'Spring 2023
'Shuffle The Deck
'https://github.com/Pickchr2/ShuffleTheDeck.git

Option Strict On
Option Explicit On
Option Compare Text

Imports System
Module ShuffleTheDeck
    Dim deckTracker(13, 4) As Boolean
    Dim cardsLeft As Integer

    Sub Main(args As String())
        Dim userInput As String
        Dim quitFlag As Boolean = False

        Do Until quitFlag
            Console.WriteLine("Press " & Chr(34) & "S" & Chr(34) & " to shuffle the deck, Press " & Chr(34) & "Q" & Chr(34) & " to quit, Press any other key to draw a card.")
            userInput = Console.ReadLine()

            Select Case userInput
                Case "S"

                Case "Q"
                    quitFlag = True
                Case Else

            End Select
        Loop
    End Sub
End Module
