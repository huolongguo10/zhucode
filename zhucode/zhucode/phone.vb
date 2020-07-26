Imports System.ComponentModel

Public Class phone
    Public ifile As Object, iname As Object, sname, sfile, file As String, name1 As String
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Label1.Text = TimeOfDay
    End Sub

    Private Sub phone_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = TimeOfDay


        On Error Resume Next

        Dim MyReader As New System.IO.StreamReader("D:\phone\file.txt", System.Text.Encoding.UTF8)
        ifile = Split(MyReader.ReadToEnd(), ",")
        sfile = MyReader.ReadToEnd
        MyReader.Close()
        MyReader = Nothing


        Dim MyReader1 As New System.IO.StreamReader("D:\phone\name.txt", System.Text.Encoding.UTF8)
        iname = Split(MyReader1.ReadToEnd(), ",")
        sname = MyReader1.ReadToEnd
        MyReader1.Close()
        MyReader1 = Nothing
        'MsgBox(Join(iname))

        Button1.Text = iname(0)
        Button2.Text = iname(1)
        Button3.Text = iname(2)
        Button4.Text = iname(3)
        Button5.Text = iname(4)
        Button6.Text = iname(5)
        Button7.Text = iname(6)
        Button8.Text = iname(7)
        Button9.Text = iname(8)
        Button10.Text = iname(9)
        Button11.Text = iname(10)
        Button12.Text = iname(11)
        Button13.Text = iname(12)
        Button14.Text = iname(13)
        Button15.Text = iname(14)
        Button16.Text = iname(15)
        Button17.Text = iname(16)
        Button18.Text = iname(17)
        Button19.Text = iname(18)
        Button20.Text = iname(19)
        Button21.Text = iname(20)
        Button22.Text = iname(21)
        Button23.Text = iname(22)
        Button24.Text = iname(23)
        Button25.Text = iname(24)
        Button26.Text = iname(25)
        Button27.Text = iname(26)
        Button28.Text = iname(27)
        Button29.Text = iname(28)
        Button30.Text = iname(29)
        Button31.Text = iname(30)
        Button32.Text = iname(31)
        Button33.Text = iname(32)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If ifile(7) = "" Then
qf:         file = InputBox（"程序路径"）
            If file = "" Then
                GoTo qf
            End If
qn:         name1 = InputBox（"程序名称"）
            If name1 = "" Then
                GoTo qn
            End If
            Button8.Text = name1
            ifile(7) = file
            iname(7) = name1
            Shell(ifile(7))
        Else
            Shell(ifile(7))
        End If

        'Shell(ifile(7))

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If ifile(6) = "" Then               '如果没有指定程序
qf:         file = InputBox（"程序路径"）   '获取路径
            If file = "" Then               '没有输入
                GoTo qf                     '重新获取
            End If
qn:         name1 = InputBox（"程序名称"）  '获取名称
            If name1 = "" Then              '没有输入
                GoTo qn                     '重新获取
            End If
            Button7.Text = name1
            ifile(6) = file
            iname(6) = name1
        End If
        Shell(ifile(6))
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If ifile(8) = "" Then
qf:         file = InputBox（"程序路径"）
            If file = "" Then
                GoTo qf
            End If
qn:         name1 = InputBox（"程序名称"）
            If name1 = "" Then
                GoTo qn
            End If
            Button9.Text = name1
            ifile(8) = file
            iname(8) = name1
            Shell(ifile(8))
        Else
            Shell(ifile(8))
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ifile(0) = "" Then

qf:         file = InputBox（"程序路径", "?"）

            If file = "" Then
                GoTo qf
            End If

qn:         name1 = InputBox（"程序名称", "?"）

            If name1 = "" Then
                GoTo qn
            End If

            Button1.Text = name1
            ifile(0) = file
            iname(0) = name1
            Shell(ifile(0))

        Else
            Shell(ifile(0))
        End If
    End Sub

    Private Sub phone_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        sname = Join(iname, ",")
        sfile = Join(ifile, ",")
        savetxt("D:\phone\file.txt", sfile)
        savetxt("D:\phone\name.txt", sname)
    End Sub
    Public Sub savetxt(file As String, Optional text As String = "")
        Dim MyStream As New System.IO.FileStream(file, System.IO.FileMode.Create)
        Dim MyWriter As New System.IO.StreamWriter(MyStream, System.Text.Encoding.Default)
        MyWriter.WriteLine(text)
        MyWriter.Flush()
        MyWriter.Close()
        MyStream.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If ifile(3) = "" Then               '如果没有指定程序
qf:         file = InputBox（"程序路径"）   '获取路径
            If file = "" Then               '没有输入
                GoTo qf                     '重新获取
            End If
