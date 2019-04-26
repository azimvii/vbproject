Public Class frm_catalog_a172316
    Private Sub frm_catalog_a172316_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mysql As String = "SELECT FLD_PRODUCT_ID FROM TBL_PRODUCTS_A172316"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        lst_id.DataSource = mydatatable
        lst_id.DisplayMember = "FLD_PRODUCT_ID"

        refresh_text(lst_id.Text)

    End Sub

    Private Sub refresh_text(id As String)
        Dim mysql As String = "SELECT * FROM TBL_PRODUCTS_A172316 WHERE FLD_PRODUCT_ID = '" & id & "'"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        txt_id.Text = mydatatable.Rows(0).Item("FLD_PRODUCT_ID")
        txt_name.Text = mydatatable.Rows(0).Item("FLD_PRODUCT_NAME")
        txt_price.Text = mydatatable.Rows(0).Item("FLD_PRICE")
        txt_brand.Text = mydatatable.Rows(0).Item("FLD_BRAND")
        txt_color.Text = mydatatable.Rows(0).Item("FLD_COLOR")
        txt_type.Text = mydatatable.Rows(0).Item("FLD_TYPE")
        txt_quantity.Text = mydatatable.Rows(0).Item("FLD_QUANTITY")

        pic_product.BackgroundImage = Image.FromFile("pictures/" & txt_id.Text & ".jpg")
    End Sub

    Private Sub lst_id_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles lst_id.MouseClick
        refresh_text(lst_id.Text)
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_mainmenu_a172316.Show()
        Me.Hide()
    End Sub
End Class