Public Class SecretaryMenuFrm


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim EditPatientFrm As New PatientEditFrm
        EditPatientFrm.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim DeletePatientFrm As New PatientDeleteFrm
        DeletePatientFrm.Show()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim AddEmployeeFrm As New EmployeeAddFrm
        AddEmployeeFrm.Show()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim EditEmployeeFrm As New EmployeeEditFrm
        EditEmployeeFrm.Show()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim DelEmployeeFrm As New EmployeeDeleteFrm
        DelEmployeeFrm.Show()

    End Sub

    Private Sub SecretaryMenuFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Close()
    End Sub
End Class