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
            Login.Dock  = DockStyle.Fill;
            Login.LoginSuccessful += (s, user) => HandleLoginSuccess(user);
            pnl_Container.Controls.Add(Login);
        }

        private void HandleLoginSuccess(User user) 
        {
            switch (user.AccountRole) 
            {
                case "Manager":
                    manager_Dashboard manager_Dashboard       = new manager_Dashboard(user);
                    manager_ManageAccount manageAccount       = new manager_ManageAccount(user);
                    manager_ManageFacility manageFacility     = new manager_ManageFacility(user);
                    manager_AssignSchedule assignSchedule     = new manager_AssignSchedule(user);
                    manager_EquipmentRequest equipmentRequest = new manager_EquipmentRequest(user);

                    LoadScreen(manager_Dashboard);

                    manager_Dashboard.LogoutRequested += (s, e) => ShowLogin();

                    manager_Dashboard.ManageAccountRequested += (s, e) => LoadScreen(manageAccount);
                    manageAccount.BackRequested += (s, e) => LoadScreen(manager_Dashboard);

                    manager_Dashboard.ManageFacilityRequested += (s, e) => LoadScreen(manageFacility);
                    manageFacility.BackRequested += (s, e) => LoadScreen(manager_Dashboard);

                    manager_Dashboard.AssignSchedule += (s, e) => LoadScreen(assignSchedule);
                    assignSchedule.BackRequested += (s, e) => LoadScreen(manager_Dashboard);

                    manager_Dashboard.EquipmentRequest += (s, e) => LoadScreen(equipmentRequest);
                    equipmentRequest.BackRequested += (s, e) => LoadScreen(manager_Dashboard);

                    break;


                case "Receptionist":
                    receptionist_Dashboard receptionistDashboard     = new receptionist_Dashboard(user);
                    receptionist_ManageAccount manageAccount_Student = new receptionist_ManageAccount(user);
                    receptionist_ManageBooking manageBooking         = new receptionist_ManageBooking(user);
                    receptionist_ManagePayment managePayment         = new receptionist_ManagePayment(user);
                    receptionist_ViewRating viewRating               = new receptionist_ViewRating(user);

                    LoadScreen(receptionistDashboard);

                    receptionistDashboard.LogoutRequested += (s, e) => ShowLogin();

                    receptionistDashboard.ManageAccountRequested += (s, e) => LoadScreen(manageAccount_Student);
                    manageAccount_Student.BackRequested += (s, e) => LoadScreen(receptionistDashboard);

                    receptionistDashboard.ManageBookingRequested += (s, e) => LoadScreen(manageBooking);
                    manageBooking.BackRequested += (s, e) => LoadScreen(receptionistDashboard);
                    
                    receptionistDashboard.ManagePaymentRequested += (s, e) => LoadScreen(managePayment);
                    managePayment.BackRequested += (s, e) => LoadScreen(receptionistDashboard);

                    receptionistDashboard.ViewRatingRequested += (s, e) => LoadScreen(viewRating);
                    viewRating.BackRequested += (s, e) => LoadScreen(receptionistDashboard);

                    break;


                case "Student":
                    student_Dashboard studentDashboard    = new student_Dashboard(user);
                    student_SearchFacility searchFacility = new student_SearchFacility(user);
                    student_Payment payment               = new student_Payment(user);
                    student_SendReview sendReview         = new student_SendReview(user);
                    student_ManageProfile manageProfile_s = new student_ManageProfile(user);

                    LoadScreen(studentDashboard);

                    studentDashboard.LogoutRequested += (s, e) => ShowLogin();

                    studentDashboard.SearchFacilityRequested += (s, e) => LoadScreen(searchFacility);
                    searchFacility.BackRequested += (s, e) => LoadScreen(studentDashboard);

                    studentDashboard.PaymentRequested += (s, e) => LoadScreen(payment);
                    payment.BackRequested += (s, e) => LoadScreen(studentDashboard);

                    studentDashboard.SendReviewRequested += (s, e) => LoadScreen(sendReview);
                    sendReview.BackRequested += (s, e) => LoadScreen(studentDashboard);

                    studentDashboard.ManageProfileRequested += (s, e) => LoadScreen(manageProfile_s);
                    manageProfile_s.BackRequested += (s, e) => LoadScreen(studentDashboard);

                    break;

                case "Maintainance Staff":
                    maintainanceStaff_Dashboard maintainanceDashboard = new maintainanceStaff_Dashboard(user);
                    maintainanceStaff_ViewSchedule viewSchedule       = new maintainanceStaff_ViewSchedule(user);
                    maintainanceStaff_UpdateStatus updateStatus       = new maintainanceStaff_UpdateStatus(user);
                    maintainanceStaff_ManageRequest manageRequest     = new maintainanceStaff_ManageRequest(user);
                    maintainanceStaff_ManageProfile manageProfile_m   = new maintainanceStaff_ManageProfile(user);

                    LoadScreen(maintainanceDashboard);

                    maintainanceDashboard.LogoutRequested += (s, e) => ShowLogin();

                    maintainanceDashboard.ViewScheduleRequested += (s, e) => LoadScreen(viewSchedule);
                    viewSchedule.BackRequested += (s, e) => LoadScreen(maintainanceDashboard);

                    maintainanceDashboard.UpdateStatusRequested += (s, e) => LoadScreen(updateStatus);
                    updateStatus.BackRequested += (s, e) => LoadScreen(maintainanceDashboard);

                    maintainanceDashboard.ManageRequestRequested += (s, e) => LoadScreen(manageRequest);
                    manageRequest.BackRequested += (s, e) => LoadScreen(maintainanceDashboard);

                    maintainanceDashboard.ManageProfileRequested += (s, e) => LoadScreen(manageProfile_m);
                    manageProfile_m.BackRequested += (s, e) => LoadScreen(maintainanceDashboard);

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