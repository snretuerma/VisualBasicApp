Public Class appWindow

    'on click of compute button
    Private Sub computeButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles computeButton.Click
        'variables used for the input textboxes
        Dim sampleSize As Double = 0
        Dim tokenElement As Double = 0
        Select Case True
            'Permutation case
            Case permutationRadio.Checked
                Select Case True
                    'case for repetition allowed
                    Case allowedRadio.Checked
                        'check if input length is greater than 0 to ensure that ther is an input in the text box repeated in other cases
                        If sampleSizeTextBox.TextLength > 0 And tokenElementTextBox.TextLength > 0 Then
                            'check if the input can be parsed as double/ check if the input is a number
                            'display error message if input is not a number
                            If Not Double.TryParse(sampleSizeTextBox.Text.Trim, sampleSize) Then
                                MessageBox.Show("Incorrect input type. Must be double", "Error", _
                                   MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
                                sampleSizeTextBox.Clear()
                                sampleSizeTextBox.Focus()
                                'display error message if input is not a number
                            ElseIf Not Double.TryParse(tokenElementTextBox.Text.Trim, tokenElement) Then
                                MessageBox.Show("Incorrect input type. Must be double", "Error", _
                                   MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
                                tokenElementTextBox.Clear()
                                tokenElementTextBox.Focus()

                            Else

                                If tokenElement > sampleSize Then
                                    MessageBox.Show("Token element must be less than the Sample Size", "Error", _
                                        MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
                                    tokenElementTextBox.Clear()
                                    tokenElementTextBox.Focus()
                                Else
                                    Dim answer As Double = sampleSize ^ tokenElement
                                    answerLabel.Text = "There are " & answer & " possible outcomes"
                                End If

                            End If

                        Else
                            MessageBox.Show("No input", "Error", _
                                MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
                        End If
                        'case for repetition not allowed
                    Case notAllowedRadio.Checked
                        If sampleSizeTextBox.TextLength > 0 And tokenElementTextBox.TextLength > 0 Then
                            If Not Double.TryParse(sampleSizeTextBox.Text.Trim, sampleSize) Then
                                MessageBox.Show("Incorrect input type. Must be double", "Error", _
                                   MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
                                sampleSizeTextBox.Clear()
                                sampleSizeTextBox.Focus()

                            ElseIf Not Double.TryParse(tokenElementTextBox.Text.Trim, tokenElement) Then
                                MessageBox.Show("Incorrect input type. Must be double", "Error", _
                                   MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
                                tokenElementTextBox.Clear()
                                tokenElementTextBox.Focus()

                            Else

                                If tokenElement > sampleSize Then
                                    MessageBox.Show("Token element must be less than the Sample Size", "Error", _
                                        MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
                                    tokenElementTextBox.Clear()
                                    tokenElementTextBox.Focus()
                                Else
                                    'use double data type for the variables to ensure precision and also to prevent data type errors from the division operation in the the computation
                                    Dim answer As Double = 0
                                    Dim numerator As Double = 1
                                    Dim denominator As Double = sampleSize - tokenElement
                                    Dim solvedDenominator As Double = 1

                                    'if sample size is 0 save the value of 1 as the value of the numerator to emulate 0!
                                    If sampleSize = 0 Then
                                        numerator = 1
                                    Else
                                        'iterate index from 1 to the sample size while multiplying the numerator value to the index then save it again to the numerator variable
                                        For index As Double = 1 To sampleSize
                                            numerator = numerator * index
                                        Next
                                    End If
                                    'do the same(factorial) operation to the computed denominator (n-r)  
                                    If denominator = 0 Then
                                        denominator = 1
                                    Else
                                        For index As Double = 1 To denominator
                                            solvedDenominator = solvedDenominator * index
                                        Next
                                    End If
                                    'do the last operation(divide the numerator and denominator factorials) then print the value as a label in the GUI
                                    answer = numerator / solvedDenominator
                                    answerLabel.Text = "There are " & answer & " possible outcomes"

                                End If

                            End If

                        Else
                            'display error message if no input is detected
                            MessageBox.Show("No input", "Error", _
                                MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
                        End If
                    Case Else
                        'for default case when nothing is selected, display an error message
                        MessageBox.Show("Select repetition option", "Error", _
                            MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
                End Select

                'Combination case
            Case combinationRadio.Checked
                Select Case True
                    Case allowedRadio.Checked
                        If sampleSizeTextBox.TextLength > 0 And tokenElementTextBox.TextLength > 0 Then
                            If Not Double.TryParse(sampleSizeTextBox.Text.Trim, sampleSize) Then
                                MessageBox.Show("Incorrect input type. Must be double", "Error", _
                                   MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
                                sampleSizeTextBox.Clear()
                                sampleSizeTextBox.Focus()

                            ElseIf Not Double.TryParse(tokenElementTextBox.Text.Trim, tokenElement) Then
                                MessageBox.Show("Incorrect input type. Must be double", "Error", _
                                   MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
                                tokenElementTextBox.Clear()
                                tokenElementTextBox.Focus()

                            Else

                                If tokenElement > sampleSize Then
                                    MessageBox.Show("Token element must be less than the Sample Size", "Error", _
                                        MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
                                    tokenElementTextBox.Clear()
                                    tokenElementTextBox.Focus()
                                Else
                                    'use double data type for the variables to ensure precision and also to prevent data type errors from the division operation in the the computation
                                    Dim answer As Double = 0
                                    Dim numerator As Double = 1
                                    Dim denominator As Double = 1
                                    Dim solvedDenominator As Double = sampleSize - tokenElement
                                    Dim finalDenominator As Double = 1

                                    'solve n!
                                    If sampleSize > 0 Then
                                        For index = sampleSize To 1 Step -1
                                            numerator *= index
                                        Next
                                    End If

                                    'solve r!
                                    If tokenElement > 0 Then
                                        For index = tokenElement To 1 Step -1
                                            denominator *= index
                                        Next
                                    End If

                                    'solve (n-r)!
                                    If solvedDenominator > 0 Then
                                        For index = solvedDenominator To 1 Step -1
                                            finalDenominator *= index
                                        Next
                                    End If

                                    answerLabel.Text = "There are " & numerator / (denominator * finalDenominator) & " possible outcomes"

                                End If

                            End If

                        Else
                            MessageBox.Show("No input", "Error", _
                                MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
                        End If
                    Case notAllowedRadio.Checked
                        If sampleSizeTextBox.TextLength > 0 And tokenElementTextBox.TextLength > 0 Then
                            If Not Double.TryParse(sampleSizeTextBox.Text.Trim, sampleSize) Then
                                MessageBox.Show("Incorrect input type. Must be double", "Error", _
                                   MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
                                sampleSizeTextBox.Clear()
                                sampleSizeTextBox.Focus()

                            ElseIf Not Double.TryParse(tokenElementTextBox.Text.Trim, tokenElement) Then
                                MessageBox.Show("Incorrect input type. Must be double", "Error", _
                                   MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
                                tokenElementTextBox.Clear()
                                tokenElementTextBox.Focus()

                            Else

                                If tokenElement > sampleSize Then
                                    MessageBox.Show("Token element must be less than the Sample Size", "Error", _
                                        MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
                                    tokenElementTextBox.Clear()
                                    tokenElementTextBox.Focus()
                                Else
                                    'use double data type for the variables to ensure precision and also to prevent data type errors from the division operation in the the computation
                                    Dim answer As Double = 0
                                    Dim numerator As Double = (sampleSize + tokenElement) - 1
                                    Dim solvedNumerator As Double = 1
                                    Dim denominator As Double = 1
                                    Dim solvedDenominator As Double = sampleSize - 1
                                    Dim finalDenominator As Double = 1

                                    'solve n! using the variable of numerator which has the computed value of n+r-1
                                    If numerator > 0 Then
                                        For index = numerator To 1 Step -1
                                            solvedNumerator *= index
                                        Next
                                    Else
                                        solvedNumerator = 1
                                    End If

                                    'solve r!
                                    If tokenElement > 0 Then
                                        For index = tokenElement To 1 Step -1
                                            denominator *= index
                                        Next
                                    End If

                                    'solve (n-1)!
                                    If solvedDenominator > 0 Then
                                        For index = solvedDenominator To 1 Step -1
                                            finalDenominator *= index
                                        Next
                                    End If

                                    answerLabel.Text = "There are " & solvedNumerator / (denominator * finalDenominator) & " possible outcomes"

                                End If

                            End If

                        Else
                            'when no input is detected, display an error message
                            MessageBox.Show("No input", "Error", _
                                MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
                        End If

                    Case Else
                        'for default case when nothing is selected, display an error message
                        MessageBox.Show("Select repetition option", "Error", _
                            MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
                End Select
            Case Else
                'for default case when nothing is selected, display an error message
                MessageBox.Show("Select a method to use", "Error", _
                          MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
        End Select

    End Sub

    'reset button function
    Private Sub resetButton_Click(sender As System.Object, e As System.EventArgs) Handles resetButton.Click
        permutationRadio.Checked = False
        combinationRadio.Checked = False
        allowedRadio.Checked = False
        notAllowedRadio.Checked = False
        sampleSizeTextBox.Clear()
        tokenElementTextBox.Clear()
        answerLabel.Text = "Answer Unavailable"
    End Sub

    'on click of close in the file menu strip
    Private Sub menuClose_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub

    'on click of help in the menu strip
    Private Sub menuHelp_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        MessageBox.Show("This is an application that computes Permutation and Combination with and without repetition" & vbNewLine & "Instruction:" & vbNewLine & "1. Choose a counting method" & vbNewLine & "2. Choose repetition" & vbNewLine & "3. Input necessary information then click the compute button" & vbNewLine & "Note: Press the Reset button to clear the input", "About", _
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
    End Sub

    'on click of close button display confirmation dialog box
    Private Sub MyForm_Closing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show(" Are you sure you want to quit", "Are you sure?", MessageBoxButtons.YesNoCancel) <> DialogResult.Yes Then
            e.Cancel = True
        End If
    End Sub
End Class
