using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarMemberSystem
{
    public partial class commodityManagement : System.Windows.Forms.Form
    {
        public commodityManagement()
        {
            InitializeComponent();
        }

        private void btnretruehome_BtnClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
