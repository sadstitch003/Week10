namespace PraktikumWEek8
{
    partial class formHasilPertandingan
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
            this.cbHomeTeam = new System.Windows.Forms.ComboBox();
            this.cbAwayTeam = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblHomeCaptain = new System.Windows.Forms.Label();
            this.lblHomeManager = new System.Windows.Forms.Label();
            this.lblAwayCaptain = new System.Windows.Forms.Label();
            this.lblAwayManager = new System.Windows.Forms.Label();
            this.lblStadiumCapacity = new System.Windows.Forms.Label();
            this.lblStadiumName = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblAwayAssMng = new System.Windows.Forms.Label();
            this.lblHomeAssMng = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dgvDMatch = new System.Windows.Forms.DataGridView();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblSkor = new System.Windows.Forms.Label();
            this.lblTanggal = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDMatch)).BeginInit();
            this.SuspendLayout();
            // 
            // cbHomeTeam
            // 
            this.cbHomeTeam.FormattingEnabled = true;
            this.cbHomeTeam.Location = new System.Drawing.Point(44, 19);
            this.cbHomeTeam.Margin = new System.Windows.Forms.Padding(2);
            this.cbHomeTeam.Name = "cbHomeTeam";
            this.cbHomeTeam.Size = new System.Drawing.Size(169, 21);
            this.cbHomeTeam.TabIndex = 0;
            this.cbHomeTeam.SelectedIndexChanged += new System.EventHandler(this.cbHomeTeam_SelectedIndexChanged);
            // 
            // cbAwayTeam
            // 
            this.cbAwayTeam.FormattingEnabled = true;
            this.cbAwayTeam.Location = new System.Drawing.Point(295, 19);
            this.cbAwayTeam.Margin = new System.Windows.Forms.Padding(2);
            this.cbAwayTeam.Name = "cbAwayTeam";
            this.cbAwayTeam.Size = new System.Drawing.Size(169, 21);
            this.cbAwayTeam.TabIndex = 1;
            this.cbAwayTeam.SelectedIndexChanged += new System.EventHandler(this.cbAwayTeam_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(244, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "VS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Manager  :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Captain     :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(292, 82);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Captain     :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(292, 48);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Manager  :";
            // 
            // lblHomeCaptain
            // 
            this.lblHomeCaptain.AutoSize = true;
            this.lblHomeCaptain.Location = new System.Drawing.Point(98, 82);
            this.lblHomeCaptain.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHomeCaptain.Name = "lblHomeCaptain";
            this.lblHomeCaptain.Size = new System.Drawing.Size(86, 13);
            this.lblHomeCaptain.TabIndex = 8;
            this.lblHomeCaptain.Text = "- Captain Name -";
            // 
            // lblHomeManager
            // 
            this.lblHomeManager.AutoSize = true;
            this.lblHomeManager.Location = new System.Drawing.Point(98, 48);
            this.lblHomeManager.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHomeManager.Name = "lblHomeManager";
            this.lblHomeManager.Size = new System.Drawing.Size(92, 13);
            this.lblHomeManager.TabIndex = 7;
            this.lblHomeManager.Text = "- Manager Name -";
            // 
            // lblAwayCaptain
            // 
            this.lblAwayCaptain.AutoSize = true;
            this.lblAwayCaptain.Location = new System.Drawing.Point(350, 82);
            this.lblAwayCaptain.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAwayCaptain.Name = "lblAwayCaptain";
            this.lblAwayCaptain.Size = new System.Drawing.Size(86, 13);
            this.lblAwayCaptain.TabIndex = 10;
            this.lblAwayCaptain.Text = "- Captain Name -";
            // 
            // lblAwayManager
            // 
            this.lblAwayManager.AutoSize = true;
            this.lblAwayManager.Location = new System.Drawing.Point(350, 48);
            this.lblAwayManager.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAwayManager.Name = "lblAwayManager";
            this.lblAwayManager.Size = new System.Drawing.Size(92, 13);
            this.lblAwayManager.TabIndex = 9;
            this.lblAwayManager.Text = "- Manager Name -";
            // 
            // lblStadiumCapacity
            // 
            this.lblStadiumCapacity.AutoSize = true;
            this.lblStadiumCapacity.Location = new System.Drawing.Point(228, 127);
            this.lblStadiumCapacity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStadiumCapacity.Name = "lblStadiumCapacity";
            this.lblStadiumCapacity.Size = new System.Drawing.Size(101, 13);
            this.lblStadiumCapacity.TabIndex = 14;
            this.lblStadiumCapacity.Text = "- Stadium Capacity -";
            // 
            // lblStadiumName
            // 
            this.lblStadiumName.AutoSize = true;
            this.lblStadiumName.Location = new System.Drawing.Point(228, 110);
            this.lblStadiumName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStadiumName.Name = "lblStadiumName";
            this.lblStadiumName.Size = new System.Drawing.Size(88, 13);
            this.lblStadiumName.TabIndex = 13;
            this.lblStadiumName.Text = "- Stadium Name -";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(173, 127);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Capacity :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(173, 110);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Stadium  :";
            // 
            // lblAwayAssMng
            // 
            this.lblAwayAssMng.AutoSize = true;
            this.lblAwayAssMng.Location = new System.Drawing.Point(350, 65);
            this.lblAwayAssMng.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAwayAssMng.Name = "lblAwayAssMng";
            this.lblAwayAssMng.Size = new System.Drawing.Size(91, 13);
            this.lblAwayAssMng.TabIndex = 18;
            this.lblAwayAssMng.Text = "- Ass Mng Name -";
            // 
            // lblHomeAssMng
            // 
            this.lblHomeAssMng.AutoSize = true;
            this.lblHomeAssMng.Location = new System.Drawing.Point(98, 65);
            this.lblHomeAssMng.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHomeAssMng.Name = "lblHomeAssMng";
            this.lblHomeAssMng.Size = new System.Drawing.Size(91, 13);
            this.lblHomeAssMng.TabIndex = 17;
            this.lblHomeAssMng.Text = "- Ass Mng Name -";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(292, 65);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "AssMng    :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(41, 65);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "AssMng    :";
            // 
            // dgvDMatch
            // 
            this.dgvDMatch.AllowUserToAddRows = false;
            this.dgvDMatch.AllowUserToDeleteRows = false;
            this.dgvDMatch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDMatch.Location = new System.Drawing.Point(44, 225);
            this.dgvDMatch.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDMatch.Name = "dgvDMatch";
            this.dgvDMatch.ReadOnly = true;
            this.dgvDMatch.RowHeadersWidth = 51;
            this.dgvDMatch.RowTemplate.Height = 24;
            this.dgvDMatch.Size = new System.Drawing.Size(419, 175);
            this.dgvDMatch.TabIndex = 20;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(211, 151);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(2);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(84, 22);
            this.btnCheck.TabIndex = 19;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lblSkor
            // 
            this.lblSkor.AutoSize = true;
            this.lblSkor.Location = new System.Drawing.Point(229, 199);
            this.lblSkor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSkor.Name = "lblSkor";
            this.lblSkor.Size = new System.Drawing.Size(41, 13);
            this.lblSkor.TabIndex = 24;
            this.lblSkor.Text = "- Skor -";
            // 
            // lblTanggal
            // 
            this.lblTanggal.AutoSize = true;
            this.lblTanggal.Location = new System.Drawing.Point(229, 183);
            this.lblTanggal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTanggal.Name = "lblTanggal";
            this.lblTanggal.Size = new System.Drawing.Size(58, 13);
            this.lblTanggal.TabIndex = 23;
            this.lblTanggal.Text = "- Tanggal -";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(175, 199);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Skor         :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(173, 183);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 13);
            this.label13.TabIndex = 21;
            this.label13.Text = "Tanggal  :";
            // 
            // formHasilPertandingan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 430);
            this.Controls.Add(this.lblSkor);
            this.Controls.Add(this.lblTanggal);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.dgvDMatch);
            this.Controls.Add(this.lblAwayAssMng);
            this.Controls.Add(this.lblHomeAssMng);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblStadiumCapacity);
            this.Controls.Add(this.lblStadiumName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblAwayCaptain);
            this.Controls.Add(this.lblAwayManager);
            this.Controls.Add(this.lblHomeCaptain);
            this.Controls.Add(this.lblHomeManager);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbAwayTeam);
            this.Controls.Add(this.cbHomeTeam);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "formHasilPertandingan";
            this.Text = "Hasil Pertandingan";
            this.Load += new System.EventHandler(this.formHasilPertandingan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDMatch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbHomeTeam;
        private System.Windows.Forms.ComboBox cbAwayTeam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblHomeCaptain;
        private System.Windows.Forms.Label lblHomeManager;
        private System.Windows.Forms.Label lblAwayCaptain;
        private System.Windows.Forms.Label lblAwayManager;
        private System.Windows.Forms.Label lblStadiumCapacity;
        private System.Windows.Forms.Label lblStadiumName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblAwayAssMng;
        private System.Windows.Forms.Label lblHomeAssMng;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgvDMatch;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblSkor;
        private System.Windows.Forms.Label lblTanggal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}

