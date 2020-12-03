Public Class Form2
    Private Sub AddTab()
        Dim Body As New RichTextBox()
        Body.Name = "Body"
        Body.Dock = DockStyle.Fill

        ' Body.ContextMenuStrip = ContextMenuStrip1
        Dim NewPage As New TabPage()
        Dim TabCount As Integer
        TabCount += 1
        Dim DocumentText As String = "Document " & TabCount
        NewPage.Name = DocumentText
        NewPage.Text = DocumentText

        NewPage.Controls.Add(Body)

        'TabControl1.TabPages.Add(NewPage)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call AddTab()


    End Sub

    Private Sub btnSair3_Click(sender As Object, e As EventArgs) Handles btnSair3.Click
        Me.Close()
        Form1.Close()

    End Sub

    Private Sub ToolStripContainer1_TopToolStripPanel_Click(sender As Object, e As EventArgs) Handles ToolStripContainer1.TopToolStripPanel.Click, TopToolStripPanel.Click

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim Inc As Double
        Dim IncExp As Double
        Dim Grau As Double
        Dim DivGrau As Double

        Inc = TextBoxCont.Text / TextBoxDiv.Text
        TextBoxInc.Text = Inc

        IncExp = TextBoxInc.Text * TextBoxCoe.Text
        TextBoxExp.Text = IncExp

        If ComboBox1.Text = "A" Then
            Grau = TextBoxMed.Text - 1
            TextBoxGra.Text = Grau
        Else
            TextBoxGra.Text = ""
        End If

        DivGrau = (IncExp ^ 4) / Grau
        TextBoxDivGrau.Text = DivGrau

    End Sub

    Private Sub btnInserir_Click(sender As Object, e As EventArgs) Handles btnInserir.Click
        Me.DataGridView1.Rows.Add(ComboBox1.Text, TextBoxCont.Text, TextBoxDiv.Text, TextBoxInc.Text, TextBoxCoe.Text, TextBoxExp.Text, TextBoxGra.Text, TextBoxDivGrau.Text)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "A" Then
            TextBoxMed.Show()
            Label9.Show()
            DataGridView2.Show()

        Else
            TextBoxMed.Hide()
            Label9.Hide()
            DataGridView2.Hide()
        End If

    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        Dim myvalue As Object
        Dim parar, num, i, o As Integer
        Dim message, title, value As String
        Dim desv, avg As Long

        message = "INSIRA O VALOR MEDIDO:"
        title = "MEDIÇÕES"
        value = ""
        parar = 0

        While parar = 0
            myvalue = InputBox(message, title, value)

            Me.DataGridView2.Rows.Add(myvalue)
            If myvalue = "" Then
                parar = 1
            End If
        End While
        num = DataGridView2.RowCount.ToString - 2
        TextBoxMed.Text = num

        For i = 0 To num - 1
            o = o + Convert.ToDouble(DataGridView2.Rows(i).Cells(0).Value)
        Next

        TextBoxCont.Text = o.ToString
        TextBoxCont.Text = TextBoxCont.Text / TextBoxMed.Text
        avg = TextBoxCont.Text
        i = 0
        num = TextBoxMed.Text
        For i = 0 To num - 1
            o = o + (((Convert.ToDouble(DataGridView2.Rows(i).Cells(0).Value)) - avg) ^ 2)
        Next

        desv = o / num
        desv = Math.Sqrt(desv)

        TextBoxDiv.Text = desv

    End Sub

End Class



