namespace Presentation
{
    partial class Clients
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
            this.AffichageData = new System.Windows.Forms.DataGridView();
            this.ButtonReader = new System.Windows.Forms.Button();
            this.ButtonInsert = new System.Windows.Forms.Button();
            this.ButtonUpdate = new System.Windows.Forms.Button();
            this.TexteID = new System.Windows.Forms.TextBox();
            this.TexteName = new System.Windows.Forms.TextBox();
            this.TexteAdress = new System.Windows.Forms.TextBox();
            this.TexteEmail = new System.Windows.Forms.TextBox();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.LabelID = new System.Windows.Forms.Label();
            this.LabelName = new System.Windows.Forms.Label();
            this.LabelAdress = new System.Windows.Forms.Label();
            this.LabelEmail = new System.Windows.Forms.Label();
            this.ButtonProduit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AffichageData)).BeginInit();
            this.SuspendLayout();
            // 
            // AffichageData
            // 
            this.AffichageData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AffichageData.Location = new System.Drawing.Point(12, 12);
            this.AffichageData.Name = "AffichageData";
            this.AffichageData.Size = new System.Drawing.Size(464, 261);
            this.AffichageData.TabIndex = 0;
            // 
            // ButtonReader
            // 
            this.ButtonReader.Location = new System.Drawing.Point(507, 52);
            this.ButtonReader.Name = "ButtonReader";
            this.ButtonReader.Size = new System.Drawing.Size(75, 23);
            this.ButtonReader.TabIndex = 1;
            this.ButtonReader.Text = "Reader";
            this.ButtonReader.UseVisualStyleBackColor = true;
            this.ButtonReader.Click += new System.EventHandler(this.ButtonReader_Click);
            // 
            // ButtonInsert
            // 
            this.ButtonInsert.Location = new System.Drawing.Point(507, 100);
            this.ButtonInsert.Name = "ButtonInsert";
            this.ButtonInsert.Size = new System.Drawing.Size(75, 23);
            this.ButtonInsert.TabIndex = 2;
            this.ButtonInsert.Text = "Insert";
            this.ButtonInsert.UseVisualStyleBackColor = true;
            this.ButtonInsert.Click += new System.EventHandler(this.ButtonInsert_Click);
            // 
            // ButtonUpdate
            // 
            this.ButtonUpdate.Location = new System.Drawing.Point(507, 151);
            this.ButtonUpdate.Name = "ButtonUpdate";
            this.ButtonUpdate.Size = new System.Drawing.Size(75, 23);
            this.ButtonUpdate.TabIndex = 3;
            this.ButtonUpdate.Text = "Update";
            this.ButtonUpdate.UseVisualStyleBackColor = true;
            // 
            // TexteID
            // 
            this.TexteID.Location = new System.Drawing.Point(12, 301);
            this.TexteID.Name = "TexteID";
            this.TexteID.Size = new System.Drawing.Size(100, 20);
            this.TexteID.TabIndex = 4;
            // 
            // TexteName
            // 
            this.TexteName.Location = new System.Drawing.Point(134, 301);
            this.TexteName.Name = "TexteName";
            this.TexteName.Size = new System.Drawing.Size(100, 20);
            this.TexteName.TabIndex = 5;
            // 
            // TexteAdress
            // 
            this.TexteAdress.Location = new System.Drawing.Point(264, 301);
            this.TexteAdress.Name = "TexteAdress";
            this.TexteAdress.Size = new System.Drawing.Size(100, 20);
            this.TexteAdress.TabIndex = 6;
            // 
            // TexteEmail
            // 
            this.TexteEmail.Location = new System.Drawing.Point(386, 301);
            this.TexteEmail.Name = "TexteEmail";
            this.TexteEmail.Size = new System.Drawing.Size(100, 20);
            this.TexteEmail.TabIndex = 7;
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Location = new System.Drawing.Point(507, 208);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(75, 23);
            this.ButtonDelete.TabIndex = 8;
            this.ButtonDelete.Text = "Delete";
            this.ButtonDelete.UseVisualStyleBackColor = true;
            // 
            // LabelID
            // 
            this.LabelID.AutoSize = true;
            this.LabelID.Location = new System.Drawing.Point(39, 283);
            this.LabelID.Name = "LabelID";
            this.LabelID.Size = new System.Drawing.Size(18, 13);
            this.LabelID.TabIndex = 9;
            this.LabelID.Text = "ID";
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Location = new System.Drawing.Point(163, 283);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(35, 13);
            this.LabelName.TabIndex = 10;
            this.LabelName.Text = "Name";
            // 
            // LabelAdress
            // 
            this.LabelAdress.AutoSize = true;
            this.LabelAdress.Location = new System.Drawing.Point(294, 283);
            this.LabelAdress.Name = "LabelAdress";
            this.LabelAdress.Size = new System.Drawing.Size(39, 13);
            this.LabelAdress.TabIndex = 11;
            this.LabelAdress.Text = "Adress";
            // 
            // LabelEmail
            // 
            this.LabelEmail.AutoSize = true;
            this.LabelEmail.Location = new System.Drawing.Point(419, 283);
            this.LabelEmail.Name = "LabelEmail";
            this.LabelEmail.Size = new System.Drawing.Size(32, 13);
            this.LabelEmail.TabIndex = 12;
            this.LabelEmail.Text = "Email";
            // 
            // ButtonProduit
            // 
            this.ButtonProduit.Location = new System.Drawing.Point(522, 371);
            this.ButtonProduit.Name = "ButtonProduit";
            this.ButtonProduit.Size = new System.Drawing.Size(75, 23);
            this.ButtonProduit.TabIndex = 13;
            this.ButtonProduit.Text = "Produit";
            this.ButtonProduit.UseVisualStyleBackColor = true;
            this.ButtonProduit.Click += new System.EventHandler(this.ButtonProduit_Click);
            // 
            // Clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 405);
            this.Controls.Add(this.ButtonProduit);
            this.Controls.Add(this.LabelEmail);
            this.Controls.Add(this.LabelAdress);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.LabelID);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.TexteEmail);
            this.Controls.Add(this.TexteAdress);
            this.Controls.Add(this.TexteName);
            this.Controls.Add(this.TexteID);
            this.Controls.Add(this.ButtonUpdate);
            this.Controls.Add(this.ButtonInsert);
            this.Controls.Add(this.ButtonReader);
            this.Controls.Add(this.AffichageData);
            this.Name = "Clients";
            this.Text = "Clients";
            ((System.ComponentModel.ISupportInitialize)(this.AffichageData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView AffichageData;
        private System.Windows.Forms.Button ButtonInsert;
        private System.Windows.Forms.Button ButtonUpdate;
        private System.Windows.Forms.TextBox TexteID;
        private System.Windows.Forms.TextBox TexteName;
        private System.Windows.Forms.TextBox TexteAdress;
        private System.Windows.Forms.TextBox TexteEmail;
        private System.Windows.Forms.Button ButtonReader;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.Label LabelID;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label LabelAdress;
        private System.Windows.Forms.Label LabelEmail;
        private System.Windows.Forms.Button ButtonProduit;
    }
}

