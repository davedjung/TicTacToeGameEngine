Imports System.IO

Public Class GUI

    Public keyLength As Integer
    Public stat() As Integer
    Public keyPath As String
    Public vectorPath As String
    Public vectorOutputPath As String
    Public basicAI As Boolean
    Public AIFirst As Boolean
    Public keys(,) As Integer
    Public advancedAI As Boolean
    Public vectorMode As Boolean
    Dim totalKeys As Integer
    Dim totalVectors As Integer

    Private Sub GUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        initialize(True)
        importKeys()

    End Sub

    Public Sub initialize(ByVal hardReset As Boolean)

        'Initialize variables
        If hardReset = True Then
            keyLength = 18
            Dim dummyStat(keyLength - 1) As Integer
            stat = dummyStat
            keyPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\Ultimate_Keys.txt"
            vectorPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\vector.txt"
            vectorOutputPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\Ultimate_Vector.txt"
            basicAI = True
            AIFirst = True
            advancedAI = True
            vectorMode = False
        End If
        For i As Integer = 0 To stat.Length - 1
            stat(i) = 0
        Next

        'Initialize GUI.vb
        pbx0.Enabled = False
        pbx0.Image = My.Resources.Empty_Board
        pbx0.SizeMode = PictureBoxSizeMode.Zoom
        pbx0.Show()
        pbx1.Enabled = False
        pbx1.Image = My.Resources.Empty_Board
        pbx1.SizeMode = PictureBoxSizeMode.Zoom
        pbx1.Show()
        pbx2.Enabled = False
        pbx2.Image = My.Resources.Empty_Board
        pbx2.SizeMode = PictureBoxSizeMode.Zoom
        pbx2.Show()
        pbx3.Enabled = False
        pbx3.Image = My.Resources.Empty_Board
        pbx3.SizeMode = PictureBoxSizeMode.Zoom
        pbx3.Show()
        pbx4.Enabled = False
        pbx4.Image = My.Resources.Empty_Board
        pbx4.SizeMode = PictureBoxSizeMode.Zoom
        pbx4.Show()
        pbx5.Enabled = False
        pbx5.Image = My.Resources.Empty_Board
        pbx5.SizeMode = PictureBoxSizeMode.Zoom
        pbx5.Show()
        pbx6.Enabled = False
        pbx6.Image = My.Resources.Empty_Board
        pbx6.SizeMode = PictureBoxSizeMode.Zoom
        pbx6.Show()
        pbx7.Enabled = False
        pbx7.Image = My.Resources.Empty_Board
        pbx7.SizeMode = PictureBoxSizeMode.Zoom
        pbx7.Show()
        pbx8.Enabled = False
        pbx8.Image = My.Resources.Empty_Board
        pbx8.SizeMode = PictureBoxSizeMode.Zoom
        pbx8.Show()
        pbxV0.Enabled = True
        pbxV0.Image = My.Resources.Line_Vertical
        pbxV0.SizeMode = PictureBoxSizeMode.StretchImage
        pbxV0.Show()
        pbxV1.Enabled = True
        pbxV1.Image = My.Resources.Line_Vertical
        pbxV1.SizeMode = PictureBoxSizeMode.StretchImage
        pbxV1.Show()
        pbxH0.Enabled = True
        pbxH0.Image = My.Resources.Line_Horizontal
        pbxH0.SizeMode = PictureBoxSizeMode.StretchImage
        pbxH0.Show()
        pbxH1.Enabled = True
        pbxH1.Image = My.Resources.Line_Horizontal
        pbxH1.SizeMode = PictureBoxSizeMode.StretchImage
        pbxH1.Show()
        btnStart.Text = "Start"

        'Initialize Conf.vb
        If hardReset = True Then
            Conf.rdbBasicOn.Enabled = True
            Conf.rdbBasicOn.Checked = True
            Conf.rdbBasicOff.Enabled = True
            Conf.rdbBasicOff.Checked = False
            Conf.rdbKeyOn.Enabled = True
            Conf.rdbKeyOn.Checked = True
            Conf.rdbKeyOff.Enabled = True
            Conf.rdbKeyOff.Checked = False
            Conf.rdb9Inputs.Enabled = False
            Conf.rdb9Inputs.Checked = False
            Conf.rdb18Inputs.Enabled = False
            Conf.rdb18Inputs.Checked = True
            Conf.rdbAIX.Enabled = True
            Conf.rdbAIX.Checked = True
            Conf.rdbAIO.Enabled = True
            Conf.rdbAIO.Checked = False
            Conf.rdbVectorOn.Enabled = True
            Conf.rdbVectorOn.Checked = False
            Conf.rdbVectorOff.Enabled = True
            Conf.rdbVectorOff.Checked = True
            Conf.txtKeyPath.Text = keyPath
            Conf.txtVectorPath.Text = vectorPath
            Conf.txtVectorPath.Enabled = False
            Conf.txtVectorOutputPath.Text = vectorOutputPath
            Conf.txtVectorOutputPath.Enabled = False
        End If

    End Sub

    Private Sub btnOptions_Click(sender As Object, e As EventArgs) Handles btnOptions.Click

        Conf.Show()

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        initialize(True)

    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click

        If btnStart.Text = "Restart" Then
            initialize(False)
        End If

        btnStart.Text = "Restart"

        If vectorMode = False Then
            If AIFirst = True Then
                enableAllPbx()
                AIMove()
            Else
                enableAllPbx()
            End If
        Else
            importKeys()
            disableAllPbx()
            importVectors()
        End If

    End Sub

    Private Sub importVectors()
        Dim sr As New StreamReader(vectorPath)
        Dim sw As New StreamWriter(vectorOutputPath)
        totalVectors = 0

        Do While sr.EndOfStream = False
            sr.ReadLine()
            totalVectors += 1
        Loop

        Dim currentVector(17) As Integer
        Dim response(8) As Integer

        Dim tempString As String
        tempString = ""
        sr = New StreamReader(vectorPath)
        For i As Integer = 0 To totalVectors - 1
            tempString = ""
            tempString = sr.ReadLine()
            For j As Integer = 0 To 17
                currentVector(j) = tempString.Substring(j, 1)
            Next
            response = searchKey(currentVector)
            Dim matchFound As Boolean
            matchFound = False
            For l As Integer = 0 To 8
                If response(l) <> 0 Then
                    matchFound = True
                End If
            Next
            If matchFound = True Then
                tempString = tempString & " "
                For k As Integer = 0 To 8
                    tempString = tempString & response(k)
                Next
                sw.WriteLine(tempString)
            End If

        Next
    End Sub

    Private Function searchKey(input As Integer()) As Integer()

        Dim options(8) As Integer
        Dim identical As Boolean
        Dim matchFound As Boolean

        matchFound = False
        identical = True


        For i As Integer = 0 To totalKeys - 1
            For j As Integer = 0 To 17
                If input(j) <> keys(i, j) Then
                    identical = False
                End If
            Next
            If identical = True Then
                matchFound = True
                For k As Integer = 0 To 8
                    If keys(i, k + 18) = 1 Then options(k) = 1
                Next
            End If
            identical = True
        Next

        If matchFound = False Then
            Dim answer As Integer
            Dim is2P = check2P(input)
            If is2P = True Then
                For i As Integer = 0 To 8
                    stat(i + 9) = input(i)
                    stat(i) = input(i + 9)
                Next
            Else
                For i As Integer = 0 To 17
                    stat(i) = input(i)
                Next
            End If
            answer = basicAIMove()
            If answer <> -1 Then options(answer) = 1
        End If

        Return options

    End Function

    Private Function check2P(input As Integer()) As Boolean
        Dim count1P, count2P As Integer
        For i As Integer = 0 To 8
            If input(i) = 1 Then count1P += 1
            If input(i + 9) = 1 Then count2P += 1
        Next
        If count1P >= count2P Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub enableAllPbx()
        pbx0.Enabled = True
        pbx1.Enabled = True
        pbx2.Enabled = True
        pbx3.Enabled = True
        pbx4.Enabled = True
        pbx5.Enabled = True
        pbx6.Enabled = True
        pbx7.Enabled = True
        pbx8.Enabled = True
    End Sub

    Private Sub disableAllPbx()
        pbx0.Enabled = False
        pbx1.Enabled = False
        pbx2.Enabled = False
        pbx3.Enabled = False
        pbx4.Enabled = False
        pbx5.Enabled = False
        pbx6.Enabled = False
        pbx7.Enabled = False
        pbx8.Enabled = False
    End Sub

    Private Sub importKeys()
        Dim sr As New StreamReader(keyPath)

        totalKeys = 0
        Do While sr.EndOfStream = False
            sr.ReadLine()
            totalKeys += 1
        Loop

        If keyLength = 18 Then
            Dim dummyKeys(totalKeys - 1, 26) As Integer
            keys = dummyKeys
        Else
            Dim dummyKeys(totalKeys - 1, 17) As Integer
            keys = dummyKeys
        End If

        Dim tempString As String
        tempString = ""

        sr = New StreamReader(keyPath)
        For i As Integer = 0 To totalKeys - 1
            tempString = ""
            tempString = sr.ReadLine()
            For j As Integer = 0 To keyLength + 8
                keys(i, j) = tempString.Substring(j, 1)
            Next
        Next
    End Sub

    Private Sub AIMove()
        Dim options(9) As Integer
        Dim index As Integer
        Dim response As Integer

        options(0) = -1
        index = 0
        response = -1

        If advancedAI = True Then
            response = advancedAIMove()
        End If

        If basicAI = True Then
            If response = -1 Then response = basicAIMove()
        End If


        If response <> -1 Then
            If keyLength = 18 Then
                If stat(response) = 1 Or stat(response + 9) = 1 Then
                    response = -1
                End If
            Else
                If stat(response) <> 0 Then
                    response = -1
                End If
            End If
        End If

        If response = -1 Then
            For i As Integer = 0 To 8
                If keyLength = 9 Then
                    If stat(i) = 0 Then
                        options(index) = i
                        index += 1
                    End If
                Else
                    If stat(i) = 0 And stat(i + 9) = 0 Then
                        options(index) = i
                        index += 1
                    End If
                End If
            Next
            Dim rand As New Random
            index = rand.Next(index - 1)
            response = options(index)
        End If

        If AIFirst = True Then
            Select Case response
                Case 0
                    pbx0.Image = My.Resources.X_Board
                    pbx0.Enabled = False
                Case 1
                    pbx1.Image = My.Resources.X_Board
                    pbx1.Enabled = False

                Case 2
                    pbx2.Image = My.Resources.X_Board
                    pbx2.Enabled = False

                Case 3
                    pbx3.Image = My.Resources.X_Board
                    pbx3.Enabled = False

                Case 4
                    pbx4.Image = My.Resources.X_Board
                    pbx4.Enabled = False

                Case 5
                    pbx5.Image = My.Resources.X_Board
                    pbx5.Enabled = False

                Case 6
                    pbx6.Image = My.Resources.X_Board
                    pbx6.Enabled = False

                Case 7
                    pbx7.Image = My.Resources.X_Board
                    pbx7.Enabled = False

                Case 8
                    pbx8.Image = My.Resources.X_Board
                    pbx8.Enabled = False

            End Select
        Else
            Select Case response
                Case 0
                    pbx0.Image = My.Resources.O_Board
                    pbx0.Enabled = False

                Case 1
                    pbx1.Image = My.Resources.O_Board
                    pbx1.Enabled = False

                Case 2
                    pbx2.Image = My.Resources.O_Board
                    pbx2.Enabled = False

                Case 3
                    pbx3.Image = My.Resources.O_Board
                    pbx3.Enabled = False

                Case 4
                    pbx4.Image = My.Resources.O_Board
                    pbx4.Enabled = False

                Case 5
                    pbx5.Image = My.Resources.O_Board
                    pbx5.Enabled = False

                Case 6
                    pbx6.Image = My.Resources.O_Board
                    pbx6.Enabled = False

                Case 7
                    pbx7.Image = My.Resources.O_Board
                    pbx7.Enabled = False

                Case 8
                    pbx8.Image = My.Resources.O_Board
                    pbx8.Enabled = False
            End Select
        End If
        stat(response) = 1
        If isEnd() = True Then disableAllPbx()
    End Sub

    Private Function advancedAIMove() As Integer

        Dim answer As Integer
        Dim options(8, 8) As Integer
        Dim identical As Boolean
        Dim index As Integer

        answer = -1
        identical = True
        index = 0

        For i As Integer = 0 To totalKeys - 1
            For j As Integer = 0 To keyLength - 1
                If stat(j) <> keys(i, j) Then
                    identical = False
                End If
            Next
            If identical = True Then
                For k As Integer = 0 To 8
                    options(index, k) = keys(i, k + 18)
                Next
                index += 1
            End If
            identical = True
        Next

        If index <> 0 Then
            Dim chosen As Integer
            Dim rand As New Random
            chosen = rand.Next(index - 1)
            For l As Integer = 0 To 8
                If options(chosen, l) = 1 Then
                    answer = l
                End If
            Next
        End If

        Return answer

    End Function

    Private Function basicAIMove() As Integer

        Dim answer As Integer
        answer = -1

        If keyLength = 18 Then
            If stat(9) = 1 Then
                If stat(10) = 1 And stat(2) = 0 Then
                    answer = 2
                ElseIf stat(11) = 1 And stat(1) = 0 Then
                    answer = 1
                ElseIf stat(12) = 1 And stat(6) = 0 Then
                    answer = 6
                ElseIf stat(13) = 1 And stat(8) = 0 Then
                    answer = 8
                ElseIf stat(15) = 1 And stat(3) = 0 Then
                    answer = 3
                ElseIf stat(17) = 1 And stat(4) = 0 Then
                    answer = 4
                End If
            End If
            If stat(10) = 1 Then
                If stat(11) = 1 And stat(0) = 0 Then
                    answer = 0
                ElseIf stat(13) = 1 And stat(7) = 0 Then
                    answer = 7
                ElseIf stat(16) = 1 And stat(4) = 0 Then
                    answer = 4
                End If
            End If
            If stat(11) = 1 Then
                If stat(13) = 1 And stat(6) = 0 Then
                    answer = 6
                ElseIf stat(14) = 1 And stat(8) = 0 Then
                    answer = 8
                ElseIf stat(15) = 1 And stat(4) = 0 Then
                    answer = 4
                ElseIf stat(17) = 1 And stat(5) = 0 Then
                    answer = 5
                End If
            End If
            If stat(12) = 1 Then
                If stat(13) = 1 And stat(5) = 0 Then
                    answer = 5
                ElseIf stat(14) = 1 And stat(4) = 0 Then
                    answer = 4
                ElseIf stat(15) = 1 And stat(0) = 0 Then
                    answer = 0
                End If
            End If
            If stat(13) = 1 Then
                If stat(14) = 1 And stat(3) = 0 Then
                    answer = 3
                ElseIf stat(15) = 1 And stat(2) = 0 Then
                    answer = 2
                ElseIf stat(16) = 1 And stat(1) = 0 Then
                    answer = 1
                ElseIf stat(17) = 1 And stat(0) = 0 Then
                    answer = 0
                End If
            End If
            If stat(14) = 1 Then
                If stat(17) = 1 And stat(2) = 0 Then
                    answer = 2
                End If
            End If
            If stat(15) = 1 Then
                If stat(16) = 1 And stat(8) = 0 Then
                    answer = 8
                ElseIf stat(17) = 1 And stat(7) = 0 Then
                    answer = 7
                End If
            End If
            If stat(16) = 1 Then
                If stat(17) = 1 And stat(6) = 0 Then
                    answer = 6
                End If
            End If
            If stat(0) = 1 Then
                If stat(1) = 1 And stat(11) = 0 Then
                    answer = 2
                ElseIf stat(2) = 1 And stat(10) = 0 Then
                    answer = 1
                ElseIf stat(3) = 1 And stat(15) = 0 Then
                    answer = 6
                ElseIf stat(4) = 1 And stat(17) = 0 Then
                    answer = 8
                ElseIf stat(6) = 1 And stat(12) = 0 Then
                    answer = 3
                ElseIf stat(8) = 1 And stat(13) = 0 Then
                    answer = 4
                End If
            End If
            If stat(1) = 1 Then
                If stat(2) = 1 And stat(9) = 0 Then
                    answer = 0
                ElseIf stat(4) = 1 And stat(16) = 0 Then
                    answer = 7
                ElseIf stat(7) = 1 And stat(13) = 0 Then
                    answer = 4
                End If
            End If
            If stat(2) = 1 Then
                If stat(4) = 1 And stat(15) = 0 Then
                    answer = 6
                ElseIf stat(5) = 1 And stat(17) = 0 Then
                    answer = 8
                ElseIf stat(6) = 1 And stat(13) = 0 Then
                    answer = 4
                ElseIf stat(8) = 1 And stat(14) = 0 Then
                    answer = 5
                End If
            End If
            If stat(3) = 1 Then
                If stat(4) = 1 And stat(14) = 0 Then
                    answer = 5
                ElseIf stat(5) = 1 And stat(13) = 0 Then
                    answer = 4
                ElseIf stat(6) = 1 And stat(9) = 0 Then
                    answer = 0
                End If
            End If
            If stat(4) = 1 Then
                If stat(5) = 1 And stat(12) = 0 Then
                    answer = 3
                ElseIf stat(6) = 1 And stat(11) = 0 Then
                    answer = 2
                ElseIf stat(7) = 1 And stat(10) = 0 Then
                    answer = 1
                ElseIf stat(8) = 1 And stat(9) = 0 Then
                    answer = 0
                End If
            End If
            If stat(5) = 1 Then
                If stat(8) = 1 And stat(11) = 0 Then
                    answer = 2
                End If
            End If
            If stat(6) = 1 Then
                If stat(7) = 1 And stat(17) = 0 Then
                    answer = 8
                ElseIf stat(8) = 1 And stat(16) = 0 Then
                    answer = 7
                End If
            End If
            If stat(7) = 1 Then
                If stat(8) = 1 And stat(15) = 0 Then
                    answer = 6
                End If
            End If
        Else
            '/////////////Implementation/////////////
            If stat(0) = -1 Then
                If stat(1) = -1 And stat(2) = 0 Then
                    answer = 2
                ElseIf stat(2) = -1 And stat(1) = 0 Then
                    answer = 1

                End If
            End If
        End If

            Return answer

    End Function

    Private Function isEnd() As Boolean
        Dim finished As Boolean
        Dim winner As Integer
        Dim isFull As Boolean
        finished = False
        winner = 0
        isFull = True

        'check Horizontal
        If keyLength = 18 Then
            If stat(0) = 1 And stat(1) = 1 And stat(2) = 1 Then
                winner = 1
            ElseIf stat(3) = 1 And stat(4) = 1 And stat(5) = 1 Then
                winner = 1
            ElseIf stat(6) = 1 And stat(7) = 1 And stat(8) = 1 Then
                winner = 1
            End If
            If stat(9) = 1 And stat(10) = 1 And stat(11) = 1 Then
                winner = -1
            ElseIf stat(12) = 1 And stat(13) = 1 And stat(14) = 1 Then
                winner = -1
            ElseIf stat(15) = 1 And stat(16) = 1 And stat(17) = 1 Then
                winner = -1
            End If
        Else
            If stat(0) = 1 And stat(1) = 1 And stat(2) = 1 Then
                winner = 1
            ElseIf stat(3) = 1 And stat(4) = 1 And stat(5) = 1 Then
                winner = 1
            ElseIf stat(6) = 1 And stat(7) = 1 And stat(8) = 1 Then
                winner = 1
            End If
            If stat(0) = -1 And stat(1) = -1 And stat(2) = -1 Then
                winner = -1
            ElseIf stat(3) = -1 And stat(4) = -1 And stat(5) = -1 Then
                winner = -1
            ElseIf stat(6) = -1 And stat(7) = -1 And stat(8) = -1 Then
                winner = -1
            End If
        End If
        'check Vertical
        If keyLength = 18 Then
            If stat(0) = 1 And stat(3) = 1 And stat(6) = 1 Then
                winner = 1
            ElseIf stat(1) = 1 And stat(4) = 1 And stat(7) = 1 Then
                winner = 1
            ElseIf stat(2) = 1 And stat(5) = 1 And stat(8) = 1 Then
                winner = 1
            End If
            If stat(9) = 1 And stat(12) = 1 And stat(15) = 1 Then
                winner = -1
            ElseIf stat(10) = 1 And stat(13) = 1 And stat(16) = 1 Then
                winner = -1
            ElseIf stat(11) = 1 And stat(14) = 1 And stat(17) = 1 Then
                winner = -1
            End If
        Else
            If stat(0) = 1 And stat(3) = 1 And stat(6) = 1 Then
                winner = 1
            ElseIf stat(1) = 1 And stat(4) = 1 And stat(7) = 1 Then
                winner = 1
            ElseIf stat(2) = 1 And stat(5) = 1 And stat(8) = 1 Then
                winner = 1
            End If
            If stat(0) = -1 And stat(3) = -1 And stat(6) = -1 Then
                winner = -1
            ElseIf stat(1) = -1 And stat(4) = -1 And stat(7) = -1 Then
                winner = -1
            ElseIf stat(2) = -1 And stat(5) = -1 And stat(8) = -1 Then
                winner = -1
            End If
        End If
        'check Diagonal
        If keyLength = 18 Then
            If stat(0) = 1 And stat(4) = 1 And stat(8) = 1 Then
                winner = 1
            ElseIf stat(2) = 1 And stat(4) = 1 And stat(6) = 1 Then
                winner = 1
            End If
            If stat(9) = 1 And stat(13) = 1 And stat(17) = 1 Then
                winner = -1
            ElseIf stat(11) = 1 And stat(13) = 1 And stat(15) = 1 Then
                winner = -1
            End If
        Else
            If stat(0) = 1 And stat(4) = 1 And stat(8) = 1 Then
                winner = 1
            ElseIf stat(2) = 1 And stat(4) = 1 And stat(6) = 1 Then
                winner = 1
            End If
            If stat(0) = -1 And stat(4) = -1 And stat(8) = -1 Then
                winner = -1
            ElseIf stat(2) = -1 And stat(4) = -1 And stat(6) = -1 Then
                winner = -1
            End If
        End If

        If winner <> 0 Then
            finished = True
        End If

        'check Full
        If keyLength = 18 Then
            For i As Integer = 0 To 8
                If stat(i) = 0 And stat(i + 9) = 0 Then
                    isFull = False
                End If
            Next
        Else
            For i As Integer = 0 To 8
                If stat(i) = 0 Then
                    isFull = False
                End If
            Next
        End If

        If finished = False And isFull = True Then
            finished = True
            winner = 0
        End If

        If finished = True Then

            If winner = 1 Then
                MessageBox.Show("Computer has won")
            ElseIf winner = -1 Then
                MessageBox.Show("Player has won")
            ElseIf winner = 0 Then
                MessageBox.Show("The game has tied")
            End If

            disableAllPbx()


        End If


        Return finished

    End Function

    Private Sub pbx0_Click(sender As Object, e As EventArgs) Handles pbx0.Click
        If AIFirst = True Then
            pbx0.Image = My.Resources.O_Board
        Else
            pbx0.Image = My.Resources.X_Board
        End If
        Dim index As Integer = 0
        If keyLength = 18 Then
            stat(index + 9) = 1
        Else
            If AIFirst = True Then
                stat(index) = -1
            Else
                stat(index) = 1
            End If
        End If
        pbx0.Enabled = False
        If isEnd() = False Then AIMove()
    End Sub

    Private Sub pbx1_Click(sender As Object, e As EventArgs) Handles pbx1.Click
        If AIFirst = True Then
            pbx1.Image = My.Resources.O_Board
        Else
            pbx1.Image = My.Resources.X_Board
        End If
        Dim index As Integer = 1
        If keyLength = 18 Then
            stat(index + 9) = 1
        Else
            If AIFirst = True Then
                stat(index) = -1
            Else
                stat(index) = 1
            End If
        End If
        pbx1.Enabled = False
        If isEnd() = False Then AIMove()
    End Sub

    Private Sub pbx2_Click(sender As Object, e As EventArgs) Handles pbx2.Click
        If AIFirst = True Then
            pbx2.Image = My.Resources.O_Board
        Else
            pbx2.Image = My.Resources.X_Board
        End If
        Dim index As Integer = 2
        If keyLength = 18 Then
            stat(index + 9) = 1
        Else
            If AIFirst = True Then
                stat(index) = -1
            Else
                stat(index) = 1
            End If
        End If
        pbx2.Enabled = False

        If isEnd() = False Then AIMove()
    End Sub

    Private Sub pbx3_Click(sender As Object, e As EventArgs) Handles pbx3.Click
        If AIFirst = True Then
            pbx3.Image = My.Resources.O_Board
        Else
            pbx3.Image = My.Resources.X_Board
        End If
        Dim index As Integer = 3
        If keyLength = 18 Then
            stat(index + 9) = 1
        Else
            If AIFirst = True Then
                stat(index) = -1
            Else
                stat(index) = 1
            End If
        End If
        pbx3.Enabled = False

        If isEnd() = False Then AIMove()
    End Sub

    Private Sub pbx4_Click(sender As Object, e As EventArgs) Handles pbx4.Click
        If AIFirst = True Then
            pbx4.Image = My.Resources.O_Board
        Else
            pbx4.Image = My.Resources.X_Board
        End If
        Dim index As Integer = 4
        If keyLength = 18 Then
            stat(index + 9) = 1
        Else
            If AIFirst = True Then
                stat(index) = -1
            Else
                stat(index) = 1
            End If
        End If
        pbx4.Enabled = False

        If isEnd() = False Then AIMove()
    End Sub

    Private Sub pbx5_Click(sender As Object, e As EventArgs) Handles pbx5.Click
        If AIFirst = True Then
            pbx5.Image = My.Resources.O_Board
        Else
            pbx5.Image = My.Resources.X_Board
        End If
        Dim index As Integer = 5
        If keyLength = 18 Then
            stat(index + 9) = 1
        Else
            If AIFirst = True Then
                stat(index) = -1
            Else
                stat(index) = 1
            End If
        End If
        pbx5.Enabled = False

        If isEnd() = False Then AIMove()
    End Sub

    Private Sub pbx6_Click(sender As Object, e As EventArgs) Handles pbx6.Click
        If AIFirst = True Then
            pbx6.Image = My.Resources.O_Board
        Else
            pbx6.Image = My.Resources.X_Board
        End If
        Dim index As Integer = 6
        If keyLength = 18 Then
            stat(index + 9) = 1
        Else
            If AIFirst = True Then
                stat(index) = -1
            Else
                stat(index) = 1
            End If
        End If
        pbx6.Enabled = False

        If isEnd() = False Then AIMove()
    End Sub

    Private Sub pbx7_Click(sender As Object, e As EventArgs) Handles pbx7.Click
        If AIFirst = True Then
            pbx7.Image = My.Resources.O_Board
        Else
            pbx7.Image = My.Resources.X_Board
        End If
        Dim index As Integer = 7
        If keyLength = 18 Then
            stat(index + 9) = 1
        Else
            If AIFirst = True Then
                stat(index) = -1
            Else
                stat(index) = 1
            End If
        End If
        pbx7.Enabled = False

        If isEnd() = False Then AIMove()
    End Sub

    Private Sub pbx8_Click(sender As Object, e As EventArgs) Handles pbx8.Click
        If AIFirst = True Then
            pbx8.Image = My.Resources.O_Board
        Else
            pbx8.Image = My.Resources.X_Board
        End If
        Dim index As Integer = 8
        If keyLength = 18 Then
            stat(index + 9) = 1
        Else
            If AIFirst = True Then
                stat(index) = -1
            Else
                stat(index) = 1
            End If
        End If
        pbx8.Enabled = False

        If isEnd() = False Then AIMove()
    End Sub

End Class