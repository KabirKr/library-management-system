<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormBooks
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBooks))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.ToolStripHome = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripDropDownBooks = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ManageBooksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IssueBooksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReceiveBookToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMembers = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLogout = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripAbout = New System.Windows.Forms.ToolStripButton()
        Me.TableLayoutContainer = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TextBoxName = New System.Windows.Forms.TextBox()
        Me.LblBookName = New System.Windows.Forms.Label()
        Me.LblAuthor = New System.Windows.Forms.Label()
        Me.LblPublisher = New System.Windows.Forms.Label()
        Me.LblQuantity = New System.Windows.Forms.Label()
        Me.LblPrice = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.BtnAddBook = New System.Windows.Forms.Button()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.TextBoxAuthor = New System.Windows.Forms.TextBox()
        Me.TextBoxPublisher = New System.Windows.Forms.TextBox()
        Me.TextBoxQuantity = New System.Windows.Forms.TextBox()
        Me.TextBoxPrice = New System.Windows.Forms.TextBox()
        Me.BooksDataGridView = New System.Windows.Forms.DataGridView()
        Me.BookIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AuthorNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PublisherNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantityInStockDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BooksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LibraryManagementDataSet = New LibraryManagementSystem.LibraryManagementDataSet()
        Me.LblHeading = New System.Windows.Forms.Label()
        Me.BooksTableAdapter = New LibraryManagementSystem.LibraryManagementDataSetTableAdapters.BooksTableAdapter()
        Me.ToolStrip.SuspendLayout()
        Me.TableLayoutContainer.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.BooksDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BooksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibraryManagementDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.ManageBooksToolStripMenuItem.Enabled = False
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
        'TableLayoutContainer
        '
        Me.TableLayoutContainer.ColumnCount = 3
        Me.TableLayoutContainer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutContainer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutContainer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutContainer.Controls.Add(Me.ToolStrip, 0, 0)
        Me.TableLayoutContainer.Controls.Add(Me.TableLayoutPanel1, 1, 3)
        Me.TableLayoutContainer.Controls.Add(Me.LblHeading, 1, 1)
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
        Me.TableLayoutContainer.TabIndex = 1
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.5!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.5!))
        Me.TableLayoutPanel1.Controls.Add(Me.TextBoxName, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.LblBookName, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.LblAuthor, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.LblPublisher, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.LblQuantity, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.LblPrice, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 0, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBoxAuthor, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBoxPublisher, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBoxQuantity, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBoxPrice, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.BooksDataGridView, 3, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(20, 148)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 10
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(968, 432)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'TextBoxName
        '
        Me.TextBoxName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxName.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.TextBoxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxName.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.TextBoxName.Location = New System.Drawing.Point(103, 3)
        Me.TextBoxName.Name = "TextBoxName"
        Me.TextBoxName.Size = New System.Drawing.Size(312, 33)
        Me.TextBoxName.TabIndex = 1
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
        Me.LblBookName.Size = New System.Drawing.Size(94, 25)
        Me.LblBookName.TabIndex = 0
        Me.LblBookName.Text = "Name"
        Me.LblBookName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblAuthor
        '
        Me.LblAuthor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblAuthor.AutoSize = True
        Me.LblAuthor.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAuthor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.LblAuthor.Location = New System.Drawing.Point(3, 49)
        Me.LblAuthor.Name = "LblAuthor"
        Me.LblAuthor.Size = New System.Drawing.Size(94, 25)
        Me.LblAuthor.TabIndex = 2
        Me.LblAuthor.Text = "Author"
        Me.LblAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblPublisher
        '
        Me.LblPublisher.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblPublisher.AutoSize = True
        Me.LblPublisher.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPublisher.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.LblPublisher.Location = New System.Drawing.Point(3, 98)
        Me.LblPublisher.Name = "LblPublisher"
        Me.LblPublisher.Size = New System.Drawing.Size(94, 25)
        Me.LblPublisher.TabIndex = 4
        Me.LblPublisher.Text = "Publisher"
        Me.LblPublisher.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblQuantity
        '
        Me.LblQuantity.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblQuantity.AutoSize = True
        Me.LblQuantity.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblQuantity.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.LblQuantity.Location = New System.Drawing.Point(3, 147)
        Me.LblQuantity.Name = "LblQuantity"
        Me.LblQuantity.Size = New System.Drawing.Size(94, 25)
        Me.LblQuantity.TabIndex = 6
        Me.LblQuantity.Text = "Quantity"
        Me.LblQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblPrice
        '
        Me.LblPrice.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblPrice.AutoSize = True
        Me.LblPrice.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPrice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.LblPrice.Location = New System.Drawing.Point(3, 196)
        Me.LblPrice.Name = "LblPrice"
        Me.LblPrice.Size = New System.Drawing.Size(94, 25)
        Me.LblPrice.TabIndex = 8
        Me.LblPrice.Text = "Price"
        Me.LblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel1.SetColumnSpan(Me.TableLayoutPanel2, 2)
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.BtnUpdate, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.BtnAddBook, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 258)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(412, 55)
        Me.TableLayoutPanel2.TabIndex = 10
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
        Me.BtnUpdate.Location = New System.Drawing.Point(216, 5)
        Me.BtnUpdate.Margin = New System.Windows.Forms.Padding(0, 5, 5, 5)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(191, 45)
        Me.BtnUpdate.TabIndex = 1
        Me.BtnUpdate.Text = "Update Book"
        Me.BtnUpdate.UseVisualStyleBackColor = False
        '
        'BtnAddBook
        '
        Me.BtnAddBook.BackColor = System.Drawing.Color.Transparent
        Me.BtnAddBook.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAddBook.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnAddBook.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.BtnAddBook.FlatAppearance.BorderSize = 2
        Me.BtnAddBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAddBook.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddBook.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.BtnAddBook.Location = New System.Drawing.Point(0, 5)
        Me.BtnAddBook.Margin = New System.Windows.Forms.Padding(0, 5, 5, 5)
        Me.BtnAddBook.Name = "BtnAddBook"
        Me.BtnAddBook.Size = New System.Drawing.Size(191, 45)
        Me.BtnAddBook.TabIndex = 0
        Me.BtnAddBook.Text = "Add Book"
        Me.BtnAddBook.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 3
        Me.TableLayoutPanel1.SetColumnSpan(Me.TableLayoutPanel3, 2)
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.BtnCancel, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.BtnDelete, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 329)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(412, 55)
        Me.TableLayoutPanel3.TabIndex = 11
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
        Me.BtnCancel.Location = New System.Drawing.Point(216, 5)
        Me.BtnCancel.Margin = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(196, 45)
        Me.BtnCancel.TabIndex = 1
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = False
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
        Me.BtnDelete.Size = New System.Drawing.Size(191, 45)
        Me.BtnDelete.TabIndex = 0
        Me.BtnDelete.Text = "Delete Book"
        Me.BtnDelete.UseVisualStyleBackColor = False
        '
        'TextBoxAuthor
        '
        Me.TextBoxAuthor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxAuthor.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.TextBoxAuthor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxAuthor.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxAuthor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.TextBoxAuthor.Location = New System.Drawing.Point(103, 52)
        Me.TextBoxAuthor.Name = "TextBoxAuthor"
        Me.TextBoxAuthor.Size = New System.Drawing.Size(312, 33)
        Me.TextBoxAuthor.TabIndex = 3
        '
        'TextBoxPublisher
        '
        Me.TextBoxPublisher.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxPublisher.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.TextBoxPublisher.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxPublisher.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPublisher.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.TextBoxPublisher.Location = New System.Drawing.Point(103, 101)
        Me.TextBoxPublisher.Name = "TextBoxPublisher"
        Me.TextBoxPublisher.Size = New System.Drawing.Size(312, 33)
        Me.TextBoxPublisher.TabIndex = 5
        '
        'TextBoxQuantity
        '
        Me.TextBoxQuantity.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxQuantity.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.TextBoxQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxQuantity.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxQuantity.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.TextBoxQuantity.Location = New System.Drawing.Point(103, 150)
        Me.TextBoxQuantity.Name = "TextBoxQuantity"
        Me.TextBoxQuantity.Size = New System.Drawing.Size(312, 33)
        Me.TextBoxQuantity.TabIndex = 7
        '
        'TextBoxPrice
        '
        Me.TextBoxPrice.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxPrice.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.TextBoxPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxPrice.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPrice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.TextBoxPrice.Location = New System.Drawing.Point(103, 199)
        Me.TextBoxPrice.Name = "TextBoxPrice"
        Me.TextBoxPrice.Size = New System.Drawing.Size(312, 33)
        Me.TextBoxPrice.TabIndex = 9
        '
        'BooksDataGridView
        '
        Me.BooksDataGridView.AllowUserToAddRows = False
        Me.BooksDataGridView.AllowUserToDeleteRows = False
        Me.BooksDataGridView.AutoGenerateColumns = False
        Me.BooksDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.BooksDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.BooksDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.BooksDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.BooksDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(27, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(240, Byte), Integer))
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(3)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(27, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(240, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BooksDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.BooksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BooksDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BookIdDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.AuthorNameDataGridViewTextBoxColumn, Me.PublisherNameDataGridViewTextBoxColumn, Me.QuantityInStockDataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn})
        Me.BooksDataGridView.DataSource = Me.BooksBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(240, Byte), Integer))
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(3)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(240, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.BooksDataGridView.DefaultCellStyle = DataGridViewCellStyle2
        Me.BooksDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BooksDataGridView.EnableHeadersVisualStyles = False
        Me.BooksDataGridView.Location = New System.Drawing.Point(441, 3)
        Me.BooksDataGridView.Name = "BooksDataGridView"
        Me.BooksDataGridView.ReadOnly = True
        Me.BooksDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BooksDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.BooksDataGridView.RowHeadersVisible = False
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(39, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(240, Byte), Integer))
        DataGridViewCellStyle4.Padding = New System.Windows.Forms.Padding(3)
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(171, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.BooksDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.TableLayoutPanel1.SetRowSpan(Me.BooksDataGridView, 10)
        Me.BooksDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.BooksDataGridView.ShowEditingIcon = False
        Me.BooksDataGridView.Size = New System.Drawing.Size(524, 426)
        Me.BooksDataGridView.TabIndex = 12
        '
        'BookIdDataGridViewTextBoxColumn
        '
        Me.BookIdDataGridViewTextBoxColumn.DataPropertyName = "BookId"
        Me.BookIdDataGridViewTextBoxColumn.HeaderText = "BookId"
        Me.BookIdDataGridViewTextBoxColumn.Name = "BookIdDataGridViewTextBoxColumn"
        Me.BookIdDataGridViewTextBoxColumn.ReadOnly = True
        Me.BookIdDataGridViewTextBoxColumn.Visible = False
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AuthorNameDataGridViewTextBoxColumn
        '
        Me.AuthorNameDataGridViewTextBoxColumn.DataPropertyName = "AuthorName"
        Me.AuthorNameDataGridViewTextBoxColumn.HeaderText = "Author"
        Me.AuthorNameDataGridViewTextBoxColumn.Name = "AuthorNameDataGridViewTextBoxColumn"
        Me.AuthorNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PublisherNameDataGridViewTextBoxColumn
        '
        Me.PublisherNameDataGridViewTextBoxColumn.DataPropertyName = "PublisherName"
        Me.PublisherNameDataGridViewTextBoxColumn.HeaderText = "Publisher"
        Me.PublisherNameDataGridViewTextBoxColumn.Name = "PublisherNameDataGridViewTextBoxColumn"
        Me.PublisherNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'QuantityInStockDataGridViewTextBoxColumn
        '
        Me.QuantityInStockDataGridViewTextBoxColumn.DataPropertyName = "QuantityInStock"
        Me.QuantityInStockDataGridViewTextBoxColumn.HeaderText = "Stock Quantity"
        Me.QuantityInStockDataGridViewTextBoxColumn.Name = "QuantityInStockDataGridViewTextBoxColumn"
        Me.QuantityInStockDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PriceDataGridViewTextBoxColumn
        '
        Me.PriceDataGridViewTextBoxColumn.DataPropertyName = "Price"
        Me.PriceDataGridViewTextBoxColumn.HeaderText = "Price"
        Me.PriceDataGridViewTextBoxColumn.Name = "PriceDataGridViewTextBoxColumn"
        Me.PriceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BooksBindingSource
        '
        Me.BooksBindingSource.DataMember = "Books"
        Me.BooksBindingSource.DataSource = Me.LibraryManagementDataSet
        '
        'LibraryManagementDataSet
        '
        Me.LibraryManagementDataSet.DataSetName = "LibraryManagementDataSet"
        Me.LibraryManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LblHeading
        '
        Me.LblHeading.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblHeading.Font = New System.Drawing.Font("Segoe UI Semilight", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHeading.ForeColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.LblHeading.Location = New System.Drawing.Point(20, 30)
        Me.LblHeading.Margin = New System.Windows.Forms.Padding(0)
        Me.LblHeading.Name = "LblHeading"
        Me.LblHeading.Size = New System.Drawing.Size(968, 108)
        Me.LblHeading.TabIndex = 1
        Me.LblHeading.Text = "Manage Books"
        Me.LblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BooksTableAdapter
        '
        Me.BooksTableAdapter.ClearBeforeFill = True
        '
        'FormBooks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1008, 601)
        Me.Controls.Add(Me.TableLayoutContainer)
        Me.MinimumSize = New System.Drawing.Size(1024, 640)
        Me.Name = "FormBooks"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Books"
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        Me.TableLayoutContainer.ResumeLayout(False)
        Me.TableLayoutContainer.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        CType(Me.BooksDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BooksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibraryManagementDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents TableLayoutContainer As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ToolStripHome As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripDropDownBooks As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents ManageBooksToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IssueBooksToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReceiveBookToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMembers As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLogout As System.Windows.Forms.ToolStripButton
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents LblBookName As System.Windows.Forms.Label
    Friend WithEvents LblAuthor As System.Windows.Forms.Label
    Friend WithEvents LblPublisher As System.Windows.Forms.Label
    Friend WithEvents LblQuantity As System.Windows.Forms.Label
    Friend WithEvents LblPrice As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents BtnAddBook As System.Windows.Forms.Button
    Friend WithEvents BtnUpdate As System.Windows.Forms.Button
    Friend WithEvents LblHeading As System.Windows.Forms.Label
    Friend WithEvents ToolStripAbout As System.Windows.Forms.ToolStripButton
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TextBoxName As TextBox
    Friend WithEvents TextBoxAuthor As TextBox
    Friend WithEvents TextBoxPublisher As TextBox
    Friend WithEvents TextBoxQuantity As TextBox
    Friend WithEvents TextBoxPrice As TextBox
    Friend WithEvents BooksDataGridView As DataGridView
    Friend WithEvents LibraryManagementDataSet As LibraryManagementDataSet
    Friend WithEvents BooksBindingSource As BindingSource
    Friend WithEvents BooksTableAdapter As LibraryManagementDataSetTableAdapters.BooksTableAdapter
    Friend WithEvents BookIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AuthorNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PublisherNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QuantityInStockDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
