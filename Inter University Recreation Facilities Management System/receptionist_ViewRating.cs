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
    public partial class receptionist_ViewRating : UserControl
    {
        public receptionist_ViewRating(User user)
        {
            InitializeComponent();
            this.Resize += (s, e) => Aligned();
        }

        private void Aligned()
        {
            lbl_ViewRating.Left = (this.ClientSize.Width - lbl_ViewRating.Width) / 2;
        }

        public event EventHandler BackRequested;
        private void btn_Back_Click(object sender, EventArgs e)
        {
            BackRequested?.Invoke(this, EventArgs.Empty);
        }
    }
}
