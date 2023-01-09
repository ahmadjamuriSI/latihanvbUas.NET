Public Class OptionButton

    Private Sub rbSotoAyam_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbSotoAyam.CheckedChanged
        Label2.Text = rbSotoAyam.Text
    End Sub

    Private Sub rbSotoDaging_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbSotoDaging.CheckedChanged
        Label2.Text = rbSotoDaging.Text
    End Sub

    Private Sub rbSotoIga_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbSotoIga.CheckedChanged
        Label2.Text = rbSotoIga.Text
    End Sub

    Private Sub rbTehManis_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbTehManis.CheckedChanged
        Label3.Text = rbTehManis.Text
    End Sub

    Private Sub rbEsTeh_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbEsTeh.CheckedChanged
        Label3.Text = rbEsTeh.Text
    End Sub

    Private Sub rbEsJeruk_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbEsJeruk.CheckedChanged
        Label3.Text = rbEsJeruk.Text
    End Sub
End Class