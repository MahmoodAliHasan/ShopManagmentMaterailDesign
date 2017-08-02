<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMain
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Pic_Refresh = New System.Windows.Forms.PictureBox()
        Me.Pic_Delete = New System.Windows.Forms.PictureBox()
        Me.Txt_Search = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Pic_Change_Pass = New System.Windows.Forms.PictureBox()
        Me.Pic_Add = New System.Windows.Forms.PictureBox()
        Me.Pic_Update = New System.Windows.Forms.PictureBox()
        Me.Pic_About = New System.Windows.Forms.PictureBox()
        Me.pnl_Add = New System.Windows.Forms.Panel()
        Me.Pic_Hide_Info = New System.Windows.Forms.PictureBox()
        Me.Pic_Insert = New System.Windows.Forms.PictureBox()
        Me.Txt_price = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Txt_num = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Txt_item = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Tmr_Add = New System.Windows.Forms.Timer(Me.components)
        Me.Pnl_Info = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Lbl_num = New System.Windows.Forms.Label()
        Me.Lbl_username = New System.Windows.Forms.Label()
        Me.Lbl_num33 = New System.Windows.Forms.Label()
        Me.Lbl_1 = New System.Windows.Forms.Label()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Ch_Select = New MaterialSkin.Controls.MaterialCheckBox()
        Me.Tmr_Frm_Effect = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Pic_Pnl_About_Hide = New System.Windows.Forms.PictureBox()
        Me.Pnl_About = New System.Windows.Forms.Panel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Tmr_About = New System.Windows.Forms.Timer(Me.components)
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.Pic_Refresh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic_Delete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic_Change_Pass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic_Add, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic_Update, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic_About, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_Add.SuspendLayout()
        CType(Me.Pic_Hide_Info, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic_Insert, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pnl_Info.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.Pic_Pnl_About_Hide, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pnl_About.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGV
        '
        Me.DGV.AllowUserToAddRows = False
        Me.DGV.AllowUserToDeleteRows = False
        Me.DGV.AllowUserToResizeRows = False
        Me.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV.BackgroundColor = System.Drawing.Color.White
        Me.DGV.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.LightGreen
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Sakkal Majalla", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DGV.ColumnHeadersHeight = 35
        Me.DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column6, Me.Column5, Me.Column7})
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Sakkal Majalla", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV.DefaultCellStyle = DataGridViewCellStyle11
        Me.DGV.EnableHeadersVisualStyles = False
        Me.DGV.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DGV.Location = New System.Drawing.Point(146, 151)
        Me.DGV.Name = "DGV"
        Me.DGV.ReadOnly = True
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Sakkal Majalla", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.DGV.RowHeadersVisible = False
        Me.DGV.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Sakkal Majalla", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DarkGreen
        Me.DGV.RowTemplate.Height = 30
        Me.DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV.Size = New System.Drawing.Size(1074, 481)
        Me.DGV.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.FillWeight = 250.0!
        Me.Column1.HeaderText = "اسماء المواد"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        DataGridViewCellStyle8.NullValue = Nothing
        Me.Column2.DefaultCellStyle = DataGridViewCellStyle8
        Me.Column2.HeaderText = "السعر"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "العدد"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        DataGridViewCellStyle9.NullValue = "0"
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle9
        Me.Column4.HeaderText = "السعر الكلي"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column6
        '
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle10.NullValue = "حذف"
        Me.Column6.DefaultCellStyle = DataGridViewCellStyle10
        Me.Column6.FillWeight = 40.0!
        Me.Column6.HeaderText = "ازلة"
        Me.Column6.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.Column6.LinkColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column6.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        '
        'Column5
        '
        Me.Column5.FillWeight = 60.0!
        Me.Column5.HeaderText = "تحديد"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.HeaderText = "Column7"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Pic_Refresh)
        Me.Panel1.Controls.Add(Me.Pic_Delete)
        Me.Panel1.Controls.Add(Me.Txt_Search)
        Me.Panel1.Controls.Add(Me.PictureBox5)
        Me.Panel1.Controls.Add(Me.Pic_Change_Pass)
        Me.Panel1.Controls.Add(Me.Pic_Add)
        Me.Panel1.Controls.Add(Me.Pic_Update)
        Me.Panel1.Controls.Add(Me.Pic_About)
        Me.Panel1.Location = New System.Drawing.Point(0, 64)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1369, 81)
        Me.Panel1.TabIndex = 1
        '
        'Pic_Refresh
        '
        Me.Pic_Refresh.BackColor = System.Drawing.Color.Transparent
        Me.Pic_Refresh.BackgroundImage = CType(resources.GetObject("Pic_Refresh.BackgroundImage"), System.Drawing.Image)
        Me.Pic_Refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pic_Refresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Pic_Refresh.Location = New System.Drawing.Point(945, 6)
        Me.Pic_Refresh.Name = "Pic_Refresh"
        Me.Pic_Refresh.Size = New System.Drawing.Size(59, 52)
        Me.Pic_Refresh.TabIndex = 7
        Me.Pic_Refresh.TabStop = False
        Me.ToolTip1.SetToolTip(Me.Pic_Refresh, "تحديث البيانات")
        '
        'Pic_Delete
        '
        Me.Pic_Delete.BackColor = System.Drawing.Color.Transparent
        Me.Pic_Delete.BackgroundImage = CType(resources.GetObject("Pic_Delete.BackgroundImage"), System.Drawing.Image)
        Me.Pic_Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pic_Delete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Pic_Delete.Location = New System.Drawing.Point(1125, 6)
        Me.Pic_Delete.Name = "Pic_Delete"
        Me.Pic_Delete.Size = New System.Drawing.Size(59, 52)
        Me.Pic_Delete.TabIndex = 6
        Me.Pic_Delete.TabStop = False
        Me.ToolTip1.SetToolTip(Me.Pic_Delete, "حذف المحدد")
        '
        'Txt_Search
        '
        Me.Txt_Search.Depth = 0
        Me.Txt_Search.Hint = "اكتب للبحث عن اسماء المواد او السعر او العدد"
        Me.Txt_Search.Location = New System.Drawing.Point(454, 12)
        Me.Txt_Search.MaxLength = 32767
        Me.Txt_Search.MouseState = MaterialSkin.MouseState.HOVER
        Me.Txt_Search.Name = "Txt_Search"
        Me.Txt_Search.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Txt_Search.SelectedText = ""
        Me.Txt_Search.SelectionLength = 0
        Me.Txt_Search.SelectionStart = 0
        Me.Txt_Search.Size = New System.Drawing.Size(383, 23)
        Me.Txt_Search.TabIndex = 5
        Me.Txt_Search.TabStop = False
        Me.Txt_Search.UseSystemPasswordChar = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.BackgroundImage = CType(resources.GetObject("PictureBox5.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox5.Location = New System.Drawing.Point(855, 6)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(59, 52)
        Me.PictureBox5.TabIndex = 4
        Me.PictureBox5.TabStop = False
        '
        'Pic_Change_Pass
        '
        Me.Pic_Change_Pass.BackColor = System.Drawing.Color.Transparent
        Me.Pic_Change_Pass.BackgroundImage = CType(resources.GetObject("Pic_Change_Pass.BackgroundImage"), System.Drawing.Image)
        Me.Pic_Change_Pass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pic_Change_Pass.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Pic_Change_Pass.Location = New System.Drawing.Point(1305, 6)
        Me.Pic_Change_Pass.Name = "Pic_Change_Pass"
        Me.Pic_Change_Pass.Size = New System.Drawing.Size(59, 52)
        Me.Pic_Change_Pass.TabIndex = 3
        Me.Pic_Change_Pass.TabStop = False
        Me.ToolTip1.SetToolTip(Me.Pic_Change_Pass, "تغير الاسم  و كلمة المرور")
        '
        'Pic_Add
        '
        Me.Pic_Add.BackColor = System.Drawing.Color.Transparent
        Me.Pic_Add.BackgroundImage = CType(resources.GetObject("Pic_Add.BackgroundImage"), System.Drawing.Image)
        Me.Pic_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pic_Add.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Pic_Add.Location = New System.Drawing.Point(1215, 6)
        Me.Pic_Add.Name = "Pic_Add"
        Me.Pic_Add.Size = New System.Drawing.Size(59, 52)
        Me.Pic_Add.TabIndex = 1
        Me.Pic_Add.TabStop = False
        Me.ToolTip1.SetToolTip(Me.Pic_Add, "اضافة")
        '
        'Pic_Update
        '
        Me.Pic_Update.BackColor = System.Drawing.Color.Transparent
        Me.Pic_Update.BackgroundImage = CType(resources.GetObject("Pic_Update.BackgroundImage"), System.Drawing.Image)
        Me.Pic_Update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pic_Update.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Pic_Update.Location = New System.Drawing.Point(1035, 6)
        Me.Pic_Update.Name = "Pic_Update"
        Me.Pic_Update.Size = New System.Drawing.Size(59, 52)
        Me.Pic_Update.TabIndex = 2
        Me.Pic_Update.TabStop = False
        Me.ToolTip1.SetToolTip(Me.Pic_Update, "تعديل")
        '
        'Pic_About
        '
        Me.Pic_About.BackColor = System.Drawing.Color.Transparent
        Me.Pic_About.BackgroundImage = CType(resources.GetObject("Pic_About.BackgroundImage"), System.Drawing.Image)
        Me.Pic_About.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pic_About.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Pic_About.Location = New System.Drawing.Point(3, 6)
        Me.Pic_About.Name = "Pic_About"
        Me.Pic_About.Size = New System.Drawing.Size(60, 52)
        Me.Pic_About.TabIndex = 0
        Me.Pic_About.TabStop = False
        Me.ToolTip1.SetToolTip(Me.Pic_About, "حول البرنامج")
        '
        'pnl_Add
        '
        Me.pnl_Add.BackColor = System.Drawing.Color.White
        Me.pnl_Add.BackgroundImage = CType(resources.GetObject("pnl_Add.BackgroundImage"), System.Drawing.Image)
        Me.pnl_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnl_Add.Controls.Add(Me.Pic_Hide_Info)
        Me.pnl_Add.Controls.Add(Me.Pic_Insert)
        Me.pnl_Add.Controls.Add(Me.Txt_price)
        Me.pnl_Add.Controls.Add(Me.Txt_num)
        Me.pnl_Add.Controls.Add(Me.Txt_item)
        Me.pnl_Add.Location = New System.Drawing.Point(0, 661)
        Me.pnl_Add.Name = "pnl_Add"
        Me.pnl_Add.Size = New System.Drawing.Size(1366, 69)
        Me.pnl_Add.TabIndex = 4
        Me.pnl_Add.Visible = False
        '
        'Pic_Hide_Info
        '
        Me.Pic_Hide_Info.BackColor = System.Drawing.Color.Transparent
        Me.Pic_Hide_Info.BackgroundImage = CType(resources.GetObject("Pic_Hide_Info.BackgroundImage"), System.Drawing.Image)
        Me.Pic_Hide_Info.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pic_Hide_Info.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Pic_Hide_Info.Location = New System.Drawing.Point(1295, 7)
        Me.Pic_Hide_Info.Name = "Pic_Hide_Info"
        Me.Pic_Hide_Info.Size = New System.Drawing.Size(59, 52)
        Me.Pic_Hide_Info.TabIndex = 6
        Me.Pic_Hide_Info.TabStop = False
        Me.ToolTip1.SetToolTip(Me.Pic_Hide_Info, "اخفاء")
        '
        'Pic_Insert
        '
        Me.Pic_Insert.BackColor = System.Drawing.Color.Transparent
        Me.Pic_Insert.BackgroundImage = CType(resources.GetObject("Pic_Insert.BackgroundImage"), System.Drawing.Image)
        Me.Pic_Insert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pic_Insert.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Pic_Insert.Location = New System.Drawing.Point(12, 7)
        Me.Pic_Insert.Name = "Pic_Insert"
        Me.Pic_Insert.Size = New System.Drawing.Size(59, 52)
        Me.Pic_Insert.TabIndex = 5
        Me.Pic_Insert.TabStop = False
        Me.ToolTip1.SetToolTip(Me.Pic_Insert, "حفظ")
        '
        'Txt_price
        '
        Me.Txt_price.Depth = 0
        Me.Txt_price.Hint = "السعر"
        Me.Txt_price.Location = New System.Drawing.Point(527, 31)
        Me.Txt_price.MaxLength = 32767
        Me.Txt_price.MouseState = MaterialSkin.MouseState.HOVER
        Me.Txt_price.Name = "Txt_price"
        Me.Txt_price.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Txt_price.SelectedText = ""
        Me.Txt_price.SelectionLength = 0
        Me.Txt_price.SelectionStart = 0
        Me.Txt_price.Size = New System.Drawing.Size(210, 23)
        Me.Txt_price.TabIndex = 3
        Me.Txt_price.TabStop = False
        Me.Txt_price.UseSystemPasswordChar = False
        '
        'Txt_num
        '
        Me.Txt_num.Depth = 0
        Me.Txt_num.Hint = "العدد"
        Me.Txt_num.Location = New System.Drawing.Point(294, 31)
        Me.Txt_num.MaxLength = 32767
        Me.Txt_num.MouseState = MaterialSkin.MouseState.HOVER
        Me.Txt_num.Name = "Txt_num"
        Me.Txt_num.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Txt_num.SelectedText = ""
        Me.Txt_num.SelectionLength = 0
        Me.Txt_num.SelectionStart = 0
        Me.Txt_num.Size = New System.Drawing.Size(189, 23)
        Me.Txt_num.TabIndex = 4
        Me.Txt_num.TabStop = False
        Me.Txt_num.UseSystemPasswordChar = False
        '
        'Txt_item
        '
        Me.Txt_item.Depth = 0
        Me.Txt_item.Hint = "اسم المادة"
        Me.Txt_item.Location = New System.Drawing.Point(777, 31)
        Me.Txt_item.MaxLength = 32767
        Me.Txt_item.MouseState = MaterialSkin.MouseState.HOVER
        Me.Txt_item.Name = "Txt_item"
        Me.Txt_item.Padding = New System.Windows.Forms.Padding(45, 0, 0, 0)
        Me.Txt_item.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Txt_item.SelectedText = ""
        Me.Txt_item.SelectionLength = 0
        Me.Txt_item.SelectionStart = 0
        Me.Txt_item.Size = New System.Drawing.Size(296, 23)
        Me.Txt_item.TabIndex = 2
        Me.Txt_item.TabStop = False
        Me.Txt_item.UseSystemPasswordChar = False
        '
        'Tmr_Add
        '
        Me.Tmr_Add.Interval = 1
        '
        'Pnl_Info
        '
        Me.Pnl_Info.BackColor = System.Drawing.Color.White
        Me.Pnl_Info.BackgroundImage = CType(resources.GetObject("Pnl_Info.BackgroundImage"), System.Drawing.Image)
        Me.Pnl_Info.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pnl_Info.Controls.Add(Me.Panel4)
        Me.Pnl_Info.Location = New System.Drawing.Point(0, 569)
        Me.Pnl_Info.Name = "Pnl_Info"
        Me.Pnl_Info.Size = New System.Drawing.Size(1366, 69)
        Me.Pnl_Info.TabIndex = 7
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.BackgroundImage = CType(resources.GetObject("Panel4.BackgroundImage"), System.Drawing.Image)
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel4.Controls.Add(Me.Lbl_num)
        Me.Panel4.Controls.Add(Me.Lbl_username)
        Me.Panel4.Controls.Add(Me.Lbl_num33)
        Me.Panel4.Controls.Add(Me.Lbl_1)
        Me.Panel4.Controls.Add(Me.lbl_total)
        Me.Panel4.Location = New System.Drawing.Point(0, 23)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1346, 42)
        Me.Panel4.TabIndex = 14
        '
        'Lbl_num
        '
        Me.Lbl_num.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_num.Font = New System.Drawing.Font("AGA Mashq Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Lbl_num.ForeColor = System.Drawing.Color.White
        Me.Lbl_num.Location = New System.Drawing.Point(68, 5)
        Me.Lbl_num.Name = "Lbl_num"
        Me.Lbl_num.Size = New System.Drawing.Size(128, 29)
        Me.Lbl_num.TabIndex = 12
        Me.Lbl_num.Text = "0"
        '
        'Lbl_username
        '
        Me.Lbl_username.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_username.Font = New System.Drawing.Font("AGA Mashq Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Lbl_username.ForeColor = System.Drawing.Color.White
        Me.Lbl_username.Location = New System.Drawing.Point(990, 4)
        Me.Lbl_username.Name = "Lbl_username"
        Me.Lbl_username.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Lbl_username.Size = New System.Drawing.Size(317, 29)
        Me.Lbl_username.TabIndex = 12
        Me.Lbl_username.Text = "مرحبا بك عزيزي :  "
        '
        'Lbl_num33
        '
        Me.Lbl_num33.AutoSize = True
        Me.Lbl_num33.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_num33.Font = New System.Drawing.Font("AGA Mashq Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Lbl_num33.ForeColor = System.Drawing.Color.White
        Me.Lbl_num33.Location = New System.Drawing.Point(200, 5)
        Me.Lbl_num33.Name = "Lbl_num33"
        Me.Lbl_num33.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Lbl_num33.Size = New System.Drawing.Size(137, 29)
        Me.Lbl_num33.TabIndex = 11
        Me.Lbl_num33.Text = "عدد المواد :"
        '
        'Lbl_1
        '
        Me.Lbl_1.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_1.Font = New System.Drawing.Font("AGA Mashq Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Lbl_1.ForeColor = System.Drawing.Color.White
        Me.Lbl_1.Location = New System.Drawing.Point(654, 7)
        Me.Lbl_1.Name = "Lbl_1"
        Me.Lbl_1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Lbl_1.Size = New System.Drawing.Size(172, 29)
        Me.Lbl_1.TabIndex = 11
        Me.Lbl_1.Text = "مجموع السعر الكلي : "
        '
        'lbl_total
        '
        Me.lbl_total.BackColor = System.Drawing.Color.Transparent
        Me.lbl_total.Font = New System.Drawing.Font("AGA Mashq Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lbl_total.ForeColor = System.Drawing.Color.White
        Me.lbl_total.Location = New System.Drawing.Point(526, 7)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(128, 29)
        Me.lbl_total.TabIndex = 13
        Me.lbl_total.Text = "0"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Ch_Select
        '
        Me.Ch_Select.AutoSize = True
        Me.Ch_Select.BackColor = System.Drawing.Color.Transparent
        Me.Ch_Select.Depth = 0
        Me.Ch_Select.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.Ch_Select.Location = New System.Drawing.Point(1153, 635)
        Me.Ch_Select.Margin = New System.Windows.Forms.Padding(0)
        Me.Ch_Select.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.Ch_Select.MouseState = MaterialSkin.MouseState.HOVER
        Me.Ch_Select.Name = "Ch_Select"
        Me.Ch_Select.Ripple = True
        Me.Ch_Select.Size = New System.Drawing.Size(55, 30)
        Me.Ch_Select.TabIndex = 8
        Me.Ch_Select.Text = "تحديد"
        Me.Ch_Select.UseVisualStyleBackColor = False
        '
        'Tmr_Frm_Effect
        '
        Me.Tmr_Frm_Effect.Interval = 1
        '
        'Pic_Pnl_About_Hide
        '
        Me.Pic_Pnl_About_Hide.BackColor = System.Drawing.Color.Transparent
        Me.Pic_Pnl_About_Hide.BackgroundImage = CType(resources.GetObject("Pic_Pnl_About_Hide.BackgroundImage"), System.Drawing.Image)
        Me.Pic_Pnl_About_Hide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pic_Pnl_About_Hide.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Pic_Pnl_About_Hide.Location = New System.Drawing.Point(466, 3)
        Me.Pic_Pnl_About_Hide.Name = "Pic_Pnl_About_Hide"
        Me.Pic_Pnl_About_Hide.Size = New System.Drawing.Size(59, 52)
        Me.Pic_Pnl_About_Hide.TabIndex = 8
        Me.Pic_Pnl_About_Hide.TabStop = False
        Me.ToolTip1.SetToolTip(Me.Pic_Pnl_About_Hide, "غلاق")
        '
        'Pnl_About
        '
        Me.Pnl_About.BackColor = System.Drawing.Color.White
        Me.Pnl_About.BackgroundImage = CType(resources.GetObject("Pnl_About.BackgroundImage"), System.Drawing.Image)
        Me.Pnl_About.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pnl_About.Controls.Add(Me.Pic_Pnl_About_Hide)
        Me.Pnl_About.Controls.Add(Me.LinkLabel1)
        Me.Pnl_About.Controls.Add(Me.PictureBox1)
        Me.Pnl_About.Controls.Add(Me.Label5)
        Me.Pnl_About.Controls.Add(Me.Label2)
        Me.Pnl_About.Controls.Add(Me.Label4)
        Me.Pnl_About.Controls.Add(Me.Label1)
        Me.Pnl_About.Controls.Add(Me.Label3)
        Me.Pnl_About.Location = New System.Drawing.Point(419, 233)
        Me.Pnl_About.Name = "Pnl_About"
        Me.Pnl_About.Size = New System.Drawing.Size(528, 264)
        Me.Pnl_About.TabIndex = 9
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.Font = New System.Drawing.Font("Sakkal Majalla", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.ForeColor = System.Drawing.Color.Gray
        Me.LinkLabel1.Location = New System.Drawing.Point(336, 196)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(97, 25)
        Me.LinkLabel1.TabIndex = 7
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Mahmood Ali"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(25, 17)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(227, 230)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Sakkal Majalla", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gray
        Me.Label5.Location = New System.Drawing.Point(251, 101)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label5.Size = New System.Drawing.Size(255, 79)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "للاقتراح او التبليغ عن المشاكل يمكنك اضغط ع الرابط ادناة,... شاكرين مساهتك في تطو" &
    "ير البرنامج"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Sakkal Majalla", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gray
        Me.Label2.Location = New System.Drawing.Point(341, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label2.Size = New System.Drawing.Size(107, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "برمجة و تصميم  :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Sakkal Majalla", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gray
        Me.Label4.Location = New System.Drawing.Point(284, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 25)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Team-L"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Sakkal Majalla", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(341, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(104, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "اصدار البرامج    :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Sakkal Majalla", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gray
        Me.Label3.Location = New System.Drawing.Point(284, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 25)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "1.0.0.0 "
        '
        'Tmr_About
        '
        Me.Tmr_About.Enabled = True
        Me.Tmr_About.Interval = 1
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1366, 730)
        Me.Controls.Add(Me.Pnl_About)
        Me.Controls.Add(Me.Ch_Select)
        Me.Controls.Add(Me.pnl_Add)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.Pnl_Info)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1366, 730)
        Me.Name = "FrmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "القائمة الرئسية"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.Pic_Refresh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic_Delete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic_Change_Pass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic_Add, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic_Update, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic_About, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_Add.ResumeLayout(False)
        CType(Me.Pic_Hide_Info, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic_Insert, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pnl_Info.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.Pic_Pnl_About_Hide, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pnl_About.ResumeLayout(False)
        Me.Pnl_About.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGV As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Pic_About As PictureBox
    Friend WithEvents Txt_Search As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Pic_Change_Pass As PictureBox
    Friend WithEvents Pic_Update As PictureBox
    Friend WithEvents Pic_Add As PictureBox
    Friend WithEvents Pic_Delete As PictureBox
    Friend WithEvents pnl_Add As Panel
    Friend WithEvents Txt_price As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Txt_item As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Pic_Hide_Info As PictureBox
    Friend WithEvents Pic_Insert As PictureBox
    Friend WithEvents Tmr_Add As Timer
    Friend WithEvents Txt_num As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Pic_Refresh As PictureBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewLinkColumn
    Friend WithEvents Column5 As DataGridViewCheckBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Pnl_Info As Panel
    Friend WithEvents Lbl_1 As Label
    Friend WithEvents Lbl_num33 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Lbl_username As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Lbl_num As Label
    Friend WithEvents lbl_total As Label
    Friend WithEvents Ch_Select As MaterialSkin.Controls.MaterialCheckBox
    Friend WithEvents Tmr_Frm_Effect As Timer
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Pnl_About As Panel
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Pic_Pnl_About_Hide As PictureBox
    Friend WithEvents Tmr_About As Timer
End Class
