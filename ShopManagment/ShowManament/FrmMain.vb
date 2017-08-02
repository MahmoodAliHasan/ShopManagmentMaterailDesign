Imports System.ComponentModel
Imports System.Data.OleDb
Imports MaterialSkin


Public Class FrmMain

    ' Dim strconn As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\DB_SM.accdb;Jet OLEDB:Database Password=07700998510;"
    ' Dim conn As New OleDbConnection(strconn)
    Dim cmd As New OleDbCommand
    Dim DT As New DataTable
    Dim DR As OleDbDataReader
    Public Row_index As Integer
    Private Sub FrmMain_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Application.Exit()
    End Sub

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Theme_Green()
        Pnl_Info.Location = New Point(0, 661)
        Lbl_username.Text &= Frm_Login.Txt_username.Text
        DGV_Fill()
        Total_DGV()
        Pnl_About.Location = New Point(-Pnl_About.Width, Pnl_About.Location.Y)
    End Sub

    Sub Theme_Green()
        Dim skinmanage As MaterialSkinManager = MaterialSkinManager.Instance
        skinmanage.AddFormToManage(Me)
        skinmanage.Theme = MaterialSkinManager.Themes.LIGHT
        skinmanage.ColorScheme = New ColorScheme(Primary.Green300, Primary.Green500, Primary.Green100, Accent.Green100, TextShade.WHITE)

    End Sub

    Private Sub Pic_Add_Click(sender As Object, e As EventArgs) Handles Pic_Add.Click
        add_upd = "add"
        clear_Txt()
        timer_add_falg = True
        pnl_Add.Location = New Point(pnl_Add.Location.X, pnl_Add.Location.Y + pnl_Add.Height)
        pnl_Add.Visible = True
        Tmr_Add.Enabled = True
    End Sub
    Dim timer_add_falg As Boolean = False
    Private Sub Tmr_Add_Tick(sender As Object, e As EventArgs) Handles Tmr_Add.Tick
        If pnl_Add.Location.Y >= 661 And timer_add_falg = True Then
            pnl_Add.Location = New Point(pnl_Add.Location.X, pnl_Add.Location.Y - 4)
        ElseIf timer_add_falg = False And pnl_Add.Location.Y <= 660 + pnl_Add.Height
            pnl_Add.Location = New Point(pnl_Add.Location.X, pnl_Add.Location.Y + 4)
        Else



        End If
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles Pic_Hide_Info.Click
        timer_add_falg = False
    End Sub


    Private Sub Txt_Search_TextChanged(sender As Object, e As EventArgs) Handles Txt_Search.TextChanged
        Search_DGV()
    End Sub

    Sub Search_DGV()
        Try
            Dim count As Integer = 0
            DGV.Rows.Clear()
            Dim val As String = Txt_Search.Text
            Dim sql As String = "select * from  shop where item like '" & val & "%' or num like '" & val & "%' or price like'" & val & "%'"

            cmd = New OleDbCommand(sql, conn)
            If conn.State = 0 Then conn.Open()
            DR = cmd.ExecuteReader
            If DR.Read = True Then
                Do
                    DGV.Rows.Add(DR.Item("item"), DR.Item("price"), DR.Item("num"), DR.Item("num") * DR.Item("price"))

                Loop While DR.Read

            End If
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub


    Sub Total_DGV()
        Try
            Dim total As Double = 0

            For i = 0 To DGV.RowCount - 1
                total += CDbl(DGV.Item(3, i).Value)
            Next
            lbl_total.Text = total
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub


    Private Sub DGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellContentClick
        Try
            If DGV.CurrentCell.ColumnIndex = 4 Then
                If MsgBox("هل تود بالفعل حذف  هذه البيانات من الجدول", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton1, "تاكيد الحذف ") = MsgBoxResult.Yes Then
                    Try
                        Dim val = DGV(6, DGV.CurrentCell.RowIndex).Value
                        'MsgBox(val)
                        Dim sql As String = "Delete * from shop  where id = " & val & " "
                        'MsgBox(sql)
                        cmd = New OleDbCommand(sql, conn)
                        If conn.State = 0 Then conn.Open()
                        cmd.ExecuteNonQuery()
                        conn.Close()
                        DGV.Rows.RemoveAt(DGV.CurrentCell.RowIndex)
                        ' MsgBox(DGV(6, DGV.CurrentCell.RowIndex).Value)
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                    Total_DGV()
                End If
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub DGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellClick
        If DGV.CurrentCell.ColumnIndex = 5 Then

            If DGV.CurrentCell.Value = True Then
                DGV.CurrentCell.Value = False
            Else
                DGV.CurrentCell.Value = True
            End If
        End If

        If add_upd = "upd" Then
            Fill_Txt()
        End If
    End Sub
    Dim add_upd As String = ""
    Private Sub Pic_Insert_Click(sender As Object, e As EventArgs) Handles Pic_Insert.Click
        If add_upd = "add" Then

            If Txt_price.Text = "" Then Txt_price.Text = "0"
            If Txt_num.Text = "" Then Txt_num.Text = "0"

            If IsNumeric(Txt_num.Text) And IsNumeric(Txt_price.Text) Then

                If Txt_item.Text = "" Then Txt_item.Text = ""
                Insert_DGV()
                clear_Txt()
                Total_DGV()
            Else
                MsgBox("يجب ان يكون السعر و العدد ارقام وليست حروف !!!!!!!!!!!!!")
            End If
        Else
            If add_upd = "upd" Then
                If Txt_price.Text = "" Then Txt_price.Text = "0"
                If Txt_num.Text = "" Then Txt_num.Text = "0"

                If IsNumeric(Txt_num.Text) And IsNumeric(Txt_price.Text) Then

                    If Txt_item.Text = "" Then Txt_item.Text = ""
                    Uodate_DGV()
                    clear_Txt()
                    Total_DGV()
                Else
                    MsgBox("يجب ان يكون السعر و العدد ارقام وليست حروف !!!!!!!!!!!!!")
                End If
            Else

            End If
        End If


    End Sub

    Sub clear_Txt()
        Txt_item.Clear()
        Txt_num.Clear()
        Txt_price.Clear()
    End Sub
    Private Sub Pic_Refresh_Click(sender As Object, e As EventArgs) Handles Pic_Refresh.Click
        DGV_Fill()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Lbl_num.Text = DGV.RowCount
    End Sub
    Sub Fill_Txt()
        Row_index = DGV.CurrentCell.RowIndex
        Txt_item.Text = DGV.Item(0, Row_index).Value
        Txt_price.Text = DGV.Item(1, Row_index).Value
        Txt_num.Text = DGV.Item(2, Row_index).Value

    End Sub
    Private Sub Pic_Update_Click(sender As Object, e As EventArgs) Handles Pic_Update.Click
        add_upd = "upd"
        timer_add_falg = True
        pnl_Add.Location = New Point(pnl_Add.Location.X, pnl_Add.Location.Y + pnl_Add.Height)
        pnl_Add.Visible = True
        Tmr_Add.Enabled = True
        Fill_Txt()

    End Sub

    Private Sub Ch_Select_CheckedChanged(sender As Object, e As EventArgs) Handles Ch_Select.CheckedChanged
        If Ch_Select.Checked = True Then
            For i = 0 To DGV.RowCount - 1
                If DGV.Item(5, i).Value = False Then
                    DGV.Item(5, i).Value = True
                End If
            Next
        Else
            For i = 0 To DGV.RowCount - 1
                If DGV.Item(5, i).Value = True Then
                    DGV.Item(5, i).Value = False
                End If
            Next
        End If

    End Sub

    Private Sub Pic_Delete_Click(sender As Object, e As EventArgs) Handles Pic_Delete.Click
        If MsgBox("هل تود بالفعل حذف المحدد ", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton1, "تاكيد") = MsgBoxResult.Yes Then
            Delete_Selected()
            DGV_Fill()
        End If
    End Sub
    Sub Delete_Selected()
        Dim RowsCount As Integer = DGV.RowCount - 1
        For i = 0 To RowsCount
            If DGV.Item(5, i).Value = True Then
                Try
                    Dim sql As String = "delete * from shop  where id = ?"
                    cmd = New OleDbCommand(sql, conn)
                    If conn.State = 0 Then conn.Open()
                    cmd.Parameters.Add(New OleDbParameter("id", DGV.Item(6, i).Value))
                    cmd.ExecuteNonQuery()
                    conn.Close()

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

            End If

        Next

    End Sub


    Sub Enter_Pic(ByRef pic As PictureBox)
        pic.Width += 10
        pic.Height += 10
        pic.Location = New Point(pic.Location.X - 5, pic.Location.Y - 5)
    End Sub
    Sub Leave_Pic(ByRef pic As PictureBox)
        pic.Width -= 10
        pic.Height -= 10
        pic.Location = New Point(pic.Location.X + 5, pic.Location.Y + 5)
    End Sub
    Sub Press_Pic(ByRef pic As PictureBox)
        pic.Width += 16
        pic.Height += 16
        pic.Location = New Point(pic.Location.X - 8, pic.Location.Y - 8)
    End Sub
    Sub UnPress_Pic(ByRef pic As PictureBox)
        pic.Width -= 16
        pic.Height -= 16
        pic.Location = New Point(pic.Location.X + 8, pic.Location.Y + 8)
    End Sub
