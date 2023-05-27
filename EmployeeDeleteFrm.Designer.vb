<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeeDeleteFrm
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
        Me.empSearchTxt = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.deleteBTN = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.empAddressTxt = New System.Windows.Forms.TextBox()
        Me.empAgeTxt = New System.Windows.Forms.TextBox()
        Me.empTypeTxt = New System.Windows.Forms.TextBox()
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
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'empSearchTxt
        '
        Me.empSearchTxt.Location = New System.Drawing.Point(221, 92)
        Me.empSearchTxt.Name = "empSearchTxt"
        Me.empSearchTxt.Size = New System.Drawing.Size(204, 20)
        Me.empSearchTxt.TabIndex = 70
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(72, 95)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(144, 13)
        Me.Label8.TabIndex = 69
        Me.Label8.Text = "Search Employee LastName:"
        '
        'deleteBTN
        '
        Me.deleteBTN.Location = New System.Drawing.Point(845, 336)
        Me.deleteBTN.Name = "deleteBTN"
        Me.deleteBTN.Size = New System.Drawing.Size(75, 23)
        Me.deleteBTN.TabIndex = 68
        Me.deleteBTN.Text = "Delete"
        Me.deleteBTN.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(34, 336)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 67
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(31, 114)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(471, 216)
        Me.DataGridView1.TabIndex = 66
        '
        'empAddressTxt
        '
        Me.empAddressTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.empAddressTxt.Location = New System.Drawing.Point(630, 280)
        Me.empAddressTxt.Name = "empAddressTxt"
        Me.empAddressTxt.Size = New System.Drawing.Size(290, 26)
        Me.empAddressTxt.TabIndex = 65
        '
        'empAgeTxt
        '
        Me.empAgeTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.empAgeTxt.Location = New System.Drawing.Point(630, 248)
        Me.empAgeTxt.Name = "empAgeTxt"
        Me.empAgeTxt.Size = New System.Drawing.Size(290, 26)
        Me.empAgeTxt.TabIndex = 64
        '
        'empTypeTxt
        '
        Me.empTypeTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.empTypeTxt.Location = New System.Drawing.Point(630, 210)
        Me.empTypeTxt.Name = "empTypeTxt"
        Me.empTypeTxt.Size = New System.Drawing.Size(290, 26)
        Me.empTypeTxt.TabIndex = 63
        '
        'empLNameTxt
        '
        Me.empLNameTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.empLNameTxt.Location = New System.Drawing.Point(630, 167)
        Me.empLNameTxt.Name = "empLNameTxt"
        Me.empLNameTxt.Size = New System.Drawing.Size(290, 26)
        Me.empLNameTxt.TabIndex = 62
        '
        'empFNameTxt
        '
        Me.empFNameTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.empFNameTxt.Location = New System.Drawing.Point(630, 124)
        Me.empFNameTxt.Name = "empFNameTxt"
        Me.empFNameTxt.Size = New System.Drawing.Size(290, 26)
        Me.empFNameTxt.TabIndex = 61
        '
        'empIdTxt
        '
        Me.empIdTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.empIdTxt.Location = New System.Drawing.Point(630, 84)
        Me.empIdTxt.Name = "empIdTxt"
        Me.empIdTxt.Size = New System.Drawing.Size(290, 26)
        Me.empIdTxt.TabIndex = 60
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(509, 280)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 13)
        Me.Label7.TabIndex = 59
        Me.Label7.Text = "Employee Adress:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(509, 210)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 13)
        Me.Label6.TabIndex = 58
        Me.Label6.Text = "Employee Type:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(509, 167)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 13)
        Me.Label5.TabIndex = 57
        Me.Label5.Text = "Employee LastName:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(508, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 13)
        Me.Label4.TabIndex = 56
        Me.Label4.Text = "Employee FirstName:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(508, 255)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 55
        Me.Label3.Text = "Employee Age:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(508, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "Employee ID:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Historic", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(392, 50)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "Delete Employee Info"
        '
        'EmployeeDeleteFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(932, 366)
        Me.Controls.Add(Me.empSearchTxt)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.deleteBTN)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.empAddressTxt)
        Me.Controls.Add(Me.empAgeTxt)
        Me.Controls.Add(Me.empTypeTxt)
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
        Me.Name = "EmployeeDeleteFrm"
        Me.Text = "EmployeeDeleteFrm"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents empSearchTxt As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents deleteBTN As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents empAddressTxt As TextBox
    Friend WithEvents empAgeTxt As TextBox
    Friend WithEvents empTypeTxt As TextBox
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
End Class
