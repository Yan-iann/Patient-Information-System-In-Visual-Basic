Imports IBM.Data.DB2
Public Class EmployeeEditFrm
    Dim PISconn As Common.DbConnection
    Private Sub EmployeeEditFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            Call NoEntry()
            Me.UpdateBTN.Enabled = False

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

    Private Sub DataGridView1_MouseUp(sender As Object, e As MouseEventArgs) Handles DataGridView1.MouseUp
        Me.empIdTxt.Text = Me.DataGridView1.CurrentRow.Cells(0).Value
        Me.empFNameTxt.Text = Me.DataGridView1.CurrentRow.Cells(1).Value
        Me.empLNameTxt.Text = Me.DataGridView1.CurrentRow.Cells(2).Value
        Me.empAgeTxt.Text = Me.DataGridView1.CurrentRow.Cells(3).Value
        Me.empAddressTxt.Text = Me.DataGridView1.CurrentRow.Cells(4).Value
        Me.empTypeTxt.Text = Me.DataGridView1.CurrentRow.Cells(5).Value
        Call Entry()
    End Sub

    Private Sub NoEntry()
        Me.empIdTxt.Enabled = False
        Me.empFNameTxt.Enabled = False
        Me.empLNameTxt.Enabled = False
        Me.empAgeTxt.Enabled = False
        Me.empAddressTxt.Enabled = False
        Me.empTypeTxt.Enabled = False
    End Sub

    Private Sub Entry()
        Me.empIdTxt.Enabled = False
        Me.empFNameTxt.Enabled = True
        Me.empLNameTxt.Enabled = True
        Me.empAgeTxt.Enabled = True
        Me.empAddressTxt.Enabled = True
        Me.empTypeTxt.Enabled = True
    End Sub

    Private Sub AllowUpdate()
        If (Me.empIdTxt.Text <> "") And (Me.empFNameTxt.Text <> "") And (Me.empLNameTxt.Text <> "") And (Me.empAgeTxt.Text <> "") And (Me.empAddressTxt.Text <> "") Then
            Me.UpdateBTN.Enabled = True
        Else
            Me.UpdateBTN.Enabled = False
        End If
    End Sub

    Private Sub empIdTxt_TextChanged(sender As Object, e As EventArgs) Handles empIdTxt.TextChanged
        Call AllowUpdate()
    End Sub

    Private Sub empFNameTxt_TextChanged(sender As Object, e As EventArgs) Handles empFNameTxt.TextChanged
        Call AllowUpdate()
    End Sub

    Private Sub empLNameTxt_TextChanged(sender As Object, e As EventArgs) Handles empLNameTxt.TextChanged
        Call AllowUpdate()
    End Sub

    Private Sub empAgeTxt_TextChanged(sender As Object, e As EventArgs) Handles empAgeTxt.TextChanged
        Call AllowUpdate()
    End Sub

    Private Sub empAddressTxt_TextChanged(sender As Object, e As EventArgs) Handles empAddressTxt.TextChanged
        Call AllowUpdate()
    End Sub

    Private Sub empTypeTxt_SelectedIndexChanged(sender As Object, e As EventArgs) Handles empTypeTxt.SelectedIndexChanged
        Call AllowUpdate()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PISconn.Close()
        SecretaryMenuFrm.Show()
        Me.Close()
    End Sub

    Private Sub UpdateBTN_Click(sender As Object, e As EventArgs) Handles UpdateBTN.Click
        Dim empId As String
        Dim empFname As String
        Dim empLname As String
        Dim empAge As String
        Dim empAdd As String
        Dim empType As String

        Dim UpdateEmployee As String
        Dim CmdUpdateEmployee As DB2Command

        empId = Me.empIdTxt.Text
        empFname = Me.empFNameTxt.Text
        empLname = Me.empLNameTxt.Text
        empAge = Me.empAgeTxt.Text
        empAdd = Me.empAddressTxt.Text
        empType = Me.empTypeTxt.Text

        UpdateEmployee = "update employee set empfname = '" & empFname & "',emplname ='" & empLname & "',empage='" & empAge & "',empaddress='" & empAdd & "',emptype='" & empType & "' where empid ='" & empId & "' "
        CmdUpdateEmployee = New DB2Command(UpdateEmployee, PISconn)
        CmdUpdateEmployee.ExecuteNonQuery()
        MessageBox.Show("Employee Succesfully Updated")
        Call RefreshDataGrid()
        Call ClearEmployeeFunction()
        Call NoEntry()
    End Sub

    Private Sub ClearEmployeeFunction()
        Me.empIdTxt.Clear()
        Me.empFNameTxt.Clear()
        Me.empLNameTxt.Clear()
        Me.empAgeTxt.Clear()
        Me.empAddressTxt.Clear()
        Me.empSearchTxt.Clear()
    End Sub

    Private Sub empSearchTxt_TextChanged(sender As Object, e As EventArgs) Handles empSearchTxt.TextChanged
        Try
            Dim SearchEmployeeStr As String
            Dim CmdSearch As DB2Command
            Dim RdrSearch As DB2DataReader
            Dim SearchEmployeeStr2 As String
            Dim row As String()

            SearchEmployeeStr2 = "%" + Me.empSearchTxt.Text + "%"
            SearchEmployeeStr = "Select * from employee where empLName like  '" & SearchEmployeeStr2 & "'"
            CmdSearch = New DB2Command(SearchEmployeeStr, PISconn)
            RdrSearch = CmdSearch.ExecuteReader
            Me.DataGridView1.Rows.Clear()

            While RdrSearch.Read
                row = New String() {RdrSearch.GetString(0), RdrSearch.GetString(1), RdrSearch.GetString(2), RdrSearch.GetString(3), RdrSearch.GetString(4), RdrSearch.GetString(5)}
                Me.DataGridView1.Rows.Add(row)
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class