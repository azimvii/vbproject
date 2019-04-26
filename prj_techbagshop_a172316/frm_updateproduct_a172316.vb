Public Class frm_updateproduct_a172316
    Dim current_id As String

    Private Sub frm_updateproduct_a172316_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh_grid()

        get_current_id()
    End Sub

    Private Sub refresh_grid()
        Dim mysql As String = "SELECT * FROM TBL_PRODUCTS_A172316"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        grd_product.DataSource = mydatatable

    End Sub

    Private Sub clear_fields()
        txt_id.Text = ""
        txt_name.Text = ""
        txt_price.Text = ""
        txt_brand.Text = ""
        txt_color.Text = ""
        txt_type.Text = ""
        txt_quantity.Text = ""

    End Sub

    Private Sub get_current_id()
        Dim current_row As Integer = grd_product.CurrentRow.Index

        current_id = grd_product(0, current_row).Value

        txt_id.Text = current_id
        txt_name.Text = grd_product(1, current_row).Value
        txt_price.Text = grd_product(2, current_row).Value
        txt_brand.Text = grd_product(3, current_row).Value
        txt_color.Text = grd_product(4, current_row).Value
        txt_type.Text = grd_product(5, current_row).Value
        txt_quantity.Text = grd_product(6, current_row).Value
    End Sub

    Private Sub grd_product_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_product.CellClick
        get_current_id()

    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        run_sql_command("UPDATE TBL_PRODUCTS_A172316 SET FLD_PRODUCT_NAME='" & txt_name.Text & "'WHERE FLD_PRODUCT_ID='" & current_id & "'")

        run_sql_command("UPDATE TBL_STUDENTS_A172316 SET FLD_PRICE='" & txt_price.Text & "'WHERE FLD_PRODUCT_ID='" & current_id & "'")

        run_sql_command("UPDATE TBL_PRODUCTS_A172316 SET FLD_BRAND='" & txt_brand.Text & "'WHERE FLD_PRODUCT_ID='" & current_id & "'")

        run_sql_command("UPDATE TBL_PRODUCTS_A172316 SET FLD_COLOR='" & txt_color.Text & "'WHERE FLD_PRODUCT_ID='" & current_id & "'")

        run_sql_command("UPDATE TBL_PRODUCTS_A172316 SET FLD_TYPE='" & txt_type.Text & "'WHERE FLD_PRODUCT_ID='" & current_id & "'")

        run_sql_command("UPDATE TBL_PRODUCTS_A172316 SET FLD_QUANTITY='" & txt_quantity.Text & "'WHERE FLD_PRODUCT_ID='" & current_id & "'")

        Beep()
        MsgBox("You have successfully updated the product """ & current_id & """.")

        refresh_grid()
        clear_fields()
        get_current_id()

    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim delete_confirmation = MsgBox("Are you sure you would like to delete the product """ & current_id & """?", MsgBoxStyle.YesNo)

        If delete_confirmation = MsgBoxResult.Yes Then

            run_sql_command("DELETE FROM TBL_PRODUCTS_A172316 WHERE FLD_PRODUCT_ID = '" & current_id & "'")
            My.Computer.FileSystem.DeleteFile("pictures\" & txt_id.Text & ".jpg")

            Beep()
            MsgBox("The product """ & current_id & """ has been successfully deleted.")

            refresh_grid()
            clear_fields()
            get_current_id()

        End If
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_mainmenu_a172316.Show()
        Me.Hide()

    End Sub
End Class