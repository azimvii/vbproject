<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_catalog_a172316
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_catalog_a172316))
        Me.lst_id = New System.Windows.Forms.ListBox()
        Me.pic_product = New System.Windows.Forms.PictureBox()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.txt_color = New System.Windows.Forms.TextBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.txt_quantity = New System.Windows.Forms.TextBox()
        Me.txt_type = New System.Windows.Forms.TextBox()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.txt_brand = New System.Windows.Forms.TextBox()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.lbl_color = New System.Windows.Forms.Label()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_quantity = New System.Windows.Forms.Label()
        Me.lbl_price = New System.Windows.Forms.Label()
        Me.lbl_brand = New System.Windows.Forms.Label()
        Me.btn_back = New System.Windows.Forms.Button()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lst_id
        '
        Me.lst_id.FormattingEnabled = True
        Me.lst_id.ItemHeight = 16
        Me.lst_id.Location = New System.Drawing.Point(141, 75)
        Me.lst_id.Name = "lst_id"
        Me.lst_id.Size = New System.Drawing.Size(254, 212)
        Me.lst_id.TabIndex = 0
        '
        'pic_product
        '
        Me.pic_product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pic_product.Location = New System.Drawing.Point(443, 73)
        Me.pic_product.Name = "pic_product"
        Me.pic_product.Size = New System.Drawing.Size(254, 214)
        Me.pic_product.TabIndex = 1
        Me.pic_product.TabStop = False
        '
        'txt_id
        '
        Me.txt_id.Location = New System.Drawing.Point(24, 327)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(159, 22)
        Me.txt_id.TabIndex = 2
        '
        'txt_color
        '
        Me.txt_color.Location = New System.Drawing.Point(141, 383)
        Me.txt_color.Name = "txt_color"
        Me.txt_color.Size = New System.Drawing.Size(159, 22)
        Me.txt_color.TabIndex = 3
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(236, 327)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(159, 22)
        Me.txt_name.TabIndex = 4
        '
        'txt_quantity
        '
        Me.txt_quantity.Location = New System.Drawing.Point(550, 383)
        Me.txt_quantity.Name = "txt_quantity"
        Me.txt_quantity.Size = New System.Drawing.Size(159, 22)
        Me.txt_quantity.TabIndex = 5
        '
        'txt_type
        '
        Me.txt_type.Location = New System.Drawing.Point(343, 383)
        Me.txt_type.Name = "txt_type"
        Me.txt_type.Size = New System.Drawing.Size(159, 22)
        Me.txt_type.TabIndex = 6
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.BackColor = System.Drawing.Color.Transparent
        Me.lbl_title.Font = New System.Drawing.Font("Modern No. 20", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_title.Location = New System.Drawing.Point(313, 9)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(206, 41)
        Me.lbl_title.TabIndex = 7
        Me.lbl_title.Text = "CATALOG"
        '
        'txt_price
        '
        Me.txt_price.Location = New System.Drawing.Point(443, 327)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.Size = New System.Drawing.Size(159, 22)
        Me.txt_price.TabIndex = 8
        '
        'txt_brand
        '
        Me.txt_brand.Location = New System.Drawing.Point(650, 327)
        Me.txt_brand.Name = "txt_brand"
        Me.txt_brand.Size = New System.Drawing.Size(159, 22)
        Me.txt_brand.TabIndex = 9
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.BackColor = System.Drawing.Color.Transparent
        Me.lbl_id.Font = New System.Drawing.Font("Palatino Linotype", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id.ForeColor = System.Drawing.Color.Black
        Me.lbl_id.Location = New System.Drawing.Point(21, 307)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(84, 19)
        Me.lbl_id.TabIndex = 11
        Me.lbl_id.Text = "Product ID:"
        '
        'lbl_color
        '
        Me.lbl_color.AutoSize = True
        Me.lbl_color.BackColor = System.Drawing.Color.Transparent
        Me.lbl_color.Font = New System.Drawing.Font("Palatino Linotype", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_color.Location = New System.Drawing.Point(138, 363)
        Me.lbl_color.Name = "lbl_color"
        Me.lbl_color.Size = New System.Drawing.Size(48, 19)
        Me.lbl_color.TabIndex = 12
        Me.lbl_color.Text = "Color:"
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.BackColor = System.Drawing.Color.Transparent
        Me.lbl_name.Font = New System.Drawing.Font("Palatino Linotype", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_name.Location = New System.Drawing.Point(233, 307)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(52, 19)
        Me.lbl_name.TabIndex = 13
        Me.lbl_name.Text = "Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Palatino Linotype", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(340, 363)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 19)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Type:"
        '
        'lbl_quantity
        '
        Me.lbl_quantity.AutoSize = True
        Me.lbl_quantity.BackColor = System.Drawing.Color.Transparent
        Me.lbl_quantity.Font = New System.Drawing.Font("Palatino Linotype", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_quantity.Location = New System.Drawing.Point(547, 363)
        Me.lbl_quantity.Name = "lbl_quantity"
        Me.lbl_quantity.Size = New System.Drawing.Size(74, 19)
        Me.lbl_quantity.TabIndex = 15
        Me.lbl_quantity.Text = "Quantity:"
        '
        'lbl_price
        '
        Me.lbl_price.AutoSize = True
        Me.lbl_price.BackColor = System.Drawing.Color.Transparent
        Me.lbl_price.Font = New System.Drawing.Font("Palatino Linotype", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_price.Location = New System.Drawing.Point(440, 307)
        Me.lbl_price.Name = "lbl_price"
        Me.lbl_price.Size = New System.Drawing.Size(80, 19)
        Me.lbl_price.TabIndex = 17
        Me.lbl_price.Text = "Price(RM):"
        '
        'lbl_brand
        '
        Me.lbl_brand.AutoSize = True
        Me.lbl_brand.BackColor = System.Drawing.Color.Transparent
        Me.lbl_brand.Font = New System.Drawing.Font("Palatino Linotype", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_brand.Location = New System.Drawing.Point(647, 307)
        Me.lbl_brand.Name = "lbl_brand"
        Me.lbl_brand.Size = New System.Drawing.Size(52, 19)
        Me.lbl_brand.TabIndex = 18
        Me.lbl_brand.Text = "Brand:"
        '
        'btn_back
        '
        Me.btn_back.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_back.Location = New System.Drawing.Point(379, 421)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(92, 45)
        Me.btn_back.TabIndex = 19
        Me.btn_back.Text = "BACK"
        Me.btn_back.UseVisualStyleBackColor = False
        '
        'frm_catalog_a172316
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(852, 478)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.lbl_brand)
        Me.Controls.Add(Me.lbl_price)
        Me.Controls.Add(Me.lbl_quantity)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbl_name)
        Me.Controls.Add(Me.lbl_color)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.txt_brand)
        Me.Controls.Add(Me.txt_price)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.txt_type)
        Me.Controls.Add(Me.txt_quantity)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.txt_color)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.pic_product)
        Me.Controls.Add(Me.lst_id)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_catalog_a172316"
        Me.Text = "Catalog Details"
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lst_id As ListBox
    Friend WithEvents pic_product As PictureBox
    Friend WithEvents txt_id As TextBox
    Friend WithEvents txt_color As TextBox
    Friend WithEvents txt_name As TextBox
    Friend WithEvents txt_quantity As TextBox
    Friend WithEvents txt_type As TextBox
    Friend WithEvents lbl_title As Label
    Friend WithEvents txt_price As TextBox
    Friend WithEvents txt_brand As TextBox
    Friend WithEvents lbl_id As Label
    Friend WithEvents lbl_color As Label
    Friend WithEvents lbl_name As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lbl_quantity As Label
    Friend WithEvents lbl_price As Label
    Friend WithEvents lbl_brand As Label
    Friend WithEvents btn_back As Button
End Class
