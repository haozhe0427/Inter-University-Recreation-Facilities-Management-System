using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inter_University_Recreation_Facilities_Management_System
{
    public partial class Form_Shell : Form
    {
        public Form_Shell()
        {
            InitializeComponent();
            ShowLogin();
        }

        private void ShowLogin() 
        {
            pnl_Container.Controls.Clear();

            Login Login = new Login();
            forgotPassword forgotPassword = new forgotPassword();

            Login.Dock  = DockStyle.Fill;
            // User & Password validation -> Role Validation
            Login.          CredentialsValid   += (s, user) => role_Validation(user);

            // Login <-> Forgot Password
            Login.          To_ResetPassword   += (s, e)    => LoadScreen(forgotPassword);
            forgotPassword. To_Login           += (s, e)    => ShowLogin();

            pnl_Container.Controls.Add(Login);
        }

        private void role_Validation(User user)
        {
            switch (user.AccountRole) 
            {
                case "Manager":
                    manager_Dashboard        manager_Dashboard = new manager_Dashboard       (user);
                    manager_ManageAccount    manageAccount     = new manager_ManageAccount   (user);
                    manager_ManageFacility   manageFacility    = new manager_ManageFacility  (user);
                    manager_AssignSchedule   assignSchedule    = new manager_AssignSchedule  (user);
                    manager_EquipmentRequest equipmentRequest  = new manager_EquipmentRequest(user);

                    // Login (successful) <-> Manager Dashboard
                    LoadScreen(manager_Dashboard);
                    manager_Dashboard.To_Login            += (s, e) => ShowLogin ();

                    // Manager Dashboard  <-> Manage Account
                    manager_Dashboard.To_ManageAccount    += (s, e) => LoadScreen(manageAccount);
                    manageAccount.    To_Dashboard        += (s, e) => LoadScreen(manager_Dashboard);

                    // Manager Dashboard  <-> Manage Facility
                    manager_Dashboard.To_ManageFacility   += (s, e) => LoadScreen(manageFacility);
                    manageFacility.   To_Dashboard        += (s, e) => LoadScreen(manager_Dashboard);

                    // Manager Dashboard  <-> Assign Schedule
                    manager_Dashboard.To_AssignSchedule   += (s, e) => LoadScreen(assignSchedule);
                    assignSchedule.   To_Dashboard        += (s, e) => LoadScreen(manager_Dashboard);

                    // Manager Dashboard  <-> Equipment Request
                    manager_Dashboard.To_EquipmentRequest += (s, e) => LoadScreen(equipmentRequest);
                    equipmentRequest. To_Dashboard        += (s, e) => LoadScreen(manager_Dashboard);

                    break;


                case "Receptionist":
                    receptionist_Dashboard     receptionistDashboard = new receptionist_Dashboard    (user);
                    receptionist_ManageAccount manageAccount_Student = new receptionist_ManageAccount(user);
                    receptionist_ManageBooking manageBooking         = new receptionist_ManageBooking(user);
                    receptionist_ManagePayment managePayment         = new receptionist_ManagePayment(user);
                    receptionist_ViewRating    viewRating            = new receptionist_ViewRating   (user);

                    // Login (successful)     <-> Receptionist Dashboard
                    LoadScreen(receptionistDashboard);
                    receptionistDashboard.To_Login         += (s, e) => ShowLogin();

                    // Receptionist Dashboard <-> Manage Account
                    receptionistDashboard.To_ManageAccount += (s, e) => LoadScreen(manageAccount_Student);
                    manageAccount_Student.To_Dashboard     += (s, e) => LoadScreen(receptionistDashboard);

                    // Receptionist Dashboard <-> Manage Booking
                    receptionistDashboard.To_ManageBooking += (s, e) => LoadScreen(manageBooking);
                    manageBooking.        To_Dashboard     += (s, e) => LoadScreen(receptionistDashboard);

                    // Receptionist Dashboard <-> Manage Payment
                    receptionistDashboard.To_ManagePayment += (s, e) => LoadScreen(managePayment);
                    managePayment.        To_Dashboard     += (s, e) => LoadScreen(receptionistDashboard);

                    // Receptionist Dashboard <-> View Rating
                    receptionistDashboard.To_ViewRating    += (s, e) => LoadScreen(viewRating);
                    viewRating.           To_Dashboard     += (s, e) => LoadScreen(receptionistDashboard);

                    break;


                case "Student":
                    student_Dashboard      studentDashboard = new student_Dashboard     (user);
                    student_SearchFacility searchFacility   = new student_SearchFacility(user);
                    student_Payment        payment          = new student_Payment       (user);
                    student_SendReview     sendReview       = new student_SendReview    (user);
                    student_ManageProfile  manageProfile_s  = new student_ManageProfile (user);

                    // Login (successful) <-> Student Dashboard
                    LoadScreen(studentDashboard);
                    studentDashboard.To_Login          += (s, e) => ShowLogin();

                    // Student Dashboard  <-> Search Facility
                    studentDashboard.To_SearchFacility += (s, e) => LoadScreen(searchFacility);
                    searchFacility.  To_Dashboard      += (s, e) => LoadScreen(studentDashboard);

                    // Student Dashboard  <-> Payment
                    studentDashboard.To_Payment        += (s, e) => LoadScreen(payment);
                    payment.         To_Dashboard      += (s, e) => LoadScreen(studentDashboard);

                    // Student Dashboard  <-> Send Review
                    studentDashboard.To_SendReview     += (s, e) => LoadScreen(sendReview);
                    sendReview.      To_Dashboard      += (s, e) => LoadScreen(studentDashboard);

                    // Student Dashboard  <-> Manage Profile
                    studentDashboard.To_ManageProfile  += (s, e) => LoadScreen(manageProfile_s);
                    manageProfile_s. To_Dashboard      += (s, e) => LoadScreen(studentDashboard);

                    break;


                case "Maintenance Staff":
                    maintenanceStaff_Dashboard     maintainanceDashboard = new maintenanceStaff_Dashboard    (user);
                    maintenanceStaff_ViewSchedule  viewSchedule          = new maintenanceStaff_ViewSchedule (user);
                    maintenanceStaff_UpdateStatus  updateStatus          = new maintenanceStaff_UpdateStatus (user);
                    maintenanceStaff_ManageRequest manageRequest         = new maintenanceStaff_ManageRequest(user);
                    maintenanceStaff_ManageProfile manageProfile_m       = new maintenanceStaff_ManageProfile(user);

                    // Login (successful)          <-> Maintenance Staff Dashboard
                    LoadScreen(maintainanceDashboard);
                    maintainanceDashboard.To_Login         += (s, e) => ShowLogin();

                    // Maintenance Staff Dashboard <-> View Schedule
                    maintainanceDashboard.To_ViewSchedule  += (s, e) => LoadScreen(viewSchedule);
                    viewSchedule.         To_Dashboard     += (s, e) => LoadScreen(maintainanceDashboard);

                    // Maintenance Staff Dashboard <-> Update Status
                    maintainanceDashboard.To_UpdateStatus  += (s, e) => LoadScreen(updateStatus);
                    updateStatus.         To_Dashboard     += (s, e) => LoadScreen(maintainanceDashboard);

                    // Maintenance Staff Dashboard <-> Manage Request
                    maintainanceDashboard.To_ManageRequest += (s, e) => LoadScreen(manageRequest);
                    manageRequest.        To_Dashboard     += (s, e) => LoadScreen(maintainanceDashboard);

                    // Maintenance Staff Dashboard <-> Manage Profile
                    maintainanceDashboard.To_ManageProfile += (s, e) => LoadScreen(manageProfile_m);
                    manageProfile_m.      To_Dashboard     += (s, e) => LoadScreen(maintainanceDashboard);

                    break;


                default:
                    MessageBox.Show("Unknown role: " + user.AccountRole);
                    break;
            }
        }

        private void LoadScreen(UserControl screen)
        {
            pnl_Container.Controls.Clear();
            screen.Dock = DockStyle.Fill;
            pnl_Container.Controls.Add(screen);
        }
    }
}