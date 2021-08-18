namespace MyMp3Player
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
        	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
        	this.panel1 = new System.Windows.Forms.Panel();
        	this.label1 = new System.Windows.Forms.Label();
        	this.exitBtn = new System.Windows.Forms.Button();
        	this.pictureBox1 = new System.Windows.Forms.PictureBox();
        	this.button1 = new System.Windows.Forms.Button();
        	this.prevBtn = new System.Windows.Forms.Button();
        	this.playBtn = new System.Windows.Forms.Button();
        	this.stopBtn = new System.Windows.Forms.Button();
        	this.nextBtn = new System.Windows.Forms.Button();
        	this.audioLbx = new System.Windows.Forms.ListBox();
        	this.panel1.SuspendLayout();
        	((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
        	this.SuspendLayout();
        	// 
        	// panel1
        	// 
        	this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
        	this.panel1.Controls.Add(this.label1);
        	this.panel1.Controls.Add(this.exitBtn);
        	this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
        	this.panel1.Location = new System.Drawing.Point(0, 0);
        	this.panel1.Name = "panel1";
        	this.panel1.Size = new System.Drawing.Size(378, 41);
        	this.panel1.TabIndex = 0;
        	// 
        	// label1
        	// 
        	this.label1.AutoSize = true;
        	this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label1.ForeColor = System.Drawing.Color.White;
        	this.label1.Location = new System.Drawing.Point(25, 9);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(153, 24);
        	this.label1.TabIndex = 1;
        	this.label1.Text = "C# Ui Academy";
        	// 
        	// exitBtn
        	// 
        	this.exitBtn.Dock = System.Windows.Forms.DockStyle.Right;
        	this.exitBtn.FlatAppearance.BorderSize = 0;
        	this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        	this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.exitBtn.ForeColor = System.Drawing.Color.White;
        	this.exitBtn.Location = new System.Drawing.Point(336, 0);
        	this.exitBtn.Name = "exitBtn";
        	this.exitBtn.Size = new System.Drawing.Size(42, 41);
        	this.exitBtn.TabIndex = 3;
        	this.exitBtn.Text = "X";
        	this.exitBtn.UseVisualStyleBackColor = true;
        	this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
        	// 
        	// pictureBox1
        	// 
        	this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
        	this.pictureBox1.Location = new System.Drawing.Point(79, 47);
        	this.pictureBox1.Name = "pictureBox1";
        	this.pictureBox1.Size = new System.Drawing.Size(232, 221);
        	this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
        	this.pictureBox1.TabIndex = 2;
        	this.pictureBox1.TabStop = false;
        	// 
        	// button1
        	// 
        	this.button1.FlatAppearance.BorderSize = 0;
        	this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        	this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
        	this.button1.Location = new System.Drawing.Point(26, 287);
        	this.button1.Name = "button1";
        	this.button1.Size = new System.Drawing.Size(61, 39);
        	this.button1.TabIndex = 3;
        	this.button1.UseVisualStyleBackColor = true;
        	this.button1.Click += new System.EventHandler(this.button1_Click);
        	// 
        	// prevBtn
        	// 
        	this.prevBtn.FlatAppearance.BorderSize = 0;
        	this.prevBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        	this.prevBtn.Image = ((System.Drawing.Image)(resources.GetObject("prevBtn.Image")));
        	this.prevBtn.Location = new System.Drawing.Point(93, 287);
        	this.prevBtn.Name = "prevBtn";
        	this.prevBtn.Size = new System.Drawing.Size(61, 39);
        	this.prevBtn.TabIndex = 3;
        	this.prevBtn.UseVisualStyleBackColor = true;
        	this.prevBtn.Click += new System.EventHandler(this.prevBtn_Click);
        	// 
        	// playBtn
        	// 
        	this.playBtn.FlatAppearance.BorderSize = 0;
        	this.playBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        	this.playBtn.Image = ((System.Drawing.Image)(resources.GetObject("playBtn.Image")));
        	this.playBtn.Location = new System.Drawing.Point(160, 287);
        	this.playBtn.Name = "playBtn";
        	this.playBtn.Size = new System.Drawing.Size(61, 39);
        	this.playBtn.TabIndex = 3;
        	this.playBtn.UseVisualStyleBackColor = true;
        	this.playBtn.Click += new System.EventHandler(this.playBtn_Click);
        	// 
        	// stopBtn
        	// 
        	this.stopBtn.FlatAppearance.BorderSize = 0;
        	this.stopBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        	this.stopBtn.Image = ((System.Drawing.Image)(resources.GetObject("stopBtn.Image")));
        	this.stopBtn.Location = new System.Drawing.Point(294, 287);
        	this.stopBtn.Name = "stopBtn";
        	this.stopBtn.Size = new System.Drawing.Size(61, 39);
        	this.stopBtn.TabIndex = 3;
        	this.stopBtn.UseVisualStyleBackColor = true;
        	this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
        	// 
        	// nextBtn
        	// 
        	this.nextBtn.FlatAppearance.BorderSize = 0;
        	this.nextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        	this.nextBtn.Image = ((System.Drawing.Image)(resources.GetObject("nextBtn.Image")));
        	this.nextBtn.Location = new System.Drawing.Point(227, 287);
        	this.nextBtn.Name = "nextBtn";
        	this.nextBtn.Size = new System.Drawing.Size(61, 39);
        	this.nextBtn.TabIndex = 3;
        	this.nextBtn.UseVisualStyleBackColor = true;
        	this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
        	// 
        	// audioLbx
        	// 
        	this.audioLbx.FormattingEnabled = true;
        	this.audioLbx.ItemHeight = 20;
        	this.audioLbx.Location = new System.Drawing.Point(12, 332);
        	this.audioLbx.Name = "audioLbx";
        	this.audioLbx.Size = new System.Drawing.Size(354, 324);
        	this.audioLbx.TabIndex = 4;
        	this.audioLbx.SelectedIndexChanged += new System.EventHandler(this.AudioLbxSelectedIndexChanged);
        	// 
        	// Form1
        	// 
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
        	this.AutoSize = true;
        	this.ClientSize = new System.Drawing.Size(378, 667);
        	this.Controls.Add(this.audioLbx);
        	this.Controls.Add(this.nextBtn);
        	this.Controls.Add(this.stopBtn);
        	this.Controls.Add(this.playBtn);
        	this.Controls.Add(this.prevBtn);
        	this.Controls.Add(this.button1);
        	this.Controls.Add(this.pictureBox1);
        	this.Controls.Add(this.panel1);
        	this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        	this.Name = "Form1";
        	this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        	this.Text = "Form1";
        	this.panel1.ResumeLayout(false);
        	this.panel1.PerformLayout();
        	((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
        	this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button prevBtn;
        private System.Windows.Forms.Button playBtn;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.ListBox audioLbx;
    }
}

