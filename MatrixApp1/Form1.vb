Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim currentDatetime As DateTime = DateTime.Now
        dateLabel.Text = currentDatetime.ToString("D")
        timeLabel.Text = currentDatetime.ToString("T")
    End Sub

    Private Sub additionButtton_Click(sender As Object, e As EventArgs) Handles additionButtton.Click
        Dim addition As New AdditionForm
        addition.MdiParent = Me
        addition.Show()
    End Sub

    Private Sub subtractionButton_Click(sender As Object, e As EventArgs) Handles subtractionButton.Click
        Dim subtraction As New SubtractionForm
        subtraction.MdiParent = Me
        subtraction.Show()
    End Sub

    Private Sub multiplicationButton_Click(sender As Object, e As EventArgs) Handles multiplicationButton.Click
        Dim multiple As New MultiplicationForm
        multiple.MdiParent = Me
        multiple.Show()
    End Sub

    Private Sub determinantButton_Click(sender As Object, e As EventArgs) Handles determinantButton.Click
        Dim deter As New DeterminantForm
        deter.MdiParent = Me
        deter.Show()
    End Sub

    Private Sub inverseButton_Click(sender As Object, e As EventArgs) Handles inverseButton.Click
        Dim inverse As New InverseForm
        inverse.MdiParent = Me
        inverse.Show()
    End Sub
End Class
