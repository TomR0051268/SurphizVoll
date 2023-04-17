namespace SurphizVoll
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnCub = new System.Windows.Forms.Button();
            this.lblCubVol = new System.Windows.Forms.Label();
            this.lblCubSfc = new System.Windows.Forms.Label();
            this.txtCubH = new System.Windows.Forms.TextBox();
            this.lblCubH = new System.Windows.Forms.Label();
            this.txtCubW = new System.Windows.Forms.TextBox();
            this.lblCubW = new System.Windows.Forms.Label();
            this.txtCubL = new System.Windows.Forms.TextBox();
            this.lblCubL = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblSphSfc = new System.Windows.Forms.Label();
            this.lblSphVol = new System.Windows.Forms.Label();
            this.btnSph = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(499, 221);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnCub);
            this.tabPage1.Controls.Add(this.lblCubVol);
            this.tabPage1.Controls.Add(this.lblCubSfc);
            this.tabPage1.Controls.Add(this.txtCubH);
            this.tabPage1.Controls.Add(this.lblCubH);
            this.tabPage1.Controls.Add(this.txtCubW);
            this.tabPage1.Controls.Add(this.lblCubW);
            this.tabPage1.Controls.Add(this.txtCubL);
            this.tabPage1.Controls.Add(this.lblCubL);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(491, 195);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cuboid";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnCub
            // 
            this.btnCub.Location = new System.Drawing.Point(211, 151);
            this.btnCub.Name = "btnCub";
            this.btnCub.Size = new System.Drawing.Size(75, 23);
            this.btnCub.TabIndex = 8;
            this.btnCub.Text = "CALCUL888";
            this.btnCub.UseVisualStyleBackColor = true;
            this.btnCub.Click += new System.EventHandler(this.btnCub_Click);
            // 
            // lblCubVol
            // 
            this.lblCubVol.AutoSize = true;
            this.lblCubVol.Location = new System.Drawing.Point(287, 74);
            this.lblCubVol.Name = "lblCubVol";
            this.lblCubVol.Size = new System.Drawing.Size(55, 13);
            this.lblCubVol.TabIndex = 7;
            this.lblCubVol.Text = "VOLUME:";
            // 
            // lblCubSfc
            // 
            this.lblCubSfc.AutoSize = true;
            this.lblCubSfc.Location = new System.Drawing.Point(249, 36);
            this.lblCubSfc.Name = "lblCubSfc";
            this.lblCubSfc.Size = new System.Drawing.Size(92, 13);
            this.lblCubSfc.TabIndex = 6;
            this.lblCubSfc.Text = "SURFACE AREA:";
            // 
            // txtCubH
            // 
            this.txtCubH.Location = new System.Drawing.Point(72, 83);
            this.txtCubH.Name = "txtCubH";
            this.txtCubH.Size = new System.Drawing.Size(81, 20);
            this.txtCubH.TabIndex = 5;
            // 
            // lblCubH
            // 
            this.lblCubH.AutoSize = true;
            this.lblCubH.Location = new System.Drawing.Point(26, 86);
            this.lblCubH.Name = "lblCubH";
            this.lblCubH.Size = new System.Drawing.Size(38, 13);
            this.lblCubH.TabIndex = 4;
            this.lblCubH.Text = "Height";
            // 
            // txtCubW
            // 
            this.txtCubW.Location = new System.Drawing.Point(72, 51);
            this.txtCubW.Name = "txtCubW";
            this.txtCubW.Size = new System.Drawing.Size(81, 20);
            this.txtCubW.TabIndex = 3;
            // 
            // lblCubW
            // 
            this.lblCubW.AutoSize = true;
            this.lblCubW.Location = new System.Drawing.Point(26, 54);
            this.lblCubW.Name = "lblCubW";
            this.lblCubW.Size = new System.Drawing.Size(35, 13);
            this.lblCubW.TabIndex = 2;
            this.lblCubW.Text = "Width";
            // 
            // txtCubL
            // 
            this.txtCubL.Location = new System.Drawing.Point(72, 18);
            this.txtCubL.Name = "txtCubL";
            this.txtCubL.Size = new System.Drawing.Size(81, 20);
            this.txtCubL.TabIndex = 1;
            // 
            // lblCubL
            // 
            this.lblCubL.AutoSize = true;
            this.lblCubL.Location = new System.Drawing.Point(26, 21);
            this.lblCubL.Name = "lblCubL";
            this.lblCubL.Size = new System.Drawing.Size(40, 13);
            this.lblCubL.TabIndex = 0;
            this.lblCubL.Text = "Length";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnSph);
            this.tabPage2.Controls.Add(this.lblSphVol);
            this.tabPage2.Controls.Add(this.lblSphSfc);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(491, 195);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sphere";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(491, 195);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Cone";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Radius";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(128, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(82, 20);
            this.textBox1.TabIndex = 1;
            // 
            // lblSphSfc
            // 
            this.lblSphSfc.AutoSize = true;
            this.lblSphSfc.Location = new System.Drawing.Point(292, 33);
            this.lblSphSfc.Name = "lblSphSfc";
            this.lblSphSfc.Size = new System.Drawing.Size(92, 13);
            this.lblSphSfc.TabIndex = 2;
            this.lblSphSfc.Text = "SURFACE AREA:";
            // 
            // lblSphVol
            // 
            this.lblSphVol.AutoSize = true;
            this.lblSphVol.Location = new System.Drawing.Point(329, 69);
            this.lblSphVol.Name = "lblSphVol";
            this.lblSphVol.Size = new System.Drawing.Size(55, 13);
            this.lblSphVol.TabIndex = 3;
            this.lblSphVol.Text = "VOLUME:";
            // 
            // btnSph
            // 
            this.btnSph.Location = new System.Drawing.Point(214, 137);
            this.btnSph.Name = "btnSph";
            this.btnSph.Size = new System.Drawing.Size(75, 23);
            this.btnSph.TabIndex = 4;
            this.btnSph.Text = "CALCUL888";
            this.btnSph.UseVisualStyleBackColor = true;
            this.btnSph.Click += new System.EventHandler(this.btnSph_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 221);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label lblCubL;
        private System.Windows.Forms.Label lblCubVol;
        private System.Windows.Forms.Label lblCubSfc;
        private System.Windows.Forms.TextBox txtCubH;
        private System.Windows.Forms.Label lblCubH;
        private System.Windows.Forms.TextBox txtCubW;
        private System.Windows.Forms.Label lblCubW;
        private System.Windows.Forms.TextBox txtCubL;
        private System.Windows.Forms.Button btnCub;
        private System.Windows.Forms.Label lblSphSfc;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSph;
        private System.Windows.Forms.Label lblSphVol;
    }
}

