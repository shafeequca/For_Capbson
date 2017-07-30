using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using InMag_V._16.DataSet;
using CrystalDecisions.CrystalReports.Engine;

namespace InMag_V._16
{
    public partial class frmSales : Form
    {
        DataSet1 ds;
        public frmSales()
        {
            InitializeComponent();

            this.ItemDisplayGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ItemDisplayGrid_KeyDown);
            this.cboCustomer.SelectionChangeCommitted += new System.EventHandler(this.cboCustomer_SelectionChangeCommitted);
            this.cboCustomer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboCustomer_KeyDown);
            this.txtItemcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtItemcode_KeyDown);
            this.txtQuantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQuantity_KeyDown);
            this.txtItems.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtItems_KeyDown);
            this.txtRate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRate_KeyDown);
            this.txtRate.KeyPress += new KeyPressEventHandler(NumberOnly_KeyPress);
            this.txtItems.KeyPress += new KeyPressEventHandler(txtItems_KeyPress);
            this.txtCGST.KeyPress += new KeyPressEventHandler(NumberOnly_KeyPress);
            this.txtQuantity.KeyPress += new KeyPressEventHandler(NumberOnly_KeyPress);
            this.txtSGST.KeyPress += new KeyPressEventHandler(NumberOnly_KeyPress);
            this.txtCGSTPer.KeyPress += new KeyPressEventHandler(NumberOnly_KeyPress);
            this.txtIGST.KeyPress += new KeyPressEventHandler(NumberOnly_KeyPress);
            this.txtSGSTPer.KeyPress += new KeyPressEventHandler(NumberOnly_KeyPress);
            this.contextMenuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.Edit_Click);

            this.txtBillNoSearch.KeyPress += new KeyPressEventHandler(Search_KeyPress);
            this.cboCustomerSearch.KeyPress += new KeyPressEventHandler(Search_KeyPress);
            this.DtFrom.KeyPress += new KeyPressEventHandler(Search_KeyPress);
            this.DtTo.KeyPress += new KeyPressEventHandler(Search_KeyPress);

        }

        private void Search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                SearchGridLoad();
            }
        }
        private void NumberOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox tb = sender as TextBox;

            if (!(e.KeyChar == 8 || e.KeyChar == 46 || e.KeyChar == 13 || (e.KeyChar >= 48 && e.KeyChar <= 57)))
                e.Handled = true;
            else
            {
                if (e.KeyChar == 46 && tb.Text.Contains("."))
                {
                    e.Handled = true;
                }
            }
            if (e.KeyChar == 13)
            {
                if (tb.Name == "txtCash")
                    txtSGST.Focus();
                else if (tb.Name == "txtDiscount")
                    btnSave_Click(null, null);
                else if (tb.Name == "txtItems")
                    txtQuantity.Focus();
            }
        }
        private void frmSales_Load(object sender, EventArgs e)
        {
            ds = new DataSet1();
            comboLoad();
            txtItemcode.Tag = null;
            SetBillNo();
            SearchGridLoad();
            itemView.Visible = false;
        }
        private void SetBillNo()
        {
            string query = "Truncate table tblTemp";
            Connections.Instance.ExecuteQueries(query);
            query = "select billno from tblSettings";
            DataTable dt = (DataTable)Connections.Instance.ShowDataInGridView(query);
            if (dt.Rows.Count > 0)
                txtBillno.Text = (Convert.ToInt32(dt.Rows[0][0].ToString()) + 1).ToString();
            else
                txtBillno.Text = "1";
        
        }
        private void SearchGridLoad()
        {
            try
            {
                string chCondition="";
                if (chkCashEntry.Checked)
                    chCondition = "and s.Cash=0 order by c.Customer";
                else
                    chCondition = "order by s.BillNo DESC";

                string condition = "(s.BillDate>='" + DtFrom.Value.ToString("dd-MMM-yyyy") + "' and s.BillDate<='" + DtTo.Value.ToString("dd-MMM-yyyy") + "') " + chCondition;
                if (txtBillNoSearch.Text.Trim() != "")
                    condition = "s.BillNo='" + txtBillNoSearch.Text + "'";
                else if (cboCustomerSearch.SelectedIndex != -1 && cboCustomerSearch.Text !="")
                    condition = "(s.BillDate>='" + DtFrom.Value.ToString("dd-MMM-yyyy") + "' and s.BillDate<='" + DtTo.Value.ToString("dd-MMM-yyyy") + "' and s.custId='" + cboCustomerSearch.SelectedValue + "') " + chCondition;
                string query = "select s.saleId,s.BillNo as Bill_No,CONVERT(VARCHAR(11),s.BillDate,106) as Bill_Date,c.Customer,s.custId,s.BillTotal,s.CGSTPer,s.CGST,s.SGSTPer,s.SGST,s.IGSTPer,s.IGST,s.GrandTotal,s.vehicleno from tblSales s,tblCustomer c where s.custId=c.Custid  and " + condition;
                SearchGrid.DataSource = Connections.Instance.ShowDataInGridView(query);
                SearchGrid.Columns[0].Visible = false;
                SearchGrid.Columns[1].Width = 60;
                SearchGrid.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                SearchGrid.Columns[2].Width = 90;
                SearchGrid.Columns[3].Width = 200;
                SearchGrid.Columns[4].Visible = false;
                SearchGrid.Columns[5].Visible = false;
                SearchGrid.Columns[6].Visible = false;
                SearchGrid.Columns[7].Visible = false;
                SearchGrid.Columns[8].Visible = false;
                SearchGrid.Columns[9].Visible = false;
                SearchGrid.Columns[10].Visible = false;
                SearchGrid.Columns[11].Visible = false;
                SearchGrid.Columns[12].Visible = false;
                SearchGrid.Columns[13].Visible = false;
                SearchGrid.Columns[14].Visible = false;
            }
            catch { }
        }
        private void comboLoad()
        {
            try
            {
                string query = "select custId,Customer from tblCustomer order by Customer";
                cboCustomer.DataSource = Connections.Instance.ShowDataInGridView(query);
                cboCustomer.DisplayMember = "Customer";
                cboCustomer.ValueMember = "custId";
                cboCustomer.Text = "";
                cboCustomer.SelectedIndex = -1;

                cboCustomerSearch.DataSource = Connections.Instance.ShowDataInGridView(query);
                cboCustomerSearch.DisplayMember = "Customer";
                cboCustomerSearch.ValueMember = "custId";
                cboCustomerSearch.Text = "";
                cboCustomerSearch.SelectedIndex = -1;
            }
            catch { }
        }
        private void cboCustomer_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cboCustomer.SelectedValue != null && cboCustomer.Text !="")
            {
                System.Data.DataRowView DR = (System.Data.DataRowView)cboCustomer.Items[cboCustomer.SelectedIndex];
                string query = "select * from tblCustomer where custId='" + DR.Row[0].ToString() + "'";
                DataTable dt = (DataTable)Connections.Instance.ShowDataInGridView(query);
                if (dt.Rows.Count > 0)
                {
                    txtAddress.Text = dt.Rows[0][2].ToString();
                    txtGST.Text = dt.Rows[0][3].ToString();
                    txtState.Text = dt.Rows[0][4].ToString();
                    txtStateCode.Text = dt.Rows[0][5].ToString();

                }
            }
        }
        
        
               
        
       
        private void cboCustomer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                cboCustomer_SelectionChangeCommitted(null, null);
                txtItems.Focus();
            }
        }
        private void txtItemcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (txtItemcode.Text.Trim() != "")
                {
                    string query = "select itemId,Rate from tblItem where item_Code='" + txtItemcode.Text.Trim() + "'";
                    
                    DataTable dt = (DataTable)Connections.Instance.ShowDataInGridView(query);
                    if (dt.Rows.Count > 0)
                    {
                        txtItems.Tag = dt.Rows[0][0].ToString();
                        txtRate.Text = dt.Rows[0][1].ToString();
                        txtQuantity.Focus();
                    }
                    dt.Dispose();
                }
                else
                    txtItems.Focus();
            }
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            if (txtQuantity.Text.Trim() == "")
                txtQuantity.Text = "0";
            if (txtRate.Text.Trim() == "")
                txtRate.Text = "0";
            txtTotal.Text = (Convert.ToDouble(txtQuantity.Text) * Convert.ToDouble(txtRate.Text)).ToString();
        }

        private void txtRate_TextChanged(object sender, EventArgs e)
        {
            if (txtRate.Text.Trim() == "")
                txtRate.Text = "0";
            if (txtQuantity.Text.Trim() == "")
                txtQuantity.Text = "0";
            txtTotal.Text = (Convert.ToDouble(txtQuantity.Text) * Convert.ToDouble(txtRate.Text)).ToString();
        }
        private void txtQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txtRate.Focus();
            }
        }
        private void GridShow()
        {
            try
            {
                Type t = typeof(System.Windows.Forms.SystemInformation);
                
                string query = "select ROW_NUMBER() OVER(ORDER BY id) AS Row,itemcode,itemid,itemname,qty,rate,total from tblTemp;";
                ItemGrid.DataSource = Connections.Instance.ShowDataInGridView(query);
                ItemGrid.Columns[0].Width = 35;
                ItemGrid.Columns[1].Width = txtItemcode.Width;//86;
                ItemGrid.Columns[2].Visible = false;
                ItemGrid.Columns[3].Width = txtItems.Width - 1;//203;
                ItemGrid.Columns[4].Width = txtQuantity.Width;//128;
                ItemGrid.Columns[5].Width = txtRate.Width-1;//124;
                ItemGrid.Columns[6].Width = txtTotal.Width -5-  (ItemGrid.Controls.OfType<VScrollBar>().First().Visible? SystemInformation.VerticalScrollBarWidth:0); //145;
                if (ItemGrid.Rows.Count > 0)
                {
                    ItemGrid.FirstDisplayedScrollingRowIndex = ItemGrid.RowCount - 1;
                    ItemGrid.Rows[ItemGrid.RowCount - 1].Selected = true;
                }
                query = "select sum(total) from tblTemp";
                DataTable dt = (DataTable)Connections.Instance.ShowDataInGridView(query);
                if (dt.Rows.Count > 0)
                    txtBillTotal.Text = dt.Rows[0][0].ToString();
            }
            catch { }
        }
        private void txtRate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (txtItems.Text.Trim() == "" || txtItems.Tag == null || txtQuantity.Text.Trim() == "" || txtQuantity.Text.Trim() == "0" || txtRate.Text.Trim() == "" || txtRate.Text.Trim() == "0")
                {
                    MessageBox.Show("Please enter the data");
                    txtItems.Focus();
                }
                else
                {
                    string query = "select Current_Stock from tblItem where itemId='" + txtItems.Tag.ToString() + "'";
                    DataTable dt = (DataTable)Connections.Instance.ShowDataInGridView(query);
                    query = "select qty from tblTemp where itemId='" + txtItems.Tag.ToString() + "'";
                    DataTable dt1 = (DataTable)Connections.Instance.ShowDataInGridView(query);
                    if (dt1.Rows.Count > 0)
                    {
                        if (txtBillno.Tag == null)
                        {
                            if (txtItemcode.Tag == null)
                            {
                                double newQty = Convert.ToDouble(txtQuantity.Text) + Convert.ToDouble(dt1.Rows[0][0].ToString());
                                double newTotal = newQty * Convert.ToDouble(txtRate.Text);
                                if (Convert.ToDouble(dt.Rows[0][0].ToString()) < newQty)
                                {
                                    DialogResult dialogResult = MessageBox.Show("No sufficient stock." + Environment.NewLine + "Do you want to continue with negative stock?", "Sale Voucher", MessageBoxButtons.YesNo);
                                    if (dialogResult == DialogResult.Yes)
                                        query = "update tblTemp set Qty='" + newQty + "',rate='" + Convert.ToDouble(txtRate.Text.Trim()) + "',total='" + newTotal + "' where itemId='" + txtItems.Tag.ToString() + "'";
                                }
                                else
                                    query = "update tblTemp set Qty='" + newQty + "',rate='" + Convert.ToDouble(txtRate.Text.Trim()) + "',total='" + newTotal + "' where itemId='" + txtItems.Tag.ToString() + "'";
                            }
                            else
                            {
                                if (Convert.ToDouble(dt.Rows[0][0].ToString()) < Convert.ToDouble(txtQuantity.Text))
                                {
                                    DialogResult dialogResult = MessageBox.Show("No sufficient stock." + Environment.NewLine + "Do you want to continue with negative stock?", "Sale Voucher", MessageBoxButtons.YesNo);
                                    if (dialogResult == DialogResult.Yes)
                                        query = "update tblTemp set Qty='" + Convert.ToDouble(txtQuantity.Text.Trim()) + "',rate='" + Convert.ToDouble(txtRate.Text.Trim()) + "',total='" + Convert.ToDouble(txtTotal.Text.Trim()) + "' where itemId='" + Convert.ToDouble(txtItemcode.Tag.ToString()) + "'";
                                }
                                else
                                    query = "update tblTemp set Qty='" + Convert.ToDouble(txtQuantity.Text.Trim()) + "',rate='" + Convert.ToDouble(txtRate.Text.Trim()) + "',total='" + Convert.ToDouble(txtTotal.Text.Trim()) + "' where itemId='" + Convert.ToDouble(txtItemcode.Tag.ToString()) + "'";
                            }
                        }
                        else
                        {
                            if (txtItemcode.Tag == null)
                            {
                                double newQty = Convert.ToDouble(txtQuantity.Text) + Convert.ToDouble(dt1.Rows[0][0].ToString());
                                double newTotal = newQty * Convert.ToDouble(txtRate.Text);
                                query = "select qty from tblSaleTrans where itemId='" + txtItems.Tag.ToString() + "' and saleId='" + txtBillno.Tag.ToString() + "'";
                                DataTable dt2 = (DataTable)Connections.Instance.ShowDataInGridView(query);
                                if (Convert.ToDouble(dt.Rows[0][0].ToString()) < (newQty-Convert.ToDouble(dt2.Rows[0][0].ToString())))
                                {
                                    DialogResult dialogResult = MessageBox.Show("No sufficient stock." + Environment.NewLine + "Do you want to continue with negative stock?", "Sale Voucher", MessageBoxButtons.YesNo);
                                    if (dialogResult == DialogResult.Yes)
                                        query = "update tblTemp set Qty='" + newQty + "',rate='" + Convert.ToDouble(txtRate.Text.Trim()) + "',total='" + newTotal + "' where itemId='" + txtItems.Tag.ToString() + "'";
                                }
                                else
                                    query = "update tblTemp set Qty='" + newQty + "',rate='" + Convert.ToDouble(txtRate.Text.Trim()) + "',total='" + newTotal + "' where itemId='" + txtItems.Tag.ToString() + "'";
                            }
                            else
                            {
                                query = "select qty from tblSaleTrans where itemId='" + txtItems.Tag.ToString() + "' and saleId='" + txtBillno.Tag.ToString() + "'";
                                DataTable dt2 = (DataTable)Connections.Instance.ShowDataInGridView(query);
                                if (Convert.ToDouble(dt.Rows[0][0].ToString()) < (Convert.ToDouble(txtQuantity.Text) - Convert.ToDouble(dt2.Rows[0][0].ToString())))
                                {
                                    DialogResult dialogResult = MessageBox.Show("No sufficient stock." + Environment.NewLine + "Do you want to continue with negative stock?", "Sale Voucher", MessageBoxButtons.YesNo);
                                    if (dialogResult == DialogResult.Yes)
                                        query = "update tblTemp set Qty='" + Convert.ToDouble(txtQuantity.Text.Trim()) + "',rate='" + Convert.ToDouble(txtRate.Text.Trim()) + "',total='" + Convert.ToDouble(txtTotal.Text.Trim()) + "' where itemId='" + Convert.ToDouble(txtItemcode.Tag.ToString()) + "'";
                                }
                                else
                                    query = "update tblTemp set Qty='" + Convert.ToDouble(txtQuantity.Text.Trim()) + "',rate='" + Convert.ToDouble(txtRate.Text.Trim()) + "',total='" + Convert.ToDouble(txtTotal.Text.Trim()) + "' where itemId='" + Convert.ToDouble(txtItemcode.Tag.ToString()) + "'";
                            }
                        }
                    }
                    else
                    {
                        double exQty = 0;
                        if (txtBillno.Tag != null)
                        {
                            query = "select qty from tblSaleTrans where itemId='" + txtItems.Tag.ToString() + "' and saleId='" + txtBillno.Tag.ToString() + "'";
                            DataTable dt3 = (DataTable)Connections.Instance.ShowDataInGridView(query);
                            exQty = Convert.ToDouble(dt.Rows[0][0].ToString());
                        }
                        if (Convert.ToDouble(dt.Rows[0][0].ToString()) < (Convert.ToDouble(txtQuantity.Text)-exQty))
                        {
                            DialogResult dialogResult = MessageBox.Show("No sufficient stock." + Environment.NewLine + "Do you want to continue with negative stock?", "Sale Voucher", MessageBoxButtons.YesNo);
                            if (dialogResult == DialogResult.Yes)
                                query = "insert into tblTemp values('" + txtItemcode.Text.Trim() + "','" + txtItems.Tag.ToString() + "','" + txtItems.Text.Trim() + "','" + Convert.ToDouble(txtQuantity.Text.Trim()) + "','" + Convert.ToDouble(txtRate.Text.Trim()) + "','" + Convert.ToDouble(txtTotal.Text.Trim()) + "')";
                        }
                        else
                            query = "insert into tblTemp values('" + txtItemcode.Text.Trim() + "','" + txtItems.Tag.ToString() + "','" + txtItems.Text.Trim() + "','" + Convert.ToDouble(txtQuantity.Text.Trim()) + "','" + Convert.ToDouble(txtRate.Text.Trim()) + "','" + Convert.ToDouble(txtTotal.Text.Trim()) + "')";
                    }
                    Connections.Instance.ExecuteQueries(query);
                    dt.Dispose();
                    dt1.Dispose();
                    GridShow();
                    cmdItemClear_Click(null, null);
                }
            }
        }
        private void cmdItemClear_Click(object sender, EventArgs e)
        {
            txtItemcode.Tag = null;
            txtItemcode.Enabled = true;
            txtItemcode.Text ="";
            txtItems.Enabled = true;
            txtItems.Tag = null;
            txtItems.Text = "";
            txtQuantity.Text = "0";
            txtRate.Text = "0";
            txtItems.Focus();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
        private void Edit_Click(object sender, ToolStripItemClickedEventArgs e)
        {
            if (ItemGrid.SelectedRows.Count > 0)
            {
                int rowno = ItemGrid.SelectedRows[0].Index;
                ToolStripItem item = e.ClickedItem;
                if (item.Name == "Edit")
                {
                    txtItemcode.Enabled = false;
                    txtItems.Enabled = false;
                    txtItemcode.Text = ItemGrid.Rows[rowno].Cells[1].Value.ToString();
                    txtItems.Tag = ItemGrid.Rows[rowno].Cells[2].Value.ToString();
                    txtQuantity.Text  = ItemGrid.Rows[rowno].Cells[4].Value.ToString();
                    txtRate.Text = ItemGrid.Rows[rowno].Cells[5].Value.ToString();
                    txtItemcode.Tag = ItemGrid.Rows[rowno].Cells[2].Value.ToString();
                    txtQuantity.Focus();
                }
                else if (item.Name == "Delete")
                {
                    string query = "delete from tblTemp where itemId='" + ItemGrid.Rows[rowno].Cells[2].Value.ToString() + "'";
                    Connections.Instance.ExecuteQueries(query);
                    GridShow();
                }
            }
        }

        
        private void Calculation()
        {
            if (txtCGSTPer.Text == "")
                txtCGSTPer.Text = "0";
            if (txtBillTotal.Text == "")
                txtBillTotal.Text = "0";
            if (txtIGSTPer.Text == "")
                txtIGSTPer.Text = "0";
            if (txtSGSTPer.Text == "")
                txtSGSTPer.Text = "0";
            txtCGST.Text = (Convert.ToDouble(txtBillTotal.Text) * (Convert.ToDouble(txtCGSTPer.Text) / 100)).ToString();
            txtSGST.Text = (Convert.ToDouble(txtBillTotal.Text) * (Convert.ToDouble(txtSGSTPer.Text) / 100)).ToString();
            txtIGST.Text = (Convert.ToDouble(txtBillTotal.Text) * (Convert.ToDouble(txtIGSTPer.Text) / 100)).ToString();
            txtGrandTotal.Text = (Convert.ToDouble(txtBillTotal.Text) + Convert.ToDouble(txtCGST.Text) + Convert.ToDouble(txtSGST.Text) + Convert.ToDouble(txtIGST.Text)).ToString();
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            Calculation();

        }

        private void txtCBalance_TextChanged(object sender, EventArgs e)
        {
            Calculation();
        }

        private void txtGrand_TextChanged(object sender, EventArgs e)
        {
            Calculation();
        }

        private void cboRategroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemGrid.Rows.Count > 0)
            {
                for (int i = 0; i < ItemGrid.Rows.Count; i++)
                {
                    string query = "select rate from tblItem where itemId='" + ItemGrid.Rows[i].Cells[2].Value + "'";
                    DataTable dt = (DataTable)Connections.Instance.ShowDataInGridView(query);
                    query = "update tblTemp set rate='" + Convert.ToDouble(dt.Rows[0][0].ToString()) + "',Total='" + Convert.ToDouble(dt.Rows[0][0].ToString()) * Convert.ToDouble(ItemGrid.Rows[i].Cells[4].Value) + "' where itemId='" + ItemGrid.Rows[i].Cells[2].Value + "'";
                    Connections.Instance.ExecuteQueries(query);
                }
                GridShow();
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBillno.Tag = null;
            
            cboCustomer.Enabled = true;
            txtAddress.Text = "";
            txtSGSTPer.Text = "0";
            cmdItemClear_Click(null, null);
            ItemGrid.DataSource = null;
            txtBillTotal.Text = "0";
            txtCGSTPer.Text = "0";
            txtIGSTPer.Text = "0";
            txtVehicle.Text = "";
            txtState.Text = "";
            txtStateCode.Text = "";
            txtGST.Text = "";
            SetBillNo();
            cboCustomer.SelectedIndex = -1;
            cboCustomer.Text = "";
            btnReset_Click(null, null);
            btnSearch_Click(null,null);
            cboCustomer.Focus();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchGridLoad();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cboCustomerSearch.SelectedValue = -1;
            DtFrom.Value = DateTime.Today;
            DtTo.Value = DateTime.Today;
            txtBillNoSearch.Text = "";
            SearchGridLoad();
            cboCustomer.Focus();
        }

        private void SearchGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //string query = "BillTotal,s.CGSTPer,s.CGST,s.SGSTPer,s.SGST,s.IGSTPer,s.IGST,s.GrandTotal from tblSales s,tblCustomer c where s.custId=c.Custid  and " + condition;

                txtBillno.Tag = SearchGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtBillno.Text = SearchGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                DatePicker.Value = Convert.ToDateTime(SearchGrid.Rows[e.RowIndex].Cells[2].Value);
                cboCustomer.SelectedValue = SearchGrid.Rows[e.RowIndex].Cells[4].Value.ToString();
                cboCustomer_SelectionChangeCommitted(null, null);
                cboCustomer.Text = SearchGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtBillTotal.Text = SearchGrid.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtCGSTPer.Text = SearchGrid.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtCGST.Text = SearchGrid.Rows[e.RowIndex].Cells[7].Value.ToString();
                txtSGSTPer.Text = SearchGrid.Rows[e.RowIndex].Cells[8].Value.ToString();
                txtSGST.Text = SearchGrid.Rows[e.RowIndex].Cells[9].Value.ToString();
                txtIGSTPer.Text = SearchGrid.Rows[e.RowIndex].Cells[10].Value.ToString();
                txtIGST.Text = SearchGrid.Rows[e.RowIndex].Cells[11].Value.ToString();
                txtGrandTotal.Text = SearchGrid.Rows[e.RowIndex].Cells[12].Value.ToString();
                txtVehicle.Text = SearchGrid.Rows[e.RowIndex].Cells[13].Value.ToString();
                cboCustomer.Enabled = false;
                string query = "truncate table tblTemp";
                Connections.Instance.ExecuteQueries(query);
                query = "insert into tblTemp select i.Item_Code,i.itemId,i.Item_Name,s.qty,s.rate,s.total from tblSaleTrans s,tblItem i where s.itemId=i.itemId and saleId='" + txtBillno.Tag.ToString() + "'";
                Connections.Instance.ExecuteQueries(query);
                GridShow();
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cboCustomer.SelectedIndex == -1 || txtBillno.Text == "")
            {
                MessageBox.Show("Please enter the data");
                cboCustomer.Focus();
            }
            else
            {
                //if (ItemGrid.Rows.Count == 0)
                //    MessageBox.Show("Please add items");
                //else
                //{
                DialogResult dialogResult = MessageBox.Show("Do you want to save this bill?", "Sale Voucher", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string query = "";
                    if (txtBillno.Tag == null)
                    {
                        query = "insert into tblSales values('" + txtBillno.Text + "','" + DatePicker.Value.ToString("dd-MMM-yyyy") + "','" + cboCustomer.SelectedValue + "','" + Convert.ToDouble(txtBillTotal.Text) + "','" + Convert.ToDouble(txtCGSTPer.Text) + "','" + Convert.ToDouble(txtCGST.Text) + "','" + Convert.ToDouble(txtSGSTPer.Text) + "','" + Convert.ToDouble(txtSGST.Text) + "','" + Convert.ToDouble(txtIGSTPer.Text) + "','" + Convert.ToDouble(txtIGST.Text) + "','" + Convert.ToDouble(txtGrandTotal.Text) + "','" + Convert.ToDouble(txtGrandTotal.Text) + "'),'"+ txtVehicle.Text +"'";
                        Connections.Instance.ExecuteQueries(query);
                        query = "select ident_current('tblSales')";
                        DataTable dt = (DataTable)Connections.Instance.ShowDataInGridView(query);
                        int id = Convert.ToInt32(dt.Rows[0][0].ToString());
                        for (int i = 0; i < ItemGrid.Rows.Count; i++)
                        {
                            query = "insert into tblSaleTrans values('" + id + "','" + ItemGrid.Rows[i].Cells[2].Value + "','" + ItemGrid.Rows[i].Cells[4].Value + "','" + ItemGrid.Rows[i].Cells[5].Value + "','" + ItemGrid.Rows[i].Cells[6].Value + "','false')";
                            Connections.Instance.ExecuteQueries(query);
                            query = "update tblItem set Current_Stock=Current_Stock-'" + ItemGrid.Rows[i].Cells[4].Value + "' where itemId='" + ItemGrid.Rows[i].Cells[2].Value + "'";
                            Connections.Instance.ExecuteQueries(query);
                        }
                        query = "update tblSettings set BillNo=BillNo+1";
                        Connections.Instance.ExecuteQueries(query);

                    }
                    else
                    {
                        //update
                        query = "update tblSales set BillDate='" + DatePicker.Value.ToString("dd-MMM-yyyy") + "',GrandTotal='" + Convert.ToDouble(txtGrandTotal.Text) + "',Cash='" + Convert.ToDouble(txtGrandTotal.Text) + "',BillTotal='" + Convert.ToDouble(txtBillTotal.Text) + "',CGSTPer='" + Convert.ToDouble(txtCGSTPer.Text) + "',CGST='" + Convert.ToDouble(txtCGST.Text) + "',SGSTPer='" + Convert.ToDouble(txtSGSTPer.Text) + "',SGST='" + Convert.ToDouble(txtSGST.Text) + "',IGSTPer='" + Convert.ToDouble(txtIGSTPer.Text) + "',IGST='" + Convert.ToDouble(txtIGST.Text) + "',vehicleno='"+ txtVehicle.Text +"'  where saleId='" + txtBillno.Tag.ToString() + "'";
                        Connections.Instance.ExecuteQueries(query);
                        query = "select itemId,qty from tblSaletrans where saleId='" + txtBillno.Tag.ToString() + "'";
                       
                        DataTable dt = (DataTable)Connections.Instance.ShowDataInGridView(query);
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            query = "update tblItem set Current_Stock=Current_Stock+'" + Convert.ToDouble(dt.Rows[i][1].ToString()) + "' where itemId='" + dt.Rows[i][0].ToString() + "'";
                            Connections.Instance.ExecuteQueries(query);
                        }
                        query = "delete from tblSaletrans where saleId='" + txtBillno.Tag.ToString() + "'";
                        Connections.Instance.ExecuteQueries(query);
                        for (int i = 0; i < ItemGrid.Rows.Count; i++)
                        {
                            query = "insert into tblSaleTrans values('" + txtBillno.Tag.ToString() + "','" + ItemGrid.Rows[i].Cells[2].Value + "','" + ItemGrid.Rows[i].Cells[4].Value + "','" + ItemGrid.Rows[i].Cells[5].Value + "','" + ItemGrid.Rows[i].Cells[6].Value + "','false')";
                            Connections.Instance.ExecuteQueries(query);
                            query = "update tblItem set Current_Stock=Current_Stock-'" + ItemGrid.Rows[i].Cells[4].Value + "' where itemId='" + ItemGrid.Rows[i].Cells[2].Value + "'";
                            Connections.Instance.ExecuteQueries(query);
                        }

                    }
                    dialogResult = MessageBox.Show("Do you want to print this bill?", "Sale Voucher", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        string query1 = "select t.ItemName as Items,t.Qty as Qty,t.Rate as Rate,t.Total as Total," + txtCGSTPer.Text + " as CGSTPER,t.Total * " + txtCGSTPer.Text + "/100 AS CGST," + txtSGSTPer.Text + " as SGSTPER,t.Total * " + txtSGSTPer.Text + "/100 AS SGST," + txtIGSTPer.Text + " as IGSTPER,t.Total * " + txtIGSTPer.Text + "/100 AS IGST, (t.Total * " + txtCGSTPer.Text + "/100)+(t.Total * " + txtSGSTPer.Text + "/100)+(t.Total * " + txtIGSTPer.Text + "/100) AS GSTTotal from tblTemp t,tblItem i where t.ItemId=i.ItemId";
                        DataTable dt = (DataTable)Connections.Instance.ShowDataInGridView(query1);
                        DataTable dtCloned = dt.Clone();
                        dtCloned.Columns[4].DataType = typeof(Decimal);
                        dtCloned.Columns[5].DataType = typeof(Decimal);
                        dtCloned.Columns[6].DataType = typeof(Decimal);
                        dtCloned.Columns[7].DataType = typeof(Decimal);
                        dtCloned.Columns[8].DataType = typeof(Decimal);
                        dtCloned.Columns[9].DataType = typeof(Decimal);
                        foreach (DataRow row in dt.Rows)
                        {
                            dtCloned.ImportRow(row);
                        }
                        ds.Tables["Bill"].Clear();
                        ds.Tables["Bill"].Merge(dtCloned);

                        ReportDocument cryRpt = new ReportDocument();
                        cryRpt.Load(System.IO.Path.GetDirectoryName(Application.ExecutablePath).ToString() + @"\Reports\GSTBIll.rpt");
                        cryRpt.DataDefinition.FormulaFields[1].Text = "'"+ txtBillno.Text +"'";
                        cryRpt.DataDefinition.FormulaFields[2].Text = "'" + DatePicker.Value.ToString("dd-MM-yyyy") + "'";
                        cryRpt.DataDefinition.FormulaFields[3].Text = "'" + txtState.Text  + "'";
                        cryRpt.DataDefinition.FormulaFields[4].Text = "'" + txtStateCode.Text  + "'";
                        cryRpt.DataDefinition.FormulaFields[5].Text = "'" + cboCustomer.Text + "'";
                        string addd = txtAddress.Text.Replace("\r", string.Empty).Replace("\n", "^");
                        cryRpt.DataDefinition.FormulaFields[6].Text = "'" + addd + "'";
                        cryRpt.DataDefinition.FormulaFields[7].Text = "'" + txtGST.Text + "'";
                        cryRpt.DataDefinition.FormulaFields[8].Text = "'" + txtVehicle.Text  + "'";
                        cryRpt.DataDefinition.FormulaFields[9].Text = "'" + txtBillTotal.Text  + "'";
                        cryRpt.DataDefinition.FormulaFields[10].Text = "'" + txtSGST.Text + "'";
                        cryRpt.DataDefinition.FormulaFields[11].Text = "'" + txtIGST.Text + "'";
                        double gst = Convert.ToDouble(txtCGST.Text) + Convert.ToDouble(txtSGST.Text) + Convert.ToDouble(txtIGST.Text);
                        cryRpt.DataDefinition.FormulaFields[12].Text = "'" + gst + "'";
                        cryRpt.DataDefinition.FormulaFields[13].Text = "'" + txtGrandTotal.Text + "'";
                        cryRpt.DataDefinition.FormulaFields[14].Text = "'" + txtCGST.Text + "'";
                        
                        //cryRpt.DataDefinition.FormulaFields[16].Text = "'" + ConvertNumbertoWords(Convert.ToInt64(txtGrandTotal.Text)) + "'";

                        cryRpt.SetDataSource(ds);
                        cryRpt.Refresh();
                        cryRpt.PrintToPrinter(1, true, 0, 0);
                    }

                    query = "truncate table tblTemp";
                    Connections.Instance.ExecuteQueries(query);

                    btnClear_Click(null, null);
                    //}
                }
            }
        }

        public string ConvertNumbertoWords(long number)
        {
            if (number == 0) return "ZERO";
            if (number < 0) return "minus " + ConvertNumbertoWords(Math.Abs(number));
            string words = "";
            if ((number / 1000000) > 0)
            {
                words += ConvertNumbertoWords(number / 100000) + " LAKES ";
                number %= 1000000;
            }
            if ((number / 1000) > 0)
            {
                words += ConvertNumbertoWords(number / 1000) + " THOUSAND ";
                number %= 1000;
            }
            if ((number / 100) > 0)
            {
                words += ConvertNumbertoWords(number / 100) + " HUNDRED ";
                number %= 100;
            }
            //if ((number / 10) > 0)  
            //{  
            // words += ConvertNumbertoWords(number / 10) + " RUPEES ";  
            // number %= 10;  
            //}  
            if (number > 0)
            {
                if (words != "") words += "AND ";
                var unitsMap = new[]   
        {  
            "ZERO", "ONE", "TWO", "THREE", "FOUR", "FIVE", "SIX", "SEVEN", "EIGHT", "NINE", "TEN", "ELEVEN", "TWELVE", "THIRTEEN", "FOURTEEN", "FIFTEEN", "SIXTEEN", "SEVENTEEN", "EIGHTEEN", "NINETEEN"  
        };
                var tensMap = new[]   
        {  
            "ZERO", "TEN", "TWENTY", "THIRTY", "FORTY", "FIFTY", "SIXTY", "SEVENTY", "EIGHTY", "NINETY"  
        };
                if (number < 20) words += unitsMap[number];
                else
                {
                    words += tensMap[number / 10];
                    if ((number % 10) > 0) words += " " + unitsMap[number % 10];
                }
            }
            return words;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtBillno.Tag == null)
                MessageBox.Show("Please select a bill to delete");
            else
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to delete the bill?", "Sale Voucher", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string query = "delete from tblSales where saleId='" + txtBillno.Tag.ToString() + "'";
                    Connections.Instance.ExecuteQueries(query);
                    query = "select itemid,qty from tblSaletrans where saleId='" + txtBillno.Tag.ToString() + "'";
                    DataTable dt = (DataTable)Connections.Instance.ShowDataInGridView(query);
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        query = "update tblItem set Current_Stock=Current_Stock+'" + Convert.ToDouble(dt.Rows[i][1].ToString()) + "' where itemId='" + dt.Rows[i][0].ToString() + "'";
                        Connections.Instance.ExecuteQueries(query);
                    }
                    query = "delete from tblSaletrans where saleId='" + txtBillno.Tag.ToString() + "'";
                    Connections.Instance.ExecuteQueries(query);
                    SearchGridLoad();
                    btnClear_Click(null, null);
                }
            }
               
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            btnSave_Click(null, null);
        }

        private void cboArea_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboAreaSearch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            btnSearch_Click(null, null);
        }

        private void txtItemcode_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtItems_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (e.KeyChar == 13)
            {
                
                    txtQuantity.Focus();
            }
        }
        private void txtItems_TextChanged(object sender, EventArgs e)
        {
            if (txtItems.Text.Trim() != "")
            {
                itemView.Visible = false;
                string query = "select itemId,Item_Code,Item_Name,Rate,WRate from tblitem where Item_Name like '" + txtItems.Text + "%';";
                ItemDisplayGrid.DataSource = Connections.Instance.ShowDataInGridView(query);
                if (ItemDisplayGrid.Rows.Count == 1 && txtItems.Text != ItemDisplayGrid.Rows[0].Cells[2].Value.ToString())
                {

                    txtItems.Tag = ItemDisplayGrid.Rows[0].Cells[0].Value.ToString();
                    txtItemcode.Text = ItemDisplayGrid.Rows[0].Cells[1].Value.ToString();
                    txtRate.Text = ItemDisplayGrid.Rows[0].Cells[3].Value.ToString();
                    itemView.Visible = false;
                    txtQuantity.Focus();
                    txtItems.Text = ItemDisplayGrid.Rows[0].Cells[2].Value.ToString();
                }
                else if (ItemDisplayGrid.Rows.Count == 1 && txtItems.Text == ItemDisplayGrid.Rows[0].Cells[2].Value.ToString())
                {
                    itemView.Visible = false;
                }
                else
                {
                    itemView.Visible = true;
                    ItemDisplayGrid.Columns[0].Visible = false;
                    ItemDisplayGrid.Columns[1].Visible = false;
                    ItemDisplayGrid.Columns[3].Visible = false;
                    ItemDisplayGrid.Columns[4].Visible = false;
                    ItemDisplayGrid.ClearSelection();
                }
            }
        }

        private void txtItems_KeyDown(object sender, KeyEventArgs e)
        {

            if (ItemDisplayGrid.Rows.Count > 1 && e.KeyCode == Keys.Down)
            {
                ItemDisplayGrid.Focus();
                ItemDisplayGrid.Rows[0].Selected = true;

            }
            else if (e.KeyCode == Keys.Escape)
            {
                itemView.Visible = false;
            }
        }
        private void ItemDisplayGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter && ItemDisplayGrid.Rows.Count > 0)
            {
                int r = ItemDisplayGrid.CurrentRow.Index;
                txtItems.Tag = ItemDisplayGrid.Rows[r].Cells[0].Value.ToString();
                txtItemcode.Text = ItemDisplayGrid.Rows[r].Cells[1].Value.ToString();
                txtRate.Text = ItemDisplayGrid.Rows[r].Cells[3].Value.ToString();
                txtQuantity.Focus();
                txtItems.Text = ItemDisplayGrid.Rows[r].Cells[2].Value.ToString();
                itemView.Visible = false;
            }
            else if (e.KeyData == Keys.Escape)
            {
                itemView.Visible = false;
                txtItems.Focus();
            }
        }
        private void ItemDisplayGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int r = ItemDisplayGrid.CurrentRow.Index;
                txtItems.Tag = ItemDisplayGrid.Rows[r].Cells[0].Value.ToString();
                txtItemcode.Text = ItemDisplayGrid.Rows[r].Cells[1].Value.ToString();
                txtRate.Text = ItemDisplayGrid.Rows[r].Cells[3].Value.ToString();
                txtQuantity.Focus();
                txtItems.Text = ItemDisplayGrid.Rows[r].Cells[2].Value.ToString();
                itemView.Visible = false;
            }
        }

        private void txtCGSTPer_TextChanged(object sender, EventArgs e)
        {
            Calculation();
        }

        private void txtSGSTPer_TextChanged(object sender, EventArgs e)
        {
            Calculation();
        }

        private void txtIGSTPer_TextChanged(object sender, EventArgs e)
        {
            Calculation();
        }

        private void SearchGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        


    }
}
