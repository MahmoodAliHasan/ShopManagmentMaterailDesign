Imports System.Data.OleDb

Module Mod_Connection

    Public strconn As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\DB_SM.accdb;Jet OLEDB:Database Password=07700998510;"
    Public conn As New OleDbConnection(strconn)
    Dim cmd As New OleDbCommand
    Dim DT As New DataTable
    Dim DR As OleDbDataReader


    Sub check_username_pass()
        Try
            Dim sql As String = " Select * from login "
            cmd = New OleDbCommand(sql, conn)
            If conn.State = 0 Then conn.Open()
            DR = cmd.ExecuteReader
            If DR.Read = True Then
                If Frm_Login.Txt_username.Text = DR.Item("username") And Frm_Login.Txt_pass.Text = DR.Item("pass") Then
                    conn.Close()
                    Frm_Login.Theme_blue()
                    Frm_Login.Hide()
                    FrmMain.Show()
                ElseIf Frm_Login.Txt_username.Text = "" Or Frm_Login.Txt_pass.Text = ""
                    MsgBox("من فضلك اكتب اسم المستخدم او كلمة المرور")

                Else
                    MsgBox("تحقق من اسم المستخدم او كلمة المرور")
                    Frm_Login.Theme_Red()
                End If
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub
    Sub DGV_Fill()

        Try
            Dim count As Integer = 0
            FrmMain.DGV.Rows.Clear()
            Dim sql As String = "select * from  shop"
            cmd = New OleDbCommand(sql, conn)
            If conn.State = 0 Then conn.Open()
            DR = cmd.ExecuteReader
            If DR.Read = True Then
                Do
                    FrmMain.DGV.Rows.Add(DR.Item("item"), DR.Item("price"), DR.Item("num"), DR.Item("num") * DR.Item("price"))
                    FrmMain.DGV.Item(6, count).Value = DR.Item("id")
                    count += 1
                Loop While DR.Read

            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub Insert_DGV()
        Try
            Dim sql As String = "insert into shop (item,price,num)  values ('" & FrmMain.Txt_item.Text & "' ," & FrmMain.Txt_price.Text & " ," & FrmMain.Txt_num.Text & ") "
            cmd = New OleDbCommand(sql, conn)
            If conn.State = 0 Then conn.Open()
            cmd.ExecuteNonQuery()
            conn.Close()
            FrmMain.DGV.Rows.Add(FrmMain.Txt_item.Text, FrmMain.Txt_price.Text, FrmMain.Txt_num.Text, CDbl(FrmMain.Txt_price.Text) * CDbl(FrmMain.Txt_num.Text))
            insert_id()
            ''  FrmMain.DGV.Item(6, FrmMain.DGV.RowCount - 1).Value = FrmMain.DGV.Item(6, FrmMain.DGV.RowCount - 2).Value + 1
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Sub Uodate_DGV()
        Try
            Dim trans As OleDbTransaction
            Dim sql As String = "update shop set item= '" & FrmMain.Txt_item.Text & "',price= " & FrmMain.Txt_price.Text & " , num= " & FrmMain.Txt_num.Text & "  where id=" & FrmMain.DGV.Item(6, FrmMain.Row_index).Value & " "
            cmd = New OleDbCommand(sql, conn)
            If conn.State = 0 Then conn.Open()
            cmd.ExecuteNonQuery()
            trans = conn.BeginTransaction
            trans.Commit()
            conn.Close()
            With FrmMain.DGV
                .Item(0, FrmMain.Row_index).Value = FrmMain.Txt_item.Text
                .Item(1, FrmMain.Row_index).Value = FrmMain.Txt_price.Text
                .Item(2, FrmMain.Row_index).Value = FrmMain.Txt_num.Text
                .Item(3, FrmMain.Row_index).Value = CDbl(FrmMain.Txt_price.Text) * CDbl(FrmMain.Txt_num.Text)
            End With
            ' FrmMain.DGV.Rows.Add(FrmMain.Txt_item.Text, FrmMain.Txt_price.Text, FrmMain.Txt_num.Text, CDbl(FrmMain.Txt_price.Text) * CDbl(FrmMain.Txt_num.Text))

            ''  FrmMain.DGV.Item(6, FrmMain.DGV.RowCount - 1).Value = FrmMain.DGV.Item(6, FrmMain.DGV.RowCount - 2).Value + 1
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Function insert_id()

        Try
            Dim count As Integer = 0

            Dim sql As String = "select * from  shop"
            cmd = New OleDbCommand(sql, conn)
            If conn.State = 0 Then conn.Open()
            DR = cmd.ExecuteReader
            If DR.Read = True Then
                Do

                    count = DR.Item("id")
                Loop While DR.Read

                FrmMain.DGV.Item(6, FrmMain.DGV.RowCount - 1).Value = count

            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

End Module
