Imports System.Data
Imports System.Data.SqlClient
Public Class frmacc
    Dim con As New SqlConnection        'designed for connecting to Microsoft SQL Server.
    Dim cmd As New SqlCommand           'A command is a SQL statement or a stored procedure used to retrieve, insert, delete or modify data in a data source.

    Private Sub DBConnection()
        con.ConnectionString = "Data Source=LAPTOP-NUCQR7HS\SQLEXPRESS;Initial Catalog=HotelMG Database; Integrated Security=True"
        con.Open()
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles lblNationality.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblfname.Click

    End Sub

    Private Sub frmacc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles txtRoomno.TextChanged

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtFname.TextChanged

    End Sub

    Private Sub lblID_Click(sender As Object, e As EventArgs) Handles lblID.Click

    End Sub

    Private Sub lbllname_Click(sender As Object, e As EventArgs) Handles lbllname.Click

    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles txtCharges.TextChanged

    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        DBConnection()
        Dim IDno, fname, lname, room, category, charges, rcpt, payment, amount, nationality, total As String
        IDno = txtID.Text
        fname = txtFname.Text
        lname = txtLname.Text
        room = txtRoomno.Text
        category = cmbroom.SelectedItem
        charges = txtCharges.Text
        rcpt = txtRcpt.Text
        payment = txtPayment.Text
        amount = txtAmount.Text
        nationality = cmbNat.SelectedItem
        total = txtTotal.Text

        Try
            cmd.Connection = con
            cmd.CommandText = "INSERT INTO Accommodation VALUES ('" & IDno & "','" & fname & "','" & lname & "','" & room & "','" & category & "','" & charges & "','" & rcpt & "','" & payment & "','" & amount & "','" & nationality & "','" & total & "')"
            cmd.ExecuteNonQuery()
            MessageBox.Show("Record is inserted to the Table", "Insert Record",MessageBoxButtons.OK,MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error while inserting record into table...!" & ex.Message, "Insert Record")
        Finally
            con.Close()
        End Try
        txtID.Clear()
        txtFname.Clear()
        txtLname.Clear()
        txtRoomno.Clear()
        cmbroom.SelectedIndex = 0
        txtCharges.Clear()
        txtRcpt.Clear()
        txtPayment.Clear()
        txtAmount.Clear()
        cmbNat.SelectedIndex = 0
        txtTotal.Clear()
        txtID.Focus()
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        DBConnection()
        Try
            Dim query As String = "SELECT *FROM Accommodation"
            Dim da As SqlDataAdapter = New SqlDataAdapter(query, con)

            'This is integral to the working of ADO.Net since data is transferred to and from a database through a data adapter.
            'It retrieves data from a database into a dataset And updates the database. 
            'When changes are made To the dataset, the changes in the database are actually done by the data adapter.

            Dim ds As DataSet = New DataSet ' store data in a disconnected cache and the application retrieves data from it.
            da.Fill(ds, "Accommodation")
            dgvAccommodation.DataSource = ds.Tables("Accommodation")
        Catch ex As Exception
            MessageBox.Show("Error while selecting a table...!" & ex.Message, "Select all records")
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        Try
            txtID.Text = dgvAccommodation.CurrentRow.Cells(0).Value.ToString()
            txtFname.Text = dgvAccommodation.CurrentRow.Cells(1).Value.ToString()
            txtLname.Text = dgvAccommodation.CurrentRow.Cells(2).Value.ToString()
            txtRoomno.Text = dgvAccommodation.CurrentRow.Cells(3).Value.ToString()
            cmbroom.Text = dgvAccommodation.CurrentRow.Cells(4).Value.ToString()
            txtCharges.Text = dgvAccommodation.CurrentRow.Cells(5).Value.ToString()
            txtRcpt.Text = dgvAccommodation.CurrentRow.Cells(6).Value.ToString()
            txtPayment.Text = dgvAccommodation.CurrentRow.Cells(7).Value.ToString()
            txtAmount.Text = dgvAccommodation.CurrentRow.Cells(8).Value.ToString()
            cmbNat.Text = dgvAccommodation.CurrentRow.Cells(9).Value.ToString()
            txtTotal.Text = dgvAccommodation.CurrentRow.Cells(10).Value.ToString()

        Catch ex As Exception
            MessageBox.Show("Error while selecting records on table...!" & ex.Message, "Select Record")
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        DBConnection()
        Dim IDno As String
        IDno = txtID.Text
        Try
            cmd.Connection = con
            If MessageBox.Show("Do you really want to delete this record?", "Delete Record", MessageBoxButtons.YesNo,MessageBoxIcon.Warning) =Windows.Forms.DialogResult.No Then
                MessageBox.Show("Operation Cancelled...!", "Delete Record")
            Else
                cmd.CommandText = "DELETE FROM Accommodation WHERE ID_No='" & IDno & "'"
                cmd.ExecuteNonQuery()
                MessageBox.Show("Record is deleted from table", "Delete Record")
            End If
        Catch ex As Exception
            MessageBox.Show("Error while deleting record on table...!" & ex.Message,"Delete Record")
        Finally
            con.Close()
        End Try
        txtID.Clear()
        txtFname.Clear()
        txtLname.Clear()
        txtRoomno.Clear()
        cmbroom.SelectedIndex = 0
        txtCharges.Clear()
        txtRcpt.Clear()
        txtPayment.Clear()
        txtAmount.Clear()
        cmbNat.SelectedIndex = 0
        txtTotal.Clear()
        txtID.Focus()
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        DBConnection()
        Dim IDno, fname, lname, room, category, charges, rcpt, payment, amount, nationality, total As String
        IDno = txtID.Text
        fname = txtFname.Text
        lname = txtLname.Text
        room = txtRoomno.Text
        category = cmbroom.SelectedItem
        charges = txtCharges.Text
        rcpt = txtRcpt.Text
        payment = txtPayment.Text
        amount = txtAmount.Text
        nationality = cmbNat.SelectedItem
        total = txtTotal.Text
        Try
            cmd.Connection = con
            cmd.CommandText = "UPDATE Accommodation SET Fname='" & fname & "',Lname='" & lname & "',Roomno='" & room & "',Category='" & category & "',Charges='" & charges & "',Rcptno='" & rcpt & "',Payment='" & payment & "',Amountcharged='" & amount & "',Nationality='" & nationality & "',Totalcharged='" & total & "' WHERE ID_No='" & IDno & "'"
            cmd.ExecuteNonQuery()
            MessageBox.Show("Record is updated to the table", "Update Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error whileupdating record on table...!" & ex.Message, "Update Record")
        Finally
            con.Close()
        End Try
        txtID.Clear()
        txtFname.Clear()
        txtLname.Clear()
        txtRoomno.Clear()
        cmbroom.SelectedIndex = 0
        txtCharges.Clear()
        txtRcpt.Clear()
        txtPayment.Clear()
        txtAmount.Clear()
        cmbNat.SelectedIndex = 0
        txtTotal.Clear()
        txtID.Focus()
    End Sub

    Private Sub dgvAccommodation_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAccommodation.CellContentClick

    End Sub














    Private Sub lblTotal_Click(sender As Object, e As EventArgs) Handles lblTotal.Click

    End Sub
    Private Sub lblAmount_Click(sender As Object, e As EventArgs) Handles lblAmount.Click

    End Sub
    Private Sub lblPayment_Click(sender As Object, e As EventArgs) Handles lblPayment.Click

    End Sub
    Private Sub lblRcptno_Click(sender As Object, e As EventArgs) Handles lblRcptno.Click

    End Sub
    Private Sub lblCharges_Click(sender As Object, e As EventArgs) Handles lblCharges.Click

    End Sub
    Private Sub Category_Click(sender As Object, e As EventArgs) Handles Category.Click

    End Sub
    Private Sub lblRoomno_Click(sender As Object, e As EventArgs) Handles lblRoomno.Click

    End Sub








    Private Sub txtTotal_TextChanged(sender As Object, e As EventArgs) Handles txtTotal.TextChanged
        btnInsert.Enabled = True
    End Sub
End Class
