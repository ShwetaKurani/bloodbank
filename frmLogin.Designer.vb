<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Me.label1 = New System.Windows.Forms.Label
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnReset = New System.Windows.Forms.Button
        Me.btnLogin = New System.Windows.Forms.Button
        Me.lblPassword = New System.Windows.Forms.Label
        Me.lblUsername = New System.Windows.Forms.Label
        Me.txtPassword = New System.Windows.Forms.TextBox
        Me.txtUsername = New System.Windows.Forms.TextBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Verdana", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.label1.Location = New System.Drawing.Point(565, 106)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(76, 25)
        Me.label1.TabIndex = 33
        Me.label1.Text = "Login"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(665, 346)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(146, 44)
        Me.btnClose.TabIndex = 30
        Me.btnClose.Text = "cancel"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(514, 346)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(145, 44)
        Me.btnReset.TabIndex = 29
        Me.btnReset.Text = "RESET"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(353, 346)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(155, 44)
        Me.btnLogin.TabIndex = 28
        Me.btnLogin.Text = "submit"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(444, 265)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(53, 13)
        Me.lblPassword.TabIndex = 32
        Me.lblPassword.Text = "Password"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Location = New System.Drawing.Point(442, 184)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(55, 13)
        Me.lblUsername.TabIndex = 31
        Me.lblUsername.Text = "Username"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(665, 265)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(136, 20)
        Me.txtPassword.TabIndex = 27
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(665, 195)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(136, 20)
        Me.txtUsername.TabIndex = 26
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Blood_Bank_Management_System.My.Resources.Resources.bloodbank
        Me.PictureBox1.Location = New System.Drawing.Point(22, 157)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(288, 295)
        Me.PictureBox1.TabIndex = 34
        Me.PictureBox1.TabStop = False
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Blood_Bank_Management_System.My.Resources.Resources.a
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(928, 563)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents btnClose As System.Windows.Forms.Button
    Private WithEvents btnReset As System.Windows.Forms.Button
    Private WithEvents btnLogin As System.Windows.Forms.Button
    Private WithEvents lblPassword As System.Windows.Forms.Label
    Private WithEvents lblUsername As System.Windows.Forms.Label
    Private WithEvents txtPassword As System.Windows.Forms.TextBox
    Private WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
