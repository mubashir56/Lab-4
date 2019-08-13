Option Strict On
''' <summary>
''' Handle all functions of the Semester Average Form
''' </summary>
Public Class SemesterAverageForm
#Region "Constants and Variables"
    Private Const MIN_GRADE As Integer = 0
    Private Const MAX_GRADE As Integer = 100
#End Region

#Region "Functions and Subroutines"

    ''' <summary>
    ''' Converts a numeric grade into a letter grade
    ''' </summary>
    ''' <param name="numberGrade">The grade to be converted</param>
    ''' <returns>Letter grade corresponding to the provided number grade</returns>
    Function getLetterGrade(ByVal numberGrade As Double) As String
        Dim letterGrade As String = ""

        Select Case numberGrade
            Case 90 To 100
                letterGrade = "A+"
            Case 85 To 89
                letterGrade = "A"
            Case 80 To 84
                letterGrade = "A-"
            Case 77 To 79
                letterGrade = "B+"
            Case 73 To 84
                letterGrade = "B"
            Case 70 To 84
                letterGrade = "B-"
            Case 67 To 84
                letterGrade = "C+"
            Case 63 To 84
                letterGrade = "C"
            Case 60 To 84
                letterGrade = "C-"
            Case 57 To 84
                letterGrade = "D+"
            Case 53 To 84
                letterGrade = "D"
            Case 50 To 84
                letterGrade = "D-"
            Case 0 To 49
                letterGrade = "F"
        End Select

        Return letterGrade
    End Function

    ''' <summary>
    ''' Checks if provided string meets the requirements of a number grade
    ''' </summary>
    ''' <param name="inputData">Data to be validated</param>
    ''' <returns>Whether the data passed validation</returns>
    Function validateInput(ByVal inputData As String) As Boolean
        Dim isValidInput As Boolean = False
        Dim dataAsNumber As Integer

        If (Integer.TryParse(inputData, dataAsNumber)) Then
            If (dataAsNumber >= MIN_GRADE AndAlso dataAsNumber <= MAX_GRADE) Then
                isValidInput = True
            End If
        End If

        Return isValidInput
    End Function

#End Region

#Region "Event Handlers"
    ''' <summary>
    ''' Handles Class 1 data entry
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub txtCourseOneGrade_TextChanged(sender As Object, e As EventArgs) Handles txtCourseOneGrade.LostFocus
        Dim userInput As String = txtCourseOneGrade.Text
        If (validateInput(userInput)) Then
            lblCourseOneLetterGrade.Text = getLetterGrade(CDbl(userInput))
            lblResponseOutput.Text = ""
        Else
            lblResponseOutput.Text = "Please make sure you enter a valid grade between " + MIN_GRADE.ToString + " and " + MAX_GRADE.ToString

        End If
    End Sub

    ''' <summary>
    ''' Handles Class 2 data entry
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub txtCourseTwoGrade_TextChanged(sender As Object, e As EventArgs) Handles txtCourseTwoGrade.LostFocus
        Dim userInput As String = txtCourseTwoGrade.Text
        If (validateInput(userInput)) Then
            lblCourseTwoLetterGrade.Text = getLetterGrade(CDbl(userInput))
            lblResponseOutput.Text = ""
        Else
            lblResponseOutput.Text = "Please make sure you enter a valid grade between " + MIN_GRADE.ToString + " and " + MAX_GRADE.ToString

        End If
    End Sub

    ''' <summary>
    ''' Handles Class 3 data entry
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub txtCourseThreeGrade_TextChanged(sender As Object, e As EventArgs) Handles txtCourseThreeGrade.LostFocus
        Dim userInput As String = txtCourseThreeGrade.Text
        If (validateInput(userInput)) Then
            lblCourseThreeLetterGrade.Text = getLetterGrade(CDbl(userInput))
            lblResponseOutput.Text = ""
        Else
            lblResponseOutput.Text = "Please make sure you enter a valid grade between " + MIN_GRADE.ToString + " and " + MAX_GRADE.ToString

        End If
    End Sub

    ''' <summary>
    ''' Handles Class 4 data entry
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub txtCourseFourGrade_TextChanged(sender As Object, e As EventArgs) Handles txtCourseFourGrade.LostFocus
        Dim userInput As String = txtCourseFourGrade.Text
        If (validateInput(userInput)) Then
            lblCourseFourLetterGrade.Text = getLetterGrade(CDbl(userInput))
            lblResponseOutput.Text = ""
        Else
            lblResponseOutput.Text = "Please make sure you enter a valid grade between " + MIN_GRADE.ToString + " and " + MAX_GRADE.ToString
        End If
    End Sub

    ''' <summary>
    ''' Handles Class 5 data entry
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub txtCourseFiveGrade_TextChanged(sender As Object, e As EventArgs) Handles txtCourseFiveGrade.LostFocus
        Dim userInput As String = txtCourseFiveGrade.Text
        If (validateInput(userInput)) Then
            lblCourseFiveLetterGrade.Text = getLetterGrade(CDbl(userInput))
            lblResponseOutput.Text = ""
        Else
            lblResponseOutput.Text = "Please make sure you enter a valid grade between " + MIN_GRADE.ToString + " and " + MAX_GRADE.ToString
        End If
    End Sub

    ''' <summary>
    ''' Handles Class 6 data entry
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub txtCourseSixGrade_TextChanged(sender As Object, e As EventArgs) Handles txtCourseSixGrade.LostFocus
        Dim userInput As String = txtCourseSixGrade.Text
        If (validateInput(userInput)) Then
            lblCourseSixLetterGrade.Text = getLetterGrade(CDbl(userInput))
            lblResponseOutput.Text = ""
        Else
            lblResponseOutput.Text = "Please make sure you enter a valid grade between " + MIN_GRADE.ToString + " and " + MAX_GRADE.ToString
        End If
    End Sub

    ''' <summary>
    ''' Handles the exit button, and exiting the form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    ''' <summary>
    ''' Handles the reset button and resetting the form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        lblResponseOutput.Text = ""
        lblSemesterAverage.Text = ""

        txtCourseOneGrade.Clear()
        txtCourseTwoGrade.Clear()
        txtCourseThreeGrade.Clear()
        txtCourseFourGrade.Clear()
        txtCourseFiveGrade.Clear()
        txtCourseSixGrade.Clear()

        lblCourseOneLetterGrade.Text = ""
        lblCourseTwoLetterGrade.Text = ""
        lblCourseThreeLetterGrade.Text = ""
        lblCourseFourLetterGrade.Text = ""
        lblCourseFiveLetterGrade.Text = ""
        lblCourseSixLetterGrade.Text = ""

        lblSemesterAverage.Text = ""
        lblSemesterLetterGrade.Text = ""

        btnCalculate.Enabled = True
        txtCourseOneGrade.ReadOnly = False
        txtCourseTwoGrade.ReadOnly = False
        txtCourseThreeGrade.ReadOnly = False
        txtCourseFourGrade.ReadOnly = False
        txtCourseFiveGrade.ReadOnly = False
        txtCourseSixGrade.ReadOnly = False
    End Sub

    ''' <summary>
    ''' Handles calculate button, calculating the semester average, and disabling input
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim gradeNumbers(5) As Double
        Dim areAllInputsValid As Boolean = False
        Dim formattedErrorMessage As String = ""
        Dim userInputs() As String = {txtCourseOneGrade.Text, txtCourseTwoGrade.Text, txtCourseThreeGrade.Text, txtCourseFourGrade.Text, txtCourseFiveGrade.Text, txtCourseSixGrade.Text}
        Dim runningTotal As Double = 0

        For inputCounter As Integer = 0 To userInputs.Length - 1 Step 1
            If Not (validateInput(userInputs(inputCounter))) Then
                formattedErrorMessage += "Please ensure that what you entered in Course " + (inputCounter + 1).ToString + " is a valid number between " + MIN_GRADE.ToString + " and " + MAX_GRADE.ToString + vbCrLf
            Else
                gradeNumbers(inputCounter) = CDbl(userInputs(inputCounter))
            End If
        Next

        If formattedErrorMessage.Equals("") Then
            For Each grade As Double In gradeNumbers
                runningTotal += grade
            Next
            lblSemesterAverage.Text = Math.Round(runningTotal / gradeNumbers.Length, 2).ToString
            lblSemesterLetterGrade.Text = getLetterGrade(Math.Round(runningTotal / gradeNumbers.Length, 2))
            lblResponseOutput.Text = "SUCCESS! " + vbCrLf + "Press reset to calculate another semester"

            btnCalculate.Enabled = False
            txtCourseOneGrade.ReadOnly = True
            txtCourseTwoGrade.ReadOnly = True
            txtCourseThreeGrade.ReadOnly = True
            txtCourseFourGrade.ReadOnly = True
            txtCourseFiveGrade.ReadOnly = True
            txtCourseSixGrade.ReadOnly = True


        Else
            lblResponseOutput.Text = "ERROR(S)!" + vbCrLf + formattedErrorMessage
        End If

    End Sub


#End Region

End Class
