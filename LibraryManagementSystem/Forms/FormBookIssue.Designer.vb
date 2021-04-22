<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBookIssue
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBookIssue))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BooksIssueDataGridView = New System.Windows.Forms.DataGridView()
        Me.IssueIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MemberIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IssueDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IssuesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LibraryManagementDataSet = New LibraryManagementSystem.LibraryManagementDataSet()
        Me.PickerIssueDate = New System.Windows.Forms.DateTimePicker()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnIssue = New System.Windows.Forms.Button()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.TextBoxBookId = New System.Windows.Forms.TextBox()
        Me.TextBoxMemberId = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.IssuesTableAdapter = New LibraryManagementSystem.LibraryManagementDataSetTableAdapters.IssuesTableAdapter()
        Me.TableLayoutContainer.SuspendLayout()
        Me.ToolStrip.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.BooksIssueDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IssuesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibraryManagementDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
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
        Me.TableLayoutContainer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutContainer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutContainer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutContainer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.TableLayoutContainer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutContainer.Size = New System.Drawing.Size(1008, 601)
        Me.TableLayoutContainer.TabIndex = 5
        '
        'ToolStrip
        '
        Me.ToolStrip.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.TableLayoutContainer.SetColumnSpan(Me.ToolStrip, 3)
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripHome, Me.ToolStripDropDownBooks, Me.ToolStripMembers, Me.ToolStripLogout, Me.ToolStripAbout})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.Size = New System.Drawing.Size(1008, 30)
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
        Me.ToolStripHome.Size = New System.Drawing.Size(44, 27)
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
        Me.ToolStripDropDownBooks.Size = New System.Drawing.Size(52, 27)
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
        Me.IssueBooksToolStripMenuItem.Enabled = False
        Me.IssueBooksToolStripMenuItem.Name = "IssueBooksToolStripMenuItem"
        Me.IssueBooksToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.IssueBooksToolStripMenuItem.Text = "Issue Book"
        '
        'ReceiveBookToolStripMenuItem
        '
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
        Me.ToolStripMembers.Size = New System.Drawing.Size(61, 27)
        Me.ToolStripMembers.Text = "Members"
        '
        'ToolStripLogout
        '
        Me.ToolStripLogout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.ToolStripLogout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripLogout.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLogout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.ToolStripLogout.Image = CType(resources.GetObject("ToolStripLogout.Image"), System.Drawing.Image)
        Me.ToolStripLogout.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripLogout.Margin = New System.Windows.Forms.Padding(0, 1, 20, 2)
        Me.ToolStripLogout.Name = "ToolStripLogout"
        Me.ToolStripLogout.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never
        Me.ToolStripLogout.Padding = New System.Windows.Forms.Padding(3)
        Me.ToolStripLogout.Size = New System.Drawing.Size(61, 27)
        Me.ToolStripLogout.Text = "Logout"
        '
        'ToolStripAbout
        '
        Me.ToolStripAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripAbout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.ToolStripAbout.Image = CType(resources.GetObject("ToolStripAbout.Image"), System.Drawing.Image)
        Me.ToolStripAbout.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripAbout.Name = "ToolStripAbout"
        Me.ToolStripAbout.Size = New System.Drawing.Size(44, 27)
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
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.BooksIssueDataGridView, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.PickerIssueDate, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBoxBookId, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBoxMemberId, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(20, 148)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 8
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(968, 432)
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
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(3, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Member Id"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(3, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Issue Date"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BooksIssueDataGridView
        '
        Me.BooksIssueDataGridView.AllowUserToAddRows = False
        Me.BooksIssueDataGridView.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BooksIssueDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.BooksIssueDataGridView.AutoGenerateColumns = False
        Me.BooksIssueDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.BooksIssueDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.BooksIssueDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.BooksIssueDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.BooksIssueDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(27, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(240, Byte), Integer))
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(3)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(27, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(240, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BooksIssueDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.BooksIssueDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BooksIssueDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IssueIdDataGridViewTextBoxColumn, Me.BookIdDataGridViewTextBoxColumn, Me.MemberIdDataGridViewTextBoxColumn, Me.IssueDateDataGridViewTextBoxColumn})
        Me.BooksIssueDataGridView.DataSource = Me.IssuesBindingSource
        Me.BooksIssueDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BooksIssueDataGridView.EnableHeadersVisualStyles = False
        Me.BooksIssueDataGridView.Location = New System.Drawing.Point(456, 3)
        Me.BooksIssueDataGridView.MultiSelect = False
        Me.BooksIssueDataGridView.Name = "BooksIssueDataGridView"
        Me.BooksIssueDataGridView.ReadOnly = True
        Me.BooksIssueDataGridView.RowHeadersVisible = False
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(39, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(240, Byte), Integer))
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(3)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(171, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.BooksIssueDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.TableLayoutPanel1.SetRowSpan(Me.BooksIssueDataGridView, 8)
        Me.BooksIssueDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.BooksIssueDataGridView.Size = New System.Drawing.Size(509, 426)
        Me.BooksIssueDataGridView.TabIndex = 3
        '
        'IssueIdDataGridViewTextBoxColumn
        '
        Me.IssueIdDataGridViewTextBoxColumn.DataPropertyName = "IssueId"
        Me.IssueIdDataGridViewTextBoxColumn.HeaderText = "IssueId"
        Me.IssueIdDataGridViewTextBoxColumn.Name = "IssueIdDataGridViewTextBoxColumn"
        Me.IssueIdDataGridViewTextBoxColumn.ReadOnly = True
        Me.IssueIdDataGridViewTextBoxColumn.Visible = False
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
        Me.PickerIssueDate.Location = New System.Drawing.Point(128, 83)
        Me.PickerIssueDate.Name = "PickerIssueDate"
        Me.PickerIssueDate.Size = New System.Drawing.Size(302, 25)
        Me.PickerIssueDate.TabIndex = 5
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 3
        Me.TableLayoutPanel1.SetColumnSpan(Me.TableLayoutPanel3, 2)
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.BtnIssue, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.BtnUpdate, 2, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 143)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(427, 54)
        Me.TableLayoutPanel3.TabIndex = 6
        '
        'BtnIssue
        '
        Me.BtnIssue.BackColor = System.Drawing.Color.Transparent
        Me.BtnIssue.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnIssue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnIssue.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.BtnIssue.FlatAppearance.BorderSize = 2
        Me.BtnIssue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnIssue.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnIssue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.BtnIssue.Location = New System.Drawing.Point(0, 5)
        Me.BtnIssue.Margin = New System.Windows.Forms.Padding(0, 5, 5, 5)
        Me.BtnIssue.Name = "BtnIssue"
        Me.BtnIssue.Size = New System.Drawing.Size(203, 44)
        Me.BtnIssue.TabIndex = 12
        Me.BtnIssue.Text = "Issue Book"
        Me.BtnIssue.UseVisualStyleBackColor = False
        '
        'BtnUpdate
        '
        Me.BtnUpdate.BackColor = System.Drawing.Color.Transparent
        Me.BtnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnUpdate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.BtnUpdate.FlatAppearance.BorderSize = 2
        Me.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUpdate.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUpdate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.BtnUpdate.Location = New System.Drawing.Point(218, 5)
        Me.BtnUpdate.Margin = New System.Windows.Forms.Padding(0, 5, 5, 5)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(204, 44)
        Me.BtnUpdate.TabIndex = 11
        Me.BtnUpdate.Text = "Update Record"
        Me.BtnUpdate.UseVisualStyleBackColor = False
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
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 213)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(427, 54)
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
        Me.BtnDelete.Size = New System.Drawing.Size(203, 44)
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
        Me.BtnCancel.Size = New System.Drawing.Size(209, 44)
        Me.BtnCancel.TabIndex = 13
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = False
        '
        'TextBoxBookId
        '
        Me.TextBoxBookId.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxBookId.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.TextBoxBookId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxBookId.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxBookId.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.TextBoxBookId.Location = New System.Drawing.Point(128, 3)
        Me.TextBoxBookId.Name = "TextBoxBookId"
        Me.TextBoxBookId.Size = New System.Drawing.Size(302, 33)
        Me.TextBoxBookId.TabIndex = 8
        '
        'TextBoxMemberId
        '
        Me.TextBoxMemberId.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxMemberId.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.TextBoxMemberId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxMemberId.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxMemberId.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.TextBoxMemberId.Location = New System.Drawing.Point(128, 43)
        Me.TextBoxMemberId.Name = "TextBoxMemberId"
        Me.TextBoxMemberId.Size = New System.Drawing.Size(302, 33)
        Me.TextBoxMemberId.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(20, 30)
        Me.Label5.Margin = New System.Windows.Forms.Padding(0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(968, 108)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Issue Books"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'IssuesTableAdapter
        '
        Me.IssuesTableAdapter.ClearBeforeFill = True
        '
        'FormBookIssue
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1008, 601)
        Me.Controls.Add(Me.TableLayoutContainer)
        Me.MinimumSize = New System.Drawing.Size(1024, 640)
        Me.Name = "FormBookIssue"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Book Issue"
        Me.TableLayoutContainer.ResumeLayout(False)
        Me.TableLayoutContainer.PerformLayout()
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.BooksIssueDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IssuesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibraryManagementDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutContainer As TableLayoutPanel
    Friend WithEvents ToolStrip As ToolStrip
    Friend WithEvents ToolStripHome As ToolStripButton
    Friend WithEvents ToolStripDropDownBooks As ToolStripDropDownButton
    Friend WithEvents ManageBooksToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IssueBooksToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReceiveBookToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMembers As ToolStripButton
    Friend WithEvents ToolStripLogout As ToolStripButton
    Friend WithEvents ToolStripAbout As ToolStripButton
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents LblBookName As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PickerIssueDate As DateTimePicker
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents BtnIssue As Button
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents BtnDelete As Button
    Friend WithEvents BtnCancel As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxBookId As TextBox
    Friend WithEvents TextBoxMemberId As TextBox
    Friend WithEvents BooksIssueDataGridView As DataGridView
    Friend WithEvents LibraryManagementDataSet As LibraryManagementDataSet
    Friend WithEvents IssuesBindingSource As BindingSource
    Friend WithEvents IssuesTableAdapter As LibraryManagementDataSetTableAdapters.IssuesTableAdapter
    Friend WithEvents IssueIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BookIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MemberIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IssueDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
