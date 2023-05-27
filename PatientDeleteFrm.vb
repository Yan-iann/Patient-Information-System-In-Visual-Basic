Imports IBM.Data.DB2
Public Class PatientDeleteFrm
    Dim PISconn As Common.DbConnection
    Private Sub PatientDeleteFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            PISconn = New DB2Connection("server=localhost;database=patient;" + "uid=db2admin;password=db2admin;")
            PISconn.Open()
            With Me.PatientView
                PatientView.ReadOnly = True
                .ColumnCount = 6
                .Columns(0).Name = "Patient ID"
                .Columns(1).Name = "Patient FirstName"
                .Columns(2).Name = "Patient LastName"
                .Columns(3).Name = "Patient Age"
                .Columns(4).Name = "Patient Address"
                .Columns(5).Name = "Patient MobileNo"
            End With

            Call RefreshDataGrid()
            Call NoEntry()
            Me.DeleteBTN.Enabled = False

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub NoEntry()
        Me.patIdTxt.Enabled = False
        Me.patFNameTxt.Enabled = False
        Me.patLNameTxt.Enabled = False
        Me.patAgeTxt.Enabled = False
        Me.patAddTxt.Enabled = False
        Me.patMobileTxt.Enabled = False
    End Sub

    Private Sub RefreshDataGrid()
        Dim RdrPatient As DB2DataReader
        Dim CmdRetPatient As DB2Command
        Dim SelectPatientStr As String
        Dim Row As String()

        SelectPatientStr = "select * from patient"
        CmdRetPatient = New DB2Command(SelectPatientStr, PISconn)
        RdrPatient = CmdRetPatient.ExecuteReader
        Me.PatientView.Rows.Clear()
        While RdrPatient.Read
            Row = New String() {RdrPatient.GetString(0), RdrPatient.GetString(1), RdrPatient.GetString(2), RdrPatient.GetString(3), RdrPatient.GetString(4), RdrPatient.GetString(5)}
            PatientView.Rows.Add(Row)
        End While
        RdrPatient.Close()
    End Sub

    Private Sub PatientView_MouseUp(sender As Object, e As MouseEventArgs) Handles PatientView.MouseUp
        Me.patIdTxt.Text = Me.PatientView.CurrentRow.Cells(0).Value
        Me.patFNameTxt.Text = Me.PatientView.CurrentRow.Cells(1).Value
        Me.patLNameTxt.Text = Me.PatientView.CurrentRow.Cells(2).Value
        Me.patAgeTxt.Text = Me.PatientView.CurrentRow.Cells(3).Value
        Me.patAddTxt.Text = Me.PatientView.CurrentRow.Cells(4).Value
        Me.patMobileTxt.Text = Me.PatientView.CurrentRow.Cells(5).Value
        Call AllowDelete()
    End Sub

    Private Sub DeleteBTN_Click(sender As Object, e As EventArgs) Handles DeleteBTN.Click
        Try
            Dim DeletePatientStr As String
            Dim CmdPatientDelete As DB2Command
            Dim Answer As Integer

            Answer = MsgBox("Are you sure you want to delete the customer info of '" & Me.PatientView.CurrentRow.Cells(1).Value & "' ?", vbQuestion + vbYesNo + vbDefaultButton2, "Delete Confirmation")
            If answer = vbYes Then
                DeletePatientStr = "delete from patient where patid = '" & Me.patIdTxt.Text & "'"
                CmdPatientDelete = New DB2Command(DeletePatientStr, PISconn)
                CmdPatientDelete.ExecuteNonQuery()
                MessageBox.Show("Patient Information Succesfully Deleted")
                Call RefreshDataGrid()
                Call ClearPatientFunction()
                Call NoEntry()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub ClearPatientFunction()
        Me.patIdTxt.Clear()
        Me.patFNameTxt.Clear()
        Me.patLNameTxt.Clear()
        Me.patAgeTxt.Clear()
        Me.patAddTxt.Clear()
        Me.patMobileTxt.Clear()
        Me.patSearchTxt.Clear()
    End Sub

    Private Sub patSearchTxt_TextChanged(sender As Object, e As EventArgs) Handles patSearchTxt.TextChanged
        Try
            Dim SearchPatientStr As String
            Dim CmdSearch As DB2Command
            Dim RdrSearch As DB2DataReader
            Dim SearchPatientStr2 As String
            Dim row As String()

            SearchPatientStr2 = "%" + Me.patSearchTxt.Text + "%"
            SearchPatientStr = "Select * from patient where patLName like  '" & SearchPatientStr2 & "'"
            CmdSearch = New DB2Command(SearchPatientStr, PISconn)
            RdrSearch = CmdSearch.ExecuteReader
            Me.PatientView.Rows.Clear()

            While RdrSearch.Read
                row = New String() {RdrSearch.GetString(0), RdrSearch.GetString(1), RdrSearch.GetString(2), RdrSearch.GetString(3), RdrSearch.GetString(4), RdrSearch.GetString(5)}
                Me.PatientView.Rows.Add(row)
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PISconn.Close()
        SecretaryMenuFrm.Show()
        Me.Close()
    End Sub

    Private Sub AllowDelete()
        If (Me.patIdTxt.Text <> "") And (Me.patFNameTxt.Text <> "") And (Me.patLNameTxt.Text <> "") And (Me.patAgeTxt.Text <> "") And (Me.patAddTxt.Text <> "") And (Me.patMobileTxt.Text <> "") Then
            Me.DeleteBTN.Enabled = True
        Else
            Me.DeleteBTN.Enabled = False
        End If
    End Sub

    Private Sub patIdTxt_TextChanged(sender As Object, e As EventArgs) Handles patIdTxt.TextChanged
        Call AllowDelete()
    End Sub

    Private Sub patFNameTxt_TextChanged(sender As Object, e As EventArgs) Handles patFNameTxt.TextChanged
        Call AllowDelete()
    End Sub

    Private Sub patLNameTxt_TextChanged(sender As Object, e As EventArgs) Handles patLNameTxt.TextChanged
        Call AllowDelete()
    End Sub

    Private Sub patAgeTxt_TextChanged(sender As Object, e As EventArgs) Handles patAgeTxt.TextChanged
        Call AllowDelete()
    End Sub

    Private Sub patAddTxt_TextChanged(sender As Object, e As EventArgs) Handles patAddTxt.TextChanged
        Call AllowDelete()
    End Sub

    Private Sub patMobileTxt_TextChanged(sender As Object, e As EventArgs) Handles patMobileTxt.TextChanged
        Call AllowDelete()
    End Sub
End Class