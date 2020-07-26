Public Class read



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim s As Object

        s = CreateObject("sapi.spvoice")
        s.speak(RichTextBox1.Text)
    End Sub
End Class