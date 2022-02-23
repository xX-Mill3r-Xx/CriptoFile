
namespace CriptoFile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonEncryptFile = new System.Windows.Forms.Button();
            this.buttonDecryptFile = new System.Windows.Forms.Button();
            this.buttonCreateAsmKeys = new System.Windows.Forms.Button();
            this.buttonExportPublicKeys = new System.Windows.Forms.Button();
            this.buttonImportPublicKeys = new System.Windows.Forms.Button();
            this.buttonGetPrivateKey = new System.Windows.Forms.Button();
            this.txt_Key = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(960, 214);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chave não Definida";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(991, 240);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.txt_Key);
            this.panel2.Location = new System.Drawing.Point(12, 268);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(991, 100);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.buttonGetPrivateKey);
            this.panel3.Controls.Add(this.buttonImportPublicKeys);
            this.panel3.Controls.Add(this.buttonExportPublicKeys);
            this.panel3.Controls.Add(this.buttonCreateAsmKeys);
            this.panel3.Controls.Add(this.buttonDecryptFile);
            this.panel3.Controls.Add(this.buttonEncryptFile);
            this.panel3.Location = new System.Drawing.Point(12, 384);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(991, 192);
            this.panel3.TabIndex = 3;
            // 
            // buttonEncryptFile
            // 
            this.buttonEncryptFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEncryptFile.Location = new System.Drawing.Point(132, 23);
            this.buttonEncryptFile.Name = "buttonEncryptFile";
            this.buttonEncryptFile.Size = new System.Drawing.Size(237, 68);
            this.buttonEncryptFile.TabIndex = 0;
            this.buttonEncryptFile.Text = "Criptografar Arquivo";
            this.buttonEncryptFile.UseVisualStyleBackColor = true;
            this.buttonEncryptFile.Click += new System.EventHandler(this.buttonEncryptFile_Click);
            // 
            // buttonDecryptFile
            // 
            this.buttonDecryptFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDecryptFile.Location = new System.Drawing.Point(375, 23);
            this.buttonDecryptFile.Name = "buttonDecryptFile";
            this.buttonDecryptFile.Size = new System.Drawing.Size(237, 68);
            this.buttonDecryptFile.TabIndex = 1;
            this.buttonDecryptFile.Text = "Descriptografar Arquivo";
            this.buttonDecryptFile.UseVisualStyleBackColor = true;
            this.buttonDecryptFile.Click += new System.EventHandler(this.buttonDecryptFile_Click);
            // 
            // buttonCreateAsmKeys
            // 
            this.buttonCreateAsmKeys.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateAsmKeys.Location = new System.Drawing.Point(618, 23);
            this.buttonCreateAsmKeys.Name = "buttonCreateAsmKeys";
            this.buttonCreateAsmKeys.Size = new System.Drawing.Size(237, 68);
            this.buttonCreateAsmKeys.TabIndex = 2;
            this.buttonCreateAsmKeys.Text = "Criar Chaves";
            this.buttonCreateAsmKeys.UseVisualStyleBackColor = true;
            this.buttonCreateAsmKeys.Click += new System.EventHandler(this.buttonCreateAsmKeys_Click);
            // 
            // buttonExportPublicKeys
            // 
            this.buttonExportPublicKeys.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExportPublicKeys.Location = new System.Drawing.Point(132, 97);
            this.buttonExportPublicKeys.Name = "buttonExportPublicKeys";
            this.buttonExportPublicKeys.Size = new System.Drawing.Size(237, 68);
            this.buttonExportPublicKeys.TabIndex = 3;
            this.buttonExportPublicKeys.Text = "Exportar Chave Publica";
            this.buttonExportPublicKeys.UseVisualStyleBackColor = true;
            this.buttonExportPublicKeys.Click += new System.EventHandler(this.buttonExportPublicKeys_Click);
            // 
            // buttonImportPublicKeys
            // 
            this.buttonImportPublicKeys.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonImportPublicKeys.Location = new System.Drawing.Point(375, 97);
            this.buttonImportPublicKeys.Name = "buttonImportPublicKeys";
            this.buttonImportPublicKeys.Size = new System.Drawing.Size(237, 68);
            this.buttonImportPublicKeys.TabIndex = 4;
            this.buttonImportPublicKeys.Text = "Importar Chave Publica";
            this.buttonImportPublicKeys.UseVisualStyleBackColor = true;
            this.buttonImportPublicKeys.Click += new System.EventHandler(this.buttonImportPublicKeys_Click);
            // 
            // buttonGetPrivateKey
            // 
            this.buttonGetPrivateKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGetPrivateKey.Location = new System.Drawing.Point(618, 97);
            this.buttonGetPrivateKey.Name = "buttonGetPrivateKey";
            this.buttonGetPrivateKey.Size = new System.Drawing.Size(237, 68);
            this.buttonGetPrivateKey.TabIndex = 5;
            this.buttonGetPrivateKey.Text = "Obter Chave Privada";
            this.buttonGetPrivateKey.UseVisualStyleBackColor = true;
            this.buttonGetPrivateKey.Click += new System.EventHandler(this.buttonGetPrivateKey_Click);
            // 
            // txt_Key
            // 
            this.txt_Key.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Key.Location = new System.Drawing.Point(132, 31);
            this.txt_Key.Name = "txt_Key";
            this.txt_Key.Size = new System.Drawing.Size(723, 34);
            this.txt_Key.TabIndex = 0;
            this.txt_Key.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 588);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CriptoFile";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_Key;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonGetPrivateKey;
        private System.Windows.Forms.Button buttonImportPublicKeys;
        private System.Windows.Forms.Button buttonExportPublicKeys;
        private System.Windows.Forms.Button buttonCreateAsmKeys;
        private System.Windows.Forms.Button buttonDecryptFile;
        private System.Windows.Forms.Button buttonEncryptFile;
    }
}

