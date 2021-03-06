﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class appWindow
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.inputPanel = New System.Windows.Forms.Panel()
        Me.tokenElementTextBox = New System.Windows.Forms.TextBox()
        Me.sampleSizeTextBox = New System.Windows.Forms.TextBox()
        Me.inputTokenLabel = New System.Windows.Forms.Label()
        Me.inputSizeLabel = New System.Windows.Forms.Label()
        Me.inputPanelLabel = New System.Windows.Forms.Label()
        Me.buttonPanel = New System.Windows.Forms.Panel()
        Me.resetButton = New System.Windows.Forms.Button()
        Me.computeButton = New System.Windows.Forms.Button()
        Me.answerLabel = New System.Windows.Forms.Label()
        Me.answerPanelLabel = New System.Windows.Forms.Label()
        Me.methodPanel = New System.Windows.Forms.Panel()
        Me.methodPanelLabel = New System.Windows.Forms.Label()
        Me.combinationRadio = New System.Windows.Forms.RadioButton()
        Me.permutationRadio = New System.Windows.Forms.RadioButton()
        Me.repetitionPanel = New System.Windows.Forms.Panel()
        Me.notAllowedRadio = New System.Windows.Forms.RadioButton()
        Me.allowedRadio = New System.Windows.Forms.RadioButton()
        Me.repetitionPanelLabel = New System.Windows.Forms.Label()
        Me.FileToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.inputPanel.SuspendLayout()
        Me.buttonPanel.SuspendLayout()
        Me.methodPanel.SuspendLayout()
        Me.repetitionPanel.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'inputPanel
        '
        Me.inputPanel.Controls.Add(Me.tokenElementTextBox)
        Me.inputPanel.Controls.Add(Me.sampleSizeTextBox)
        Me.inputPanel.Controls.Add(Me.inputTokenLabel)
        Me.inputPanel.Controls.Add(Me.inputSizeLabel)
        Me.inputPanel.Controls.Add(Me.inputPanelLabel)
        Me.inputPanel.Location = New System.Drawing.Point(216, 40)
        Me.inputPanel.Name = "inputPanel"
        Me.inputPanel.Size = New System.Drawing.Size(382, 102)
        Me.inputPanel.TabIndex = 6
        '
        'tokenElementTextBox
        '
        Me.tokenElementTextBox.Location = New System.Drawing.Point(107, 57)
        Me.tokenElementTextBox.Name = "tokenElementTextBox"
        Me.tokenElementTextBox.Size = New System.Drawing.Size(251, 20)
        Me.tokenElementTextBox.TabIndex = 8
        '
        'sampleSizeTextBox
        '
        Me.sampleSizeTextBox.Location = New System.Drawing.Point(107, 33)
        Me.sampleSizeTextBox.Name = "sampleSizeTextBox"
        Me.sampleSizeTextBox.Size = New System.Drawing.Size(251, 20)
        Me.sampleSizeTextBox.TabIndex = 7
        '
        'inputTokenLabel
        '
        Me.inputTokenLabel.AutoSize = True
        Me.inputTokenLabel.Location = New System.Drawing.Point(15, 60)
        Me.inputTokenLabel.Name = "inputTokenLabel"
        Me.inputTokenLabel.Size = New System.Drawing.Size(91, 13)
        Me.inputTokenLabel.TabIndex = 4
        Me.inputTokenLabel.Text = "Token Element (r)"
        '
        'inputSizeLabel
        '
        Me.inputSizeLabel.AutoSize = True
        Me.inputSizeLabel.Location = New System.Drawing.Point(15, 35)
        Me.inputSizeLabel.Name = "inputSizeLabel"
        Me.inputSizeLabel.Size = New System.Drawing.Size(80, 13)
        Me.inputSizeLabel.TabIndex = 3
        Me.inputSizeLabel.Text = "Sample Size (n)"
        '
        'inputPanelLabel
        '
        Me.inputPanelLabel.AutoSize = True
        Me.inputPanelLabel.Location = New System.Drawing.Point(-3, 0)
        Me.inputPanelLabel.Name = "inputPanelLabel"
        Me.inputPanelLabel.Size = New System.Drawing.Size(36, 13)
        Me.inputPanelLabel.TabIndex = 0
        Me.inputPanelLabel.Text = "Inputs"
        '
        'buttonPanel
        '
        Me.buttonPanel.Controls.Add(Me.resetButton)
        Me.buttonPanel.Controls.Add(Me.computeButton)
        Me.buttonPanel.Controls.Add(Me.answerLabel)
        Me.buttonPanel.Controls.Add(Me.answerPanelLabel)
        Me.buttonPanel.Location = New System.Drawing.Point(216, 148)
        Me.buttonPanel.Name = "buttonPanel"
        Me.buttonPanel.Size = New System.Drawing.Size(382, 101)
        Me.buttonPanel.TabIndex = 9
        '
        'resetButton
        '
        Me.resetButton.Location = New System.Drawing.Point(191, 36)
        Me.resetButton.Name = "resetButton"
        Me.resetButton.Size = New System.Drawing.Size(100, 30)
        Me.resetButton.TabIndex = 11
        Me.resetButton.Text = "Reset"
        Me.resetButton.UseVisualStyleBackColor = True
        '
        'computeButton
        '
        Me.computeButton.Location = New System.Drawing.Point(51, 36)
        Me.computeButton.Name = "computeButton"
        Me.computeButton.Size = New System.Drawing.Size(107, 30)
        Me.computeButton.TabIndex = 10
        Me.computeButton.Text = "Compute"
        Me.computeButton.UseVisualStyleBackColor = True
        '
        'answerLabel
        '
        Me.answerLabel.AutoSize = True
        Me.answerLabel.Location = New System.Drawing.Point(48, 0)
        Me.answerLabel.Name = "answerLabel"
        Me.answerLabel.Size = New System.Drawing.Size(101, 13)
        Me.answerLabel.TabIndex = 1
        Me.answerLabel.Text = "Answer Unavailable"
        '
        'answerPanelLabel
        '
        Me.answerPanelLabel.AutoSize = True
        Me.answerPanelLabel.Location = New System.Drawing.Point(0, 0)
        Me.answerPanelLabel.Name = "answerPanelLabel"
        Me.answerPanelLabel.Size = New System.Drawing.Size(42, 13)
        Me.answerPanelLabel.TabIndex = 0
        Me.answerPanelLabel.Text = "Answer"
        '
        'methodPanel
        '
        Me.methodPanel.Controls.Add(Me.methodPanelLabel)
        Me.methodPanel.Controls.Add(Me.combinationRadio)
        Me.methodPanel.Controls.Add(Me.permutationRadio)
        Me.methodPanel.Location = New System.Drawing.Point(9, 40)
        Me.methodPanel.Name = "methodPanel"
        Me.methodPanel.Size = New System.Drawing.Size(201, 102)
        Me.methodPanel.TabIndex = 0
        '
        'methodPanelLabel
        '
        Me.methodPanelLabel.AutoSize = True
        Me.methodPanelLabel.Location = New System.Drawing.Point(0, 0)
        Me.methodPanelLabel.Name = "methodPanelLabel"
        Me.methodPanelLabel.Size = New System.Drawing.Size(100, 13)
        Me.methodPanelLabel.TabIndex = 2
        Me.methodPanelLabel.Text = "Method of Counting"
        '
        'combinationRadio
        '
        Me.combinationRadio.AutoSize = True
        Me.combinationRadio.Location = New System.Drawing.Point(24, 56)
        Me.combinationRadio.Name = "combinationRadio"
        Me.combinationRadio.Size = New System.Drawing.Size(83, 17)
        Me.combinationRadio.TabIndex = 2
        Me.combinationRadio.Text = "Combination"
        Me.combinationRadio.UseVisualStyleBackColor = True
        '
        'permutationRadio
        '
        Me.permutationRadio.AutoSize = True
        Me.permutationRadio.Location = New System.Drawing.Point(24, 33)
        Me.permutationRadio.Name = "permutationRadio"
        Me.permutationRadio.Size = New System.Drawing.Size(81, 17)
        Me.permutationRadio.TabIndex = 1
        Me.permutationRadio.Text = "Permutation"
        Me.permutationRadio.UseVisualStyleBackColor = True
        '
        'repetitionPanel
        '
        Me.repetitionPanel.Controls.Add(Me.notAllowedRadio)
        Me.repetitionPanel.Controls.Add(Me.allowedRadio)
        Me.repetitionPanel.Controls.Add(Me.repetitionPanelLabel)
        Me.repetitionPanel.Location = New System.Drawing.Point(9, 148)
        Me.repetitionPanel.Name = "repetitionPanel"
        Me.repetitionPanel.Size = New System.Drawing.Size(201, 101)
        Me.repetitionPanel.TabIndex = 3
        '
        'notAllowedRadio
        '
        Me.notAllowedRadio.AutoSize = True
        Me.notAllowedRadio.Location = New System.Drawing.Point(24, 49)
        Me.notAllowedRadio.Name = "notAllowedRadio"
        Me.notAllowedRadio.Size = New System.Drawing.Size(82, 17)
        Me.notAllowedRadio.TabIndex = 5
        Me.notAllowedRadio.Text = "Not Allowed"
        Me.notAllowedRadio.UseVisualStyleBackColor = True
        '
        'allowedRadio
        '
        Me.allowedRadio.AutoSize = True
        Me.allowedRadio.Location = New System.Drawing.Point(24, 26)
        Me.allowedRadio.Name = "allowedRadio"
        Me.allowedRadio.Size = New System.Drawing.Size(62, 17)
        Me.allowedRadio.TabIndex = 4
        Me.allowedRadio.Text = "Allowed"
        Me.allowedRadio.UseVisualStyleBackColor = True
        '
        'repetitionPanelLabel
        '
        Me.repetitionPanelLabel.AutoSize = True
        Me.repetitionPanelLabel.Location = New System.Drawing.Point(3, 0)
        Me.repetitionPanelLabel.Name = "repetitionPanelLabel"
        Me.repetitionPanelLabel.Size = New System.Drawing.Size(55, 13)
        Me.repetitionPanelLabel.TabIndex = 0
        Me.repetitionPanelLabel.Text = "Repetition"
        '
        'FileToolStripMenuItem1
        '
        Me.FileToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseToolStripMenuItem})
        Me.FileToolStripMenuItem1.Name = "FileToolStripMenuItem1"
        Me.FileToolStripMenuItem1.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem1.Text = "File"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem1, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(610, 24)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'appWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(610, 261)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.repetitionPanel)
        Me.Controls.Add(Me.methodPanel)
        Me.Controls.Add(Me.buttonPanel)
        Me.Controls.Add(Me.inputPanel)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "appWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Methods of Counting"
        Me.inputPanel.ResumeLayout(False)
        Me.inputPanel.PerformLayout()
        Me.buttonPanel.ResumeLayout(False)
        Me.buttonPanel.PerformLayout()
        Me.methodPanel.ResumeLayout(False)
        Me.methodPanel.PerformLayout()
        Me.repetitionPanel.ResumeLayout(False)
        Me.repetitionPanel.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents inputPanel As System.Windows.Forms.Panel
    Friend WithEvents buttonPanel As System.Windows.Forms.Panel
    Friend WithEvents methodPanel As System.Windows.Forms.Panel
    Friend WithEvents permutationRadio As System.Windows.Forms.RadioButton
    Friend WithEvents repetitionPanel As System.Windows.Forms.Panel
    Friend WithEvents methodPanelLabel As System.Windows.Forms.Label
    Friend WithEvents combinationRadio As System.Windows.Forms.RadioButton
    Friend WithEvents notAllowedRadio As System.Windows.Forms.RadioButton
    Friend WithEvents allowedRadio As System.Windows.Forms.RadioButton
    Friend WithEvents repetitionPanelLabel As System.Windows.Forms.Label
    Friend WithEvents inputTokenLabel As System.Windows.Forms.Label
    Friend WithEvents inputSizeLabel As System.Windows.Forms.Label
    Friend WithEvents inputPanelLabel As System.Windows.Forms.Label
    Friend WithEvents answerPanelLabel As System.Windows.Forms.Label
    Friend WithEvents resetButton As System.Windows.Forms.Button
    Friend WithEvents computeButton As System.Windows.Forms.Button
    Friend WithEvents answerLabel As System.Windows.Forms.Label
    Friend WithEvents tokenElementTextBox As System.Windows.Forms.TextBox
    Friend WithEvents sampleSizeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FileToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip

End Class
