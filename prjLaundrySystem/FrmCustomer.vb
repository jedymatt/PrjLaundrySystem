Imports MySql.Data.MySqlClient

Public Class FrmCustomer
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Try
            Dim cmd = New MySqlCommand With {
                .Connection = GetConnection()
            }
            Dim conn = GetConnection()

            With Cmd
                .Connection = conn
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
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub
End Class
