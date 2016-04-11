namespace EntityDemo_Form
{
    partial class Form1
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
            this.dtGrid = new System.Windows.Forms.DataGridView();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.txtKaydet = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtDegistir = new System.Windows.Forms.TextBox();
            this.btnDegistir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGrid
            // 
            this.dtGrid.AllowUserToAddRows = false;
            this.dtGrid.AllowUserToDeleteRows = false;
            this.dtGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrid.Location = new System.Drawing.Point(14, 15);
            this.dtGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtGrid.Name = "dtGrid";
            this.dtGrid.ReadOnly = true;
            this.dtGrid.Size = new System.Drawing.Size(338, 264);
            this.dtGrid.TabIndex = 0;
            this.dtGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGrid_CellClick);
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(359, 15);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(131, 31);
            this.btnListele.TabIndex = 1;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(496, 15);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(126, 31);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(359, 80);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(158, 24);
            this.txtAra.TabIndex = 3;
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(523, 77);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(99, 29);
            this.btnAra.TabIndex = 4;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // txtKaydet
            // 
            this.txtKaydet.Location = new System.Drawing.Point(359, 133);
            this.txtKaydet.Name = "txtKaydet";
            this.txtKaydet.Size = new System.Drawing.Size(158, 24);
            this.txtKaydet.TabIndex = 3;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(523, 130);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(99, 29);
            this.btnKaydet.TabIndex = 4;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtDegistir
            // 
            this.txtDegistir.Location = new System.Drawing.Point(359, 184);
            this.txtDegistir.Name = "txtDegistir";
            this.txtDegistir.Size = new System.Drawing.Size(158, 24);
            this.txtDegistir.TabIndex = 3;
            // 
            // btnDegistir
            // 
            this.btnDegistir.Location = new System.Drawing.Point(523, 181);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(99, 29);
            this.btnDegistir.TabIndex = 4;
            this.btnDegistir.Text = "Değiştir";
            this.btnDegistir.UseVisualStyleBackColor = true;
            this.btnDegistir.Click += new System.EventHandler(this.btnDegistir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 292);
            this.Controls.Add(this.btnDegistir);
            this.Controls.Add(this.txtDegistir);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtKaydet);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.dtGrid);
            this.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Entity Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGrid;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.TextBox txtKaydet;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtDegistir;
        private System.Windows.Forms.Button btnDegistir;
    }
}

