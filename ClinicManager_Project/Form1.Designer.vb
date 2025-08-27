<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        MySqlCommand1 = New MySql.Data.MySqlClient.MySqlCommand()
        Panel1 = New Panel()
        checkpass = New CheckBox()
        btnexit = New Button()
        btnlogin = New Button()
        txtpassword = New TextBox()
        txtusername = New TextBox()
        lblpass1 = New Label()
        lblname1 = New Label()
        ToolTip1 = New ToolTip(components)
        ToolTip2 = New ToolTip(components)
        ToolTip3 = New ToolTip(components)
        SuspendLayout()
        ' 
        ' MySqlCommand1
        ' 
        MySqlCommand1.CacheAge = 0
        MySqlCommand1.Connection = Nothing
        MySqlCommand1.EnableCaching = False
        MySqlCommand1.Transaction = Nothing
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Transparent
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(800, 75)
        Panel1.TabIndex = 8
        ' 
        ' checkpass
        ' 
        checkpass.Anchor = AnchorStyles.None
        checkpass.AutoSize = True
        checkpass.BackColor = Color.Transparent
        checkpass.Location = New Point(633, 280)
        checkpass.Name = "checkpass"
        checkpass.Size = New Size(107, 19)
        checkpass.TabIndex = 15
        checkpass.Text = "show password"
        checkpass.UseVisualStyleBackColor = False
        ' 
        ' btnexit
        ' 
        btnexit.Anchor = AnchorStyles.None
        btnexit.BackColor = Color.Transparent
        btnexit.Font = New Font("Britannic Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnexit.Location = New Point(554, 323)
        btnexit.Name = "btnexit"
        btnexit.Size = New Size(87, 34)
        btnexit.TabIndex = 14
        btnexit.Text = "exit"
        btnexit.UseVisualStyleBackColor = False
        ' 
        ' btnlogin
        ' 
        btnlogin.Anchor = AnchorStyles.None
        btnlogin.BackColor = Color.Transparent
        btnlogin.Font = New Font("Britannic Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnlogin.Location = New Point(465, 323)
        btnlogin.Name = "btnlogin"
        btnlogin.Size = New Size(83, 34)
        btnlogin.TabIndex = 13
        btnlogin.Text = "login"
        btnlogin.UseVisualStyleBackColor = False
        ' 
        ' txtpassword
        ' 
        txtpassword.Anchor = AnchorStyles.None
        txtpassword.Location = New Point(527, 278)
        txtpassword.Name = "txtpassword"
        txtpassword.Size = New Size(100, 23)
        txtpassword.TabIndex = 12
        txtpassword.UseSystemPasswordChar = True
        ' 
        ' txtusername
        ' 
        txtusername.Anchor = AnchorStyles.None
        txtusername.Location = New Point(527, 233)
        txtusername.Name = "txtusername"
        txtusername.Size = New Size(100, 23)
        txtusername.TabIndex = 11
        ' 
        ' lblpass1
        ' 
        lblpass1.Anchor = AnchorStyles.None
        lblpass1.AutoSize = True
        lblpass1.BackColor = Color.Transparent
        lblpass1.Font = New Font("Britannic Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblpass1.Location = New Point(424, 278)
        lblpass1.Name = "lblpass1"
        lblpass1.Size = New Size(97, 23)
        lblpass1.TabIndex = 10
        lblpass1.Text = "password"
        ' 
        ' lblname1
        ' 
        lblname1.Anchor = AnchorStyles.None
        lblname1.AutoSize = True
        lblname1.BackColor = Color.Transparent
        lblname1.Font = New Font("Britannic Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblname1.Location = New Point(431, 233)
        lblname1.Name = "lblname1"
        lblname1.Size = New Size(90, 23)
        lblname1.TabIndex = 9
        lblname1.Text = "usernme"
        ' 
        ' ToolTip1
        ' 
        ToolTip1.ToolTipTitle = "تسجيل دخول"
        ' 
        ' ToolTip2
        ' 
        ToolTip2.ToolTipTitle = "خروج"
        ' 
        ' ToolTip3
        ' 
        ToolTip3.ToolTipTitle = "عرض /اخفاء"
        ' 
        ' Form1
        ' 
        AcceptButton = btnlogin
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources._3
        BackgroundImageLayout = ImageLayout.Stretch
        CancelButton = btnexit
        ClientSize = New Size(800, 450)
        Controls.Add(Panel1)
        Controls.Add(checkpass)
        Controls.Add(btnexit)
        Controls.Add(btnlogin)
        Controls.Add(txtpassword)
        Controls.Add(txtusername)
        Controls.Add(lblpass1)
        Controls.Add(lblname1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form1"
        Text = "Login"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MySqlCommand1 As MySql.Data.MySqlClient.MySqlCommand
    Friend WithEvents Panel1 As Panel
    Friend WithEvents checkpass As CheckBox
    Friend WithEvents btnexit As Button
    Friend WithEvents btnlogin As Button
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents txtusername As TextBox
    Friend WithEvents lblpass1 As Label
    Friend WithEvents lblname1 As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ToolTip2 As ToolTip
    Friend WithEvents ToolTip3 As ToolTip
End Class