#Region "Pic effect in my programm"
    Private Sub Pic_Change_Pass_MouseEnter(sender As Object, e As EventArgs) Handles Pic_Change_Pass.MouseEnter
        Enter_Pic(Pic_Change_Pass)
    End Sub

    Private Sub Pic_Change_Pass_MouseLeave(sender As Object, e As EventArgs) Handles Pic_Change_Pass.MouseLeave
        Leave_Pic(Pic_Change_Pass)
    End Sub

    Private Sub Pic_Change_Pass_MouseDown(sender As Object, e As MouseEventArgs) Handles Pic_Change_Pass.MouseDown
        Press_Pic(Pic_Change_Pass)
    End Sub

    Private Sub Pic_Change_Pass_MouseUp(sender As Object, e As MouseEventArgs) Handles Pic_Change_Pass.MouseUp
        UnPress_Pic(Pic_Change_Pass)
    End Sub

    '===========
    Private Sub Pic_Add_MouseEnter(sender As Object, e As EventArgs) Handles Pic_Add.MouseEnter
        Enter_Pic(Pic_Add)
    End Sub

    Private Sub Pic_Add_MouseLeave(sender As Object, e As EventArgs) Handles Pic_Add.MouseLeave
        Leave_Pic(Pic_Add)
    End Sub

    Private Sub Pic_Add_MouseDown(sender As Object, e As MouseEventArgs) Handles Pic_Add.MouseDown
        Press_Pic(Pic_Add)
    End Sub

    Private Sub Pic_Add_MouseUp(sender As Object, e As MouseEventArgs) Handles Pic_Add.MouseUp
        UnPress_Pic(Pic_Add)
    End Sub

    '==================
    Private Sub Pic_Delete_MouseEnter(sender As Object, e As EventArgs) Handles Pic_Delete.MouseEnter
        Enter_Pic(Pic_Delete)
    End Sub

    Private Sub Pic_Delete_MouseLeave(sender As Object, e As EventArgs) Handles Pic_Delete.MouseLeave
        Leave_Pic(Pic_Delete)
    End Sub

    Private Sub Pic_Delete_MouseDown(sender As Object, e As MouseEventArgs) Handles Pic_Delete.MouseDown
        Press_Pic(Pic_Delete)
    End Sub

    Private Sub Pic_Delete_MouseUp(sender As Object, e As MouseEventArgs) Handles Pic_Delete.MouseUp
        UnPress_Pic(Pic_Delete)
    End Sub
    '======================
    Private Sub Pic_Insert_MouseEnter(sender As Object, e As EventArgs) Handles Pic_Insert.MouseEnter
        Enter_Pic(Pic_Insert)
    End Sub

    Private Sub Pic_Insert_MouseLeave(sender As Object, e As EventArgs) Handles Pic_Insert.MouseLeave
        Leave_Pic(Pic_Insert)
    End Sub

    Private Sub Pic_Insert_MouseDown(sender As Object, e As MouseEventArgs) Handles Pic_Insert.MouseDown
        Press_Pic(Pic_Insert)
    End Sub

    Private Sub Pic_Insert_MouseUp(sender As Object, e As MouseEventArgs) Handles Pic_Insert.MouseUp
        UnPress_Pic(Pic_Insert)
    End Sub
    '======================
    Private Sub Pic_Update_MouseEnter(sender As Object, e As EventArgs) Handles Pic_Update.MouseEnter
        Enter_Pic(Pic_Update)
    End Sub

    Private Sub Pic_Update_MouseLeave(sender As Object, e As EventArgs) Handles Pic_Update.MouseLeave
        Leave_Pic(Pic_Update)
    End Sub

    Private Sub Pic_Update_MouseDown(sender As Object, e As MouseEventArgs) Handles Pic_Update.MouseDown
        Press_Pic(Pic_Update)
    End Sub

    Private Sub Pic_Update_MouseUp(sender As Object, e As MouseEventArgs) Handles Pic_Update.MouseUp
        UnPress_Pic(Pic_Update)
    End Sub
    '======================

    Private Sub Pic_Refresh_MouseEnter(sender As Object, e As EventArgs) Handles Pic_Refresh.MouseEnter
        Enter_Pic(Pic_Refresh)
    End Sub

    Private Sub Pic_Refresh_MouseLeave(sender As Object, e As EventArgs) Handles Pic_Refresh.MouseLeave
        Leave_Pic(Pic_Refresh)
    End Sub

    Private Sub Pic_Refresh_MouseDown(sender As Object, e As MouseEventArgs) Handles Pic_Refresh.MouseDown
        Press_Pic(Pic_Refresh)
    End Sub

    Private Sub Pic_Refresh_MouseUp(sender As Object, e As MouseEventArgs) Handles Pic_Refresh.MouseUp
        UnPress_Pic(Pic_Refresh)
    End Sub
    '======================

    Private Sub Pic_Hide_Info_MouseEnter(sender As Object, e As EventArgs) Handles Pic_Hide_Info.MouseEnter
        Enter_Pic(Pic_Hide_Info)
    End Sub

    Private Sub Pic_Hide_Info_MouseLeave(sender As Object, e As EventArgs) Handles Pic_Hide_Info.MouseLeave
        Leave_Pic(Pic_Hide_Info)
    End Sub

    Private Sub Pic_Hide_Info_MouseDown(sender As Object, e As MouseEventArgs) Handles Pic_Hide_Info.MouseDown
        Press_Pic(Pic_Hide_Info)
    End Sub

    Private Sub Pic_Hide_Info_MouseUp(sender As Object, e As MouseEventArgs) Handles Pic_Hide_Info.MouseUp
        UnPress_Pic(Pic_Hide_Info)
    End Sub
    '======================

    Private Sub Pic_About_MouseEnter(sender As Object, e As EventArgs) Handles Pic_About.MouseEnter
        Enter_Pic(Pic_About)
    End Sub

    Private Sub Pic_About_MouseLeave(sender As Object, e As EventArgs) Handles Pic_About.MouseLeave
        Leave_Pic(Pic_About)
    End Sub

    Private Sub Pic_About_MouseDown(sender As Object, e As MouseEventArgs) Handles Pic_About.MouseDown
        Press_Pic(Pic_About)
    End Sub

    Private Sub Pic_About_MouseUp(sender As Object, e As MouseEventArgs) Handles Pic_About.MouseUp
        UnPress_Pic(Pic_About)
    End Sub


    '======================


