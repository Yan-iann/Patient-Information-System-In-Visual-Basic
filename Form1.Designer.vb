<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.patFNameTxt = New System.Windows.Forms.TextBox()
        Me.patLNameTxt = New System.Windows.Forms.TextBox()
        Me.patAgeTxt = New System.Windows.Forms.TextBox()
        Me.patAddTxt = New System.Windows.Forms.TextBox()
        Me.patMobileTxt = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.RegisterBTN = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Historic", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(365, 50)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Patient Registration"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 246)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Patient Address:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(30, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Patient FirstName:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(33, 156)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Patient LasttName:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(33, 199)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Patient Age:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(29, 292)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Patient MobileNo:"
        '
        'patFNameTxt
        '
        Me.patFNameTxt.Location = New System.Drawing.Point(129, 103)
        Me.patFNameTxt.Name = "patFNameTxt"
        Me.patFNameTxt.Size = New System.Drawing.Size(215, 20)
        Me.patFNameTxt.TabIndex = 8
        '
        'patLNameTxt
        '
        Me.patLNameTxt.Location = New System.Drawing.Point(129, 149)
        Me.patLNameTxt.Name = "patLNameTxt"
        Me.patLNameTxt.Size = New System.Drawing.Size(215, 20)
        Me.patLNameTxt.TabIndex = 9
        '
        'patAgeTxt
        '
        Me.patAgeTxt.Location = New System.Drawing.Point(129, 192)
        Me.patAgeTxt.Name = "patAgeTxt"
        Me.patAgeTxt.Size = New System.Drawing.Size(215, 20)
        Me.patAgeTxt.TabIndex = 10
        '
        'patAddTxt
        '
        Me.patAddTxt.Location = New System.Drawing.Point(129, 239)
        Me.patAddTxt.Name = "patAddTxt"
        Me.patAddTxt.Size = New System.Drawing.Size(215, 20)
        Me.patAddTxt.TabIndex = 11
        '
        'patMobileTxt
        '
        Me.patMobileTxt.Location = New System.Drawing.Point(129, 285)
        Me.patMobileTxt.Name = "patMobileTxt"
        Me.patMobileTxt.Size = New System.Drawing.Size(215, 20)
        Me.patMobileTxt.TabIndex = 12
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(350, 96)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(438, 254)
        Me.DataGridView1.TabIndex = 13
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(36, 327)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'RegisterBTN
        '
        Me.RegisterBTN.Location = New System.Drawing.Point(189, 327)
        Me.RegisterBTN.Name = "RegisterBTN"
        Me.RegisterBTN.Size = New System.Drawing.Size(75, 23)
        Me.RegisterBTN.TabIndex = 15
        Me.RegisterBTN.Text = "Register"
        Me.RegisterBTN.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(269, 327)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 16
        Me.Button3.Text = "Refresh"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 362)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.RegisterBTN)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.patMobileTxt)
        Me.Controls.Add(Me.patAddTxt)
        Me.Controls.Add(Me.patAgeTxt)
        Me.Controls.Add(Me.patLNameTxt)
        Me.Controls.Add(Me.patFNameTxt)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "AddpatientFrm"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents patFNameTxt As TextBox
    Friend WithEvents patLNameTxt As TextBox
    Friend WithEvents patAgeTxt As TextBox
    Friend WithEvents patAddTxt As TextBox
    Friend WithEvents patMobileTxt As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents RegisterBTN As Button
    Friend WithEvents Button3 As Button
End Class
