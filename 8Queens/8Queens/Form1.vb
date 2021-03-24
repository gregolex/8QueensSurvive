Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Testing how to remove queens from the board
        'Label1.Text = ""
1:
        ' Initialize the random-number generator.
        Randomize()

        ' Generate random value between 0 and 7.
        Dim queenColPlacement As Integer = CInt(Int((8 * Rnd()) + 0))

        'Difining Integers
        Dim Col As Integer = 7
        Dim Row As Integer = 7
        Dim currentRow As Integer = 0

        'Defining Queens 2D Array As Integer
        Dim Queens(Row, Col) As Integer
        For compileRows As Integer = 0 To 7 Step 1
            For compileCols As Integer = 0 To 7 Step 1
                Queens(compileRows, compileCols) = 0
            Next
        Next

        'Row 0 Calculations
        'Intializing
        Dim variableRow As Integer
        Dim variableCol As Integer
        Dim leftSideVariable As Integer
        Dim rightSideVariable As Integer
        variableRow = currentRow
        variableCol = queenColPlacement
        leftSideVariable = queenColPlacement
        rightSideVariable = queenColPlacement

        'Filling in array for Left Horizontal, Left Diagonal
        If (queenColPlacement <> 0) Then
            For colIndex As Integer = 0 To queenColPlacement - 1 Step 1 'For (x=0; x < 8; x++)
                variableRow = variableRow + 1
                variableCol = variableCol - 1
                leftSideVariable = leftSideVariable - 1
                Queens(variableRow, variableCol) = 1
                Queens(currentRow, leftSideVariable) = 1
            Next
        End If

        'Filling in array straight down vertical
        For rowIndex As Integer = 1 To 7 Step 1
            Queens(rowIndex, queenColPlacement) = 1
        Next

        'Reinitialize
        variableRow = currentRow
        variableCol = queenColPlacement

        'Filling in array for Right Horizontal, Right Diagonal
        If (queenColPlacement <> 7) Then
            For colIndex As Integer = queenColPlacement + 1 To 7 Step 1 'For (x=0; x < 8; x++)
                variableRow = variableRow + 1
                variableCol = variableCol + 1
                rightSideVariable = rightSideVariable + 1
                Queens(variableRow, variableCol) = 1
                Queens(currentRow, rightSideVariable) = 1
            Next
        End If

        'Row 1 Calculations
        'Initializing Variables and Finding the second queen
        currentRow = 1
        queenColPlacement = CInt(Int((8 * Rnd()) + 0))
        While (Queens(currentRow, queenColPlacement) = 1)
            queenColPlacement = CInt(Int((8 * Rnd()) + 0))
        End While
        variableRow = currentRow
        variableCol = queenColPlacement
        leftSideVariable = queenColPlacement
        rightSideVariable = queenColPlacement

        'Filling in Left Horizontal
        If (queenColPlacement <> 0) Then
            For colIndex As Integer = 0 To queenColPlacement - 1 Step 1
                leftSideVariable = leftSideVariable - 1
                Queens(currentRow, leftSideVariable) = 1
            Next
        End If
        'Filling in Right Horizontal
        If (queenColPlacement <> 7) Then
            For colIndex As Integer = queenColPlacement + 1 To 7 Step 1
                rightSideVariable = rightSideVariable + 1
                Queens(currentRow, rightSideVariable) = 1
            Next
        End If
        'Filling in Left Diagonal
        If (queenColPlacement <> 0) Then
            For colIndex As Integer = 0 To queenColPlacement - 1 Step 1
                variableCol = variableCol - 1
                variableRow = variableRow + 1
                If (variableRow < 8) Then
                    Queens(variableRow, variableCol) = 1
                End If
            Next
        End If


        'Filling in Right Diagonal
        variableRow = currentRow
        variableCol = queenColPlacement
        If (queenColPlacement <> 7) Then
            For colIndex As Integer = queenColPlacement + 1 To 7 Step 1
                variableCol = variableCol + 1
                variableRow = variableRow + 1
                If (variableRow < 8) Then
                    Queens(variableRow, variableCol) = 1
                End If
            Next
        End If

        'Filling in Straight Down from the queenColPlacement
        For rowIndex As Integer = 2 To 7 Step 1
            Queens(rowIndex, queenColPlacement) = 1
        Next

        'Row 2 Calculations
        currentRow = 2
        queenColPlacement = CInt(Int((8 * Rnd()) + 0))
        While (Queens(currentRow, queenColPlacement) = 1)
            queenColPlacement = CInt(Int((8 * Rnd()) + 0))
        End While
        variableRow = currentRow
        variableCol = queenColPlacement
        leftSideVariable = queenColPlacement
        rightSideVariable = queenColPlacement

        'Filling in Left Horizontal
        If (queenColPlacement <> 0) Then
            For colIndex As Integer = 0 To queenColPlacement - 1 Step 1
                leftSideVariable = leftSideVariable - 1
                Queens(currentRow, leftSideVariable) = 1
            Next
        End If

        'Filling in Right Horizontal
        If (queenColPlacement <> 7) Then
            For colIndex As Integer = queenColPlacement + 1 To 7 Step 1
                rightSideVariable = rightSideVariable + 1
                Queens(currentRow, rightSideVariable) = 1
            Next
        End If

        'Filling in Left Diagonal
        If (queenColPlacement <> 0) Then
            For colIndex As Integer = 0 To queenColPlacement - 1 Step 1
                variableCol = variableCol - 1
                variableRow = variableRow + 1
                If (variableRow < 8) Then
                    Queens(variableRow, variableCol) = 1
                End If
            Next
        End If

        'Filling in Right Diagonal
        variableRow = currentRow
        variableCol = queenColPlacement
        If (queenColPlacement <> 7) Then
            For colIndex As Integer = queenColPlacement + 1 To 7 Step 1
                variableCol = variableCol + 1
                variableRow = variableRow + 1
                If (variableRow < 8) Then
                    Queens(variableRow, variableCol) = 1
                End If
            Next
        End If
        'Filling in Straight Down from the queenColPlacement
        For rowIndex As Integer = 3 To 7 Step 1
            Queens(rowIndex, queenColPlacement) = 1
        Next

        'Row 3 Calculations
        currentRow = 3
        queenColPlacement = CInt(Int((8 * Rnd()) + 0))
        While (Queens(currentRow, queenColPlacement) = 1)
            queenColPlacement = CInt(Int((8 * Rnd()) + 0))
        End While
        variableRow = currentRow
        variableCol = queenColPlacement
        leftSideVariable = queenColPlacement
        rightSideVariable = queenColPlacement

        'Filling in Left Horizontal
        If (queenColPlacement <> 0) Then
            For colIndex As Integer = 0 To queenColPlacement - 1 Step 1
                leftSideVariable = leftSideVariable - 1
                Queens(currentRow, leftSideVariable) = 1
            Next
        End If

        'Filling in Right Horizontal
        If (queenColPlacement <> 7) Then
            For colIndex As Integer = queenColPlacement + 1 To 7 Step 1
                rightSideVariable = rightSideVariable + 1
                Queens(currentRow, rightSideVariable) = 1
            Next
        End If

        'Filling in Left Diagonal
        If (queenColPlacement <> 0) Then
            For colIndex As Integer = 0 To queenColPlacement - 1 Step 1
                variableCol = variableCol - 1
                variableRow = variableRow + 1
                If (variableRow < 8) Then
                    Queens(variableRow, variableCol) = 1
                End If
            Next
        End If

        'Filling in Right Diagonal
        variableRow = currentRow
        variableCol = queenColPlacement
        If (queenColPlacement <> 7) Then
            For colIndex As Integer = queenColPlacement + 1 To 7 Step 1
                variableCol = variableCol + 1
                variableRow = variableRow + 1
                If (variableRow < 8) Then
                    Queens(variableRow, variableCol) = 1
                End If
            Next
        End If
        'Filling in Straight Down from the queenColPlacement
        For rowIndex As Integer = 4 To 7 Step 1
            Queens(rowIndex, queenColPlacement) = 1
        Next

        'Row 4 Calculations
        currentRow = 4
        queenColPlacement = CInt(Int((8 * Rnd()) + 0))
        If (Queens(4, 0) = 0 Or Queens(4, 1) = 0 Or Queens(4, 2) = 0 Or Queens(4, 3) = 0 Or Queens(4, 4) = 0 Or Queens(4, 5) = 0 Or Queens(4, 6) = 0 Or Queens(4, 7) = 0) Then
            While (Queens(currentRow, queenColPlacement) = 1)
                queenColPlacement = CInt(Int((8 * Rnd()) + 0))
            End While
        Else
            GoTo 1
        End If

        variableRow = currentRow
        variableCol = queenColPlacement
        leftSideVariable = queenColPlacement
        rightSideVariable = queenColPlacement

        'Filling in Left Horizontal
        If (queenColPlacement <> 0) Then
            For colIndex As Integer = 0 To queenColPlacement - 1 Step 1
                leftSideVariable = leftSideVariable - 1
                Queens(currentRow, leftSideVariable) = 1
            Next
        End If

        'Filling in Right Horizontal
        If (queenColPlacement <> 7) Then
            For colIndex As Integer = queenColPlacement + 1 To 7 Step 1
                rightSideVariable = rightSideVariable + 1
                Queens(currentRow, rightSideVariable) = 1
            Next
        End If

        'Filling in Left Diagonal
        If (queenColPlacement <> 0) Then
            For colIndex As Integer = 0 To queenColPlacement - 1 Step 1
                variableCol = variableCol - 1
                variableRow = variableRow + 1
                If (variableRow < 8) Then
                    Queens(variableRow, variableCol) = 1
                End If
            Next
        End If

        'Filling in Right Diagonal
        variableRow = currentRow
        variableCol = queenColPlacement
        If (queenColPlacement <> 7) Then
            For colIndex As Integer = queenColPlacement + 1 To 7 Step 1
                variableCol = variableCol + 1
                variableRow = variableRow + 1
                If (variableRow < 8) Then
                    Queens(variableRow, variableCol) = 1
                End If
            Next
        End If
        'Filling in Straight Down from the queenColPlacement
        For rowIndex As Integer = 5 To 7 Step 1
            Queens(rowIndex, queenColPlacement) = 1
        Next

        'Row 5 Calculations
        currentRow = 5
        queenColPlacement = CInt(Int((8 * Rnd()) + 0))
        If (Queens(5, 0) = 0 Or Queens(5, 1) = 0 Or Queens(5, 2) = 0 Or Queens(5, 3) = 0 Or Queens(5, 4) = 0 Or Queens(5, 5) = 0 Or Queens(5, 6) = 0 Or Queens(5, 7) = 0) Then
            While (Queens(currentRow, queenColPlacement) = 1)
                queenColPlacement = CInt(Int((8 * Rnd()) + 0))
            End While
        Else
            GoTo 1
        End If
        variableRow = currentRow
        variableCol = queenColPlacement
        leftSideVariable = queenColPlacement
        rightSideVariable = queenColPlacement

        'Filling in Left Horizontal
        If (queenColPlacement <> 0) Then
            For colIndex As Integer = 0 To queenColPlacement - 1 Step 1
                leftSideVariable = leftSideVariable - 1
                Queens(currentRow, leftSideVariable) = 1
            Next
        End If

        'Filling in Right Horizontal
        If (queenColPlacement <> 7) Then
            For colIndex As Integer = queenColPlacement + 1 To 7 Step 1
                rightSideVariable = rightSideVariable + 1
                Queens(currentRow, rightSideVariable) = 1
            Next
        End If

        'Filling in Left Diagonal
        If (queenColPlacement <> 0) Then
            For colIndex As Integer = 0 To queenColPlacement - 1 Step 1
                variableCol = variableCol - 1
                variableRow = variableRow + 1
                If (variableRow < 8) Then
                    Queens(variableRow, variableCol) = 1
                End If
            Next
        End If

        'Filling in Right Diagonal
        variableRow = currentRow
        variableCol = queenColPlacement
        If (queenColPlacement <> 7) Then
            For colIndex As Integer = queenColPlacement + 1 To 7 Step 1
                variableCol = variableCol + 1
                variableRow = variableRow + 1
                If (variableRow < 8) Then
                    Queens(variableRow, variableCol) = 1
                End If
            Next
        End If
        'Filling in Straight Down from the queenColPlacement
        For rowIndex As Integer = 6 To 7 Step 1
            Queens(rowIndex, queenColPlacement) = 1
        Next

        'Row 6 Calculations
        currentRow = 6
        queenColPlacement = CInt(Int((8 * Rnd()) + 0))
        If (Queens(6, 0) = 0 Or Queens(6, 1) = 0 Or Queens(6, 2) = 0 Or Queens(6, 3) = 0 Or Queens(6, 4) = 0 Or Queens(6, 5) = 0 Or Queens(6, 6) = 0 Or Queens(6, 7) = 0) Then
            While (Queens(currentRow, queenColPlacement) = 1)
                queenColPlacement = CInt(Int((8 * Rnd()) + 0))
            End While
        Else
            GoTo 1
        End If
        variableRow = currentRow
        variableCol = queenColPlacement
        leftSideVariable = queenColPlacement
        rightSideVariable = queenColPlacement

        'Filling in Left Horizontal
        If (queenColPlacement <> 0) Then
            For colIndex As Integer = 0 To queenColPlacement - 1 Step 1
                leftSideVariable = leftSideVariable - 1
                Queens(currentRow, leftSideVariable) = 1
            Next
        End If

        'Filling in Right Horizontal
        If (queenColPlacement <> 7) Then
            For colIndex As Integer = queenColPlacement + 1 To 7 Step 1
                rightSideVariable = rightSideVariable + 1
                Queens(currentRow, rightSideVariable) = 1
            Next
        End If

        'Filling in Left Diagonal
        If (queenColPlacement <> 0) Then
            For colIndex As Integer = 0 To queenColPlacement - 1 Step 1
                variableCol = variableCol - 1
                variableRow = variableRow + 1
                If (variableRow < 8) Then
                    Queens(variableRow, variableCol) = 1
                End If
            Next
        End If

        'Filling in Right Diagonal
        variableRow = currentRow
        variableCol = queenColPlacement
        If (queenColPlacement <> 7) Then
            For colIndex As Integer = queenColPlacement + 1 To 7 Step 1
                variableCol = variableCol + 1
                variableRow = variableRow + 1
                If (variableRow < 8) Then
                    Queens(variableRow, variableCol) = 1
                End If
            Next
        End If
        'Filling in Straight Down from the queenColPlacement
        For rowIndex As Integer = 7 To 7 Step 1
            Queens(rowIndex, queenColPlacement) = 1
        Next
        'Row 7 Calculations
        currentRow = 7
        queenColPlacement = CInt(Int((8 * Rnd()) + 0))
        If (Queens(7, 0) = 0 Or Queens(7, 1) = 0 Or Queens(7, 2) = 0 Or Queens(7, 3) = 0 Or Queens(7, 4) = 0 Or Queens(7, 5) = 0 Or Queens(7, 6) = 0 Or Queens(7, 7) = 0) Then
            While (Queens(currentRow, queenColPlacement) = 1)
                queenColPlacement = CInt(Int((8 * Rnd()) + 0))
            End While
        Else
            GoTo 1
        End If
        variableRow = currentRow
        variableCol = queenColPlacement
        leftSideVariable = queenColPlacement
        rightSideVariable = queenColPlacement

        'Filling in Left Horizontal
        If (queenColPlacement <> 0) Then
            For colIndex As Integer = 0 To queenColPlacement - 1 Step 1
                leftSideVariable = leftSideVariable - 1
                Queens(currentRow, leftSideVariable) = 1
            Next
        End If

        'Filling in Right Horizontal
        If (queenColPlacement <> 7) Then
            For colIndex As Integer = queenColPlacement + 1 To 7 Step 1
                rightSideVariable = rightSideVariable + 1
                Queens(currentRow, rightSideVariable) = 1
            Next
        End If

        'Filling in Left Diagonal
        If (queenColPlacement <> 0) Then
            For colIndex As Integer = 0 To queenColPlacement - 1 Step 1
                variableCol = variableCol - 1
                variableRow = variableRow + 1
                If (variableRow < 8) Then
                    Queens(variableRow, variableCol) = 1
                End If
            Next
        End If

        'Filling in Right Diagonal
        variableRow = currentRow
        variableCol = queenColPlacement
        If (queenColPlacement <> 7) Then
            For colIndex As Integer = queenColPlacement + 1 To 7 Step 1
                variableCol = variableCol + 1
                variableRow = variableRow + 1
                If (variableRow < 8) Then
                    Queens(variableRow, variableCol) = 1
                End If
            Next
        End If


        'Displaying Proper Text
        If Queens(0, 0) = 0 Then
            Label1.Text = "Q"
        End If
        If Queens(0, 1) = 0 Then
            Label2.Text = "Q"
        End If
        If Queens(0, 2) = 0 Then
            Label4.Text = "Q"
        End If
        If Queens(0, 3) = 0 Then
            Label3.Text = "Q"
        End If
        If Queens(0, 4) = 0 Then
            Label8.Text = "Q"
        End If
        If Queens(0, 5) = 0 Then
            Label7.Text = "Q"
        End If
        If Queens(0, 6) = 0 Then
            Label6.Text = "Q"
        End If
        If Queens(0, 7) = 0 Then
            Label5.Text = "Q"
        End If

        'Display for Second Row
        If Queens(1, 0) = 0 Then
            Label16.Text = "Q"
        End If
        If Queens(1, 1) = 0 Then
            Label15.Text = "Q"
        End If
        If Queens(1, 2) = 0 Then
            Label14.Text = "Q"
        End If
        If Queens(1, 3) = 0 Then
            Label13.Text = "Q"
        End If
        If Queens(1, 4) = 0 Then
            Label12.Text = "Q"
        End If
        If Queens(1, 5) = 0 Then
            Label11.Text = "Q"
        End If
        If Queens(1, 6) = 0 Then
            Label10.Text = "Q"
        End If
        If Queens(1, 7) = 0 Then
            Label9.Text = "Q"
        End If

        'Display for Third Row
        If Queens(2, 0) = 0 Then
            Label32.Text = "Q"
        End If
        If Queens(2, 1) = 0 Then
            Label31.Text = "Q"
        End If
        If Queens(2, 2) = 0 Then
            Label30.Text = "Q"
        End If
        If Queens(2, 3) = 0 Then
            Label29.Text = "Q"
        End If
        If Queens(2, 4) = 0 Then
            Label28.Text = "Q"
        End If
        If Queens(2, 5) = 0 Then
            Label27.Text = "Q"
        End If
        If Queens(2, 6) = 0 Then
            Label26.Text = "Q"
        End If
        If Queens(2, 7) = 0 Then
            Label25.Text = "Q"
        End If

        'Display for Fourth Row
        If Queens(3, 0) = 0 Then
            Label24.Text = "Q"
        End If
        If Queens(3, 1) = 0 Then
            Label23.Text = "Q"
        End If
        If Queens(3, 2) = 0 Then
            Label22.Text = "Q"
        End If
        If Queens(3, 3) = 0 Then
            Label21.Text = "Q"
        End If
        If Queens(3, 4) = 0 Then
            Label20.Text = "Q"
        End If
        If Queens(3, 5) = 0 Then
            Label19.Text = "Q"
        End If
        If Queens(3, 6) = 0 Then
            Label18.Text = "Q"
        End If
        If Queens(3, 7) = 0 Then
            Label17.Text = "Q"
        End If

        'Display for Fifth Row Row
        If Queens(4, 0) = 0 Then
            Label64.Text = "Q"
        End If
        If Queens(4, 1) = 0 Then
            Label63.Text = "Q"
        End If
        If Queens(4, 2) = 0 Then
            Label62.Text = "Q"
        End If
        If Queens(4, 3) = 0 Then
            Label61.Text = "Q"
        End If
        If Queens(4, 4) = 0 Then
            Label60.Text = "Q"
        End If
        If Queens(4, 5) = 0 Then
            Label59.Text = "Q"
        End If
        If Queens(4, 6) = 0 Then
            Label58.Text = "Q"
        End If
        If Queens(4, 7) = 0 Then
            Label57.Text = "Q"
        End If

        'Display for Sixth Row 
        If Queens(5, 0) = 0 Then
            Label56.Text = "Q"
        End If
        If Queens(5, 1) = 0 Then
            Label55.Text = "Q"
        End If
        If Queens(5, 2) = 0 Then
            Label54.Text = "Q"
        End If
        If Queens(5, 3) = 0 Then
            Label53.Text = "Q"
        End If
        If Queens(5, 4) = 0 Then
            Label52.Text = "Q"
        End If
        If Queens(5, 5) = 0 Then
            Label51.Text = "Q"
        End If
        If Queens(5, 6) = 0 Then
            Label50.Text = "Q"
        End If
        If Queens(5, 7) = 0 Then
            Label49.Text = "Q"
        End If

        'Display for Seventh Row 
        If Queens(6, 0) = 0 Then
            Label48.Text = "Q"
        End If
        If Queens(6, 1) = 0 Then
            Label47.Text = "Q"
        End If
        If Queens(6, 2) = 0 Then
            Label46.Text = "Q"
        End If
        If Queens(6, 3) = 0 Then
            Label45.Text = "Q"
        End If
        If Queens(6, 4) = 0 Then
            Label44.Text = "Q"
        End If
        If Queens(6, 5) = 0 Then
            Label43.Text = "Q"
        End If
        If Queens(6, 6) = 0 Then
            Label42.Text = "Q"
        End If
        If Queens(6, 7) = 0 Then
            Label41.Text = "Q"
        End If

        'Display for Eigth Row 
        If Queens(7, 0) = 0 Then
            Label40.Text = "Q"
        End If
        If Queens(7, 1) = 0 Then
            Label39.Text = "Q"
        End If
        If Queens(7, 2) = 0 Then
            Label38.Text = "Q"
        End If
        If Queens(7, 3) = 0 Then
            Label37.Text = "Q"
        End If
        If Queens(7, 4) = 0 Then
            Label36.Text = "Q"
        End If
        If Queens(7, 5) = 0 Then
            Label35.Text = "Q"
        End If
        If Queens(7, 6) = 0 Then
            Label34.Text = "Q"
        End If
        If Queens(7, 7) = 0 Then
            Label33.Text = "Q"
        End If

        '-----------------------------------------------------
        'Display for First Row
        If Queens(0, 0) = 1 Then
            Label1.Text = ""
        End If
        If Queens(0, 1) = 1 Then
            Label2.Text = ""
        End If
        If Queens(0, 2) = 1 Then
            Label4.Text = ""
        End If
        If Queens(0, 3) = 1 Then
            Label3.Text = ""
        End If
        If Queens(0, 4) = 1 Then
            Label8.Text = ""
        End If
        If Queens(0, 5) = 1 Then
            Label7.Text = ""
        End If
        If Queens(0, 6) = 1 Then
            Label6.Text = ""
        End If
        If Queens(0, 7) = 1 Then
            Label5.Text = ""
        End If

        'Display for Second Row
        If Queens(1, 0) = 1 Then
            Label16.Text = ""
        End If
        If Queens(1, 1) = 1 Then
            Label15.Text = ""
        End If
        If Queens(1, 2) = 1 Then
            Label14.Text = ""
        End If
        If Queens(1, 3) = 1 Then
            Label13.Text = ""
        End If
        If Queens(1, 4) = 1 Then
            Label12.Text = ""
        End If
        If Queens(1, 5) = 1 Then
            Label11.Text = ""
        End If
        If Queens(1, 6) = 1 Then
            Label10.Text = ""
        End If
        If Queens(1, 7) = 1 Then
            Label9.Text = ""
        End If

        'Display for Third Row
        If Queens(2, 0) = 1 Then
            Label32.Text = ""
        End If
        If Queens(2, 1) = 1 Then
            Label31.Text = ""
        End If
        If Queens(2, 2) = 1 Then
            Label30.Text = ""
        End If
        If Queens(2, 3) = 1 Then
            Label29.Text = ""
        End If
        If Queens(2, 4) = 1 Then
            Label28.Text = ""
        End If
        If Queens(2, 5) = 1 Then
            Label27.Text = ""
        End If
        If Queens(2, 6) = 1 Then
            Label26.Text = ""
        End If
        If Queens(2, 7) = 1 Then
            Label25.Text = ""
        End If

        'Display for Fourth Row
        If Queens(3, 0) = 1 Then
            Label24.Text = ""
        End If
        If Queens(3, 1) = 1 Then
            Label23.Text = ""
        End If
        If Queens(3, 2) = 1 Then
            Label22.Text = ""
        End If
        If Queens(3, 3) = 1 Then
            Label21.Text = ""
        End If
        If Queens(3, 4) = 1 Then
            Label20.Text = ""
        End If
        If Queens(3, 5) = 1 Then
            Label19.Text = ""
        End If
        If Queens(3, 6) = 1 Then
            Label18.Text = ""
        End If
        If Queens(3, 7) = 1 Then
            Label17.Text = ""
        End If

        'Display for Fifth Row Row
        If Queens(4, 0) = 1 Then
            Label64.Text = ""
        End If
        If Queens(4, 1) = 1 Then
            Label63.Text = ""
        End If
        If Queens(4, 2) = 1 Then
            Label62.Text = ""
        End If
        If Queens(4, 3) = 1 Then
            Label61.Text = ""
        End If
        If Queens(4, 4) = 1 Then
            Label60.Text = ""
        End If
        If Queens(4, 5) = 1 Then
            Label59.Text = ""
        End If
        If Queens(4, 6) = 1 Then
            Label58.Text = ""
        End If
        If Queens(4, 7) = 1 Then
            Label57.Text = ""
        End If

        'Display for Sixth Row 
        If Queens(5, 0) = 1 Then
            Label56.Text = ""
        End If
        If Queens(5, 1) = 1 Then
            Label55.Text = ""
        End If
        If Queens(5, 2) = 1 Then
            Label54.Text = ""
        End If
        If Queens(5, 3) = 1 Then
            Label53.Text = ""
        End If
        If Queens(5, 4) = 1 Then
            Label52.Text = ""
        End If
        If Queens(5, 5) = 1 Then
            Label51.Text = ""
        End If
        If Queens(5, 6) = 1 Then
            Label50.Text = ""
        End If
        If Queens(5, 7) = 1 Then
            Label49.Text = ""
        End If

        'Display for Seventh Row 
        If Queens(6, 0) = 1 Then
            Label48.Text = ""
        End If
        If Queens(6, 1) = 1 Then
            Label47.Text = ""
        End If
        If Queens(6, 2) = 1 Then
            Label46.Text = ""
        End If
        If Queens(6, 3) = 1 Then
            Label45.Text = ""
        End If
        If Queens(6, 4) = 1 Then
            Label44.Text = ""
        End If
        If Queens(6, 5) = 1 Then
            Label43.Text = ""
        End If
        If Queens(6, 6) = 1 Then
            Label42.Text = ""
        End If
        If Queens(6, 7) = 1 Then
            Label41.Text = ""
        End If

        'Display for Eigth Row 
        If Queens(7, 0) = 1 Then
            Label40.Text = ""
        End If
        If Queens(7, 1) = 1 Then
            Label39.Text = ""
        End If
        If Queens(7, 2) = 1 Then
            Label38.Text = ""
        End If
        If Queens(7, 3) = 1 Then
            Label37.Text = ""
        End If
        If Queens(7, 4) = 1 Then
            Label36.Text = ""
        End If
        If Queens(7, 5) = 1 Then
            Label35.Text = ""
        End If
        If Queens(7, 6) = 1 Then
            Label34.Text = ""
        End If
        If Queens(7, 7) = 1 Then
            Label33.Text = ""
        End If
    End Sub

    Private Sub Label65_Click(sender As Object, e As EventArgs) Handles Label65.Click

    End Sub
End Class
