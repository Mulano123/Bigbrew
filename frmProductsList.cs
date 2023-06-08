using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BigBrewPOS
{
    public partial class frmProductsList : Form
    {
        public frmProductsList()
        {
            InitializeComponent();
            for(int i = 1; i <= 10; i++)
            {
                dataGridView1.Rows.Add(i, "1", "Product " + i);
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
