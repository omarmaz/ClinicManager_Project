Imports MySql.Data.MySqlClient

' ========== Login Form ==========
Public Class Form1

    ' زر Login
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        Dim user As String = txtusername.Text.Trim()
        Dim pass As String = txtpassword.Text.Trim()

        ' تحقق يدوي من المستخدم
        If user = "amr" AndAlso pass = "1234" Then
            ' افتح الفورم الرئيسي
            Dim mainForm As New Form2()
            mainForm.Show()
            Me.Hide()
        Else
            MessageBox.Show("Invalid Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtpassword.Clear()
            txtusername.Focus()
        End If
    End Sub

    ' زر Exit
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Application.Exit()
    End Sub

    ' CheckBox لإظهار/إخفاء الباسورد
    Private Sub checkpass_CheckedChanged(sender As Object, e As EventArgs) Handles checkpass.CheckedChanged
        txtpassword.UseSystemPasswordChar = Not checkpass.Checked
    End Sub

    ' فورم التحميل: تأكد إن الباسورد مخفي أول ما يفتح الفورم
    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtpassword.UseSystemPasswordChar = True
        checkpass.Checked = False
    End Sub

End Class


' ========== Main Menu ==========
Public Class Form2

    ' زر Add Patient
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles Btnadd.Click
        Dim addForm As New FormAddPatient()
        addForm.ShowDialog()
    End Sub

    ' زر View Patients
    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnview.Click
        Dim viewForm As New ViewPatients()
        viewForm.ShowDialog()
    End Sub

    ' زر Exit
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Application.Exit()
    End Sub

End Class


' ========== Add Patient ==========
Public Class FormAddPatient

    ' Connection String
    Private connStr As String = "server=localhost;user id=root;password=omarmazen2004;database=ClinicDB"

    ' ===== Save Button =====
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' تحقق من إدخال البيانات
        If txtName.Text = "" Or txtAge.Text = "" Or txtPhone.Text = "" Then
            MessageBox.Show("Please fill all fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' تأكد إن Age رقم
        Dim ageNum As Integer
        If Not Integer.TryParse(txtAge.Text, ageNum) Then
            MessageBox.Show("Age must be a number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtAge.Focus()
            Return
        End If

        ' اتصال بقاعدة البيانات
        Using conn As New MySqlConnection(connStr)
            Try
                conn.Open()

                ' 1- تحقق من عدد المواعيد بنفس اليوم
                Dim checkCountQuery As String = "SELECT COUNT(*) FROM Patients WHERE AppointmentDate=@AppointmentDate"
                Using checkCmd As New MySqlCommand(checkCountQuery, conn)
                    checkCmd.Parameters.AddWithValue("@AppointmentDate", dtpDate.Value.ToString("yyyy-MM-dd"))
                    Dim count As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())
                    If count >= 5 Then
                        MessageBox.Show("لا يمكن الحجز، هذا اليوم ممتلئ (5 حجوزات فقط).", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return
                    End If
                End Using

                ' 2- تحقق من تكرار نفس المريض بنفس اليوم
                Dim checkDuplicateQuery As String = "SELECT COUNT(*) FROM Patients WHERE Name=@Name AND Phone=@Phone AND AppointmentDate=@AppointmentDate"
                Using dupCmd As New MySqlCommand(checkDuplicateQuery, conn)
                    dupCmd.Parameters.AddWithValue("@Name", txtName.Text.Trim())
                    dupCmd.Parameters.AddWithValue("@Phone", txtPhone.Text.Trim())
                    dupCmd.Parameters.AddWithValue("@AppointmentDate", dtpDate.Value.ToString("yyyy-MM-dd"))
                    Dim exists As Integer = Convert.ToInt32(dupCmd.ExecuteScalar())
                    If exists > 0 Then
                        MessageBox.Show("المريض مسجل مسبقاً في نفس اليوم.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return
                    End If
                End Using

                ' 3- إذا الأمور تمام → سجل المريض
                Dim query As String = "INSERT INTO Patients (Name, Age, Phone, AppointmentDate) VALUES (@Name, @Age, @Phone, @AppointmentDate)"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Name", txtName.Text.Trim())
                    cmd.Parameters.AddWithValue("@Age", ageNum)
                    cmd.Parameters.AddWithValue("@Phone", txtPhone.Text.Trim())
                    cmd.Parameters.AddWithValue("@AppointmentDate", dtpDate.Value.ToString("yyyy-MM-dd"))
                    cmd.ExecuteNonQuery()
                End Using

                MessageBox.Show("تم حجز الموعد بنجاح!", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ClearFields()

            Catch ex As Exception
                MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    ' ===== Clear Button =====
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearFields()
    End Sub

    ' ===== Back Button =====
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    ' ===== Sub لإعادة الفراغ للحقول =====
    Private Sub ClearFields()
        txtName.Clear()
        txtAge.Clear()
        txtPhone.Clear()
        dtpDate.Value = DateTime.Now
    End Sub

End Class


' ========== View Patients ==========
Public Class ViewPatients

    ' Connection String
    Dim conn As New MySqlConnection("server=localhost;userid=root;password=omarmazen2004;database=ClinicDB")

    ' ===== Load Patients into DataGridView =====
    Sub LoadPatients(Optional searchTerm As String = "")
        Try
            conn.Open()
            Dim query As String
            If searchTerm = "" Then
                query = "SELECT * FROM Patients"
            Else
                query = "SELECT * FROM Patients WHERE Name LIKE @name"
            End If

            Dim cmd As New MySqlCommand(query, conn)
            If searchTerm <> "" Then
                cmd.Parameters.AddWithValue("@name", "%" & searchTerm & "%")
            End If

            Dim da As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)

            ' 🟢 الحل: تأكد من تصفير الداتا قبل العرض
            DataGridView1.DataSource = Nothing
            DataGridView1.Rows.Clear()
            DataGridView1.DataSource = dt

            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Database Error: " & ex.Message)
            conn.Close()
        End Try
    End Sub

    ' ===== Form Load =====
    Private Sub ViewPatients_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPatients()
    End Sub

    ' ===== Refresh Button =====
    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles BtnRefresh.Click
        txtSearchName.Clear()
        LoadPatients()
    End Sub

    ' ===== Delete Button =====
    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim id As Integer = DataGridView1.SelectedRows(0).Cells("ID").Value
            Dim result = MessageBox.Show("Are you sure you want to delete this patient?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If result = DialogResult.Yes Then
                Try
                    conn.Open()
                    Dim cmd As New MySqlCommand("DELETE FROM Patients WHERE ID=@id", conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.ExecuteNonQuery()
                    conn.Close()
                    MessageBox.Show("Patient deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LoadPatients()
                Catch ex As Exception
                    MessageBox.Show("Database Error: " & ex.Message)
                    conn.Close()
                End Try
            End If
        Else
            MessageBox.Show("Please select a patient first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    ' ===== Back Button =====
    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Me.Hide()
        Form2.Show()
    End Sub

    ' ===== Update directly on DataGridView =====
    Private Sub DataGridView1_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit
        Try
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            Dim id As Integer = row.Cells("ID").Value
            Dim name As String = row.Cells("Name").Value
            Dim age As Integer = Convert.ToInt32(row.Cells("Age").Value)
            Dim phone As String = row.Cells("Phone").Value
            Dim appDate As Date = Convert.ToDateTime(row.Cells("AppointmentDate").Value)

            conn.Open()
            Dim cmd As New MySqlCommand("UPDATE Patients SET Name=@name, Age=@age, Phone=@phone, AppointmentDate=@appDate WHERE ID=@id", conn)
            cmd.Parameters.AddWithValue("@id", id)
            cmd.Parameters.AddWithValue("@name", name)
            cmd.Parameters.AddWithValue("@age", age)
            cmd.Parameters.AddWithValue("@phone", phone)
            cmd.Parameters.AddWithValue("@appDate", appDate.ToString("yyyy-MM-dd"))
            cmd.ExecuteNonQuery()
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Update Error: " & ex.Message)
            conn.Close()
        End Try
    End Sub

    ' ===== Search Button =====
    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        Dim searchText As String = txtSearchName.Text.Trim()
        If searchText = "" Then
            MessageBox.Show("Please enter a name to search!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtSearchName.Focus()
            Return
        End If

        LoadPatients(searchText)
    End Sub

End Class
