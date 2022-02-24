Public Class Femi
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtCalc.Click
        Dim alt, peso, altura, conta As Single

        Try
            alt = TextBox1.Text
            peso = TextBox2.Text


            altura = alt * alt
            conta = peso / altura

        Catch ex As Exception
            MsgBox("Algo deu errado. Tente novamente!", vbCritical
                   )
            Label3.Text = ("")
        End Try

        If conta < 19 Then
            Label3.Text = ("Seu imc está Abaixo do normal, imc:" & " " & conta)
        ElseIf conta <= 23.9 Then
            Label3.Text = ("Seu imc está normal, imc:" & " " & conta)
        ElseIf conta <= 28.9 Then
            Label3.Text = ("Seu imc está em Obesidade leve, imc:" & " " & conta)
        ElseIf conta <= 38.9 Then
            Label3.Text = ("Seu imc está em obesidade moderada, imc:" & " " & conta)
        Else
            Label3.Text = ("Seu imc está em obesidade morbida, imc:" & " " & conta)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BtClear.Click
        TextBox1.Clear()
        TextBox2.Clear()
        Label3.Text = ("")




    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtBack.Click
        Imc.Show()
        Me.Close()


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles BtTabela.Click
        Tabela.Show()
        Me.Close()


    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Feminino_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class