using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
|====================================================================================================|
|    Manage Sports and Recreation facilities information for each of the participated University     |
|                          (add, edit, delete – facility type, rate, etc).                           |
|====================================================================================================|
*/

namespace Inter_University_Recreation_Facilities_Management_System
{
    public partial class manager_ManageFacility : UserControl
    {
        private void Aligned()
        {
            lbl_ManageFacility.Left = (this.ClientSize.Width - lbl_ManageFacility.Width) / 2;
            int dgv_ManageFacility = (this.ClientSize.Width - dgv_Facility.Width) / 2;

            dgv_Facility.    Left = dgv_ManageFacility;
            lbl_FacilityID.  Left = dgv_ManageFacility;
            lbl_FacilityName.Left = dgv_ManageFacility;
            lbl_FacilityType.Left = dgv_ManageFacility;
            lbl_Status.      Left = dgv_ManageFacility;
            lbl_Rate.        Left = dgv_ManageFacility;

            lbl_SelectedFacilityID.Left = lbl_FacilityID.Left + 110;
            lbl_SelectedFacilityID.Top = lbl_FacilityID.Top - (lbl_SelectedFacilityID.Height - lbl_FacilityID.Height) / 2;

            txtBox_FacilityName.Left = lbl_FacilityName.Left + 140;
            txtBox_FacilityName. Top = lbl_FacilityName.Top - (txtBox_FacilityName.Height - lbl_FacilityName.Height) / 2;

            rb_Indoor.Left = lbl_FacilityType.Left + 120;
            rb_Indoor. Top = lbl_FacilityType.Top - (rb_Indoor.Height - lbl_FacilityType.Height) / 2;

            rb_Outdoor.Left = rb_Indoor.Right + 10;
            rb_Outdoor. Top = rb_Outdoor.Top - (rb_Outdoor.Height - rb_Indoor.Height) / 2;

            cBox_Status.Left = lbl_Status.Left + 140;
            cBox_Status. Top = lbl_Status.Top - (cBox_Status.Height - lbl_Status.Height) / 2;

            txtBox_Rate.Left = lbl_Rate.Left + 90;
            txtBox_Rate. Top = lbl_Rate.Top - (txtBox_Rate.Height - lbl_Rate.Height) / 2;

            btn_Update.Left = dgv_Facility.Right - btn_Update.Width;
            btn_Delete.Left = btn_Update.Left  - btn_Delete.Width - 10;
            btn_Add.   Left = btn_Delete.Left  - btn_Add.Width - 10;
            btn_Clear. Left = btn_Add.Left  - btn_Clear.Width - 10;
            btn_Search.Left = btn_Clear.Left - btn_Search.Width - 10;
        }


        private void LoadFacility() 
        {
            DataTable dataTable = Methods.LoadFacility();

            dgv_Facility.AutoGenerateColumns = false;
            dgv_Facility.DataSource = dataTable;
        }


        public manager_ManageFacility(User user)
        {
            InitializeComponent();
            this.Resize += (s,e) => Aligned();
            LoadFacility();
        }

        
        public event EventHandler To_Dashboard;
        private void btn_Logout_Click(object sender, EventArgs e)
        {
            To_Dashboard?.Invoke(this, EventArgs.Empty);
        }


        private void dgv_Facility_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow selectedRow = dgv_Facility.Rows[e.RowIndex];

            lbl_SelectedFacilityID.Text = selectedRow.Cells["FacilityID"  ].Value.ToString();
            txtBox_FacilityName   .Text = selectedRow.Cells["FacilityName"].Value.ToString();

            string type = selectedRow.Cells["FacilityType"].Value.ToString();
            rb_Indoor. Checked = (type == "Indoor" );
            rb_Outdoor.Checked = (type == "Outdoor");

            txtBox_Rate.Text = selectedRow.Cells["Rate"].Value.ToString();

            string status = selectedRow.Cells["FacilityStatus"].Value.ToString();
            cBox_Status.Text = status;
        }


