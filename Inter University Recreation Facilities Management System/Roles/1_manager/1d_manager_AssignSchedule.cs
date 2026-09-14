using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Inter_University_Recreation_Facilities_Management_System
{
    public partial class manager_AssignSchedule : UserControl
    {
        private void Aligned()
        {
            lbl_AssignSchedule.Left = (this.ClientSize.Width - lbl_AssignSchedule.Width) / 2;
            int dgv_Maintenance = (this.ClientSize.Width - dgv_MaintenanceSchedule.Width) / 2;

            dgv_MaintenanceSchedule.Left = dgv_Maintenance;
            lbl_MaintenanceID.Left = dgv_Maintenance;
            lbl_FacilityID.Left = dgv_Maintenance;
            lbl_AccountID.Left = dgv_Maintenance;
            lbl_MaintenanceType.Left = dgv_Maintenance;
            lbl_Status.Left = dgv_Maintenance;

            lbl_SelectedMaintenanceID.Left = lbl_MaintenanceID.Left + 110;
            lbl_SelectedMaintenanceID.Top = lbl_MaintenanceID.Top - (lbl_SelectedMaintenanceID.Height - lbl_MaintenanceID.Height) / 2;

            lbl_SelectedFacilityID.Left = lbl_FacilityID.Left + 110;
            lbl_SelectedFacilityID.Top = lbl_FacilityID.Top - (lbl_SelectedFacilityID.Height - lbl_FacilityID.Height) / 2;

            txtBox_AccountID.Left = lbl_AccountID.Left + 110;
            txtBox_AccountID.Top = lbl_AccountID.Top - (txtBox_AccountID.Height - lbl_AccountID.Height) / 2;

            rb_Installation.Left = lbl_MaintenanceType.Right + 10;
            rb_Installation.Top = lbl_MaintenanceType.Top - (rb_Installation.Height - lbl_MaintenanceType.Height) / 2;

            rb_Fixing.Left = rb_Installation.Right + 10;
            rb_Fixing.Top = rb_Fixing.Top - (rb_Fixing.Height - rb_Installation.Height) / 2;

            rb_Dismantlement.Left = rb_Dismantlement.Left + 160;
            rb_Dismantlement.Top = rb_Dismantlement.Top - (rb_Dismantlement.Height - rb_Fixing.Height) / 2;

            cBox_Status.Left = lbl_Status.Left + 90;
            cBox_Status.Top = lbl_Status.Top - (cBox_Status.Height - lbl_Status.Height) / 2;

            btn_Update.Left = dgv_MaintenanceSchedule.Right - btn_Update.Width;
            btn_Add.Left = btn_Update.Left - btn_Add.Width - 10;
            btn_Clear.Left = btn_Add.Left - btn_Clear.Width - 10;
        }


        private void LoadSchedule()
        {
            DataTable dataTable = Methods.LoadSchedules();

            dgv_MaintenanceSchedule.AutoGenerateColumns = false;
            dgv_MaintenanceSchedule.DataSource = dataTable;
        }


        public manager_AssignSchedule(User user)
        {
            InitializeComponent();
            this.Resize += (s, e) => Aligned();
            LoadSchedule();
        }


        public event EventHandler To_Dashboard;
        private void btn_Back_Click(object sender, EventArgs e)
        {
            To_Dashboard?.Invoke(this, EventArgs.Empty);
        }
    }
}
