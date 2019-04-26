<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_makeorder_a172316
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_makeorder_a172316))
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btn_vieworder = New System.Windows.Forms.Button()
        Me.dud_quantity = New System.Windows.Forms.NumericUpDown()
        Me.lbl_datetit = New System.Windows.Forms.Label()
        Me.pic_product = New System.Windows.Forms.PictureBox()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btn_confirm = New System.Windows.Forms.Button()
        Me.lbl_staff = New System.Windows.Forms.Label()
        Me.lbl_customer = New System.Windows.Forms.Label()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.grd_order = New System.Windows.Forms.DataGridView()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.lbl_ordid = New System.Windows.Forms.Label()
        Me.lbl_idtit = New System.Windows.Forms.Label()
        Me.cmb_cust = New System.Windows.Forms.ComboBox()
        Me.cmb_staff = New System.Windows.Forms.ComboBox()
        Me.grd_products = New System.Windows.Forms.DataGridView()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.lbl_total = New System.Windows.Forms.Label()
        CType(Me.dud_quantity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd_order, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd_products, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.Location = New System.Drawing.Point(261, 256)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(87, 33)
        Me.btn_delete.TabIndex = 50
        Me.btn_delete.Text = "DELETE"
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label9.Location = New System.Drawing.Point(44, 791)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(332, 17)
        Me.Label9.TabIndex = 49
        Me.Label9.Text = "Tel: 03 4050 4903   Email: leesportsrim@gmail.com"
        '
        'btn_vieworder
        '
        Me.btn_vieworder.BackColor = System.Drawing.Color.Yellow
        Me.btn_vieworder.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_vieworder.Location = New System.Drawing.Point(603, 399)
        Me.btn_vieworder.Name = "btn_vieworder"
        Me.btn_vieworder.Size = New System.Drawing.Size(105, 51)
        Me.btn_vieworder.TabIndex = 46
        Me.btn_vieworder.Text = "VIEW ORDER"
        Me.btn_vieworder.UseVisualStyleBackColor = False
        '
        'dud_quantity
        '
        Me.dud_quantity.Location = New System.Drawing.Point(49, 262)
        Me.dud_quantity.Name = "dud_quantity"
        Me.dud_quantity.Size = New System.Drawing.Size(120, 22)
        Me.dud_quantity.TabIndex = 45
        Me.dud_quantity.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lbl_datetit
        '
        Me.lbl_datetit.AutoSize = True
        Me.lbl_datetit.BackColor = System.Drawing.Color.Transparent
        Me.lbl_datetit.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_datetit.ForeColor = System.Drawing.Color.Black
        Me.lbl_datetit.Location = New System.Drawing.Point(603, 66)
        Me.lbl_datetit.Name = "lbl_datetit"
        Me.lbl_datetit.Size = New System.Drawing.Size(70, 17)
        Me.lbl_datetit.TabIndex = 44
        Me.lbl_datetit.Text = "Date       :"
        '
        'pic_product
        '
        Me.pic_product.BackColor = System.Drawing.Color.Transparent
        Me.pic_product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pic_product.Location = New System.Drawing.Point(606, 99)
        Me.pic_product.Name = "pic_product"
        Me.pic_product.Size = New System.Drawing.Size(187, 224)
        Me.pic_product.TabIndex = 43
        Me.pic_product.TabStop = False
        '
        'btn_back
        '
        Me.btn_back.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_back.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.Location = New System.Drawing.Point(714, 399)
        Me.btn_back.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(79, 51)
        Me.btn_back.TabIndex = 42
        Me.btn_back.Text = "BACK"
        Me.btn_back.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label8.Location = New System.Drawing.Point(781, 706)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 17)
        Me.Label8.TabIndex = 41
        Me.Label8.Text = "Total"
        '
        'btn_confirm
        '
        Me.btn_confirm.BackColor = System.Drawing.Color.Lime
        Me.btn_confirm.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_confirm.Location = New System.Drawing.Point(603, 339)
        Me.btn_confirm.Name = "btn_confirm"
        Me.btn_confirm.Size = New System.Drawing.Size(190, 43)
        Me.btn_confirm.TabIndex = 40
        Me.btn_confirm.Text = "CONFIRM ORDER"
        Me.btn_confirm.UseVisualStyleBackColor = False
        '
        'lbl_staff
        '
        Me.lbl_staff.AutoSize = True
        Me.lbl_staff.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_staff.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_staff.ForeColor = System.Drawing.Color.Black
        Me.lbl_staff.Location = New System.Drawing.Point(345, 62)
        Me.lbl_staff.Name = "lbl_staff"
        Me.lbl_staff.Size = New System.Drawing.Size(54, 17)
        Me.lbl_staff.TabIndex = 39
        Me.lbl_staff.Text = "Staff ID"
        '
        'lbl_customer
        '
        Me.lbl_customer.AutoSize = True
        Me.lbl_customer.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_customer.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_customer.ForeColor = System.Drawing.Color.Black
        Me.lbl_customer.Location = New System.Drawing.Point(46, 62)
        Me.lbl_customer.Name = "lbl_customer"
        Me.lbl_customer.Size = New System.Drawing.Size(78, 17)
        Me.lbl_customer.TabIndex = 38
        Me.lbl_customer.Text = "Cutomer ID"
        '
        'txt_total
        '
        Me.txt_total.Location = New System.Drawing.Point(476, 263)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.Size = New System.Drawing.Size(100, 22)
        Me.txt_total.TabIndex = 37
        '
        'grd_order
        '
        Me.grd_order.AllowUserToAddRows = False
        Me.grd_order.AllowUserToDeleteRows = False
        Me.grd_order.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.grd_order.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.grd_order.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.grd_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_order.Location = New System.Drawing.Point(49, 300)
        Me.grd_order.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grd_order.Name = "grd_order"
        Me.grd_order.ReadOnly = True
        Me.grd_order.RowTemplate.Height = 28
        Me.grd_order.Size = New System.Drawing.Size(527, 150)
        Me.grd_order.TabIndex = 36
        '
        'btn_add
        '
        Me.btn_add.BackColor = System.Drawing.Color.Lime
        Me.btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_add.Location = New System.Drawing.Point(184, 256)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(71, 33)
        Me.btn_add.TabIndex = 35
        Me.btn_add.Text = "ADD"
        Me.btn_add.UseVisualStyleBackColor = False
        '
        'lbl_date
        '
        Me.lbl_date.AutoSize = True
        Me.lbl_date.BackColor = System.Drawing.Color.Transparent
        Me.lbl_date.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_date.ForeColor = System.Drawing.Color.Black
        Me.lbl_date.Location = New System.Drawing.Point(690, 66)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(38, 17)
        Me.lbl_date.TabIndex = 34
        Me.lbl_date.Text = "Date"
        '
        'lbl_ordid
        '
        Me.lbl_ordid.AutoSize = True
        Me.lbl_ordid.BackColor = System.Drawing.Color.Transparent
        Me.lbl_ordid.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ordid.ForeColor = System.Drawing.Color.Black
        Me.lbl_ordid.Location = New System.Drawing.Point(690, 42)
        Me.lbl_ordid.Name = "lbl_ordid"
        Me.lbl_ordid.Size = New System.Drawing.Size(55, 17)
        Me.lbl_ordid.TabIndex = 33
        Me.lbl_ordid.Text = "orderID"
        '
        'lbl_idtit
        '
        Me.lbl_idtit.AutoSize = True
        Me.lbl_idtit.BackColor = System.Drawing.Color.Transparent
        Me.lbl_idtit.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_idtit.ForeColor = System.Drawing.Color.Black
        Me.lbl_idtit.Location = New System.Drawing.Point(603, 42)
        Me.lbl_idtit.Name = "lbl_idtit"
        Me.lbl_idtit.Size = New System.Drawing.Size(74, 17)
        Me.lbl_idtit.TabIndex = 32
        Me.lbl_idtit.Text = "Order ID : "
        '
        'cmb_cust
        '
        Me.cmb_cust.FormattingEnabled = True
        Me.cmb_cust.Location = New System.Drawing.Point(145, 59)
        Me.cmb_cust.Name = "cmb_cust"
        Me.cmb_cust.Size = New System.Drawing.Size(147, 24)
        Me.cmb_cust.TabIndex = 31
        '
        'cmb_staff
        '
        Me.cmb_staff.FormattingEnabled = True
        Me.cmb_staff.Location = New System.Drawing.Point(429, 59)
        Me.cmb_staff.Name = "cmb_staff"
        Me.cmb_staff.Size = New System.Drawing.Size(147, 24)
        Me.cmb_staff.TabIndex = 30
        '
        'grd_products
        '
        Me.grd_products.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.grd_products.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.grd_products.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.grd_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_products.Location = New System.Drawing.Point(49, 99)
        Me.grd_products.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grd_products.Name = "grd_products"
        Me.grd_products.ReadOnly = True
        Me.grd_products.RowTemplate.Height = 28
        Me.grd_products.Size = New System.Drawing.Size(527, 149)
        Me.grd_products.TabIndex = 29
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.BackColor = System.Drawing.Color.Transparent
        Me.lbl_title.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.ForeColor = System.Drawing.Color.Black
        Me.lbl_title.Location = New System.Drawing.Point(255, 9)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(323, 32)
        Me.lbl_title.TabIndex = 27
        Me.lbl_title.Text = "ORDER TRANSACTION"
        Me.lbl_title.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.Location = New System.Drawing.Point(381, 264)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(89, 17)
        Me.lbl_total.TabIndex = 51
        Me.lbl_total.Text = "TOTAL (RM)"
        '
        'frm_makeorder_a172316
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(852, 478)
        Me.Controls.Add(Me.lbl_total)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btn_vieworder)
        Me.Controls.Add(Me.dud_quantity)
        Me.Controls.Add(Me.lbl_datetit)
        Me.Controls.Add(Me.pic_product)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btn_confirm)
        Me.Controls.Add(Me.lbl_staff)
        Me.Controls.Add(Me.lbl_customer)
        Me.Controls.Add(Me.txt_total)
        Me.Controls.Add(Me.grd_order)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.lbl_date)
        Me.Controls.Add(Me.lbl_ordid)
        Me.Controls.Add(Me.lbl_idtit)
        Me.Controls.Add(Me.cmb_cust)
        Me.Controls.Add(Me.cmb_staff)
        Me.Controls.Add(Me.grd_products)
        Me.Controls.Add(Me.lbl_title)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_makeorder_a172316"
        Me.Text = "Make Order"
        CType(Me.dud_quantity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd_order, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd_products, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_delete As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents btn_vieworder As Button
    Friend WithEvents dud_quantity As NumericUpDown
    Friend WithEvents lbl_datetit As Label
    Friend WithEvents pic_product As PictureBox
    Friend WithEvents btn_back As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents btn_confirm As Button
    Friend WithEvents lbl_staff As Label
    Friend WithEvents lbl_customer As Label
    Friend WithEvents txt_total As TextBox
    Friend WithEvents grd_order As DataGridView
    Friend WithEvents btn_add As Button
    Friend WithEvents lbl_date As Label
    Friend WithEvents lbl_ordid As Label
    Friend WithEvents lbl_idtit As Label
    Friend WithEvents cmb_cust As ComboBox
    Friend WithEvents cmb_staff As ComboBox
    Friend WithEvents grd_products As DataGridView
    Friend WithEvents lbl_title As Label
    Friend WithEvents lbl_total As Label
End Class
