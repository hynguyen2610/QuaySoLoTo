using CEMS.Controls.Commons;

namespace QuaySoLoto
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblSo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgrSo = new CEMS.Controls.Commons.DataGridViewEx();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnQuay = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrSo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::QuaySoLoto.Properties.Resources._1EB7C2E8718C574FEE3C1886F908C78E7A2AABC80FDDD73C10_pimgpsh_fullsize_distr;
            this.pictureBox1.Location = new System.Drawing.Point(3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(888, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblSo
            // 
            this.lblSo.AutoSize = true;
            this.lblSo.Font = new System.Drawing.Font("Impact", 90F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSo.Location = new System.Drawing.Point(38, 189);
            this.lblSo.Name = "lblSo";
            this.lblSo.Size = new System.Drawing.Size(473, 145);
            this.lblSo.TabIndex = 1;
            this.lblSo.Text = "1234567";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(542, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(340, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Danh sách các số trúng thưởng";
            // 
            // dgrSo
            // 
            this.dgrSo.AllowUserToAddRows = false;
            this.dgrSo.AllowUserToDeleteRows = false;
            this.dgrSo.AllowUserToOrderColumns = true;
            this.dgrSo.AllowUserToResizeColumns = false;
            this.dgrSo.AllowUserToResizeRows = false;
            this.dgrSo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgrSo.AutoGenerateColumns = false;
            this.dgrSo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrSo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgrSo.DataSource = this.bindingSource1;
            this.dgrSo.Location = new System.Drawing.Point(562, 231);
            this.dgrSo.Name = "dgrSo";
            this.dgrSo.ReadOnly = true;
            this.dgrSo.Size = new System.Drawing.Size(320, 159);
            this.dgrSo.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "So";
            this.Column1.HeaderText = "Số trúng thưởng";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // btnQuay
            // 
            this.btnQuay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuay.Location = new System.Drawing.Point(421, 353);
            this.btnQuay.Name = "btnQuay";
            this.btnQuay.Size = new System.Drawing.Size(101, 37);
            this.btnQuay.TabIndex = 4;
            this.btnQuay.Text = "Quay";
            this.btnQuay.UseVisualStyleBackColor = true;
            this.btnQuay.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 402);
            this.Controls.Add(this.btnQuay);
            this.Controls.Add(this.dgrSo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSo);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Quay số";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrSo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblSo;
        private System.Windows.Forms.Label label2;
        private CEMS.Controls.Commons.DataGridViewEx dgrSo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button btnQuay;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}

