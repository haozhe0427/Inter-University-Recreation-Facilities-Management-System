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
    public partial class form_Login : Form
    {
        //--------------------------------------------------------------------------------//
        //                                   METHODS                                      //      
        //--------------------------------------------------------------------------------//
        private void Aligned()
        {
            // Center the title
            lbl_Login.Left       = (this.ClientSize.Width - lbl_Login.Width) / 2;

            // Center the textboxes, then align their labels to the same left edge
            int textBoxLeft      = (this.ClientSize.Width - txtBox_Username.Width) / 2;

            txtBox_Username.Left = textBoxLeft;
            lbl_Username.Left    = textBoxLeft;

            txtBox_Password.Left = textBoxLeft;
            lbl_Password.Left    = textBoxLeft;

            // Center the button
            btn_Login.Left       = (this.ClientSize.Width - btn_Login.Width) / 2;
        }



        //--------------------------------------------------------------------------------//
        //                                   FORM                                         //
        //--------------------------------------------------------------------------------//
        public form_Login()
        {
            InitializeComponent();
            // Set the minimum size of the form to its initial size
            this.MinimumSize = this.Size; 
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Aligned();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Aligned();
        }



        //--------------------------------------------------------------------------------//
        //                                  ELEMENT                                       //
        //--------------------------------------------------------------------------------//

        // 1. Login label
        private void lbl_Login_Click(object sender, EventArgs e)
        {
            Aligned();
        }

        // 2. Username label
        private void lbl_Username_Click(object sender, EventArgs e)
        {
            Aligned();
        }

        // 3. Username textbox
        private void txtBox_Username_TextChanged(object sender, EventArgs e)
        {
            Aligned();
        }

        // 4. Password label
        private void lbl_Password_Click(object sender, EventArgs e)
        {
            Aligned();
        }

        // 5. Password textbox
        private void txtBox_Password_TextChanged(object sender, EventArgs e)
        {
            Aligned();
        }

        // 6. Login button
        private void btn_Login_Click(object sender, EventArgs e)
        {
            Aligned();
        }
    }
}
