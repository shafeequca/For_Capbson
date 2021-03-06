﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InMag_V._16
{
    public partial class frmItemMaster : Form
    {

        public frmItemMaster()
        {
            InitializeComponent();
            this.txtPurchaseRate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPurchaseRate_KeyDown);
            this.txtItemCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtItemCode_KeyDown);

            this.txtRetailRate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRetailRate_KeyDown);
            this.txtStock.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtStock_KeyDown);
            this.txtWholeSale.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtWholeSale_KeyDown);

            this.txtPurchaseRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberOnly_KeyPress);
            this.txtRetailRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberOnly_KeyPress);
            this.txtStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberOnly_KeyPress);
            this.txtWholeSale.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberOnly_KeyPress);

        }
        private void NumberOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar == 8 || e.KeyChar == 46 || e.KeyChar == 13 || (e.KeyChar >= 48 && e.KeyChar <= 57)))
                e.Handled = true;
        }
        private void frmItemMaster_Load(object sender, EventArgs e)
        {
            GridShow();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                lblID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtItemCode.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtItem.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                
                
                txtRetailRate.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtWholeSale.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtPurchaseRate.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
               
                txtStock.Text = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
                txtStock.Enabled = false;
            }
        }
        private void GridShow()
        {
            try
            {
                string query = "select * from tblItem where Item_Name like '" + txtSearch.Text.Trim() + "%'  order by Item_Name";
                dataGridView1.DataSource = Connections.Instance.ShowDataInGridView(query);
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].Visible = false;
                //dataGridView1.Columns[5].Width = 100;
                dataGridView1.Columns[3].Visible = false;
                dataGridView1.Columns[4].Visible = false;
                dataGridView1.Columns[6].Visible = false;
                dataGridView1.Columns[7].Visible = false;
                dataGridView1.Columns[8].Visible = false;
                dataGridView1.Columns[9].Visible = false;
                dataGridView1.Columns[10].Visible = false;
                dataGridView1.Columns[11].Visible = false;
                dataGridView1.Columns[12].Visible = false;
            }
            catch { }
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            txtStock.Enabled = true;
            txtItem.Text = "";
            //txtMalayalam.Text = "";
            //txtMinRate.Text = "";
            //txtMRP.Text = "";
            txtPurchaseRate.Text = "";
            //txtReorderLevel.Text = "";
            txtSearch.Text = "";
            txtRetailRate.Text = "";
            txtStock.Text = "";
            txtWholeSale.Text = "";
            txtItem.Focus();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            GridShow();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (lblID.Text.Trim() == "")
            {
                //Insert
                if (txtItem.Text.Trim() == "" ||  txtRetailRate.Text == "" || txtPurchaseRate.Text == "" ||  txtStock.Text == "" || txtWholeSale.Text == "")
                    MessageBox.Show("Please enter the data");
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Do you want to save?", "Item Master", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        string query = "insert into tblItem values('" + txtItemCode.Text.Trim() + "','" + txtItem.Text.Trim() + "','','0','" + Convert.ToDouble(txtRetailRate.Text.Trim()) + "','" + Convert.ToDouble(txtWholeSale.Text.Trim()) + "','" + Convert.ToDouble(txtPurchaseRate.Text) + "','0','0','" + Convert.ToDouble(txtStock.Text) + "','" + Convert.ToDouble(txtStock.Text) + "','false')";
                        Connections.Instance.ExecuteQueries(query);
                        GridShow();
                        btnClear_Click(null, null);
                    }
                }

            }
            else
            {
                //Update
                if (txtItem.Text.Trim() == "" ||  txtRetailRate.Text == "" || txtPurchaseRate.Text == "" ||  txtStock.Text == "" || txtWholeSale.Text == "")
                    MessageBox.Show("Please enter the data");
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Do you want to save?", "Customer Master", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        string query = "update tblItem set Item_Name='" + txtItem.Text.Trim() + "',Rate='" + Convert.ToDouble(txtRetailRate.Text.Trim()) + "',WRate='" + Convert.ToDouble(txtWholeSale.Text.Trim()) + "',PRate='" + Convert.ToDouble(txtPurchaseRate.Text) + "' where itemId='" + lblID.Text.Trim() + "'";
                        Connections.Instance.ExecuteQueries(query);
                        GridShow();
                        btnClear_Click(null, null);
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lblID.Text.Trim() == "")
                MessageBox.Show("No item selected to delete");
            else
            {
                DialogResult dialogResult = MessageBox.Show("All data under this item would be deleted. Do you want to delete the Item", "Item Master", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string query = "Delete from tblItem where custId='" + lblID.Text.Trim() + "'";
                    Connections.Instance.ExecuteQueries(query);
                    GridShow();
                    btnClear_Click(null, null);
                }
            }

        }

        private void txtItem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txtRetailRate.Focus();
            }

        }
        
        private void txtMRP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txtRetailRate.Focus();
            }

        }
        private void txtRetailRate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txtPurchaseRate.Focus();
            }

        }
        private void txtItemCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txtItem.Focus();
            }
        }
        private void txtWholeSale_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txtStock.Focus();
            }
        }
        private void txtPurchaseRate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txtWholeSale.Focus();
            }
        }
        
        private void txtReorderLevel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txtStock.Focus();
            }
        }
        private void txtStock_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btnSave_Click(null, null);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
