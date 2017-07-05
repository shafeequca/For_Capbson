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
            this.txtTin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTin_KeyDown);
            this.txtCST.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCst_KeyDown);
            this.txtPlace.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPlace_KeyDown);
            this.txtPhone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPhone_KeyDown);
            this.cboArea.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboArea_KeyDown);
            this.txtBalance.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBalance_KeyDown);
            this.txtBalance.KeyPress += new KeyPressEventHandler(this.NumberOnly_KeyPress);

        }
        private void NumberOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar == 8 || e.KeyChar == 46 || e.KeyChar == 13 || (e.KeyChar >= 48 && e.KeyChar <= 57)))
                e.Handled = true;
        }
        private void frmCustomerMaster_Load(object sender, EventArgs e)
        {
            comboLoad();
            GridShow();
        }
        private void comboLoad()
        {
            string query = "select areaId,Area from tblArea order By Area";
            cboArea.DataSource = Connections.Instance.ShowDataInGridView(query);
            cboArea.DisplayMember = "Area";
            cboArea.ValueMember = "areaId";

        }
        private void GridShow()
        {
            try
            {
                string query = "select cus.*,ar.Area from tblCustomer cus, tblArea ar where cus.areaId=ar.areaId and cus.Customer like '" + txtSearch.Text.Trim() + "%'  order by cus.areaId,cus.Customer";
                dataGridView1.DataSource = Connections.Instance.ShowDataInGridView(query);
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[2].Visible = false;
                dataGridView1.Columns[3].Visible = false;
                dataGridView1.Columns[4].Width = 50;
                dataGridView1.Columns[5].Visible = false;
                dataGridView1.Columns[6].Visible = false;
                dataGridView1.Columns[7].Width = 40;
                dataGridView1.Columns[8].Visible = false;
                dataGridView1.Columns[9].Visible = false;
                dataGridView1.Columns[10].Visible = false;
                dataGridView1.Columns[11].Width = 80;

            }
            catch { }
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            lblID.Text = "";
            txtBalance.Text = "";
            txtCST.Text = "";
            txtCustomer.Text = "";
            txtNotes.Text = "";
            txtPhone.Text = "";
            txtPlace.Text = "";
            txtSearch.Text = "";
            txtTin.Text = "";
            cboArea.SelectedIndex = 0;
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
                if (txtCustomer.Text.Trim() == "" || txtPlace.Text == "" || txtBalance.Text == "")
                    MessageBox.Show("Please enter the data");
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Do you want to save?", "Customer Master", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        string query = "insert into tblCustomer values('" + txtCustomer.Text.Trim() + "','" + txtTin.Text.Trim() + "','" + txtCST.Text.Trim() + "','" + txtPlace.Text.Trim() + "','" + txtPhone.Text.Trim() + "','" + cboArea.SelectedValue + "','" + Convert.ToDouble(txtBalance.Text) + "','" + txtNotes.Text.Trim() + "',0,'false')";
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
                        string query = "update tblCustomer set Customer='" + txtCustomer.Text.Trim() + "',Tin='" + txtTin.Text.Trim() + "',CST='" + txtCST.Text.Trim() + "',Place='" + txtPlace.Text.Trim() + "',Phone='" + txtPhone.Text.Trim() + "',areaId='" + cboArea.SelectedValue + "',creditBal='" + Convert.ToDouble(txtBalance.Text) + "',Notes='" + txtNotes.Text.Trim() + "' where custId='" + lblID.Text.Trim() + "'";
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
                txtTin.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtCST.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtPlace.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtPhone.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                cboArea.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString(); 
                txtBalance.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                txtNotes.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
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
                txtTin.Focus();
            }
        }
        private void txtTin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txtCST.Focus();
            }
        }
        private void txtCst_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txtPlace.Focus();
            }
        }
        private void txtPlace_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txtPhone.Focus();
            }
        }
        private void txtPhone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                cboArea.Focus();
            }
        }
        private void cboArea_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txtBalance.Focus();
            }
        }
        private void txtBalance_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txtNotes.Focus();
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
