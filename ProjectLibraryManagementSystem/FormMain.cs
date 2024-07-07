using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace ProjectLibraryManagementSystem
{
    public partial class FormMain : Form
    {
        private Dictionary<Label, PictureBox> labelToPictureBoxMapping;
        private Dictionary<PictureBox, Label> pictureBoxToLabelMapping;
        private Color originalLabelBackColor;
        private Color originalPictureBoxBackColor;
        private Color originalBackColor;
        private Color clickColor = Color.FromArgb(237, 234, 205);
        private bool currentlySelectedControl = false;
        private Timer loginTimer = null!;
        private static Dictionary<Control, Type>? formMapping;
        public FormMain()
        {
            InitializeComponent();
            loginTimer = new Timer();
            loginTimer.Interval = 500;
            //oginTimer.Tick += LoginTimer_Tick!;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            StartPosition = FormStartPosition.CenterScreen;
            Rectangle screenSize = Screen.PrimaryScreen.WorkingArea;
            Size = new Size(screenSize.Width, screenSize.Height);
            Location = new Point((screenSize.Width - Width) / 2, (screenSize.Height - Height) / 2);
            loginTimer.Start();

            formMapping = new Dictionary<Control, Type>
            {
                { ptbBook, typeof(FormBook) },
                { ptbStaff, typeof(FormStaff) },
                { ptbSupplier, typeof(FormSupplier) },
                { ptbMember, typeof(FormMember) },
                { ptbUser, typeof(FormUser) },
                { ptbCard, typeof(FormCard) },
                { ptbImport, typeof(FormImport) },
                { ptbBorrow, typeof(FormBorrow) },
                { ptbReturn, typeof(FormReturn) },
                { ptbRenew, typeof(FormRenew) },
                { ptbInvoice, typeof(FormInvoice) },
                { ptbPay, typeof(FormPayment) },
                { ptbExpire, typeof(FormBorrowExpire)},
                {ptbAddress, typeof(FormAddress) },

                { lblBook, typeof(FormBook) },
                { lblStaff, typeof(FormStaff) },
                { lblSupplier, typeof(FormSupplier) },
                { lblMember, typeof(FormMember) },
                { lblUser, typeof(FormUser) },
                { lblCard, typeof(FormCard) },
                { lblImport, typeof(FormImport) },
                { lblBorrow, typeof(FormBorrow) },
                { lblReturn, typeof(FormReturn) },
                { lblRenew, typeof(FormRenew) },
                { lblInvoice, typeof(FormInvoice) },
                { lblPayment, typeof(FormPayment) },
                { lblExpire, typeof(FormBorrowExpire)},
                { lblAddress, typeof(FormAddress) }
            };
            if (formMapping != null)
            {
                Helper.AttachClickEvents(formMapping);
                // Initialize label to pictureBox mapping
                labelToPictureBoxMapping = new Dictionary<Label, PictureBox>
                {
                    { lblBook, ptbBook },
                    { lblStaff, ptbStaff },
                    { lblSupplier, ptbSupplier },
                    { lblMember, ptbMember },
                    { lblUser, ptbUser },
                    { lblCard, ptbCard },
                    { lblImport, ptbImport },
                    { lblBorrow, ptbBorrow },
                    { lblReturn, ptbReturn },
                    { lblRenew, ptbRenew },
                    { lblInvoice, ptbInvoice },
                    { lblPayment, ptbPay },
                    { lblExpire, ptbExpire },
                    { lblAddress, ptbAddress },
                    //{lblReport, ptbReport },
                    { lblLogout, ptbLogout }
                };

                pictureBoxToLabelMapping = new Dictionary<PictureBox, Label>();
                foreach (var pair in labelToPictureBoxMapping)
                {
                    pictureBoxToLabelMapping[pair.Value] = pair.Key;
                }

                // Attach mouse events to both labels and pictureBoxes
                foreach (var label in labelToPictureBoxMapping.Keys)
                {
                    label.MouseEnter += (s, ev) => ChangeBackgroundColor(label);
                    label.MouseLeave += (s, ev) => ResetBackgroundColor(label);
                }

                foreach (var pictureBox in pictureBoxToLabelMapping.Keys)
                {
                    pictureBox.MouseEnter += (s, ev) => ChangeBackgroundColor(pictureBox);
                    pictureBox.MouseLeave += (s, ev) => ResetBackgroundColor(pictureBox);
                }
                //foreach (var entry in formMapping)
                //{
                //    entry.Key.MouseEnter += (s, ev) => ChangeBackgroundColor(entry.Key);
                //    entry.Key.MouseLeave += (s, ev) => ResetBackgroundColor(entry.Key);
                //}
            }
        }
        private void ChangeBackgroundColor(Control control)
        {
            if (control is Label label && labelToPictureBoxMapping.TryGetValue(label, out var pictureBox))
            {
                // Store original background colors
                originalLabelBackColor = label.BackColor;
                originalPictureBoxBackColor = pictureBox.BackColor;

                // Change to desired hover color
                label.BackColor = Color.LightGray;
                pictureBox.BackColor = Color.LightGray;
            }
            else if (control is PictureBox pb && pictureBoxToLabelMapping.TryGetValue(pb, out var correspondingLabel))
            {
                // Store original background colors
                originalPictureBoxBackColor = pb.BackColor;
                originalLabelBackColor = correspondingLabel.BackColor;

                // Change to desired hover color
                pb.BackColor = Color.LightGray;
                correspondingLabel.BackColor = Color.LightGray;
            }
        }

        private void ResetBackgroundColor(Control control)
        {
            if (control is Label label && labelToPictureBoxMapping.TryGetValue(label, out var pictureBox))
            {
                // Reset to original background colors
                label.BackColor = originalLabelBackColor;
                pictureBox.BackColor = originalPictureBoxBackColor;
            }
            else if (control is PictureBox pb && pictureBoxToLabelMapping.TryGetValue(pb, out var correspondingLabel))
            {
                // Reset to original background colors
                pb.BackColor = originalPictureBoxBackColor;
                correspondingLabel.BackColor = originalLabelBackColor;
            }
        }
        private void LoginTimer_Tick(object sender, EventArgs e)
        {
            loginTimer.Stop();
            Helper.PerformLogin();
        }
        private void ptbLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do You Want to Logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                loginTimer.Stop();
                Helper.PerformLogin();
                loginTimer.Tick += LoginTimer_Tick!;
            }
            else
            {
                return;
            }
        }
        private void lblSalaryRp_MouseEnter(object sender, EventArgs e)
        {
            lblSalaryRp.BackColor = Color.FromArgb(237, 234, 205);
        }

        private void lblSalaryRp_MouseLeave(object sender, EventArgs e)
        {
            lblSalaryRp.BackColor = Color.Transparent;
        }

        private void lblCirRp_MouseEnter(object sender, EventArgs e)
        {
            lblCirRp.BackColor = Color.FromArgb(237, 234, 205);
        }

        private void lblCirRp_MouseLeave(object sender, EventArgs e)
        {
            lblCirRp.BackColor = Color.Transparent;
        }

        private void lblMemRp_MouseEnter(object sender, EventArgs e)
        {
            lblMemRp.BackColor = Color.FromArgb(237, 234, 205);
        }

        private void lblMemRp_MouseLeave(object sender, EventArgs e)
        {
            lblMemRp.BackColor = Color.Transparent;
        }
        private void lblReport_MouseEnter(object sender, EventArgs e)
        {
            lblReport.BackColor = Color.LightGray;
            ptbReport.BackColor = Color.LightGray;
        }

        private void lblReport_MouseLeave(object sender, EventArgs e)
        {
            lblReport.BackColor = Color.Transparent;
            ptbReport.BackColor = Color.Transparent;
        }

        private void ptbReport_Click(object sender, EventArgs e)
        {
            currentlySelectedControl = true;
            if (currentlySelectedControl == false)
            {
                ResetBackgroundColor(lblReport);
            }
            panelReport.Visible = true;
            lblReport.BackColor = Color.LightGray;
            ptbReport.BackColor = Color.LightGray;
            currentlySelectedControl = true;
        }

        private void lblSalaryRp_Click(object sender, EventArgs e)
        {
            lblSalaryRp_BackColorChanged(sender, e);
            panelHeader.Visible = true;
            panelDgv.Visible = true;
            lblReportTitle.Text = lblSalaryRp.Text;
            string query = "SELECT * FROM vGetSalaryReport";
            DataTable dataTable = Helper.ReadData(query);
            dgvReport.DataSource = dataTable;
        }

        private void ptbClose_Click(object sender, EventArgs e)
        {
            panelReport.Visible = false;
            panelHeader.Visible = false;
            panelDgv.Visible = false;
        }

        private void lblCirRp_Click(object sender, EventArgs e)
        {
            lblCirRp_BackColorChanged(sender, e);
            panelHeader.Visible = true;
            panelDgv.Visible = true;
            panelBdEd.Visible = true;
            panelReportType.Visible = true;
            lblReportTitle.Text = lblCirRp.Text;
            DateTime bd = dtpbd.Value;
            DateTime ed = dtped.Value;
            cmbReportType.SelectedIndexChanged += cmbReportType_SelectedIndexChanged;

        }

        private void lblCirRp_BackColorChanged(object sender, EventArgs e)
        {
            lblCirRp.BackColor = Color.FromArgb(237, 234, 205);
        }

        private void cmbReportType_SelectedIndexChanged(object? sender, EventArgs e)
        {
            DateTime bd = dtpbd.Value;
            DateTime ed = dtped.Value;
            if (cmbReportType.SelectedIndex == 0)
            {
                try
                {
                    using (SqlConnection connection = Helper.OpenConnection())
                    using (SqlCommand command = new SqlCommand("spImportReport", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Add parameters
                        command.Parameters.Add(new SqlParameter("@bd", SqlDbType.DateTime)).Value = bd;
                        command.Parameters.Add(new SqlParameter("@ed", SqlDbType.DateTime)).Value = ed;

                        command.ExecuteNonQuery();

                        lblReportTitle.Text = cmbReportType.Text;
                        string query = "SELECT * FROM tbImportReport";
                        DataTable dataTable = Helper.ReadData(query);
                        dgvReport.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Showing Import Report: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (cmbReportType.SelectedIndex == 1)
            {
                try
                {
                    using (SqlConnection connection = Helper.OpenConnection())
                    using (SqlCommand command = new SqlCommand("spBorrowReport", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Add parameters
                        command.Parameters.Add(new SqlParameter("@bd", SqlDbType.DateTime)).Value = bd;
                        command.Parameters.Add(new SqlParameter("@ed", SqlDbType.DateTime)).Value = ed;

                        command.ExecuteNonQuery();

                        lblReportTitle.Text = cmbReportType.Text;
                        string query = "SELECT * FROM tbBorrowReport";
                        DataTable dataTable = Helper.ReadData(query);
                        dgvReport.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Showing Borrow Report: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (cmbReportType.SelectedIndex == 2)
            {
                try
                {
                    using (SqlConnection connection = Helper.OpenConnection())
                    using (SqlCommand command = new SqlCommand("spReturnReport", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Add parameters
                        command.Parameters.Add(new SqlParameter("@bd", SqlDbType.DateTime)).Value = bd;
                        command.Parameters.Add(new SqlParameter("@ed", SqlDbType.DateTime)).Value = ed;

                        command.ExecuteNonQuery();

                        lblReportTitle.Text = cmbReportType.Text;
                        string query = "SELECT * FROM tbReturnReport";
                        DataTable dataTable = Helper.ReadData(query);
                        dgvReport.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Showing Return Report: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (cmbReportType.SelectedIndex == 3)
            {
                DataTable dataTable = new DataTable();
                string query = "SELECT * FROM fnRenewReport(@bd, @ed)";
                try
                {
                    using (SqlConnection connection = Helper.OpenConnection())
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.CommandType = CommandType.Text;

                        // Add parameters
                        command.Parameters.Add(new SqlParameter("@bd", SqlDbType.DateTime)).Value = bd;
                        command.Parameters.Add(new SqlParameter("@ed", SqlDbType.DateTime)).Value = ed;
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(dataTable);

                        lblReportTitle.Text = cmbReportType.Text;
                        dgvReport.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Showing Renew Report: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                DataTable dataTable = new DataTable();
                string query = "SELECT * FROM fnBorrowExpireReport(@bd, @ed)";
                try
                {
                    using (SqlConnection connection = Helper.OpenConnection())
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.CommandType = CommandType.Text;

                        // Add parameters
                        command.Parameters.Add(new SqlParameter("@bd", SqlDbType.DateTime)).Value = bd;
                        command.Parameters.Add(new SqlParameter("@ed", SqlDbType.DateTime)).Value = ed;
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(dataTable);

                        lblReportTitle.Text = cmbReportType.Text;
                        dgvReport.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Showing BorrowExpire Report: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void lblSalaryRp_BackColorChanged(object sender, EventArgs e)
        {
            lblSalaryRp.BackColor = Color.FromArgb(237, 234, 205);
        }
    }
}
