Public Class MultiplicationForm
    Dim matrice() As String = {"2x2 Matrix", "3x3 Matrix"}
    Private Sub MultiplicationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        Dim B(1, 1) As Integer

        A(0, 0) = CInt(A00tb.Text)
        A(0, 1) = CInt(A01tb.Text)
        A(1, 0) = CInt(A10tb.Text)
        A(1, 1) = CInt(A11tb.Text)

        B(0, 0) = CInt(B00tb.Text)
        B(0, 1) = CInt(B01tb.Text)
        B(1, 0) = CInt(B10tb.Text)
        B(1, 1) = CInt(B11tb.Text)

        C00lb.Text = (A(0, 0) * B(0, 0)) + (A(0, 1) * B(1, 0))
        C01lb.Text = (A(0, 0) * B(0, 1)) + (A(0, 1) * B(1, 1))
        C10lb.Text = (A(1, 0) * B(0, 0)) + (A(1, 1) * B(1, 0))
        C11lb.Text = (A(1, 0) * B(0, 1)) + (A(1, 1) * B(1, 1))
    End Sub

    Private Sub calButton_Click(sender As Object, e As EventArgs) Handles calButton.Click
        Dim A3(2, 2) As Integer
        Dim B3(2, 2) As Integer

        A3(0, 0) = CInt(aa00tb.Text)
        A3(0, 1) = CInt(aa01tb.Text)
        A3(0, 2) = CInt(aa02tb.Text)
        A3(1, 0) = CInt(aa10tb.Text)
        A3(1, 1) = CInt(aa11tb.Text)
        A3(1, 2) = CInt(aa12tb.Text)
        A3(2, 0) = CInt(aa20tb.Text)
        A3(2, 1) = CInt(aa21tb.Text)
        A3(2, 2) = CInt(aa22tb.Text)

        B3(0, 0) = CInt(bb00tb.Text)
        B3(0, 1) = CInt(bb01.Text)
        B3(0, 2) = CInt(bb02.Text)
        B3(1, 0) = CInt(bb10.Text)
        B3(1, 1) = CInt(bb11.Text)
        B3(1, 2) = CInt(bb12.Text)
        B3(2, 0) = CInt(bb20.Text)
        B3(2, 1) = CInt(bb21.Text)
        B3(2, 2) = CInt(bb22.Text)

        cc00.Text = (A3(0, 0) * B3(0, 0)) + (A3(0, 1) * B3(1, 0)) + (A3(0, 2) * B3(2, 0))
        cc01.Text = (A3(0, 0) * B3(0, 1)) + (A3(0, 1) * B3(1, 1)) + (A3(0, 2) * B3(2, 1))
        cc02.Text = (A3(0, 0) * B3(0, 2)) + (A3(0, 1) * B3(1, 2)) + (A3(0, 2) * B3(2, 2))
        cc10.Text = (A3(1, 0) * B3(0, 0)) + (A3(1, 1) * B3(1, 0)) + (A3(1, 2) * B3(2, 0))
        cc11.Text = (A3(1, 0) * B3(0, 1)) + (A3(1, 1) * B3(1, 1)) + (A3(1, 2) * B3(2, 1))
        cc12.Text = (A3(1, 0) * B3(0, 2)) + (A3(1, 1) * B3(1, 2)) + (A3(1, 2) * B3(2, 2))
        cc20.Text = (A3(2, 0) * B3(0, 0)) + (A3(2, 1) * B3(1, 0)) + (A3(2, 2) * B3(2, 0))
        cc21.Text = (A3(2, 0) * B3(0, 1)) + (A3(2, 1) * B3(1, 1)) + (A3(2, 2) * B3(2, 1))
        cc22.Text = (A3(2, 0) * B3(0, 2)) + (A3(2, 1) * B3(1, 2)) + (A3(2, 2) * B3(2, 2))
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
        bb00tb.Clear()
        bb01.Clear()
        bb02.Clear()
        bb10.Clear()
        bb11.Clear()
        bb12.Clear()
        bb20.Clear()
        bb21.Clear()
        bb22.Clear()
        B00tb.Clear()
        B01tb.Clear()
        B10tb.Clear()
        B11tb.Clear()
        m2GroupBox.Enabled = False
        m3GroupBox.Enabled = False
        resetButton.Enabled = False
    End Sub
End Class