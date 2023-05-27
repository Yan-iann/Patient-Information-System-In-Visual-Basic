<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeeEditFrm
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.empAddressTxt = New System.Windows.Forms.TextBox()
        Me.empAgeTxt = New System.Windows.Forms.TextBox()
        Me.empLNameTxt = New System.Windows.Forms.TextBox()
        Me.empFNameTxt = New System.Windows.Forms.TextBox()
        Me.empIdTxt = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.empSearchTxt = New System.Windows.Forms.TextBox()
        Me.empTypeTxt = New System.Windows.Forms.ComboBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UpdateBTN
        '
        Me.UpdateBTN.Location = New System.Drawing.Point(290, 328)
        Me.UpdateBTN.Name = "UpdateBTN"
        Me.UpdateBTN.Size = New System.Drawing.Size(75, 23)
        Me.UpdateBTN.TabIndex = 50
        Me.UpdateBTN.Text = "Update"
        Me.UpdateBTN.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(24, 328)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 48
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(371, 97)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(504, 254)
        Me.DataGridView1.TabIndex = 47
        '
        'empAddressTxt
        '
        Me.empAddressTxt.Location = New System.Drawing.Point(139, 249)
        Me.empAddressTxt.Name = "empAddressTxt"
        Me.empAddressTxt.Size = New System.Drawing.Size(226, 20)
        Me.empAddressTxt.TabIndex = 46
        '
        'empAgeTxt
        '
        Me.empAgeTxt.Location = New System.Drawing.Point(139, 217)
        Me.empAgeTxt.Name = "empAgeTxt"
        Me.empAgeTxt.Size = New System.Drawing.Size(226, 20)
        Me.empAgeTxt.TabIndex = 45
        '
        'empLNameTxt
        '
        Me.empLNameTxt.Location = New System.Drawing.Point(139, 180)
        Me.empLNameTxt.Name = "empLNameTxt"
        Me.empLNameTxt.Size = New System.Drawing.Size(226, 20)
        Me.empLNameTxt.TabIndex = 43
        '
        'empFNameTxt
        '
        Me.empFNameTxt.Location = New System.Drawing.Point(139, 137)
        Me.empFNameTxt.Name = "empFNameTxt"
        Me.empFNameTxt.Size = New System.Drawing.Size(226, 20)
        Me.empFNameTxt.TabIndex = 42
        '
        'empIdTxt
        '
        Me.empIdTxt.Location = New System.Drawing.Point(139, 97)
        Me.empIdTxt.Name = "empIdTxt"
        Me.empIdTxt.Size = New System.Drawing.Size(226, 20)
        Me.empIdTxt.TabIndex = 41
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(21, 256)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 13)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "Employee Adress:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 291)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 13)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "Employee Type:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 187)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 13)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Employee LastName:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 13)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Employee FirstName:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 224)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Employee Age:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Employee ID:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Historic", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(348, 50)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Edit Employee Info"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(442, 81)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(144, 13)
        Me.Label8.TabIndex = 51
        Me.Label8.Text = "Search Employee LastName:"
        '
        'empSearchTxt
        '
        Me.empSearchTxt.Location = New System.Drawing.Point(584, 74)
        Me.empSearchTxt.Name = "empSearchTxt"
        Me.empSearchTxt.Size = New System.Drawing.Size(192, 20)
        Me.empSearchTxt.TabIndex = 52
        '
        'empTypeTxt
        '
        Me.empTypeTxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.empTypeTxt.FormattingEnabled = True
        Me.empTypeTxt.Items.AddRange(New Object() {"Secretary", "Physician"})
        Me.empTypeTxt.Location = New System.Drawing.Point(139, 283)
        Me.empTypeTxt.Name = "empTypeTxt"
        Me.empTypeTxt.Size = New System.Drawing.Size(226, 21)
        Me.empTypeTxt.TabIndex = 53
        '
        'EmployeeEditFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(887, 363)
        Me.Controls.Add(Me.empTypeTxt)
        Me.Controls.Add(Me.empSearchTxt)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.UpdateBTN)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.empAddressTxt)
        Me.Controls.Add(Me.empAgeTxt)
        Me.Controls.Add(Me.empLNameTxt)
        Me.Controls.Add(Me.empFNameTxt)
        Me.Controls.Add(Me.empIdTxt)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "EmployeeEditFrm"
        Me.Text = "EmployeeEditFrm"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UpdateBTN As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents empAddressTxt As TextBox
    Friend WithEvents empAgeTxt As TextBox
    Friend WithEvents empLNameTxt As TextBox
    Friend WithEvents empFNameTxt As TextBox
    Friend WithEvents empIdTxt As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents empSearchTxt As TextBox
    Friend WithEvents empTypeTxt As ComboBox
End Class
