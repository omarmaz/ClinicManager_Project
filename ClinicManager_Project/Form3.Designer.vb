<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAddPatient
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAddPatient))
        grpPatientInfo = New GroupBox()
        dtpDate = New DateTimePicker()
        lblDate = New Label()
        txtPhone = New TextBox()
        lblPhone = New Label()
        txtAge = New TextBox()
        lblAge = New Label()
        txtName = New TextBox()
        lblName = New Label()
        blnSCB = New Panel()
        btnBack = New Button()
        btnClear = New Button()
        btnSave = New Button()
        grpPatientInfo.SuspendLayout()
        blnSCB.SuspendLayout()
        SuspendLayout()
        ' 
        ' grpPatientInfo
        ' 
        grpPatientInfo.BackColor = Color.Transparent
        grpPatientInfo.Controls.Add(dtpDate)
        grpPatientInfo.Controls.Add(lblDate)
        grpPatientInfo.Controls.Add(txtPhone)
        grpPatientInfo.Controls.Add(lblPhone)
        grpPatientInfo.Controls.Add(txtAge)
        grpPatientInfo.Controls.Add(lblAge)
        grpPatientInfo.Controls.Add(txtName)
        grpPatientInfo.Controls.Add(lblName)
        grpPatientInfo.Font = New Font("Sitka Small", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        grpPatientInfo.ForeColor = SystemColors.ButtonHighlight
        grpPatientInfo.Location = New Point(97, 12)
        grpPatientInfo.Name = "grpPatientInfo"
        grpPatientInfo.Size = New Size(590, 284)
        grpPatientInfo.TabIndex = 0
        grpPatientInfo.TabStop = False
        grpPatientInfo.Text = "Patient Information"
        ' 
        ' dtpDate
        ' 
        dtpDate.Location = New Point(161, 161)
        dtpDate.Name = "dtpDate"
        dtpDate.Size = New Size(264, 24)
        dtpDate.TabIndex = 7
        ' 
        ' lblDate
        ' 
        lblDate.AutoSize = True
        lblDate.Location = New Point(14, 161)
        lblDate.Name = "lblDate"
        lblDate.Size = New Size(141, 19)
        lblDate.TabIndex = 6
        lblDate.Text = "Appointment Date:"
        ' 
        ' txtPhone
        ' 
        txtPhone.Location = New Point(77, 123)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(187, 24)
        txtPhone.TabIndex = 5
        ' 
        ' lblPhone
        ' 
        lblPhone.AutoSize = True
        lblPhone.Location = New Point(14, 123)
        lblPhone.Name = "lblPhone"
        lblPhone.RightToLeft = RightToLeft.No
        lblPhone.Size = New Size(57, 19)
        lblPhone.TabIndex = 4
        lblPhone.Text = "Phone:"
        ' 
        ' txtAge
        ' 
        txtAge.Location = New Point(77, 81)
        txtAge.Name = "txtAge"
        txtAge.Size = New Size(187, 24)
        txtAge.TabIndex = 3
        ' 
        ' lblAge
        ' 
        lblAge.AutoSize = True
        lblAge.Location = New Point(17, 81)
        lblAge.Name = "lblAge"
        lblAge.Size = New Size(39, 19)
        lblAge.TabIndex = 2
        lblAge.Text = "Age:"
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(77, 38)
        txtName.Name = "txtName"
        txtName.Size = New Size(187, 24)
        txtName.TabIndex = 1
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.ForeColor = SystemColors.ButtonHighlight
        lblName.Location = New Point(17, 38)
        lblName.Name = "lblName"
        lblName.Size = New Size(54, 19)
        lblName.TabIndex = 0
        lblName.Text = "Name:"
        ' 
        ' blnSCB
        ' 
        blnSCB.BackColor = Color.Transparent
        blnSCB.Controls.Add(btnBack)
        blnSCB.Controls.Add(btnClear)
        blnSCB.Controls.Add(btnSave)
        blnSCB.Location = New Point(97, 315)
        blnSCB.Name = "blnSCB"
        blnSCB.Size = New Size(590, 109)
        blnSCB.TabIndex = 1
        ' 
        ' btnBack
        ' 
        btnBack.Font = New Font("Sitka Text", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBack.Location = New Point(446, 28)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(105, 39)
        btnBack.TabIndex = 2
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Font = New Font("Sitka Text", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClear.Location = New Point(236, 28)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(105, 39)
        btnClear.TabIndex = 1
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnSave
        ' 
        btnSave.Font = New Font("Sitka Text", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSave.Location = New Point(17, 28)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(105, 39)
        btnSave.TabIndex = 0
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' FormAddPatient
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources._9
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(784, 530)
        Controls.Add(blnSCB)
        Controls.Add(grpPatientInfo)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "FormAddPatient"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Add New Patient"
        grpPatientInfo.ResumeLayout(False)
        grpPatientInfo.PerformLayout()
        blnSCB.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents grpPatientInfo As GroupBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents lblPhone As Label
    Friend WithEvents txtAge As TextBox
    Friend WithEvents lblAge As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents lblDate As Label
    Friend WithEvents blnSCB As Panel
    Friend WithEvents btnBack As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnSave As Button
End Class
