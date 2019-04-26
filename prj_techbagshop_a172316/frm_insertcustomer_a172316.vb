Public Class frm_insertcustomer_a172316
    Private Sub frm_insertcustomer_a172316_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh_grid()

        txt_id.Text = generate_id()
    End Sub

    Private Function generate_id() As String
        Dim lastid As String = run_sql_query("SELECT MAX(FLD_CUSTOMER_ID) AS LASTID FROM TBL_CUSTOMERS_A172316").Rows(0).Item("LASTID")

        'MsgBox(lastid)

        Dim newid As String = "C00" & Mid(lastid, 2) + 1

        Return newid
    End Function

    Private Sub refresh_grid()
        Dim mysql As String = "SELECT * FROM TBL_CUSTOMERS_A172316"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        grd_customer.DataSource = mydatatable

    End Sub

    Private Sub clear_fields()

        txt_id.Text = generate_id()
        txt_name.Text = ""
        txt_phone.Text = ""
    End Sub

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click
        Dim mysql As String = "INSERT INTO TBL_CUSTOMERS_A172316 VALUES ('" & txt_id.Text & "','" & txt_name.Text & "','" & txt_phone.Text & "')"

        Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2)

        Try
            mywriter.Connection.Open()
            mywriter.ExecuteNonQuery()
            mywriter.Connection.Close()

            refresh_grid()
            clear_fields()
            MsgBox("You have successfully enter the customer.")

        Catch ex As Exception

            Beep()
            MsgBox("There is a mistake in the data you entered, as shown below" & vbCrLf & vbCrLf & ex.Message)

            mywriter.Connection.Close()
        End Try
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_mainmenu_a172316.Show()
        Me.Hide()

    End Sub

End Class