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
        Me.txFirstName = New System.Windows.Forms.TextBox()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.txLastName = New System.Windows.Forms.TextBox()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.txGender = New System.Windows.Forms.TextBox()
        Me.lstOccupation = New System.Windows.Forms.ListBox()
        Me.lblOccupation = New System.Windows.Forms.Label()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txFirstName
        '
        Me.txFirstName.Location = New System.Drawing.Point(380, 16)
        Me.txFirstName.Name = "txFirstName"
        Me.txFirstName.Size = New System.Drawing.Size(189, 22)
        Me.txFirstName.TabIndex = 4
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(219, 21)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(72, 16)
        Me.lblFirstName.TabIndex = 5
        Me.lblFirstName.Text = "First Name"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(219, 66)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(72, 16)
        Me.lblLastName.TabIndex = 7
        Me.lblLastName.Text = "Last Name"
        '
        'txLastName
        '
        Me.txLastName.Location = New System.Drawing.Point(380, 61)
        Me.txLastName.Name = "txLastName"
        Me.txLastName.Size = New System.Drawing.Size(189, 22)
        Me.txLastName.TabIndex = 6
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Location = New System.Drawing.Point(219, 109)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(52, 16)
        Me.lblGender.TabIndex = 9
        Me.lblGender.Text = "Gender"
        '
        'txGender
        '
        Me.txGender.Location = New System.Drawing.Point(380, 104)
        Me.txGender.Name = "txGender"
        Me.txGender.Size = New System.Drawing.Size(189, 22)
        Me.txGender.TabIndex = 8
        '
        'lstOccupation
        '
        Me.lstOccupation.FormattingEnabled = True
        Me.lstOccupation.ItemHeight = 16
        Me.lstOccupation.Items.AddRange(New Object() {"Doctor", "Programmer", "Mechanic", "Teacher"})
        Me.lstOccupation.Location = New System.Drawing.Point(625, 41)
        Me.lstOccupation.Name = "lstOccupation"
        Me.lstOccupation.Size = New System.Drawing.Size(120, 164)
        Me.lstOccupation.TabIndex = 10
        '
        'lblOccupation
        '
        Me.lblOccupation.AutoSize = True
        Me.lblOccupation.Location = New System.Drawing.Point(622, 16)
        Me.lblOccupation.Name = "lblOccupation"
        Me.lblOccupation.Size = New System.Drawing.Size(75, 16)
        Me.lblOccupation.TabIndex = 11
        Me.lblOccupation.Text = "Occupation"
        '
        'btnGo
        '
        Me.btnGo.Location = New System.Drawing.Point(222, 212)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(159, 90)
        Me.btnGo.TabIndex = 12
        Me.btnGo.Text = "Go"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnGo)
        Me.Controls.Add(Me.lblOccupation)
        Me.Controls.Add(Me.lstOccupation)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.txGender)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.txLastName)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.txFirstName)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txFirstName As TextBox
    Friend WithEvents lblFirstName As Label
    Friend WithEvents lblLastName As Label
    Friend WithEvents txLastName As TextBox
    Friend WithEvents lblGender As Label
    Friend WithEvents txGender As TextBox
    Friend WithEvents lstOccupation As ListBox
    Friend WithEvents lblOccupation As Label
    Friend WithEvents btnGo As Button

    Private Sub btnGo_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnGo_Click_1(sender As Object, e As EventArgs) Handles btnGo.Click

        Dim stFirstName As String
        Dim stLastName As String
        Dim stGender As String
        Dim stOccumpation As String

        stFirstName = txFirstName.Text
        stLastName = txLastName.Text
        stGender = txGender.Text
        stOccumpation = lstOccupation.SelectedItem

        MsgBox("Hello " & stFirstName & " " & stLastName & " You are a " & stGender & " " & stOccumpation)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lstOccupation.Items.Add("Writer")
        lstOccupation.Items.Add("Actor")
        lstOccupation.Items.Add("Painter")
        lstOccupation.Items.Add("Driver")
    End Sub
End Class
