Imports MaterialSkin

Public Class Frm_Login

    Private Sub Frm_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Theme_blue()
        load_loaction_of_obj()
        Tmr_Effect.Enabled = True
    End Sub

    Sub load_loaction_of_obj()
        Txt_pass.Location = New Point(Me.Width, Txt_pass.Location.Y)
        Txt_username.Location = New Point(Me.Width, Txt_username.Location.Y)
        Btn_Login.Location = New Point(Me.Width, Btn_Login.Location.Y)
        Btn_Exit.Location = New Point(Me.Width, Btn_Exit.Location.Y)

    End Sub
#Region "Them in from login "
    Sub Theme_blue()
        Dim skinmanage As MaterialSkinManager = MaterialSkinManager.Instance
        skinmanage.AddFormToManage(Me)
        skinmanage.Theme = MaterialSkinManager.Themes.LIGHT
        skinmanage.ColorScheme = New ColorScheme(Primary.Blue300, Primary.Blue500, Primary.Green100, Accent.Green100, TextShade.WHITE)
        skinmanage.ROBOTO_MEDIUM_10 = Btn_Login.Font
        skinmanage.ROBOTO_MEDIUM_11 = Btn_Login.Font
        skinmanage.ROBOTO_MEDIUM_12 = Btn_Login.Font
        skinmanage.ROBOTO_REGULAR_11 = Btn_Login.Font
    End Sub

    Sub Theme_Red()
        Dim skinmanage As MaterialSkinManager = MaterialSkinManager.Instance
        skinmanage.AddFormToManage(Me)
        skinmanage.Theme = MaterialSkinManager.Themes.LIGHT
        skinmanage.ColorScheme = New ColorScheme(Primary.Red300, Primary.Red500, Primary.Green100, Accent.Green100, TextShade.WHITE)
        skinmanage.ROBOTO_MEDIUM_10 = Btn_Login.Font
        skinmanage.ROBOTO_MEDIUM_11 = Btn_Login.Font
        skinmanage.ROBOTO_MEDIUM_12 = Btn_Login.Font
        skinmanage.ROBOTO_REGULAR_11 = Btn_Login.Font
    End Sub
#End Region

    Private Sub Btn_Exit_Click(sender As Object, e As EventArgs) Handles Btn_Exit.Click
        Me.Close()
    End Sub

    Private Sub Btn_Login_Click(sender As Object, e As EventArgs) Handles Btn_Login.Click
        check_username_pass()
    End Sub

    Private Sub Tmr_Effect_Tick(sender As Object, e As EventArgs) Handles Tmr_Effect.Tick
        If Txt_pass.Location.X >= 230 Then
            Txt_pass.Location = New Point(Txt_pass.Location.X - 10, Txt_pass.Location.Y)
            Txt_username.Location = New Point(Txt_username.Location.X - 10, Txt_username.Location.Y)
            Btn_Login.Location = New Point(Btn_Login.Location.X - 7, Btn_Login.Location.Y)
            Btn_Exit.Location = New Point(Btn_Exit.Location.X - 10, Btn_Exit.Location.Y)


        Else
            Btn_Login.Location = New Point(379, Btn_Login.Location.Y)
            Tmr_Effect.Enabled = False
        End If



    End Sub
End Class