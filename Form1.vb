Imports System.Data
Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Dim con As New OleDb.OleDbConnection
    Private Sub btnVerify_Click(sender As Object, e As EventArgs) Handles btnVerify.Click
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\gdzvapatsva\Desktop\usernames.accdb"
        con.Open()
        Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM login WHERE studentname = '" &
    txtstudentname.Text & "' AND [studentnumber] = '" & txtStudentnumber.Text & "' ", con)
        Dim sdr As OleDbDataReader = cmd.ExecuteReader()
        If sdr.Read() = True Then
            MessageBox.Show("Login successfull")
            con.Close()
            products.Show()
            Me.Hide()
        Else
            MessageBox.Show("Login NOT successfull" & vbNewLine & "Please Log in again")
            txtstudentname.Clear()
            txtStudentnumber.Clear()
            txtstudentname.Focus()
            con.Close()
        End If

    End Sub
End Class