qn:         name1 = InputBox（"程序名称"）  '获取名称
            If name1 = "" Then              '没有输入
                GoTo qn                     '重新获取
            End If
            Button4.Text = name1
            ifile(3) = file
            iname(3) = name1
        End If
        Shell(ifile(3))
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If ifile(4) = "" Then               '如果没有指定程序
qf:         file = InputBox（"程序路径"）   '获取路径
            If file = "" Then               '没有输入
                GoTo qf                     '重新获取
            End If
qn:         name1 = InputBox（"程序名称"）  '获取名称
            If name1 = "" Then              '没有输入
                GoTo qn                     '重新获取
            End If
            Button5.Text = name1
            ifile(4) = file
            iname(4) = name1
        End If
        Shell(ifile(4))
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If ifile(5) = "" Then               '如果没有指定程序
qf:         file = InputBox（"程序路径"）   '获取路径
            If file = "" Then               '没有输入
                GoTo qf                     '重新获取
            End If
qn:         name1 = InputBox（"程序名称"）  '获取名称
            If name1 = "" Then              '没有输入
                GoTo qn                     '重新获取
            End If
            Button6.Text = name1
            ifile(5) = file
            iname(5) = name1
        End If
        Shell(ifile(5))
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If ifile(9) = "" Then               '如果没有指定程序
qf:         file = InputBox（"程序路径"）   '获取路径
            If file = "" Then               '没有输入
                GoTo qf                     '重新获取
            End If
qn:         name1 = InputBox（"程序名称"）  '获取名称
            If name1 = "" Then              '没有输入
                GoTo qn                     '重新获取
            End If
            Button10.Text = name1
            ifile(9) = file
            iname(9) = name1
        End If
        Shell(ifile(9))
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If ifile(10) = "" Then              '如果没有指定程序
qf:         file = InputBox（"程序路径"）   '获取路径
            If file = "" Then               '没有输入
                GoTo qf                     '重新获取
            End If
qn:         name1 = InputBox（"程序名称"）  '获取名称
            If name1 = "" Then              '没有输入
                GoTo qn                     '重新获取
            End If
            Button11.Text = name1
            ifile(10) = file
            iname(10) = name1
        End If
        Shell(ifile(10))
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ifile(1) = "" Then               '如果没有指定程序
qf:         file = InputBox（"程序路径"）   '获取路径
            If file = "" Then               '没有输入
                GoTo qf                     '重新获取
            End If
qn:         name1 = InputBox（"程序名称"）  '获取名称
            If name1 = "" Then              '没有输入
                GoTo qn                     '重新获取
            End If
            Button2.Text = name1
            ifile(1) = file
            iname(1) = name1
        End If
        Shell(ifile(1))
    End Sub
    Sub newsu(num As Byte)
        If ifile(num) = "" Then             '如果没有指定程序
qf:         file = InputBox（"程序路径"）   '获取路径
            If file = "" Then               '没有输入
                GoTo qf                     '重新获取
            End If
qn:         name1 = InputBox（"程序名称"）  '获取名称
            If name1 = "" Then              '没有输入
                GoTo qn                     '重新获取
            End If

            ifile(num) = file
            iname(num) = name1
        End If
        Shell(ifile(num))
        Call savetxt("D:\phone\file.txt")
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Call newsu(11)
        Button12.Text = name1
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Call newsu(12)
        Button13.Text = name1
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Call newsu(13)
        Button14.Text = name1
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Call newsu(14)
        Button15.Text = name1
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Call newsu(15)
        Button16.Text = name1
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        Call newsu(21)
        Button22.Text = name1
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        Call newsu(21)
        Button22.Text = name1
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        Call newsu(23)
        Button24.Text = name1
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        Call newsu(24)
        Button26.Text = name1
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        Call newsu(16)
        Button26.Text = name1
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        Call newsu(26)
        Button27.Text = name1
    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        Call newsu(27)
        Button28.Text = name1
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Call newsu(16)
        Button17.Text = name1
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Call newsu(17)
        Button18.Text = name1
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        Call newsu(18)
        Button19.Text = name1
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Call newsu(19)
        Button20.Text = name1
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        Call newsu(20)
        Button21.Text = name1
    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        Call newsu(28)
        Button29.Text = name1
    End Sub

    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        Call newsu(29)
        Button30.Text = name1
    End Sub

    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button31.Click
        Call newsu(30)
        Button31.Text = name1
    End Sub

    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Button32.Click
        Call newsu(31)
        Button32.Text = name1
    End Sub

    Private Sub Button33_Click(sender As Object, e As EventArgs) Handles Button33.Click
        Call newsu(32)
        Button33.Text = name1
    End Sub

    Private Sub phone_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

    End Sub
End Class
