Public Class Class1
    Function opentxt(file As String)
        On Error Resume Next
        Dim MyReader As New System.IO.StreamReader(file, System.Text.Encoding.UTF8)
        opentxt = MyReader.ReadToEnd()
        MyReader.Close()
        If file = "" Then
            Call savetxt(file)
        End If
    End Function
    Public Sub savetxt(file As String, Optional text As String = "")
        Dim MyStream As New System.IO.FileStream(file, System.IO.FileMode.Create)
        Dim MyWriter As New System.IO.StreamWriter(MyStream, System.Text.Encoding.Default)
        MyWriter.WriteLine(text)
        MyWriter.Flush()
        MyWriter.Close()
        MyStream.Close()
    End Sub


End Class
