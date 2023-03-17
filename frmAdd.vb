Imports System.Data
Imports System.Data.SqlClient
Public Class Admission
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand

    Private Sub DBConnection()
        con.ConnectionString = "Data Source=LAPTOP-NUCQR7HS\SQLEXPRESS;Initial Catalog=HotelMG Database; Integrated Security=True"
        con.Open()
    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        DBConnection()
        Dim datein, dateout As Date
        Dim regno, room As String
        datein = dtpIn.Value
        dateout = dtpOut.Value
        regno = txtRegno.Text
        room = txtRoomno.Text

        Try
            cmd.Connection = con
            cmd.CommandText = "INSERT INTO Admission VALUES ('" & room & "','" & regno & "','" & datein & "','" & dateout & "')"
            cmd.ExecuteNonQuery()
            MessageBox.Show("Record is inserted to the Table", "Insert Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error while inserting record into table...!" & ex.Message, "Insert Record")
        Finally
            con.Close()
        End Try
        txtRegno.Clear()
        txtRoomno.Clear()
        txtRoomno.Focus()
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        DBConnection()
        Try
            Dim query As String = "SELECT *FROM Admission"
            Dim da As SqlDataAdapter = New SqlDataAdapter(query, con)
            Dim ds As DataSet = New DataSet
            da.Fill(ds, "Admission")
            dgvadd.DataSource = ds.Tables("Admission")
        Catch ex As Exception
            MessageBox.Show("Error while selecting a table...!" & ex.Message, "Select all records")
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        Try
            txtRoomno.Text = dgvadd.CurrentRow.Cells(0).Value.ToString()
            txtRegno.Text = dgvadd.CurrentRow.Cells(1).Value.ToString()
            dtpIn.Value = dgvadd.CurrentRow.Cells(2).Value.ToString()
            dtpOut.Value = dgvadd.CurrentRow.Cells(3).Value.ToString()          

        Catch ex As Exception
            MessageBox.Show("Error while selecting records on table...!" & ex.Message, "Select Record")
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        DBConnection()
        Dim datein, dateout As Date
        Dim regno, room As String
        datein = dtpIn.Value
        dateout = dtpOut.Value
        regno = txtRegno.Text
        room = txtRoomno.Text
        Try
            cmd.Connection = con
            cmd.CommandText = "UPDATE Admission SET Regno='" & regno & "',Indate='" & datein & "',Outdate='" & dateout & "' WHERE Roomno='" & room & "'"
            cmd.ExecuteNonQuery()
            MessageBox.Show("Record is updated to the table", "Update Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error while updating record on table...!" & ex.Message, "Update Record")
        Finally
            con.Close()
        End Try
        txtRegno.Clear()
        txtRoomno.Clear()
        txtRoomno.Focus()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        DBConnection()
        Dim room As String
        room = txtRoomno.Text
        Try
            cmd.Connection = con
            If MessageBox.Show("Do you really want to delete this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.No Then
                MessageBox.Show("Operation Cancelled...!", "Delete Record")
            Else
                cmd.CommandText = "DELETE FROM Admission WHERE Roomno='" & room & "'"
                cmd.ExecuteNonQuery()
                MessageBox.Show("Record is deleted from table", "Delete Record")
            End If
        Catch ex As Exception
            MessageBox.Show("Error while deleting record on table...!" & ex.Message, "Delete Record")
        Finally
            con.Close()
        End Try
        txtRegno.Clear()
        txtRoomno.Clear()
        txtRoomno.Focus()
    End Sub
End Class