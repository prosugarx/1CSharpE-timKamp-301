namespace CSharpEğtimKampı301.EFProject
{
    partial class FrmLocation
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnList = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDayNight = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbGuide = new System.Windows.Forms.ComboBox();
            this.nudCpacity = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCpacity)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Purple;
            this.btnUpdate.Location = new System.Drawing.Point(132, 487);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(241, 41);
            this.btnUpdate.TabIndex = 27;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.ForeColor = System.Drawing.Color.Purple;
            this.btnDelete.Location = new System.Drawing.Point(132, 435);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(241, 46);
            this.btnDelete.TabIndex = 26;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.ForeColor = System.Drawing.Color.Purple;
            this.btnAdd.Location = new System.Drawing.Point(132, 384);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(241, 45);
            this.btnAdd.TabIndex = 25;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(132, 73);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(241, 22);
            this.txtCity.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "Şehir:";
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(132, 114);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(241, 22);
            this.txtCountry.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Ülke:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(83, -24);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(241, 22);
            this.txtId.TabIndex = 20;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(396, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(622, 517);
            this.dataGridView1.TabIndex = 19;
            // 
            // btnList
            // 
            this.btnList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnList.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnList.ForeColor = System.Drawing.Color.Purple;
            this.btnList.Location = new System.Drawing.Point(132, 332);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(241, 46);
            this.btnList.TabIndex = 18;
            this.btnList.Text = "Listele";
            this.btnList.UseVisualStyleBackColor = false;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, -18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Rehber Id:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 29;
            this.label4.Text = "Lokasyon Id:";
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(132, 29);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(241, 22);
            this.textId.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 35;
            this.label5.Text = "Kapasite:";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(132, 210);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(241, 22);
            this.txtPrice.TabIndex = 34;
            this.txtPrice.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(69, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 16);
            this.label6.TabIndex = 33;
            this.label6.Text = "Fiyat:";
            // 
            // txtDayNight
            // 
            this.txtDayNight.Location = new System.Drawing.Point(132, 255);
            this.txtDayNight.Name = "txtDayNight";
            this.txtDayNight.Size = new System.Drawing.Size(241, 22);
            this.txtDayNight.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 16);
            this.label7.TabIndex = 31;
            this.label7.Text = "Gün Gece:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 305);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 16);
            this.label8.TabIndex = 37;
            this.label8.Text = "Rehber:";
            // 
            // cmbGuide
            // 
            this.cmbGuide.FormattingEnabled = true;
            this.cmbGuide.Location = new System.Drawing.Point(132, 302);
            this.cmbGuide.Name = "cmbGuide";
            this.cmbGuide.Size = new System.Drawing.Size(241, 24);
            this.cmbGuide.TabIndex = 39;
            // 
            // nudCpacity
            // 
            this.nudCpacity.Location = new System.Drawing.Point(132, 165);
            this.nudCpacity.Name = "nudCpacity";
            this.nudCpacity.Size = new System.Drawing.Size(241, 22);
            this.nudCpacity.TabIndex = 40;
            // 
            // FrmLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 606);
            this.Controls.Add(this.nudCpacity);
            this.Controls.Add(this.cmbGuide);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDayNight);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.label1);
            this.Name = "FrmLocation";
            this.Text = "FrmLocation";
            this.Load += new System.EventHandler(this.FrmLocation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCpacity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDayNight;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbGuide;
        private System.Windows.Forms.NumericUpDown nudCpacity;
    }
}