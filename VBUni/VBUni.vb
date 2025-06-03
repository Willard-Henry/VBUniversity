Public Class VBUni
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.


    End Sub
    Private Sub Display1Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Display1Button.Click
        'Display information for the first student
        NameTextBox.Text = "Douglas Bock"
        MajorTextBox.Text = "Computer Management & Information Systems"
    End Sub

    Private Sub Display2Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Display2Button.Click
        'Display information for the second student
        NameTextBox.Text = "Mary Akosua Derry"
        MajorTextBox.Text = "Business Administration"
    End Sub

    Private Sub Display3Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Display3Button.Click
        'Display information for the third student
        NameTextBox.Text = "Samuel Oppong"
        MajorTextBox.Text = "Computer Science"
    End Sub

    Private Sub ResetButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetButton.Click
        'Reset the form by clearing the TextBox controls
        NameTextBox.Clear()
        MajorTextBox.Clear()
    End Sub

    Private Sub ExitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitButton.Click
        'Exit the application by closing it
        Me.Close()
    End Sub

    ' Draw the current form onto the print document
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim bmp As New Bitmap(Me.Width, Me.Height)
        Me.DrawToBitmap(bmp, New Rectangle(0, 0, Me.Width, Me.Height))
        e.Graphics.DrawImage(bmp, 0, 0)
    End Sub

    Private Sub PrintButton_Click(sender As Object, e As EventArgs) Handles PrintButton.Click
        PrintPreviewDialog1.ShowDialog()
    End Sub



    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
End Class
