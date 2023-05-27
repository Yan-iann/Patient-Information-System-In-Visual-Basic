<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PatientEditFrm
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
        Me.UpdateBTN = New System.Windows.Forms.Button()
        Me.BackBTN = New System.Windows.Forms.Button()
        Me.PatientView = New System.Windows.Forms.DataGridView()
        Me.patMobileTxt = New System.Windows.Forms.TextBox()
        Me.patAddTxt = New System.Windows.Forms.TextBox()
        Me.patAgeTxt = New System.Windows.Forms.TextBox()
        Me.patLNameTxt = New System.Windows.Forms.TextBox()
        Me.patFNameTxt = New System.Windows.Forms.TextBox()
        Me.patIdTxt = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.patSearchTxt = New System.Windows.Forms.TextBox()
        CType(Me.PatientView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UpdateBTN
        '
        Me.UpdateBTN.Location = New System.Drawing.Point(284, 330)
        Me.UpdateBTN.Name = "UpdateBTN"
        Me.UpdateBTN.Size = New System.Drawing.Size(75, 23)
        Me.UpdateBTN.TabIndex = 33
        Me.UpdateBTN.Text = "Update"
        Me.UpdateBTN.UseVisualStyleBackColor = True
        '
        'BackBTN
        '
        Me.BackBTN.Location = New System.Drawing.Point(24, 330)
        Me.BackBTN.Name = "BackBTN"
        Me.BackBTN.Size = New System.Drawing.Size(75, 23)
        Me.BackBTN.TabIndex = 31
        Me.BackBTN.Text = "Back"
        Me.BackBTN.UseVisualStyleBackColor = True
        '
        'PatientView
        '
        Me.PatientView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PatientView.Location = New System.Drawing.Point(365, 99)
        Me.PatientView.Name = "PatientView"
        Me.PatientView.Size = New System.Drawing.Size(423, 254)
        Me.PatientView.TabIndex = 30
        '
        'patMobileTxt
        '
        Me.patMobileTxt.Location = New System.Drawing.Point(139, 295)
        Me.patMobileTxt.Name = "patMobileTxt"
        Me.patMobileTxt.Size = New System.Drawing.Size(220, 20)
        Me.patMobileTxt.TabIndex = 29
        '
        'patAddTxt
        '
        Me.patAddTxt.Location = New System.Drawing.Point(139, 263)
        Me.patAddTxt.Name = "patAddTxt"
        Me.patAddTxt.Size = New System.Drawing.Size(220, 20)
        Me.patAddTxt.TabIndex = 28
        '
        'patAgeTxt
        '
        Me.patAgeTxt.Location = New System.Drawing.Point(139, 218)
        Me.patAgeTxt.Name = "patAgeTxt"
        Me.patAgeTxt.Size = New System.Drawing.Size(220, 20)
        Me.patAgeTxt.TabIndex = 27
        '
        'patLNameTxt
        '
        Me.patLNameTxt.Location = New System.Drawing.Point(139, 182)
        Me.patLNameTxt.Name = "patLNameTxt"
        Me.patLNameTxt.Size = New System.Drawing.Size(220, 20)
        Me.patLNameTxt.TabIndex = 26
        '
        'patFNameTxt
        '
        Me.patFNameTxt.Location = New System.Drawing.Point(139, 139)
        Me.patFNameTxt.Name = "patFNameTxt"
        Me.patFNameTxt.Size = New System.Drawing.Size(220, 20)
        Me.patFNameTxt.TabIndex = 25
        '
        'patIdTxt
        '
        Me.patIdTxt.Location = New System.Drawing.Point(139, 99)
        Me.patIdTxt.Name = "patIdTxt"
        Me.patIdTxt.Size = New System.Drawing.Size(220, 20)
        Me.patIdTxt.TabIndex = 24
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(21, 302)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 13)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Patient MobileNo:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 225)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 13)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Patient Age:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 189)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Patient LastName:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 146)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Patient FirstName:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 270)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Patient Address:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Patient ID:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Historic", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(302, 50)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Edit Patient Info"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(490, 84)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(134, 13)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "Search Patient Last Name:"
        '
        'patSearchTxt
        '
        Me.patSearchTxt.Location = New System.Drawing.Point(629, 77)
        Me.patSearchTxt.Name = "patSearchTxt"
        Me.patSearchTxt.Size = New System.Drawing.Size(159, 20)
        Me.patSearchTxt.TabIndex = 35
        '
        'PatientEditFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 368)
        Me.Controls.Add(Me.patSearchTxt)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.UpdateBTN)
        Me.Controls.Add(Me.BackBTN)
        Me.Controls.Add(Me.PatientView)
        Me.Controls.Add(Me.patMobileTxt)
        Me.Controls.Add(Me.patAddTxt)
        Me.Controls.Add(Me.patAgeTxt)
        Me.Controls.Add(Me.patLNameTxt)
        Me.Controls.Add(Me.patFNameTxt)
        Me.Controls.Add(Me.patIdTxt)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "PatientEditFrm"
        Me.Text = "PatientEditFrm"
        CType(Me.PatientView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UpdateBTN As Button
    Friend WithEvents BackBTN As Button
    Friend WithEvents PatientView As DataGridView
    Friend WithEvents patMobileTxt As TextBox
    Friend WithEvents patAddTxt As TextBox
    Friend WithEvents patAgeTxt As TextBox
    Friend WithEvents patLNameTxt As TextBox
    Friend WithEvents patFNameTxt As TextBox
    Friend WithEvents patIdTxt As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents patSearchTxt As TextBox
End Class
