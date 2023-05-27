Imports IBM.Data.DB2
Public Class EmployeeAddFrm
    Dim PISconn As Common.DbConnection
    Private Sub EmployeeAddFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            PISconn = New DB2Connection("server=localhost;database=patient;" + "uid=db2admin;password=db2admin;")
            PISconn.Open()
            With Me.DataGridView1
                DataGridView1.ReadOnly = True
                DataGridView1.AllowUserToResizeRows = False
                DataGridView1.AllowUserToResizeColumns = False
                .ColumnCount = 6
                .Columns(0).Name = "Employee ID"
                .Columns(1).Name = "Employee FirstName"
                .Columns(2).Name = "Employee LastName"
                .Columns(3).Name = "Employee Age"
                .Columns(4).Name = "Employee Address"
                .Columns(5).Name = "Employee Type"
            End With

            Call RefreshDataGrid()
            Me.RegisterBTN.Enabled = False

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub RefreshDataGrid()
        Dim RdrEmployee As DB2DataReader
        Dim CmdRetEmployee As DB2Command
        Dim SelectEmployeeStr As String
        Dim Row As String()

        SelectEmployeeStr = "select * from employee"
        CmdRetEmployee = New DB2Command(SelectEmployeeStr, PISconn)
        RdrEmployee = CmdRetEmployee.ExecuteReader
        Me.DataGridView1.Rows.Clear()
        While RdrEmployee.Read
            Row = New String() {RdrEmployee.GetString(0), RdrEmployee.GetString(1), RdrEmployee.GetString(2), RdrEmployee.GetString(3), RdrEmployee.GetString(4), RdrEmployee.GetString(5)}
            DataGridView1.Rows.Add(Row)
        End While
        RdrEmployee.Close()
    End Sub

    Private Sub RegisterBTN_Click(sender As Object, e As EventArgs) Handles RegisterBTN.Click
        Try

            Dim empLname As String
            Dim empFname As String
            Dim empAge As String
            Dim empAdd As String
            Dim empType As String

            Dim InsertEmployee As String
            Dim CmdInsertEmployee As DB2Command


            empFname = Me.empFNameTxt.Text
            empLname = Me.empLNameTxt.Text
            empAge = Me.empAgeTxt.Text
            empAdd = Me.empAddressTxt.Text
            empType = Me.empTypeTxt.Text
            InsertEmployee = "insert into employee(empfname,emplname,empage,empaddress,emptype) values('" & empFname & "','" & empLname & "','" & empAge & "','" & empAdd & "','" & empType & "')"
            CmdInsertEmployee = New DB2Command(InsertEmployee, PISconn)
            CmdInsertEmployee.ExecuteNonQuery()
            MessageBox.Show("Employee Succesfully Registered")
            Call RefreshDataGrid()
            Call ClearEmployeeFunction()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub ClearEmployeeFunction()
        Me.empFNameTxt.Clear()
        Me.empLNameTxt.Clear()
        Me.empAgeTxt.Clear()
        Me.empAddressTxt.Clear()
        Me.empFNameTxt.Focus()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Call RefreshDataGrid()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PISconn.Close()
        SecretaryMenuFrm.Show()
        Me.Close()
    End Sub

    Private Sub Entry()
        If (Me.empFNameTxt.Text <> "") And (Me.empLNameTxt.Text <> "") And (Me.empAgeTxt.Text <> "") And (Me.empAddressTxt.Text <> "") Then
            Me.RegisterBTN.Enabled = True
        Else
            Me.RegisterBTN.Enabled = False
        End If
    End Sub

    Private Sub empFNameTxt_TextChanged(sender As Object, e As EventArgs) Handles empFNameTxt.TextChanged
        Call Entry()
    End Sub

    Private Sub empLNameTxt_TextChanged(sender As Object, e As EventArgs) Handles empLNameTxt.TextChanged
        Call Entry()
    End Sub

    Private Sub empAgeTxt_TextChanged(sender As Object, e As EventArgs) Handles empAgeTxt.TextChanged
        Call Entry()
    End Sub

    Private Sub empAddressTxt_TextChanged(sender As Object, e As EventArgs) Handles empAddressTxt.TextChanged
        Call Entry()
    End Sub
End Class