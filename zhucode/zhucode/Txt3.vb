Public Class Txt3
    Public i As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        RichTextBox1.Text = ""
        On Error Resume Next
        i = InputBox("路径")
        Dim MyReader As New System.IO.StreamReader(i, System.Text.Encoding.UTF8)
        RichTextBox1.Text = MyReader.ReadToEnd()
        MyReader.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim MyStream As New System.IO.FileStream(i, System.IO.FileMode.Create)
        Dim MyWriter As New System.IO.StreamWriter(MyStream, System.Text.Encoding.Default)
        MyWriter.WriteLine(RichTextBox1.Text)
        MyWriter.Flush()
        MyWriter.Close()
        MyStream.Close()

    End Sub
End Class