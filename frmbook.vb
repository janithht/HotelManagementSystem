Imports System.Data
Imports System.Data.SqlClient
Public Class frmbook
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand

    Private Sub DBConnection()
        con.ConnectionString = "Data Source=LAPTOP-NUCQR7HS\SQLEXPRESS;Initial Catalog=HotelMG Database; Integrated Security=True"
        con.Open()
    End Sub
    Private Sub frmbook_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        DBConnection()
        Dim dateti As Date
        Dim regno, IDno, gender, cont, add As String
        dateti = dtp.Value
        regno = txtRegno.Text
        IDno = txtID.Text
        gender = cmbGender.SelectedItem
        cont = txtContact.Text
        add = txtAdd.Text

        Try
            cmd.Connection = con
            cmd.CommandText = "INSERT INTO Booking VALUES ('" & dateti & "','" & regno & "','" & IDno & "','" & gender & "','" & cont & "','" & add & "')"
            cmd.ExecuteNonQuery()
            MessageBox.Show("Record is inserted to the Table", "Insert Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error while inserting record into table...!" & ex.Message, "Insert Record")
        Finally
            con.Close()
        End Try
        txtRegno.Clear()
        txtID.Clear()
        cmbGender.SelectedIndex = 0
        txtContact.Clear()
        txtAdd.Clear()
        txtRegno.Focus()
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        DBConnection()
        Try
            Dim query As String = "SELECT *FROM Booking"
            Dim da As SqlDataAdapter = New SqlDataAdapter(query, con)
            Dim ds As DataSet = New DataSet
            da.Fill(ds, "Booking")
            dgvbooking.DataSource = ds.Tables("Booking")
        Catch ex As Exception
            MessageBox.Show("Error while selecting a table...!" & ex.Message, "Select all records")
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        Try
            dtp.Value = dgvbooking.CurrentRow.Cells(0).Value.ToString()
            txtRegno.Text = dgvbooking.CurrentRow.Cells(1).Value.ToString()
            txtID.Text = dgvbooking.CurrentRow.Cells(2).Value.ToString()
            cmbGender.Text = dgvbooking.CurrentRow.Cells(3).Value.ToString()
            txtContact.Text = dgvbooking.CurrentRow.Cells(4).Value.ToString()
            txtAdd.Text = dgvbooking.CurrentRow.Cells(5).Value.ToString()

        Catch ex As Exception
            MessageBox.Show("Error while selecting records on table...!" & ex.Message, "Select Record")
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        DBConnection()
        Dim dateti As Date
        Dim regno, IDno, gender, cont, add As String
        dateti = dtp.Value
        regno = txtRegno.Text
        IDno = txtID.Text
        gender = cmbGender.SelectedItem
        cont = txtContact.Text
        add = txtAdd.Text
        Try
            cmd.Connection = con
            cmd.CommandText = "UPDATE Booking SET Date='" & dateti & "',ID_No='" & IDno & "',Gender='" & gender & "',Contacts='" & cont & "',Address='" & add & "' WHERE Regno='" & regno & "'"
            cmd.ExecuteNonQuery()
            MessageBox.Show("Record is updated to the table", "Update Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error while updating record on table...!" & ex.Message, "Update Record")
        Finally
            con.Close()
        End Try
        txtRegno.Clear()
        txtID.Clear()
        cmbGender.SelectedIndex = 0
        txtContact.Clear()
        txtAdd.Clear()
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
                cmd.CommandText = "DELETE FROM Booking WHERE Regno='" & regno & "'"
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
        cmbGender.SelectedIndex = 0
        txtContact.Clear()
        txtAdd.Clear()
        txtRegno.Focus()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs)
        btnInsert.Enabled = True


    End Sub

    Private Sub cmbGender_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbGender.SelectedIndexChanged

    End Sub
End Class