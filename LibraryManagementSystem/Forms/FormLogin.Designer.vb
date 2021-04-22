<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLogin
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
        Me.PanelContainer = New System.Windows.Forms.Panel()
        Me.LblHeading = New System.Windows.Forms.Label()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.BtnLogin = New System.Windows.Forms.Button()
        Me.LblPassword = New System.Windows.Forms.Label()
        Me.LblUsername = New System.Windows.Forms.Label()
        Me.TextBoxPassword = New System.Windows.Forms.TextBox()
        Me.TextBoxUsername = New System.Windows.Forms.TextBox()
        Me.PanelContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelContainer
        '
        Me.PanelContainer.BackColor = System.Drawing.Color.Transparent
        Me.PanelContainer.Controls.Add(Me.LblHeading)
        Me.PanelContainer.Controls.Add(Me.BtnExit)
        Me.PanelContainer.Controls.Add(Me.BtnLogin)
        Me.PanelContainer.Controls.Add(Me.LblPassword)
        Me.PanelContainer.Controls.Add(Me.LblUsername)
        Me.PanelContainer.Controls.Add(Me.TextBoxPassword)
        Me.PanelContainer.Controls.Add(Me.TextBoxUsername)
        Me.PanelContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContainer.Location = New System.Drawing.Point(0, 0)
        Me.PanelContainer.Margin = New System.Windows.Forms.Padding(0)
        Me.PanelContainer.Name = "PanelContainer"
        Me.PanelContainer.Size = New System.Drawing.Size(784, 561)
        Me.PanelContainer.TabIndex = 0
        '
        'LblHeading
        '
        Me.LblHeading.AutoSize = True
        Me.LblHeading.Font = New System.Drawing.Font("Segoe UI Light", 34.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHeading.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.LblHeading.Location = New System.Drawing.Point(114, 65)
        Me.LblHeading.Name = "LblHeading"
        Me.LblHeading.Size = New System.Drawing.Size(581, 62)
        Me.LblHeading.TabIndex = 0
        Me.LblHeading.Text = "Library Management System"
        '
        'BtnExit
        '
        Me.BtnExit.BackColor = System.Drawing.Color.Transparent
        Me.BtnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.BtnExit.FlatAppearance.BorderSize = 2
        Me.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExit.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.BtnExit.Location = New System.Drawing.Point(344, 367)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(124, 49)
        Me.BtnExit.TabIndex = 6
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = False
        '
        'BtnLogin
        '
        Me.BtnLogin.BackColor = System.Drawing.Color.Transparent
        Me.BtnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnLogin.FlatAppearance.BorderSize = 2
        Me.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLogin.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.BtnLogin.Location = New System.Drawing.Point(183, 367)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(124, 49)
        Me.BtnLogin.TabIndex = 5
        Me.BtnLogin.Text = "Login"
        Me.BtnLogin.UseVisualStyleBackColor = False
        '
        'LblPassword
        '
        Me.LblPassword.AutoSize = True
        Me.LblPassword.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.LblPassword.Location = New System.Drawing.Point(178, 256)
        Me.LblPassword.Name = "LblPassword"
        Me.LblPassword.Size = New System.Drawing.Size(91, 25)
        Me.LblPassword.TabIndex = 3
        Me.LblPassword.Text = "Password"
        '
        'LblUsername
        '
        Me.LblUsername.AutoSize = True
        Me.LblUsername.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.LblUsername.Location = New System.Drawing.Point(178, 176)
        Me.LblUsername.Name = "LblUsername"
        Me.LblUsername.Size = New System.Drawing.Size(98, 25)
        Me.LblUsername.TabIndex = 1
        Me.LblUsername.Text = "Username"
        '
        'TextBoxPassword
        '
        Me.TextBoxPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.TextBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxPassword.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.TextBoxPassword.Location = New System.Drawing.Point(183, 284)
        Me.TextBoxPassword.Name = "TextBoxPassword"
        Me.TextBoxPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxPassword.Size = New System.Drawing.Size(442, 33)
        Me.TextBoxPassword.TabIndex = 4
        '
        'TextBoxUsername
        '
        Me.TextBoxUsername.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.TextBoxUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxUsername.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.TextBoxUsername.Location = New System.Drawing.Point(183, 204)
        Me.TextBoxUsername.Name = "TextBoxUsername"
        Me.TextBoxUsername.Size = New System.Drawing.Size(442, 33)
        Me.TextBoxUsername.TabIndex = 2
        '
        'FormLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.PanelContainer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(800, 600)
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "FormLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.PanelContainer.ResumeLayout(False)
        Me.PanelContainer.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelContainer As System.Windows.Forms.Panel
    Friend WithEvents LblHeading As System.Windows.Forms.Label
    Friend WithEvents BtnExit As System.Windows.Forms.Button
    Friend WithEvents BtnLogin As System.Windows.Forms.Button
    Friend WithEvents LblPassword As System.Windows.Forms.Label
    Friend WithEvents LblUsername As System.Windows.Forms.Label
    Friend WithEvents TextBoxUsername As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxPassword As System.Windows.Forms.TextBox

End Class
