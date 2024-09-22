Public Class DeterminantForm
    Dim matrice() As String = {"2x2 Matrix", "3x3 Matrix"}
    Private Sub DeterminantForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        matrixTypeComboBox.DataSource = matrice
        m2GroupBox.Enabled = False
        m3GroupBox.Enabled = False
        resetButton.Enabled = False
    End Sub

    Private Sub acceptButton_Click(sender As Object, e As EventArgs) Handles acceptButton.Click
        If matrixTypeComboBox.Text = matrice(0) Then
            m2GroupBox.Enabled = True
        ElseIf matrixTypeComboBox.Text = matrice(1) Then
            m3GroupBox.Enabled = True
        End If
        matrixTypeComboBox.Enabled = False
        resetButton.Enabled = True
    End Sub

    Private Sub calculateButton_Click(sender As Object, e As EventArgs) Handles calculateButton.Click
        Dim A(1, 1) As Integer

        A(0, 0) = CInt(A00tb.Text)
        A(0, 1) = CInt(A01tb.Text)
        A(1, 0) = CInt(A10tb.Text)
        A(1, 1) = CInt(A11tb.Text)

        determinant2.Text = (A(0, 0) * A(1, 1)) - (A(0, 1) * A(1, 0))
    End Sub

    Private Sub resetButton_Click(sender As Object, e As EventArgs) Handles resetButton.Click
        matrixTypeComboBox.Enabled = True
        A00tb.Clear()
        A01tb.Clear()
        A10tb.Clear()
        A11tb.Clear()
        aa00tb.Clear()
        aa01tb.Clear()
        aa02tb.Clear()
        aa10tb.Clear()
        aa11tb.Clear()
        aa12tb.Clear()
        aa20tb.Clear()
        aa21tb.Clear()
        aa22tb.Clear()
        determinant2.Text = String.Empty
        determinant3.Text = String.Empty
        m2GroupBox.Enabled = False
        m3GroupBox.Enabled = False
        resetButton.Enabled = False
    End Sub

    Private Sub calButton_Click(sender As Object, e As EventArgs) Handles calButton.Click
        Dim A3(2, 2) As Integer

        A3(0, 0) = CInt(aa00tb.Text)
        A3(0, 1) = CInt(aa01tb.Text)
        A3(0, 2) = CInt(aa02tb.Text)
        A3(1, 0) = CInt(aa10tb.Text)
        A3(1, 1) = CInt(aa11tb.Text)
        A3(1, 2) = CInt(aa12tb.Text)
        A3(2, 0) = CInt(aa20tb.Text)
        A3(2, 1) = CInt(aa21tb.Text)
        A3(2, 2) = CInt(aa22tb.Text)

        Dim first As Integer = A3(0, 0) * ((A3(1, 1) * A3(2, 2)) - (A3(1, 2) * A3(2, 1)))
        Dim second As Integer = A3(0, 1) * ((A3(1, 0) * A3(2, 2)) - (A3(1, 2) * A3(2, 0)))
        Dim thirds As Integer = A3(0, 2) * ((A3(1, 0) * A3(2, 1)) - (A3(1, 1) * A3(2, 0)))

        determinant3.Text = first - second + thirds
    End Sub
End Class