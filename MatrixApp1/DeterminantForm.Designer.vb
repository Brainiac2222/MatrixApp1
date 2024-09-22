<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeterminantForm
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
        determinant2 = New Label()
        Label2 = New Label()
        calculateButton = New Button()
        Label1 = New Label()
        Plus1Label = New Label()
        A10tb = New TextBox()
        A01tb = New TextBox()
        A00tb = New TextBox()
        A11tb = New TextBox()
        m3GroupBox = New GroupBox()
        Label6 = New Label()
        determinant3 = New Label()
        calButton = New Button()
        Label4 = New Label()
        Label5 = New Label()
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
        GroupBox1.Location = New Point(12, 57)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(175, 104)
        GroupBox1.TabIndex = 3
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
        m2GroupBox.Controls.Add(determinant2)
        m2GroupBox.Controls.Add(Label2)
        m2GroupBox.Controls.Add(calculateButton)
        m2GroupBox.Controls.Add(Label1)
        m2GroupBox.Controls.Add(Plus1Label)
        m2GroupBox.Controls.Add(A10tb)
        m2GroupBox.Controls.Add(A01tb)
        m2GroupBox.Controls.Add(A00tb)
        m2GroupBox.Controls.Add(A11tb)
        m2GroupBox.Location = New Point(193, 12)
        m2GroupBox.Name = "m2GroupBox"
        m2GroupBox.Size = New Size(485, 114)
        m2GroupBox.TabIndex = 5
        m2GroupBox.TabStop = False
        m2GroupBox.Text = "2x2 Matrix"
        ' 
        ' determinant2
        ' 
        determinant2.BorderStyle = BorderStyle.Fixed3D
        determinant2.Location = New Point(242, 51)
        determinant2.Name = "determinant2"
        determinant2.Size = New Size(66, 25)
        determinant2.TabIndex = 6
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(206, 45)
        Label2.Name = "Label2"
        Label2.Size = New Size(30, 31)
        Label2.TabIndex = 12
        Label2.Text = "="
        ' 
        ' calculateButton
        ' 
        calculateButton.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        calculateButton.Location = New Point(333, 45)
        calculateButton.Name = "calculateButton"
        calculateButton.Size = New Size(94, 29)
        calculateButton.TabIndex = 11
        calculateButton.Text = "Calculate"
        calculateButton.UseVisualStyleBackColor = True
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
        ' Plus1Label
        ' 
        Plus1Label.AutoSize = True
        Plus1Label.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Plus1Label.Location = New Point(154, 45)
        Plus1Label.Name = "Plus1Label"
        Plus1Label.Size = New Size(46, 31)
        Plus1Label.TabIndex = 4
        Plus1Label.Text = "|A|"
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
        m3GroupBox.Controls.Add(Label6)
        m3GroupBox.Controls.Add(determinant3)
        m3GroupBox.Controls.Add(calButton)
        m3GroupBox.Controls.Add(Label4)
        m3GroupBox.Controls.Add(Label5)
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
        m3GroupBox.Size = New Size(485, 139)
        m3GroupBox.TabIndex = 6
        m3GroupBox.TabStop = False
        m3GroupBox.Text = "3x3 Matrix"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(262, 59)
        Label6.Name = "Label6"
        Label6.Size = New Size(30, 31)
        Label6.TabIndex = 38
        Label6.Text = "="
        ' 
        ' determinant3
        ' 
        determinant3.BorderStyle = BorderStyle.Fixed3D
        determinant3.Location = New Point(298, 64)
        determinant3.Name = "determinant3"
        determinant3.Size = New Size(76, 25)
        determinant3.TabIndex = 37
        ' 
        ' calButton
        ' 
        calButton.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        calButton.Location = New Point(380, 62)
        calButton.Name = "calButton"
        calButton.Size = New Size(94, 29)
        calButton.TabIndex = 36
        calButton.Text = "Calculate"
        calButton.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(174, 58)
        Label4.Name = "Label4"
        Label4.Size = New Size(30, 31)
        Label4.TabIndex = 35
        Label4.Text = "="
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(210, 57)
        Label5.Name = "Label5"
        Label5.Size = New Size(46, 31)
        Label5.TabIndex = 25
        Label5.Text = "|A|"
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
        resetButton.Location = New Point(12, 167)
        resetButton.Name = "resetButton"
        resetButton.Size = New Size(175, 29)
        resetButton.TabIndex = 49
        resetButton.Text = "Reset"
        resetButton.UseVisualStyleBackColor = True
        ' 
        ' DeterminantForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(703, 281)
        Controls.Add(resetButton)
        Controls.Add(m3GroupBox)
        Controls.Add(m2GroupBox)
        Controls.Add(GroupBox1)
        Name = "DeterminantForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Determinant"
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
    Friend WithEvents calculateButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Plus1Label As Label
    Friend WithEvents A10tb As TextBox
    Friend WithEvents A01tb As TextBox
    Friend WithEvents A00tb As TextBox
    Friend WithEvents A11tb As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents determinant2 As Label
    Friend WithEvents m3GroupBox As GroupBox
    Friend WithEvents determinant3 As Label
    Friend WithEvents calButton As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents aa22tb As TextBox
    Friend WithEvents aa12tb As TextBox
    Friend WithEvents aa02tb As TextBox
    Friend WithEvents aa21tb As TextBox
    Friend WithEvents aa11tb As TextBox
    Friend WithEvents aa01tb As TextBox
    Friend WithEvents aa20tb As TextBox
    Friend WithEvents aa00tb As TextBox
    Friend WithEvents aa10tb As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents resetButton As Button
End Class
