Imports System.ComponentModel
Imports System.Data.OleDb
Imports MaterialSkin

Public Class FrmChangePassName
    Dim cmd As New OleDbCommand
    Dim DR As OleDbDataReader
    Private Sub FrmChangePassName_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Theme_Organge()
        Txt_New_Username.Select()
        Txt_username.Hint = "الاسم القديم"
        Txt_pass.Hint = "كلمة المرور القديمة"
        Txt_New_Username.Hint = "الاسم الجديد"
        Txt_New_Pass1.Hint = "كلمة المرور الجديدة"
        Txt_New_Pass2.Hint = "اعادة كلمة المرور"

    End Sub

    Sub Theme_Organge()
        Dim skinmanage As MaterialSkinManager = MaterialSkinManager.Instance
        skinmanage.AddFormToManage(Me)
        skinmanage.Theme = MaterialSkinManager.Themes.LIGHT
        skinmanage.ColorScheme = New ColorScheme(Primary.Orange300, Primary.Orange500, Primary.Green100, Accent.Green100, TextShade.WHITE)

    End Sub

    Dim Check_Old_Username_Pass As Boolean
    Sub check_username_pass()
        Try
            Dim sql As String = " Select * from login "
            cmd = New OleDbCommand(sql, conn)
            If conn.State = 0 Then conn.Open()
            DR = cmd.ExecuteReader
            If DR.Read = True Then
                If Txt_username.Text = DR.Item("username") And Txt_pass.Text = DR.Item("pass") Then

                    Check_Old_Username_Pass = True

                ElseIf Txt_username.Text = "" Or Txt_pass.Text = ""
                    MsgBox("من فضلك اكتب اسم المستخدم او كلمة المرور")
                    Check_Old_Username_Pass = False
                Else
                    MsgBox("تحقق من اسم المستخدم او كلمة المرور القديمتين")
                    Check_Old_Username_Pass = False
                End If
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub Update_Username_Pass()
        Try
            Dim trans As OleDbTransaction
            Dim sql As String = "update login set username =?  , pass =?  "

            cmd = New OleDbCommand(sql, conn)
            If conn.State = 0 Then conn.Open()
            cmd.Parameters.Add(New OleDbParameter("username", Txt_New_Username.Text))
            cmd.Parameters.Add(New OleDbParameter("pass", Txt_New_Pass1.Text))
            cmd.ExecuteNonQuery()
            trans = conn.BeginTransaction
            trans.Commit()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub
    Private Sub Btn_Check_Click(sender As Object, e As EventArgs) Handles Btn_Check.Click
        check_username_pass()
        If Check_Old_Username_Pass = True Then
            If Txt_New_Username.Text = "" Or Txt_New_Pass1.Text = "" Or Txt_New_Pass2.Text = "" Then
                MessageBox.Show("هلا قمت بملئ جميع الحقول من فضلك  ^^", "خطا")
            ElseIf Txt_New_Pass1.Text <> Txt_New_Pass2.Text Then
                MessageBox.Show("كلمة المرور غير متطابقة ", "خطا")
            Else
                Update_Username_Pass()
                MessageBox.Show("تم تغير اسم المستخدم وكلمة المرور ", "Team-L")
                Timer1.Enabled = True
            End If
        End If
    End Sub

    Private Sub Btn_Cancel_Click(sender As Object, e As EventArgs) Handles Btn_Cancel.Click
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Me.Location.Y <= 730 + Me.Height Then
            Me.Location = New Point(Me.Location.X, Me.Location.Y + 20)
        Else
            Me.Close()
            FrmMain.Theme_Green()
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub FrmChangePassName_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        FrmMain.Theme_Green()
    End Sub
End Class