Imports System.Data
Imports System.Data.SqlClient
Public Class frmemployee
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand

    Private Sub DBConnection()
        con.ConnectionString = "Data Source=LAPTOP-NUCQR7HS\SQLEXPRESS;Initial Catalog=HotelMG Database; Integrated Security=True"
        con.Open()
    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        DBConnection()
        Dim IDno, sno, sname, cont, add, email, dep, accno, salary As String
        IDno = txtID.Text
        sno = txtno.Text
        sname = txtName.Text
        cont = txtCon.Text
        add = txtAdd.Text
        email = txtEma.Text
        dep = cmbdep.SelectedItem
        accno = txtAcc.Text
        salary = txtSal.Text

        Try
            cmd.Connection = con
            cmd.CommandText = "INSERT INTO Employee VALUES ('" & IDno & "','" & sno & "','" & sname & "','" & cont & "','" & add & "','" & email & "','" & dep & "','" & accno & "','" & salary & "')"
            cmd.ExecuteNonQuery()
            MessageBox.Show("Record is inserted to the Table", "Insert Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error while inserting record into table...!" & ex.Message, "Insert Record")
        Finally
            con.Close()
        End Try
        txtno.Clear()
        txtID.Clear()
        cmbdep.SelectedIndex = 0
        txtName.Clear()
        txtAdd.Clear()
        txtEma.Clear()
        txtCon.Clear()
        txtAcc.Clear()
        txtSal.Clear()
        txtID.Focus()
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        DBConnection()
        Try
            Dim query As String = "SELECT *FROM Employee"
            Dim da As SqlDataAdapter = New SqlDataAdapter(query, con)
            Dim ds As DataSet = New DataSet
            da.Fill(ds, "Employee")
            dgv.DataSource = ds.Tables("Employee")
        Catch ex As Exception
            MessageBox.Show("Error while selecting a table...!" & ex.Message, "Select all records")
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        Try
            txtID.Text = dgv.CurrentRow.Cells(0).Value.ToString()
            txtno.Text = dgv.CurrentRow.Cells(1).Value.ToString()
            txtName.Text = dgv.CurrentRow.Cells(2).Value.ToString()
            txtCon.Text = dgv.CurrentRow.Cells(3).Value.ToString()
            txtAdd.Text = dgv.CurrentRow.Cells(4).Value.ToString()
            txtEma.Text = dgv.CurrentRow.Cells(5).Value.ToString()
            cmbdep.Text = dgv.CurrentRow.Cells(6).Value.ToString()
            txtAcc.Text = dgv.CurrentRow.Cells(7).Value.ToString()
            txtSal.Text = dgv.CurrentRow.Cells(8).Value.ToString()           

        Catch ex As Exception
            MessageBox.Show("Error while selecting records on table...!" & ex.Message, "Select Record")
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        DBConnection()
        Dim IDno, sno, sname, cont, add, email, dep, accno, salary As String
        IDno = txtID.Text
        sno = txtno.Text
        sname = txtName.Text
        cont = txtCon.Text
        add = txtAdd.Text
        email = txtEma.Text
        dep = cmbdep.SelectedItem
        accno = txtAcc.Text
        salary = txtSal.Text
        Try
            cmd.Connection = con
            cmd.CommandText = "UPDATE Employee SET Staffno='" & sno & "',Staffname='" & sname & "',Contacts='" & cont & "',Address='" & add & "',Email='" & email & "',Department='" & dep & "',Accountno='" & accno & "',Salary='" & salary & "' WHERE IDno='" & IDno & "'"
            cmd.ExecuteNonQuery()
            MessageBox.Show("Record is updated to the table", "Update Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error whileupdating record on table...!" & ex.Message, "Update Record")
        Finally
            con.Close()
        End Try
        txtno.Clear()
        txtID.Clear()
        cmbdep.SelectedIndex = 0
        txtName.Clear()
        txtAdd.Clear()
        txtEma.Clear()
        txtCon.Clear()
        txtAcc.Clear()
        txtSal.Clear()
        txtID.Focus()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        DBConnection()
        Dim IDno As String
        IDno = txtID.Text
        Try
            cmd.Connection = con
            If MessageBox.Show("Do you really want to delete this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.No Then
                MessageBox.Show("Operation Cancelled...!", "Delete Record")
            Else
                cmd.CommandText = "DELETE FROM Employee WHERE IDno='" & IDno & "'"
                cmd.ExecuteNonQuery()
                MessageBox.Show("Record is deleted from table", "Delete Record")
            End If
        Catch ex As Exception
            MessageBox.Show("Error while deleting record on table...!" & ex.Message, "Delete Record")
        Finally
            con.Close()
        End Try
        txtno.Clear()
        txtID.Clear()
        cmbdep.SelectedIndex = 0
        txtName.Clear()
        txtAdd.Clear()
        txtEma.Clear()
        txtCon.Clear()
        txtAcc.Clear()
        txtSal.Clear()
        txtID.Focus()
    End Sub
End Class