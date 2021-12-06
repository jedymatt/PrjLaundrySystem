<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCustomer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtCustomerId = New System.Windows.Forms.TextBox()
        Me.TxtFullname = New System.Windows.Forms.TextBox()
        Me.dpBirthdate = New System.Windows.Forms.DateTimePicker()
        Me.CmbGender = New System.Windows.Forms.ComboBox()
        Me.TxtAddress = New System.Windows.Forms.TextBox()
        Me.TxtContact = New System.Windows.Forms.TextBox()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(97, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Customer Id"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(119, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Fullname"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(119, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Birthdate"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(100, 332)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Contact No."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(125, 214)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Address"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(130, 164)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Gender"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(82, 386)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(111, 20)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Email Address"
        '
        'TxtCustomerId
        '
        Me.TxtCustomerId.Location = New System.Drawing.Point(238, 37)
        Me.TxtCustomerId.Name = "TxtCustomerId"
        Me.TxtCustomerId.Size = New System.Drawing.Size(386, 26)
        Me.TxtCustomerId.TabIndex = 7
        '
        'TxtFullname
        '
        Me.TxtFullname.Location = New System.Drawing.Point(238, 77)
        Me.TxtFullname.Name = "TxtFullname"
        Me.TxtFullname.Size = New System.Drawing.Size(386, 26)
        Me.TxtFullname.TabIndex = 8
        '
        'dpBirthdate
        '
        Me.dpBirthdate.Checked = False
        Me.dpBirthdate.CustomFormat = ""
        Me.dpBirthdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dpBirthdate.Location = New System.Drawing.Point(238, 116)
        Me.dpBirthdate.Name = "dpBirthdate"
        Me.dpBirthdate.Size = New System.Drawing.Size(386, 26)
        Me.dpBirthdate.TabIndex = 9
        '
        'CmbGender
        '
        Me.CmbGender.FormattingEnabled = True
        Me.CmbGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.CmbGender.Location = New System.Drawing.Point(238, 164)
        Me.CmbGender.Name = "CmbGender"
        Me.CmbGender.Size = New System.Drawing.Size(386, 28)
        Me.CmbGender.TabIndex = 10
        '
        'TxtAddress
        '
        Me.TxtAddress.Location = New System.Drawing.Point(238, 211)
        Me.TxtAddress.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtAddress.Multiline = True
        Me.TxtAddress.Name = "TxtAddress"
        Me.TxtAddress.Size = New System.Drawing.Size(386, 93)
        Me.TxtAddress.TabIndex = 17
        '
        'TxtContact
        '
        Me.TxtContact.Location = New System.Drawing.Point(238, 329)
        Me.TxtContact.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtContact.Name = "TxtContact"
        Me.TxtContact.Size = New System.Drawing.Size(386, 26)
        Me.TxtContact.TabIndex = 18
        '
        'TxtEmail
        '
        Me.TxtEmail.Location = New System.Drawing.Point(238, 380)
        Me.TxtEmail.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(386, 26)
        Me.TxtEmail.TabIndex = 19
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(238, 431)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(143, 33)
        Me.BtnSave.TabIndex = 20
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Location = New System.Drawing.Point(238, 432)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(116, 32)
        Me.BtnUpdate.TabIndex = 21
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'BtnClose
        '
        Me.BtnClose.Location = New System.Drawing.Point(505, 432)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(98, 32)
        Me.BtnClose.TabIndex = 22
        Me.BtnClose.Text = "Close"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'FrmCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 519)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.TxtEmail)
        Me.Controls.Add(Me.TxtContact)
        Me.Controls.Add(Me.TxtAddress)
        Me.Controls.Add(Me.CmbGender)
        Me.Controls.Add(Me.dpBirthdate)
        Me.Controls.Add(Me.TxtFullname)
        Me.Controls.Add(Me.TxtCustomerId)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmCustomer"
        Me.Text = "Customer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtCustomerId As TextBox
    Friend WithEvents TxtFullname As TextBox
    Friend WithEvents dpBirthdate As DateTimePicker
    Friend WithEvents CmbGender As ComboBox
    Friend WithEvents TxtAddress As TextBox
    Friend WithEvents TxtContact As TextBox
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents BtnSave As Button
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents BtnClose As Button
End Class
