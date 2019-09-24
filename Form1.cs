using NITGEN.SDK.NBioBSP;
using System;
using System.IO;
using System.Windows.Forms;

namespace getTextFromBinMinFIM6060
{
    public partial class Form1 : Form
    {

        //variáveis
        NBioAPI nBioAPI;
        FileStream fs;
        NBioAPI.Export m_Export;
        NBioAPI.Type.MINCONV_DATA_TYPE importType;
        NBioAPI.Type.HFIR processedFIR;
        uint nSize ;
        byte[] minData;
        String filename;


        public Form1()
        {
            InitializeComponent();
          
            
            this.bt_converter.Enabled = false;
            this.pathfilename.Enabled = false;
            this.button1.Enabled = false;
            this.txt_textencode.Enabled = false;
            this.button2.Enabled = false;

            //inveção de dependências
            nBioAPI = new NBioAPI();
            m_Export = new NBioAPI.Export(nBioAPI);

        }



        //abre o arquivo min, seja de acordo com o o check button, iso ou MINCONV_TYPE_FIM01_HV, lê o binário e guarda array de byte
        private void Button1_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            string szFileName = "";
            openFileDialog1.Filter = "MIN files (*.min)|*.min|All files (*.*)|*.*";                 

            if (openFileDialog1.ShowDialog(this) != DialogResult.OK)
                return;
            szFileName = openFileDialog1.FileName;

            if (szFileName != "")
            {
                    
                fs = new FileStream(szFileName, FileMode.Open, FileAccess.Read);
                BinaryReader fr = new BinaryReader(fs);

                nSize = (uint)fs.Length;
                minData = new byte[nSize];
                fr.Read(minData, 0, (int)nSize);
                fr.Close();
                fs.Close();
                pathfilename.Text = openFileDialog1.FileName;
                txt_textencode.Enabled = true;
                bt_converter.Enabled = true;
                button2.Enabled = true;
            }            
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
                                 
        }


       //verifica o formato a importar e converte para formato nitgen.
        private void Button2_Click(object sender, EventArgs e)
        {
                                           
            if (rb_hv01.Checked)            
                importType = NBioAPI.Type.MINCONV_DATA_TYPE.MINCONV_TYPE_FIM01_HV;           
            else if (rb_ISO.Checked)                
               importType = NBioAPI.Type.MINCONV_DATA_TYPE.MINCONV_TYPE_ISO;
                
         
            try
            {
                 m_Export.FDxToNBioBSPEx(minData, nSize, importType, NBioAPI.Type.FIR_PURPOSE.VERIFY, out processedFIR);
            }
            catch(Exception)
            {               
                String error = "Formato incompatível ";
                MessageBox.Show(error);
                return;
            }
            
            NBioAPI.Type.FIR_TEXTENCODE textencode;
            nBioAPI.GetTextFIRFromHandle(processedFIR, out textencode, true);
            txt_textencode.Text = textencode.TextFIR;
            MessageBox.Show("Convertido com Sucesso");

        }


        //salva a digital em formato MINCONV_TYPE_FIM01_H.min
        private void Button2_Click_1(object sender, EventArgs e)
        {
            NBioAPI.Export.EXPORT_DATA exportData;
            uint ret = m_Export.NBioBSPToFDx(processedFIR, out exportData, NBioAPI.Type.MINCONV_DATA_TYPE.MINCONV_TYPE_FIM01_HV);
            SaveFileDialog saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            string szFileName = "", szFileName2 = "";
            saveFileDialog1.Filter = "MIN files (*.min)|*.min|All files (*.*)|*.*";

            if (saveFileDialog1.ShowDialog(this) != DialogResult.OK)
                return;

            szFileName = saveFileDialog1.FileName;

            if (szFileName != "")
            {
                for (int f = 0; f < exportData.FingerNum; f++)
                {
                    for (int s = 0; s < exportData.SamplesPerFinger; s++)
                    {
                        szFileName2 = Path.GetDirectoryName(szFileName) + Path.DirectorySeparatorChar + Path.GetFileNameWithoutExtension(szFileName) + "_" + f.ToString() + "_" + s.ToString() + Path.GetExtension(szFileName);

                        FileStream fs = new FileStream(szFileName2, FileMode.OpenOrCreate, FileAccess.Write);
                        BinaryWriter fw = new BinaryWriter(fs);
                        fw.Write(exportData.FingerData[f].Template[s].Data);
                        fw.Close();
                        fs.Close();
                    }
                }
            }
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

            pathfilename.Enabled = true;
            button1.Enabled = true;
           
        }

        private void TextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged_2(object sender, EventArgs e)
        {

           
        }

        private void Rb_ISO_CheckedChanged(object sender, EventArgs e)
        {
            pathfilename.Enabled = true;
            button1.Enabled = true;
        }
    }
}
