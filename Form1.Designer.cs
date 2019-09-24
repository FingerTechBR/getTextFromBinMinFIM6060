namespace getTextFromBinMinFIM6060
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.bt_converter = new System.Windows.Forms.Button();
            this.pathfilename = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.rb_hv01 = new System.Windows.Forms.RadioButton();
            this.rb_ISO = new System.Windows.Forms.RadioButton();
            this.txt_textencode = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(220, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 25);
            this.button1.TabIndex = 0;
            this.button1.Text = "Selecionar Arquivo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // bt_converter
            // 
            this.bt_converter.Location = new System.Drawing.Point(13, 126);
            this.bt_converter.Name = "bt_converter";
            this.bt_converter.Size = new System.Drawing.Size(201, 23);
            this.bt_converter.TabIndex = 1;
            this.bt_converter.Text = "Converter";
            this.bt_converter.UseVisualStyleBackColor = true;
            this.bt_converter.Click += new System.EventHandler(this.Button2_Click);
            // 
            // pathfilename
            // 
            this.pathfilename.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.pathfilename.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.pathfilename.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.pathfilename.Enabled = false;
            this.pathfilename.HideSelection = false;
            this.pathfilename.Location = new System.Drawing.Point(12, 68);
            this.pathfilename.Name = "pathfilename";
            this.pathfilename.Size = new System.Drawing.Size(202, 20);
            this.pathfilename.TabIndex = 1;
            this.pathfilename.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 177);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(201, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Salvar (HV01)";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click_1);
            // 
            // rb_hv01
            // 
            this.rb_hv01.AutoSize = true;
            this.rb_hv01.Location = new System.Drawing.Point(24, 22);
            this.rb_hv01.Name = "rb_hv01";
            this.rb_hv01.Size = new System.Drawing.Size(115, 17);
            this.rb_hv01.TabIndex = 3;
            this.rb_hv01.TabStop = true;
            this.rb_hv01.Text = "MIN_Nitgen_HV01";
            this.rb_hv01.UseVisualStyleBackColor = true;
            this.rb_hv01.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // rb_ISO
            // 
            this.rb_ISO.AutoSize = true;
            this.rb_ISO.Location = new System.Drawing.Point(24, 45);
            this.rb_ISO.Name = "rb_ISO";
            this.rb_ISO.Size = new System.Drawing.Size(94, 17);
            this.rb_ISO.TabIndex = 4;
            this.rb_ISO.TabStop = true;
            this.rb_ISO.Text = "MINConv_ISO";
            this.rb_ISO.UseVisualStyleBackColor = true;
            this.rb_ISO.CheckedChanged += new System.EventHandler(this.Rb_ISO_CheckedChanged);
            // 
            // txt_textencode
            // 
            this.txt_textencode.Location = new System.Drawing.Point(220, 105);
            this.txt_textencode.MinimumSize = new System.Drawing.Size(0, 95);
            this.txt_textencode.Multiline = true;
            this.txt_textencode.Name = "txt_textencode";
            this.txt_textencode.Size = new System.Drawing.Size(150, 95);
            this.txt_textencode.TabIndex = 5;
            this.txt_textencode.TextChanged += new System.EventHandler(this.TextBox1_TextChanged_2);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 278);
            this.Controls.Add(this.txt_textencode);
            this.Controls.Add(this.rb_ISO);
            this.Controls.Add(this.rb_hv01);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pathfilename);
            this.Controls.Add(this.bt_converter);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bt_converter;
        private System.Windows.Forms.TextBox pathfilename;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton rb_hv01;
        private System.Windows.Forms.RadioButton rb_ISO;
        private System.Windows.Forms.TextBox txt_textencode;
    }
}

