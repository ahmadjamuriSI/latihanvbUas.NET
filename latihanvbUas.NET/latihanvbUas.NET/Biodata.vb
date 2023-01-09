Public Class Biodata
    Dim membaca, musik, olahraga As String
    
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        lblNpm.Text = txtNPM.Text
        lblNama.Text = txtNama.Text
        lblKelamin.Text = cbKelamin.Text
        lblJurusan.Text = cbJurusan.Text
        lblSemester.Text = cbSemester.Text
        lblMembaca.Text = "1" & membaca & vbCrLf & "2" & musik & vbCrLf & "3" & olahraga & vbCrLf

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxmembaca.CheckedChanged
        membaca = CheckBoxMembaca.Text
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxMusik.CheckedChanged
        musik = CheckBoxMusik.Text
    End Sub

    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxOlahraga.CheckedChanged
        olahraga = CheckBoxOlahraga.Text
    End Sub
End Class