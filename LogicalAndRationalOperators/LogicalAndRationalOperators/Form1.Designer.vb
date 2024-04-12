<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnGrade = New System.Windows.Forms.Button()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.txtExamScore = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnGrade
        '
        Me.btnGrade.Location = New System.Drawing.Point(240, 273)
        Me.btnGrade.Name = "btnGrade"
        Me.btnGrade.Size = New System.Drawing.Size(126, 65)
        Me.btnGrade.TabIndex = 0
        Me.btnGrade.Text = "Get Grade"
        Me.btnGrade.UseVisualStyleBackColor = True
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Location = New System.Drawing.Point(115, 113)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(126, 16)
        Me.lblScore.TabIndex = 1
        Me.lblScore.Text = "Enter the score here"
        '
        'txtExamScore
        '
        Me.txtExamScore.Location = New System.Drawing.Point(316, 106)
        Me.txtExamScore.MaxLength = 3
        Me.txtExamScore.Name = "txtExamScore"
        Me.txtExamScore.Size = New System.Drawing.Size(164, 22)
        Me.txtExamScore.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtExamScore)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.btnGrade)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnGrade As Button
    Friend WithEvents lblScore As Label
    Friend WithEvents txtExamScore As TextBox
End Class
