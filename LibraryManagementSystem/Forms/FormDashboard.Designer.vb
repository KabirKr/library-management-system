<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormDashboard
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
        Me.TableLayoutContainer = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBoxActions = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnIssueBook = New System.Windows.Forms.Button()
        Me.BtnBooks = New System.Windows.Forms.Button()
        Me.BtnMembers = New System.Windows.Forms.Button()
        Me.BtnReceiveBook = New System.Windows.Forms.Button()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnLogout = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LinkAboutFrom = New System.Windows.Forms.LinkLabel()
        Me.TableLayoutContainer.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBoxActions.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutContainer
        '
        Me.TableLayoutContainer.BackColor = System.Drawing.Color.Transparent
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
        Me.TableLayoutContainer.Size = New System.Drawing.Size(1008, 601)
        Me.TableLayoutContainer.TabIndex = 1
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBoxActions, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.LinkAboutFrom, 0, 4)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(20, 20)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(968, 561)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'GroupBoxActions
        '
        Me.GroupBoxActions.BackColor = System.Drawing.Color.Transparent
        Me.GroupBoxActions.Controls.Add(Me.TableLayoutPanel2)
        Me.GroupBoxActions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBoxActions.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBoxActions.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxActions.ForeColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.GroupBoxActions.Location = New System.Drawing.Point(3, 127)
        Me.GroupBoxActions.Name = "GroupBoxActions"
        Me.GroupBoxActions.Size = New System.Drawing.Size(962, 358)
        Me.GroupBoxActions.TabIndex = 1
        Me.GroupBoxActions.TabStop = False
        Me.GroupBoxActions.Text = "Quick Actions"
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
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 39)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(5)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 5
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(956, 316)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'BtnIssueBook
        '
        Me.BtnIssueBook.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.BtnIssueBook.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnIssueBook.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnIssueBook.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.BtnIssueBook.FlatAppearance.BorderSize = 0
        Me.BtnIssueBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnIssueBook.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnIssueBook.ForeColor = System.Drawing.Color.White
        Me.BtnIssueBook.Location = New System.Drawing.Point(13, 166)
        Me.BtnIssueBook.Name = "BtnIssueBook"
        Me.BtnIssueBook.Size = New System.Drawing.Size(457, 137)
        Me.BtnIssueBook.TabIndex = 5
        Me.BtnIssueBook.Text = "ISSUE BOOKS"
        Me.BtnIssueBook.UseVisualStyleBackColor = False
        '
        'BtnBooks
        '
        Me.BtnBooks.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.BtnBooks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnBooks.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBooks.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnBooks.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.BtnBooks.FlatAppearance.BorderSize = 0
        Me.BtnBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBooks.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBooks.ForeColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.BtnBooks.Location = New System.Drawing.Point(13, 13)
        Me.BtnBooks.Name = "BtnBooks"
        Me.BtnBooks.Size = New System.Drawing.Size(457, 137)
        Me.BtnBooks.TabIndex = 4
        Me.BtnBooks.Text = "MANAGE BOOKS"
        Me.BtnBooks.UseVisualStyleBackColor = False
        '
        'BtnMembers
        '
        Me.BtnMembers.BackColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.BtnMembers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnMembers.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnMembers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnMembers.FlatAppearance.BorderSize = 0
        Me.BtnMembers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMembers.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMembers.ForeColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.BtnMembers.Location = New System.Drawing.Point(486, 13)
        Me.BtnMembers.Name = "BtnMembers"
        Me.BtnMembers.Size = New System.Drawing.Size(457, 137)
        Me.BtnMembers.TabIndex = 3
        Me.BtnMembers.Text = "MANAGE MEMBERS"
        Me.BtnMembers.UseVisualStyleBackColor = False
        '
        'BtnReceiveBook
        '
        Me.BtnReceiveBook.BackColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.BtnReceiveBook.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnReceiveBook.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnReceiveBook.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.BtnReceiveBook.FlatAppearance.BorderSize = 0
        Me.BtnReceiveBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnReceiveBook.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReceiveBook.ForeColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.BtnReceiveBook.Location = New System.Drawing.Point(486, 166)
        Me.BtnReceiveBook.Name = "BtnReceiveBook"
        Me.BtnReceiveBook.Size = New System.Drawing.Size(457, 137)
        Me.BtnReceiveBook.TabIndex = 6
        Me.BtnReceiveBook.Text = "RECEIVE BOOKS"
        Me.BtnReceiveBook.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.BtnLogout, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(962, 98)
        Me.TableLayoutPanel3.TabIndex = 2
        '
        'BtnLogout
        '
        Me.BtnLogout.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnLogout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.BtnLogout.FlatAppearance.BorderSize = 2
        Me.BtnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLogout.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.BtnLogout.Location = New System.Drawing.Point(866, 3)
        Me.BtnLogout.Name = "BtnLogout"
        Me.BtnLogout.Size = New System.Drawing.Size(93, 44)
        Me.BtnLogout.TabIndex = 0
        Me.BtnLogout.Text = "LOG OUT"
        Me.BtnLogout.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(321, 47)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "LMS DASHBOARD"
        '
        'LinkAboutFrom
        '
        Me.LinkAboutFrom.AutoSize = True
        Me.LinkAboutFrom.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkAboutFrom.LinkColor = System.Drawing.Color.CornflowerBlue
        Me.LinkAboutFrom.Location = New System.Drawing.Point(3, 508)
        Me.LinkAboutFrom.Name = "LinkAboutFrom"
        Me.LinkAboutFrom.Size = New System.Drawing.Size(52, 21)
        Me.LinkAboutFrom.TabIndex = 3
        Me.LinkAboutFrom.TabStop = True
        Me.LinkAboutFrom.Text = "About"
        '
        'FormDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1008, 601)
        Me.Controls.Add(Me.TableLayoutContainer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1024, 640)
        Me.MinimumSize = New System.Drawing.Size(1024, 640)
        Me.Name = "FormDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard"
        Me.TableLayoutContainer.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.GroupBoxActions.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutContainer As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents GroupBoxActions As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents BtnIssueBook As System.Windows.Forms.Button
    Friend WithEvents BtnMembers As System.Windows.Forms.Button
    Friend WithEvents BtnReceiveBook As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnLogout As Button
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents BtnBooks As Button
    Friend WithEvents LinkAboutFrom As LinkLabel
End Class
