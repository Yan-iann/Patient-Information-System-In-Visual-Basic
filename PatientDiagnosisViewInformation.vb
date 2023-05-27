Imports IBM.Data.DB2
Public Class PatientDiagnosisViewInformation
    Dim PISconn As Common.DbConnection
    Private Sub PatientDiagnosisViewInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            PISconn = New DB2Connection("server=localhost;database=patient;" + "uid=db2admin;password=db2admin;")
            PISconn.Open()
            With Me.PatientDiagnosisView
                PatientDiagnosisView.ReadOnly = True
                PatientDiagnosisView.AllowUserToResizeRows = False
                PatientDiagnosisView.AllowUserToResizeColumns = False
                .ColumnCount = 4
                .Columns(0).Name = "Apply ID"
                .Columns(1).Name = "Patient ID"
                .Columns(2).Name = "Diagnosis NO"
                .Columns(3).Name = "Apply Date"
            End With
            Call RefreshDataGrid()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub RefreshDataGrid()
        Dim RdrDiagApply As DB2DataReader
        Dim CmdRetDiagApply As DB2Command
        Dim SelectDiagApplyStr As String
        Dim Row As String()

        SelectDiagApplyStr = "select * from diagapply"
        CmdRetDiagApply = New DB2Command(SelectDiagApplyStr, PISconn)
        RdrDiagApply = CmdRetDiagApply.ExecuteReader
        Me.PatientDiagnosisView.Rows.Clear()
        While RdrDiagApply.Read
            Row = New String() {RdrDiagApply.GetString(0), RdrDiagApply.GetString(1), RdrDiagApply.GetString(2), RdrDiagApply.GetString(3)}
            PatientDiagnosisView.Rows.Add(Row)
        End While
        RdrDiagApply.Close()
    End Sub

    Private Sub PatientDiagnosisView_MouseUp(sender As Object, e As MouseEventArgs) Handles PatientDiagnosisView.MouseUp
        Dim StrpatLname As String
        Dim StrDiag As String
        Dim LnameId As String
        Dim diag As String
        Dim CmdL As DB2Command
        Dim CmdD As DB2Command
        Dim RdrLname As DB2DataReader
        Dim RdrDiag As DB2DataReader
        Dim lname As String
        Dim desc As String

        LnameId = Me.PatientDiagnosisView.CurrentRow.Cells(1).Value

        StrpatLname = "select * from patient where patid = '" & LnameId & "'"
        CmdL = New DB2Command(StrpatLname, PISconn)
        RdrLname = CmdL.ExecuteReader
        RdrLname.Read()
        lname = RdrLname.GetString(2)
        patLNameTxt.Text = lname
        RdrLname.Close()

        diag = Me.PatientDiagnosisView.CurrentRow.Cells(2).Value

        StrDiag = "select * from diagnosis where diagno = '" & diag & "'"
        CmdD = New DB2Command(StrDiag, PISconn)
        RdrDiag = CmdD.ExecuteReader
        RdrDiag.Read()
        desc = RdrDiag.GetString(1)
        diagDescTxt.Text = desc
        RdrDiag.Close()

        Me.patIdTxt.Text = Me.PatientDiagnosisView.CurrentRow.Cells(1).Value
        Me.diagnoTxt.Text = Me.PatientDiagnosisView.CurrentRow.Cells(2).Value
        Me.applyDateTxt.Text = Me.PatientDiagnosisView.CurrentRow.Cells(3).Value

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PatientDiagnosisFrm.Show()
        Me.Close()
    End Sub
End Class