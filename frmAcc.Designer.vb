<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmacc
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmacc))
        Me.lblfname = New System.Windows.Forms.Label()
        Me.lbllname = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblRoomno = New System.Windows.Forms.Label()
        Me.Category = New System.Windows.Forms.Label()
        Me.lblCharges = New System.Windows.Forms.Label()
        Me.lblRcptno = New System.Windows.Forms.Label()
        Me.lblPayment = New System.Windows.Forms.Label()
        Me.lblAmount = New System.Windows.Forms.Label()
        Me.lblNationality = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtFname = New System.Windows.Forms.TextBox()
        Me.txtLname = New System.Windows.Forms.TextBox()
        Me.txtRoomno = New System.Windows.Forms.TextBox()
        Me.txtPayment = New System.Windows.Forms.TextBox()
        Me.txtRcpt = New System.Windows.Forms.TextBox()
        Me.txtCharges = New System.Windows.Forms.TextBox()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.dgvAccommodation = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbroom = New System.Windows.Forms.ComboBox()
        Me.cmbNat = New System.Windows.Forms.ComboBox()
        CType(Me.dgvAccommodation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblfname
        '
        Me.lblfname.AutoSize = True
        Me.lblfname.BackColor = System.Drawing.Color.Transparent
        Me.lblfname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfname.Location = New System.Drawing.Point(15, 78)
        Me.lblfname.Name = "lblfname"
        Me.lblfname.Size = New System.Drawing.Size(67, 13)
        Me.lblfname.TabIndex = 0
        Me.lblfname.Text = "First Name"
        '
        'lbllname
        '
        Me.lbllname.AutoSize = True
        Me.lbllname.BackColor = System.Drawing.Color.Transparent
        Me.lbllname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllname.Location = New System.Drawing.Point(16, 118)
        Me.lbllname.Name = "lbllname"
        Me.lbllname.Size = New System.Drawing.Size(67, 13)
        Me.lbllname.TabIndex = 1
        Me.lbllname.Text = "Last Name"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.BackColor = System.Drawing.Color.Transparent
        Me.lblID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Location = New System.Drawing.Point(19, 37)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(67, 13)
        Me.lblID.TabIndex = 2
        Me.lblID.Text = "ID Number"
        '
        'lblRoomno
        '
        Me.lblRoomno.AutoSize = True
        Me.lblRoomno.BackColor = System.Drawing.Color.Transparent
        Me.lblRoomno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRoomno.Location = New System.Drawing.Point(15, 157)
        Me.lblRoomno.Name = "lblRoomno"
        Me.lblRoomno.Size = New System.Drawing.Size(59, 13)
        Me.lblRoomno.TabIndex = 3
        Me.lblRoomno.Text = "Room-No"
        '
        'Category
        '
        Me.Category.AutoSize = True
        Me.Category.BackColor = System.Drawing.Color.Transparent
        Me.Category.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Category.Location = New System.Drawing.Point(19, 196)
        Me.Category.Name = "Category"
        Me.Category.Size = New System.Drawing.Size(57, 13)
        Me.Category.TabIndex = 4
        Me.Category.Text = "Category"
        '
        'lblCharges
        '
        Me.lblCharges.AutoSize = True
        Me.lblCharges.BackColor = System.Drawing.Color.Transparent
        Me.lblCharges.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCharges.Location = New System.Drawing.Point(16, 245)
        Me.lblCharges.Name = "lblCharges"
        Me.lblCharges.Size = New System.Drawing.Size(53, 13)
        Me.lblCharges.TabIndex = 5
        Me.lblCharges.Text = "Charges"
        '
        'lblRcptno
        '
        Me.lblRcptno.AutoSize = True
        Me.lblRcptno.BackColor = System.Drawing.Color.Transparent
        Me.lblRcptno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRcptno.Location = New System.Drawing.Point(19, 286)
        Me.lblRcptno.Name = "lblRcptno"
        Me.lblRcptno.Size = New System.Drawing.Size(54, 13)
        Me.lblRcptno.TabIndex = 6
        Me.lblRcptno.Text = "Rcpt-No"
        '
        'lblPayment
        '
        Me.lblPayment.AutoSize = True
        Me.lblPayment.BackColor = System.Drawing.Color.Transparent
        Me.lblPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPayment.Location = New System.Drawing.Point(19, 328)
        Me.lblPayment.Name = "lblPayment"
        Me.lblPayment.Size = New System.Drawing.Size(55, 13)
        Me.lblPayment.TabIndex = 7
        Me.lblPayment.Text = "Payment"
        '
        'lblAmount
        '
        Me.lblAmount.AutoSize = True
        Me.lblAmount.BackColor = System.Drawing.Color.Transparent
        Me.lblAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmount.Location = New System.Drawing.Point(0, 371)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(100, 13)
        Me.lblAmount.TabIndex = 8
        Me.lblAmount.Text = "Amount Charged"
        '
        'lblNationality
        '
        Me.lblNationality.AutoSize = True
        Me.lblNationality.BackColor = System.Drawing.Color.Transparent
        Me.lblNationality.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNationality.Location = New System.Drawing.Point(19, 415)
        Me.lblNationality.Name = "lblNationality"
        Me.lblNationality.Size = New System.Drawing.Size(67, 13)
        Me.lblNationality.TabIndex = 9
        Me.lblNationality.Text = "Nationality"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.BackColor = System.Drawing.Color.Transparent
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(13, 465)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(87, 13)
        Me.lblTotal.TabIndex = 10
        Me.lblTotal.Text = "Total Charged"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(125, 37)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(116, 20)
        Me.txtID.TabIndex = 11
        '
        'txtFname
        '
        Me.txtFname.Location = New System.Drawing.Point(128, 78)
        Me.txtFname.Name = "txtFname"
        Me.txtFname.Size = New System.Drawing.Size(113, 20)
        Me.txtFname.TabIndex = 12
        '
        'txtLname
        '
        Me.txtLname.Location = New System.Drawing.Point(128, 118)
        Me.txtLname.Name = "txtLname"
        Me.txtLname.Size = New System.Drawing.Size(113, 20)
        Me.txtLname.TabIndex = 13
        '
        'txtRoomno
        '
        Me.txtRoomno.Location = New System.Drawing.Point(128, 157)
        Me.txtRoomno.Name = "txtRoomno"
        Me.txtRoomno.Size = New System.Drawing.Size(113, 20)
        Me.txtRoomno.TabIndex = 14
        '
        'txtPayment
        '
        Me.txtPayment.Location = New System.Drawing.Point(128, 328)
        Me.txtPayment.Name = "txtPayment"
        Me.txtPayment.Size = New System.Drawing.Size(113, 20)
        Me.txtPayment.TabIndex = 16
        '
        'txtRcpt
        '
        Me.txtRcpt.Location = New System.Drawing.Point(128, 286)
        Me.txtRcpt.Name = "txtRcpt"
        Me.txtRcpt.Size = New System.Drawing.Size(113, 20)
        Me.txtRcpt.TabIndex = 17
        '
        'txtCharges
        '
        Me.txtCharges.Location = New System.Drawing.Point(128, 238)
        Me.txtCharges.Name = "txtCharges"
        Me.txtCharges.Size = New System.Drawing.Size(113, 20)
        Me.txtCharges.TabIndex = 18
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(128, 371)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(113, 20)
        Me.txtAmount.TabIndex = 19
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(128, 462)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(113, 20)
        Me.txtTotal.TabIndex = 21
        '
        'btnInsert
        '
        Me.btnInsert.BackColor = System.Drawing.Color.Transparent
        Me.btnInsert.Enabled = False
        Me.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnInsert.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInsert.Location = New System.Drawing.Point(3, 548)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(100, 34)
        Me.btnInsert.TabIndex = 22
        Me.btnInsert.Text = "Insert"
        Me.btnInsert.UseVisualStyleBackColor = False
        '
        'btnDisplay
        '
        Me.btnDisplay.BackColor = System.Drawing.Color.Transparent
        Me.btnDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplay.Location = New System.Drawing.Point(128, 550)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(92, 32)
        Me.btnDisplay.TabIndex = 23
        Me.btnDisplay.Text = "Display"
        Me.btnDisplay.UseVisualStyleBackColor = False
        '
        'btnSelect
        '
        Me.btnSelect.BackColor = System.Drawing.Color.Transparent
        Me.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSelect.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelect.Location = New System.Drawing.Point(245, 550)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(92, 32)
        Me.btnSelect.TabIndex = 24
        Me.btnSelect.Text = "Select"
        Me.btnSelect.UseVisualStyleBackColor = False
        '
        'btnupdate
        '
        Me.btnupdate.BackColor = System.Drawing.Color.Transparent
        Me.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnupdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdate.Location = New System.Drawing.Point(361, 550)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(92, 32)
        Me.btnupdate.TabIndex = 25
        Me.btnupdate.Text = "Update"
        Me.btnupdate.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Transparent
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(480, 550)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(92, 32)
        Me.btnDelete.TabIndex = 26
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'dgvAccommodation
        '
        Me.dgvAccommodation.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvAccommodation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvAccommodation.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.dgvAccommodation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAccommodation.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgvAccommodation.Location = New System.Drawing.Point(299, 12)
        Me.dgvAccommodation.Name = "dgvAccommodation"
        Me.dgvAccommodation.Size = New System.Drawing.Size(789, 532)
        Me.dgvAccommodation.TabIndex = 27
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(105, 465)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 16)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "$"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(106, 371)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 16)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "$"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(106, 331)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(16, 16)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "$"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(105, 241)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(16, 16)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "$"
        '
        'cmbroom
        '
        Me.cmbroom.FormattingEnabled = True
        Me.cmbroom.Items.AddRange(New Object() {"", "SINGLE ", "DOUBLE ", "TRIPLE", "TWIN", "MINI SUITE", "MASTER SUITE"})
        Me.cmbroom.Location = New System.Drawing.Point(120, 193)
        Me.cmbroom.Name = "cmbroom"
        Me.cmbroom.Size = New System.Drawing.Size(121, 21)
        Me.cmbroom.TabIndex = 32
        '
        'cmbNat
        '
        Me.cmbNat.FormattingEnabled = True
        Me.cmbNat.Items.AddRange(New Object() {"", "LOCAL", "FOREIGN"})
        Me.cmbNat.Location = New System.Drawing.Point(120, 415)
        Me.cmbNat.Name = "cmbNat"
        Me.cmbNat.Size = New System.Drawing.Size(121, 21)
        Me.cmbNat.TabIndex = 33
        '
        'frmacc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1100, 598)
        Me.Controls.Add(Me.cmbNat)
        Me.Controls.Add(Me.cmbroom)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvAccommodation)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.txtCharges)
        Me.Controls.Add(Me.txtRcpt)
        Me.Controls.Add(Me.txtPayment)
        Me.Controls.Add(Me.txtRoomno)
        Me.Controls.Add(Me.txtLname)
        Me.Controls.Add(Me.txtFname)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblNationality)
        Me.Controls.Add(Me.lblAmount)
        Me.Controls.Add(Me.lblPayment)
        Me.Controls.Add(Me.lblRcptno)
        Me.Controls.Add(Me.lblCharges)
        Me.Controls.Add(Me.Category)
        Me.Controls.Add(Me.lblRoomno)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.lbllname)
        Me.Controls.Add(Me.lblfname)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "frmacc"
        Me.Text = "Accommodation"
        Me.TransparencyKey = System.Drawing.Color.Transparent
        CType(Me.dgvAccommodation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblfname As System.Windows.Forms.Label
    Friend WithEvents lbllname As System.Windows.Forms.Label
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents lblRoomno As System.Windows.Forms.Label
    Friend WithEvents Category As System.Windows.Forms.Label
    Friend WithEvents lblCharges As System.Windows.Forms.Label
    Friend WithEvents lblRcptno As System.Windows.Forms.Label
    Friend WithEvents lblPayment As System.Windows.Forms.Label
    Friend WithEvents lblAmount As System.Windows.Forms.Label
    Friend WithEvents lblNationality As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents txtFname As System.Windows.Forms.TextBox
    Friend WithEvents txtLname As System.Windows.Forms.TextBox
    Friend WithEvents txtRoomno As System.Windows.Forms.TextBox
    Friend WithEvents txtPayment As System.Windows.Forms.TextBox
    Friend WithEvents txtRcpt As System.Windows.Forms.TextBox
    Friend WithEvents txtCharges As System.Windows.Forms.TextBox
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents btnInsert As System.Windows.Forms.Button
    Friend WithEvents btnDisplay As System.Windows.Forms.Button
    Friend WithEvents btnSelect As System.Windows.Forms.Button
    Friend WithEvents btnupdate As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents dgvAccommodation As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbroom As System.Windows.Forms.ComboBox
    Friend WithEvents cmbNat As System.Windows.Forms.ComboBox

End Class
