<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmChangePassName
    Inherits MaterialSkin.Controls.MaterialForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmChangePassName))
        Me.Txt_username = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Txt_New_Pass1 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Txt_New_Pass2 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Btn_Check = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.Btn_Cancel = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.Txt_New_Username = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Txt_pass = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Txt_username
        '
        Me.Txt_username.Depth = 0
        Me.Txt_username.Hint = "الاسم القديم"
        Me.Txt_username.Location = New System.Drawing.Point(101, 42)
        Me.Txt_username.MaxLength = 32767
        Me.Txt_username.MouseState = MaterialSkin.MouseState.HOVER
        Me.Txt_username.Name = "Txt_username"
        Me.Txt_username.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Txt_username.SelectedText = ""
        Me.Txt_username.SelectionLength = 0
        Me.Txt_username.SelectionStart = 0
        Me.Txt_username.Size = New System.Drawing.Size(283, 23)
        Me.Txt_username.TabIndex = 0
        Me.Txt_username.TabStop = False
        Me.Txt_username.UseSystemPasswordChar = False
        '
        'Txt_New_Pass1
        '
        Me.Txt_New_Pass1.Depth = 0
        Me.Txt_New_Pass1.Hint = "كلمة المرور الجديدة"
        Me.Txt_New_Pass1.Location = New System.Drawing.Point(101, 63)
        Me.Txt_New_Pass1.MaxLength = 32767
        Me.Txt_New_Pass1.MouseState = MaterialSkin.MouseState.HOVER
        Me.Txt_New_Pass1.Name = "Txt_New_Pass1"
        Me.Txt_New_Pass1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Txt_New_Pass1.SelectedText = ""
        Me.Txt_New_Pass1.SelectionLength = 0
        Me.Txt_New_Pass1.SelectionStart = 0
        Me.Txt_New_Pass1.Size = New System.Drawing.Size(283, 23)
        Me.Txt_New_Pass1.TabIndex = 1
        Me.Txt_New_Pass1.TabStop = False
        Me.Txt_New_Pass1.UseSystemPasswordChar = False
        '
        'Txt_New_Pass2
        '
        Me.Txt_New_Pass2.Depth = 0
        Me.Txt_New_Pass2.Hint = "اعادة كلمة المرور"
        Me.Txt_New_Pass2.Location = New System.Drawing.Point(101, 103)
        Me.Txt_New_Pass2.MaxLength = 32767
        Me.Txt_New_Pass2.MouseState = MaterialSkin.MouseState.HOVER
        Me.Txt_New_Pass2.Name = "Txt_New_Pass2"
        Me.Txt_New_Pass2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Txt_New_Pass2.SelectedText = ""
        Me.Txt_New_Pass2.SelectionLength = 0
        Me.Txt_New_Pass2.SelectionStart = 0
        Me.Txt_New_Pass2.Size = New System.Drawing.Size(283, 23)
        Me.Txt_New_Pass2.TabIndex = 2
        Me.Txt_New_Pass2.TabStop = False
        Me.Txt_New_Pass2.UseSystemPasswordChar = False
        '
        'Btn_Check
        '
        Me.Btn_Check.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Check.Depth = 0
        Me.Btn_Check.Location = New System.Drawing.Point(272, 153)
        Me.Btn_Check.MouseState = MaterialSkin.MouseState.HOVER
        Me.Btn_Check.Name = "Btn_Check"
        Me.Btn_Check.Primary = True
        Me.Btn_Check.Size = New System.Drawing.Size(112, 46)
        Me.Btn_Check.TabIndex = 3
        Me.Btn_Check.Text = "تاكيد "
        Me.Btn_Check.UseVisualStyleBackColor = True
        '
        'Btn_Cancel
        '
        Me.Btn_Cancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Cancel.Depth = 0
        Me.Btn_Cancel.Location = New System.Drawing.Point(101, 153)
        Me.Btn_Cancel.MouseState = MaterialSkin.MouseState.HOVER
        Me.Btn_Cancel.Name = "Btn_Cancel"
        Me.Btn_Cancel.Primary = True
        Me.Btn_Cancel.Size = New System.Drawing.Size(112, 46)
        Me.Btn_Cancel.TabIndex = 4
        Me.Btn_Cancel.Text = "الغاء "
        Me.Btn_Cancel.UseVisualStyleBackColor = True
        '
        'Txt_New_Username
        '
        Me.Txt_New_Username.Depth = 0
        Me.Txt_New_Username.Hint = "الاسم الجديد "
        Me.Txt_New_Username.Location = New System.Drawing.Point(101, 23)
        Me.Txt_New_Username.MaxLength = 32767
        Me.Txt_New_Username.MouseState = MaterialSkin.MouseState.HOVER
        Me.Txt_New_Username.Name = "Txt_New_Username"
        Me.Txt_New_Username.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Txt_New_Username.SelectedText = ""
        Me.Txt_New_Username.SelectionLength = 0
        Me.Txt_New_Username.SelectionStart = 0
        Me.Txt_New_Username.Size = New System.Drawing.Size(283, 23)
        Me.Txt_New_Username.TabIndex = 0
        Me.Txt_New_Username.TabStop = False
        Me.Txt_New_Username.UseSystemPasswordChar = False
        '
        'Txt_pass
        '
        Me.Txt_pass.Depth = 0
        Me.Txt_pass.Hint = "كلمة المرور القديمة"
        Me.Txt_pass.Location = New System.Drawing.Point(101, 85)
        Me.Txt_pass.MaxLength = 32767
        Me.Txt_pass.MouseState = MaterialSkin.MouseState.HOVER
        Me.Txt_pass.Name = "Txt_pass"
        Me.Txt_pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Txt_pass.SelectedText = ""
        Me.Txt_pass.SelectionLength = 0
        Me.Txt_pass.SelectionStart = 0
        Me.Txt_pass.Size = New System.Drawing.Size(283, 23)
        Me.Txt_pass.TabIndex = 1
        Me.Txt_pass.TabStop = False
        Me.Txt_pass.UseSystemPasswordChar = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Txt_pass)
        Me.Panel1.Controls.Add(Me.Txt_username)
        Me.Panel1.Location = New System.Drawing.Point(154, 89)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(485, 150)
        Me.Panel1.TabIndex = 7
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.Btn_Cancel)
        Me.Panel2.Controls.Add(Me.Txt_New_Username)
        Me.Panel2.Controls.Add(Me.Btn_Check)
        Me.Panel2.Controls.Add(Me.Txt_New_Pass2)
        Me.Panel2.Controls.Add(Me.Txt_New_Pass1)
        Me.Panel2.Location = New System.Drawing.Point(154, 245)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(485, 227)
        Me.Panel2.TabIndex = 8
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'FrmChangePassName
        '
        Me.AcceptButton = Me.Btn_Check
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(805, 490)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(280, -490)
        Me.MaximumSize = New System.Drawing.Size(805, 490)
        Me.Name = "FrmChangePassName"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "تغير الاسم و كلمة المرور"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Txt_username As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Txt_New_Pass1 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Txt_New_Pass2 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Btn_Check As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents Btn_Cancel As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents Txt_New_Username As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Txt_pass As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Timer1 As Timer
End Class
