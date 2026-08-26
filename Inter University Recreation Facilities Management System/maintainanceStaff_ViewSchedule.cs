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
    public partial class maintainanceStaff_ViewSchedule : UserControl
    {
        public maintainanceStaff_ViewSchedule(User user)
        {
            InitializeComponent();
            this.Resize += (s, e) => Aligned();
        }

        private void Aligned()
        {
            lbl_ViewSchedule.Left = (this.Width - lbl_ViewSchedule.Width) / 2;
        }

        public event EventHandler BackRequested;
        private void btn_Back_Click(object sender, EventArgs e)
        {
            BackRequested?.Invoke(this, EventArgs.Empty);
        }
    }
}
