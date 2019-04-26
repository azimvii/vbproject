<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_vieworder_a172316
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_vieworder_a172316))
        Me.lbl_contact = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.lbl_staffid = New System.Windows.Forms.Label()
        Me.lbl_custid = New System.Windows.Forms.Label()
        Me.txt_staffid = New System.Windows.Forms.TextBox()
        Me.txt_custid = New System.Windows.Forms.TextBox()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.lbl_orderid = New System.Windows.Forms.Label()
        Me.cmb_orderid = New System.Windows.Forms.ComboBox()
        Me.grd_order = New System.Windows.Forms.DataGridView()
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.lbl_datetit = New System.Windows.Forms.Label()
        CType(Me.grd_order, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_contact
        '
        Me.lbl_contact.AutoSize = True
        Me.lbl_contact.BackColor = System.Drawing.Color.Transparent
        Me.lbl_contact.Font = New System.Drawing.Font("Lucida Sans Unicode", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_contact.ForeColor = System.Drawing.Color.Black
        Me.lbl_contact.Location = New System.Drawing.Point(12, 452)
        Me.lbl_contact.Name = "lbl_contact"
        Me.lbl_contact.Size = New System.Drawing.Size(364, 17)
        Me.lbl_contact.TabIndex = 45
        Me.lbl_contact.Text = "Tel: 03 7780 6541   Email: techbagshop@gmail.com"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift Condensed", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(380, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 36)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "INVOICE"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Lucida Handwriting", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(312, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(222, 19)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "43650 Bandar Baru Bangi"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Lucida Handwriting", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(294, 49)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(256, 19)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "Lot 13, Jalan 15 , Seksyen 15/2E"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.BackColor = System.Drawing.Color.Transparent
        Me.lbl_title.Font = New System.Drawing.Font("Lucida Handwriting", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.ForeColor = System.Drawing.Color.Black
        Me.lbl_title.Location = New System.Drawing.Point(292, 13)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(258, 36)
        Me.lbl_title.TabIndex = 41
        Me.lbl_title.Text = "TECH BAG SHOP"
        Me.lbl_title.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbl_staffid
        '
        Me.lbl_staffid.AutoSize = True
        Me.lbl_staffid.BackColor = System.Drawing.Color.Transparent
        Me.lbl_staffid.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_staffid.ForeColor = System.Drawing.Color.Black
        Me.lbl_staffid.Location = New System.Drawing.Point(111, 171)
        Me.lbl_staffid.Name = "lbl_staffid"
        Me.lbl_staffid.Size = New System.Drawing.Size(72, 19)
        Me.lbl_staffid.TabIndex = 40
        Me.lbl_staffid.Text = "Issued by"
        '
        'lbl_custid
        '
        Me.lbl_custid.AutoSize = True
        Me.lbl_custid.BackColor = System.Drawing.Color.Transparent
        Me.lbl_custid.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_custid.ForeColor = System.Drawing.Color.Black
        Me.lbl_custid.Location = New System.Drawing.Point(111, 138)
        Me.lbl_custid.Name = "lbl_custid"
        Me.lbl_custid.Size = New System.Drawing.Size(91, 19)
        Me.lbl_custid.TabIndex = 39
        Me.lbl_custid.Text = "Customer ID"
        '
        'txt_staffid
        '
        Me.txt_staffid.Location = New System.Drawing.Point(268, 171)
        Me.txt_staffid.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_staffid.Name = "txt_staffid"
        Me.txt_staffid.ReadOnly = True
        Me.txt_staffid.Size = New System.Drawing.Size(70, 22)
        Me.txt_staffid.TabIndex = 38
        '
        'txt_custid
        '
        Me.txt_custid.Location = New System.Drawing.Point(268, 135)
        Me.txt_custid.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_custid.Name = "txt_custid"
        Me.txt_custid.ReadOnly = True
        Me.txt_custid.Size = New System.Drawing.Size(70, 22)
        Me.txt_custid.TabIndex = 37
        '
        'btn_back
        '
        Me.btn_back.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_back.Font = New System.Drawing.Font("Arial Rounded MT Bold", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.Location = New System.Drawing.Point(115, 395)
        Me.btn_back.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(97, 38)
        Me.btn_back.TabIndex = 36
        Me.btn_back.Text = "BACK"
        Me.btn_back.UseVisualStyleBackColor = False
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.BackColor = System.Drawing.Color.Transparent
        Me.lbl_total.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total.ForeColor = System.Drawing.Color.Black
        Me.lbl_total.Location = New System.Drawing.Point(581, 402)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(41, 19)
        Me.lbl_total.TabIndex = 35
        Me.lbl_total.Text = "Total"
        '
        'txt_total
        '
        Me.txt_total.Location = New System.Drawing.Point(640, 402)
        Me.txt_total.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.Size = New System.Drawing.Size(101, 22)
        Me.txt_total.TabIndex = 34
        '
        'lbl_orderid
        '
        Me.lbl_orderid.AutoSize = True
        Me.lbl_orderid.BackColor = System.Drawing.Color.Transparent
        Me.lbl_orderid.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_orderid.ForeColor = System.Drawing.Color.Black
        Me.lbl_orderid.Location = New System.Drawing.Point(537, 138)
        Me.lbl_orderid.Name = "lbl_orderid"
        Me.lbl_orderid.Size = New System.Drawing.Size(65, 19)
        Me.lbl_orderid.TabIndex = 33
        Me.lbl_orderid.Text = "Order ID"
        '
        'cmb_orderid
        '
        Me.cmb_orderid.FormattingEnabled = True
        Me.cmb_orderid.Location = New System.Drawing.Point(640, 138)
        Me.cmb_orderid.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmb_orderid.Name = "cmb_orderid"
        Me.cmb_orderid.Size = New System.Drawing.Size(101, 24)
        Me.cmb_orderid.TabIndex = 32
        '
        'grd_order
        '
        Me.grd_order.AllowUserToAddRows = False
        Me.grd_order.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.grd_order.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.grd_order.BackgroundColor = System.Drawing.Color.LightCyan
        Me.grd_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_order.Location = New System.Drawing.Point(115, 200)
        Me.grd_order.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grd_order.Name = "grd_order"
        Me.grd_order.ReadOnly = True
        Me.grd_order.RowTemplate.Height = 28
        Me.grd_order.Size = New System.Drawing.Size(626, 176)
        Me.grd_order.TabIndex = 31
        '
        'lbl_date
        '
        Me.lbl_date.AutoSize = True
        Me.lbl_date.Location = New System.Drawing.Point(637, 175)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(38, 17)
        Me.lbl_date.TabIndex = 46
        Me.lbl_date.Text = "Date"
        '
        'lbl_datetit
        '
        Me.lbl_datetit.AutoSize = True
        Me.lbl_datetit.Location = New System.Drawing.Point(541, 175)
        Me.lbl_datetit.Name = "lbl_datetit"
        Me.lbl_datetit.Size = New System.Drawing.Size(38, 17)
        Me.lbl_datetit.TabIndex = 47
        Me.lbl_datetit.Text = "Date"
        '
        'frm_vieworder_a172316
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(852, 478)
        Me.Controls.Add(Me.lbl_datetit)
        Me.Controls.Add(Me.lbl_date)
        Me.Controls.Add(Me.lbl_contact)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.lbl_staffid)
        Me.Controls.Add(Me.lbl_custid)
        Me.Controls.Add(Me.txt_staffid)
        Me.Controls.Add(Me.txt_custid)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.lbl_total)
        Me.Controls.Add(Me.txt_total)
        Me.Controls.Add(Me.lbl_orderid)
        Me.Controls.Add(Me.cmb_orderid)
        Me.Controls.Add(Me.grd_order)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_vieworder_a172316"
        Me.Text = "Invoice"
        CType(Me.grd_order, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_contact As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lbl_title As Label
    Friend WithEvents lbl_staffid As Label
    Friend WithEvents lbl_custid As Label
    Friend WithEvents txt_staffid As TextBox
    Friend WithEvents txt_custid As TextBox
    Friend WithEvents btn_back As Button
    Friend WithEvents lbl_total As Label
    Friend WithEvents txt_total As TextBox
    Friend WithEvents lbl_orderid As Label
    Friend WithEvents cmb_orderid As ComboBox
    Friend WithEvents grd_order As DataGridView
    Friend WithEvents lbl_date As Label
    Friend WithEvents lbl_datetit As Label
End Class
