<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormHome
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
        Me.TableLayoutContainer = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblWelcome = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.BtnLogout = New System.Windows.Forms.Button()
        Me.GroupBoxActions = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnIssueBook = New System.Windows.Forms.Button()
        Me.BtnBooks = New System.Windows.Forms.Button()
        Me.BtnMembers = New System.Windows.Forms.Button()
        Me.BtnReceiveBook = New System.Windows.Forms.Button()
        Me.TableLayoutContainer.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.GroupBoxActions.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutContainer
        '
        Me.TableLayoutContainer.ColumnCount = 3
        Me.TableLayoutContainer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutContainer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutContainer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutContainer.Controls.Add(Me.TableLayoutPanel1, 1, 1)
        Me.TableLayoutContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutContainer.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutContainer.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutContainer.Name = "TableLayoutContainer"
        Me.TableLayoutContainer.RowCount = 3
        Me.TableLayoutContainer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutContainer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutContainer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutContainer.Size = New System.Drawing.Size(784, 561)
        Me.TableLayoutContainer.TabIndex = 1
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBoxActions, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(20, 20)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(744, 521)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.FlowLayoutPanel1, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.FlowLayoutPanel2, 1, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(744, 96)
        Me.TableLayoutPanel3.TabIndex = 2
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.Label1)
        Me.FlowLayoutPanel1.Controls.Add(Me.LblWelcome)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(372, 96)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(303, 32)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Library Management System"
        '
        'LblWelcome
        '
        Me.LblWelcome.AutoSize = True
        Me.LblWelcome.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblWelcome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.LblWelcome.Location = New System.Drawing.Point(3, 32)
        Me.LblWelcome.Name = "LblWelcome"
        Me.LblWelcome.Size = New System.Drawing.Size(108, 21)
        Me.LblWelcome.TabIndex = 2
        Me.LblWelcome.Text = "Welcome Kabir"
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.BtnLogout)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(372, 0)
        Me.FlowLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(372, 96)
        Me.FlowLayoutPanel2.TabIndex = 1
        '
        'BtnLogout
        '
        Me.BtnLogout.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BtnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnLogout.FlatAppearance.BorderSize = 0
        Me.BtnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLogout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.BtnLogout.Location = New System.Drawing.Point(294, 3)
        Me.BtnLogout.Name = "BtnLogout"
        Me.BtnLogout.Size = New System.Drawing.Size(75, 23)
        Me.BtnLogout.TabIndex = 0
        Me.BtnLogout.Text = "Logout"
        Me.BtnLogout.UseVisualStyleBackColor = True
        '
        'GroupBoxActions
        '
        Me.GroupBoxActions.BackColor = System.Drawing.Color.Transparent
        Me.GroupBoxActions.Controls.Add(Me.TableLayoutPanel2)
        Me.GroupBoxActions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBoxActions.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBoxActions.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxActions.ForeColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.GroupBoxActions.Location = New System.Drawing.Point(3, 119)
        Me.GroupBoxActions.Name = "GroupBoxActions"
        Me.GroupBoxActions.Size = New System.Drawing.Size(738, 282)
        Me.GroupBoxActions.TabIndex = 1
        Me.GroupBoxActions.TabStop = False
        Me.GroupBoxActions.Text = "Actions"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 5
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.BtnIssueBook, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.BtnBooks, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.BtnMembers, 3, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.BtnReceiveBook, 3, 3)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 29)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(5)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 5
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(732, 250)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'BtnIssueBook
        '
        Me.BtnIssueBook.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.BtnIssueBook.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnIssueBook.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnIssueBook.FlatAppearance.BorderSize = 0
        Me.BtnIssueBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnIssueBook.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnIssueBook.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnIssueBook.Location = New System.Drawing.Point(13, 133)
        Me.BtnIssueBook.Name = "BtnIssueBook"
        Me.BtnIssueBook.Size = New System.Drawing.Size(345, 104)
        Me.BtnIssueBook.TabIndex = 5
        Me.BtnIssueBook.Text = "Issue Book"
        Me.BtnIssueBook.UseVisualStyleBackColor = False
        '
        'BtnBooks
        '
        Me.BtnBooks.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.BtnBooks.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBooks.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnBooks.FlatAppearance.BorderSize = 0
        Me.BtnBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBooks.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBooks.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnBooks.Location = New System.Drawing.Point(13, 13)
        Me.BtnBooks.Name = "BtnBooks"
        Me.BtnBooks.Size = New System.Drawing.Size(345, 104)
        Me.BtnBooks.TabIndex = 4
        Me.BtnBooks.Text = "Manage Books"
        Me.BtnBooks.UseVisualStyleBackColor = False
        '
        'BtnMembers
        '
        Me.BtnMembers.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.BtnMembers.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnMembers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnMembers.FlatAppearance.BorderSize = 0
        Me.BtnMembers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMembers.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMembers.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnMembers.Location = New System.Drawing.Point(374, 13)
        Me.BtnMembers.Name = "BtnMembers"
        Me.BtnMembers.Size = New System.Drawing.Size(345, 104)
        Me.BtnMembers.TabIndex = 3
        Me.BtnMembers.Text = "Manage Members"
        Me.BtnMembers.UseVisualStyleBackColor = False
        '
        'BtnReceiveBook
        '
        Me.BtnReceiveBook.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.BtnReceiveBook.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnReceiveBook.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnReceiveBook.FlatAppearance.BorderSize = 0
        Me.BtnReceiveBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnReceiveBook.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReceiveBook.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnReceiveBook.Location = New System.Drawing.Point(374, 133)
        Me.BtnReceiveBook.Name = "BtnReceiveBook"
        Me.BtnReceiveBook.Size = New System.Drawing.Size(345, 104)
        Me.BtnReceiveBook.TabIndex = 6
        Me.BtnReceiveBook.Text = "Receive Book"
        Me.BtnReceiveBook.UseVisualStyleBackColor = False
        '
        'FormHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.TableLayoutContainer)
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "FormHome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormHome"
        Me.TableLayoutContainer.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.GroupBoxActions.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutContainer As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents GroupBoxActions As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents BtnIssueBook As System.Windows.Forms.Button
    Friend WithEvents BtnBooks As System.Windows.Forms.Button
    Friend WithEvents BtnMembers As System.Windows.Forms.Button
    Friend WithEvents BtnReceiveBook As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LblWelcome As System.Windows.Forms.Label
    Friend WithEvents FlowLayoutPanel2 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents BtnLogout As System.Windows.Forms.Button
End Class
