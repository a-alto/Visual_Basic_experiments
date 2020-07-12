Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim a As Double = TextBox1.Text
        Dim c As Double = a * 2 * 3.14
        Dim d As Double = a * a * 3.14
        Dim z As Double = 4 / 3 * a * a * a * 3.14
        If TextBox3.Text = "circonferenza" Then
            TextBox2.Text = c
        ElseIf TextBox3.Text = "cerchio" Then
            TextBox2.Text = d
        ElseIf TextBox3.Text = "sfera" Then
            TextBox2.Text = z
        Else
            MsgBox("Parametro errato!")
        End If
    End Sub
End Class
