using System;
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

            Login          login         = new Login();
            forgotPassword resetPassword = new forgotPassword();

            login.Dock = DockStyle.Fill;

            // User & Password validation -> Role Validation
            login.        CredentialsValid += (s, user) => RoleValidation(user);

            // Login <-> Forgot Password
            login.        To_ResetPassword += (s, e)    => LoadScreen(resetPassword);
            resetPassword.To_Login         += (s, e)    => ShowLogin();

            pnl_Container.Controls.Add(login);
        }

        private void RoleValidation(User user)
        {
            switch (user.AccountRole)
            {
                case "Manager":
                    {
                        manager_Dashboard        managerDashboard = new manager_Dashboard(user);
                        manager_ManageAccount    manageAccount    = new manager_ManageAccount(user);
                        manager_ManageFacility   manageFacility   = new manager_ManageFacility(user);
                        manager_AssignSchedule   assignSchedule   = new manager_AssignSchedule(user);
                        manager_EquipmentRequest equipmentRequest = new manager_EquipmentRequest(user);

                        // Login (successful) <-> Manager Dashboard
                        LoadScreen(managerDashboard);
                        managerDashboard.To_Login            += (s, e) => ShowLogin();

                        // Manager Dashboard  <-> Manage Account
                        managerDashboard.To_ManageAccount    += (s, e) => LoadScreen(manageAccount);
                        manageAccount.   To_Dashboard        += (s, e) => LoadScreen(managerDashboard);

                        // Manager Dashboard  <-> Manage Facility
                        managerDashboard.To_ManageFacility   += (s, e) => LoadScreen(manageFacility);
                        manageFacility.  To_Dashboard        += (s, e) => LoadScreen(managerDashboard);

                        // Manager Dashboard  <-> Assign Schedule
                        managerDashboard.To_AssignSchedule   += (s, e) => LoadScreen(assignSchedule);
                        assignSchedule.  To_Dashboard        += (s, e) => LoadScreen(managerDashboard);

                        // Manager Dashboard  <-> Equipment Request
                        managerDashboard.To_EquipmentRequest += (s, e) => LoadScreen(equipmentRequest);
                        equipmentRequest.To_Dashboard        += (s, e) => LoadScreen(managerDashboard);

                        break;
                    }

                case "Receptionist":
                    {
                        receptionist_Dashboard     receptionistDashboard = new receptionist_Dashboard(user);
                        receptionist_ManageAccount manageAccount         = new receptionist_ManageAccount(user);
                        receptionist_ManageBooking manageBooking         = new receptionist_ManageBooking(user);
                        receptionist_ManagePayment managePayment         = new receptionist_ManagePayment(user);
                        receptionist_ViewRating    viewRating            = new receptionist_ViewRating(user);

                        // Login (successful)     <-> Receptionist Dashboard
                        LoadScreen(receptionistDashboard);
                        receptionistDashboard.To_Login         += (s, e) => ShowLogin();

                        // Receptionist Dashboard <-> Manage Account
                        receptionistDashboard.To_ManageAccount += (s, e) => LoadScreen(manageAccount);
                        manageAccount.        To_Dashboard     += (s, e) => LoadScreen(receptionistDashboard);

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
                    }

                case "Student":
                    {
                        student_Dashboard      studentDashboard = new student_Dashboard(user);
                        student_SearchFacility searchFacility   = new student_SearchFacility(user);
                        student_Payment        payment          = new student_Payment(user);
                        student_SendReview     sendReview       = new student_SendReview(user);
                        student_ManageProfile  manageProfile    = new student_ManageProfile(user);

                        // Login (successful) <-> Student Dashboard
                        LoadScreen(studentDashboard);
                        studentDashboard.To_Login          += (s, e) => ShowLogin();

                        // Student Dashboard  <-> Search Facility
                        studentDashboard.To_SearchFacility += (s, e) => LoadScreen(searchFacility);
                        searchFacility.  To_Dashboard      += (s, e) => LoadScreen(studentDashboard);

                        // Student Dashboard  <-> Payment
                        studentDashboard.To_Payment       += (s, e) => LoadScreen(payment);
                        payment.         To_Dashboard     += (s, e) => LoadScreen(studentDashboard);

                        // Student Dashboard  <-> Send Review
                        studentDashboard.To_SendReview    += (s, e) => LoadScreen(sendReview);
                        sendReview.      To_Dashboard     += (s, e) => LoadScreen(studentDashboard);

                        // Student Dashboard  <-> Manage Profile
                        studentDashboard.To_ManageProfile += (s, e) => LoadScreen(manageProfile);
                        manageProfile.   To_Dashboard     += (s, e) => LoadScreen(studentDashboard);

                        break;
                    }

                case "Maintenance Staff":
                    {
                        maintenanceStaff_Dashboard     maintenanceDashboard = new maintenanceStaff_Dashboard(user);
                        maintenanceStaff_ViewSchedule  viewSchedule         = new maintenanceStaff_ViewSchedule(user);
                        maintenanceStaff_UpdateStatus  updateStatus         = new maintenanceStaff_UpdateStatus(user);
                        maintenanceStaff_ManageRequest manageRequest        = new maintenanceStaff_ManageRequest(user);
                        maintenanceStaff_ManageProfile manageProfile        = new maintenanceStaff_ManageProfile(user);

                        // Login (successful)          <-> Maintenance Staff Dashboard
                        LoadScreen(maintenanceDashboard);
                        maintenanceDashboard.To_Login         += (s, e) => ShowLogin();

                        // Maintenance Staff Dashboard <-> View Schedule
                        maintenanceDashboard.To_ViewSchedule  += (s, e) => LoadScreen(viewSchedule);
                        viewSchedule.        To_Dashboard     += (s, e) => LoadScreen(maintenanceDashboard);

                        // Maintenance Staff Dashboard <-> Update Status
                        maintenanceDashboard.To_UpdateStatus  += (s, e) => LoadScreen(updateStatus);
                        updateStatus.        To_Dashboard     += (s, e) => LoadScreen(maintenanceDashboard);

                        // Maintenance Staff Dashboard <-> Manage Request
                        maintenanceDashboard.To_ManageRequest += (s, e) => LoadScreen(manageRequest);
                        manageRequest.       To_Dashboard     += (s, e) => LoadScreen(maintenanceDashboard);

                        // Maintenance Staff Dashboard <-> Manage Profile
                        maintenanceDashboard.To_ManageProfile += (s, e) => LoadScreen(manageProfile);
                        manageProfile.       To_Dashboard     += (s, e) => LoadScreen(maintenanceDashboard);

                        break;
                    }

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