using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeDinhTho_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       EmloyeeBAL emlBAL = new EmloyeeBAL();
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
  
        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            btnThoat.Enabled = true;
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<EmloyeeBEL> lstEml = emlBAL.ReadEmloyee();
            foreach (EmloyeeBEL eml in lstEml)
            {
                dateCgv.Rows.Add(eml.Id, eml.Name, eml.AreaName);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
           EmloyeeBEL eml = new EmloyeeBEL();
           
            eml.Name = tbTen.Text;

            emlBAL.DeleteEmloyee(eml);

            int idx = dateCgv.CurrentCell.RowIndex;
            dateCgv.Rows.RemoveAt(idx);
        }
    }
}