#End Region
#Region " "

#End Region

    Private Sub Pic_Change_Pass_Click(sender As Object, e As EventArgs) Handles Pic_Change_Pass.Click
        Tmr_Frm_Effect.Enabled = True
        FrmChangePassName.Location = New Point(280, -FrmChangePassName.Height + 10)
        FrmChangePassName.ShowDialog()

    End Sub

    Private Sub FrmEffect_Tick(sender As Object, e As EventArgs) Handles Tmr_Frm_Effect.Tick

        If FrmChangePassName.Location.Y <= 130 Then
            FrmChangePassName.Location = New Point(FrmChangePassName.Location.X, FrmChangePassName.Location.Y + 10)
        Else
            Tmr_Frm_Effect.Enabled = False
        End If
    End Sub

    Private Sub Pic_About_Click(sender As Object, e As EventArgs) Handles Pic_About.Click
        Show_Pnl_About = True
        Tmr_About.Enabled = True

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start("https://www.facebook.com/Mahmood.Ali.Ma")
    End Sub
    Dim Show_Pnl_About As Boolean
    Private Sub Pic_Pnl_About_Hide_Click(sender As Object, e As EventArgs) Handles Pic_Pnl_About_Hide.Click
        Show_Pnl_About = False
    End Sub

    Private Sub Tmr_About_Tick(sender As Object, e As EventArgs) Handles Tmr_About.Tick
        If Pnl_About.Location.X <= 441 And Show_Pnl_About = True Then

            Pnl_About.Location = New Point(Pnl_About.Location.X + 30, Pnl_About.Location.Y)

        ElseIf Pnl_About.Location.X > -Pnl_About.Width And Show_Pnl_About = False
            Pnl_About.Location = New Point(Pnl_About.Location.X - 50, Pnl_About.Location.Y)

            '  Pnl_About.Location = New Point(-Pnl_About.Width, Pnl_About.Location.Y)
            ' Tmr_About.Enabled = False
        End If
    End Sub
End Class