        private void btn_Search_Click(object sender, EventArgs e)
        {
            string facilityName = txtBox_FacilityName.Text;
            
            string facilityType = null;
            if      (rb_Indoor.Checked ) facilityType = "Indoor";
            else if (rb_Outdoor.Checked) facilityType = "Outdoor";

            string facilityStatus = cBox_Status.Text;
            
            double? rate = null;
            if (!string.IsNullOrWhiteSpace(txtBox_Rate.Text))
            {
                if (!double.TryParse(txtBox_Rate.Text, out double parsedRate))
                {
                    MessageBox.Show("Please enter a valid rate.");
                    return;
                }
                rate = parsedRate;
            }

            if (facilityName == "" && facilityType == null && facilityStatus == "" && rate < 0)
            {
                MessageBox.Show("Please fill in at least one search criteria."); 
                return;
            }

            DataTable searchResults = Methods.SearchFacility(facilityName, facilityType, facilityStatus, rate);
            dgv_Facility.DataSource = searchResults;
        }


        private void btn_Clear_Click(object sender, EventArgs e)
        {
            lbl_SelectedFacilityID.Text = string.Empty;
            txtBox_FacilityName.   Text = string.Empty;

            if (rb_Indoor.Checked || rb_Outdoor.Checked) 
            {
                rb_Indoor. Checked = false;
                rb_Outdoor.Checked = false;
            }

            cBox_Status.SelectedIndex = 0;
            txtBox_Rate.Text= string.Empty;

            LoadFacility();
        }


        private void btn_Add_Click(object sender, EventArgs e)
        {
            string facility_name = txtBox_FacilityName.Text;
            string facility_type = null;

            if      (rb_Indoor. Checked) facility_type = "Indoor";
            else if (rb_Outdoor.Checked) facility_type = "Outdoor";

            string facility_status = cBox_Status.Text;
            double facility_rate = double.Parse(txtBox_Rate.Text);

            if (facility_name == "" || facility_type == null || 
                facility_status == "" || facility_rate < 0) 
            {
                MessageBox.Show("Please fill in all fields");
                return;
            }

            DataTable updatedFacilities = Methods.AddFacility(
                facility_name, facility_type, facility_status, facility_rate
                );
            dgv_Facility.DataSource = updatedFacilities;

            MessageBox.Show("Facility added successfully.");
            btn_Clear_Click(sender, e);
        }


        private void btn_Delete_Click(object sender, EventArgs e)
        {
            string facilityID = lbl_SelectedFacilityID.Text;

            if (string.IsNullOrEmpty(facilityID)) 
            {
                MessageBox.Show("Please select a faciluty form the list first.");
                return;
            }

            DialogResult confirm = MessageBox.Show(
                    "Are you sure want to delete facility " + facilityID,
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                    );

            if (confirm != DialogResult.Yes) return;

            try
            {
                DataTable updatedFacilities = Methods.DeleteFacility(facilityID);
                dgv_Facility.DataSource = updatedFacilities;

                MessageBox.Show("Facility deleted successfully");
                btn_Clear_Click(sender, e);
            }
            catch (Exception ex) 
            { MessageBox.Show("Could not delete this facility " + ex.Message); }
        }


        private void btn_Update_Click(object sender, EventArgs e)
        {
            string facility_id   = lbl_SelectedFacilityID.Text;
            string facility_name = txtBox_FacilityName.Text;

            string facility_type = null;
            if      (rb_Indoor. Checked) facility_type = "Indoor";
            else if (rb_Outdoor.Checked) facility_type = "Outdoor";

            string facility_status = cBox_Status.Text;
            

            if (facility_id == "" || facility_name == "" || facility_type == null ||
                facility_status == "" || 
                !double.TryParse(txtBox_Rate.Text, out double facility_rate) || facility_rate < 0)
            {
                MessageBox.Show("Please fill in all fields");
                return;
            }

            try
            {
                DataTable updatedFacilities = Methods.UpdateFacility(
                    facility_id, facility_name, facility_type, facility_status, facility_rate
                    );
                dgv_Facility.DataSource = updatedFacilities;

                MessageBox.Show("Facility updated successfully.");
                btn_Clear_Click(sender, e);
            }
            catch (Exception ex) 
            { MessageBox.Show("Could not updated this facility. " + ex.Message); }
        }
    }
}