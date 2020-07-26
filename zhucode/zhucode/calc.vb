Public Class calc1
    Public i As Double
    Public oper As String
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        oper = "+"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        oper = "-"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        oper = "*"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        oper = "/"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        oper = "^"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If oper = "+" Then
            Dim x As Double, y As Double
            x = Val(TextBox1.Text)
            y = Val(TextBox3.Text)
            i = x + y
            Label1.Text = i

            oper = "+"
            'TextBox1.Text = Label1.Text
        ElseIf oper = "-" Then
            i = TextBox1.Text - TextBox3.Text
            Label1.Text = i
            oper = "-"
        ElseIf oper = "*" Then
            i = TextBox1.Text * TextBox3.Text
            Label1.Text = i
            oper = "*"
        ElseIf oper = "/" Then
            i = TextBox1.Text / TextBox3.Text
            Label1.Text = i
            oper = "/"
        ElseIf oper = "^" Then
            i = TextBox1.Text ^ TextBox3.Text
            Label1.Text = i
            oper = "^"
        Else
            MsgBox("未指定符号！" & Chr(13) & "请指定!")
            TextBox1.Text = "ERROR"
        End If
        TextBox1.Text = Label1.Text
        TextBox3.Text = ""
    End Sub
End Class