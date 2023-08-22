Imports System.Data
Imports System.Data.OleDb

Public Class products
    Dim con As New OleDb.OleDbConnection
    Dim ds As New DataSet
    Dim da As New OleDbDataAdapter
    Dim tables As DataTableCollection
    Dim source As New BindingSource
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\gdzvapatsva\Desktop\usernames.accdb"
        con.Open()
        tables = ds.Tables
        Dim cmd As OleDbCommand = New OleDbCommand("Select * From PRODUCTS", con)
        da = New OleDbDataAdapter(cmd)

        da.Fill(ds, "Products")
        Dim view As New DataView(tables(0))
        source.DataSource = view
        DataGridView1.DataSource = source

        con.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\gdzvapatsva\Desktop\usernames.accdb"
        con.Open()
        Dim cmd As OleDbCommand = New OleDbCommand("Insert into PRODUCTS Values (?,?,?,?)", con)
        cmd.Parameters.Add(New OleDbParameter("Product_ID", (TextBox1.Text)))
        cmd.Parameters.Add(New OleDbParameter("Product_Name", (TextBox2.Text)))
        cmd.Parameters.Add(New OleDbParameter("Quantity", (TextBox3.Text)))
        cmd.Parameters.Add(New OleDbParameter("Unit_price", (TextBox4.Text)))
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            con.Close()
            MessageBox.Show("Record Successfully Added")
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
            DataGridView1.DataSource = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class