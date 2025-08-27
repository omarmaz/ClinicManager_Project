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
        lblTitle = New Label()
        DataGridView1 = New DataGridView()
        BtnRefresh = New Button()
        BtnDelete = New Button()
        BtnBack = New Button()
        txtSearchName = New TextBox()
        Label1 = New Label()
        BtnSearch = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.BackColor = Color.Transparent
        lblTitle.Font = New Font("Sitka Text", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        lblTitle.Location = New Point(326, 9)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(177, 30)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Patient Records"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(12, 134)
        DataGridView1.MultiSelect = False
        DataGridView1.Name = "DataGridView1"
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Size = New Size(430, 307)
        DataGridView1.TabIndex = 1
        ' 
        ' BtnRefresh
        ' 
        BtnRefresh.Location = New Point(180, 458)
        BtnRefresh.Name = "BtnRefresh"
        BtnRefresh.Size = New Size(100, 40)
        BtnRefresh.TabIndex = 2
        BtnRefresh.Text = "Refresh"
        BtnRefresh.UseVisualStyleBackColor = True
        ' 
        ' BtnDelete
        ' 
        BtnDelete.BackgroundImageLayout = ImageLayout.Stretch
        BtnDelete.Location = New Point(12, 458)
        BtnDelete.Name = "BtnDelete"
        BtnDelete.Size = New Size(100, 40)
        BtnDelete.TabIndex = 3
        BtnDelete.Text = "Delete"
        BtnDelete.UseVisualStyleBackColor = True
        ' 
        ' BtnBack
        ' 
        BtnBack.Location = New Point(342, 458)
        BtnBack.Name = "BtnBack"
        BtnBack.Size = New Size(100, 40)
        BtnBack.TabIndex = 4
        BtnBack.Text = "Back"
        BtnBack.UseVisualStyleBackColor = True
        ' 
        ' txtSearchName
        ' 
        txtSearchName.Location = New Point(156, 56)
        txtSearchName.Name = "txtSearchName"
        txtSearchName.Size = New Size(144, 23)
        txtSearchName.TabIndex = 5
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(91, 55)
        Label1.Name = "Label1"
        Label1.Size = New Size(59, 23)
        Label1.TabIndex = 6
        Label1.Text = "Name:"
        ' 
        ' BtnSearch
        ' 
        BtnSearch.Location = New Point(156, 95)
        BtnSearch.Name = "BtnSearch"
        BtnSearch.Size = New Size(144, 23)
        BtnSearch.TabIndex = 7
        BtnSearch.Text = "Search"
        BtnSearch.UseVisualStyleBackColor = True
        ' 
        ' ViewPatients
        ' 
        AutoScaleDimensions = New SizeF(7F, 18F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.Green_and_Blue_Gradient_Dental_Medical_Presentation__3_
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(784, 529)
        Controls.Add(BtnSearch)
        Controls.Add(Label1)
        Controls.Add(txtSearchName)
        Controls.Add(BtnBack)
        Controls.Add(BtnDelete)
        Controls.Add(BtnRefresh)
        Controls.Add(DataGridView1)
        Controls.Add(lblTitle)
        DoubleBuffered = True
        Font = New Font("Sitka Text", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(3, 4, 3, 4)
        Name = "ViewPatients"
        StartPosition = FormStartPosition.CenterScreen
        Text = "View Patients"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BtnRefresh As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents BtnBack As Button
    Friend WithEvents txtSearchName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnSearch As Button
End Class
