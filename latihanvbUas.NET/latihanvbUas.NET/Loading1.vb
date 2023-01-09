Public Class Loading1

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim I As Double
        Static lctr As Integer

        For I = 1 To 100
            Label1.Text = ProgressBar1.Value
        Next

        If lctr <= 100 Then
            ProgressBar1.Value = lctr
            lctr = lctr + 1
        Else
            'OptionButton.Show()
            'Me.Hide()
            Close()
        End If
    End Sub
End Class