Public Class form1

    Private Sub btnResponder_Click(sender As Object, e As EventArgs) Handles btnResponder.Click
        If (Not cbxEstUnid.Checked AndAlso Not cbxIrlanda.Checked AndAlso Not cbxInglaterra.Checked AndAlso Not cbxMexico.Checked AndAlso Not cbxRussia.Checked AndAlso Not cbxColombia.Checked) Then
            MsgBox("Selecione pelo menos uma alternativa.", MsgBoxStyle.Exclamation, "Atenção")
            Exit Sub
        End If

        If (cbxEstUnid.Checked AndAlso cbxIrlanda.Checked AndAlso cbxInglaterra.Checked AndAlso Not cbxMexico.Checked AndAlso Not cbxRussia.Checked AndAlso Not cbxColombia.Checked) Then
            lblInterrogacao.Text = "Correto!"
        Else
            lblInterrogacao.Text = "Errado!"
        End If
    End Sub
End Class
