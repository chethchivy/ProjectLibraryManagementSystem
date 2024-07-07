using ProjectLibraryManagementSystem.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Timer = System.Windows.Forms.Timer;

namespace ProjectLibraryManagementSystem
{
    public partial class FormSupplier : Form
    {
        private bool selectionHandlerSubscribed = false;
        private Timer loginTimer = null!;
        public FormSupplier()
        {
            InitializeComponent();
            DataGridView.CheckForIllegalCrossThreadCalls = false;
            ConfigView();
        }
        private void ConfigView()
        {
            dgvSupDisplay.Columns.Clear();
            dgvSupDisplay.Columns.Add("ColSupID", "SupplierID");
            dgvSupDisplay.Columns.Add("ColSupName", "Supplier Name");
            dgvSupDisplay.Columns.Add("ColSupAddr", "Supplier Address");
            dgvSupDisplay.Columns.Add("ColPhone1", "Phone Number1");
            dgvSupDisplay.Columns.Add("ColPhone2", "Phone Number2");
        }
        public bool TryParseSupplierInputs(out Supplier sup)
        {
            sup = new Supplier();
            bool isValid = true;
            sup.supplierName = txtSupName.Text;
            sup.supplierAddr = txtSupAddr.Text;
            sup.supPhone1 = txtPhone1.Text;
            sup.supPhone2 = txtPhone2.Text;

            return isValid;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (Helper.ValidateTextBoxes(txtSupName, txtSupAddr, txtPhone1, txtPhone2))
            {
                if (TryParseSupplierInputs(out Supplier newSupplier))
                {
                    bool isSuccess = Supplier.InsertSupplier(newSupplier);
                    if (isSuccess)
                    {
                        MessageBox.Show("Supplier inserted successfully...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadSupplierDataGrid();
                        Helper.ClearControls(this);
                    }
                    else
                    {
                        MessageBox.Show("Supplier was not inserted...", "Error Insert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            {
                if (TryParseSupplierInputs(out Supplier newSupplier))
                {
                    if (byte.TryParse(txtSupID.Text, out byte supID))
                    {
                        newSupplier.supplierID = supID;
                        bool isSuccess = Supplier.UpdateSupplierByID(newSupplier);
                        if (isSuccess)
                        {
                            MessageBox.Show("Supplier Update successfully...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadSupplierDataGrid();
                            Helper.ClearControls(this);
                        }
                        else
                        {
                            MessageBox.Show("Supplier was not Updated.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Supplier ID. Please enter a valid number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            dgvSupDisplay.ClearSelection();
            Helper.ClearControls(this);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void RetrieveSupplierDetails(byte supID)
        {
            Supplier sup = new Supplier();
            Supplier.RetrieveSupplierDetails(supID, sup);

            txtSupID.Text = sup.supplierID.ToString();
            txtSupName.Text = sup.supplierName;
            txtSupAddr.Text = sup.supplierAddr;
            txtPhone1.Text = sup.supPhone1;
            txtPhone2.Text = sup.supPhone2;
        }


        private void FormSupplier_Load(object sender, EventArgs e)
        {
            Helper.AttachNavigationEvents(this);
            LoadSupplierDataGrid();
            dgvSupDisplay.ClearSelection();
        }
        private void LoadSupplierDataGrid()
        {
            dgvSupDisplay.Rows.Clear();
            string query = "SELECT * FROM vGetAllSuppliers";
            Supplier newSupplier = new Supplier();
            List<Supplier> suppliers = new List<Supplier>();
            suppliers = Supplier.GetAllSuppler(query);
            foreach (Supplier supplier in suppliers)
            {
                newSupplier.supplierID = supplier.supplierID;
                newSupplier.supplierName = supplier.supplierName;
                newSupplier.supplierAddr = supplier.supplierAddr;
                newSupplier.supPhone1 = supplier.supPhone1;
                newSupplier.supPhone2 = supplier.supPhone2;
                dgvSupDisplay.Rows.Add(newSupplier.supplierID, newSupplier.supplierName, newSupplier.supplierAddr, newSupplier.supPhone1, newSupplier.supPhone2);
            }
            dgvSupDisplay.ClearSelection();
        }

        private void dgvSupDisplay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Helper.AttachNavigationEvents(dgvSupDisplay);
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dgvSupDisplay.SelectionChanged += dgvSupDisplay_SelectionChanged;
                dgvSupDisplay_SelectionChanged(sender, e);
            }
        }

        private void dgvSupDisplay_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvSupDisplay.CurrentRow != null)
            {
                DataGridViewRow selectedRow = dgvSupDisplay.CurrentRow;

                byte supID = (byte)selectedRow.Cells["ColSupID"].Value;
                RetrieveSupplierDetails(supID);

                if (!selectionHandlerSubscribed)
                {
                    selectionHandlerSubscribed = true;
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.Trim();
            Supplier.SearchSupplier(searchTerm, dgvSupDisplay);
            dgvSupDisplay.ClearSelection();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string searchTerm = txtSearch.Text.Trim();
                bool result = Supplier.SearchSupplier(searchTerm, dgvSupDisplay);
                if (!result)
                {
                    MessageBox.Show($"No Supplier found for the given search {searchTerm}.", "Search Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSearch.Clear();
                }
                e.SuppressKeyPress = true;
            }
        }

        private void LoginTimer_Tick(object sender, EventArgs e)
        {
            loginTimer.Stop();
            Helper.PerformLogin();
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do You Want to Logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Close();
                loginTimer = new Timer();
                loginTimer.Interval = 200;
                loginTimer.Start();
                loginTimer.Tick += LoginTimer_Tick!;
            }
            else
            {
                return;
            }
        }
    }
}
