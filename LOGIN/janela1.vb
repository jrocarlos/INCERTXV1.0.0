Public Class Janela1

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles TÍTULO.Click

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub SAIR_Click(sender As Object, e As EventArgs) Handles SAIR.Click
        Me.Close()
    End Sub

    Private Sub INICIAR_Click(sender As Object, e As EventArgs) Handles INICIAR.Click
        janela2.Show()

    End Sub

    Private Sub A_CheckedChanged(sender As Object, e As EventArgs) Handles A.CheckedChanged
        Dim v As Boolean = If(A.Checked() = False, False, True)
        Q1.Enabled = v
    End Sub

    Private Sub B_CheckedChanged(sender As Object, e As EventArgs) Handles B.CheckedChanged
        If B.Checked() = False Then
            Q2.Enabled = False
        Else
            Q2.Enabled = True
        End If
    End Sub

    Private Sub janela1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Q1_TextChanged(sender As Object, e As EventArgs) Handles Q1.TextChanged

    End Sub

    Private Sub TITU_TextChanged(sender As Object, e As EventArgs) Handles TITU.TextChanged

    End Sub

    Private Sub BindingSource1_CurrentChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub
End Class