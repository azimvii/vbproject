<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_updateproduct_a172316
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_updateproduct_a172316))
        Me.lbl_quantity = New System.Windows.Forms.Label()
        Me.lbl_type = New System.Windows.Forms.Label()
        Me.lbl_color = New System.Windows.Forms.Label()
        Me.lbl_brand = New System.Windows.Forms.Label()
        Me.lbl_price = New System.Windows.Forms.Label()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.txt_quantity = New System.Windows.Forms.TextBox()
        Me.txt_type = New System.Windows.Forms.TextBox()
        Me.txt_color = New System.Windows.Forms.TextBox()
        Me.txt_brand = New System.Windows.Forms.TextBox()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.grd_product = New System.Windows.Forms.DataGridView()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_back = New System.Windows.Forms.Button()
        CType(Me.grd_product, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_quantity
        '
        Me.lbl_quantity.AutoSize = True
        Me.lbl_quantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_quantity.Location = New System.Drawing.Point(78, 418)
        Me.lbl_quantity.Name = "lbl_quantity"
        Me.lbl_quantity.Size = New System.Drawing.Size(65, 17)
        Me.lbl_quantity.TabIndex = 31
        Me.lbl_quantity.Text = "Quantity:"
        '
        'lbl_type
        '
        Me.lbl_type.AutoSize = True
        Me.lbl_type.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_type.Location = New System.Drawing.Point(78, 390)
        Me.lbl_type.Name = "lbl_type"
        Me.lbl_type.Size = New System.Drawing.Size(44, 17)
        Me.lbl_type.TabIndex = 30
        Me.lbl_type.Text = "Type:"
        '
        'lbl_color
        '
        Me.lbl_color.AutoSize = True
        Me.lbl_color.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_color.Location = New System.Drawing.Point(78, 362)
        Me.lbl_color.Name = "lbl_color"
        Me.lbl_color.Size = New System.Drawing.Size(45, 17)
        Me.lbl_color.TabIndex = 29
        Me.lbl_color.Text = "Color:"
        '
        'lbl_brand
        '
        Me.lbl_brand.AutoSize = True
        Me.lbl_brand.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_brand.Location = New System.Drawing.Point(78, 333)
        Me.lbl_brand.Name = "lbl_brand"
        Me.lbl_brand.Size = New System.Drawing.Size(50, 17)
        Me.lbl_brand.TabIndex = 28
        Me.lbl_brand.Text = "Brand:"
        '
        'lbl_price
        '
        Me.lbl_price.AutoSize = True
        Me.lbl_price.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_price.Location = New System.Drawing.Point(78, 305)
        Me.lbl_price.Name = "lbl_price"
        Me.lbl_price.Size = New System.Drawing.Size(75, 17)
        Me.lbl_price.TabIndex = 27
        Me.lbl_price.Text = "Price(RM):"
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_name.Location = New System.Drawing.Point(78, 277)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(102, 17)
        Me.lbl_name.TabIndex = 26
        Me.lbl_name.Text = "Product Name:"
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id.Location = New System.Drawing.Point(78, 250)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(78, 17)
        Me.lbl_id.TabIndex = 25
        Me.lbl_id.Text = "Product ID:"
        '
        'txt_quantity
        '
        Me.txt_quantity.Location = New System.Drawing.Point(200, 415)
        Me.txt_quantity.Name = "txt_quantity"
        Me.txt_quantity.Size = New System.Drawing.Size(230, 22)
        Me.txt_quantity.TabIndex = 24
        '
        'txt_type
        '
        Me.txt_type.Location = New System.Drawing.Point(200, 387)
        Me.txt_type.Name = "txt_type"
        Me.txt_type.Size = New System.Drawing.Size(230, 22)
        Me.txt_type.TabIndex = 23
        '
        'txt_color
        '
        Me.txt_color.Location = New System.Drawing.Point(200, 358)
        Me.txt_color.Name = "txt_color"
        Me.txt_color.Size = New System.Drawing.Size(230, 22)
        Me.txt_color.TabIndex = 22
        '
        'txt_brand
        '
        Me.txt_brand.Location = New System.Drawing.Point(200, 330)
        Me.txt_brand.Name = "txt_brand"
        Me.txt_brand.Size = New System.Drawing.Size(230, 22)
        Me.txt_brand.TabIndex = 21
        '
        'txt_price
        '
        Me.txt_price.Location = New System.Drawing.Point(200, 302)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.Size = New System.Drawing.Size(230, 22)
        Me.txt_price.TabIndex = 20
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(200, 274)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(230, 22)
        Me.txt_name.TabIndex = 19
        '
        'txt_id
        '
        Me.txt_id.Location = New System.Drawing.Point(200, 245)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(230, 22)
        Me.txt_id.TabIndex = 18
        '
        'grd_product
        '
        Me.grd_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_product.Location = New System.Drawing.Point(78, 69)
        Me.grd_product.Name = "grd_product"
        Me.grd_product.RowTemplate.Height = 24
        Me.grd_product.Size = New System.Drawing.Size(699, 160)
        Me.grd_product.TabIndex = 17
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.BackColor = System.Drawing.Color.Transparent
        Me.lbl_title.Font = New System.Drawing.Font("Arial Rounded MT Bold", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.ForeColor = System.Drawing.Color.Purple
        Me.lbl_title.Location = New System.Drawing.Point(313, 20)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(273, 38)
        Me.lbl_title.TabIndex = 16
        Me.lbl_title.Text = "Update Product"
        '
        'btn_update
        '
        Me.btn_update.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_update.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.Location = New System.Drawing.Point(518, 245)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(105, 51)
        Me.btn_update.TabIndex = 32
        Me.btn_update.Text = "UPDATE"
        Me.btn_update.UseVisualStyleBackColor = False
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.Color.Red
        Me.btn_delete.Location = New System.Drawing.Point(672, 245)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(105, 48)
        Me.btn_delete.TabIndex = 33
        Me.btn_delete.Text = "DELETE"
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'btn_back
        '
        Me.btn_back.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_back.Location = New System.Drawing.Point(607, 387)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(105, 50)
        Me.btn_back.TabIndex = 34
        Me.btn_back.Text = "BACK"
        Me.btn_back.UseVisualStyleBackColor = False
        '
        'frm_updateproduct_a172316
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(852, 478)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.lbl_quantity)
        Me.Controls.Add(Me.lbl_type)
        Me.Controls.Add(Me.lbl_color)
        Me.Controls.Add(Me.lbl_brand)
        Me.Controls.Add(Me.lbl_price)
        Me.Controls.Add(Me.lbl_name)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.txt_quantity)
        Me.Controls.Add(Me.txt_type)
        Me.Controls.Add(Me.txt_color)
        Me.Controls.Add(Me.txt_brand)
        Me.Controls.Add(Me.txt_price)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.grd_product)
        Me.Controls.Add(Me.lbl_title)
        Me.Name = "frm_updateproduct_a172316"
        Me.Text = "Update Product"
        CType(Me.grd_product, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_quantity As Label
    Friend WithEvents lbl_type As Label
    Friend WithEvents lbl_color As Label
    Friend WithEvents lbl_brand As Label
    Friend WithEvents lbl_price As Label
    Friend WithEvents lbl_name As Label
    Friend WithEvents lbl_id As Label
    Friend WithEvents txt_quantity As TextBox
    Friend WithEvents txt_type As TextBox
    Friend WithEvents txt_color As TextBox
    Friend WithEvents txt_brand As TextBox
    Friend WithEvents txt_price As TextBox
    Friend WithEvents txt_name As TextBox
    Friend WithEvents txt_id As TextBox
    Friend WithEvents grd_product As DataGridView
    Friend WithEvents lbl_title As Label
    Friend WithEvents btn_update As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_back As Button
End Class
