Public Class Form1
    'Teste comentario para push github
    Private Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        Dim Excel As New Microsoft.Office.Interop.Excel.Application
        Dim Planilha As New Microsoft.Office.Interop.Excel.Worksheet
        Dim Pasta = Excel.Workbooks.Add
        Dim File As String
        Dim user, password As String
        Dim linha, coluna As Integer

        File = "\\net1\mte\Area Comum\Calibração\Rastreabilidade\Rastreabilidade.xls"
        Excel.Visible = True
        Excel.DisplayAlerts = False
        Excel.DisplayClipboardWindow = False
        Excel.EnableEvents = False
        Excel.ScreenUpdating = False
        Excel.Workbooks.Application.AskToUpdateLinks = False
        Excel.Workbooks.Open(File)

        linha = 4
        coluna = 2
        user = ""
        password = ""

        While user <> TextBox1.Text
            Excel.Application.Worksheets("User").Select
            user = Excel.Cells(linha, coluna).Value
            coluna = coluna + 1
            password = Excel.Cells(linha, coluna).Value
            coluna = coluna - 1
            linha = linha + 1
        End While

        If user = "" Then
            GoTo fim
        End If

        If TextBox1.Text = user Then
            If TextBox2.Text = password Then
                Form2.Show()
            Else
                MessageBox.Show("SENHA INCORRETA", "ERROR", MessageBoxButtons.OK)
                GoTo fim
            End If
        Else
            MessageBox.Show("USUÁRIO INCORRETO", "ERROR", MessageBoxButtons.OK)
            GoTo fim
        End If



        Me.Hide()
        Form2.TextBoxMed.Hide()
        Form2.Label9.Hide()
        Form2.DataGridView2.Hide()

fim:

        Excel.Workbooks.Close()
        Excel.Application.Quit()

    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btnSair1.Click
        Dim Excel As New Microsoft.Office.Interop.Excel.Application
        Me.Close()
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
