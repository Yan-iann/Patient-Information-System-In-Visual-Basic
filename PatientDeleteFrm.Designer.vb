<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PatientDeleteFrm
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
        Me.patSearchTxt = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DeleteBTN = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
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
        CType(Me.PatientView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'patSearchTxt
        '
        Me.patSearchTxt.Location = New System.Drawing.Point(199, 88)
        Me.patSearchTxt.Name = "patSearchTxt"
        Me.patSearchTxt.Size = New System.Drawing.Size(159, 20)
        Me.patSearchTxt.TabIndex = 53
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(67, 95)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(131, 13)
        Me.Label8.TabIndex = 52
        Me.Label8.Text = "Search Patient LastName:"
        '
        'DeleteBTN
        '
        Me.DeleteBTN.Location = New System.Drawing.Point(713, 336)
        Me.DeleteBTN.Name = "DeleteBTN"
        Me.DeleteBTN.Size = New System.Drawing.Size(75, 23)
        Me.DeleteBTN.TabIndex = 51
        Me.DeleteBTN.Text = "Delete"
        Me.DeleteBTN.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(21, 340)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 50
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PatientView
        '
        Me.PatientView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PatientView.Location = New System.Drawing.Point(21, 114)
        Me.PatientView.Name = "PatientView"
        Me.PatientView.Size = New System.Drawing.Size(417, 220)
        Me.PatientView.TabIndex = 49
        '
        'patMobileTxt
        '
        Me.patMobileTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.patMobileTxt.Location = New System.Drawing.Point(544, 306)
        Me.patMobileTxt.Name = "patMobileTxt"
        Me.patMobileTxt.Size = New System.Drawing.Size(244, 26)
        Me.patMobileTxt.TabIndex = 48
        '
        'patAddTxt
        '
        Me.patAddTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.patAddTxt.Location = New System.Drawing.Point(544, 274)
        Me.patAddTxt.Name = "patAddTxt"
        Me.patAddTxt.Size = New System.Drawing.Size(244, 26)
        Me.patAddTxt.TabIndex = 47
        '
        'patAgeTxt
        '
        Me.patAgeTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.patAgeTxt.Location = New System.Drawing.Point(544, 229)
        Me.patAgeTxt.Name = "patAgeTxt"
        Me.patAgeTxt.Size = New System.Drawing.Size(244, 26)
        Me.patAgeTxt.TabIndex = 46
        '
        'patLNameTxt
        '
        Me.patLNameTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.patLNameTxt.Location = New System.Drawing.Point(544, 197)
        Me.patLNameTxt.Name = "patLNameTxt"
        Me.patLNameTxt.Size = New System.Drawing.Size(244, 26)
        Me.patLNameTxt.TabIndex = 45
        '
        'patFNameTxt
        '
        Me.patFNameTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.patFNameTxt.Location = New System.Drawing.Point(544, 150)
        Me.patFNameTxt.Name = "patFNameTxt"
        Me.patFNameTxt.Size = New System.Drawing.Size(244, 26)
        Me.patFNameTxt.TabIndex = 44
        '
        'patIdTxt
        '
        Me.patIdTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.patIdTxt.Location = New System.Drawing.Point(544, 114)
        Me.patIdTxt.Name = "patIdTxt"
        Me.patIdTxt.Size = New System.Drawing.Size(244, 26)
        Me.patIdTxt.TabIndex = 43
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(444, 313)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 13)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "Patient MobileNo:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(444, 236)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 13)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "Patient Age:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(444, 200)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 13)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Patient LastName:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(444, 157)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 13)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Patient FirstName:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(444, 281)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Patient Address:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(444, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Patient ID:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Historic", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(346, 50)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Delete Patient Info"
        '
        'PatientDeleteFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 372)
        Me.Controls.Add(Me.patSearchTxt)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.DeleteBTN)
        Me.Controls.Add(Me.Button1)
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
        Me.Name = "PatientDeleteFrm"
        Me.Text = "PatientDeleteFrm"
        CType(Me.PatientView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents patSearchTxt As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents DeleteBTN As Button
    Friend WithEvents Button1 As Button
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
End Class
