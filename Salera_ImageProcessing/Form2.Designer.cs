namespace Salera_ImageProcessing
{
    partial class Form2
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.opencam = new System.Windows.Forms.Button();
            this.closecam = new System.Windows.Forms.Button();
            this.capture = new System.Windows.Forms.Button();
            this.capturert = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openForegroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openBackgroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subtraction = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(22, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(350, 350);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Location = new System.Drawing.Point(22, 411);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(350, 350);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox4.Location = new System.Drawing.Point(559, 55);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(216, 186);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox3.Location = new System.Drawing.Point(425, 247);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(350, 350);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // opencam
            // 
            this.opencam.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.opencam.ForeColor = System.Drawing.SystemColors.Control;
            this.opencam.Location = new System.Drawing.Point(436, 57);
            this.opencam.Name = "opencam";
            this.opencam.Size = new System.Drawing.Size(117, 45);
            this.opencam.TabIndex = 6;
            this.opencam.Text = "Open WebCam";
            this.opencam.UseVisualStyleBackColor = false;
            this.opencam.Click += new System.EventHandler(this.opencam_Click);
            // 
            // closecam
            // 
            this.closecam.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.closecam.ForeColor = System.Drawing.SystemColors.Control;
            this.closecam.Location = new System.Drawing.Point(436, 100);
            this.closecam.Name = "closecam";
            this.closecam.Size = new System.Drawing.Size(117, 45);
            this.closecam.TabIndex = 7;
            this.closecam.Text = "Close WebCam";
            this.closecam.UseVisualStyleBackColor = false;
            this.closecam.Click += new System.EventHandler(this.closecam_Click);
            // 
            // capture
            // 
            this.capture.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.capture.ForeColor = System.Drawing.SystemColors.Control;
            this.capture.Location = new System.Drawing.Point(437, 143);
            this.capture.Name = "capture";
            this.capture.Size = new System.Drawing.Size(117, 45);
            this.capture.TabIndex = 8;
            this.capture.Text = "Capture";
            this.capture.UseVisualStyleBackColor = false;
            this.capture.Click += new System.EventHandler(this.capture_Click);
            // 
            // capturert
            // 
            this.capturert.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.capturert.ForeColor = System.Drawing.SystemColors.Control;
            this.capturert.Location = new System.Drawing.Point(412, 187);
            this.capturert.Name = "capturert";
            this.capturert.Size = new System.Drawing.Size(141, 45);
            this.capturert.TabIndex = 9;
            this.capturert.Text = "Capture (Real-time)";
            this.capturert.UseVisualStyleBackColor = false;
            this.capturert.Click += new System.EventHandler(this.capturert_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(801, 30);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openForegroundToolStripMenuItem,
            this.openBackgroundToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 26);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openForegroundToolStripMenuItem
            // 
            this.openForegroundToolStripMenuItem.Name = "openForegroundToolStripMenuItem";
            this.openForegroundToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.openForegroundToolStripMenuItem.Text = "Open Foreground";
            this.openForegroundToolStripMenuItem.Click += new System.EventHandler(this.openForegroundToolStripMenuItem_Click);
            // 
            // openBackgroundToolStripMenuItem
            // 
            this.openBackgroundToolStripMenuItem.Name = "openBackgroundToolStripMenuItem";
            this.openBackgroundToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.openBackgroundToolStripMenuItem.Text = "Open Background";
            this.openBackgroundToolStripMenuItem.Click += new System.EventHandler(this.openBackgroundToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // subtraction
            // 
            this.subtraction.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.subtraction.ForeColor = System.Drawing.SystemColors.Control;
            this.subtraction.Location = new System.Drawing.Point(425, 615);
            this.subtraction.Name = "subtraction";
            this.subtraction.Size = new System.Drawing.Size(141, 45);
            this.subtraction.TabIndex = 11;
            this.subtraction.Text = "Subtract";
            this.subtraction.UseVisualStyleBackColor = false;
            this.subtraction.Click += new System.EventHandler(this.subtraction_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            this.openFileDialog2.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog2_FileOk);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // timer1
            // 
            this.timer1.Interval = 33;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 33;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(727, 742);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "Back";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 776);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.subtraction);
            this.Controls.Add(this.capturert);
            this.Controls.Add(this.capture);
            this.Controls.Add(this.closecam);
            this.Controls.Add(this.opencam);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Subtraction";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button opencam;
        private System.Windows.Forms.Button closecam;
        private System.Windows.Forms.Button capture;
        private System.Windows.Forms.Button capturert;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openForegroundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openBackgroundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.Button subtraction;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label1;
    }
}