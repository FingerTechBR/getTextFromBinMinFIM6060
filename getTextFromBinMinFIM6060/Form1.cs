using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace getTextFromBinMinFIM6060
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        String filename;
        private void Button1_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                filename = openFileDialog.FileName;
                pathfilename.Text = filename;
              
                //MessageBox.Show(filename);

            }



        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {


        }
    }
}
