<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.patron_bc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.item_bc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.due_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.timestamp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CKO_Time = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_Save_Transactions = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdo1Year = New System.Windows.Forms.RadioButton()
        Me.rdo42days = New System.Windows.Forms.RadioButton()
        Me.rdo21days = New System.Windows.Forms.RadioButton()
        Me.rdo28days = New System.Windows.Forms.RadioButton()
        Me.rdo14days = New System.Windows.Forms.RadioButton()
        Me.rdo7days = New System.Windows.Forms.RadioButton()
        Me.rdoToday = New System.Windows.Forms.RadioButton()
        Me.grpDueDate = New System.Windows.Forms.GroupBox()
        Me.lbl_due_date = New System.Windows.Forms.Label()
        Me.DatePicker = New System.Windows.Forms.DateTimePicker()
        Me.grpEntry = New System.Windows.Forms.GroupBox()
        Me.btnNoCard = New System.Windows.Forms.Button()
        Me.btn_Checkout = New System.Windows.Forms.Button()
        Me.txt_item_barcode = New System.Windows.Forms.TextBox()
        Me.lbl_item_barcode = New System.Windows.Forms.Label()
        Me.lbl_patron_barcode = New System.Windows.Forms.Label()
        Me.txt_Patron_barcode = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblPrinters = New System.Windows.Forms.Label()
        Me.cboInstalledPrinters = New System.Windows.Forms.ComboBox()
        Me.chk_strict_barcode = New System.Windows.Forms.CheckBox()
        Me.chk_Print_Receipt = New System.Windows.Forms.CheckBox()
        Me.StatusText = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.grpDueDate.SuspendLayout()
        Me.grpEntry.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatusText})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 933)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1214, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.72982!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.27018!))
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox2, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.dgv, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_Save_Transactions, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.grpDueDate, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.grpEntry, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 216.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 232.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1214, 933)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv.ColumnHeadersHeight = 34
        Me.dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.patron_bc, Me.item_bc, Me.due_date, Me.timestamp, Me.CKO_Time})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv.Location = New System.Drawing.Point(632, 5)
        Me.dgv.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgv.Name = "dgv"
        Me.dgv.RowHeadersWidth = 20
        Me.TableLayoutPanel1.SetRowSpan(Me.dgv, 3)
        Me.dgv.RowTemplate.Height = 25
        Me.dgv.Size = New System.Drawing.Size(578, 690)
        Me.dgv.TabIndex = 4
        Me.dgv.TabStop = False
        '
        'patron_bc
        '
        Me.patron_bc.HeaderText = "Patron Barcode"
        Me.patron_bc.MinimumWidth = 8
        Me.patron_bc.Name = "patron_bc"
        '
        'item_bc
        '
        Me.item_bc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.item_bc.HeaderText = "Item Barcode"
        Me.item_bc.MinimumWidth = 8
        Me.item_bc.Name = "item_bc"
        Me.item_bc.Width = 130
        '
        'due_date
        '
        Me.due_date.HeaderText = "Due Date"
        Me.due_date.MinimumWidth = 8
        Me.due_date.Name = "due_date"
        '
        'timestamp
        '
        Me.timestamp.HeaderText = "Scan Time"
        Me.timestamp.MinimumWidth = 8
        Me.timestamp.Name = "timestamp"
        Me.timestamp.Visible = False
        '
        'CKO_Time
        '
        Me.CKO_Time.HeaderText = "CKO Time"
        Me.CKO_Time.MinimumWidth = 8
        Me.CKO_Time.Name = "CKO_Time"
        Me.CKO_Time.Visible = False
        '
        'btn_Save_Transactions
        '
        Me.btn_Save_Transactions.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Save_Transactions.AutoSize = True
        Me.btn_Save_Transactions.Enabled = False
        Me.btn_Save_Transactions.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btn_Save_Transactions.Location = New System.Drawing.Point(632, 705)
        Me.btn_Save_Transactions.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_Save_Transactions.Name = "btn_Save_Transactions"
        Me.btn_Save_Transactions.Size = New System.Drawing.Size(578, 223)
        Me.btn_Save_Transactions.TabIndex = 11
        Me.btn_Save_Transactions.Text = "Finish this Checkout"
        Me.btn_Save_Transactions.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.AutoSize = True
        Me.GroupBox1.Controls.Add(Me.rdo1Year)
        Me.GroupBox1.Controls.Add(Me.rdo42days)
        Me.GroupBox1.Controls.Add(Me.rdo21days)
        Me.GroupBox1.Controls.Add(Me.rdo28days)
        Me.GroupBox1.Controls.Add(Me.rdo14days)
        Me.GroupBox1.Controls.Add(Me.rdo7days)
        Me.GroupBox1.Controls.Add(Me.rdoToday)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 247)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(620, 232)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Due Date Periods:"
        '
        'rdo1Year
        '
        Me.rdo1Year.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rdo1Year.AutoSize = True
        Me.rdo1Year.Location = New System.Drawing.Point(375, 29)
        Me.rdo1Year.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rdo1Year.Name = "rdo1Year"
        Me.rdo1Year.Size = New System.Drawing.Size(77, 24)
        Me.rdo1Year.TabIndex = 6
        Me.rdo1Year.TabStop = True
        Me.rdo1Year.Text = "1 year"
        Me.rdo1Year.UseVisualStyleBackColor = True
        '
        'rdo42days
        '
        Me.rdo42days.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rdo42days.AutoSize = True
        Me.rdo42days.Location = New System.Drawing.Point(190, 102)
        Me.rdo42days.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rdo42days.Name = "rdo42days"
        Me.rdo42days.Size = New System.Drawing.Size(89, 24)
        Me.rdo42days.TabIndex = 5
        Me.rdo42days.TabStop = True
        Me.rdo42days.Text = "42 days"
        Me.rdo42days.UseVisualStyleBackColor = True
        '
        'rdo21days
        '
        Me.rdo21days.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rdo21days.AutoSize = True
        Me.rdo21days.Location = New System.Drawing.Point(190, 66)
        Me.rdo21days.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rdo21days.Name = "rdo21days"
        Me.rdo21days.Size = New System.Drawing.Size(89, 24)
        Me.rdo21days.TabIndex = 4
        Me.rdo21days.TabStop = True
        Me.rdo21days.Text = "21 days"
        Me.rdo21days.UseVisualStyleBackColor = True
        '
        'rdo28days
        '
        Me.rdo28days.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rdo28days.AutoSize = True
        Me.rdo28days.Location = New System.Drawing.Point(9, 102)
        Me.rdo28days.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rdo28days.Name = "rdo28days"
        Me.rdo28days.Size = New System.Drawing.Size(89, 24)
        Me.rdo28days.TabIndex = 2
        Me.rdo28days.TabStop = True
        Me.rdo28days.Text = "28 days"
        Me.rdo28days.UseVisualStyleBackColor = True
        '
        'rdo14days
        '
        Me.rdo14days.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rdo14days.AutoSize = True
        Me.rdo14days.Location = New System.Drawing.Point(190, 29)
        Me.rdo14days.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rdo14days.Name = "rdo14days"
        Me.rdo14days.Size = New System.Drawing.Size(89, 24)
        Me.rdo14days.TabIndex = 3
        Me.rdo14days.TabStop = True
        Me.rdo14days.Text = "14 days"
        Me.rdo14days.UseVisualStyleBackColor = True
        '
        'rdo7days
        '
        Me.rdo7days.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rdo7days.AutoSize = True
        Me.rdo7days.Location = New System.Drawing.Point(9, 66)
        Me.rdo7days.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rdo7days.Name = "rdo7days"
        Me.rdo7days.Size = New System.Drawing.Size(80, 24)
        Me.rdo7days.TabIndex = 1
        Me.rdo7days.TabStop = True
        Me.rdo7days.Text = "7 days"
        Me.rdo7days.UseVisualStyleBackColor = True
        '
        'rdoToday
        '
        Me.rdoToday.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rdoToday.AutoSize = True
        Me.rdoToday.Location = New System.Drawing.Point(10, 31)
        Me.rdoToday.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rdoToday.Name = "rdoToday"
        Me.rdoToday.Size = New System.Drawing.Size(77, 24)
        Me.rdoToday.TabIndex = 0
        Me.rdoToday.TabStop = True
        Me.rdoToday.Text = "Today"
        Me.rdoToday.UseVisualStyleBackColor = True
        '
        'grpDueDate
        '
        Me.grpDueDate.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDueDate.AutoSize = True
        Me.grpDueDate.Controls.Add(Me.lbl_due_date)
        Me.grpDueDate.Controls.Add(Me.DatePicker)
        Me.grpDueDate.Location = New System.Drawing.Point(3, 3)
        Me.grpDueDate.Name = "grpDueDate"
        Me.grpDueDate.Size = New System.Drawing.Size(622, 236)
        Me.grpDueDate.TabIndex = 13
        Me.grpDueDate.TabStop = False
        '
        'lbl_due_date
        '
        Me.lbl_due_date.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_due_date.AutoSize = True
        Me.lbl_due_date.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_due_date.Location = New System.Drawing.Point(14, 74)
        Me.lbl_due_date.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_due_date.Name = "lbl_due_date"
        Me.lbl_due_date.Size = New System.Drawing.Size(119, 29)
        Me.lbl_due_date.TabIndex = 6
        Me.lbl_due_date.Text = "Due Date:"
        '
        'DatePicker
        '
        Me.DatePicker.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DatePicker.CalendarFont = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.DatePicker.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DatePicker.Location = New System.Drawing.Point(141, 66)
        Me.DatePicker.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DatePicker.Name = "DatePicker"
        Me.DatePicker.Size = New System.Drawing.Size(424, 37)
        Me.DatePicker.TabIndex = 5
        '
        'grpEntry
        '
        Me.grpEntry.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpEntry.AutoSize = True
        Me.grpEntry.Controls.Add(Me.btnNoCard)
        Me.grpEntry.Controls.Add(Me.btn_Checkout)
        Me.grpEntry.Controls.Add(Me.txt_item_barcode)
        Me.grpEntry.Controls.Add(Me.lbl_item_barcode)
        Me.grpEntry.Controls.Add(Me.lbl_patron_barcode)
        Me.grpEntry.Controls.Add(Me.txt_Patron_barcode)
        Me.grpEntry.Location = New System.Drawing.Point(3, 487)
        Me.grpEntry.Name = "grpEntry"
        Me.grpEntry.Size = New System.Drawing.Size(622, 210)
        Me.grpEntry.TabIndex = 14
        Me.grpEntry.TabStop = False
        '
        'btnNoCard
        '
        Me.btnNoCard.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNoCard.Location = New System.Drawing.Point(481, 15)
        Me.btnNoCard.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnNoCard.Name = "btnNoCard"
        Me.btnNoCard.Size = New System.Drawing.Size(135, 57)
        Me.btnNoCard.TabIndex = 23
        Me.btnNoCard.Text = "No Card?"
        Me.btnNoCard.UseVisualStyleBackColor = True
        '
        'btn_Checkout
        '
        Me.btn_Checkout.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Checkout.Enabled = False
        Me.btn_Checkout.Location = New System.Drawing.Point(481, 111)
        Me.btn_Checkout.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_Checkout.Name = "btn_Checkout"
        Me.btn_Checkout.Size = New System.Drawing.Size(135, 54)
        Me.btn_Checkout.TabIndex = 22
        Me.btn_Checkout.Text = "Check Out Item"
        Me.btn_Checkout.UseVisualStyleBackColor = True
        '
        'txt_item_barcode
        '
        Me.txt_item_barcode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txt_item_barcode.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_item_barcode.Location = New System.Drawing.Point(139, 116)
        Me.txt_item_barcode.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_item_barcode.Name = "txt_item_barcode"
        Me.txt_item_barcode.Size = New System.Drawing.Size(310, 37)
        Me.txt_item_barcode.TabIndex = 21
        '
        'lbl_item_barcode
        '
        Me.lbl_item_barcode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl_item_barcode.AutoSize = True
        Me.lbl_item_barcode.Location = New System.Drawing.Point(6, 122)
        Me.lbl_item_barcode.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_item_barcode.Name = "lbl_item_barcode"
        Me.lbl_item_barcode.Size = New System.Drawing.Size(109, 20)
        Me.lbl_item_barcode.TabIndex = 20
        Me.lbl_item_barcode.Text = "Item Barcode:"
        '
        'lbl_patron_barcode
        '
        Me.lbl_patron_barcode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl_patron_barcode.AutoSize = True
        Me.lbl_patron_barcode.Location = New System.Drawing.Point(6, 47)
        Me.lbl_patron_barcode.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_patron_barcode.Name = "lbl_patron_barcode"
        Me.lbl_patron_barcode.Size = New System.Drawing.Size(124, 20)
        Me.lbl_patron_barcode.TabIndex = 19
        Me.lbl_patron_barcode.Text = "Patron Barcode:"
        '
        'txt_Patron_barcode
        '
        Me.txt_Patron_barcode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txt_Patron_barcode.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Patron_barcode.Location = New System.Drawing.Point(138, 35)
        Me.txt_Patron_barcode.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_Patron_barcode.Name = "txt_Patron_barcode"
        Me.txt_Patron_barcode.Size = New System.Drawing.Size(312, 37)
        Me.txt_Patron_barcode.TabIndex = 18
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblPrinters)
        Me.GroupBox2.Controls.Add(Me.cboInstalledPrinters)
        Me.GroupBox2.Controls.Add(Me.chk_strict_barcode)
        Me.GroupBox2.Controls.Add(Me.chk_Print_Receipt)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 703)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(616, 216)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Settings"
        '
        'lblPrinters
        '
        Me.lblPrinters.AutoSize = True
        Me.lblPrinters.Location = New System.Drawing.Point(12, 107)
        Me.lblPrinters.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPrinters.Name = "lblPrinters"
        Me.lblPrinters.Size = New System.Drawing.Size(118, 20)
        Me.lblPrinters.TabIndex = 17
        Me.lblPrinters.Text = "Receipt Printer:"
        Me.lblPrinters.Visible = False
        '
        'cboInstalledPrinters
        '
        Me.cboInstalledPrinters.FormattingEnabled = True
        Me.cboInstalledPrinters.Location = New System.Drawing.Point(12, 131)
        Me.cboInstalledPrinters.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboInstalledPrinters.Name = "cboInstalledPrinters"
        Me.cboInstalledPrinters.Size = New System.Drawing.Size(366, 28)
        Me.cboInstalledPrinters.TabIndex = 16
        Me.cboInstalledPrinters.TabStop = False
        Me.cboInstalledPrinters.Visible = False
        '
        'chk_strict_barcode
        '
        Me.chk_strict_barcode.AutoSize = True
        Me.chk_strict_barcode.Location = New System.Drawing.Point(16, 41)
        Me.chk_strict_barcode.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chk_strict_barcode.Name = "chk_strict_barcode"
        Me.chk_strict_barcode.Size = New System.Drawing.Size(145, 24)
        Me.chk_strict_barcode.TabIndex = 11
        Me.chk_strict_barcode.TabStop = False
        Me.chk_strict_barcode.Text = "Strict Barcode?"
        Me.chk_strict_barcode.UseVisualStyleBackColor = True
        '
        'chk_Print_Receipt
        '
        Me.chk_Print_Receipt.AutoSize = True
        Me.chk_Print_Receipt.Location = New System.Drawing.Point(243, 41)
        Me.chk_Print_Receipt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chk_Print_Receipt.Name = "chk_Print_Receipt"
        Me.chk_Print_Receipt.Size = New System.Drawing.Size(135, 24)
        Me.chk_Print_Receipt.TabIndex = 12
        Me.chk_Print_Receipt.TabStop = False
        Me.chk_Print_Receipt.Text = "Print Receipt?"
        Me.chk_Print_Receipt.UseVisualStyleBackColor = True
        '
        'StatusText
        '
        Me.StatusText.Name = "StatusText"
        Me.StatusText.Size = New System.Drawing.Size(0, 15)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1214, 955)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpDueDate.ResumeLayout(False)
        Me.grpDueDate.PerformLayout()
        Me.grpEntry.ResumeLayout(False)
        Me.grpEntry.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents dgv As DataGridView
    Friend WithEvents patron_bc As DataGridViewTextBoxColumn
    Friend WithEvents item_bc As DataGridViewTextBoxColumn
    Friend WithEvents due_date As DataGridViewTextBoxColumn
    Friend WithEvents timestamp As DataGridViewTextBoxColumn
    Friend WithEvents CKO_Time As DataGridViewTextBoxColumn
    Friend WithEvents btn_Save_Transactions As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rdo1Year As RadioButton
    Friend WithEvents rdo42days As RadioButton
    Friend WithEvents rdo21days As RadioButton
    Friend WithEvents rdo28days As RadioButton
    Friend WithEvents rdo14days As RadioButton
    Friend WithEvents rdo7days As RadioButton
    Friend WithEvents rdoToday As RadioButton
    Friend WithEvents grpDueDate As GroupBox
    Friend WithEvents lbl_due_date As Label
    Friend WithEvents DatePicker As DateTimePicker
    Friend WithEvents grpEntry As GroupBox
    Friend WithEvents btnNoCard As Button
    Friend WithEvents btn_Checkout As Button
    Friend WithEvents txt_item_barcode As TextBox
    Friend WithEvents lbl_item_barcode As Label
    Friend WithEvents lbl_patron_barcode As Label
    Friend WithEvents txt_Patron_barcode As TextBox
    Friend WithEvents StatusText As ToolStripStatusLabel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblPrinters As Label
    Friend WithEvents cboInstalledPrinters As ComboBox
    Friend WithEvents chk_strict_barcode As CheckBox
    Friend WithEvents chk_Print_Receipt As CheckBox
End Class
