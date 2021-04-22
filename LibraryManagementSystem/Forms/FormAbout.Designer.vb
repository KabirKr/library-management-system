<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAbout
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAbout))
        Me.TableLayoutContainer = New System.Windows.Forms.TableLayoutPanel()
        Me.ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.ToolStripHome = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripDropDownBooks = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ManageBooksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IssueBooksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReceiveBookToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMembers = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripAbout = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLogout = New System.Windows.Forms.ToolStripButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TableLayoutContainer.SuspendLayout()
        Me.ToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutContainer
        '
        Me.TableLayoutContainer.ColumnCount = 3
        Me.TableLayoutContainer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutContainer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutContainer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutContainer.Controls.Add(Me.ToolStrip, 0, 0)
        Me.TableLayoutContainer.Controls.Add(Me.Label5, 1, 1)
        Me.TableLayoutContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutContainer.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutContainer.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutContainer.MaximumSize = New System.Drawing.Size(800, 600)
        Me.TableLayoutContainer.MinimumSize = New System.Drawing.Size(800, 600)
        Me.TableLayoutContainer.Name = "TableLayoutContainer"
        Me.TableLayoutContainer.RowCount = 5
        Me.TableLayoutContainer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutContainer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutContainer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutContainer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.TableLayoutContainer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutContainer.Size = New System.Drawing.Size(800, 600)
        Me.TableLayoutContainer.TabIndex = 2
        '
        'ToolStrip
        '
        Me.ToolStrip.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.TableLayoutContainer.SetColumnSpan(Me.ToolStrip, 3)
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripHome, Me.ToolStripDropDownBooks, Me.ToolStripMembers, Me.ToolStripAbout, Me.ToolStripLogout})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.Size = New System.Drawing.Size(800, 25)
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
        'ToolStripAbout
        '
        Me.ToolStripAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripAbout.Enabled = False
        Me.ToolStripAbout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.ToolStripAbout.Image = CType(resources.GetObject("ToolStripAbout.Image"), System.Drawing.Image)
        Me.ToolStripAbout.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripAbout.Name = "ToolStripAbout"
        Me.ToolStripAbout.Size = New System.Drawing.Size(44, 22)
        Me.ToolStripAbout.Text = "About"
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
        Me.ToolStripLogout.Size = New System.Drawing.Size(61, 22)
        Me.ToolStripLogout.Text = "Logout"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(23, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(754, 109)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "About"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FormAbout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 561)
        Me.Controls.Add(Me.TableLayoutContainer)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "FormAbout"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormAbout"
        Me.TableLayoutContainer.ResumeLayout(False)
        Me.TableLayoutContainer.PerformLayout()
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
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
    Friend WithEvents ToolStripAbout As ToolStripButton
    Friend WithEvents Label5 As Label
    Friend WithEvents ToolStripLogout As ToolStripButton
End Class
