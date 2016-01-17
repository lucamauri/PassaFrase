Imports System.Text
Imports System.Security.Cryptography

Public Class PassaFraseCore
    Dim Handler As New TextHandler
    Const GuessesPerSecondMassive = 100 * 10 ^ 12
    Const GuessesPerSecondOffline = 350 * 10 ^ 9
    Const GuessesPerSecondOnline = 10 ^ 3

    Public Const SecondsToYears = 60 / 60 / 24 / 365.25
    Public Const SecondsToDays = 60 / 60 / 24

    Public Enum WordCase As Integer
        Lowercase = 0
        Uppercase = 1
        CamelCase = 2
    End Enum

    Private DizionarioContent As List(Of String)

    Public ReadOnly Property Dizionario() As List(Of String)
        Get
            Return DizionarioContent
        End Get
    End Property

    Public ReadOnly Property CurrentPassPhrase As String
    Public ReadOnly Property CurrentBitsOfEntropy As Single
    Public ReadOnly Property CurrentCombinationNumber As Single
    Public ReadOnly Property NumberOfSymbols As Integer
    Public ReadOnly Property CurrentLenght As Integer
    Public ReadOnly Property CurrentMD5Hash As String
    'Public ReadOnly Property EstimatedTimeToGuessMassive As TimeSpan
    'Public ReadOnly Property EstimatedTimeToGuessOffline As TimeSpan
    'Public ReadOnly Property EstimatedTimeToGuessOnline As TimeSpan

    Public ReadOnly Property EstimatedTimeToGuessMassive As Single
    Public ReadOnly Property EstimatedTimeToGuessOffline As Single
    Public ReadOnly Property EstimatedTimeToGuessOnline As Single

    Sub New()
        'DizionarioContent = My.Resources.Dizionario.Split(Environment.NewLine).ToList
        DizionarioContent = My.Resources.DizionarioComune.Split(Environment.NewLine).ToList
    End Sub
    Function GetRandomWord(ResultCase As WordCase) As String
        Dim RNG As New DerivativeRNG
        'Dim Rnd As New Random
        Dim Index As Integer

        'Index = Rnd.Next(0, DizionarioContent.Count - 1)
        Index = RNG.Next(0, DizionarioContent.Count - 1)

        Select Case ResultCase
            Case WordCase.Uppercase
                Return DizionarioContent(Index).Trim.ToUpper
            Case WordCase.CamelCase
                Return FirstCapital(DizionarioContent(Index).Trim)
            Case Else
                Return DizionarioContent(Index).Trim
        End Select
    End Function
    Function GetRandomNumer(Digits As Integer) As String
        Dim Rnd As New Random
        Dim Number As Integer
        Dim MaxString As String = ""

        Number = Rnd.Next(0, Convert.ToInt16(MaxString.PadRight(Digits, "9")))
        Return Number.ToString
    End Function
    Function GeneratepassPhrase(WordsNumber As Integer, WordsCase As WordCase) As String
        Try
            Dim PassPhraseBuilder As New StringBuilder
            _CurrentLenght = WordsNumber
            _NumberOfSymbols = DizionarioContent.Count * 3

            For Index As Integer = 1 To WordsNumber
                PassPhraseBuilder.Append(GetRandomWord(WordsCase))
            Next

            _CurrentPassPhrase = PassPhraseBuilder.ToString
            _CurrentBitsOfEntropy = Math.Log(_NumberOfSymbols, 2) * WordsNumber
            _CurrentCombinationNumber = _NumberOfSymbols ^ WordsNumber
            _currentmd5hash = ComputeMD5Hash(_CurrentPassPhrase)
            '_EstimatedTimeToGuessMassive = New TimeSpan(_CurrentCombinationNumber / GuessesPerSecondMassive * 10 ^ 7)
            '_EstimatedTimeToGuessOffline = New TimeSpan(_CurrentCombinationNumber / GuessesPerSecondOffline * 10 ^ 7)

            'If (_CurrentCombinationNumber / GuessesPerSecondOnline * 10 ^ 7) > Int64.MaxValue Then
            '    _EstimatedTimeToGuessOnline = New TimeSpan(Int64.MaxValue)
            'Else
            '    _EstimatedTimeToGuessOnline = New TimeSpan(_CurrentCombinationNumber / GuessesPerSecondOnline * 10 ^ 7)
            'End If
            _EstimatedTimeToGuessMassive = _CurrentCombinationNumber / GuessesPerSecondMassive
            _EstimatedTimeToGuessOffline = _CurrentCombinationNumber / GuessesPerSecondOffline
            _EstimatedTimeToGuessOnline = _CurrentCombinationNumber / GuessesPerSecondOnline

            Return "OK"
        Catch ex As Exception
            Return ex.ToString
        End Try
    End Function
    Function FirstCapital(Word As String) As String
        Dim Array As Char()

        If String.IsNullOrEmpty(Word) Then
            Return Word
        End If

        Array = Word.ToCharArray
        Array(0) = Char.ToUpper(Array(0))
        Return New String(Array)
    End Function
    Function ComputeMD5Hash(Input As String) As String
        Dim MD5Hash As MD5
        Dim Data As Byte()
        Dim sBuilder As StringBuilder

        MD5Hash = MD5.Create
        Data = MD5Hash.ComputeHash(Encoding.UTF8.GetBytes(Input))

        sBuilder = New StringBuilder()
        For Index As Integer = 0 To Data.Length - 1
            sBuilder.Append(Data(Index).ToString("x2"))
        Next

        Return sBuilder.ToString()
    End Function
End Class