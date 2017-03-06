namespace RaspiRCCar
{
    partial class FMain
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
            this.PBTriggerL = new System.Windows.Forms.ProgressBar();
            this.PBTriggerR = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PBPadLX = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.PBPadRX = new System.Windows.Forms.ProgressBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Timer_Controller = new System.Windows.Forms.Timer(this.components);
            this.Timer_Network = new System.Windows.Forms.Timer(this.components);
            this.PLeftBG = new System.Windows.Forms.Panel();
            this.PLeftDot = new System.Windows.Forms.Panel();
            this.PRightBG = new System.Windows.Forms.Panel();
            this.PRightDot = new System.Windows.Forms.Panel();
            this.PBPadLY = new System.Windows.Forms.ProgressBar();
            this.PBPadRY = new System.Windows.Forms.ProgressBar();
            this.BClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.PLeftBG.SuspendLayout();
            this.PRightBG.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Image = global::RaspiRCCar.Properties.Resources.Deviantart_please_stand_by_by_gxmew;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(872, 504);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // PBTriggerL
            // 
            this.PBTriggerL.Location = new System.Drawing.Point(6, 19);
            this.PBTriggerL.Name = "PBTriggerL";
            this.PBTriggerL.Size = new System.Drawing.Size(181, 23);
            this.PBTriggerL.Step = 1;
            this.PBTriggerL.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.PBTriggerL.TabIndex = 1;
            // 
            // PBTriggerR
            // 
            this.PBTriggerR.Location = new System.Drawing.Point(6, 48);
            this.PBTriggerR.Name = "PBTriggerR";
            this.PBTriggerR.Size = new System.Drawing.Size(181, 23);
            this.PBTriggerR.Step = 1;
            this.PBTriggerR.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.PBTriggerR.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Left";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.PBTriggerL);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.PBTriggerR);
            this.groupBox1.Location = new System.Drawing.Point(12, 522);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 84);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Trigger";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Right";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.PBPadRY);
            this.groupBox2.Controls.Add(this.PBPadLY);
            this.groupBox2.Controls.Add(this.PLeftBG);
            this.groupBox2.Controls.Add(this.PRightBG);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.PBPadLX);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.PBPadRX);
            this.groupBox2.Location = new System.Drawing.Point(630, 522);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(254, 213);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Analog Pad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Right";
            // 
            // PBPadLX
            // 
            this.PBPadLX.Location = new System.Drawing.Point(6, 149);
            this.PBPadLX.MarqueeAnimationSpeed = 0;
            this.PBPadLX.Maximum = 200;
            this.PBPadLX.Name = "PBPadLX";
            this.PBPadLX.Size = new System.Drawing.Size(100, 23);
            this.PBPadLX.Step = 1;
            this.PBPadLX.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.PBPadLX.TabIndex = 1;
            this.PBPadLX.Value = 100;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Left";
            // 
            // PBPadRX
            // 
            this.PBPadRX.Location = new System.Drawing.Point(148, 149);
            this.PBPadRX.Maximum = 200;
            this.PBPadRX.Name = "PBPadRX";
            this.PBPadRX.Size = new System.Drawing.Size(100, 23);
            this.PBPadRX.Step = 1;
            this.PBPadRX.TabIndex = 2;
            this.PBPadRX.Value = 100;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(272, 522);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(352, 213);
            this.textBox1.TabIndex = 8;
            // 
            // Timer_Controller
            // 
            this.Timer_Controller.Enabled = true;
            this.Timer_Controller.Interval = 10;
            this.Timer_Controller.Tick += new System.EventHandler(this.Timer_Controller_Tick);
            // 
            // Timer_Network
            // 
            this.Timer_Network.Enabled = true;
            this.Timer_Network.Tick += new System.EventHandler(this.Timer_Network_Tick);
            // 
            // PLeftBG
            // 
            this.PLeftBG.BackColor = System.Drawing.Color.Blue;
            this.PLeftBG.Controls.Add(this.PLeftDot);
            this.PLeftBG.Location = new System.Drawing.Point(6, 43);
            this.PLeftBG.Name = "PLeftBG";
            this.PLeftBG.Size = new System.Drawing.Size(100, 100);
            this.PLeftBG.TabIndex = 9;
            // 
            // PLeftDot
            // 
            this.PLeftDot.BackColor = System.Drawing.Color.Red;
            this.PLeftDot.Location = new System.Drawing.Point(47, 47);
            this.PLeftDot.Name = "PLeftDot";
            this.PLeftDot.Size = new System.Drawing.Size(6, 6);
            this.PLeftDot.TabIndex = 10;
            // 
            // PRightBG
            // 
            this.PRightBG.BackColor = System.Drawing.Color.Blue;
            this.PRightBG.Controls.Add(this.PRightDot);
            this.PRightBG.Location = new System.Drawing.Point(148, 43);
            this.PRightBG.Name = "PRightBG";
            this.PRightBG.Size = new System.Drawing.Size(100, 100);
            this.PRightBG.TabIndex = 11;
            // 
            // PRightDot
            // 
            this.PRightDot.BackColor = System.Drawing.Color.Red;
            this.PRightDot.Location = new System.Drawing.Point(47, 47);
            this.PRightDot.Name = "PRightDot";
            this.PRightDot.Size = new System.Drawing.Size(6, 6);
            this.PRightDot.TabIndex = 10;
            // 
            // PBPadLY
            // 
            this.PBPadLY.Location = new System.Drawing.Point(6, 178);
            this.PBPadLY.MarqueeAnimationSpeed = 0;
            this.PBPadLY.Maximum = 200;
            this.PBPadLY.Name = "PBPadLY";
            this.PBPadLY.Size = new System.Drawing.Size(100, 23);
            this.PBPadLY.Step = 1;
            this.PBPadLY.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.PBPadLY.TabIndex = 12;
            this.PBPadLY.Value = 100;
            // 
            // PBPadRY
            // 
            this.PBPadRY.Location = new System.Drawing.Point(148, 178);
            this.PBPadRY.MarqueeAnimationSpeed = 0;
            this.PBPadRY.Maximum = 200;
            this.PBPadRY.Name = "PBPadRY";
            this.PBPadRY.Size = new System.Drawing.Size(100, 23);
            this.PBPadRY.Step = 1;
            this.PBPadRY.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.PBPadRY.TabIndex = 13;
            this.PBPadRY.Value = 100;
            // 
            // BClose
            // 
            this.BClose.Location = new System.Drawing.Point(12, 712);
            this.BClose.Name = "BClose";
            this.BClose.Size = new System.Drawing.Size(254, 23);
            this.BClose.TabIndex = 9;
            this.BClose.Text = "Close";
            this.BClose.UseVisualStyleBackColor = true;
            this.BClose.Click += new System.EventHandler(this.BClose_Click);
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 747);
            this.Controls.Add(this.BClose);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Raspberry Pi Car";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FMain_FormClosing);
            this.Load += new System.EventHandler(this.FMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.PLeftBG.ResumeLayout(false);
            this.PRightBG.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar PBTriggerL;
        private System.Windows.Forms.ProgressBar PBTriggerR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar PBPadLX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar PBPadRX;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer Timer_Controller;
        private System.Windows.Forms.Timer Timer_Network;
        private System.Windows.Forms.Panel PLeftBG;
        private System.Windows.Forms.Panel PLeftDot;
        private System.Windows.Forms.Panel PRightBG;
        private System.Windows.Forms.Panel PRightDot;
        private System.Windows.Forms.ProgressBar PBPadRY;
        private System.Windows.Forms.ProgressBar PBPadLY;
        private System.Windows.Forms.Button BClose;
    }
}