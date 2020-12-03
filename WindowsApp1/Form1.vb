Public Class Form1
    'Teste comentario para push github
    Private Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        Form2.Show()
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btnSair1.Click
        Dim Excel As New Microsoft.Office.Interop.Excel.Application
        Close()
        Excel.Workbooks.Close()
        Excel.Application.Quit()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox2.PasswordChar = ""
        Else
            TextBox2.PasswordChar = "*"
        End If
    End Sub

End Class
