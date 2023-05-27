<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PatientDiagnosisViewInformation
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
        Me.PatientDiagnosisView = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.patIdTxt = New System.Windows.Forms.TextBox()
        Me.patLNameTxt = New System.Windows.Forms.TextBox()
        Me.diagnoTxt = New System.Windows.Forms.TextBox()
        Me.diagDescTxt = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.applyDateTxt = New System.Windows.Forms.TextBox()
        CType(Me.PatientDiagnosisView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PatientDiagnosisView
        '
        Me.PatientDiagnosisView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PatientDiagnosisView.Location = New System.Drawing.Point(12, 87)
        Me.PatientDiagnosisView.Name = "PatientDiagnosisView"
        Me.PatientDiagnosisView.Size = New System.Drawing.Size(411, 288)
        Me.PatientDiagnosisView.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(187, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(480, 57)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Patient Diagnosis Record"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 391)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Exit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(543, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 45)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Details"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(604, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(194, 25)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Patient Last Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(436, 145)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 25)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Patient ID:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(669, 224)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 25)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Diagnosis"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(429, 224)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(146, 25)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Diagnosis No:"
        '
        'patIdTxt
        '
        Me.patIdTxt.Enabled = False
        Me.patIdTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.patIdTxt.Location = New System.Drawing.Point(429, 181)
        Me.patIdTxt.Name = "patIdTxt"
        Me.patIdTxt.Size = New System.Drawing.Size(118, 31)
        Me.patIdTxt.TabIndex = 8
        '
        'patLNameTxt
        '
        Me.patLNameTxt.Enabled = False
        Me.patLNameTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.patLNameTxt.Location = New System.Drawing.Point(651, 181)
        Me.patLNameTxt.Name = "patLNameTxt"
        Me.patLNameTxt.Size = New System.Drawing.Size(125, 31)
        Me.patLNameTxt.TabIndex = 9
        '
        'diagnoTxt
        '
        Me.diagnoTxt.Enabled = False
        Me.diagnoTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.diagnoTxt.Location = New System.Drawing.Point(429, 264)
        Me.diagnoTxt.Name = "diagnoTxt"
        Me.diagnoTxt.Size = New System.Drawing.Size(127, 31)
        Me.diagnoTxt.TabIndex = 10
        '
        'diagDescTxt
        '
        Me.diagDescTxt.Enabled = False
        Me.diagDescTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.diagDescTxt.Location = New System.Drawing.Point(642, 264)
        Me.diagDescTxt.Name = "diagDescTxt"
        Me.diagDescTxt.Size = New System.Drawing.Size(156, 31)
        Me.diagDescTxt.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(541, 308)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(135, 25)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Applied Date"
        '
        'applyDateTxt
        '
        Me.applyDateTxt.Enabled = False
        Me.applyDateTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.applyDateTxt.Location = New System.Drawing.Point(521, 344)
        Me.applyDateTxt.Name = "applyDateTxt"
        Me.applyDateTxt.Size = New System.Drawing.Size(176, 31)
        Me.applyDateTxt.TabIndex = 13
        '
        'PatientDiagnosisViewInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(819, 426)
        Me.Controls.Add(Me.applyDateTxt)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.diagDescTxt)
        Me.Controls.Add(Me.diagnoTxt)
        Me.Controls.Add(Me.patLNameTxt)
        Me.Controls.Add(Me.patIdTxt)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PatientDiagnosisView)
        Me.Name = "PatientDiagnosisViewInformation"
        Me.Text = "PatientDiagnosisViewInformation"
        CType(Me.PatientDiagnosisView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PatientDiagnosisView As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents patIdTxt As TextBox
    Friend WithEvents patLNameTxt As TextBox
    Friend WithEvents diagnoTxt As TextBox
    Friend WithEvents diagDescTxt As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents applyDateTxt As TextBox
End Class
