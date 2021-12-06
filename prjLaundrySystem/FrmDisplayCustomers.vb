Imports MySql.Data.MySqlClient

Public Class FrmDisplayCustomers

    Private Sub prcDisplayAllCustomer()
        Dim sqlLaundryAdapter = New MySqlDataAdapter
        Dim datLaundry = New DataTable
        Try
            With Cmd
                .Parameters.Clear()
                .CommandText = "prcDisplayCustomer"
                .CommandType = CommandType.StoredProcedure
                sqlLaundryAdapter.SelectCommand = Cmd
                datLaundry.Clear()
                sqlLaundryAdapter.Fill(datLaundry)
                lblTotalRecord.Text = "Total Record: " & datLaundry.Rows.Count.ToString



                If datLaundry.Rows.Count > 0 Then
                    dgvCustomer.RowCount = datLaundry.Rows.Count
                    Dim row As Integer = 0
                    While Not datLaundry.Rows.Count - 1 < row
                        With dgvCustomer
                            .Rows(row).Cells(0).Value = datLaundry.Rows(row).Item("id").ToString
                            .Rows(row).Cells(1).Value = datLaundry.Rows(row).Item("cust_id").ToString
                            .Rows(row).Cells(2).Value = datLaundry.Rows(row).Item("fullname").ToString
                            .Rows(row).Cells(3).Value = datLaundry.Rows(row).Item("address").ToString
                            .Rows(row).Cells(4).Value = datLaundry.Rows(row).Item("contactno").ToString
                            .Rows(row).Cells(5).Value = datLaundry.Rows(row).Item("birthdate").ToString
                            .Rows(row).Cells(6).Value = datLaundry.Rows(row).Item("gender").ToString
                            .Rows(row).Cells(7).Value = datLaundry.Rows(row).Item("email").ToString
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



    Private Sub FrmDisplayCustomers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        prcDisplayAllCustomer()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        With FrmCustomer
            .TxtCustomerId.Focus()
            .BtnUpdate.Visible = False
            .BtnSave.Visible = True
            .ShowDialog()


        End With
        prcDisplayAllCustomer()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            With Cmd
                .Parameters.Clear()
                .CommandText = "prcDeleteCustomer"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@cid", CInt(dgvCustomer.CurrentRow.Cells(0).Value))
                .ExecuteNonQuery()
            End With
            MessageBox.Show("Record Successfully Deleted")
            prcDisplayAllCustomer()
        Catch ex As Exception
            MessageBox.Show("" + ex.Message)
        End Try
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        With FrmCustomer
            .TxtCustomerId.Text = dgvCustomer.CurrentRow.Cells(1).Value
            .TxtFullname.Text = dgvCustomer.CurrentRow.Cells(2).Value
            .TxtAddress.Text = dgvCustomer.CurrentRow.Cells(3).Value
            .TxtContact.Text = dgvCustomer.CurrentRow.Cells(4).Value
            .dpBirthdate.Value = dgvCustomer.CurrentRow.Cells(5).Value
            .CmbGender.Text = dgvCustomer.CurrentRow.Cells(6).Value
            .TxtEmail.Text = dgvCustomer.CurrentRow.Cells(7).Value
            .Rid = CInt(dgvCustomer.CurrentRow.Cells(0).Value)
            .btnUpdate.Visible = True
            .BtnSave.Visible = False
            .ShowDialog()
        End With
        prcDisplayAllCustomer()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        prcDisplayAutoCompleteCustomer(cmbSearchBy.Text, txtSearch.Text)
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            btnSearch.Enabled = False
        Else
            btnSearch.Enabled = True
        End If

    End Sub

    Private Sub prcDisplayAutoCompleteCustomer(ByVal v_searchtype As String, ByVal v_search As String)
        Dim sqlLaundryAdapter = New MySqlDataAdapter
        Dim datLaundry = New DataTable
        Try
            With Cmd
                .Parameters.Clear()
                .CommandText = "prcDisplayCustomerFilter"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@v_searchtype", v_searchtype)
                .Parameters.AddWithValue("@v_search", v_search)
                sqlLaundryAdapter.SelectCommand = Cmd
                datLaundry.Clear()
                sqlLaundryAdapter.Fill(datLaundry)
                If datLaundry.Rows.Count > 0 Then
                    dgvCustomer.RowCount = datLaundry.Rows.Count
                    Dim row = 0
                    While Not datLaundry.Rows.Count - 1 < row
                        With dgvCustomer
                            .Rows(row).Cells(0).Value = datLaundry.Rows(row).Item("id").ToString
                            .Rows(row).Cells(1).Value = datLaundry.Rows(row).Item("cust_id").ToString
                            .Rows(row).Cells(2).Value = datLaundry.Rows(row).Item("fullname").ToString
                            .Rows(row).Cells(3).Value = datLaundry.Rows(row).Item("address").ToString
                            .Rows(row).Cells(4).Value = datLaundry.Rows(row).Item("contactno").ToString
                            .Rows(row).Cells(5).Value = datLaundry.Rows(row).Item("birthdate").ToString
                            .Rows(row).Cells(6).Value = datLaundry.Rows(row).Item("gender").ToString
                            .Rows(row).Cells(7).Value = datLaundry.Rows(row).Item("email").ToString
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

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If CheckBox1.Checked = True Then
            prcDisplayAutoCompleteCustomer(cmbSearchBy.Text, txtSearch.Text)
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub

End Class