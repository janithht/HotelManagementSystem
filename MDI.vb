Public Class frmMDI




    Private Sub AccommodationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AccommodationToolStripMenuItem.Click
        Dim frm As New frmacc
        frm.MdiParent = Me
        frm.Dock = DockStyle.Fill
        frm.Show()
    End Sub

    Private Sub AdmissionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdmissionToolStripMenuItem.Click
        Dim frm As New Admission
        frm.MdiParent = Me
        frm.Dock = DockStyle.Top
        frm.Show()
    End Sub

    Private Sub BookingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BookingToolStripMenuItem.Click
        Dim frm As New frmbook
        frm.MdiParent = Me
        frm.Dock = DockStyle.Top
        frm.Show()
    End Sub

    Private Sub ConferenceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConferenceToolStripMenuItem.Click
        Dim frm As New frmcon
        frm.MdiParent = Me
        frm.Dock = DockStyle.Fill
        frm.Show()
    End Sub

    Private Sub MealsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MealsToolStripMenuItem.Click
        Dim frm As New frmmeal
        frm.MdiParent = Me
        frm.Dock = DockStyle.None
        frm.Show()
    End Sub

    Private Sub SportingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SportingToolStripMenuItem.Click
        Dim frm As New frmsport
        frm.MdiParent = Me
        frm.Dock = DockStyle.None
        frm.Show()
    End Sub

    Private Sub SwimmingPoolToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SwimmingPoolToolStripMenuItem.Click
        Dim frm As New frmswimming
        frm.MdiParent = Me
        frm.Dock = DockStyle.None
        frm.Show()
    End Sub

    Private Sub EmployeeDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmployeeDetailsToolStripMenuItem.Click
        Dim frm As New frmemployee
        frm.MdiParent = Me
        frm.Dock = DockStyle.Top
        frm.Show()
    End Sub

    
    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        Me.Close()
    End Sub

    Private Sub frmMDI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
       


    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click

    End Sub

    Private Sub BookingToolStripMenuItem1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub AccommodationToolStripMenuItem1_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub AdmissionToolStripMenuItem1_Click(sender As Object, e As EventArgs)

    End Sub
End Class