<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

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
        Dim Animation10 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BunifuImageButton4 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BunifuImageButton2 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuImageButton3 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.sendfilebtn = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.recoverybtn = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.bootloaderbtn = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.apkbtn = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.rebootbtn = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Screenie = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.dis_hu = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.en_hu = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton6 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.timer = New System.Windows.Forms.Timer(Me.components)
        Me.open = New System.Windows.Forms.OpenFileDialog()
        Me.buttontrans = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.BunifuImageButton4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel1.Controls.Add(Me.BunifuImageButton4)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel1)
        Me.Panel1.Controls.Add(Me.BunifuImageButton1)
        Me.buttontrans.SetDecoration(Me.Panel1, BunifuAnimatorNS.DecorationType.None)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(614, 34)
        Me.Panel1.TabIndex = 0
        '
        'BunifuImageButton4
        '
        Me.BunifuImageButton4.BackColor = System.Drawing.Color.Teal
        Me.buttontrans.SetDecoration(Me.BunifuImageButton4, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuImageButton4.Image = CType(resources.GetObject("BunifuImageButton4.Image"), System.Drawing.Image)
        Me.BunifuImageButton4.ImageActive = Nothing
        Me.BunifuImageButton4.Location = New System.Drawing.Point(-19, 0)
        Me.BunifuImageButton4.Name = "BunifuImageButton4"
        Me.BunifuImageButton4.Size = New System.Drawing.Size(75, 34)
        Me.BunifuImageButton4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton4.TabIndex = 2
        Me.BunifuImageButton4.TabStop = False
        Me.BunifuImageButton4.Zoom = 10
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.buttontrans.SetDecoration(Me.BunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(62, 9)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(61, 13)
        Me.BunifuCustomLabel1.TabIndex = 1
        Me.BunifuCustomLabel1.Text = "Adb Toolkit"
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.DarkCyan
        Me.buttontrans.SetDecoration(Me.BunifuImageButton1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuImageButton1.Image = CType(resources.GetObject("BunifuImageButton1.Image"), System.Drawing.Image)
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(584, 0)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(30, 34)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton1.TabIndex = 1
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 10
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.Panel1
        Me.BunifuDragControl1.Vertical = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.BunifuImageButton3)
        Me.Panel2.Controls.Add(Me.BunifuImageButton2)
        Me.buttontrans.SetDecoration(Me.Panel2, BunifuAnimatorNS.DecorationType.None)
        Me.Panel2.Location = New System.Drawing.Point(0, 40)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(614, 100)
        Me.Panel2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.SeaGreen
        Me.buttontrans.SetDecoration(Me.Label1, BunifuAnimatorNS.DecorationType.None)
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(95, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(507, 61)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Device Detected"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuImageButton2
        '
        Me.BunifuImageButton2.BackColor = System.Drawing.Color.SeaShell
        Me.buttontrans.SetDecoration(Me.BunifuImageButton2, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuImageButton2.Image = CType(resources.GetObject("BunifuImageButton2.Image"), System.Drawing.Image)
        Me.BunifuImageButton2.ImageActive = Nothing
        Me.BunifuImageButton2.Location = New System.Drawing.Point(3, 16)
        Me.BunifuImageButton2.Name = "BunifuImageButton2"
        Me.BunifuImageButton2.Size = New System.Drawing.Size(86, 61)
        Me.BunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton2.TabIndex = 0
        Me.BunifuImageButton2.TabStop = False
        Me.BunifuImageButton2.Zoom = 10
        '
        'BunifuImageButton3
        '
        Me.BunifuImageButton3.BackColor = System.Drawing.Color.White
        Me.buttontrans.SetDecoration(Me.BunifuImageButton3, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuImageButton3.Image = CType(resources.GetObject("BunifuImageButton3.Image"), System.Drawing.Image)
        Me.BunifuImageButton3.ImageActive = Nothing
        Me.BunifuImageButton3.Location = New System.Drawing.Point(3, 16)
        Me.BunifuImageButton3.Name = "BunifuImageButton3"
        Me.BunifuImageButton3.Size = New System.Drawing.Size(86, 59)
        Me.BunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton3.TabIndex = 0
        Me.BunifuImageButton3.TabStop = False
        Me.BunifuImageButton3.Zoom = 10
        '
        'sendfilebtn
        '
        Me.sendfilebtn.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.sendfilebtn.BackColor = System.Drawing.Color.SeaGreen
        Me.sendfilebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.sendfilebtn.BorderRadius = 0
        Me.sendfilebtn.ButtonText = "          Send File"
        Me.sendfilebtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.buttontrans.SetDecoration(Me.sendfilebtn, BunifuAnimatorNS.DecorationType.None)
        Me.sendfilebtn.DisabledColor = System.Drawing.Color.Gray
        Me.sendfilebtn.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sendfilebtn.Iconcolor = System.Drawing.Color.Transparent
        Me.sendfilebtn.Iconimage = Nothing
        Me.sendfilebtn.Iconimage_right = Nothing
        Me.sendfilebtn.Iconimage_right_Selected = Nothing
        Me.sendfilebtn.Iconimage_Selected = Nothing
        Me.sendfilebtn.IconMarginLeft = 0
        Me.sendfilebtn.IconMarginRight = 0
        Me.sendfilebtn.IconRightVisible = True
        Me.sendfilebtn.IconRightZoom = 0R
        Me.sendfilebtn.IconVisible = True
        Me.sendfilebtn.IconZoom = 90.0R
        Me.sendfilebtn.IsTab = False
        Me.sendfilebtn.Location = New System.Drawing.Point(12, 158)
        Me.sendfilebtn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.sendfilebtn.Name = "sendfilebtn"
        Me.sendfilebtn.Normalcolor = System.Drawing.Color.SeaGreen
        Me.sendfilebtn.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.sendfilebtn.OnHoverTextColor = System.Drawing.Color.White
        Me.sendfilebtn.selected = False
        Me.sendfilebtn.Size = New System.Drawing.Size(156, 33)
        Me.sendfilebtn.TabIndex = 2
        Me.sendfilebtn.Text = "          Send File"
        Me.sendfilebtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.sendfilebtn.Textcolor = System.Drawing.Color.White
        Me.sendfilebtn.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'recoverybtn
        '
        Me.recoverybtn.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.recoverybtn.BackColor = System.Drawing.Color.SeaGreen
        Me.recoverybtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.recoverybtn.BorderRadius = 0
        Me.recoverybtn.ButtonText = "       Reboot to Recovery"
        Me.recoverybtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.buttontrans.SetDecoration(Me.recoverybtn, BunifuAnimatorNS.DecorationType.None)
        Me.recoverybtn.DisabledColor = System.Drawing.Color.Gray
        Me.recoverybtn.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.recoverybtn.Iconcolor = System.Drawing.Color.Transparent
        Me.recoverybtn.Iconimage = Nothing
        Me.recoverybtn.Iconimage_right = Nothing
        Me.recoverybtn.Iconimage_right_Selected = Nothing
        Me.recoverybtn.Iconimage_Selected = Nothing
        Me.recoverybtn.IconMarginLeft = 0
        Me.recoverybtn.IconMarginRight = 0
        Me.recoverybtn.IconRightVisible = True
        Me.recoverybtn.IconRightZoom = 0R
        Me.recoverybtn.IconVisible = True
        Me.recoverybtn.IconZoom = 90.0R
        Me.recoverybtn.IsTab = False
        Me.recoverybtn.Location = New System.Drawing.Point(446, 158)
        Me.recoverybtn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.recoverybtn.Name = "recoverybtn"
        Me.recoverybtn.Normalcolor = System.Drawing.Color.IndianRed
        Me.recoverybtn.OnHovercolor = System.Drawing.Color.White
        Me.recoverybtn.OnHoverTextColor = System.Drawing.Color.IndianRed
        Me.recoverybtn.selected = False
        Me.recoverybtn.Size = New System.Drawing.Size(156, 33)
        Me.recoverybtn.TabIndex = 3
        Me.recoverybtn.Text = "       Reboot to Recovery"
        Me.recoverybtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.recoverybtn.Textcolor = System.Drawing.Color.White
        Me.recoverybtn.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'bootloaderbtn
        '
        Me.bootloaderbtn.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.bootloaderbtn.BackColor = System.Drawing.Color.SeaGreen
        Me.bootloaderbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bootloaderbtn.BorderRadius = 0
        Me.bootloaderbtn.ButtonText = "       Reboot to bootloader"
        Me.bootloaderbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.buttontrans.SetDecoration(Me.bootloaderbtn, BunifuAnimatorNS.DecorationType.None)
        Me.bootloaderbtn.DisabledColor = System.Drawing.Color.Gray
        Me.bootloaderbtn.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bootloaderbtn.Iconcolor = System.Drawing.Color.Transparent
        Me.bootloaderbtn.Iconimage = Nothing
        Me.bootloaderbtn.Iconimage_right = Nothing
        Me.bootloaderbtn.Iconimage_right_Selected = Nothing
        Me.bootloaderbtn.Iconimage_Selected = Nothing
        Me.bootloaderbtn.IconMarginLeft = 0
        Me.bootloaderbtn.IconMarginRight = 0
        Me.bootloaderbtn.IconRightVisible = True
        Me.bootloaderbtn.IconRightZoom = 0R
        Me.bootloaderbtn.IconVisible = True
        Me.bootloaderbtn.IconZoom = 90.0R
        Me.bootloaderbtn.IsTab = False
        Me.bootloaderbtn.Location = New System.Drawing.Point(12, 215)
        Me.bootloaderbtn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.bootloaderbtn.Name = "bootloaderbtn"
        Me.bootloaderbtn.Normalcolor = System.Drawing.Color.SeaGreen
        Me.bootloaderbtn.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.bootloaderbtn.OnHoverTextColor = System.Drawing.Color.White
        Me.bootloaderbtn.selected = False
        Me.bootloaderbtn.Size = New System.Drawing.Size(156, 33)
        Me.bootloaderbtn.TabIndex = 4
        Me.bootloaderbtn.Text = "       Reboot to bootloader"
        Me.bootloaderbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bootloaderbtn.Textcolor = System.Drawing.Color.White
        Me.bootloaderbtn.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'apkbtn
        '
        Me.apkbtn.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.apkbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.apkbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.apkbtn.BorderRadius = 0
        Me.apkbtn.ButtonText = "          Install Apk"
        Me.apkbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.buttontrans.SetDecoration(Me.apkbtn, BunifuAnimatorNS.DecorationType.None)
        Me.apkbtn.DisabledColor = System.Drawing.Color.Gray
        Me.apkbtn.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.apkbtn.Iconcolor = System.Drawing.Color.Transparent
        Me.apkbtn.Iconimage = Nothing
        Me.apkbtn.Iconimage_right = Nothing
        Me.apkbtn.Iconimage_right_Selected = Nothing
        Me.apkbtn.Iconimage_Selected = Nothing
        Me.apkbtn.IconMarginLeft = 0
        Me.apkbtn.IconMarginRight = 0
        Me.apkbtn.IconRightVisible = True
        Me.apkbtn.IconRightZoom = 0R
        Me.apkbtn.IconVisible = True
        Me.apkbtn.IconZoom = 90.0R
        Me.apkbtn.IsTab = False
        Me.apkbtn.Location = New System.Drawing.Point(446, 215)
        Me.apkbtn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.apkbtn.Name = "apkbtn"
        Me.apkbtn.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.apkbtn.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.apkbtn.OnHoverTextColor = System.Drawing.Color.White
        Me.apkbtn.selected = False
        Me.apkbtn.Size = New System.Drawing.Size(156, 33)
        Me.apkbtn.TabIndex = 5
        Me.apkbtn.Text = "          Install Apk"
        Me.apkbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.apkbtn.Textcolor = System.Drawing.Color.White
        Me.apkbtn.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'rebootbtn
        '
        Me.rebootbtn.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.rebootbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.rebootbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.rebootbtn.BorderRadius = 0
        Me.rebootbtn.ButtonText = "        Reboot Device"
        Me.rebootbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.buttontrans.SetDecoration(Me.rebootbtn, BunifuAnimatorNS.DecorationType.None)
        Me.rebootbtn.DisabledColor = System.Drawing.Color.Gray
        Me.rebootbtn.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rebootbtn.Iconcolor = System.Drawing.Color.Transparent
        Me.rebootbtn.Iconimage = Nothing
        Me.rebootbtn.Iconimage_right = Nothing
        Me.rebootbtn.Iconimage_right_Selected = Nothing
        Me.rebootbtn.Iconimage_Selected = Nothing
        Me.rebootbtn.IconMarginLeft = 0
        Me.rebootbtn.IconMarginRight = 0
        Me.rebootbtn.IconRightVisible = True
        Me.rebootbtn.IconRightZoom = 0R
        Me.rebootbtn.IconVisible = True
        Me.rebootbtn.IconZoom = 90.0R
        Me.rebootbtn.IsTab = False
        Me.rebootbtn.Location = New System.Drawing.Point(12, 277)
        Me.rebootbtn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rebootbtn.Name = "rebootbtn"
        Me.rebootbtn.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.rebootbtn.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.rebootbtn.OnHoverTextColor = System.Drawing.Color.White
        Me.rebootbtn.selected = False
        Me.rebootbtn.Size = New System.Drawing.Size(156, 33)
        Me.rebootbtn.TabIndex = 6
        Me.rebootbtn.Text = "        Reboot Device"
        Me.rebootbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.rebootbtn.Textcolor = System.Drawing.Color.White
        Me.rebootbtn.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Screenie
        '
        Me.Screenie.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Screenie.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Screenie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Screenie.BorderRadius = 0
        Me.Screenie.ButtonText = "          Screenshot"
        Me.Screenie.Cursor = System.Windows.Forms.Cursors.Hand
        Me.buttontrans.SetDecoration(Me.Screenie, BunifuAnimatorNS.DecorationType.None)
        Me.Screenie.DisabledColor = System.Drawing.Color.Gray
        Me.Screenie.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Screenie.Iconcolor = System.Drawing.Color.Transparent
        Me.Screenie.Iconimage = Nothing
        Me.Screenie.Iconimage_right = Nothing
        Me.Screenie.Iconimage_right_Selected = Nothing
        Me.Screenie.Iconimage_Selected = Nothing
        Me.Screenie.IconMarginLeft = 0
        Me.Screenie.IconMarginRight = 0
        Me.Screenie.IconRightVisible = True
        Me.Screenie.IconRightZoom = 0R
        Me.Screenie.IconVisible = True
        Me.Screenie.IconZoom = 90.0R
        Me.Screenie.IsTab = False
        Me.Screenie.Location = New System.Drawing.Point(446, 277)
        Me.Screenie.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Screenie.Name = "Screenie"
        Me.Screenie.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Screenie.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.Screenie.OnHoverTextColor = System.Drawing.Color.White
        Me.Screenie.selected = False
        Me.Screenie.Size = New System.Drawing.Size(156, 33)
        Me.Screenie.TabIndex = 7
        Me.Screenie.Text = "          Screenshot"
        Me.Screenie.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Screenie.Textcolor = System.Drawing.Color.White
        Me.Screenie.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'dis_hu
        '
        Me.dis_hu.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.dis_hu.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.dis_hu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.dis_hu.BorderRadius = 0
        Me.dis_hu.ButtonText = "       Disable Heads up"
        Me.dis_hu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.buttontrans.SetDecoration(Me.dis_hu, BunifuAnimatorNS.DecorationType.None)
        Me.dis_hu.DisabledColor = System.Drawing.Color.Gray
        Me.dis_hu.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dis_hu.Iconcolor = System.Drawing.Color.Transparent
        Me.dis_hu.Iconimage = Nothing
        Me.dis_hu.Iconimage_right = Nothing
        Me.dis_hu.Iconimage_right_Selected = Nothing
        Me.dis_hu.Iconimage_Selected = Nothing
        Me.dis_hu.IconMarginLeft = 0
        Me.dis_hu.IconMarginRight = 0
        Me.dis_hu.IconRightVisible = True
        Me.dis_hu.IconRightZoom = 0R
        Me.dis_hu.IconVisible = True
        Me.dis_hu.IconZoom = 90.0R
        Me.dis_hu.IsTab = False
        Me.dis_hu.Location = New System.Drawing.Point(12, 337)
        Me.dis_hu.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dis_hu.Name = "dis_hu"
        Me.dis_hu.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.dis_hu.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.dis_hu.OnHoverTextColor = System.Drawing.Color.White
        Me.dis_hu.selected = False
        Me.dis_hu.Size = New System.Drawing.Size(156, 33)
        Me.dis_hu.TabIndex = 8
        Me.dis_hu.Text = "       Disable Heads up"
        Me.dis_hu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.dis_hu.Textcolor = System.Drawing.Color.White
        Me.dis_hu.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'en_hu
        '
        Me.en_hu.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.en_hu.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.en_hu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.en_hu.BorderRadius = 0
        Me.en_hu.ButtonText = "          Enable Heads Up"
        Me.en_hu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.buttontrans.SetDecoration(Me.en_hu, BunifuAnimatorNS.DecorationType.None)
        Me.en_hu.DisabledColor = System.Drawing.Color.Gray
        Me.en_hu.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.en_hu.Iconcolor = System.Drawing.Color.Transparent
        Me.en_hu.Iconimage = Nothing
        Me.en_hu.Iconimage_right = Nothing
        Me.en_hu.Iconimage_right_Selected = Nothing
        Me.en_hu.Iconimage_Selected = Nothing
        Me.en_hu.IconMarginLeft = 0
        Me.en_hu.IconMarginRight = 0
        Me.en_hu.IconRightVisible = True
        Me.en_hu.IconRightZoom = 0R
        Me.en_hu.IconVisible = True
        Me.en_hu.IconZoom = 90.0R
        Me.en_hu.IsTab = False
        Me.en_hu.Location = New System.Drawing.Point(446, 337)
        Me.en_hu.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.en_hu.Name = "en_hu"
        Me.en_hu.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.en_hu.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.en_hu.OnHoverTextColor = System.Drawing.Color.White
        Me.en_hu.selected = False
        Me.en_hu.Size = New System.Drawing.Size(156, 33)
        Me.en_hu.TabIndex = 9
        Me.en_hu.Text = "          Enable Heads Up"
        Me.en_hu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.en_hu.Textcolor = System.Drawing.Color.White
        Me.en_hu.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuFlatButton6
        '
        Me.BunifuFlatButton6.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton6.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton6.BorderRadius = 0
        Me.BunifuFlatButton6.ButtonText = "          Refresh"
        Me.BunifuFlatButton6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.buttontrans.SetDecoration(Me.BunifuFlatButton6, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuFlatButton6.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton6.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuFlatButton6.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton6.Iconimage = Nothing
        Me.BunifuFlatButton6.Iconimage_right = Nothing
        Me.BunifuFlatButton6.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton6.Iconimage_Selected = Nothing
        Me.BunifuFlatButton6.IconMarginLeft = 0
        Me.BunifuFlatButton6.IconMarginRight = 0
        Me.BunifuFlatButton6.IconRightVisible = True
        Me.BunifuFlatButton6.IconRightZoom = 0R
        Me.BunifuFlatButton6.IconVisible = True
        Me.BunifuFlatButton6.IconZoom = 90.0R
        Me.BunifuFlatButton6.IsTab = False
        Me.BunifuFlatButton6.Location = New System.Drawing.Point(240, 383)
        Me.BunifuFlatButton6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BunifuFlatButton6.Name = "BunifuFlatButton6"
        Me.BunifuFlatButton6.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton6.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.BunifuFlatButton6.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton6.selected = False
        Me.BunifuFlatButton6.Size = New System.Drawing.Size(98, 33)
        Me.BunifuFlatButton6.TabIndex = 10
        Me.BunifuFlatButton6.Text = "          Refresh"
        Me.BunifuFlatButton6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton6.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton6.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'timer
        '
        Me.timer.Interval = 600
        '
        'open
        '
        Me.open.FileName = "OpenFileDialog1"
        '
        'buttontrans
        '
        Me.buttontrans.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide
        Me.buttontrans.Cursor = Nothing
        Animation10.AnimateOnlyDifferences = True
        Animation10.BlindCoeff = CType(resources.GetObject("Animation10.BlindCoeff"), System.Drawing.PointF)
        Animation10.LeafCoeff = 0!
        Animation10.MaxTime = 1.0!
        Animation10.MinTime = 0!
        Animation10.MosaicCoeff = CType(resources.GetObject("Animation10.MosaicCoeff"), System.Drawing.PointF)
        Animation10.MosaicShift = CType(resources.GetObject("Animation10.MosaicShift"), System.Drawing.PointF)
        Animation10.MosaicSize = 0
        Animation10.Padding = New System.Windows.Forms.Padding(0)
        Animation10.RotateCoeff = 0!
        Animation10.RotateLimit = 0!
        Animation10.ScaleCoeff = CType(resources.GetObject("Animation10.ScaleCoeff"), System.Drawing.PointF)
        Animation10.SlideCoeff = CType(resources.GetObject("Animation10.SlideCoeff"), System.Drawing.PointF)
        Animation10.TimeCoeff = 0!
        Animation10.TransparencyCoeff = 0!
        Me.buttontrans.DefaultAnimation = Animation10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(614, 428)
        Me.Controls.Add(Me.BunifuFlatButton6)
        Me.Controls.Add(Me.en_hu)
        Me.Controls.Add(Me.dis_hu)
        Me.Controls.Add(Me.Screenie)
        Me.Controls.Add(Me.rebootbtn)
        Me.Controls.Add(Me.apkbtn)
        Me.Controls.Add(Me.bootloaderbtn)
        Me.Controls.Add(Me.recoverybtn)
        Me.Controls.Add(Me.sendfilebtn)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.buttontrans.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Toolkit"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.BunifuImageButton4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents apkbtn As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents bootloaderbtn As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents recoverybtn As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents sendfilebtn As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents en_hu As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents dis_hu As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Screenie As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents rebootbtn As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Label1 As Label
    Friend WithEvents BunifuImageButton2 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuImageButton3 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuFlatButton6 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents timer As Timer
    Friend WithEvents open As OpenFileDialog
    Friend WithEvents BunifuImageButton4 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents buttontrans As BunifuAnimatorNS.BunifuTransition
End Class
