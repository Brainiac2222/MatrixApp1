<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InverseForm
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
        GroupBox1 = New GroupBox()
        acceptButton = New Button()
        matrixTypeComboBox = New ComboBox()
        m2GroupBox = New GroupBox()
        calculateButton = New Button()
        c01 = New Label()
        c10 = New Label()
        c00 = New Label()
        c11 = New Label()
        Label8 = New Label()
        b11 = New Label()
        b01 = New Label()
        b10 = New Label()
        Label7 = New Label()
        b00 = New Label()
        Label1 = New Label()
        Label2 = New Label()
        A10tb = New TextBox()
        A01tb = New TextBox()
        determinantLabel = New Label()
        A00tb = New TextBox()
        A11tb = New TextBox()
        m3GroupBox = New GroupBox()
        e20 = New Label()
        e21 = New Label()
        e22 = New Label()
        e02 = New Label()
        e12 = New Label()
        e11 = New Label()
        e10 = New Label()
        e01 = New Label()
        e00 = New Label()
        Label17 = New Label()
        d22 = New Label()
        d21 = New Label()
        d20 = New Label()
        d12 = New Label()
        d11 = New Label()
        d10 = New Label()
        d01 = New Label()
        d02 = New Label()
        Label3 = New Label()
        Label13 = New Label()
        d00 = New Label()
        calButton = New Button()
        Label14 = New Label()
        determinant33 = New Label()
        aa22tb = New TextBox()
        aa12tb = New TextBox()
        aa02tb = New TextBox()
        aa21tb = New TextBox()
        aa11tb = New TextBox()
        aa01tb = New TextBox()
        aa20tb = New TextBox()
        aa00tb = New TextBox()
        aa10tb = New TextBox()
        resetButton = New Button()
        GroupBox1.SuspendLayout()
        m2GroupBox.SuspendLayout()
        m3GroupBox.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(acceptButton)
        GroupBox1.Controls.Add(matrixTypeComboBox)
        GroupBox1.Location = New Point(12, 110)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(175, 104)
        GroupBox1.TabIndex = 4
        GroupBox1.TabStop = False
        GroupBox1.Text = "Select Matrix Type"
        ' 
        ' acceptButton
        ' 
        acceptButton.Location = New Point(37, 60)
        acceptButton.Name = "acceptButton"
        acceptButton.Size = New Size(94, 29)
        acceptButton.TabIndex = 1
        acceptButton.Text = "Accept"
        acceptButton.UseVisualStyleBackColor = True
        ' 
        ' matrixTypeComboBox
        ' 
        matrixTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        matrixTypeComboBox.FormattingEnabled = True
        matrixTypeComboBox.Location = New Point(11, 26)
        matrixTypeComboBox.Name = "matrixTypeComboBox"
        matrixTypeComboBox.Size = New Size(151, 28)
        matrixTypeComboBox.TabIndex = 0
        ' 
        ' m2GroupBox
        ' 
        m2GroupBox.Controls.Add(calculateButton)
        m2GroupBox.Controls.Add(c01)
        m2GroupBox.Controls.Add(c10)
        m2GroupBox.Controls.Add(c00)
        m2GroupBox.Controls.Add(c11)
        m2GroupBox.Controls.Add(Label8)
        m2GroupBox.Controls.Add(b11)
        m2GroupBox.Controls.Add(b01)
        m2GroupBox.Controls.Add(b10)
        m2GroupBox.Controls.Add(Label7)
        m2GroupBox.Controls.Add(b00)
        m2GroupBox.Controls.Add(Label1)
        m2GroupBox.Controls.Add(Label2)
        m2GroupBox.Controls.Add(A10tb)
        m2GroupBox.Controls.Add(A01tb)
        m2GroupBox.Controls.Add(determinantLabel)
        m2GroupBox.Controls.Add(A00tb)
        m2GroupBox.Controls.Add(A11tb)
        m2GroupBox.Location = New Point(193, 12)
        m2GroupBox.Name = "m2GroupBox"
        m2GroupBox.Size = New Size(684, 114)
        m2GroupBox.TabIndex = 6
        m2GroupBox.TabStop = False
        m2GroupBox.Text = "2x2 Matrix"
        ' 
        ' calculateButton
        ' 
        calculateButton.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        calculateButton.Location = New Point(565, 45)
        calculateButton.Name = "calculateButton"
        calculateButton.Size = New Size(94, 29)
        calculateButton.TabIndex = 11
        calculateButton.Text = "Calculate"
        calculateButton.UseVisualStyleBackColor = True
        ' 
        ' c01
        ' 
        c01.BorderStyle = BorderStyle.Fixed3D
        c01.Location = New Point(472, 28)
        c01.Name = "c01"
        c01.Size = New Size(66, 25)
        c01.TabIndex = 21
        ' 
        ' c10
        ' 
        c10.BorderStyle = BorderStyle.Fixed3D
        c10.Location = New Point(400, 69)
        c10.Name = "c10"
        c10.Size = New Size(66, 25)
        c10.TabIndex = 20
        ' 
        ' c00
        ' 
        c00.BorderStyle = BorderStyle.Fixed3D
        c00.Location = New Point(400, 28)
        c00.Name = "c00"
        c00.Size = New Size(66, 25)
        c00.TabIndex = 19
        ' 
        ' c11
        ' 
        c11.BorderStyle = BorderStyle.Fixed3D
        c11.Location = New Point(472, 70)
        c11.Name = "c11"
        c11.Size = New Size(66, 25)
        c11.TabIndex = 18
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(364, 45)
        Label8.Name = "Label8"
        Label8.Size = New Size(30, 31)
        Label8.TabIndex = 17
        Label8.Text = "="
        ' 
        ' b11
        ' 
        b11.BorderStyle = BorderStyle.Fixed3D
        b11.Location = New Point(292, 69)
        b11.Name = "b11"
        b11.Size = New Size(66, 25)
        b11.TabIndex = 12
        ' 
        ' b01
        ' 
        b01.BorderStyle = BorderStyle.Fixed3D
        b01.Location = New Point(292, 28)
        b01.Name = "b01"
        b01.Size = New Size(66, 25)
        b01.TabIndex = 13
        ' 
        ' b10
        ' 
        b10.BorderStyle = BorderStyle.Fixed3D
        b10.Location = New Point(220, 70)
        b10.Name = "b10"
        b10.Size = New Size(66, 25)
        b10.TabIndex = 14
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(187, 45)
        Label7.Name = "Label7"
        Label7.Size = New Size(27, 31)
        Label7.TabIndex = 16
        Label7.Text = "x"
        ' 
        ' b00
        ' 
        b00.BorderStyle = BorderStyle.Fixed3D
        b00.Location = New Point(220, 28)
        b00.Name = "b00"
        b00.Size = New Size(66, 25)
        b00.TabIndex = 15
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(118, 45)
        Label1.Name = "Label1"
        Label1.Size = New Size(30, 31)
        Label1.TabIndex = 0
        Label1.Text = "="
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(154, 26)
        Label2.Name = "Label2"
        Label2.Size = New Size(27, 31)
        Label2.TabIndex = 12
        Label2.Text = "1"
        ' 
        ' A10tb
        ' 
        A10tb.Location = New Point(6, 67)
        A10tb.Name = "A10tb"
        A10tb.Size = New Size(50, 27)
        A10tb.TabIndex = 3
        ' 
        ' A01tb
        ' 
        A01tb.Location = New Point(62, 26)
        A01tb.Name = "A01tb"
        A01tb.Size = New Size(50, 27)
        A01tb.TabIndex = 2
        ' 
        ' determinantLabel
        ' 
        determinantLabel.BorderStyle = BorderStyle.Fixed3D
        determinantLabel.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        determinantLabel.Location = New Point(154, 67)
        determinantLabel.Name = "determinantLabel"
        determinantLabel.Size = New Size(27, 31)
        determinantLabel.TabIndex = 4
        ' 
        ' A00tb
        ' 
        A00tb.Location = New Point(6, 26)
        A00tb.Name = "A00tb"
        A00tb.Size = New Size(50, 27)
        A00tb.TabIndex = 1
        ' 
        ' A11tb
        ' 
        A11tb.Location = New Point(62, 67)
        A11tb.Name = "A11tb"
        A11tb.Size = New Size(50, 27)
        A11tb.TabIndex = 0
        ' 
        ' m3GroupBox
        ' 
        m3GroupBox.Controls.Add(e20)
        m3GroupBox.Controls.Add(e21)
        m3GroupBox.Controls.Add(e22)
        m3GroupBox.Controls.Add(e02)
        m3GroupBox.Controls.Add(e12)
        m3GroupBox.Controls.Add(e11)
        m3GroupBox.Controls.Add(e10)
        m3GroupBox.Controls.Add(e01)
        m3GroupBox.Controls.Add(e00)
        m3GroupBox.Controls.Add(Label17)
        m3GroupBox.Controls.Add(d22)
        m3GroupBox.Controls.Add(d21)
        m3GroupBox.Controls.Add(d20)
        m3GroupBox.Controls.Add(d12)
        m3GroupBox.Controls.Add(d11)
        m3GroupBox.Controls.Add(d10)
        m3GroupBox.Controls.Add(d01)
        m3GroupBox.Controls.Add(d02)
        m3GroupBox.Controls.Add(Label3)
        m3GroupBox.Controls.Add(Label13)
        m3GroupBox.Controls.Add(d00)
        m3GroupBox.Controls.Add(calButton)
        m3GroupBox.Controls.Add(Label14)
        m3GroupBox.Controls.Add(determinant33)
        m3GroupBox.Controls.Add(aa22tb)
        m3GroupBox.Controls.Add(aa12tb)
        m3GroupBox.Controls.Add(aa02tb)
        m3GroupBox.Controls.Add(aa21tb)
        m3GroupBox.Controls.Add(aa11tb)
        m3GroupBox.Controls.Add(aa01tb)
        m3GroupBox.Controls.Add(aa20tb)
        m3GroupBox.Controls.Add(aa00tb)
        m3GroupBox.Controls.Add(aa10tb)
        m3GroupBox.Location = New Point(193, 132)
        m3GroupBox.Name = "m3GroupBox"
        m3GroupBox.Size = New Size(684, 306)
        m3GroupBox.TabIndex = 7
        m3GroupBox.TabStop = False
        m3GroupBox.Text = "3x3 Matrix"
        ' 
        ' e20
        ' 
        e20.BorderStyle = BorderStyle.Fixed3D
        e20.Location = New Point(220, 243)
        e20.Name = "e20"
        e20.Size = New Size(76, 25)
        e20.TabIndex = 57
        ' 
        ' e21
        ' 
        e21.BorderStyle = BorderStyle.Fixed3D
        e21.Location = New Point(302, 243)
        e21.Name = "e21"
        e21.Size = New Size(76, 25)
        e21.TabIndex = 56
        ' 
        ' e22
        ' 
        e22.BorderStyle = BorderStyle.Fixed3D
        e22.Location = New Point(384, 243)
        e22.Name = "e22"
        e22.Size = New Size(76, 25)
        e22.TabIndex = 55
        ' 
        ' e02
        ' 
        e02.BorderStyle = BorderStyle.Fixed3D
        e02.Location = New Point(384, 173)
        e02.Name = "e02"
        e02.Size = New Size(76, 25)
        e02.TabIndex = 54
        ' 
        ' e12
        ' 
        e12.BorderStyle = BorderStyle.Fixed3D
        e12.Location = New Point(384, 207)
        e12.Name = "e12"
        e12.Size = New Size(76, 25)
        e12.TabIndex = 53
        ' 
        ' e11
        ' 
        e11.BorderStyle = BorderStyle.Fixed3D
        e11.Location = New Point(302, 207)
        e11.Name = "e11"
        e11.Size = New Size(76, 25)
        e11.TabIndex = 52
        ' 
        ' e10
        ' 
        e10.BorderStyle = BorderStyle.Fixed3D
        e10.Location = New Point(220, 207)
        e10.Name = "e10"
        e10.Size = New Size(76, 25)
        e10.TabIndex = 51
        ' 
        ' e01
        ' 
        e01.BorderStyle = BorderStyle.Fixed3D
        e01.Location = New Point(302, 173)
        e01.Name = "e01"
        e01.Size = New Size(76, 25)
        e01.TabIndex = 50
        ' 
        ' e00
        ' 
        e00.BorderStyle = BorderStyle.Fixed3D
        e00.Location = New Point(220, 173)
        e00.Name = "e00"
        e00.Size = New Size(76, 25)
        e00.TabIndex = 49
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label17.Location = New Point(117, 190)
        Label17.Name = "Label17"
        Label17.Size = New Size(51, 54)
        Label17.TabIndex = 48
        Label17.Text = "="
        ' 
        ' d22
        ' 
        d22.BorderStyle = BorderStyle.Fixed3D
        d22.Location = New Point(472, 88)
        d22.Name = "d22"
        d22.Size = New Size(76, 25)
        d22.TabIndex = 47
        ' 
        ' d21
        ' 
        d21.BorderStyle = BorderStyle.Fixed3D
        d21.Location = New Point(390, 88)
        d21.Name = "d21"
        d21.Size = New Size(76, 25)
        d21.TabIndex = 46
        ' 
        ' d20
        ' 
        d20.BorderStyle = BorderStyle.Fixed3D
        d20.Location = New Point(308, 88)
        d20.Name = "d20"
        d20.Size = New Size(76, 25)
        d20.TabIndex = 45
        ' 
        ' d12
        ' 
        d12.BorderStyle = BorderStyle.Fixed3D
        d12.Location = New Point(472, 57)
        d12.Name = "d12"
        d12.Size = New Size(76, 25)
        d12.TabIndex = 44
        ' 
        ' d11
        ' 
        d11.BorderStyle = BorderStyle.Fixed3D
        d11.Location = New Point(390, 57)
        d11.Name = "d11"
        d11.Size = New Size(76, 25)
        d11.TabIndex = 43
        ' 
        ' d10
        ' 
        d10.BorderStyle = BorderStyle.Fixed3D
        d10.Location = New Point(308, 59)
        d10.Name = "d10"
        d10.Size = New Size(76, 25)
        d10.TabIndex = 42
        ' 
        ' d01
        ' 
        d01.BorderStyle = BorderStyle.Fixed3D
        d01.Location = New Point(390, 26)
        d01.Name = "d01"
        d01.Size = New Size(76, 25)
        d01.TabIndex = 41
        ' 
        ' d02
        ' 
        d02.BorderStyle = BorderStyle.Fixed3D
        d02.Location = New Point(472, 28)
        d02.Name = "d02"
        d02.Size = New Size(76, 25)
        d02.TabIndex = 40
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(220, 26)
        Label3.Name = "Label3"
        Label3.Size = New Size(27, 31)
        Label3.TabIndex = 39
        Label3.Text = "1"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.Location = New Point(259, 49)
        Label13.Name = "Label13"
        Label13.Size = New Size(27, 31)
        Label13.TabIndex = 38
        Label13.Text = "x"
        ' 
        ' d00
        ' 
        d00.BorderStyle = BorderStyle.Fixed3D
        d00.Location = New Point(308, 26)
        d00.Name = "d00"
        d00.Size = New Size(76, 25)
        d00.TabIndex = 37
        ' 
        ' calButton
        ' 
        calButton.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        calButton.Location = New Point(565, 133)
        calButton.Name = "calButton"
        calButton.Size = New Size(94, 29)
        calButton.TabIndex = 36
        calButton.Text = "Calculate"
        calButton.UseVisualStyleBackColor = True
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label14.Location = New Point(174, 58)
        Label14.Name = "Label14"
        Label14.Size = New Size(30, 31)
        Label14.TabIndex = 35
        Label14.Text = "="
        ' 
        ' determinant33
        ' 
        determinant33.BorderStyle = BorderStyle.Fixed3D
        determinant33.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        determinant33.Location = New Point(210, 64)
        determinant33.Name = "determinant33"
        determinant33.Size = New Size(43, 39)
        determinant33.TabIndex = 25
        ' 
        ' aa22tb
        ' 
        aa22tb.Location = New Point(118, 92)
        aa22tb.Name = "aa22tb"
        aa22tb.Size = New Size(50, 27)
        aa22tb.TabIndex = 17
        ' 
        ' aa12tb
        ' 
        aa12tb.Location = New Point(118, 59)
        aa12tb.Name = "aa12tb"
        aa12tb.Size = New Size(50, 27)
        aa12tb.TabIndex = 18
        ' 
        ' aa02tb
        ' 
        aa02tb.Location = New Point(118, 26)
        aa02tb.Name = "aa02tb"
        aa02tb.Size = New Size(50, 27)
        aa02tb.TabIndex = 19
        ' 
        ' aa21tb
        ' 
        aa21tb.Location = New Point(62, 92)
        aa21tb.Name = "aa21tb"
        aa21tb.Size = New Size(50, 27)
        aa21tb.TabIndex = 20
        ' 
        ' aa11tb
        ' 
        aa11tb.Location = New Point(62, 59)
        aa11tb.Name = "aa11tb"
        aa11tb.Size = New Size(50, 27)
        aa11tb.TabIndex = 21
        ' 
        ' aa01tb
        ' 
        aa01tb.Location = New Point(62, 26)
        aa01tb.Name = "aa01tb"
        aa01tb.Size = New Size(50, 27)
        aa01tb.TabIndex = 22
        ' 
        ' aa20tb
        ' 
        aa20tb.Location = New Point(6, 92)
        aa20tb.Name = "aa20tb"
        aa20tb.Size = New Size(50, 27)
        aa20tb.TabIndex = 23
        ' 
        ' aa00tb
        ' 
        aa00tb.Location = New Point(6, 26)
        aa00tb.Name = "aa00tb"
        aa00tb.Size = New Size(50, 27)
        aa00tb.TabIndex = 24
        ' 
        ' aa10tb
        ' 
        aa10tb.Location = New Point(6, 59)
        aa10tb.Name = "aa10tb"
        aa10tb.Size = New Size(50, 27)
        aa10tb.TabIndex = 16
        ' 
        ' resetButton
        ' 
        resetButton.Location = New Point(12, 220)
        resetButton.Name = "resetButton"
        resetButton.Size = New Size(175, 29)
        resetButton.TabIndex = 50
        resetButton.Text = "Reset"
        resetButton.UseVisualStyleBackColor = True
        ' 
        ' InverseForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(891, 450)
        Controls.Add(resetButton)
        Controls.Add(m3GroupBox)
        Controls.Add(m2GroupBox)
        Controls.Add(GroupBox1)
        Name = "InverseForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Inverse"
        GroupBox1.ResumeLayout(False)
        m2GroupBox.ResumeLayout(False)
        m2GroupBox.PerformLayout()
        m3GroupBox.ResumeLayout(False)
        m3GroupBox.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents acceptButton As Button
    Friend WithEvents matrixTypeComboBox As ComboBox
    Friend WithEvents m2GroupBox As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents A10tb As TextBox
    Friend WithEvents A01tb As TextBox
    Friend WithEvents A00tb As TextBox
    Friend WithEvents A11tb As TextBox
    Friend WithEvents calculateButton As Button
    Friend WithEvents determinantLabel As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents b00 As Label
    Friend WithEvents b11 As Label
    Friend WithEvents b01 As Label
    Friend WithEvents b10 As Label
    Friend WithEvents c01 As Label
    Friend WithEvents c10 As Label
    Friend WithEvents c00 As Label
    Friend WithEvents c11 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents m3GroupBox As GroupBox
    Friend WithEvents Label13 As Label
    Friend WithEvents d00 As Label
    Friend WithEvents calButton As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents determinant33 As Label
    Friend WithEvents aa22tb As TextBox
    Friend WithEvents aa12tb As TextBox
    Friend WithEvents aa02tb As TextBox
    Friend WithEvents aa21tb As TextBox
    Friend WithEvents aa11tb As TextBox
    Friend WithEvents aa01tb As TextBox
    Friend WithEvents aa20tb As TextBox
    Friend WithEvents aa00tb As TextBox
    Friend WithEvents aa10tb As TextBox
    Friend WithEvents resetButton As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents e20 As Label
    Friend WithEvents e21 As Label
    Friend WithEvents e22 As Label
    Friend WithEvents e02 As Label
    Friend WithEvents e12 As Label
    Friend WithEvents e11 As Label
    Friend WithEvents e10 As Label
    Friend WithEvents e01 As Label
    Friend WithEvents e00 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents d22 As Label
    Friend WithEvents d21 As Label
    Friend WithEvents d20 As Label
    Friend WithEvents d12 As Label
    Friend WithEvents d11 As Label
    Friend WithEvents d10 As Label
    Friend WithEvents d01 As Label
    Friend WithEvents d02 As Label
End Class
