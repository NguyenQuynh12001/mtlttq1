using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vd_web6
{
    public partial class frmlistboxs : Form
    {
        public frmlistboxs()
        {
            InitializeComponent();
        }
        private void frmlistboxs_Load(object sender, EventArgs e)
        {

        }

        private void btnok_Click(object sender, EventArgs e)
        {
            if (lbsite.SelectedItems.Count > 0)
            {
                txtsite.Text = "Bạn đã chọn site:" + Environment.NewLine + Environment.NewLine + lbsite.SelectedItem.ToString();
            }
        }
    }
}
