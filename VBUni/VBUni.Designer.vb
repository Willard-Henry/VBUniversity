<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VBUni
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VBUni))
        Label1 = New Label()
        Label2 = New Label()
        NameTextBox = New TextBox()
        MajorTextBox = New TextBox()
        Display1Button = New Button()
        Display2Button = New Button()
        Display3Button = New Button()
        ResetButton = New Button()
        PrintButton = New Button()
        ExitButton = New Button()
        PrintDocument1 = New Printing.PrintDocument()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(49, 71)
        Label1.Name = "Label1"
        Label1.Size = New Size(113, 18)
        Label1.TabIndex = 0
        Label1.Text = "Student Name :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(49, 113)
        Label2.Name = "Label2"
        Label2.Size = New Size(126, 18)
        Label2.TabIndex = 1
        Label2.Text = "Academic Major :"
        ' 
        ' NameTextBox
        ' 
        NameTextBox.Location = New Point(225, 71)
        NameTextBox.Name = "NameTextBox"
        NameTextBox.ReadOnly = True
        NameTextBox.Size = New Size(298, 25)
        NameTextBox.TabIndex = 2
        NameTextBox.TabStop = False
        ' 
        ' MajorTextBox
        ' 
        MajorTextBox.Location = New Point(225, 113)
        MajorTextBox.Name = "MajorTextBox"
        MajorTextBox.ReadOnly = True
        MajorTextBox.Size = New Size(298, 25)
        MajorTextBox.TabIndex = 2
        MajorTextBox.TabStop = False
        ' 
        ' Display1Button
        ' 
        Display1Button.Location = New Point(49, 255)
        Display1Button.Name = "Display1Button"
        Display1Button.Size = New Size(126, 54)
        Display1Button.TabIndex = 3
        Display1Button.Text = "Display Student #&1"
        Display1Button.UseVisualStyleBackColor = True
        ' 
        ' Display2Button
        ' 
        Display2Button.Location = New Point(225, 255)
        Display2Button.Name = "Display2Button"
        Display2Button.Size = New Size(126, 54)
        Display2Button.TabIndex = 3
        Display2Button.Text = "Display Student #&2"
        Display2Button.UseVisualStyleBackColor = True
        ' 
        ' Display3Button
        ' 
        Display3Button.Location = New Point(397, 255)
        Display3Button.Name = "Display3Button"
        Display3Button.Size = New Size(126, 54)
        Display3Button.TabIndex = 3
        Display3Button.Text = "Display Student #&3"
        Display3Button.UseVisualStyleBackColor = True
        ' 
        ' ResetButton
        ' 
        ResetButton.Location = New Point(49, 339)
        ResetButton.Name = "ResetButton"
        ResetButton.Size = New Size(126, 54)
        ResetButton.TabIndex = 3
        ResetButton.Text = "&Reset Form"
        ResetButton.UseVisualStyleBackColor = True
        ' 
        ' PrintButton
        ' 
        PrintButton.Location = New Point(225, 339)
        PrintButton.Name = "PrintButton"
        PrintButton.Size = New Size(126, 54)
        PrintButton.TabIndex = 3
        PrintButton.Text = "&Print Form"
        PrintButton.UseVisualStyleBackColor = True
        ' 
        ' ExitButton
        ' 
        ExitButton.Location = New Point(397, 339)
        ExitButton.Name = "ExitButton"
        ExitButton.Size = New Size(126, 54)
        ExitButton.TabIndex = 3
        ExitButton.Text = "E&xit"
        ExitButton.UseVisualStyleBackColor = True
        ' 
        ' PrintDocument1
        ' 
        ' 
        ' PrintPreviewDialog1
        ' 
        PrintPreviewDialog1.AutoScrollMargin = New Size(0, 0)
        PrintPreviewDialog1.AutoScrollMinSize = New Size(0, 0)
        PrintPreviewDialog1.ClientSize = New Size(400, 300)
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.Enabled = True
        PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), Icon)
        PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        PrintPreviewDialog1.Visible = False
        ' 
        ' VBUni
        ' 
        AutoScaleDimensions = New SizeF(9.0F, 18.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(548, 405)
        Controls.Add(Display3Button)
        Controls.Add(Display2Button)
        Controls.Add(ExitButton)
        Controls.Add(PrintButton)
        Controls.Add(ResetButton)
        Controls.Add(Display1Button)
        Controls.Add(MajorTextBox)
        Controls.Add(NameTextBox)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Font = New Font("Georgia", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Name = "VBUni"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Student Information"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents MajorTextBox As TextBox
    Friend WithEvents Display1Button As Button
    Friend WithEvents Display2Button As Button
    Friend WithEvents Display3Button As Button
    Friend WithEvents ResetButton As Button
    Friend WithEvents PrintButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog

End Class
