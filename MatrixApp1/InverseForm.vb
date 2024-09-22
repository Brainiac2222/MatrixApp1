Public Class InverseForm
    Dim matrice() As String = {"2x2 Matrix", "3x3 Matrix"}
    Private Sub InverseForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        Dim determinant As Integer = (A(0, 0) * A(1, 1)) - (A(0, 1) * A(1, 0))
        determinantLabel.Text = determinant
        If determinant = 0 Then
            MessageBox.Show("Determinant equals 0,Therefore the inverse cannot be calculated for",
                            "Inverse cannot be calculated",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim inverseDeterminant As Double = 1 / determinant
            b00.Text = A(1, 1)
            b01.Text = (-1 * A(0, 1))
            b10.Text = (-1 * A(1, 0))
            b11.Text = A(0, 0)

            c00.Text = String.Format("{0:F}", inverseDeterminant * CInt(b00.Text))
            c01.Text = String.Format("{0:F}", inverseDeterminant * CInt(b01.Text))
            c10.Text = String.Format("{0:F}", inverseDeterminant * CInt(b10.Text))
            c11.Text = String.Format("{0:F}", inverseDeterminant * CInt(b11.Text))
        End If
    End Sub

    Private Sub calButton_Click(sender As Object, e As EventArgs) Handles calButton.Click
        Dim A3(2, 2) As Integer
        Dim B3(2, 2) As Integer
        Dim C3(2, 2) As Integer
        Dim D3(2, 2) As Double

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

        Dim determinant As Integer = first - second + thirds
        determinant33.Text = determinant
        If determinant = 0 Then
            MessageBox.Show("Determinant equals 0,Therefore the inverse cannot be calculated for",
                           "Inverse cannot be calculated",
                           MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim inverseDeterminant As Double = 1 / determinant
            B3(0, 0) = (A3(1, 1) * A3(2, 2)) - (A3(1, 2) * A3(2, 1))
            B3(0, 1) = (-1) * ((A3(1, 0) * A3(2, 2)) - (A3(1, 2) * A3(2, 0)))
            B3(0, 2) = (A3(1, 0) * A3(2, 1)) - (A3(1, 1) * A3(2, 0))
            B3(1, 0) = (-1) * ((A3(0, 1) * A3(2, 2)) - (A3(0, 2) * A3(2, 1)))
            B3(1, 1) = (A3(0, 0) * A3(2, 2)) - (A3(0, 2) * A3(2, 0))
            B3(1, 2) = (-1) * ((A3(0, 0) * A3(2, 1)) - (A3(0, 1) * A3(2, 0)))
            B3(2, 0) = (A3(0, 1) * A3(1, 2)) - (A3(0, 2) * A3(1, 1))
            B3(2, 1) = (-1) * ((A3(0, 0) * A3(1, 2)) - (A3(0, 2) * A3(1, 0)))
            B3(2, 2) = (A3(0, 0) * A3(1, 1)) - (A3(0, 1) * A3(1, 0))

            C3(0, 0) = B3(0, 0)
            C3(0, 1) = B3(1, 0)
            C3(0, 2) = B3(2, 0)
            C3(1, 0) = B3(0, 1)
            C3(1, 1) = B3(1, 1)
            C3(1, 2) = B3(2, 1)
            C3(2, 0) = B3(0, 2)
            C3(2, 1) = B3(1, 2)
            C3(2, 2) = B3(2, 2)


            For row = 0 To C3.GetUpperBound(0)
                For column = 0 To C3.GetUpperBound(1)
                    D3(row, column) = CDbl(inverseDeterminant * C3(row, column))
                Next
            Next

            d00.Text = C3(0, 0)
            d01.Text = C3(0, 1)
            d02.Text = C3(0, 2)
            d10.Text = C3(1, 0)
            d11.Text = C3(1, 1)
            d12.Text = C3(1, 2)
            d20.Text = C3(2, 0)
            d21.Text = C3(2, 1)
            d22.Text = C3(2, 2)

            e00.Text = D3(0, 0)
            e01.Text = D3(0, 1)
            e02.Text = D3(0, 2)
            e10.Text = D3(1, 0)
            e11.Text = D3(1, 1)
            e12.Text = D3(1, 2)
            e20.Text = D3(2, 0)
            e21.Text = D3(2, 1)
            e22.Text = D3(2, 2)

        End If
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
        d00.Text = String.Empty
        d01.Text = String.Empty
        d02.Text = String.Empty
        d10.Text = String.Empty
        d11.Text = String.Empty
        d12.Text = String.Empty
        d20.Text = String.Empty
        d21.Text = String.Empty
        d22.Text = String.Empty
        e00.Text = String.Empty
        e01.Text = String.Empty
        e02.Text = String.Empty
        e10.Text = String.Empty
        e11.Text = String.Empty
        e12.Text = String.Empty
        e20.Text = String.Empty
        e21.Text = String.Empty
        e22.Text = String.Empty
        b00.Text = String.Empty
        b01.Text = String.Empty
        b10.Text = String.Empty
        b11.Text = String.Empty
        c00.Text = String.Empty
        c01.Text = String.Empty
        c10.Text = String.Empty
        c11.Text = String.Empty
        determinantLabel.Text = String.Empty
        determinant33.Text = String.Empty
        m2GroupBox.Enabled = False
        m3GroupBox.Enabled = False
        resetButton.Enabled = False
    End Sub
End Class