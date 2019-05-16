namespace Presentation
{
    partial class Produits
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AffichageData = new System.Windows.Forms.DataGridView();
            this.ButtonReaderP = new System.Windows.Forms.Button();
            this.ButtonInsertP = new System.Windows.Forms.Button();
            this.ButtonUpdateP = new System.Windows.Forms.Button();
            this.ButtonDeleteP = new System.Windows.Forms.Button();
            this.TexteIDP = new System.Windows.Forms.TextBox();
            this.TexteLibelleP = new System.Windows.Forms.TextBox();
            this.TextePrixP = new System.Windows.Forms.TextBox();
            this.TexteQuantiteP = new System.Windows.Forms.TextBox();
            this.LabelIDProduit = new System.Windows.Forms.Label();
            this.LabelLibelle = new System.Windows.Forms.Label();
            this.LabelPrice = new System.Windows.Forms.Label();
            this.LabelQuantite = new System.Windows.Forms.Label();
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
            // ButtonReaderP
            // 
            this.ButtonReaderP.Location = new System.Drawing.Point(507, 52);
            this.ButtonReaderP.Name = "ButtonReaderP";
            this.ButtonReaderP.Size = new System.Drawing.Size(75, 23);
            this.ButtonReaderP.TabIndex = 1;
            this.ButtonReaderP.Text = "Reader";
            this.ButtonReaderP.UseVisualStyleBackColor = true;
            this.ButtonReaderP.Click += new System.EventHandler(this.ButtonReaderP_Click);
            // 
            // ButtonInsertP
            // 
            this.ButtonInsertP.Location = new System.Drawing.Point(507, 100);
            this.ButtonInsertP.Name = "ButtonInsertP";
            this.ButtonInsertP.Size = new System.Drawing.Size(75, 23);
            this.ButtonInsertP.TabIndex = 2;
            this.ButtonInsertP.Text = "Insert";
            this.ButtonInsertP.UseVisualStyleBackColor = true;
            this.ButtonInsertP.Click += new System.EventHandler(this.ButtonInsertP_Click);
            // 
            // ButtonUpdateP
            // 
            this.ButtonUpdateP.Location = new System.Drawing.Point(507, 151);
            this.ButtonUpdateP.Name = "ButtonUpdateP";
            this.ButtonUpdateP.Size = new System.Drawing.Size(75, 23);
            this.ButtonUpdateP.TabIndex = 3;
            this.ButtonUpdateP.Text = "Update";
            this.ButtonUpdateP.UseVisualStyleBackColor = true;
            // 
            // ButtonDeleteP
            // 
            this.ButtonDeleteP.Location = new System.Drawing.Point(507, 208);
            this.ButtonDeleteP.Name = "ButtonDeleteP";
            this.ButtonDeleteP.Size = new System.Drawing.Size(75, 23);
            this.ButtonDeleteP.TabIndex = 4;
            this.ButtonDeleteP.Text = "Delete";
            this.ButtonDeleteP.UseVisualStyleBackColor = true;
            // 
            // TexteIDP
            // 
            this.TexteIDP.Location = new System.Drawing.Point(12, 301);
            this.TexteIDP.Name = "TexteIDP";
            this.TexteIDP.Size = new System.Drawing.Size(100, 20);
            this.TexteIDP.TabIndex = 5;
            // 
            // TexteLibelleP
            // 
            this.TexteLibelleP.Location = new System.Drawing.Point(134, 301);
            this.TexteLibelleP.Name = "TexteLibelleP";
            this.TexteLibelleP.Size = new System.Drawing.Size(100, 20);
            this.TexteLibelleP.TabIndex = 6;
            // 
            // TextePrixP
            // 
            this.TextePrixP.Location = new System.Drawing.Point(264, 301);
            this.TextePrixP.Name = "TextePrixP";
            this.TextePrixP.Size = new System.Drawing.Size(100, 20);
            this.TextePrixP.TabIndex = 7;
            // 
            // TexteQuantiteP
            // 
            this.TexteQuantiteP.Location = new System.Drawing.Point(386, 301);
            this.TexteQuantiteP.Name = "TexteQuantiteP";
            this.TexteQuantiteP.Size = new System.Drawing.Size(100, 20);
            this.TexteQuantiteP.TabIndex = 8;
            // 
            // LabelIDProduit
            // 
            this.LabelIDProduit.AutoSize = true;
            this.LabelIDProduit.Location = new System.Drawing.Point(39, 283);
            this.LabelIDProduit.Name = "LabelIDProduit";
            this.LabelIDProduit.Size = new System.Drawing.Size(18, 13);
            this.LabelIDProduit.TabIndex = 9;
            this.LabelIDProduit.Text = "ID";
            // 
            // LabelLibelle
            // 
            this.LabelLibelle.AutoSize = true;
            this.LabelLibelle.Location = new System.Drawing.Point(167, 283);
            this.LabelLibelle.Name = "LabelLibelle";
            this.LabelLibelle.Size = new System.Drawing.Size(37, 13);
            this.LabelLibelle.TabIndex = 10;
            this.LabelLibelle.Text = "Libelle";
            // 
            // LabelPrice
            // 
            this.LabelPrice.AutoSize = true;
            this.LabelPrice.Location = new System.Drawing.Point(299, 283);
            this.LabelPrice.Name = "LabelPrice";
            this.LabelPrice.Size = new System.Drawing.Size(31, 13);
            this.LabelPrice.TabIndex = 11;
            this.LabelPrice.Text = "Price";
            // 
            // LabelQuantite
            // 
            this.LabelQuantite.AutoSize = true;
            this.LabelQuantite.Location = new System.Drawing.Point(417, 283);
            this.LabelQuantite.Name = "LabelQuantite";
            this.LabelQuantite.Size = new System.Drawing.Size(46, 13);
            this.LabelQuantite.TabIndex = 12;
            this.LabelQuantite.Text = "Quantity";
            // 
            // Produits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 389);
            this.Controls.Add(this.LabelQuantite);
            this.Controls.Add(this.LabelPrice);
            this.Controls.Add(this.LabelLibelle);
            this.Controls.Add(this.LabelIDProduit);
            this.Controls.Add(this.TexteQuantiteP);
            this.Controls.Add(this.TextePrixP);
            this.Controls.Add(this.TexteLibelleP);
            this.Controls.Add(this.TexteIDP);
            this.Controls.Add(this.ButtonDeleteP);
            this.Controls.Add(this.ButtonUpdateP);
            this.Controls.Add(this.ButtonInsertP);
            this.Controls.Add(this.ButtonReaderP);
            this.Controls.Add(this.AffichageData);
            this.Name = "Produits";
            this.Text = "Produit";
            ((System.ComponentModel.ISupportInitialize)(this.AffichageData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView AffichageData;
        private System.Windows.Forms.Button ButtonReaderP;
        private System.Windows.Forms.Button ButtonInsertP;
        private System.Windows.Forms.Button ButtonUpdateP;
        private System.Windows.Forms.Button ButtonDeleteP;
        private System.Windows.Forms.TextBox TexteIDP;
        private System.Windows.Forms.TextBox TexteLibelleP;
        private System.Windows.Forms.TextBox TextePrixP;
        private System.Windows.Forms.TextBox TexteQuantiteP;
        private System.Windows.Forms.Label LabelIDProduit;
        private System.Windows.Forms.Label LabelLibelle;
        private System.Windows.Forms.Label LabelPrice;
        private System.Windows.Forms.Label LabelQuantite;
    }
}