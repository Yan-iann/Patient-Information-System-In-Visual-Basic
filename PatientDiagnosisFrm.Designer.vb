<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PatientDiagnosisFrm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PatientView = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.patLNameTxt = New System.Windows.Forms.TextBox()
        Me.patFNameTxt = New System.Windows.Forms.TextBox()
        Me.diagDateTxt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SubmitBTN = New System.Windows.Forms.Button()
        Me.ExitBTN = New System.Windows.Forms.Button()
        Me.ViewBTN = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.patIdSearchTxt = New System.Windows.Forms.TextBox()
        Me.DiagnosisView = New System.Windows.Forms.DataGridView()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.diagNoTxt = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.patIdTxt = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.diagnosisTxt = New System.Windows.Forms.TextBox()
        CType(Me.PatientView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiagnosisView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(521, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(259, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Diagnosis Panel"
        '
        'PatientView
        '
        Me.PatientView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PatientView.Location = New System.Drawing.Point(12, 93)
        Me.PatientView.Name = "PatientView"
        Me.PatientView.Size = New System.Drawing.Size(314, 360)
        Me.PatientView.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(78, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(161, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "List Of Patients"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(352, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Patient Last Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(352, 175)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Patient First Name:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(677, 137)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Apply Date:"
        '
        'patLNameTxt
        '
        Me.patLNameTxt.Enabled = False
        Me.patLNameTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.patLNameTxt.Location = New System.Drawing.Point(455, 119)
        Me.patLNameTxt.Name = "patLNameTxt"
        Me.patLNameTxt.Size = New System.Drawing.Size(144, 31)
        Me.patLNameTxt.TabIndex = 7
        '
        'patFNameTxt
        '
        Me.patFNameTxt.Enabled = False
        Me.patFNameTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.patFNameTxt.Location = New System.Drawing.Point(455, 168)
        Me.patFNameTxt.Name = "patFNameTxt"
        Me.patFNameTxt.Size = New System.Drawing.Size(144, 31)
        Me.patFNameTxt.TabIndex = 8
        '
        'diagDateTxt
        '
        Me.diagDateTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.diagDateTxt.Location = New System.Drawing.Point(765, 130)
        Me.diagDateTxt.Name = "diagDateTxt"
        Me.diagDateTxt.Size = New System.Drawing.Size(136, 31)
        Me.diagDateTxt.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(579, 206)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 24)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Diagnosis"
        '
        'SubmitBTN
        '
        Me.SubmitBTN.Location = New System.Drawing.Point(826, 430)
        Me.SubmitBTN.Name = "SubmitBTN"
        Me.SubmitBTN.Size = New System.Drawing.Size(75, 23)
        Me.SubmitBTN.TabIndex = 11
        Me.SubmitBTN.Text = "Apply"
        Me.SubmitBTN.UseVisualStyleBackColor = True
        '
        'ExitBTN
        '
        Me.ExitBTN.Location = New System.Drawing.Point(355, 430)
        Me.ExitBTN.Name = "ExitBTN"
        Me.ExitBTN.Size = New System.Drawing.Size(75, 23)
        Me.ExitBTN.TabIndex = 12
        Me.ExitBTN.Text = "Exit"
        Me.ExitBTN.UseVisualStyleBackColor = True
        '
        'ViewBTN
        '
        Me.ViewBTN.Location = New System.Drawing.Point(714, 430)
        Me.ViewBTN.Name = "ViewBTN"
        Me.ViewBTN.Size = New System.Drawing.Size(87, 23)
        Me.ViewBTN.TabIndex = 13
        Me.ViewBTN.Text = "View Records"
        Me.ViewBTN.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(61, 74)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Search Patient ID:"
        '
        'patIdSearchTxt
        '
        Me.patIdSearchTxt.Location = New System.Drawing.Point(161, 67)
        Me.patIdSearchTxt.Name = "patIdSearchTxt"
        Me.patIdSearchTxt.Size = New System.Drawing.Size(100, 20)
        Me.patIdSearchTxt.TabIndex = 15
        '
        'DiagnosisView
        '
        Me.DiagnosisView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DiagnosisView.Location = New System.Drawing.Point(517, 233)
        Me.DiagnosisView.Name = "DiagnosisView"
        Me.DiagnosisView.Size = New System.Drawing.Size(243, 120)
        Me.DiagnosisView.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(677, 88)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "DiagNO:"
        '
        'diagNoTxt
        '
        Me.diagNoTxt.Enabled = False
        Me.diagNoTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.diagNoTxt.Location = New System.Drawing.Point(765, 81)
        Me.diagNoTxt.Name = "diagNoTxt"
        Me.diagNoTxt.Size = New System.Drawing.Size(100, 31)
        Me.diagNoTxt.TabIndex = 18
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(352, 88)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 13)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Patient ID:"
        '
        'patIdTxt
        '
        Me.patIdTxt.Enabled = False
        Me.patIdTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.patIdTxt.Location = New System.Drawing.Point(455, 81)
        Me.patIdTxt.Name = "patIdTxt"
        Me.patIdTxt.Size = New System.Drawing.Size(100, 22)
        Me.patIdTxt.TabIndex = 20
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(596, 385)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(97, 23)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Add Diagnosis"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'diagnosisTxt
        '
        Me.diagnosisTxt.Location = New System.Drawing.Point(583, 359)
        Me.diagnosisTxt.Name = "diagnosisTxt"
        Me.diagnosisTxt.Size = New System.Drawing.Size(126, 20)
        Me.diagnosisTxt.TabIndex = 22
        '
        'PatientDiagnosisFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(913, 465)
        Me.Controls.Add(Me.diagnosisTxt)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.patIdTxt)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.diagNoTxt)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.DiagnosisView)
        Me.Controls.Add(Me.patIdSearchTxt)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ViewBTN)
        Me.Controls.Add(Me.ExitBTN)
        Me.Controls.Add(Me.SubmitBTN)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.diagDateTxt)
        Me.Controls.Add(Me.patFNameTxt)
        Me.Controls.Add(Me.patLNameTxt)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PatientView)
        Me.Controls.Add(Me.Label1)
        Me.Name = "PatientDiagnosisFrm"
        Me.Text = "PatientDiagnosisFrm"
        CType(Me.PatientView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiagnosisView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PatientView As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents patLNameTxt As TextBox
    Friend WithEvents patFNameTxt As TextBox
    Friend WithEvents diagDateTxt As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents SubmitBTN As Button
    Friend WithEvents ExitBTN As Button
    Friend WithEvents ViewBTN As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents patIdSearchTxt As TextBox
    Friend WithEvents DiagnosisView As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents diagNoTxt As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents patIdTxt As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents diagnosisTxt As TextBox
End Class
