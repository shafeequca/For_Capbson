namespace InMag_V._16
{
    partial class frmSales
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblSlno = new System.Windows.Forms.Label();
            this.cboCustomer = new System.Windows.Forms.ComboBox();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.lblPlace = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtBillno = new System.Windows.Forms.TextBox();
            this.lblBillno = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.lblItemname = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblRate = new System.Windows.Forms.Label();
            this.txtItemcode = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.cboRategroup = new System.Windows.Forms.ComboBox();
            this.lblRategroup = new System.Windows.Forms.Label();
            this.ItemGrid = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.txtCGST = new System.Windows.Forms.TextBox();
            this.lblCash = new System.Windows.Forms.Label();
            this.txtSGST = new System.Windows.Forms.TextBox();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.txtIGST = new System.Windows.Forms.TextBox();
            this.lblBalance = new System.Windows.Forms.Label();
            this.txtBillTotal = new System.Windows.Forms.TextBox();
            this.lblGrand = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkCashEntry = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtBillNoSearch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DtTo = new System.Windows.Forms.DateTimePicker();
            this.DtFrom = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cboCustomerSearch = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchGrid = new System.Windows.Forms.DataGridView();
            this.cmdItemClear = new System.Windows.Forms.Button();
            this.itemView = new System.Windows.Forms.GroupBox();
            this.ItemDisplayGrid = new System.Windows.Forms.DataGridView();
            this.txtItems = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtStateCode = new System.Windows.Forms.TextBox();
            this.txtCGSTPer = new System.Windows.Forms.TextBox();
            this.txtSGSTPer = new System.Windows.Forms.TextBox();
            this.txtIGSTPer = new System.Windows.Forms.TextBox();
            this.txtGrandTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGST = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ItemGrid)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchGrid)).BeginInit();
            this.itemView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemDisplayGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSlno
            // 
            this.lblSlno.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSlno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSlno.ForeColor = System.Drawing.Color.White;
            this.lblSlno.Location = new System.Drawing.Point(24, 155);
            this.lblSlno.Name = "lblSlno";
            this.lblSlno.Size = new System.Drawing.Size(40, 22);
            this.lblSlno.TabIndex = 31;
            this.lblSlno.Text = "Sl.No";
            // 
            // cboCustomer
            // 
            this.cboCustomer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboCustomer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCustomer.FormattingEnabled = true;
            this.cboCustomer.Location = new System.Drawing.Point(121, 19);
            this.cboCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.cboCustomer.Name = "cboCustomer";
            this.cboCustomer.Size = new System.Drawing.Size(229, 28);
            this.cboCustomer.TabIndex = 37;
            this.cboCustomer.SelectedIndexChanged += new System.EventHandler(this.cboCustomer_SelectedIndexChanged);
            // 
            // lblCustomer
            // 
            this.lblCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.ForeColor = System.Drawing.Color.White;
            this.lblCustomer.Location = new System.Drawing.Point(21, 19);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(94, 20);
            this.lblCustomer.TabIndex = 36;
            this.lblCustomer.Text = "Customer";
            // 
            // lblPlace
            // 
            this.lblPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlace.ForeColor = System.Drawing.Color.White;
            this.lblPlace.Location = new System.Drawing.Point(21, 49);
            this.lblPlace.Name = "lblPlace";
            this.lblPlace.Size = new System.Drawing.Size(94, 20);
            this.lblPlace.TabIndex = 38;
            this.lblPlace.Text = "Address";
            // 
            // txtAddress
            // 
            this.txtAddress.Enabled = false;
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(121, 50);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(229, 58);
            this.txtAddress.TabIndex = 42;
            // 
            // txtBillno
            // 
            this.txtBillno.Enabled = false;
            this.txtBillno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBillno.Location = new System.Drawing.Point(520, 51);
            this.txtBillno.Margin = new System.Windows.Forms.Padding(2);
            this.txtBillno.Name = "txtBillno";
            this.txtBillno.Size = new System.Drawing.Size(143, 26);
            this.txtBillno.TabIndex = 45;
            // 
            // lblBillno
            // 
            this.lblBillno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillno.ForeColor = System.Drawing.Color.White;
            this.lblBillno.Location = new System.Drawing.Point(398, 51);
            this.lblBillno.Name = "lblBillno";
            this.lblBillno.Size = new System.Drawing.Size(117, 20);
            this.lblBillno.TabIndex = 44;
            this.lblBillno.Text = "Bill No";
            // 
            // lblDate
            // 
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(398, 87);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(117, 20);
            this.lblDate.TabIndex = 46;
            this.lblDate.Text = "Date";
            // 
            // DatePicker
            // 
            this.DatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatePicker.Location = new System.Drawing.Point(520, 82);
            this.DatePicker.Margin = new System.Windows.Forms.Padding(2);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(143, 26);
            this.DatePicker.TabIndex = 48;
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(60, 155);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 22);
            this.label10.TabIndex = 50;
            this.label10.Text = "Item Code";
            // 
            // lblItemname
            // 
            this.lblItemname.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblItemname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemname.ForeColor = System.Drawing.Color.White;
            this.lblItemname.Location = new System.Drawing.Point(144, 155);
            this.lblItemname.Name = "lblItemname";
            this.lblItemname.Size = new System.Drawing.Size(206, 22);
            this.lblItemname.TabIndex = 51;
            this.lblItemname.Text = "Item Name";
            // 
            // lblQuantity
            // 
            this.lblQuantity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.ForeColor = System.Drawing.Color.White;
            this.lblQuantity.Location = new System.Drawing.Point(347, 155);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(101, 22);
            this.lblQuantity.TabIndex = 52;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblRate
            // 
            this.lblRate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRate.ForeColor = System.Drawing.Color.White;
            this.lblRate.Location = new System.Drawing.Point(445, 155);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(98, 22);
            this.lblRate.TabIndex = 53;
            this.lblRate.Text = "Rate";
            // 
            // txtItemcode
            // 
            this.txtItemcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemcode.Location = new System.Drawing.Point(60, 179);
            this.txtItemcode.Margin = new System.Windows.Forms.Padding(2);
            this.txtItemcode.Name = "txtItemcode";
            this.txtItemcode.Size = new System.Drawing.Size(85, 26);
            this.txtItemcode.TabIndex = 56;
            this.txtItemcode.TextChanged += new System.EventHandler(this.txtItemcode_TextChanged);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(347, 179);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(2);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(98, 26);
            this.txtQuantity.TabIndex = 58;
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            // 
            // txtRate
            // 
            this.txtRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRate.Location = new System.Drawing.Point(445, 179);
            this.txtRate.Margin = new System.Windows.Forms.Padding(2);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(94, 26);
            this.txtRate.TabIndex = 59;
            this.txtRate.TextChanged += new System.EventHandler(this.txtRate_TextChanged);
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(537, 179);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(127, 26);
            this.txtTotal.TabIndex = 63;
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(537, 155);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(126, 22);
            this.lblTotal.TabIndex = 62;
            this.lblTotal.Text = "Total";
            // 
            // cboRategroup
            // 
            this.cboRategroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRategroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRategroup.FormattingEnabled = true;
            this.cboRategroup.Items.AddRange(new object[] {
            "Retail Price",
            "Wholesale Price"});
            this.cboRategroup.Location = new System.Drawing.Point(520, 119);
            this.cboRategroup.Margin = new System.Windows.Forms.Padding(2);
            this.cboRategroup.Name = "cboRategroup";
            this.cboRategroup.Size = new System.Drawing.Size(143, 28);
            this.cboRategroup.TabIndex = 65;
            this.cboRategroup.SelectedIndexChanged += new System.EventHandler(this.cboRategroup_SelectedIndexChanged);
            // 
            // lblRategroup
            // 
            this.lblRategroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRategroup.ForeColor = System.Drawing.Color.White;
            this.lblRategroup.Location = new System.Drawing.Point(399, 122);
            this.lblRategroup.Name = "lblRategroup";
            this.lblRategroup.Size = new System.Drawing.Size(117, 20);
            this.lblRategroup.TabIndex = 64;
            this.lblRategroup.Text = "Rate Group";
            // 
            // ItemGrid
            // 
            this.ItemGrid.AllowUserToAddRows = false;
            this.ItemGrid.AllowUserToDeleteRows = false;
            this.ItemGrid.AllowUserToResizeColumns = false;
            this.ItemGrid.AllowUserToResizeRows = false;
            this.ItemGrid.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.ItemGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemGrid.ColumnHeadersVisible = false;
            this.ItemGrid.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ItemGrid.DefaultCellStyle = dataGridViewCellStyle6;
            this.ItemGrid.Location = new System.Drawing.Point(22, 204);
            this.ItemGrid.Margin = new System.Windows.Forms.Padding(2);
            this.ItemGrid.MultiSelect = false;
            this.ItemGrid.Name = "ItemGrid";
            this.ItemGrid.ReadOnly = true;
            this.ItemGrid.RowHeadersVisible = false;
            this.ItemGrid.RowTemplate.Height = 24;
            this.ItemGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ItemGrid.Size = new System.Drawing.Size(641, 297);
            this.ItemGrid.TabIndex = 66;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Edit,
            this.Delete});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(108, 48);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // Edit
            // 
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(107, 22);
            this.Edit.Text = "Edit";
            // 
            // Delete
            // 
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(107, 22);
            this.Delete.Text = "Delete";
            // 
            // txtCGST
            // 
            this.txtCGST.Enabled = false;
            this.txtCGST.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCGST.Location = new System.Drawing.Point(185, 514);
            this.txtCGST.Margin = new System.Windows.Forms.Padding(2);
            this.txtCGST.Name = "txtCGST";
            this.txtCGST.Size = new System.Drawing.Size(118, 26);
            this.txtCGST.TabIndex = 68;
            // 
            // lblCash
            // 
            this.lblCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCash.ForeColor = System.Drawing.Color.White;
            this.lblCash.Location = new System.Drawing.Point(21, 517);
            this.lblCash.Name = "lblCash";
            this.lblCash.Size = new System.Drawing.Size(63, 20);
            this.lblCash.TabIndex = 67;
            this.lblCash.Text = "CGST";
            // 
            // txtSGST
            // 
            this.txtSGST.Enabled = false;
            this.txtSGST.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSGST.Location = new System.Drawing.Point(185, 544);
            this.txtSGST.Margin = new System.Windows.Forms.Padding(2);
            this.txtSGST.Name = "txtSGST";
            this.txtSGST.Size = new System.Drawing.Size(118, 26);
            this.txtSGST.TabIndex = 70;
            this.txtSGST.TextChanged += new System.EventHandler(this.txtDiscount_TextChanged);
            // 
            // lblDiscount
            // 
            this.lblDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.ForeColor = System.Drawing.Color.White;
            this.lblDiscount.Location = new System.Drawing.Point(22, 544);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(63, 20);
            this.lblDiscount.TabIndex = 69;
            this.lblDiscount.Text = "SGST";
            // 
            // txtIGST
            // 
            this.txtIGST.Enabled = false;
            this.txtIGST.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIGST.Location = new System.Drawing.Point(185, 574);
            this.txtIGST.Margin = new System.Windows.Forms.Padding(2);
            this.txtIGST.Name = "txtIGST";
            this.txtIGST.Size = new System.Drawing.Size(118, 26);
            this.txtIGST.TabIndex = 72;
            // 
            // lblBalance
            // 
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.ForeColor = System.Drawing.Color.White;
            this.lblBalance.Location = new System.Drawing.Point(22, 574);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(61, 20);
            this.lblBalance.TabIndex = 71;
            this.lblBalance.Text = "IGST";
            // 
            // txtBillTotal
            // 
            this.txtBillTotal.Enabled = false;
            this.txtBillTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBillTotal.Location = new System.Drawing.Point(488, 514);
            this.txtBillTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtBillTotal.Name = "txtBillTotal";
            this.txtBillTotal.Size = new System.Drawing.Size(175, 26);
            this.txtBillTotal.TabIndex = 74;
            this.txtBillTotal.TextChanged += new System.EventHandler(this.txtGrand_TextChanged);
            // 
            // lblGrand
            // 
            this.lblGrand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrand.ForeColor = System.Drawing.Color.White;
            this.lblGrand.Location = new System.Drawing.Point(377, 514);
            this.lblGrand.Name = "lblGrand";
            this.lblGrand.Size = new System.Drawing.Size(106, 20);
            this.lblGrand.TabIndex = 73;
            this.lblGrand.Text = "Bill Total";
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(398, 578);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(86, 34);
            this.btnPrint.TabIndex = 75;
            this.btnPrint.Text = "&Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(488, 578);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(86, 34);
            this.btnClear.TabIndex = 76;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(578, 578);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(86, 34);
            this.btnDelete.TabIndex = 77;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(307, 578);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 34);
            this.btnSave.TabIndex = 78;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.chkCashEntry);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(this.txtBillNoSearch);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.DtTo);
            this.panel1.Controls.Add(this.DtFrom);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cboCustomerSearch);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.SearchGrid);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(697, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(441, 623);
            this.panel1.TabIndex = 80;
            // 
            // chkCashEntry
            // 
            this.chkCashEntry.AutoSize = true;
            this.chkCashEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCashEntry.ForeColor = System.Drawing.Color.White;
            this.chkCashEntry.Location = new System.Drawing.Point(322, 3);
            this.chkCashEntry.Margin = new System.Windows.Forms.Padding(2);
            this.chkCashEntry.Name = "chkCashEntry";
            this.chkCashEntry.Size = new System.Drawing.Size(106, 24);
            this.chkCashEntry.TabIndex = 80;
            this.chkCashEntry.Text = "Cash Entry";
            this.chkCashEntry.UseVisualStyleBackColor = true;
            this.chkCashEntry.Visible = false;
            this.chkCashEntry.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label5.Location = new System.Drawing.Point(3, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 24);
            this.label5.TabIndex = 79;
            this.label5.Text = "Search";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(287, 101);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(68, 42);
            this.btnSearch.TabIndex = 78;
            this.btnSearch.Text = "S&earch";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(359, 102);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(69, 41);
            this.btnReset.TabIndex = 77;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtBillNoSearch
            // 
            this.txtBillNoSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBillNoSearch.Location = new System.Drawing.Point(116, 101);
            this.txtBillNoSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtBillNoSearch.Name = "txtBillNoSearch";
            this.txtBillNoSearch.Size = new System.Drawing.Size(134, 26);
            this.txtBillNoSearch.TabIndex = 76;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(16, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 75;
            this.label4.Text = "Bill No";
            // 
            // DtTo
            // 
            this.DtTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtTo.Location = new System.Drawing.Point(287, 72);
            this.DtTo.Margin = new System.Windows.Forms.Padding(2);
            this.DtTo.Name = "DtTo";
            this.DtTo.Size = new System.Drawing.Size(141, 26);
            this.DtTo.TabIndex = 74;
            // 
            // DtFrom
            // 
            this.DtFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtFrom.Location = new System.Drawing.Point(116, 71);
            this.DtFrom.Margin = new System.Windows.Forms.Padding(2);
            this.DtFrom.Name = "DtFrom";
            this.DtFrom.Size = new System.Drawing.Size(134, 26);
            this.DtFrom.TabIndex = 73;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(16, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 72;
            this.label3.Text = "Date Between";
            // 
            // cboCustomerSearch
            // 
            this.cboCustomerSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboCustomerSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboCustomerSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCustomerSearch.FormattingEnabled = true;
            this.cboCustomerSearch.Location = new System.Drawing.Point(116, 39);
            this.cboCustomerSearch.Margin = new System.Windows.Forms.Padding(2);
            this.cboCustomerSearch.Name = "cboCustomerSearch";
            this.cboCustomerSearch.Size = new System.Drawing.Size(312, 28);
            this.cboCustomerSearch.TabIndex = 71;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 70;
            this.label2.Text = "Customer";
            // 
            // SearchGrid
            // 
            this.SearchGrid.AllowUserToAddRows = false;
            this.SearchGrid.AllowUserToDeleteRows = false;
            this.SearchGrid.AllowUserToOrderColumns = true;
            this.SearchGrid.AllowUserToResizeColumns = false;
            this.SearchGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SearchGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.SearchGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SearchGrid.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.SearchGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SearchGrid.DefaultCellStyle = dataGridViewCellStyle7;
            this.SearchGrid.Location = new System.Drawing.Point(-2, 147);
            this.SearchGrid.Margin = new System.Windows.Forms.Padding(2);
            this.SearchGrid.MultiSelect = false;
            this.SearchGrid.Name = "SearchGrid";
            this.SearchGrid.ReadOnly = true;
            this.SearchGrid.RowHeadersVisible = false;
            this.SearchGrid.RowTemplate.Height = 24;
            this.SearchGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SearchGrid.Size = new System.Drawing.Size(441, 474);
            this.SearchGrid.TabIndex = 67;
            this.SearchGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SearchGrid_CellClick);
            this.SearchGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SearchGrid_CellContentClick);
            // 
            // cmdItemClear
            // 
            this.cmdItemClear.Location = new System.Drawing.Point(24, 178);
            this.cmdItemClear.Margin = new System.Windows.Forms.Padding(2);
            this.cmdItemClear.Name = "cmdItemClear";
            this.cmdItemClear.Size = new System.Drawing.Size(32, 22);
            this.cmdItemClear.TabIndex = 82;
            this.cmdItemClear.Text = "---";
            this.cmdItemClear.UseVisualStyleBackColor = true;
            this.cmdItemClear.Click += new System.EventHandler(this.cmdItemClear_Click);
            // 
            // itemView
            // 
            this.itemView.BackColor = System.Drawing.Color.White;
            this.itemView.Controls.Add(this.ItemDisplayGrid);
            this.itemView.Location = new System.Drawing.Point(144, 204);
            this.itemView.Margin = new System.Windows.Forms.Padding(2);
            this.itemView.Name = "itemView";
            this.itemView.Padding = new System.Windows.Forms.Padding(2, 0, 2, 2);
            this.itemView.Size = new System.Drawing.Size(451, 214);
            this.itemView.TabIndex = 83;
            this.itemView.TabStop = false;
            // 
            // ItemDisplayGrid
            // 
            this.ItemDisplayGrid.AllowUserToAddRows = false;
            this.ItemDisplayGrid.AllowUserToDeleteRows = false;
            this.ItemDisplayGrid.AllowUserToOrderColumns = true;
            this.ItemDisplayGrid.AllowUserToResizeColumns = false;
            this.ItemDisplayGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ItemDisplayGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            this.ItemDisplayGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ItemDisplayGrid.BackgroundColor = System.Drawing.Color.White;
            this.ItemDisplayGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemDisplayGrid.ColumnHeadersVisible = false;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ItemDisplayGrid.DefaultCellStyle = dataGridViewCellStyle9;
            this.ItemDisplayGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemDisplayGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.ItemDisplayGrid.Location = new System.Drawing.Point(2, 13);
            this.ItemDisplayGrid.Margin = new System.Windows.Forms.Padding(2);
            this.ItemDisplayGrid.MultiSelect = false;
            this.ItemDisplayGrid.Name = "ItemDisplayGrid";
            this.ItemDisplayGrid.ReadOnly = true;
            this.ItemDisplayGrid.RowHeadersVisible = false;
            this.ItemDisplayGrid.RowTemplate.Height = 24;
            this.ItemDisplayGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ItemDisplayGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ItemDisplayGrid.Size = new System.Drawing.Size(447, 199);
            this.ItemDisplayGrid.TabIndex = 68;
            this.ItemDisplayGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ItemDisplayGrid_CellClick);
            // 
            // txtItems
            // 
            this.txtItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItems.Location = new System.Drawing.Point(144, 179);
            this.txtItems.Margin = new System.Windows.Forms.Padding(2);
            this.txtItems.Name = "txtItems";
            this.txtItems.Size = new System.Drawing.Size(205, 26);
            this.txtItems.TabIndex = 84;
            this.txtItems.TextChanged += new System.EventHandler(this.txtItems_TextChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 42);
            this.label1.TabIndex = 85;
            this.label1.Text = "State and Code";
            // 
            // txtState
            // 
            this.txtState.Enabled = false;
            this.txtState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtState.Location = new System.Drawing.Point(121, 119);
            this.txtState.Margin = new System.Windows.Forms.Padding(2);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(143, 26);
            this.txtState.TabIndex = 86;
            // 
            // txtStateCode
            // 
            this.txtStateCode.Enabled = false;
            this.txtStateCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStateCode.Location = new System.Drawing.Point(268, 119);
            this.txtStateCode.Margin = new System.Windows.Forms.Padding(2);
            this.txtStateCode.Name = "txtStateCode";
            this.txtStateCode.Size = new System.Drawing.Size(82, 26);
            this.txtStateCode.TabIndex = 87;
            // 
            // txtCGSTPer
            // 
            this.txtCGSTPer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCGSTPer.Location = new System.Drawing.Point(109, 514);
            this.txtCGSTPer.Margin = new System.Windows.Forms.Padding(2);
            this.txtCGSTPer.Name = "txtCGSTPer";
            this.txtCGSTPer.Size = new System.Drawing.Size(59, 26);
            this.txtCGSTPer.TabIndex = 88;
            this.txtCGSTPer.TextChanged += new System.EventHandler(this.txtCGSTPer_TextChanged);
            // 
            // txtSGSTPer
            // 
            this.txtSGSTPer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSGSTPer.Location = new System.Drawing.Point(109, 544);
            this.txtSGSTPer.Margin = new System.Windows.Forms.Padding(2);
            this.txtSGSTPer.Name = "txtSGSTPer";
            this.txtSGSTPer.Size = new System.Drawing.Size(59, 26);
            this.txtSGSTPer.TabIndex = 89;
            this.txtSGSTPer.TextChanged += new System.EventHandler(this.txtSGSTPer_TextChanged);
            // 
            // txtIGSTPer
            // 
            this.txtIGSTPer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIGSTPer.Location = new System.Drawing.Point(109, 574);
            this.txtIGSTPer.Margin = new System.Windows.Forms.Padding(2);
            this.txtIGSTPer.Name = "txtIGSTPer";
            this.txtIGSTPer.Size = new System.Drawing.Size(59, 26);
            this.txtIGSTPer.TabIndex = 90;
            this.txtIGSTPer.TextChanged += new System.EventHandler(this.txtIGSTPer_TextChanged);
            // 
            // txtGrandTotal
            // 
            this.txtGrandTotal.Enabled = false;
            this.txtGrandTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrandTotal.Location = new System.Drawing.Point(488, 544);
            this.txtGrandTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtGrandTotal.Name = "txtGrandTotal";
            this.txtGrandTotal.Size = new System.Drawing.Size(175, 26);
            this.txtGrandTotal.TabIndex = 92;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(377, 544);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 20);
            this.label6.TabIndex = 91;
            this.label6.Text = "Grand Total";
            // 
            // txtGST
            // 
            this.txtGST.Enabled = false;
            this.txtGST.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGST.Location = new System.Drawing.Point(521, 19);
            this.txtGST.Margin = new System.Windows.Forms.Padding(2);
            this.txtGST.Name = "txtGST";
            this.txtGST.Size = new System.Drawing.Size(143, 26);
            this.txtGST.TabIndex = 94;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(399, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 20);
            this.label7.TabIndex = 93;
            this.label7.Text = "GST No";
            // 
            // frmSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1138, 623);
            this.Controls.Add(this.txtGST);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtGrandTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtIGSTPer);
            this.Controls.Add(this.txtSGSTPer);
            this.Controls.Add(this.txtCGSTPer);
            this.Controls.Add(this.txtStateCode);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.itemView);
            this.Controls.Add(this.cmdItemClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.txtBillTotal);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblGrand);
            this.Controls.Add(this.txtIGST);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.txtSGST);
            this.Controls.Add(this.txtCGST);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.lblCash);
            this.Controls.Add(this.ItemGrid);
            this.Controls.Add(this.cboRategroup);
            this.Controls.Add(this.lblRategroup);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtItemcode);
            this.Controls.Add(this.lblRate);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblItemname);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.DatePicker);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.txtBillno);
            this.Controls.Add(this.lblBillno);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblPlace);
            this.Controls.Add(this.cboCustomer);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.lblSlno);
            this.Controls.Add(this.txtItems);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmSales";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sale Voucher";
            this.Load += new System.EventHandler(this.frmSales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ItemGrid)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchGrid)).EndInit();
            this.itemView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ItemDisplayGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSlno;
        private System.Windows.Forms.ComboBox cboCustomer;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label lblPlace;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtBillno;
        private System.Windows.Forms.Label lblBillno;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker DatePicker;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblItemname;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.TextBox txtItemcode;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.ComboBox cboRategroup;
        private System.Windows.Forms.Label lblRategroup;
        private System.Windows.Forms.DataGridView ItemGrid;
        private System.Windows.Forms.TextBox txtCGST;
        private System.Windows.Forms.Label lblCash;
        private System.Windows.Forms.TextBox txtSGST;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.TextBox txtIGST;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.TextBox txtBillTotal;
        private System.Windows.Forms.Label lblGrand;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView SearchGrid;
        private System.Windows.Forms.Button cmdItemClear;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Edit;
        private System.Windows.Forms.ToolStripMenuItem Delete;
        private System.Windows.Forms.TextBox txtBillNoSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DtTo;
        private System.Windows.Forms.DateTimePicker DtFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboCustomerSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkCashEntry;
        private System.Windows.Forms.GroupBox itemView;
        private System.Windows.Forms.DataGridView ItemDisplayGrid;
        private System.Windows.Forms.TextBox txtItems;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtStateCode;
        private System.Windows.Forms.TextBox txtCGSTPer;
        private System.Windows.Forms.TextBox txtSGSTPer;
        private System.Windows.Forms.TextBox txtIGSTPer;
        private System.Windows.Forms.TextBox txtGrandTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGST;
        private System.Windows.Forms.Label label7;
    }
}