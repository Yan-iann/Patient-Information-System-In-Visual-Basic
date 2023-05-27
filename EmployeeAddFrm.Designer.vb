<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeeAddFrm
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
        Me.Button3 = New System.Windows.Forms.Button()
        Me.RegisterBTN = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.empAddressTxt = New System.Windows.Forms.TextBox()
        Me.empAgeTxt = New System.Windows.Forms.TextBox()
        Me.empLNameTxt = New System.Windows.Forms.TextBox()
        Me.empFNameTxt = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.empTypeTxt = New System.Windows.Forms.ComboBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(775, 334)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 33
        Me.Button3.Text = "Refresh"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'RegisterBTN
        '
        Me.RegisterBTN.Location = New System.Drawing.Point(291, 334)
        Me.RegisterBTN.Name = "RegisterBTN"
        Me.RegisterBTN.Size = New System.Drawing.Size(75, 23)
        Me.RegisterBTN.TabIndex = 32
        Me.RegisterBTN.Text = "Register"
        Me.RegisterBTN.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(24, 334)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 31
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(372, 74)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(478, 254)
        Me.DataGridView1.TabIndex = 30
        '
        'empAddressTxt
        '
        Me.empAddressTxt.Location = New System.Drawing.Point(139, 244)
        Me.empAddressTxt.Name = "empAddressTxt"
        Me.empAddressTxt.Size = New System.Drawing.Size(227, 20)
        Me.empAddressTxt.TabIndex = 29
        '
        'empAgeTxt
        '
        Me.empAgeTxt.Location = New System.Drawing.Point(139, 205)
        Me.empAgeTxt.Name = "empAgeTxt"
        Me.empAgeTxt.Size = New System.Drawing.Size(227, 20)
        Me.empAgeTxt.TabIndex = 28
        '
        'empLNameTxt
        '
        Me.empLNameTxt.Location = New System.Drawing.Point(139, 167)
        Me.empLNameTxt.Name = "empLNameTxt"
        Me.empLNameTxt.Size = New System.Drawing.Size(227, 20)
        Me.empLNameTxt.TabIndex = 26
        '
        'empFNameTxt
        '
        Me.empFNameTxt.Location = New System.Drawing.Point(139, 118)
        Me.empFNameTxt.Name = "empFNameTxt"
        Me.empFNameTxt.Size = New System.Drawing.Size(227, 20)
        Me.empFNameTxt.TabIndex = 25
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(21, 251)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 13)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Employee Adress:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 289)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 13)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Employee Type:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 167)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Employee LastName:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Employee FirstName:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 212)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Employee Age:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Historic", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(411, 50)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Employee Registration"
        '
        'empTypeTxt
        '
        Me.empTypeTxt.AllowDrop = True
        Me.empTypeTxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.empTypeTxt.FormattingEnabled = True
        Me.empTypeTxt.Items.AddRange(New Object() {"Secretary", "Physician"})
        Me.empTypeTxt.Location = New System.Drawing.Point(139, 281)
        Me.empTypeTxt.Name = "empTypeTxt"
        Me.empTypeTxt.Size = New System.Drawing.Size(227, 21)
        Me.empTypeTxt.TabIndex = 34
        '
        'EmployeeAddFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(862, 379)
        Me.Controls.Add(Me.empTypeTxt)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.RegisterBTN)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.empAddressTxt)
        Me.Controls.Add(Me.empAgeTxt)
        Me.Controls.Add(Me.empLNameTxt)
        Me.Controls.Add(Me.empFNameTxt)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Name = "EmployeeAddFrm"
        Me.Text = "EmployeeAddFrm"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button3 As Button
    Friend WithEvents RegisterBTN As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents empAddressTxt As TextBox
    Friend WithEvents empAgeTxt As TextBox
    Friend WithEvents empLNameTxt As TextBox
    Friend WithEvents empFNameTxt As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents empTypeTxt As ComboBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
