<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Panel1 = New Panel()
        btnexit = New Button()
        btnview = New Button()
        Btnadd = New Button()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Transparent
        Panel1.Controls.Add(btnexit)
        Panel1.Controls.Add(btnview)
        Panel1.Controls.Add(Btnadd)
        Panel1.Location = New Point(375, 227)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(725, 187)
        Panel1.TabIndex = 1
        ' 
        ' btnexit
        ' 
        btnexit.Location = New Point(121, 121)
        btnexit.Name = "btnexit"
        btnexit.Size = New Size(178, 34)
        btnexit.TabIndex = 3
        btnexit.Text = "EXIT"
        btnexit.UseVisualStyleBackColor = True
        ' 
        ' btnview
        ' 
        btnview.Location = New Point(219, 28)
        btnview.Name = "btnview"
        btnview.Size = New Size(178, 34)
        btnview.TabIndex = 1
        btnview.Text = "view"
        btnview.UseVisualStyleBackColor = True
        ' 
        ' Btnadd
        ' 
        Btnadd.BackColor = Color.Transparent
        Btnadd.Location = New Point(24, 28)
        Btnadd.Name = "Btnadd"
        Btnadd.Size = New Size(176, 34)
        Btnadd.TabIndex = 0
        Btnadd.Text = "ADD patient"
        Btnadd.UseVisualStyleBackColor = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.Green_and_Blue_Gradient_Dental_Medical_Presentation
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(784, 530)
        Controls.Add(Panel1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Main Form"
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnview As Button
    Friend WithEvents Btnadd As Button
    Friend WithEvents btnexit As Button
End Class
