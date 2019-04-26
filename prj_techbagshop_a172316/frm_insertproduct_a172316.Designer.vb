<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_insertproduct_a172316
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_insertproduct_a172316))
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.grd_product = New System.Windows.Forms.DataGridView()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.txt_brand = New System.Windows.Forms.TextBox()
        Me.txt_color = New System.Windows.Forms.TextBox()
        Me.txt_quantity = New System.Windows.Forms.TextBox()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.lbl_price = New System.Windows.Forms.Label()
        Me.lbl_brand = New System.Windows.Forms.Label()
        Me.lbl_color = New System.Windows.Forms.Label()
        Me.lbl_type = New System.Windows.Forms.Label()
        Me.lbl_quantity = New System.Windows.Forms.Label()
        Me.btn_insert = New System.Windows.Forms.Button()
        Me.pic_product = New System.Windows.Forms.PictureBox()
        Me.btn_picture = New System.Windows.Forms.Button()
        Me.txt_picture = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.cmb_type = New System.Windows.Forms.ComboBox()
        CType(Me.grd_product, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.BackColor = System.Drawing.Color.Black
        Me.lbl_title.Font = New System.Drawing.Font("Modern No. 20", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lbl_title.Location = New System.Drawing.Point(299, 21)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(294, 34)
        Me.lbl_title.TabIndex = 0
        Me.lbl_title.Text = "Insert New Product"
        '
        'grd_product
        '
        Me.grd_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_product.Location = New System.Drawing.Point(65, 70)
        Me.grd_product.Name = "grd_product"
        Me.grd_product.RowTemplate.Height = 24
        Me.grd_product.Size = New System.Drawing.Size(699, 160)
        Me.grd_product.TabIndex = 1
        '
        'txt_id
        '
        Me.txt_id.Location = New System.Drawing.Point(187, 246)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(187, 22)
        Me.txt_id.TabIndex = 2
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(187, 275)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(187, 22)
        Me.txt_name.TabIndex = 3
        '
        'txt_price
        '
        Me.txt_price.Location = New System.Drawing.Point(187, 303)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.Size = New System.Drawing.Size(187, 22)
        Me.txt_price.TabIndex = 4
        Me.txt_price.Text = "0.00"
        '
        'txt_brand
        '
        Me.txt_brand.Location = New System.Drawing.Point(187, 331)
        Me.txt_brand.Name = "txt_brand"
        Me.txt_brand.Size = New System.Drawing.Size(187, 22)
        Me.txt_brand.TabIndex = 5
        '
        'txt_color
        '
        Me.txt_color.Location = New System.Drawing.Point(187, 359)
        Me.txt_color.Name = "txt_color"
        Me.txt_color.Size = New System.Drawing.Size(187, 22)
        Me.txt_color.TabIndex = 6
        '
        'txt_quantity
        '
        Me.txt_quantity.Location = New System.Drawing.Point(187, 416)
        Me.txt_quantity.Name = "txt_quantity"
        Me.txt_quantity.Size = New System.Drawing.Size(187, 22)
        Me.txt_quantity.TabIndex = 8
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id.Location = New System.Drawing.Point(65, 251)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(78, 17)
        Me.lbl_id.TabIndex = 9
        Me.lbl_id.Text = "Product ID:"
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_name.Location = New System.Drawing.Point(65, 278)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(102, 17)
        Me.lbl_name.TabIndex = 10
        Me.lbl_name.Text = "Product Name:"
        '
        'lbl_price
        '
        Me.lbl_price.AutoSize = True
        Me.lbl_price.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_price.Location = New System.Drawing.Point(65, 306)
        Me.lbl_price.Name = "lbl_price"
        Me.lbl_price.Size = New System.Drawing.Size(75, 17)
        Me.lbl_price.TabIndex = 11
        Me.lbl_price.Text = "Price(RM):"
        '
        'lbl_brand
        '
        Me.lbl_brand.AutoSize = True
        Me.lbl_brand.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_brand.Location = New System.Drawing.Point(65, 334)
        Me.lbl_brand.Name = "lbl_brand"
        Me.lbl_brand.Size = New System.Drawing.Size(50, 17)
        Me.lbl_brand.TabIndex = 12
        Me.lbl_brand.Text = "Brand:"
        '
        'lbl_color
        '
        Me.lbl_color.AutoSize = True
        Me.lbl_color.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_color.Location = New System.Drawing.Point(65, 363)
        Me.lbl_color.Name = "lbl_color"
        Me.lbl_color.Size = New System.Drawing.Size(45, 17)
        Me.lbl_color.TabIndex = 13
        Me.lbl_color.Text = "Color:"
        '
        'lbl_type
        '
        Me.lbl_type.AutoSize = True
        Me.lbl_type.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_type.Location = New System.Drawing.Point(65, 391)
        Me.lbl_type.Name = "lbl_type"
        Me.lbl_type.Size = New System.Drawing.Size(44, 17)
        Me.lbl_type.TabIndex = 14
        Me.lbl_type.Text = "Type:"
        '
        'lbl_quantity
        '
        Me.lbl_quantity.AutoSize = True
        Me.lbl_quantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_quantity.Location = New System.Drawing.Point(65, 419)
        Me.lbl_quantity.Name = "lbl_quantity"
        Me.lbl_quantity.Size = New System.Drawing.Size(65, 17)
        Me.lbl_quantity.TabIndex = 15
        Me.lbl_quantity.Text = "Quantity:"
        '
        'btn_insert
        '
        Me.btn_insert.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_insert.Location = New System.Drawing.Point(634, 331)
        Me.btn_insert.Name = "btn_insert"
        Me.btn_insert.Size = New System.Drawing.Size(130, 45)
        Me.btn_insert.TabIndex = 16
        Me.btn_insert.Text = "INSERT"
        Me.btn_insert.UseVisualStyleBackColor = False
        '
        'pic_product
        '
        Me.pic_product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pic_product.Location = New System.Drawing.Point(418, 244)
        Me.pic_product.Name = "pic_product"
        Me.pic_product.Size = New System.Drawing.Size(193, 190)
        Me.pic_product.TabIndex = 17
        Me.pic_product.TabStop = False
        '
        'btn_picture
        '
        Me.btn_picture.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_picture.Location = New System.Drawing.Point(634, 274)
        Me.btn_picture.Name = "btn_picture"
        Me.btn_picture.Size = New System.Drawing.Size(130, 47)
        Me.btn_picture.TabIndex = 18
        Me.btn_picture.Text = "SELECT PICTURE"
        Me.btn_picture.UseVisualStyleBackColor = False
        '
        'txt_picture
        '
        Me.txt_picture.Location = New System.Drawing.Point(634, 246)
        Me.txt_picture.Name = "txt_picture"
        Me.txt_picture.Size = New System.Drawing.Size(130, 22)
        Me.txt_picture.TabIndex = 19
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btn_back
        '
        Me.btn_back.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_back.Location = New System.Drawing.Point(634, 382)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(130, 52)
        Me.btn_back.TabIndex = 20
        Me.btn_back.Text = "BACK"
        Me.btn_back.UseVisualStyleBackColor = False
        '
        'cmb_type
        '
        Me.cmb_type.FormattingEnabled = True
        Me.cmb_type.Items.AddRange(New Object() {"Computer Bag", "Tablet Bag"})
        Me.cmb_type.Location = New System.Drawing.Point(187, 386)
        Me.cmb_type.Name = "cmb_type"
        Me.cmb_type.Size = New System.Drawing.Size(187, 24)
        Me.cmb_type.TabIndex = 21
        '
        'frm_insertproduct_a172316
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(852, 478)
        Me.Controls.Add(Me.cmb_type)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.txt_picture)
        Me.Controls.Add(Me.btn_picture)
        Me.Controls.Add(Me.pic_product)
        Me.Controls.Add(Me.btn_insert)
        Me.Controls.Add(Me.lbl_quantity)
        Me.Controls.Add(Me.lbl_type)
        Me.Controls.Add(Me.lbl_color)
        Me.Controls.Add(Me.lbl_brand)
        Me.Controls.Add(Me.lbl_price)
        Me.Controls.Add(Me.lbl_name)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.txt_quantity)
        Me.Controls.Add(Me.txt_color)
        Me.Controls.Add(Me.txt_brand)
        Me.Controls.Add(Me.txt_price)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.grd_product)
        Me.Controls.Add(Me.lbl_title)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_insertproduct_a172316"
        Me.Text = "Insert Product"
        CType(Me.grd_product, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_title As Label
    Friend WithEvents grd_product As DataGridView
    Friend WithEvents txt_id As TextBox
    Friend WithEvents txt_name As TextBox
    Friend WithEvents txt_price As TextBox
    Friend WithEvents txt_brand As TextBox
    Friend WithEvents txt_color As TextBox
    Friend WithEvents txt_quantity As TextBox
    Friend WithEvents lbl_id As Label
    Friend WithEvents lbl_name As Label
    Friend WithEvents lbl_price As Label
    Friend WithEvents lbl_brand As Label
    Friend WithEvents lbl_color As Label
    Friend WithEvents lbl_type As Label
    Friend WithEvents lbl_quantity As Label
    Friend WithEvents btn_insert As Button
    Friend WithEvents pic_product As PictureBox
    Friend WithEvents btn_picture As Button
    Friend WithEvents txt_picture As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btn_back As Button
    Friend WithEvents cmb_type As ComboBox
End Class
