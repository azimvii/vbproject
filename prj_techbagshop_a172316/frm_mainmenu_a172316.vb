Public Class frm_mainmenu_a172316
    Private Sub btn_product_Click(sender As Object, e As EventArgs) Handles btn_product.Click
        frm_product_a172316.Show()
        Me.Hide()
    End Sub

    Private Sub btn_customer_Click(sender As Object, e As EventArgs) Handles btn_customer.Click
        frm_customer_a172316.Show()
        Me.Hide()
    End Sub

    Private Sub btn_staff_Click(sender As Object, e As EventArgs) Handles btn_staff.Click
        frm_staff_a172316.Show()
        Me.Hide()
    End Sub

    Private Sub btn_order_Click(sender As Object, e As EventArgs) Handles btn_order.Click
        frm_order_a172316.Show()
        Me.Hide()
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        End
    End Sub

    Private Sub btn_insertc_Click(sender As Object, e As EventArgs) Handles btn_insertc.Click
        frm_insertcustomer_a172316.Show()
        Me.Hide()

    End Sub

    Private Sub btn_insertp_Click(sender As Object, e As EventArgs) Handles btn_insertp.Click
        frm_insertproduct_a172316.Show()
        Me.Hide()

    End Sub

    Private Sub btn_inserts_Click(sender As Object, e As EventArgs) Handles btn_inserts.Click
        frm_insertstaff_a172316.Show()
        Me.Hide()

    End Sub

    Private Sub btn_catalog_Click(sender As Object, e As EventArgs) Handles btn_catalog.Click
        frm_catalog_a172316.Show()
        Me.Hide()

    End Sub

    Private Sub btn_updatec_Click(sender As Object, e As EventArgs) Handles btn_updatec.Click
        frm_updatecustomer_a172316.Show()
        Me.Hide()

    End Sub

    Private Sub btn_updatep_Click(sender As Object, e As EventArgs) Handles btn_updatep.Click
        frm_updateproduct_a172316.Show()
        Me.Hide()

    End Sub

    Private Sub btn_updates_Click(sender As Object, e As EventArgs) Handles btn_updates.Click
        frm_updatestaff_a172316.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frm_makeorder_a172316.Show()
        Me.Hide()

    End Sub
End Class
