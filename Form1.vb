Imports IBM.Data.DB2
Public Class Form1
    Dim PISconn As Common.DbConnection
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            PISconn = New DB2Connection("server=localhost;database=patient;" + "uid=db2admin;password=db2admin;")
            PISconn.Open()
            With Me.DataGridView1
                DataGridView1.ReadOnly = True
                DataGridView1.AllowUserToResizeRows = False
                .ColumnCount = 6
                .Columns(0).Name = "Patient ID"
                .Columns(1).Name = "Patient FirstName"
                .Columns(2).Name = "Patient LastName"
                .Columns(3).Name = "Patient Age"
                .Columns(4).Name = "Patient Address"
                .Columns(5).Name = "Patient MobileNo"
            End With

            Call RefreshDataGrid()
            Me.RegisterBTN.Enabled = False

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles RegisterBTN.Click
        Try

            Dim patLname As String
            Dim patFname As String
            Dim patAge As String
            Dim patAdd As String
            Dim patMobile As String

            Dim InsertPatient As String
            Dim CmdInsertPatient As DB2Command


            patFname = Me.patFNameTxt.Text
            patLname = Me.patLNameTxt.Text
            patAge = Me.patAgeTxt.Text
            patAdd = Me.patAddTxt.Text
            patMobile = Me.patMobileTxt.Text
            InsertPatient = "insert into patient(patfname,patlname,patage,pataddress,patmobileno) values('" & patFname & "','" & patLname & "','" & patAge & "','" & patAdd & "','" & patMobile & "')"
            CmdInsertPatient = New DB2Command(InsertPatient, PISconn)
            CmdInsertPatient.ExecuteNonQuery()
            MessageBox.Show("Patient Succesfully Registered")
            Call RefreshDataGrid()
            Call ClearPatientFunction()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub RefreshDataGrid()
        Dim RdrPatient As DB2DataReader
        Dim CmdRetPatient As DB2Command
        Dim SelectPatientStr As String
        Dim Row As String()

        SelectPatientStr = "select * from patient"
        CmdRetPatient = New DB2Command(SelectPatientStr, PISconn)
        RdrPatient = CmdRetPatient.ExecuteReader
        Me.DataGridView1.Rows.Clear()
        While RdrPatient.Read
            Row = New String() {RdrPatient.GetString(0), RdrPatient.GetString(1), RdrPatient.GetString(2), RdrPatient.GetString(3), RdrPatient.GetString(4), RdrPatient.GetString(5)}
            DataGridView1.Rows.Add(Row)
        End While
        RdrPatient.Close()
    End Sub

    Private Sub ClearPatientFunction()
        Me.patFNameTxt.Clear()
        Me.patLNameTxt.Clear()
        Me.patAgeTxt.Clear()
        Me.patAddTxt.Clear()
        Me.patMobileTxt.Clear()
        Me.patFNameTxt.Focus()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Call RefreshDataGrid()
    End Sub

    Private Sub Entry()
        If (Me.patFNameTxt.Text <> "") And (Me.patLNameTxt.Text <> "") And (Me.patAgeTxt.Text <> "") And (Me.patAddTxt.Text <> "") And (Me.patMobileTxt.Text <> "") Then
            Me.RegisterBTN.Enabled = True
        Else
            Me.RegisterBTN.Enabled = False
        End If
    End Sub

    Private Sub patMobileTxt_TextChanged(sender As Object, e As EventArgs) Handles patMobileTxt.TextChanged
        Call Entry()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PISconn.Close()
        SecretaryMenuFrm.Show()
        Me.Close()
    End Sub

    Private Sub patIDTxt_TextChanged(sender As Object, e As EventArgs)
        Call Entry()
    End Sub

    Private Sub patLNameTxt_TextChanged(sender As Object, e As EventArgs) Handles patFNameTxt.TextChanged
        Call Entry()

    End Sub

    Private Sub patFNameTxt_TextChanged(sender As Object, e As EventArgs) Handles patLNameTxt.TextChanged
        Call Entry()
    End Sub

    Private Sub patAgeTxt_TextChanged(sender As Object, e As EventArgs) Handles patAgeTxt.TextChanged
        Call Entry()
    End Sub

    Private Sub patAddTxt_TextChanged(sender As Object, e As EventArgs) Handles patAddTxt.TextChanged
        Call Entry()
    End Sub
End Class
