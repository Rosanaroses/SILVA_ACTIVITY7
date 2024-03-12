<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        LblUsername = New Label()
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        lblPassword = New Label()
        btnlogin = New Button()
        llblRegisternow = New LinkLabel()
        llblforgotpassword = New LinkLabel()
        SuspendLayout()
        ' 
        ' LblUsername
        ' 
        LblUsername.AutoSize = True
        LblUsername.Location = New Point(329, 29)
        LblUsername.Name = "LblUsername"
        LblUsername.Size = New Size(60, 15)
        LblUsername.TabIndex = 0
        LblUsername.Text = "Username"
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(314, 56)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(100, 23)
        txtUsername.TabIndex = 1
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(314, 142)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(100, 23)
        txtPassword.TabIndex = 2
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Location = New Point(332, 104)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(57, 15)
        lblPassword.TabIndex = 3
        lblPassword.Text = "Password"
        ' 
        ' btnlogin
        ' 
        btnlogin.Location = New Point(326, 184)
        btnlogin.Name = "btnlogin"
        btnlogin.Size = New Size(75, 23)
        btnlogin.TabIndex = 4
        btnlogin.Text = "Login"
        btnlogin.UseVisualStyleBackColor = True
        ' 
        ' llblRegisternow
        ' 
        llblRegisternow.AutoSize = True
        llblRegisternow.Location = New Point(326, 229)
        llblRegisternow.Name = "llblRegisternow"
        llblRegisternow.Size = New Size(77, 15)
        llblRegisternow.TabIndex = 5
        llblRegisternow.TabStop = True
        llblRegisternow.Text = "Register Now"
        ' 
        ' llblforgotpassword
        ' 
        llblforgotpassword.AutoSize = True
        llblforgotpassword.Location = New Point(326, 268)
        llblforgotpassword.Name = "llblforgotpassword"
        llblforgotpassword.Size = New Size(95, 15)
        llblforgotpassword.TabIndex = 6
        llblforgotpassword.TabStop = True
        llblforgotpassword.Text = "Forgot Password"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(llblforgotpassword)
        Controls.Add(llblRegisternow)
        Controls.Add(btnlogin)
        Controls.Add(lblPassword)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Controls.Add(LblUsername)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LblUsername As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents btnlogin As Button
    Friend WithEvents llblRegisternow As LinkLabel
    Friend WithEvents llblforgotpassword As LinkLabel
End Class
