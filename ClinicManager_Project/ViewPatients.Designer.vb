<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewPatients
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewPatients))
        Label1 = New Label()
        Label2 = New Label()
        txtSearchName = New TextBox()
        BtnSearch = New Button()
        BtnBack = New Button()
        BtnRefresh = New Button()
        BtnDelete = New Button()
        DataGridView1 = New DataGridView()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Stencil", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(264, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(222, 25)
        Label1.TabIndex = 0
        Label1.Text = "Patient Reccords"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(167, 46)
        Label2.Name = "Label2"
        Label2.Size = New Size(59, 19)
        Label2.TabIndex = 1
        Label2.Text = "Name:"
        ' 
        ' txtSearchName
        ' 
        txtSearchName.Location = New Point(232, 46)
        txtSearchName.Name = "txtSearchName"
        txtSearchName.Size = New Size(127, 23)
        txtSearchName.TabIndex = 2
        ' 
        ' BtnSearch
        ' 
        BtnSearch.Font = New Font("Sitka Text", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnSearch.Location = New Point(232, 75)
        BtnSearch.Name = "BtnSearch"
        BtnSearch.Size = New Size(100, 32)
        BtnSearch.TabIndex = 3
        BtnSearch.Text = "Search"
        BtnSearch.UseVisualStyleBackColor = True
        ' 
        ' BtnBack
        ' 
        BtnBack.Font = New Font("Sitka Text", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnBack.Location = New Point(276, 368)
        BtnBack.Name = "BtnBack"
        BtnBack.Size = New Size(100, 32)
        BtnBack.TabIndex = 4
        BtnBack.Text = "Back"
        BtnBack.UseVisualStyleBackColor = True
        ' 
        ' BtnRefresh
        ' 
        BtnRefresh.Font = New Font("Sitka Text", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnRefresh.Location = New Point(144, 368)
        BtnRefresh.Name = "BtnRefresh"
        BtnRefresh.Size = New Size(100, 32)
        BtnRefresh.TabIndex = 5
        BtnRefresh.Text = "Refresh"
        BtnRefresh.UseVisualStyleBackColor = True
        ' 
        ' BtnDelete
        ' 
        BtnDelete.Font = New Font("Sitka Small", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnDelete.Location = New Point(12, 368)
        BtnDelete.Name = "BtnDelete"
        BtnDelete.Size = New Size(100, 32)
        BtnDelete.TabIndex = 6
        BtnDelete.Text = "Delete"
        BtnDelete.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(3, 113)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(441, 249)
        DataGridView1.TabIndex = 7
        ' 
        ' ViewPatients
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.Green_and_Blue_Gradient_Dental_Medical_Presentation__1_
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(DataGridView1)
        Controls.Add(BtnDelete)
        Controls.Add(BtnRefresh)
        Controls.Add(BtnBack)
        Controls.Add(BtnSearch)
        Controls.Add(txtSearchName)
        Controls.Add(Label2)
        Controls.Add(Label1)
        DoubleBuffered = True
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "ViewPatients"
        Text = "ViewPatients"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSearchName As TextBox
    Friend WithEvents BtnSearch As Button
    Friend WithEvents BtnBack As Button
    Friend WithEvents BtnRefresh As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
