Imports MySql.Data.MySqlClient

Public Class FrmCustomer
    Property Rid As Integer

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Try


            With Cmd
                .Parameters.Clear()
                .CommandText = "prcInsertCustomer"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@v_custid", TxtCustomerId.Text)
                .Parameters.AddWithValue("@v_fullname", TxtFullname.Text)
                .Parameters.AddWithValue("@v_bdate", Format(dpBirthdate.Value, "yyyy-MM-dd"))
                .Parameters.AddWithValue("@v_gender", CmbGender.Text)
                .Parameters.AddWithValue("@v_contactno", TxtContact.Text)
                .Parameters.AddWithValue("@v_address", TxtAddress.Text)
                .Parameters.AddWithValue("@v_emailadd", TxtEmail.Text)
                .BeginExecuteNonQuery()
            End With
            MessageBox.Show("Records Successfully Saved", "Save Record", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Dispose()
        BtnUpdate.Visible = False
        BtnSave.Visible = True
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Try
            With Cmd
                .Parameters.Clear()
                .CommandText = "prcUpdateCustomer"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@cid", Rid)
                .Parameters.AddWithValue("@v_cust_id", TxtCustomerId.Text)
                .Parameters.AddWithValue("@v_fullname", TxtFullname.Text)
                .Parameters.AddWithValue("@v_birthdate", Format(dpBirthdate.Value, "yyyy-MM-dd"))
                .Parameters.AddWithValue("@v_gender", CmbGender.Text)
                .Parameters.AddWithValue("@v_contactno", TxtContact.Text)
                .Parameters.AddWithValue("@v_address", TxtAddress.Text)
                .Parameters.AddWithValue("@v_email", TxtEmail.Text)
                .ExecuteNonQuery()
            End With
            MessageBox.Show("Records Successfully Updated", "Update Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Dispose()
            clearText()

        Catch ex As Exception
            MessageBox.Show("" + ex.Message)
        End Try
    End Sub
    Private Sub clearText()
        TxtCustomerId.Clear()
        TxtFullname.Clear()
        CmbGender.SelectedIndex = -1
        TxtContact.Clear()
        TxtAddress.Clear()
        TxtEmail.Clear()
    End Sub
End Class
