Imports System.Data
Imports System.Data.SqlClient
Public Class frmcon
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand

    Private Sub DBConnection()
        con.ConnectionString = "Data Source=LAPTOP-NUCQR7HS\SQLEXPRESS;Initial Catalog=HotelMG Database; Integrated Security=True"
        con.Open()
    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        DBConnection()
        Dim dateti As Date
        Dim regno, IDno, fname, lname, dur, hall, charge, pay, rcpt As String
        dateti = dtp.Value
        regno = txtRegno.Text
        IDno = txtID.Text
        fname = txtFname.Text
        lname = txtLname.Text
        dur = txtDura.Text
        hall = txtHall.Text
        charge = txtCharges.Text
        pay = cmbpay.SelectedItem
        rcpt = txtRcpt.Text

        Try
            cmd.Connection = con
            cmd.CommandText = "INSERT INTO Conference VALUES ('" & regno & "','" & IDno & "','" & fname & "','" & lname & "','" & dateti & "','" & dur & "','" & hall & "','" & charge & "','" & pay & "','" & rcpt & "')"
            cmd.ExecuteNonQuery()
            MessageBox.Show("Record is inserted to the Table", "Insert Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error while inserting record into table...!" & ex.Message, "Insert Record")
        Finally
            con.Close()
        End Try
        txtRegno.Clear()
        txtID.Clear()
        cmbpay.SelectedIndex = 0
        txtFname.Clear()
        txtLname.Clear()
        txtDura.Clear()
        txtHall.Clear()
        txtCharges.Clear()
        txtRcpt.Clear()
        txtRegno.Focus()
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        DBConnection()
        Try
            Dim query As String = "SELECT *FROM Conference"
            Dim da As SqlDataAdapter = New SqlDataAdapter(query, con)
            Dim ds As DataSet = New DataSet
            da.Fill(ds, "Conference")
            dgvcon.DataSource = ds.Tables("Conference")
        Catch ex As Exception
            MessageBox.Show("Error while selecting a table...!" & ex.Message, "Select all records")
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        Try
            txtRegno.Text = dgvcon.CurrentRow.Cells(0).Value.ToString()
            txtID.Text = dgvcon.CurrentRow.Cells(1).Value.ToString()
            txtFname.Text = dgvcon.CurrentRow.Cells(2).Value.ToString()
            txtLname.Text = dgvcon.CurrentRow.Cells(3).Value.ToString()
            dtp.Value = dgvcon.CurrentRow.Cells(4).Value.ToString()
            txtDura.Text = dgvcon.CurrentRow.Cells(5).Value.ToString()
            txtHall.Text = dgvcon.CurrentRow.Cells(6).Value.ToString()
            txtCharges.Text = dgvcon.CurrentRow.Cells(7).Value.ToString()
            cmbpay.Text = dgvcon.CurrentRow.Cells(8).Value.ToString()
            txtRcpt.Text = dgvcon.CurrentRow.Cells(9).Value.ToString()         

        Catch ex As Exception
            MessageBox.Show("Error while selecting records on table...!" & ex.Message, "Select Record")
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        DBConnection()
        Dim dateti As Date
        Dim regno, IDno, fname, lname, dur, hall, charge, pay, rcpt As String
        dateti = dtp.Value
        regno = txtRegno.Text
        IDno = txtID.Text
        fname = txtFname.Text
        lname = txtLname.Text
        dur = txtDura.Text
        hall = txtHall.Text
        charge = txtCharges.Text
        pay = cmbpay.SelectedItem
        rcpt = txtRcpt.Text

        Try
            cmd.Connection = con
            cmd.CommandText = "UPDATE Conference SET IDno='" & IDno & "',Fname='" & fname & "',Lname='" & lname & "',Date='" & dateti & "',Duration='" & dur & "',Hallno='" & hall & "',Charges='" & charge & "',Payment='" & pay & "',Rcptno='" & rcpt & "' WHERE Regno='" & regno & "'"
            cmd.ExecuteNonQuery()
            MessageBox.Show("Record is updated to the table", "Update Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error while updating record on table...!" & ex.Message, "Update Record")
        Finally
            con.Close()
        End Try
        txtRegno.Clear()
        txtID.Clear()
        cmbpay.SelectedIndex = 0
        txtFname.Clear()
        txtLname.Clear()
        txtDura.Clear()
        txtHall.Clear()
        txtCharges.Clear()
        txtRcpt.Clear()
        txtRegno.Focus()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        DBConnection()
        Dim regno As String
        regno = txtRegno.Text
        Try
            cmd.Connection = con
            If MessageBox.Show("Do you really want to delete this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.No Then
                MessageBox.Show("Operation Cancelled...!", "Delete Record")
            Else
                cmd.CommandText = "DELETE FROM Conference WHERE Regno='" & regno & "'"
                cmd.ExecuteNonQuery()
                MessageBox.Show("Record is deleted from table", "Delete Record")
            End If
        Catch ex As Exception
            MessageBox.Show("Error while deleting record on table...!" & ex.Message, "Delete Record")
        Finally
            con.Close()
        End Try
        txtRegno.Clear()
        txtID.Clear()
        cmbpay.SelectedIndex = 0
        txtFname.Clear()
        txtLname.Clear()
        txtDura.Clear()
        txtHall.Clear()
        txtCharges.Clear()
        txtRcpt.Clear()
        txtRegno.Focus()
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub frmcon_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class