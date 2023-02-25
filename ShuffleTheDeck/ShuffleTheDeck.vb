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
    Dim displayHand As String

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
                    PickACard()
            End Select
        Loop
    End Sub

    Function PickACard() As String
        Dim cardDrawn As String
        Dim randomNumber As New Random()
        Dim randomFace As New Integer
        Dim randomSuit As New Integer

        randomFace = CInt(randomNumber.Next(13))
        randomSuit = CInt(randomNumber.Next(4))

        If randomFace = 0 Then
            cardDrawn = "2"
        ElseIf randomFace = 1 Then
            cardDrawn = "3"
        ElseIf randomFace = 2 Then
            cardDrawn = "4"
        ElseIf randomFace = 3 Then
            cardDrawn = "5"
        ElseIf randomFace = 4 Then
            cardDrawn = "6"
        ElseIf randomFace = 5 Then
            cardDrawn = "7"
        ElseIf randomFace = 6 Then
            cardDrawn = "8"
        ElseIf randomFace = 7 Then
            cardDrawn = "9"
        ElseIf randomFace = 8 Then
            cardDrawn = "10"
        ElseIf randomFace = 9 Then
            cardDrawn = "J"
        ElseIf randomFace = 10 Then
            cardDrawn = "Q"
        ElseIf randomFace = 11 Then
            cardDrawn = "K"
        Else
            cardDrawn = "A"
        End If

        If randomSuit = 0 Then
            cardDrawn &= Chr(3) 'Hearts Symbol
        ElseIf randomSuit = 1 Then
            cardDrawn &= Chr(4) 'Diamonds Symbol
        ElseIf randomSuit = 2 Then
            cardDrawn &= Chr(5) 'Clubs Symbol
        Else
            cardDrawn &= Chr(6) 'Spades Symbol
        End If

        Return cardDrawn
    End Function
End Module
