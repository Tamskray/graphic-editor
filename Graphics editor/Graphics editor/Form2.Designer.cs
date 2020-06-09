namespace Graphics_editor
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sepiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.artisticToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spikeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flashToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frozenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sujiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dramaticToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kakaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.redbar = new System.Windows.Forms.TrackBar();
            this.greenbar = new System.Windows.Forms.TrackBar();
            this.bluebar = new System.Windows.Forms.TrackBar();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.redvalue = new System.Windows.Forms.Label();
            this.greenvalue = new System.Windows.Forms.Label();
            this.bluevalue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.redbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bluebar)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(794, 517);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.filtresToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(798, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = global::Graphics_editor.Properties.Resources.openfile;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = global::Graphics_editor.Properties.Resources.save;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // filtresToolStripMenuItem
            // 
            this.filtresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noneToolStripMenuItem,
            this.sepiaToolStripMenuItem,
            this.artisticToolStripMenuItem,
            this.grayToolStripMenuItem,
            this.spikeToolStripMenuItem,
            this.flashToolStripMenuItem,
            this.frozenToolStripMenuItem,
            this.sujiToolStripMenuItem,
            this.dramaticToolStripMenuItem,
            this.kakaoToolStripMenuItem});
            this.filtresToolStripMenuItem.Name = "filtresToolStripMenuItem";
            this.filtresToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.filtresToolStripMenuItem.Text = "Filters";
            // 
            // noneToolStripMenuItem
            // 
            this.noneToolStripMenuItem.Name = "noneToolStripMenuItem";
            this.noneToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.noneToolStripMenuItem.Text = "None";
            this.noneToolStripMenuItem.Click += new System.EventHandler(this.noneToolStripMenuItem_Click);
            // 
            // sepiaToolStripMenuItem
            // 
            this.sepiaToolStripMenuItem.Name = "sepiaToolStripMenuItem";
            this.sepiaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sepiaToolStripMenuItem.Text = "Sepia";
            this.sepiaToolStripMenuItem.Click += new System.EventHandler(this.sepiaToolStripMenuItem_Click);
            // 
            // artisticToolStripMenuItem
            // 
            this.artisticToolStripMenuItem.Name = "artisticToolStripMenuItem";
            this.artisticToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.artisticToolStripMenuItem.Text = "Artistic";
            this.artisticToolStripMenuItem.Click += new System.EventHandler(this.artisticToolStripMenuItem_Click);
            // 
            // grayToolStripMenuItem
            // 
            this.grayToolStripMenuItem.Name = "grayToolStripMenuItem";
            this.grayToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.grayToolStripMenuItem.Text = "Gray";
            this.grayToolStripMenuItem.Click += new System.EventHandler(this.grayToolStripMenuItem_Click);
            // 
            // spikeToolStripMenuItem
            // 
            this.spikeToolStripMenuItem.Name = "spikeToolStripMenuItem";
            this.spikeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.spikeToolStripMenuItem.Text = "Spike";
            this.spikeToolStripMenuItem.Click += new System.EventHandler(this.spikeToolStripMenuItem_Click);
            // 
            // flashToolStripMenuItem
            // 
            this.flashToolStripMenuItem.Name = "flashToolStripMenuItem";
            this.flashToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.flashToolStripMenuItem.Text = "Flash";
            this.flashToolStripMenuItem.Click += new System.EventHandler(this.flashToolStripMenuItem_Click);
            // 
            // frozenToolStripMenuItem
            // 
            this.frozenToolStripMenuItem.Name = "frozenToolStripMenuItem";
            this.frozenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.frozenToolStripMenuItem.Text = "Frozen";
            this.frozenToolStripMenuItem.Click += new System.EventHandler(this.frozenToolStripMenuItem_Click);
            // 
            // sujiToolStripMenuItem
            // 
            this.sujiToolStripMenuItem.Name = "sujiToolStripMenuItem";
            this.sujiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sujiToolStripMenuItem.Text = "Suji";
            this.sujiToolStripMenuItem.Click += new System.EventHandler(this.sujiToolStripMenuItem_Click);
            // 
            // dramaticToolStripMenuItem
            // 
            this.dramaticToolStripMenuItem.Name = "dramaticToolStripMenuItem";
            this.dramaticToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dramaticToolStripMenuItem.Text = "Dramatic";
            this.dramaticToolStripMenuItem.Click += new System.EventHandler(this.dramaticToolStripMenuItem_Click);
            // 
            // kakaoToolStripMenuItem
            // 
            this.kakaoToolStripMenuItem.Name = "kakaoToolStripMenuItem";
            this.kakaoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kakaoToolStripMenuItem.Text = "Kakao";
            this.kakaoToolStripMenuItem.Click += new System.EventHandler(this.kakaoToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 551);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Red";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 583);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Green";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 612);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Blue";
            // 
            // redbar
            // 
            this.redbar.Location = new System.Drawing.Point(114, 550);
            this.redbar.Maximum = 100;
            this.redbar.Name = "redbar";
            this.redbar.Size = new System.Drawing.Size(581, 45);
            this.redbar.TabIndex = 5;
            this.redbar.ValueChanged += new System.EventHandler(this.redbar_ValueChanged);
            // 
            // greenbar
            // 
            this.greenbar.Location = new System.Drawing.Point(114, 579);
            this.greenbar.Maximum = 100;
            this.greenbar.Name = "greenbar";
            this.greenbar.Size = new System.Drawing.Size(581, 45);
            this.greenbar.TabIndex = 6;
            this.greenbar.ValueChanged += new System.EventHandler(this.greenbar_ValueChanged);
            // 
            // bluebar
            // 
            this.bluebar.Location = new System.Drawing.Point(114, 608);
            this.bluebar.Maximum = 100;
            this.bluebar.Name = "bluebar";
            this.bluebar.Size = new System.Drawing.Size(581, 45);
            this.bluebar.TabIndex = 7;
            this.bluebar.ValueChanged += new System.EventHandler(this.bluebar_ValueChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // redvalue
            // 
            this.redvalue.AutoSize = true;
            this.redvalue.Location = new System.Drawing.Point(56, 551);
            this.redvalue.Name = "redvalue";
            this.redvalue.Size = new System.Drawing.Size(0, 13);
            this.redvalue.TabIndex = 10;
            // 
            // greenvalue
            // 
            this.greenvalue.AutoSize = true;
            this.greenvalue.Location = new System.Drawing.Point(56, 583);
            this.greenvalue.Name = "greenvalue";
            this.greenvalue.Size = new System.Drawing.Size(0, 13);
            this.greenvalue.TabIndex = 11;
            // 
            // bluevalue
            // 
            this.bluevalue.AutoSize = true;
            this.bluevalue.Location = new System.Drawing.Point(56, 612);
            this.bluevalue.Name = "bluevalue";
            this.bluevalue.Size = new System.Drawing.Size(0, 13);
            this.bluevalue.TabIndex = 12;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 654);
            this.Controls.Add(this.bluevalue);
            this.Controls.Add(this.greenvalue);
            this.Controls.Add(this.redvalue);
            this.Controls.Add(this.bluebar);
            this.Controls.Add(this.greenbar);
            this.Controls.Add(this.redbar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filtres";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.redbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bluebar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem filtresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sepiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem artisticToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spikeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flashToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frozenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sujiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dramaticToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kakaoToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar redbar;
        private System.Windows.Forms.TrackBar greenbar;
        private System.Windows.Forms.TrackBar bluebar;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label redvalue;
        private System.Windows.Forms.Label greenvalue;
        private System.Windows.Forms.Label bluevalue;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
    }
}