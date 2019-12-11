namespace WrpMp3Interface
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
            this.btnSelectMp3Wrap = new System.Windows.Forms.Button();
            this.txtmp3wrap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btninput = new System.Windows.Forms.Button();
            this.txtinput = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnoutput = new System.Windows.Forms.Button();
            this.txtoutput = new System.Windows.Forms.TextBox();
            this.btnHoer = new System.Windows.Forms.Button();
            this.btnAlbum = new System.Windows.Forms.Button();
            this.btnNumber = new System.Windows.Forms.Button();
            this.txtnostart = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtlog = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSelectMp3Wrap
            // 
            this.btnSelectMp3Wrap.Location = new System.Drawing.Point(197, 68);
            this.btnSelectMp3Wrap.Name = "btnSelectMp3Wrap";
            this.btnSelectMp3Wrap.Size = new System.Drawing.Size(190, 23);
            this.btnSelectMp3Wrap.TabIndex = 0;
            this.btnSelectMp3Wrap.Text = "Select mp3wrap.exe";
            this.btnSelectMp3Wrap.UseVisualStyleBackColor = true;
            this.btnSelectMp3Wrap.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtmp3wrap
            // 
            this.txtmp3wrap.Location = new System.Drawing.Point(24, 42);
            this.txtmp3wrap.Name = "txtmp3wrap";
            this.txtmp3wrap.Size = new System.Drawing.Size(560, 20);
            this.txtmp3wrap.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mp3Warp.Exe location";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnSelectMp3Wrap);
            this.groupBox1.Controls.Add(this.txtmp3wrap);
            this.groupBox1.Location = new System.Drawing.Point(23, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(605, 113);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select mp3wrap.exe directory";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btninput);
            this.groupBox2.Controls.Add(this.txtinput);
            this.groupBox2.Location = new System.Drawing.Point(23, 131);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(605, 85);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Input Folder";
            // 
            // btninput
            // 
            this.btninput.Location = new System.Drawing.Point(197, 45);
            this.btninput.Name = "btninput";
            this.btninput.Size = new System.Drawing.Size(190, 23);
            this.btninput.TabIndex = 3;
            this.btninput.Text = "Select input Folder";
            this.btninput.UseVisualStyleBackColor = true;
            this.btninput.Click += new System.EventHandler(this.btninput_Click);
            // 
            // txtinput
            // 
            this.txtinput.Location = new System.Drawing.Point(24, 19);
            this.txtinput.Name = "txtinput";
            this.txtinput.Size = new System.Drawing.Size(560, 20);
            this.txtinput.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnoutput);
            this.groupBox3.Controls.Add(this.txtoutput);
            this.groupBox3.Location = new System.Drawing.Point(23, 222);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(605, 85);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Output Folder";
            // 
            // btnoutput
            // 
            this.btnoutput.Location = new System.Drawing.Point(197, 46);
            this.btnoutput.Name = "btnoutput";
            this.btnoutput.Size = new System.Drawing.Size(190, 23);
            this.btnoutput.TabIndex = 5;
            this.btnoutput.Text = "Select output folder";
            this.btnoutput.UseVisualStyleBackColor = true;
            this.btnoutput.Click += new System.EventHandler(this.btnoutput_Click);
            // 
            // txtoutput
            // 
            this.txtoutput.Location = new System.Drawing.Point(24, 20);
            this.txtoutput.Name = "txtoutput";
            this.txtoutput.Size = new System.Drawing.Size(560, 20);
            this.txtoutput.TabIndex = 6;
            // 
            // btnHoer
            // 
            this.btnHoer.Location = new System.Drawing.Point(23, 345);
            this.btnHoer.Name = "btnHoer";
            this.btnHoer.Size = new System.Drawing.Size(605, 56);
            this.btnHoer.TabIndex = 6;
            this.btnHoer.Text = "Merge all mp3s with mp3wrap per subdir (Scan subdirectories of input folder for m" +
    "p3s) and copy to output dir (hörspielmodus)";
            this.btnHoer.UseVisualStyleBackColor = true;
            this.btnHoer.Click += new System.EventHandler(this.btnHoer_Click);
            // 
            // btnAlbum
            // 
            this.btnAlbum.Location = new System.Drawing.Point(23, 416);
            this.btnAlbum.Name = "btnAlbum";
            this.btnAlbum.Size = new System.Drawing.Size(605, 53);
            this.btnAlbum.TabIndex = 7;
            this.btnAlbum.Text = "Scan subdirectories of input folder for mp3 and number found files in directories" +
    ". Then copy to output dir (albummodus)";
            this.btnAlbum.UseVisualStyleBackColor = true;
            this.btnAlbum.Click += new System.EventHandler(this.btnAlbum_Click);
            // 
            // btnNumber
            // 
            this.btnNumber.Location = new System.Drawing.Point(23, 485);
            this.btnNumber.Name = "btnNumber";
            this.btnNumber.Size = new System.Drawing.Size(424, 56);
            this.btnNumber.TabIndex = 8;
            this.btnNumber.Text = "Number directories in output directory starting with (input directory not used!) " +
    "in Tonunio-Format (01 - 99)";
            this.btnNumber.UseVisualStyleBackColor = true;
            this.btnNumber.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // txtnostart
            // 
            this.txtnostart.Location = new System.Drawing.Point(548, 504);
            this.txtnostart.Name = "txtnostart";
            this.txtnostart.Size = new System.Drawing.Size(80, 20);
            this.txtnostart.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(453, 506);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Start with number";
            // 
            // txtlog
            // 
            this.txtlog.Location = new System.Drawing.Point(23, 547);
            this.txtlog.Multiline = true;
            this.txtlog.Name = "txtlog";
            this.txtlog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtlog.Size = new System.Drawing.Size(617, 64);
            this.txtlog.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 643);
            this.Controls.Add(this.txtlog);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnostart);
            this.Controls.Add(this.btnNumber);
            this.Controls.Add(this.btnAlbum);
            this.Controls.Add(this.btnHoer);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "mp3wrap interface for tonunio 0.5 by CM";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelectMp3Wrap;
        private System.Windows.Forms.TextBox txtmp3wrap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btninput;
        private System.Windows.Forms.TextBox txtinput;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnoutput;
        private System.Windows.Forms.TextBox txtoutput;
        private System.Windows.Forms.Button btnHoer;
        private System.Windows.Forms.Button btnAlbum;
        private System.Windows.Forms.Button btnNumber;
        private System.Windows.Forms.TextBox txtnostart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtlog;
    }
}

