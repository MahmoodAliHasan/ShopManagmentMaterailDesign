<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Login
    Inherits MaterialSkin.Controls.MaterialForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Login))
        Me.Btn_Exit = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.Btn_Login = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.Txt_pass = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Txt_username = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Tmr_Effect = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Btn_Exit
        '
        Me.Btn_Exit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Exit.Depth = 0
        Me.Btn_Exit.Location = New System.Drawing.Point(209, 303)
        Me.Btn_Exit.Margin = New System.Windows.Forms.Padding(2, 5, 2, 5)
        Me.Btn_Exit.MouseState = MaterialSkin.MouseState.HOVER
        Me.Btn_Exit.Name = "Btn_Exit"
        Me.Btn_Exit.Primary = True
        Me.Btn_Exit.Size = New System.Drawing.Size(121, 52)
        Me.Btn_Exit.TabIndex = 7
        Me.Btn_Exit.Text = "خروج"
        Me.Btn_Exit.UseVisualStyleBackColor = True
        '
        'Btn_Login
        '
        Me.Btn_Login.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Login.Depth = 0
        Me.Btn_Login.Font = New System.Drawing.Font("Sakkal Majalla", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Login.Location = New System.Drawing.Point(381, 303)
        Me.Btn_Login.Margin = New System.Windows.Forms.Padding(2, 5, 2, 5)
        Me.Btn_Login.MouseState = MaterialSkin.MouseState.HOVER
        Me.Btn_Login.Name = "Btn_Login"
        Me.Btn_Login.Primary = True
        Me.Btn_Login.Size = New System.Drawing.Size(121, 52)
        Me.Btn_Login.TabIndex = 6
        Me.Btn_Login.Text = "تسجيل الدخول"
        Me.Btn_Login.UseVisualStyleBackColor = True
        '
        'Txt_pass
        '
        Me.Txt_pass.Depth = 0
        Me.Txt_pass.Hint = "كلمة المرور"
        Me.Txt_pass.Location = New System.Drawing.Point(209, 242)
        Me.Txt_pass.Margin = New System.Windows.Forms.Padding(2, 5, 2, 5)
        Me.Txt_pass.MaxLength = 32767
        Me.Txt_pass.MouseState = MaterialSkin.MouseState.HOVER
        Me.Txt_pass.Name = "Txt_pass"
        Me.Txt_pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Txt_pass.SelectedText = ""
        Me.Txt_pass.SelectionLength = 0
        Me.Txt_pass.SelectionStart = 0
        Me.Txt_pass.Size = New System.Drawing.Size(292, 23)
        Me.Txt_pass.TabIndex = 5
        Me.Txt_pass.TabStop = False
        Me.Txt_pass.UseSystemPasswordChar = False
        '
        'Txt_username
        '
        Me.Txt_username.Depth = 0
        Me.Txt_username.Hint = "اسم المستخدم"
        Me.Txt_username.Location = New System.Drawing.Point(210, 167)
        Me.Txt_username.Margin = New System.Windows.Forms.Padding(2, 5, 2, 5)
        Me.Txt_username.MaxLength = 32767
        Me.Txt_username.MouseState = MaterialSkin.MouseState.HOVER
        Me.Txt_username.Name = "Txt_username"
        Me.Txt_username.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Txt_username.SelectedText = ""
        Me.Txt_username.SelectionLength = 0
        Me.Txt_username.SelectionStart = 0
        Me.Txt_username.Size = New System.Drawing.Size(292, 23)
        Me.Txt_username.TabIndex = 4
        Me.Txt_username.TabStop = False
        Me.Txt_username.UseSystemPasswordChar = False
        '
        'Tmr_Effect
        '
        Me.Tmr_Effect.Interval = 1
        '
        'Frm_Login
        '
        Me.AcceptButton = Me.Btn_Login
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(711, 436)
        Me.Controls.Add(Me.Btn_Exit)
        Me.Controls.Add(Me.Btn_Login)
        Me.Controls.Add(Me.Txt_pass)
        Me.Controls.Add(Me.Txt_username)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "تسجيل الدخول"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Btn_Exit As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents Btn_Login As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents Txt_pass As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Txt_username As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Tmr_Effect As Timer
End Class
