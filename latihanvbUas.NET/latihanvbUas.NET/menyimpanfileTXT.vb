
Public Class menyimpanfileTXT
    Dim fileWriter As IO.StreamWriter
    Dim nama, alamat As String
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            fileWriter = New IO.StreamWriter("C:\Users\User\Desktop\latihan menju UAS vb.NET\latihanvbUas.NET\Biodata.txt")
            fileWriter.Write(nama)
            fileWriter.Write(alamat)

            fileWriter.Close()
            MessageBox.Show("")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        nama = TextBox1.Text
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        alamat = TextBox2.Text
    End Sub
End Class