Imports IBM.Data.DB2
Public Class PatientDiagnosisFrm
    Dim PISconn As Common.DbConnection
    Private Sub PatientDiagnosisFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            PISconn = New DB2Connection("server=localhost;database=patient;" + "uid=db2admin;password=db2admin;")
            PISconn.Open()

            With Me.PatientView
                PatientView.ReadOnly = True
                PatientView.AllowUserToResizeRows = False
                PatientView.AllowUserToResizeColumns = False
                .ColumnCount = 6
                .Columns(0).Name = "Patient ID"
                .Columns(1).Name = "Patient FirstName"
                .Columns(2).Name = "Patient LastName"
                .Columns(3).Name = "Patient Age"
                .Columns(4).Name = "Patient Address"
                .Columns(5).Name = "Patient MobileNo"
            End With

            With Me.DiagnosisView
                DiagnosisView.ReadOnly = True
                DiagnosisView.AllowUserToResizeRows = False
                DiagnosisView.AllowUserToResizeColumns = False
                .ColumnCount = 2
                .Columns(0).Name = "Diagnosis NO"
                .Columns(1).Name = "Diagnosis Name"
            End With

            Call RefreshPatientDataGrid()
            Call RefreshDiagnosisDataGrid()
            Me.SubmitBTN.Enabled = False

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub RefreshPatientDataGrid()
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

    Private Sub RefreshDiagnosisDataGrid()
        Dim RdrDiagnosis As DB2DataReader
        Dim CmdRetDiagnosis As DB2Command
        Dim SelectDiagnosisStr As String
        Dim Row As String()

        SelectDiagnosisStr = "select * from diagnosis"
        CmdRetDiagnosis = New DB2Command(SelectDiagnosisStr, PISconn)
        RdrDiagnosis = CmdRetDiagnosis.ExecuteReader
        Me.DiagnosisView.Rows.Clear()
        While RdrDiagnosis.Read
            Row = New String() {RdrDiagnosis.GetString(0), RdrDiagnosis.GetString(1)}
            DiagnosisView.Rows.Add(Row)
        End While
        RdrDiagnosis.Close()
    End Sub

    Private Sub PatientView_MouseUp(sender As Object, e As MouseEventArgs) Handles PatientView.MouseUp
        Me.patLNameTxt.Text = Me.PatientView.CurrentRow.Cells(2).Value
        Me.patFNameTxt.Text = Me.PatientView.CurrentRow.Cells(1).Value
        Me.patIdTxt.Text = Me.PatientView.CurrentRow.Cells(0).Value
    End Sub

    Private Sub SubmitBTN_Click(sender As Object, e As EventArgs) Handles SubmitBTN.Click
        Try

            Dim patId As String
            Dim diagNo As String
            Dim applyDate As String

            Dim InsertDiagApply As String
            Dim CmdInsertDiagApply As DB2Command


            patId = Me.patIdTxt.Text
            diagNo = Me.diagNoTxt.Text
            applyDate = Me.diagDateTxt.Text

            InsertDiagApply = "insert into diagapply(patid,diagno,applydate) values('" & patId & "','" & diagNo & "','" & applyDate & "')"
            CmdInsertDiagApply = New DB2Command(InsertDiagApply, PISconn)
            CmdInsertDiagApply.ExecuteNonQuery()

            MessageBox.Show("Diagnosis Succesfully Recorded")

            Call RefreshPatientDataGrid()
            Call RefreshDiagnosisDataGrid()
            Call ClearDIagnosisFunction()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub ClearDIagnosisFunction()
        Me.patFNameTxt.Clear()
        Me.patLNameTxt.Clear()
        Me.diagDateTxt.Clear()
        Me.patIdTxt.Clear()
        Me.diagNoTxt.Clear()
        Me.diagnosisTxt.Clear()
    End Sub

    Private Sub AllowSubmit()
        If (Me.patFNameTxt.Text <> "") And (Me.patLNameTxt.Text <> "") And (Me.diagNoTxt.Text <> "") And (Me.diagDateTxt.Text <> "") And (Me.patIdTxt.Text <> "") Then
            Me.SubmitBTN.Enabled = True
        Else
            Me.SubmitBTN.Enabled = False
        End If
    End Sub

    Private Sub diagDateTxt_TextChanged(sender As Object, e As EventArgs) Handles diagDateTxt.TextChanged
        Call AllowSubmit()
    End Sub

    Private Sub patIdSearchTxt_TextChanged(sender As Object, e As EventArgs) Handles patIdSearchTxt.TextChanged
        Try
            Dim SearchPatientStr As String
            Dim CmdSearch As DB2Command
            Dim RdrSearch As DB2DataReader
            Dim SearchPatientStr2 As String
            Dim row As String()

            SearchPatientStr2 = "%" + Me.patIdSearchTxt.Text + "%"
            SearchPatientStr = "Select * from patient where patid like  '" & SearchPatientStr2 & "'"
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

    Private Sub ViewBTN_Click(sender As Object, e As EventArgs) Handles ViewBTN.Click
        PatientDiagnosisViewInformation.Show()
    End Sub

    Private Sub DiagnosisView_MouseUp(sender As Object, e As MouseEventArgs) Handles DiagnosisView.MouseUp
        Me.diagNoTxt.Text = Me.DiagnosisView.CurrentRow.Cells(0).Value
    End Sub

    Private Sub diagNoTxt_TextChanged(sender As Object, e As EventArgs) Handles diagNoTxt.TextChanged
        Call AllowSubmit()
    End Sub

    Private Sub patIdTxt_TextChanged(sender As Object, e As EventArgs) Handles patIdTxt.TextChanged
        Call AllowSubmit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim addDiag As String
        Dim InsertDiagnosis As String
        Dim CmdInsertDiagApply As DB2Command

        addDiag = Me.diagnosisTxt.Text
        InsertDiagnosis = "insert into diagnosis(diagdesc) values('" & addDiag & "')"
        CmdInsertDiagApply = New DB2Command(InsertDiagnosis, PISconn)
        CmdInsertDiagApply.ExecuteNonQuery()

        MessageBox.Show("Diagnosis Succesfully Added")
        Call RefreshDiagnosisDataGrid()
        Call ClearDIagnosisFunction()
    End Sub
End Class