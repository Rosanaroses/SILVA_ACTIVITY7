<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmregister
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        lblFirstname = New Label()
        lblmiddlename = New Label()
        lbllastname = New Label()
        txtfirstname = New TextBox()
        txtlastname = New TextBox()
        txtmiddlename = New TextBox()
        DateTimePicker1 = New DateTimePicker()
        lblbirthdate = New Label()
        lblusername = New Label()
        lblpassword = New Label()
        txtusername = New TextBox()
        txtpassword = New TextBox()
        LinkLabel1 = New LinkLabel()
        btnsave = New Button()
        SuspendLayout()
        ' 
        ' lblFirstname
        ' 
        lblFirstname.AutoSize = True
        lblFirstname.Location = New Point(12, 31)
        lblFirstname.Name = "lblFirstname"
        lblFirstname.Size = New Size(64, 15)
        lblFirstname.TabIndex = 0
        lblFirstname.Text = "First Name"
        ' 
        ' lblmiddlename
        ' 
        lblmiddlename.AutoSize = True
        lblmiddlename.Location = New Point(156, 31)
        lblmiddlename.Name = "lblmiddlename"
        lblmiddlename.Size = New Size(79, 15)
        lblmiddlename.TabIndex = 1
        lblmiddlename.Text = "Middle Name"
        ' 
        ' lbllastname
        ' 
        lbllastname.AutoSize = True
        lbllastname.Location = New Point(322, 31)
        lbllastname.Name = "lbllastname"
        lbllastname.Size = New Size(63, 15)
        lbllastname.TabIndex = 2
        lbllastname.Text = "Last Name"
        ' 
        ' txtfirstname
        ' 
        txtfirstname.Location = New Point(12, 49)
        txtfirstname.Name = "txtfirstname"
        txtfirstname.Size = New Size(100, 23)
        txtfirstname.TabIndex = 3
        ' 
        ' txtlastname
        ' 
        txtlastname.Location = New Point(322, 49)
        txtlastname.Name = "txtlastname"
        txtlastname.Size = New Size(100, 23)
        txtlastname.TabIndex = 5
        ' 
        ' txtmiddlename
        ' 
        txtmiddlename.Location = New Point(156, 49)
        txtmiddlename.Name = "txtmiddlename"
        txtmiddlename.Size = New Size(100, 23)
        txtmiddlename.TabIndex = 6
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(437, 49)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(200, 23)
        DateTimePicker1.TabIndex = 7
        ' 
        ' lblbirthdate
        ' 
        lblbirthdate.AutoSize = True
        lblbirthdate.Location = New Point(469, 31)
        lblbirthdate.Name = "lblbirthdate"
        lblbirthdate.Size = New Size(56, 15)
        lblbirthdate.TabIndex = 8
        lblbirthdate.Text = "BirthDate"
        ' 
        ' lblusername
        ' 
        lblusername.AutoSize = True
        lblusername.Location = New Point(23, 115)
        lblusername.Name = "lblusername"
        lblusername.Size = New Size(68, 15)
        lblusername.TabIndex = 9
        lblusername.Text = "USERNAME"
        ' 
        ' lblpassword
        ' 
        lblpassword.AutoSize = True
        lblpassword.Location = New Point(218, 115)
        lblpassword.Name = "lblpassword"
        lblpassword.Size = New Size(68, 15)
        lblpassword.TabIndex = 10
        lblpassword.Text = "PASSWORD"
        ' 
        ' txtusername
        ' 
        txtusername.Location = New Point(23, 142)
        txtusername.Name = "txtusername"
        txtusername.Size = New Size(100, 23)
        txtusername.TabIndex = 11
        ' 
        ' txtpassword
        ' 
        txtpassword.Location = New Point(218, 142)
        txtpassword.Name = "txtpassword"
        txtpassword.Size = New Size(100, 23)
        txtpassword.TabIndex = 12
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Location = New Point(112, 245)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(203, 15)
        LinkLabel1.TabIndex = 13
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Already have an account? Login Here"
        ' 
        ' btnsave
        ' 
        btnsave.Location = New Point(30, 198)
        btnsave.Name = "btnsave"
        btnsave.Size = New Size(75, 23)
        btnsave.TabIndex = 14
        btnsave.Text = "Save"
        btnsave.UseVisualStyleBackColor = True
        ' 
        ' frmregister
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnsave)
        Controls.Add(LinkLabel1)
        Controls.Add(txtpassword)
        Controls.Add(txtusername)
        Controls.Add(lblpassword)
        Controls.Add(lblusername)
        Controls.Add(lblbirthdate)
        Controls.Add(DateTimePicker1)
        Controls.Add(txtmiddlename)
        Controls.Add(txtlastname)
        Controls.Add(txtfirstname)
        Controls.Add(lbllastname)
        Controls.Add(lblmiddlename)
        Controls.Add(lblFirstname)
        Name = "frmregister"
        Text = "frmregister"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblFirstname As Label
    Friend WithEvents lblmiddlename As Label
    Friend WithEvents lbllastname As Label
    Friend WithEvents txtfirstname As TextBox
    Friend WithEvents txtlastname As TextBox
    Friend WithEvents txtmiddlename As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents lblbirthdate As Label
    Friend WithEvents lblusername As Label
    Friend WithEvents lblpassword As Label
    Friend WithEvents txtusername As TextBox
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents btnsave As Button
End Class
