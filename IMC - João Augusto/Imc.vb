Public Class Imc

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Masc.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If MsgBox("Quer mesmo Sair?",
            MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Femi.Show()
        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
    End Sub
End Class
