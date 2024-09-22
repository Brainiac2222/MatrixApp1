<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SubtractionForm
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
        C00lb = New Label()
        C10lb = New Label()
        C01lb = New Label()
        C11lb = New Label()
        calculateButton = New Button()
        Label1 = New Label()
        B11tb = New TextBox()
        B01tb = New TextBox()
        B10tb = New TextBox()
        B00tb = New TextBox()
        Plus1Label = New Label()
        A10tb = New TextBox()
        A01tb = New TextBox()
        A00tb = New TextBox()
        A11tb = New TextBox()
        m3GroupBox = New GroupBox()
        cc22 = New Label()
        cc02 = New Label()
        cc20 = New Label()
        cc00 = New Label()
        cc10 = New Label()
        cc01 = New Label()
        cc11 = New Label()
        cc21 = New Label()
        cc12 = New Label()
        calButton = New Button()
        Label3 = New Label()
        bb02 = New TextBox()
        bb12 = New TextBox()
        bb01 = New TextBox()
        bb21 = New TextBox()
        bb22 = New TextBox()
        bb20 = New TextBox()
        bb11 = New TextBox()
        bb00tb = New TextBox()
        bb10 = New TextBox()
        Label2 = New Label()
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
        GroupBox1.Location = New Point(12, 131)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(175, 104)
        GroupBox1.TabIndex = 1
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
        m2GroupBox.Controls.Add(C00lb)
        m2GroupBox.Controls.Add(C10lb)
        m2GroupBox.Controls.Add(C01lb)
        m2GroupBox.Controls.Add(C11lb)
        m2GroupBox.Controls.Add(calculateButton)
        m2GroupBox.Controls.Add(Label1)
        m2GroupBox.Controls.Add(B11tb)
        m2GroupBox.Controls.Add(B01tb)
        m2GroupBox.Controls.Add(B10tb)
        m2GroupBox.Controls.Add(B00tb)
        m2GroupBox.Controls.Add(Plus1Label)
        m2GroupBox.Controls.Add(A10tb)
        m2GroupBox.Controls.Add(A01tb)
        m2GroupBox.Controls.Add(A00tb)
        m2GroupBox.Controls.Add(A11tb)
        m2GroupBox.Location = New Point(193, 12)
        m2GroupBox.Name = "m2GroupBox"
        m2GroupBox.Size = New Size(530, 114)
        m2GroupBox.TabIndex = 3
        m2GroupBox.TabStop = False
        m2GroupBox.Text = "2x2 Matrix"
        ' 
        ' C00lb
        ' 
        C00lb.BorderStyle = BorderStyle.Fixed3D
        C00lb.Location = New Point(302, 28)
        C00lb.Name = "C00lb"
        C00lb.Size = New Size(50, 25)
        C00lb.TabIndex = 15
        ' 
        ' C10lb
        ' 
        C10lb.BorderStyle = BorderStyle.Fixed3D
        C10lb.Location = New Point(302, 74)
        C10lb.Name = "C10lb"
        C10lb.Size = New Size(50, 25)
        C10lb.TabIndex = 14
        ' 
        ' C01lb
        ' 
        C01lb.BorderStyle = BorderStyle.Fixed3D
        C01lb.Location = New Point(358, 28)
        C01lb.Name = "C01lb"
        C01lb.Size = New Size(50, 25)
        C01lb.TabIndex = 13
        ' 
        ' C11lb
        ' 
        C11lb.BorderStyle = BorderStyle.Fixed3D
        C11lb.Location = New Point(358, 75)
        C11lb.Name = "C11lb"
        C11lb.Size = New Size(50, 25)
        C11lb.TabIndex = 12
        ' 
        ' calculateButton
        ' 
        calculateButton.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        calculateButton.Location = New Point(414, 45)
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
        Label1.Location = New Point(266, 45)
        Label1.Name = "Label1"
        Label1.Size = New Size(30, 31)
        Label1.TabIndex = 0
        Label1.Text = "="
        ' 
        ' B11tb
        ' 
        B11tb.Location = New Point(210, 67)
        B11tb.Name = "B11tb"
        B11tb.Size = New Size(50, 27)
        B11tb.TabIndex = 3
        ' 
        ' B01tb
        ' 
        B01tb.Location = New Point(210, 26)
        B01tb.Name = "B01tb"
        B01tb.Size = New Size(50, 27)
        B01tb.TabIndex = 4
        ' 
        ' B10tb
        ' 
        B10tb.Location = New Point(154, 67)
        B10tb.Name = "B10tb"
        B10tb.Size = New Size(50, 27)
        B10tb.TabIndex = 5
        ' 
        ' B00tb
        ' 
        B00tb.Location = New Point(154, 26)
        B00tb.Name = "B00tb"
        B00tb.Size = New Size(50, 27)
        B00tb.TabIndex = 6
        ' 
        ' Plus1Label
        ' 
        Plus1Label.AutoSize = True
        Plus1Label.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Plus1Label.Location = New Point(125, 45)
        Plus1Label.Name = "Plus1Label"
        Plus1Label.Size = New Size(23, 31)
        Plus1Label.TabIndex = 4
        Plus1Label.Text = "-"
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
        m3GroupBox.Controls.Add(cc22)
        m3GroupBox.Controls.Add(cc02)
        m3GroupBox.Controls.Add(cc20)
        m3GroupBox.Controls.Add(cc00)
        m3GroupBox.Controls.Add(cc10)
        m3GroupBox.Controls.Add(cc01)
        m3GroupBox.Controls.Add(cc11)
        m3GroupBox.Controls.Add(cc21)
        m3GroupBox.Controls.Add(cc12)
        m3GroupBox.Controls.Add(calButton)
        m3GroupBox.Controls.Add(Label3)
        m3GroupBox.Controls.Add(bb02)
        m3GroupBox.Controls.Add(bb12)
        m3GroupBox.Controls.Add(bb01)
        m3GroupBox.Controls.Add(bb21)
        m3GroupBox.Controls.Add(bb22)
        m3GroupBox.Controls.Add(bb20)
        m3GroupBox.Controls.Add(bb11)
        m3GroupBox.Controls.Add(bb00tb)
        m3GroupBox.Controls.Add(bb10)
        m3GroupBox.Controls.Add(Label2)
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
        m3GroupBox.Size = New Size(530, 262)
        m3GroupBox.TabIndex = 4
        m3GroupBox.TabStop = False
        m3GroupBox.Text = "3x3 Matrix"
        ' 
        ' cc22
        ' 
        cc22.BorderStyle = BorderStyle.Fixed3D
        cc22.Location = New Point(255, 225)
        cc22.Name = "cc22"
        cc22.Size = New Size(76, 25)
        cc22.TabIndex = 45
        ' 
        ' cc02
        ' 
        cc02.BorderStyle = BorderStyle.Fixed3D
        cc02.Location = New Point(255, 146)
        cc02.Name = "cc02"
        cc02.Size = New Size(76, 25)
        cc02.TabIndex = 44
        ' 
        ' cc20
        ' 
        cc20.BorderStyle = BorderStyle.Fixed3D
        cc20.Location = New Point(62, 225)
        cc20.Name = "cc20"
        cc20.Size = New Size(66, 25)
        cc20.TabIndex = 43
        ' 
        ' cc00
        ' 
        cc00.BorderStyle = BorderStyle.Fixed3D
        cc00.Location = New Point(62, 146)
        cc00.Name = "cc00"
        cc00.Size = New Size(66, 25)
        cc00.TabIndex = 42
        ' 
        ' cc10
        ' 
        cc10.BorderStyle = BorderStyle.Fixed3D
        cc10.Location = New Point(62, 185)
        cc10.Name = "cc10"
        cc10.Size = New Size(66, 25)
        cc10.TabIndex = 41
        ' 
        ' cc01
        ' 
        cc01.BorderStyle = BorderStyle.Fixed3D
        cc01.Location = New Point(154, 146)
        cc01.Name = "cc01"
        cc01.Size = New Size(66, 25)
        cc01.TabIndex = 40
        ' 
        ' cc11
        ' 
        cc11.BorderStyle = BorderStyle.Fixed3D
        cc11.Location = New Point(154, 183)
        cc11.Name = "cc11"
        cc11.Size = New Size(66, 25)
        cc11.TabIndex = 39
        ' 
        ' cc21
        ' 
        cc21.BorderStyle = BorderStyle.Fixed3D
        cc21.Location = New Point(154, 225)
        cc21.Name = "cc21"
        cc21.Size = New Size(66, 25)
        cc21.TabIndex = 38
        ' 
        ' cc12
        ' 
        cc12.BorderStyle = BorderStyle.Fixed3D
        cc12.Location = New Point(255, 185)
        cc12.Name = "cc12"
        cc12.Size = New Size(76, 25)
        cc12.TabIndex = 37
        ' 
        ' calButton
        ' 
        calButton.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        calButton.Location = New Point(414, 57)
        calButton.Name = "calButton"
        calButton.Size = New Size(94, 29)
        calButton.TabIndex = 36
        calButton.Text = "Calculate"
        calButton.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(6, 174)
        Label3.Name = "Label3"
        Label3.Size = New Size(30, 31)
        Label3.TabIndex = 35
        Label3.Text = "="
        ' 
        ' bb02
        ' 
        bb02.Location = New Point(322, 26)
        bb02.Name = "bb02"
        bb02.Size = New Size(50, 27)
        bb02.TabIndex = 34
        ' 
        ' bb12
        ' 
        bb12.Location = New Point(322, 59)
        bb12.Name = "bb12"
        bb12.Size = New Size(50, 27)
        bb12.TabIndex = 33
        ' 
        ' bb01
        ' 
        bb01.Location = New Point(266, 26)
        bb01.Name = "bb01"
        bb01.Size = New Size(50, 27)
        bb01.TabIndex = 32
        ' 
        ' bb21
        ' 
        bb21.Location = New Point(266, 92)
        bb21.Name = "bb21"
        bb21.Size = New Size(50, 27)
        bb21.TabIndex = 31
        ' 
        ' bb22
        ' 
        bb22.Location = New Point(322, 92)
        bb22.Name = "bb22"
        bb22.Size = New Size(50, 27)
        bb22.TabIndex = 30
        ' 
        ' bb20
        ' 
        bb20.Location = New Point(210, 92)
        bb20.Name = "bb20"
        bb20.Size = New Size(50, 27)
        bb20.TabIndex = 29
        ' 
        ' bb11
        ' 
        bb11.Location = New Point(266, 59)
        bb11.Name = "bb11"
        bb11.Size = New Size(50, 27)
        bb11.TabIndex = 28
        ' 
        ' bb00tb
        ' 
        bb00tb.Location = New Point(210, 26)
        bb00tb.Name = "bb00tb"
        bb00tb.Size = New Size(50, 27)
        bb00tb.TabIndex = 27
        ' 
        ' bb10
        ' 
        bb10.Location = New Point(210, 59)
        bb10.Name = "bb10"
        bb10.Size = New Size(50, 27)
        bb10.TabIndex = 26
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(174, 59)
        Label2.Name = "Label2"
        Label2.Size = New Size(23, 31)
        Label2.TabIndex = 25
        Label2.Text = "-"
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
        resetButton.Location = New Point(12, 241)
        resetButton.Name = "resetButton"
        resetButton.Size = New Size(175, 29)
        resetButton.TabIndex = 47
        resetButton.Text = "Reset"
        resetButton.UseVisualStyleBackColor = True
        ' 
        ' SubtractionForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(742, 418)
        Controls.Add(resetButton)
        Controls.Add(m3GroupBox)
        Controls.Add(m2GroupBox)
        Controls.Add(GroupBox1)
        Name = "SubtractionForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Subtraction"
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
    Friend WithEvents C00lb As Label
    Friend WithEvents C10lb As Label
    Friend WithEvents C01lb As Label
    Friend WithEvents C11lb As Label
    Friend WithEvents calculateButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents B11tb As TextBox
    Friend WithEvents B01tb As TextBox
    Friend WithEvents B10tb As TextBox
    Friend WithEvents B00tb As TextBox
    Friend WithEvents Plus1Label As Label
    Friend WithEvents A10tb As TextBox
    Friend WithEvents A01tb As TextBox
    Friend WithEvents A00tb As TextBox
    Friend WithEvents A11tb As TextBox
    Friend WithEvents m3GroupBox As GroupBox
    Friend WithEvents cc22 As Label
    Friend WithEvents cc02 As Label
    Friend WithEvents cc20 As Label
    Friend WithEvents cc00 As Label
    Friend WithEvents cc10 As Label
    Friend WithEvents cc01 As Label
    Friend WithEvents cc11 As Label
    Friend WithEvents cc21 As Label
    Friend WithEvents cc12 As Label
    Friend WithEvents calButton As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents bb02 As TextBox
    Friend WithEvents bb12 As TextBox
    Friend WithEvents bb01 As TextBox
    Friend WithEvents bb21 As TextBox
    Friend WithEvents bb22 As TextBox
    Friend WithEvents bb20 As TextBox
    Friend WithEvents bb11 As TextBox
    Friend WithEvents bb00tb As TextBox
    Friend WithEvents bb10 As TextBox
    Friend WithEvents Label2 As Label
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
End Class
