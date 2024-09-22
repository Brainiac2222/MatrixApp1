<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        dateLabel = New Label()
        Label2 = New Label()
        Label3 = New Label()
        timeLabel = New Label()
        inverseButton = New Button()
        determinantButton = New Button()
        multiplicationButton = New Button()
        subtractionButton = New Button()
        additionButtton = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.Control
        Label1.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(236, 76)
        Label1.Name = "Label1"
        Label1.Size = New Size(292, 31)
        Label1.TabIndex = 1
        Label1.Text = "Select Matrix Operations: "
        ' 
        ' dateLabel
        ' 
        dateLabel.BackColor = SystemColors.Control
        dateLabel.BorderStyle = BorderStyle.FixedSingle
        dateLabel.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        dateLabel.Location = New Point(559, 9)
        dateLabel.Name = "dateLabel"
        dateLabel.Size = New Size(229, 25)
        dateLabel.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.BackColor = SystemColors.Control
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(503, 10)
        Label2.Name = "Label2"
        Label2.Size = New Size(50, 25)
        Label2.TabIndex = 4
        Label2.Text = "Date: "
        ' 
        ' Label3
        ' 
        Label3.BackColor = SystemColors.Control
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(503, 41)
        Label3.Name = "Label3"
        Label3.Size = New Size(50, 25)
        Label3.TabIndex = 5
        Label3.Text = "Time: "
        ' 
        ' timeLabel
        ' 
        timeLabel.BackColor = SystemColors.Control
        timeLabel.BorderStyle = BorderStyle.FixedSingle
        timeLabel.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        timeLabel.Location = New Point(559, 40)
        timeLabel.Name = "timeLabel"
        timeLabel.Size = New Size(229, 25)
        timeLabel.TabIndex = 7
        ' 
        ' inverseButton
        ' 
        inverseButton.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        inverseButton.Location = New Point(67, 447)
        inverseButton.Name = "inverseButton"
        inverseButton.Size = New Size(179, 42)
        inverseButton.TabIndex = 9
        inverseButton.Text = "Inverse"
        inverseButton.UseVisualStyleBackColor = True
        ' 
        ' determinantButton
        ' 
        determinantButton.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        determinantButton.Location = New Point(67, 357)
        determinantButton.Name = "determinantButton"
        determinantButton.Size = New Size(179, 47)
        determinantButton.TabIndex = 10
        determinantButton.Text = "Determinant"
        determinantButton.UseVisualStyleBackColor = True
        ' 
        ' multiplicationButton
        ' 
        multiplicationButton.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        multiplicationButton.Location = New Point(67, 270)
        multiplicationButton.Name = "multiplicationButton"
        multiplicationButton.Size = New Size(179, 44)
        multiplicationButton.TabIndex = 11
        multiplicationButton.Text = "Multiplication"
        multiplicationButton.UseVisualStyleBackColor = True
        ' 
        ' subtractionButton
        ' 
        subtractionButton.BackColor = SystemColors.Control
        subtractionButton.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        subtractionButton.ForeColor = SystemColors.ActiveCaptionText
        subtractionButton.Location = New Point(67, 189)
        subtractionButton.Name = "subtractionButton"
        subtractionButton.Size = New Size(179, 48)
        subtractionButton.TabIndex = 12
        subtractionButton.Text = "Subtraction"
        subtractionButton.UseVisualStyleBackColor = False
        ' 
        ' additionButtton
        ' 
        additionButtton.BackColor = SystemColors.Control
        additionButtton.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        additionButtton.ForeColor = SystemColors.ActiveCaptionText
        additionButtton.Location = New Point(67, 114)
        additionButtton.Name = "additionButtton"
        additionButtton.Size = New Size(179, 48)
        additionButtton.TabIndex = 13
        additionButtton.Text = "Addition"
        additionButtton.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        BackgroundImage = My.Resources.Resources.Animated_Matrix_Wallpaper_Widescreen
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(803, 520)
        Controls.Add(additionButtton)
        Controls.Add(subtractionButton)
        Controls.Add(multiplicationButton)
        Controls.Add(determinantButton)
        Controls.Add(inverseButton)
        Controls.Add(timeLabel)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(dateLabel)
        Controls.Add(Label1)
        ForeColor = SystemColors.ActiveCaptionText
        IsMdiContainer = True
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Matrix App"
        WindowState = FormWindowState.Maximized
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dateLabel As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents timeLabel As Label
    Friend WithEvents inverseButton As Button
    Friend WithEvents determinantButton As Button
    Friend WithEvents multiplicationButton As Button
    Friend WithEvents subtractionButton As Button
    Friend WithEvents additionButtton As Button

End Class
