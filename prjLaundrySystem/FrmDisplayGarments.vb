Imports MySql.Data.MySqlClient

Public Class FrmDisplayGarments
    Private Sub PrcDisplayAllGarments()
        Dim sqlLaundryAdapter = New MySqlDataAdapter
        Dim datLaundry = New DataTable
        Try
            With Cmd
                .Parameters.Clear()
                .CommandText = "prcDisplayGarment"
                .CommandType = CommandType.StoredProcedure
                sqlLaundryAdapter.SelectCommand = Cmd
                datLaundry.Clear()
                sqlLaundryAdapter.Fill(datLaundry)
                lblTotalRecord.Text = "Total Record: " & datLaundry.Rows.Count.ToString

                If datLaundry.Rows.Count > 0 Then
                    DgvGarments.RowCount = datLaundry.Rows.Count
                    Dim row As Integer = 0
                    While Not datLaundry.Rows.Count - 1 < row
                        With DgvGarments
                            .Rows(row).Cells(0).Value = datLaundry.Rows(row).Item("id").ToString
                            .Rows(row).Cells(1).Value = datLaundry.Rows(row).Item("description").ToString

                        End With
                        row += 1
                    End While
                Else
                    MessageBox.Show("No record available", "Record Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End With
            sqlLaundryAdapter.Dispose()
            datLaundry.Dispose()
        Catch ex As Exception
            MessageBox.Show("" + ex.Message)
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        With FrmGarment
            .TxtDescription.Focus()
            .BtnUpdate.Visible = False
            .BtnSave.Visible = True
            .ShowDialog()

        End With
        PrcDisplayAllGarments()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub

    Private Sub FrmDisplayGarments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PrcDisplayAllGarments()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        With FrmGarment
            .TxtDescription.Text = DgvGarments.CurrentRow.Cells(1).Value
            .Rid = CInt(DgvGarments.CurrentRow.Cells(0).Value)
            .BtnUpdate.Visible = True
            .BtnSave.Visible = False
            .ShowDialog()
        End With
        PrcDisplayAllGarments()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            With Cmd
                .Parameters.Clear()
                .CommandText = "prcDeleteGarment"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@v_id", CInt(DgvGarments.CurrentRow.Cells(0).Value))
                .ExecuteNonQuery()
            End With
            MessageBox.Show("Record Successfully Deleted")
            PrcDisplayAllGarments()
        Catch ex As Exception
            MessageBox.Show("" + ex.Message)
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If CheckBox1.Checked = True Then
            prcDisplayAutoCompleteGarment(cmbSearchBy.Text, txtSearch.Text)
        End If
    End Sub

    Private Sub PrcDisplayAutoCompleteGarment(v_searchtype As String, v_search As String)
        Dim sqlLaundryAdapter = New MySqlDataAdapter
        Dim datLaundry = New DataTable
        Try
            With Cmd
                .Parameters.Clear()
                .CommandText = "prcDisplayGarmentFilter"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@v_searchtype", v_searchtype)
                .Parameters.AddWithValue("@v_search", v_search)
                sqlLaundryAdapter.SelectCommand = Cmd
                datLaundry.Clear()
                sqlLaundryAdapter.Fill(datLaundry)
                If datLaundry.Rows.Count > 0 Then
                    DgvGarments.RowCount = datLaundry.Rows.Count
                    Dim row = 0
                    While Not datLaundry.Rows.Count - 1 < row
                        With DgvGarments
                            .Rows(row).Cells(0).Value = datLaundry.Rows(row).Item("id").ToString
                            .Rows(row).Cells(1).Value = datLaundry.Rows(row).Item("description").ToString

                        End With
                        row = row + 1
                    End While
                Else
                    MessageBox.Show("No record available", "Record Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End With
            sqlLaundryAdapter.Dispose()
            datLaundry.Dispose()
        Catch ex As Exception
            MessageBox.Show("" + ex.Message)
        End Try
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        btnSearch.Enabled = Not CheckBox1.Checked
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        prcDisplayAutoCompleteGarment(cmbSearchBy.Text, txtSearch.Text)
    End Sub
End Class