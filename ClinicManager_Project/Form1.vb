Imports MySql.Data.MySqlClient

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Connection string
        Dim connStr As String = "server=localhost;user id=root;password=omarmazen2004;database=ClinicDB"
        Dim conn As New MySqlConnection(connStr)

        Try
            conn.Open() ' Try to open connection
            MessageBox.Show("Database connection successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Database connection failed: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close() ' Always close connections
        End Try
    End Sub
End Class
