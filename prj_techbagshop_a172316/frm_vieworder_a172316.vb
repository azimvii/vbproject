Public Class frm_vieworder_a172316

    Private Sub frm_vieworder_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        cmb_orderid.DataSource = run_sql_query("SELECT FLD_ORDER_ID FROM TBL_ORDERS_A172316")
        cmb_orderid.DisplayMember = "FLD_ORDER_ID"

        grd_order.Columns(0).HeaderText = "Product ID"
        grd_order.Columns(1).HeaderText = "Product Name"
        grd_order.Columns(2).HeaderText = "Quantity"
        grd_order.Columns(3).HeaderText = "Unit Price"
        grd_order.Columns(4).HeaderText = "Subtotal"

        lbl_date.Text = DateTime.Now.ToString("dd/MM/yyy")

        txt_total.Text = "RM" & get_total()

    End Sub

    Private Sub cmb_orderid_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_orderid.SelectedIndexChanged

        Dim order = run_sql_query("SELECT * FROM TBL_ORDERS_A172316")
        Dim orderid = order.Rows(cmb_orderid.SelectedIndex).Item("FLD_ORDER_ID")

        Dim mydatatable = run_sql_query("SELECT TBL_ITEMS_A172316.FLD_PRODUCT_ID, FLD_PRODUCT_NAME, FLD_QUANTITY, FLD_PRICE, FLD_QUANTITY*FLD_PRICE FROM TBL_ITEMS_A172316, TBL_PRODUCTS_A172316 WHERE FLD_ORDER_ID ='" & orderid & "' AND TBL_ITEMS_A172316.FLD_PRODUCT_ID = TBL_PRODUCTS_A172316.FLD_PRODUCT_ID")

        grd_order.DataSource = mydatatable

        Dim orderdatatable = run_sql_query("SELECT * FROM TBL_ORDERS_A172316 WHERE FLD_ORDER_ID = '" & orderid & "'")

        txt_custid.Text = orderdatatable.Rows(0).Item("FLD_CUSTOMER_ID")
        txt_staffid.Text = orderdatatable.Rows(0).Item("FLD_STAFF_ID")

        txt_total.Text = "RM" & FormatCurrency(get_total(), 2)

    End Sub

    Private Function get_total() As Double

        Dim total As Double = 0

        For i As Integer = 0 To grd_order.RowCount - 1
            total = total + grd_order(4, i).Value
        Next

        Return total

    End Function

    Private Sub btn_back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_back.Click

        frm_makeorder_a172316.Show()
        Me.Hide()

    End Sub
End Class