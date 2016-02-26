Public Class InventoryList

    Private Sub TextBox1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        ''If e.KeyCode = Keys.Enter Then
        Dim con As New SqlClient.SqlConnection
        Dim cmd As SqlClient.SqlCommand
        Dim sql As String


        Dim pdes As String
        Dim rdr As SqlClient.SqlDataReader

        pdes = TextBox1.Text

        dgr.Rows.Clear()
        con.ConnectionString = "Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Faithy\Documents\MYSQLDB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True"
        con.Open()



        sql = "select* from Inven_table where Des = '" & pdes & "'"
        cmd = New SqlClient.SqlCommand(sql, con)
        rdr = cmd.ExecuteReader

        While rdr.Read
            Me.dgr.Rows.Add(rdr("SKU"), rdr("Date"), rdr("Unit"), rdr("Loc"), rdr("Qty"), rdr("Unit"), rdr("Price"))
            'Call clear()
        End While
        rdr.Close()
        con.Close()
        ''End If
    End Sub

    Private Sub InventoryList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class