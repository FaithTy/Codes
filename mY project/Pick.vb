Imports System
Imports System.Data
Imports System.Data.Common
Imports System.Data.SqlClient
Public Class Pick

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim con As New SqlClient.SqlConnection
        Dim cmd As SqlClient.SqlCommand
        Dim sql As String

        Dim psku As Integer
        '' pqty = TextBox1.Text

        con.ConnectionString = "Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Faithy\Documents\MYSQLDB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True"
        con.Open()

        sql = "update from Inven_table where SKU = '" & psku & "'"
        cmd = New SqlClient.SqlCommand(sql, con)
        cmd.ExecuteNonQuery()
        Call clear()
        MsgBox("Item Deleted")
        con.Close()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Call clear()

    End Sub
    Public Sub clear()
        ComboBox1.Text = ""
        TextBox2.Text = ""
        TextBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""
        ComboBox4.Text = ""
        TextBox6.Text = ""
        TextBox5.Text = ""
        TextBox4.Text = ""
        TextBox3.Text = ""
        ComboBox8.Text = ""
        ComboBox1.Focus()
    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        Dim con As New SqlClient.SqlConnection
        Dim cmd As SqlClient.SqlCommand
        Dim sql As String

        Dim pqty As Integer
        pqty = TextBox1.Text

        If e.KeyCode = Keys.Enter Then
            Dim rdr As SqlClient.SqlDataReader
            pqty = TextBox1.Text
             con.ConnectionString = "Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Faithy\Documents\MYSQLDB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True"
            con.Open()


            sql = "select* from Inven_table where Qty = '" & pqty & "'"
            cmd = New SqlClient.SqlCommand(sql, con)
            rdr = cmd.ExecuteReader()

            While rdr.Read
                ComboBox1.Text = rdr("Des")
                ComboBox3.Text = rdr("Loc")
                ComboBox1.Text = rdr("SKU")
                ComboBox4.Text = rdr("Unit")
                TextBox2.Text = rdr("Dr")
                TextBox5.Text = rdr("Supp")
                TextBox3.Text = rdr("Date")
                TextBox6.Text = rdr("Price")
                TextBox4.Text = rdr("TotalAmount")
                ComboBox8.Text = rdr("Rec")
                rdr.Read()
            End While
            rdr.Close()

            con.Close()
        End If

    End Sub
End Class