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
    public partial class manager_AssignSchedule : UserControl
    {
        public manager_AssignSchedule(User user)
        {
            InitializeComponent();
            this.Resize += (s, e) => Aligned();
        }

        private void Aligned() 
        {
            lbl_AssignSchedule.Left = (this.ClientSize.Width - lbl_AssignSchedule.Width) / 2;
        }

        public event EventHandler To_Dashboard;
        private void btn_Back_Click(object sender, EventArgs e)
        {
            To_Dashboard?.Invoke(this, EventArgs.Empty);
        }
    }
}
