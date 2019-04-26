Public Class frm_makeorder_a172316
    Dim i As Integer = 0
    Dim current_row As Integer
    Dim total As Double
    Dim staffid As String
    Dim custid As String

    Private Sub frm_makeorder_a172316_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        refresh_grid()

    End Sub

    Private Sub refresh_grid()

        grd_products.DataSource = run_sql_query("SELECT * FROM TBL_PRODUCTS_A172316")

        grd_order.ColumnCount = 4
        grd_order.RowCount = 0

        grd_order.Columns(0).HeaderText = "Product Name"
        grd_order.Columns(1).HeaderText = "Quantity"
        grd_order.Columns(2).HeaderText = "Unit Price"
        grd_order.Columns(3).HeaderText = "Subtotal"

        lbl_ordid.Text = generate_ordid()

        cmb_cust.DataSource = run_sql_query("SELECT FLD_CUSTOMER_ID FROM TBL_CUSTOMERS_A172316")
        cmb_cust.DisplayMember = "FLD_CUSTOMER_ID"
        cmb_staff.DataSource = run_sql_query("SELECT FLD_STAFF_ID FROM TBL_STAFFS_A172316")
        cmb_staff.DisplayMember = "FLD_STAFF_ID"

        lbl_date.Text = DateTime.Now.ToString("dd/MM/yyyy")

        pic_product.BackgroundImage = Image.FromFile("pictures/P001.jpg")

        txt_total.Text = ""

    End Sub

    Private Function generate_ordid() As String

        Dim newordid As String

        Dim mydatatable As DataTable = run_sql_query("SELECT * FROM TBL_ORDERS_A172316")

        If mydatatable.Rows.Count = 0 Then
            newordid = "O001"
        Else
            Dim lastid As String = run_sql_query("SELECT MAX(FLD_ORDER_ID) AS LASTID FROM TBL_ORDERS_A172316").Rows(0).Item("LASTID")

            newordid = "O00" & Mid(lastid, 3) + 1
        End If

        Return newordid

    End Function

    Private Sub grd_products_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grd_products.CellClick

        Dim current_row As Integer = grd_products.CurrentRow.Index

        Try
            pic_product.BackgroundImage = Image.FromFile("pictures/" & grd_products(0, current_row).Value & ".jpg")
        Catch ex As Exception
            pic_product.BackgroundImage = Image.FromFile("pictures/nophoto.jpg")
        End Try

    End Sub

    Private Sub btn_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_add.Click

        Dim count As Integer = 0
        Dim temp As Integer

        For x As Integer = 0 To grd_order.RowCount - 1
            If grd_products(1, get_current_row).Value = grd_order(0, x).Value Then
                count = count + 1
                temp = x
            End If
        Next

        If count > 0 Then
            grd_order(1, temp).Value = grd_order(1, temp).Value + dud_quantity.Value
            Dim temptotal As Integer = dud_quantity.Value * grd_order(2, temp).Value
            grd_order(3, temp).Value = "RM" & grd_order(3, temp).Value + temptotal

            total = total + temptotal
        Else
            grd_order.RowCount = grd_order.RowCount + 1
            grd_order(0, i).Value = grd_products(1, get_current_row).Value
            grd_order(1, i).Value = dud_quantity.Value
            grd_order(2, i).Value = "RM" & grd_products(2, get_current_row).Value
            grd_order(3, i).Value = "RM" & dud_quantity.Value * grd_products(2, get_current_row).Value

            total = total + grd_order(3, i).Value

            i += 1
        End If

        txt_total.Text = "RM" & FormatCurrency(total, 2)
    End Sub

    Private Function get_current_row() As Integer

        current_row = grd_products.CurrentRow.Index

        Return current_row

    End Function

    Private Sub btn_confirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_confirm.Click

        If grd_order.RowCount > 0 Then
            Dim mytransaction As OleDb.OleDbTransaction

            myconnection2.Open()
            mytransaction = myconnection2.BeginTransaction

            Dim orderid As String = lbl_ordid.Text
            Dim orddate As String = lbl_date.Text

            Try

                Dim ordersql As String = "INSERT INTO TBL_ORDERS_A172316 VALUES ('" & orderid & "','" & orddate & "','" & custid & "', '" & staffid & "')"

                Dim orderwritter As New OleDb.OleDbCommand(ordersql, myconnection2, mytransaction)

                orderwritter.ExecuteNonQuery()

                For x As Integer = 0 To grd_order.RowCount - 1

                    Dim productdatatable = run_sql_query("SELECT * FROM TBL_PRODUCTS_A172316 WHERE FLD_PRODUCT_NAME ='" & grd_order(0, x).Value & "'")
                    Dim productid As String = productdatatable.Rows(0).Item("FLD_PRODUCT_ID")
                    Dim quantity As Integer = grd_order(1, x).Value

                    Dim itemsql As String = "INSERT INTO TBL_ITEMS_A172316 VALUES ('" & productid & "', '" & orderid & "', '" & quantity & "')"

                    Dim itemwritter As New OleDb.OleDbCommand(itemsql, myconnection2, mytransaction)

                    itemwritter.ExecuteNonQuery()

                Next

                mytransaction.Commit()
                myconnection2.Close()

                Beep()
                MsgBox("Transaction Successful!")

                grd_order.Rows.Clear()
                refresh_grid()

            Catch ex As Exception

                mytransaction.Rollback()
                Beep()
                MsgBox("An error occured while confirming order: " & vbCrLf & vbCrLf & ex.Message)
                myconnection2.Close()

                grd_order.Rows.Clear()
                refresh_grid()

            End Try

            i = 0
        Else
            MsgBox("Please add product")
        End If

    End Sub

    Private Sub cmb_cust_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_cust.SelectedIndexChanged

        Dim mydatatable = run_sql_query("SELECT * FROM TBL_CUSTOMERS_A172316")

        custid = mydatatable.Rows(cmb_cust.SelectedIndex).Item("FLD_CUSTOMER_ID")

    End Sub

    Private Sub cmb_staff_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_staff.SelectedIndexChanged

        Dim mydatatable = run_sql_query("SELECT * FROM TBL_STAFFS_A172316")

        staffid = mydatatable.Rows(cmb_staff.SelectedIndex).Item("FLD_STAFF_ID")

    End Sub

    Private Sub btn_back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_back.Click

        frm_mainmenu_a172316.Show()
        Me.Hide()

    End Sub

    Private Sub btn_vieworder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_vieworder.Click

        frm_vieworder_a172316.Show()
        Me.Hide()

    End Sub

    Private Sub btn_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete.Click

        If grd_order.RowCount > 0 Then
            Dim current As Integer = grd_order.CurrentRow.Index

            grd_order.Rows.RemoveAt(current)

            i = i - 1
        Else
            MsgBox("There is no order left")
        End If

    End Sub
End Class