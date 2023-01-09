Public Class TampilanFrom1

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
   
    
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TampilanForm2.TextBox1.Text = (Me.TextBox1.Text)
        TampilanForm2.TextBox2.Text = (Me.TextBox2.Text)
        TampilanForm2.Show()
    End Sub
End Class