Public Class FrmGarment
    Property Rid As Integer

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Try
            With Cmd
                .Parameters.Clear()
                .CommandText = "prcInsertGarment"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@v_description", TxtDescription.Text)
                .BeginExecuteNonQuery()
            End With
            MessageBox.Show("Records Successfully Saved", "Save Record", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Try
            With Cmd
                .Parameters.Clear()
                .CommandText = "prcUpdateGarment"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("v_id", Rid)
                .Parameters.AddWithValue("v_description", TxtDescription.Text)
                .BeginExecuteNonQuery()
            End With
            MessageBox.Show("Records Successfully Updated", "Update Record", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class