<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormBookReturn
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBookReturn))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TableLayoutContainer = New System.Windows.Forms.TableLayoutPanel()
        Me.ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.ToolStripHome = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripDropDownBooks = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ManageBooksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IssueBooksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReceiveBookToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMembers = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLogout = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripAbout = New System.Windows.Forms.ToolStripButton()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.LblBookName = New System.Windows.Forms.Label()
        Me.TextBoxBookId = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblIssuedDate = New System.Windows.Forms.Label()
        Me.TextBoxMemberId = New System.Windows.Forms.TextBox()
        Me.ReceiveBooksDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MemberIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IssueDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReturnDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IssuesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LibraryManagementDataSet = New LibraryManagementSystem.LibraryManagementDataSet()
        Me.PickerIssueDate = New System.Windows.Forms.DateTimePicker()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.LblReturnDate = New System.Windows.Forms.Label()
        Me.PickerReceiveDate = New System.Windows.Forms.DateTimePicker()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnReceive = New System.Windows.Forms.Button()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.IssuesTableAdapter = New LibraryManagementSystem.LibraryManagementDataSetTableAdapters.IssuesTableAdapter()
        Me.TableLayoutContainer.SuspendLayout()
        Me.ToolStrip.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.ReceiveBooksDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IssuesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibraryManagementDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutContainer
        '
        Me.TableLayoutContainer.ColumnCount = 3
        Me.TableLayoutContainer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutContainer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutContainer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutContainer.Controls.Add(Me.ToolStrip, 0, 0)
        Me.TableLayoutContainer.Controls.Add(Me.TableLayoutPanel1, 1, 3)
        Me.TableLayoutContainer.Controls.Add(Me.Label5, 1, 1)
        Me.TableLayoutContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutContainer.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutContainer.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutContainer.Name = "TableLayoutContainer"
        Me.TableLayoutContainer.RowCount = 5
        Me.TableLayoutContainer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutContainer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutContainer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutContainer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.TableLayoutContainer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutContainer.Size = New System.Drawing.Size(1008, 601)
        Me.TableLayoutContainer.TabIndex = 4
        '
        'ToolStrip
        '
        Me.ToolStrip.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.TableLayoutContainer.SetColumnSpan(Me.ToolStrip, 3)
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripHome, Me.ToolStripDropDownBooks, Me.ToolStripMembers, Me.ToolStripLogout, Me.ToolStripAbout})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.Size = New System.Drawing.Size(1008, 25)
        Me.ToolStrip.TabIndex = 0
        Me.ToolStrip.Text = "ToolStrip1"
        '
        'ToolStripHome
        '
        Me.ToolStripHome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripHome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.ToolStripHome.Image = CType(resources.GetObject("ToolStripHome.Image"), System.Drawing.Image)
        Me.ToolStripHome.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripHome.Name = "ToolStripHome"
        Me.ToolStripHome.Size = New System.Drawing.Size(44, 22)
        Me.ToolStripHome.Text = "Home"
        '
        'ToolStripDropDownBooks
        '
        Me.ToolStripDropDownBooks.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripDropDownBooks.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManageBooksToolStripMenuItem, Me.IssueBooksToolStripMenuItem, Me.ReceiveBookToolStripMenuItem})
        Me.ToolStripDropDownBooks.ForeColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.ToolStripDropDownBooks.Image = CType(resources.GetObject("ToolStripDropDownBooks.Image"), System.Drawing.Image)
        Me.ToolStripDropDownBooks.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownBooks.Name = "ToolStripDropDownBooks"
        Me.ToolStripDropDownBooks.Size = New System.Drawing.Size(52, 22)
        Me.ToolStripDropDownBooks.Text = "Books"
        '
        'ManageBooksToolStripMenuItem
        '
        Me.ManageBooksToolStripMenuItem.Name = "ManageBooksToolStripMenuItem"
        Me.ManageBooksToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ManageBooksToolStripMenuItem.Text = "Manage Books"
        '
        'IssueBooksToolStripMenuItem
        '
        Me.IssueBooksToolStripMenuItem.Name = "IssueBooksToolStripMenuItem"
        Me.IssueBooksToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.IssueBooksToolStripMenuItem.Text = "Issue Book"
        '
        'ReceiveBookToolStripMenuItem
        '
        Me.ReceiveBookToolStripMenuItem.Enabled = False
        Me.ReceiveBookToolStripMenuItem.Name = "ReceiveBookToolStripMenuItem"
        Me.ReceiveBookToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ReceiveBookToolStripMenuItem.Text = "Receive Book"
        '
        'ToolStripMembers
        '
        Me.ToolStripMembers.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripMembers.ForeColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.ToolStripMembers.Image = CType(resources.GetObject("ToolStripMembers.Image"), System.Drawing.Image)
        Me.ToolStripMembers.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripMembers.Name = "ToolStripMembers"
        Me.ToolStripMembers.Size = New System.Drawing.Size(61, 22)
        Me.ToolStripMembers.Text = "Members"
        '
        'ToolStripLogout
        '
        Me.ToolStripLogout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLogout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripLogout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.ToolStripLogout.Image = CType(resources.GetObject("ToolStripLogout.Image"), System.Drawing.Image)
        Me.ToolStripLogout.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripLogout.Name = "ToolStripLogout"
        Me.ToolStripLogout.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never
        Me.ToolStripLogout.Size = New System.Drawing.Size(49, 22)
        Me.ToolStripLogout.Text = "Logout"
        '
        'ToolStripAbout
        '
        Me.ToolStripAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripAbout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.ToolStripAbout.Image = CType(resources.GetObject("ToolStripAbout.Image"), System.Drawing.Image)
        Me.ToolStripAbout.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripAbout.Name = "ToolStripAbout"
        Me.ToolStripAbout.Size = New System.Drawing.Size(44, 22)
        Me.ToolStripAbout.Text = "About"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.5!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.5!))
        Me.TableLayoutPanel1.Controls.Add(Me.LblBookName, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBoxBookId, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.LblIssuedDate, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBoxMemberId, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.ReceiveBooksDataGridView, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.PickerIssueDate, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.LblReturnDate, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.PickerReceiveDate, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 0, 5)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(20, 144)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 9
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(968, 436)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'LblBookName
        '
        Me.LblBookName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblBookName.AutoSize = True
        Me.LblBookName.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBookName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.LblBookName.Location = New System.Drawing.Point(3, 0)
        Me.LblBookName.Name = "LblBookName"
        Me.LblBookName.Size = New System.Drawing.Size(119, 25)
        Me.LblBookName.TabIndex = 1
        Me.LblBookName.Text = "Book Id"
        Me.LblBookName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBoxBookId
        '
        Me.TextBoxBookId.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxBookId.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.TextBoxBookId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxBookId.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxBookId.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.TextBoxBookId.Location = New System.Drawing.Point(128, 3)
        Me.TextBoxBookId.Name = "TextBoxBookId"
        Me.TextBoxBookId.Size = New System.Drawing.Size(302, 29)
        Me.TextBoxBookId.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(3, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Member Id"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblIssuedDate
        '
        Me.LblIssuedDate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblIssuedDate.AutoSize = True
        Me.LblIssuedDate.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblIssuedDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.LblIssuedDate.Location = New System.Drawing.Point(3, 78)
        Me.LblIssuedDate.Name = "LblIssuedDate"
        Me.LblIssuedDate.Size = New System.Drawing.Size(119, 25)
        Me.LblIssuedDate.TabIndex = 1
        Me.LblIssuedDate.Text = "Issued Date"
        Me.LblIssuedDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBoxMemberId
        '
        Me.TextBoxMemberId.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxMemberId.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.TextBoxMemberId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxMemberId.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxMemberId.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.TextBoxMemberId.Location = New System.Drawing.Point(128, 42)
        Me.TextBoxMemberId.Name = "TextBoxMemberId"
        Me.TextBoxMemberId.Size = New System.Drawing.Size(302, 29)
        Me.TextBoxMemberId.TabIndex = 2
        '
        'ReceiveBooksDataGridView
        '
        Me.ReceiveBooksDataGridView.AllowUserToAddRows = False
        Me.ReceiveBooksDataGridView.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReceiveBooksDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.ReceiveBooksDataGridView.AutoGenerateColumns = False
        Me.ReceiveBooksDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ReceiveBooksDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.ReceiveBooksDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.ReceiveBooksDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.ReceiveBooksDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(27, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(240, Byte), Integer))
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(3)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(27, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(240, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ReceiveBooksDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.ReceiveBooksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ReceiveBooksDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.BookIdDataGridViewTextBoxColumn, Me.MemberIdDataGridViewTextBoxColumn, Me.IssueDateDataGridViewTextBoxColumn, Me.ReturnDateDataGridViewTextBoxColumn})
        Me.ReceiveBooksDataGridView.Cursor = System.Windows.Forms.Cursors.Default
        Me.ReceiveBooksDataGridView.DataSource = Me.IssuesBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ReceiveBooksDataGridView.DefaultCellStyle = DataGridViewCellStyle3
        Me.ReceiveBooksDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReceiveBooksDataGridView.EnableHeadersVisualStyles = False
        Me.ReceiveBooksDataGridView.Location = New System.Drawing.Point(456, 3)
        Me.ReceiveBooksDataGridView.MultiSelect = False
        Me.ReceiveBooksDataGridView.Name = "ReceiveBooksDataGridView"
        Me.ReceiveBooksDataGridView.ReadOnly = True
        Me.ReceiveBooksDataGridView.RowHeadersVisible = False
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(39, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(240, Byte), Integer))
        DataGridViewCellStyle4.Padding = New System.Windows.Forms.Padding(3)
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(171, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ReceiveBooksDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.TableLayoutPanel1.SetRowSpan(Me.ReceiveBooksDataGridView, 9)
        Me.ReceiveBooksDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ReceiveBooksDataGridView.ShowEditingIcon = False
        Me.ReceiveBooksDataGridView.Size = New System.Drawing.Size(509, 430)
        Me.ReceiveBooksDataGridView.TabIndex = 3
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IssueId"
        Me.DataGridViewTextBoxColumn1.HeaderText = "IssueId"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'BookIdDataGridViewTextBoxColumn
        '
        Me.BookIdDataGridViewTextBoxColumn.DataPropertyName = "BookId"
        Me.BookIdDataGridViewTextBoxColumn.HeaderText = "Book Id"
        Me.BookIdDataGridViewTextBoxColumn.Name = "BookIdDataGridViewTextBoxColumn"
        Me.BookIdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MemberIdDataGridViewTextBoxColumn
        '
        Me.MemberIdDataGridViewTextBoxColumn.DataPropertyName = "MemberId"
        Me.MemberIdDataGridViewTextBoxColumn.HeaderText = "Member Id"
        Me.MemberIdDataGridViewTextBoxColumn.Name = "MemberIdDataGridViewTextBoxColumn"
        Me.MemberIdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IssueDateDataGridViewTextBoxColumn
        '
        Me.IssueDateDataGridViewTextBoxColumn.DataPropertyName = "IssueDate"
        Me.IssueDateDataGridViewTextBoxColumn.HeaderText = "Issue Date"
        Me.IssueDateDataGridViewTextBoxColumn.Name = "IssueDateDataGridViewTextBoxColumn"
        Me.IssueDateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ReturnDateDataGridViewTextBoxColumn
        '
        Me.ReturnDateDataGridViewTextBoxColumn.DataPropertyName = "ReturnDate"
        Me.ReturnDateDataGridViewTextBoxColumn.HeaderText = "Return Date"
        Me.ReturnDateDataGridViewTextBoxColumn.Name = "ReturnDateDataGridViewTextBoxColumn"
        Me.ReturnDateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IssuesBindingSource
        '
        Me.IssuesBindingSource.DataMember = "Issues"
        Me.IssuesBindingSource.DataSource = Me.LibraryManagementDataSet
        '
        'LibraryManagementDataSet
        '
        Me.LibraryManagementDataSet.DataSetName = "LibraryManagementDataSet"
        Me.LibraryManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PickerIssueDate
        '
        Me.PickerIssueDate.CalendarFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PickerIssueDate.CalendarForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.PickerIssueDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.PickerIssueDate.CalendarTitleBackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.PickerIssueDate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PickerIssueDate.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PickerIssueDate.Location = New System.Drawing.Point(128, 81)
        Me.PickerIssueDate.Name = "PickerIssueDate"
        Me.PickerIssueDate.Size = New System.Drawing.Size(302, 25)
        Me.PickerIssueDate.TabIndex = 5
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel1.SetColumnSpan(Me.TableLayoutPanel2, 2)
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.BtnDelete, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.BtnCancel, 2, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 258)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(427, 53)
        Me.TableLayoutPanel2.TabIndex = 7
        '
        'BtnDelete
        '
        Me.BtnDelete.BackColor = System.Drawing.Color.Transparent
        Me.BtnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDelete.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.BtnDelete.FlatAppearance.BorderSize = 2
        Me.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDelete.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDelete.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.BtnDelete.Location = New System.Drawing.Point(0, 5)
        Me.BtnDelete.Margin = New System.Windows.Forms.Padding(0, 5, 5, 5)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(203, 43)
        Me.BtnDelete.TabIndex = 14
        Me.BtnDelete.Text = "Delete Record"
        Me.BtnDelete.UseVisualStyleBackColor = False
        '
        'BtnCancel
        '
        Me.BtnCancel.BackColor = System.Drawing.Color.Transparent
        Me.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.BtnCancel.FlatAppearance.BorderSize = 2
        Me.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancel.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.BtnCancel.Location = New System.Drawing.Point(218, 5)
        Me.BtnCancel.Margin = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(209, 43)
        Me.BtnCancel.TabIndex = 13
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = False
        '
        'LblReturnDate
        '
        Me.LblReturnDate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblReturnDate.AutoSize = True
        Me.LblReturnDate.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblReturnDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.LblReturnDate.Location = New System.Drawing.Point(3, 117)
        Me.LblReturnDate.Name = "LblReturnDate"
        Me.LblReturnDate.Size = New System.Drawing.Size(119, 25)
        Me.LblReturnDate.TabIndex = 1
        Me.LblReturnDate.Text = "Return Date"
        Me.LblReturnDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PickerReceiveDate
        '
        Me.PickerReceiveDate.CalendarFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PickerReceiveDate.CalendarForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.PickerReceiveDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.PickerReceiveDate.CalendarTitleBackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.PickerReceiveDate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PickerReceiveDate.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PickerReceiveDate.Location = New System.Drawing.Point(128, 120)
        Me.PickerReceiveDate.Name = "PickerReceiveDate"
        Me.PickerReceiveDate.Size = New System.Drawing.Size(302, 25)
        Me.PickerReceiveDate.TabIndex = 5
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 3
        Me.TableLayoutPanel1.SetColumnSpan(Me.TableLayoutPanel3, 2)
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.BtnReceive, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.BtnUpdate, 2, 0)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 179)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(427, 53)
        Me.TableLayoutPanel3.TabIndex = 6
        '
        'BtnReceive
        '
        Me.BtnReceive.BackColor = System.Drawing.Color.Transparent
        Me.BtnReceive.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnReceive.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnReceive.FlatAppearance.BorderSize = 2
        Me.BtnReceive.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.BtnReceive.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnReceive.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReceive.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.BtnReceive.Location = New System.Drawing.Point(0, 5)
        Me.BtnReceive.Margin = New System.Windows.Forms.Padding(0, 5, 5, 5)
        Me.BtnReceive.Name = "BtnReceive"
        Me.BtnReceive.Size = New System.Drawing.Size(203, 43)
        Me.BtnReceive.TabIndex = 12
        Me.BtnReceive.Text = "Receive Book"
        Me.BtnReceive.UseVisualStyleBackColor = False
        '
        'BtnUpdate
        '
        Me.BtnUpdate.BackColor = System.Drawing.Color.Transparent
        Me.BtnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnUpdate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnUpdate.FlatAppearance.BorderSize = 2
        Me.BtnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUpdate.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUpdate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.BtnUpdate.Location = New System.Drawing.Point(218, 5)
        Me.BtnUpdate.Margin = New System.Windows.Forms.Padding(0, 5, 5, 5)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(204, 43)
        Me.BtnUpdate.TabIndex = 11
        Me.BtnUpdate.Text = "Update Record"
        Me.BtnUpdate.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(20, 25)
        Me.Label5.Margin = New System.Windows.Forms.Padding(0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(968, 109)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Receive Books"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'IssuesTableAdapter
        '
        Me.IssuesTableAdapter.ClearBeforeFill = True
        '
        'FormBookReturn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1008, 601)
        Me.Controls.Add(Me.TableLayoutContainer)
        Me.MinimumSize = New System.Drawing.Size(1024, 640)
        Me.Name = "FormBookReturn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Book Receive"
        Me.TableLayoutContainer.ResumeLayout(False)
        Me.TableLayoutContainer.PerformLayout()
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.ReceiveBooksDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IssuesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibraryManagementDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutContainer As TableLayoutPanel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents LblBookName As Label
    Friend WithEvents TextBoxBookId As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LblIssuedDate As Label
    Friend WithEvents TextBoxMemberId As TextBox
    Friend WithEvents ReceiveBooksDataGridView As DataGridView
    Friend WithEvents PickerIssueDate As DateTimePicker
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents BtnCancel As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents BtnReceive As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents ToolStrip As ToolStrip
    Friend WithEvents ToolStripHome As ToolStripButton
    Friend WithEvents ToolStripDropDownBooks As ToolStripDropDownButton
    Friend WithEvents ManageBooksToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IssueBooksToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReceiveBookToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMembers As ToolStripButton
    Friend WithEvents ToolStripLogout As ToolStripButton
    Friend WithEvents ToolStripAbout As ToolStripButton
    Friend WithEvents IssueIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LibraryManagementDataSet As LibraryManagementDataSet
    Friend WithEvents IssuesBindingSource As BindingSource
    Friend WithEvents IssuesTableAdapter As LibraryManagementDataSetTableAdapters.IssuesTableAdapter
    Friend WithEvents LblReturnDate As Label
    Friend WithEvents PickerReceiveDate As DateTimePicker
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents BookIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MemberIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IssueDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReturnDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
