
namespace ALGORITHME
{
    partial class Home
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.HomePage = new System.Windows.Forms.TabPage();
            this.InstructionCrypt = new MaterialSkin.Controls.MaterialLabel();
            this.inputWordToCrypt = new System.Windows.Forms.TextBox();
            this.labelResultCrypt = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.labelResultDecrypt = new MaterialSkin.Controls.MaterialLabel();
            this.InstructionDecrypt = new MaterialSkin.Controls.MaterialLabel();
            this.inputWordToDecrypt = new System.Windows.Forms.TextBox();
            this.ClePage = new System.Windows.Forms.TabPage();
            this.inputCle = new System.Windows.Forms.TextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.tabControl1.SuspendLayout();
            this.HomePage.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.ClePage.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(-52, 14);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(288, 24);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Saisissez votre message à coder";
            // 
            // materialSingleLineTextField1
            // 
            this.materialSingleLineTextField1.Depth = 0;
            this.materialSingleLineTextField1.Hint = "";
            this.materialSingleLineTextField1.Location = new System.Drawing.Point(-71, 37);
            this.materialSingleLineTextField1.MaxLength = 32767;
            this.materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField1.Name = "materialSingleLineTextField1";
            this.materialSingleLineTextField1.PasswordChar = '\0';
            this.materialSingleLineTextField1.SelectedText = "";
            this.materialSingleLineTextField1.SelectionLength = 0;
            this.materialSingleLineTextField1.SelectionStart = 0;
            this.materialSingleLineTextField1.Size = new System.Drawing.Size(284, 28);
            this.materialSingleLineTextField1.TabIndex = 2;
            this.materialSingleLineTextField1.TabStop = false;
            this.materialSingleLineTextField1.Text = "materialSingleLineTextField1";
            this.materialSingleLineTextField1.UseSystemPasswordChar = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.HomePage);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.ClePage);
            this.tabControl1.Location = new System.Drawing.Point(2, 66);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(794, 380);
            this.tabControl1.TabIndex = 0;
            // 
            // HomePage
            // 
            this.HomePage.Controls.Add(this.InstructionCrypt);
            this.HomePage.Controls.Add(this.inputWordToCrypt);
            this.HomePage.Controls.Add(this.labelResultCrypt);
            this.HomePage.Location = new System.Drawing.Point(4, 25);
            this.HomePage.Name = "HomePage";
            this.HomePage.Padding = new System.Windows.Forms.Padding(3);
            this.HomePage.Size = new System.Drawing.Size(786, 351);
            this.HomePage.TabIndex = 0;
            this.HomePage.Text = "Cryptage";
            this.HomePage.UseVisualStyleBackColor = true;
            // 
            // InstructionCrypt
            // 
            this.InstructionCrypt.AutoSize = true;
            this.InstructionCrypt.Depth = 0;
            this.InstructionCrypt.Font = new System.Drawing.Font("Roboto", 11F);
            this.InstructionCrypt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.InstructionCrypt.Location = new System.Drawing.Point(6, 63);
            this.InstructionCrypt.MouseState = MaterialSkin.MouseState.HOVER;
            this.InstructionCrypt.Name = "InstructionCrypt";
            this.InstructionCrypt.Size = new System.Drawing.Size(202, 24);
            this.InstructionCrypt.TabIndex = 2;
            this.InstructionCrypt.Text = "Entrez votre message :";
            // 
            // inputWordToCrypt
            // 
            this.inputWordToCrypt.Location = new System.Drawing.Point(232, 65);
            this.inputWordToCrypt.Name = "inputWordToCrypt";
            this.inputWordToCrypt.Size = new System.Drawing.Size(323, 22);
            this.inputWordToCrypt.TabIndex = 1;
            this.inputWordToCrypt.TextChanged += new System.EventHandler(this.LaunchAlgoCrypt);
            // 
            // labelResultCrypt
            // 
            this.labelResultCrypt.AutoSize = true;
            this.labelResultCrypt.Location = new System.Drawing.Point(195, 193);
            this.labelResultCrypt.Name = "labelResultCrypt";
            this.labelResultCrypt.Size = new System.Drawing.Size(0, 17);
            this.labelResultCrypt.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.labelResultDecrypt);
            this.tabPage1.Controls.Add(this.InstructionDecrypt);
            this.tabPage1.Controls.Add(this.inputWordToDecrypt);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(786, 351);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Decryptage";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // labelResultDecrypt
            // 
            this.labelResultDecrypt.AutoSize = true;
            this.labelResultDecrypt.Depth = 0;
            this.labelResultDecrypt.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelResultDecrypt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelResultDecrypt.Location = new System.Drawing.Point(232, 161);
            this.labelResultDecrypt.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelResultDecrypt.Name = "labelResultDecrypt";
            this.labelResultDecrypt.Size = new System.Drawing.Size(0, 24);
            this.labelResultDecrypt.TabIndex = 4;
            // 
            // InstructionDecrypt
            // 
            this.InstructionDecrypt.AutoSize = true;
            this.InstructionDecrypt.Depth = 0;
            this.InstructionDecrypt.Font = new System.Drawing.Font("Roboto", 11F);
            this.InstructionDecrypt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.InstructionDecrypt.Location = new System.Drawing.Point(6, 63);
            this.InstructionDecrypt.MouseState = MaterialSkin.MouseState.HOVER;
            this.InstructionDecrypt.Name = "InstructionDecrypt";
            this.InstructionDecrypt.Size = new System.Drawing.Size(202, 24);
            this.InstructionDecrypt.TabIndex = 3;
            this.InstructionDecrypt.Text = "Entrez votre message :";
            // 
            // inputWordToDecrypt
            // 
            this.inputWordToDecrypt.Location = new System.Drawing.Point(232, 65);
            this.inputWordToDecrypt.Name = "inputWordToDecrypt";
            this.inputWordToDecrypt.Size = new System.Drawing.Size(323, 22);
            this.inputWordToDecrypt.TabIndex = 0;
            this.inputWordToDecrypt.TextChanged += new System.EventHandler(this.LaunchAlgoDecrypt);
            // 
            // ClePage
            // 
            this.ClePage.Controls.Add(this.inputCle);
            this.ClePage.Controls.Add(this.materialLabel1);
            this.ClePage.Location = new System.Drawing.Point(4, 25);
            this.ClePage.Name = "ClePage";
            this.ClePage.Padding = new System.Windows.Forms.Padding(3);
            this.ClePage.Size = new System.Drawing.Size(786, 351);
            this.ClePage.TabIndex = 1;
            this.ClePage.Text = "Cle";
            this.ClePage.UseVisualStyleBackColor = true;
            // 
            // inputCle
            // 
            this.inputCle.Location = new System.Drawing.Point(189, 33);
            this.inputCle.Name = "inputCle";
            this.inputCle.Size = new System.Drawing.Size(154, 22);
            this.inputCle.TabIndex = 2;
            this.inputCle.Text = "ISTIL";
            this.inputCle.TextChanged += new System.EventHandler(this.changeKey);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(23, 31);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(151, 24);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Clé de cryptage :";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Home";
            this.Text = "Application de cryptographie";
            this.tabControl1.ResumeLayout(false);
            this.HomePage.ResumeLayout(false);
            this.HomePage.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ClePage.ResumeLayout(false);
            this.ClePage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage HomePage;
        private System.Windows.Forms.TabPage ClePage;
        private System.Windows.Forms.TextBox inputWordToCrypt;
        private System.Windows.Forms.Label labelResultCrypt;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel InstructionCrypt;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox inputWordToDecrypt;
        private MaterialSkin.Controls.MaterialLabel labelResultDecrypt;
        private MaterialSkin.Controls.MaterialLabel InstructionDecrypt;
        private System.Windows.Forms.TextBox inputCle;
    }
}

