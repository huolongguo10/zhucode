Public Class zhucode

    Private Sub Calc_Click(sender As Object, e As EventArgs) Handles Calc.Click
        calc1.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        note.Show()
    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'OpenFileDialog1.ShowDialog()
        Txt3.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        phone.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        read.Show()
    End Sub



    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        help.Show()
    End Sub

    Private Sub zhucode_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Environment.GetEnvironmentVariable("PROCESSOR_ARCHITECTURE").IndexOf("64") <> -1 Then
            '64位系统
            Label1.Text = My.Computer.Info.OSFullName & My.Computer.Info.OSVersion ' & "  64位系统"
        Else
            '32位系统
            Label1.Text = My.Computer.Info.OSFullName & My.Computer.Info.OSVersion '& "  32位系统"
        End If
        'Label1.Text = My.Computer.Info.OSFullName & My.Computer.Info.OSVersion
    End Sub
End Class
