Public Class help
    Private Sub Calc_Click(sender As Object, e As EventArgs) Handles Calc.Click
        Label1.Text = "1.在第一个文本框中输入第1个数字" & Chr(13) &
            "2.按下符号" & Chr(13) &
            "3.在第三个文本框中输入第3个数字" & Chr(13) &
            "2.按下 = "
    End Sub

    Private Sub note_Click(sender As Object, e As EventArgs) Handles note.Click
        Label1.Text = "点击右侧按钮，打开对应笔记"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Label1.Text = "在对话框中输入路径，打开文本文件（如果没有则创建）"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Label1.Text = "点击按钮，创建快捷方式（第1次） " & Chr(13) &
            "点击按钮，运行快捷方式（之后）"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Label1.Text = "输入要朗读的内容" & Chr(13) &
            "点击按钮，朗读"
    End Sub

    Private Sub help_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class