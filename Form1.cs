using NITGEN.SDK.NBioBSP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace getTextFromBinMinFIM6060
{
    public partial class Form1 : Form
    {
        private NBioAPI nBioAPI;
        private FileStream fs;
        NBioAPI.Export m_Export;
        NBioAPI.Type.MINCONV_DATA_TYPE importType;
        NBioAPI.Type.HFIR processedFIR;
        String filename;
        public Form1()
        {
            InitializeComponent();
            nBioAPI = new NBioAPI();
            m_Export = new NBioAPI.Export(nBioAPI);

        }
       
        private void Button1_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                filename = openFileDialog.FileName;
                pathfilename.Text = filename;
                fs = new FileStream(filename, FileMode.Open, FileAccess.Read);

            }



        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {




        }

        private void Button2_Click(object sender, EventArgs e)
        {
            
           
            uint nSize = (uint)fs.Length;
            byte[] minData = new byte[nSize];            
            importType = NBioAPI.Type.MINCONV_DATA_TYPE.MINCONV_TYPE_FIM01_HV;
            processedFIR = new NBioAPI.Type.HFIR();
            uint ret = m_Export.FDxToNBioBSPEx(minData, nSize, importType, NBioAPI.Type.FIR_PURPOSE.VERIFY, out processedFIR);
            NBioAPI.Type.FIR_TEXTENCODE textencode;
            nBioAPI.GetTextFIRFromHandle(processedFIR, out textencode, true);            
            MessageBox.Show(textencode.TextFIR);
        }
    }
}
