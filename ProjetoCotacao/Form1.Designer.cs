namespace ProjetoCotacao
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblVariation = new System.Windows.Forms.Label();
            this.LblSell = new System.Windows.Forms.Label();
            this.LblBuy = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblVariation
            // 
            this.LblVariation.BackColor = System.Drawing.Color.DimGray;
            this.LblVariation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblVariation.ForeColor = System.Drawing.Color.White;
            this.LblVariation.Location = new System.Drawing.Point(152, 247);
            this.LblVariation.Name = "LblVariation";
            this.LblVariation.Size = new System.Drawing.Size(275, 45);
            this.LblVariation.TabIndex = 14;
            this.LblVariation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblSell
            // 
            this.LblSell.BackColor = System.Drawing.Color.DimGray;
            this.LblSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblSell.ForeColor = System.Drawing.Color.White;
            this.LblSell.Location = new System.Drawing.Point(152, 190);
            this.LblSell.Name = "LblSell";
            this.LblSell.Size = new System.Drawing.Size(275, 45);
            this.LblSell.TabIndex = 13;
            this.LblSell.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblBuy
            // 
            this.LblBuy.BackColor = System.Drawing.Color.DimGray;
            this.LblBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblBuy.ForeColor = System.Drawing.Color.White;
            this.LblBuy.Location = new System.Drawing.Point(152, 129);
            this.LblBuy.Name = "LblBuy";
            this.LblBuy.Size = new System.Drawing.Size(275, 45);
            this.LblBuy.TabIndex = 12;
            this.LblBuy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(21, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 38);
            this.label3.TabIndex = 11;
            this.label3.Text = "Compra:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(15, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 44);
            this.label4.TabIndex = 9;
            this.label4.Text = "Variação:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(43, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 38);
            this.label2.TabIndex = 10;
            this.label2.Text = "Venda:";
            // 
            // BtnSearch
            // 
            this.BtnSearch.BackColor = System.Drawing.Color.DimGray;
            this.BtnSearch.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnSearch.Location = new System.Drawing.Point(148, 319);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(283, 55);
            this.BtnSearch.TabIndex = 8;
            this.BtnSearch.Text = "Pesquisar";
            this.BtnSearch.UseVisualStyleBackColor = false;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Firebrick;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(447, 68);
            this.label1.TabIndex = 7;
            this.label1.Text = "Dólar";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 450);
            this.Controls.Add(this.LblVariation);
            this.Controls.Add(this.LblSell);
            this.Controls.Add(this.LblBuy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Cotação do Dólar";
            this.ResumeLayout(false);

        }

        #endregion

        private Label LblVariation;
        private Label LblSell;
        private Label LblBuy;
        private Label label3;
        private Label label4;
        private Label label2;
        private Button BtnSearch;
        private Label label1;
    }
}