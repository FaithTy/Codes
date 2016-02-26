Imports System
Imports System.Data
Imports System.Data.Common
Imports System.Data.SqlClient

Public Class Receive



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim con As New SqlClient.SqlConnection
        Dim cmd As SqlClient.SqlCommand
        Dim sql As String

        Dim psku, pdr, pqty As Integer
        Dim pdes, ploc, psupp, prec, punit As String
        Dim pprice, ptot As Decimal

        Dim pdate As String

        psku = ComboBox1.Text
        pdr = TextBox2.Text
        pqty = TextBox1.Text
        pdes = ComboBox2.Text
        ploc = ComboBox3.Text
        punit = ComboBox4.Text
        pprice = TextBox6.Text
        psupp = TextBox5.Text
        prec = ComboBox8.Text
        ptot = TextBox4.Text
        pdate = TextBox3.Text


        con.ConnectionString = "Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Faithy\Documents\MYSQLDB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True"
        con.Open()

        sql = "insert into Inven_table(SKU,Des,Loc,Qty,Unit,Dr,Supp,Date,Price,TotalAmount,Rec)values('" & psku & "','" & pdes & "','" & ploc & "','" & pqty & "','" & punit & "','" & pdr & "','" & psupp & "','" & pdate & "','" & pprice & "','" & ptot & "','" & prec & "')"
        cmd = New SqlClient.SqlCommand(sql, con)
        cmd.ExecuteNonQuery()
        MsgBox("Successfully Submitted")
        con.Close()
        Call clear()



    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        
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

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub HomeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HomeToolStripMenuItem.Click
        Me.Hide()
        Form1.Show()

    End Sub

    Private Sub PickToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PickToolStripMenuItem.Click
        Me.Hide()
        Pick.Show()

    End Sub

   
  
    
End Class