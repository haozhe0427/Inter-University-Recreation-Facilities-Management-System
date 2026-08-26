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
            Login.Dock     = DockStyle.Fill;
            Login.LoginSuccessful += (s, user) => HandleLoginSuccess(user);
            pnl_Container.Controls.Add(Login);
        }

        private void HandleLoginSuccess(User user) 
        {
            switch (user.AccountRole) 
            {
                case "Manager":
                    manager_Dashboard managerDashboard = new manager_Dashboard(user);
                    managerDashboard.LogoutRequested += (s, e) => ShowLogin();
                    LoadScreen(managerDashboard);
                    break;

                case "Receptionist":
                    receptionist_Dashboard receptionistDashboard = new receptionist_Dashboard(user);
                    receptionistDashboard.LogoutRequested += (s, e) => ShowLogin();
                    LoadScreen(receptionistDashboard);
                    break;

                case "Student":
                    student_Dashboard studentDashboard = new student_Dashboard(user);
                    studentDashboard.LogoutRequested += (s, e) => ShowLogin();
                    LoadScreen(studentDashboard);
                    break;

                case "Maintainance Staff":
                    maintainanceStaff_Dashboard maintainanceDashboard = new maintainanceStaff_Dashboard(user);
                    maintainanceDashboard.LogoutRequested += (s, e) => ShowLogin();
                    LoadScreen(maintainanceDashboard);
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
