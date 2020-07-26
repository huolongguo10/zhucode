Public Class note
    Dim i As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        On Error GoTo Em

        Dim MyReader As New System.IO.StreamReader(Application.StartupPath & "\n1.txt", System.Text.Encoding.UTF8)
        note1.Text = MyReader.ReadToEnd()
        MyReader.Close()
        i = 1
        Exit Sub
Em:
        note1.Text = ""

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        On Error GoTo Em
        Dim MyReader As New System.IO.StreamReader(Application.StartupPath & "\n2.txt", System.Text.Encoding.UTF8)
        note1.Text = MyReader.ReadToEnd()
        MyReader.Close()
        i = 2
        Exit Sub
Em:
        note1.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        On Error Resume Next
        Dim MyReader As New System.IO.StreamReader(Application.StartupPath & "\n3.txt", System.Text.Encoding.UTF8)
        note1.Text = MyReader.ReadToEnd()
        MyReader.Close()
        i = 3
        Exit Sub
Em:
        note1.Text = ""
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        On Error Resume Next
        Dim MyReader As New System.IO.StreamReader(Application.StartupPath & "\n4.txt", System.Text.Encoding.UTF8)
        note1.Text = MyReader.ReadToEnd()
        MyReader.Close()
        i = 4
        Exit Sub
Em:
        note1.Text = ""
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        On Error Resume Next
        Dim MyReader As New System.IO.StreamReader(Application.StartupPath & "\n5.txt", System.Text.Encoding.UTF8)
        note1.Text = MyReader.ReadToEnd()
        MyReader.Close()
        i = 5
        Exit Sub
Em:
        note1.Text = ""
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        On Error Resume Next
        Dim MyReader As New System.IO.StreamReader(Application.StartupPath & "\n6.txt", System.Text.Encoding.UTF8)
        note1.Text = MyReader.ReadToEnd()
        MyReader.Close()
        i = 6
        Exit Sub
Em:
        note1.Text = ""
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        On Error Resume Next
        Dim MyReader As New System.IO.StreamReader(Application.StartupPath & "\n7.txt", System.Text.Encoding.UTF8)
        note1.Text = MyReader.ReadToEnd()
        MyReader.Close()
        i = 7
        Exit Sub
Em:
        note1.Text = ""
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        On Error Resume Next
        Dim MyReader As New System.IO.StreamReader(Application.StartupPath & "\n8.txt", System.Text.Encoding.UTF8)
        note1.Text = MyReader.ReadToEnd()
        MyReader.Close()
        i = 8
        Exit Sub
Em:
        note1.Text = ""
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        On Error Resume Next
        Dim MyStream As New System.IO.FileStream(Application.StartupPath & "\n" & i & ".txt", System.IO.FileMode.Create)

        'Dim MyStream As New System.IO.FileStream(Application.StartupPath & "\Ssk.txt", System.IO.FileMode.Create)
        Dim MyWriter As New System.IO.StreamWriter(MyStream, System.Text.Encoding.Default)
        MyWriter.WriteLine(note1.Text)
        MyWriter.Flush()
        MyWriter.Close()
        MyStream.Close()
    End Sub
End Class