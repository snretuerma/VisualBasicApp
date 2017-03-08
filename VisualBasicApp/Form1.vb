Public Class Form1

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles inputPanel.Paint

    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles permutationRadio.CheckedChanged

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles methodPanelLabel.Click

    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles allowedRadio.CheckedChanged

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        answerLabel.Hide()
    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles inputTokenLabel.Click

    End Sub

    Private Sub MaskedTextBox1_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs)

    End Sub

    Private Sub computeButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles computeButton.Click
        If permutationRadio.Checked Then
            If allowedRadio.Checked Then
                If sampleSizeTextBox.TextLength > 0 And tokenElementTextBox.TextLength > 0 Then
                    Dim sampleSize As Double
                    Dim tokenElement As Double
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
                        answerLabel.Text = sampleSizeTextBox.Text ^ tokenElementTextBox.Text
                        answerLabel.Show()

                    End If

                Else
                    MessageBox.Show("No input", "Error", _
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
                End If
            ElseIf notAllowedRadio.Checked Then
                MessageBox.Show("Ok", "Sample", _
                   MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
            Else
                MessageBox.Show("Select repetition option", "Error", _
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
            End If

        ElseIf combinationRadio.Checked Then
            answerLabel.Text = sampleSizeTextBox.Text ^ tokenElementTextBox.Text
            answerLabel.Show()
        End If


    End Sub

End Class
