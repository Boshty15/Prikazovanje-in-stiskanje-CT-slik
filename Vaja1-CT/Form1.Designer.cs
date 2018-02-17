namespace Vaja1_CT
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.bttLUT = new System.Windows.Forms.Button();
            this.listView2 = new System.Windows.Forms.ListView();
            this.bttCT = new System.Windows.Forms.Button();
            this.bttStiskanje = new System.Windows.Forms.Button();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBttDekod = new System.Windows.Forms.Button();
            this.bttStiskanjeVec = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(482, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(512, 512);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(216, 903);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(234, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(326, 41);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 4;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // bttLUT
            // 
            this.bttLUT.Location = new System.Drawing.Point(234, 122);
            this.bttLUT.Name = "bttLUT";
            this.bttLUT.Size = new System.Drawing.Size(167, 23);
            this.bttLUT.TabIndex = 5;
            this.bttLUT.Text = "Load LUT ";
            this.bttLUT.UseVisualStyleBackColor = true;
            this.bttLUT.Click += new System.EventHandler(this.bttLUT_Click);
            // 
            // listView2
            // 
            this.listView2.Location = new System.Drawing.Point(1032, 9);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(229, 605);
            this.listView2.TabIndex = 6;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            this.listView2.Click += new System.EventHandler(this.listView2_Click);
            // 
            // bttCT
            // 
            this.bttCT.Location = new System.Drawing.Point(234, 93);
            this.bttCT.Name = "bttCT";
            this.bttCT.Size = new System.Drawing.Size(167, 23);
            this.bttCT.TabIndex = 7;
            this.bttCT.Text = "Load CT";
            this.bttCT.UseVisualStyleBackColor = true;
            this.bttCT.Click += new System.EventHandler(this.bttCT_Click);
            // 
            // bttStiskanje
            // 
            this.bttStiskanje.Location = new System.Drawing.Point(234, 185);
            this.bttStiskanje.Name = "bttStiskanje";
            this.bttStiskanje.Size = new System.Drawing.Size(167, 23);
            this.bttStiskanje.TabIndex = 8;
            this.bttStiskanje.Text = "Stiskanje";
            this.bttStiskanje.UseVisualStyleBackColor = true;
            this.bttStiskanje.Click += new System.EventHandler(this.bttStiskanje_Click);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(234, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Razmerje stiskanja: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(342, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "0";
            // 
            // txtBttDekod
            // 
            this.txtBttDekod.Location = new System.Drawing.Point(234, 281);
            this.txtBttDekod.Name = "txtBttDekod";
            this.txtBttDekod.Size = new System.Drawing.Size(167, 23);
            this.txtBttDekod.TabIndex = 14;
            this.txtBttDekod.Text = "Dekodiranje";
            this.txtBttDekod.UseVisualStyleBackColor = true;
            this.txtBttDekod.Click += new System.EventHandler(this.txtBttDekod_Click);
            // 
            // bttStiskanjeVec
            // 
            this.bttStiskanjeVec.Location = new System.Drawing.Point(237, 358);
            this.bttStiskanjeVec.Name = "bttStiskanjeVec";
            this.bttStiskanjeVec.Size = new System.Drawing.Size(164, 23);
            this.bttStiskanjeVec.TabIndex = 15;
            this.bttStiskanjeVec.Text = "Stiskanje Več Slik";
            this.bttStiskanjeVec.UseVisualStyleBackColor = true;
            this.bttStiskanjeVec.Click += new System.EventHandler(this.bttStiskanjeVec_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1598, 920);
            this.Controls.Add(this.bttStiskanjeVec);
            this.Controls.Add(this.txtBttDekod);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bttStiskanje);
            this.Controls.Add(this.bttCT);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.bttLUT);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button bttLUT;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Button bttCT;
        private System.Windows.Forms.Button bttStiskanje;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button txtBttDekod;
        private System.Windows.Forms.Button bttStiskanjeVec;
    }
}

