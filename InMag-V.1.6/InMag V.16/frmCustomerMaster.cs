using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InMag_V._16
{
    public partial class frmCustomerMaster : Form
    {
        public frmCustomerMaster()
        {
            InitializeComponent();
            this.txtCustomer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCustomer_KeyDown);
            this.txtAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTin_KeyDown);
            this.txtGST.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCst_KeyDown);
            this.txtState.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPlace_KeyDown);
            this.txtStateCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtstatecode_KeyDown);
          

        }
        private void NumberOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar == 8 || e.KeyChar == 46 || e.KeyChar == 13 || (e.KeyChar >= 48 && e.KeyChar <= 57)))
                e.Handled = true;
        }
        private void frmCustomerMaster_Load(object sender, EventArgs e)
        {
            GridShow();
        }
        
        private void GridShow()
        {
            try
            {
                string query = "select * from tblCustomer where Customer like '" + txtSearch.Text.Trim() + "%'  order by Customer";
                dataGridView1.DataSource = Connections.Instance.ShowDataInGridView(query);
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[2].Visible = false;
                dataGridView1.Columns[3].Visible = false;
                dataGridView1.Columns[6].Visible = false;
               

            }
            catch { }
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            lblID.Text = "";
            
            txtGST.Text = "";
            txtCustomer.Text = "";
         
            txtStateCode.Text = "";
            txtState.Text = "";
            txtSearch.Text = "";
            txtAddress.Text = "";
            txtCustomer.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lblID.Text.Trim() == "")
                MessageBox.Show("No item selected to delete");
            else
            {
                DialogResult dialogResult = MessageBox.Show("All data under this customer would be deleted. Do you want to delete the customer", "Customer Master", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string query = "Delete from tblCustomer where custId='" + lblID.Text.Trim() + "'";
                    Connections.Instance.ExecuteQueries(query);
                    GridShow();
                    btnClear_Click(null, null);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (lblID.Text.Trim() == "")
            {
                //Insert
                if (txtCustomer.Text.Trim() == "")
                {
                    MessageBox.Show("Please enter the customer name");
                    txtCustomer.Focus();
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Do you want to save?", "Customer Master", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        string query = "insert into tblCustomer values('" + txtCustomer.Text.Trim() + "','" + txtAddress.Text.Trim() + "','" + txtGST.Text.Trim() + "','" + txtState.Text.Trim() + "','" + txtStateCode.Text.Trim() + "',0)";
                        Connections.Instance.ExecuteQueries(query);
                        GridShow();
                        btnClear_Click(null, null);
                    }
                }
            }
            else
            {
                //Update
                if (txtCustomer.Text.Trim() == "")
                    MessageBox.Show("Please enter the data");
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Do you want to save?", "Customer Master", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        string query = "update tblCustomer set Customer='" + txtCustomer.Text.Trim() + "',Address='" + txtAddress.Text.Trim() + "',GST='" + txtGST.Text.Trim() + "',state='" + txtState.Text.Trim() + "',state_code='" + txtStateCode.Text.Trim() + "' where custId='" + lblID.Text.Trim() + "'";
                        Connections.Instance.ExecuteQueries(query);
                        GridShow();
                        btnClear_Click(null, null);
                    }
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                lblID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtCustomer.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtAddress.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtGST.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtState.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtStateCode.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            GridShow();
        }
        private void txtCustomer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txtAddress.Focus();
            }
        }
        private void txtTin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txtGST.Focus();
            }
        }
        private void txtCst_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txtState.Focus();
            }
        }
        private void txtPlace_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txtStateCode.Focus();
            }
        }
        private void txtstatecode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btnSave_Click(null, null);
            }
        }
        
       
        
        private void txtCustomer_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtTin_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void cboArea_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtPlace_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtCST_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblID_Click(object sender, EventArgs e)
        {

        }
    }
}
