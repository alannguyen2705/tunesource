namespace domi.music275
{
    partial class domiplaying
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(domiplaying));
            this.listBox_domi = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_domi_click = new System.Windows.Forms.Button();
            this.textBox_domi = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox_domi
            // 
            this.listBox_domi.FormattingEnabled = true;
            this.listBox_domi.ItemHeight = 20;
            this.listBox_domi.Location = new System.Drawing.Point(859, 90);
            this.listBox_domi.Name = "listBox_domi";
            this.listBox_domi.Size = new System.Drawing.Size(260, 404);
            this.listBox_domi.TabIndex = 0;
            this.listBox_domi.SelectedIndexChanged += new System.EventHandler(this.listBox_domi_SelectedIndexChanged);
            this.listBox_domi.DoubleClick += new System.EventHandler(this.listBox_domi_DoubleClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1074, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(859, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(209, 26);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(855, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 3;
            // 
            // button_domi_click
            // 
            this.button_domi_click.BackColor = System.Drawing.SystemColors.Highlight;
            this.button_domi_click.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_domi_click.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_domi_click.Location = new System.Drawing.Point(1012, 540);
            this.button_domi_click.Name = "button_domi_click";
            this.button_domi_click.Size = new System.Drawing.Size(106, 44);
            this.button_domi_click.TabIndex = 4;
            this.button_domi_click.Text = "Exit";
            this.button_domi_click.UseVisualStyleBackColor = false;
            this.button_domi_click.Click += new System.EventHandler(this.button_domi);
            // 
            // textBox_domi
            // 
            this.textBox_domi.Location = new System.Drawing.Point(79, 549);
            this.textBox_domi.Name = "textBox_domi";
            this.textBox_domi.Size = new System.Drawing.Size(762, 26);
            this.textBox_domi.TabIndex = 5;
            this.textBox_domi.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(859, 540);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 44);
            this.button2.TabIndex = 7;
            this.button2.Text = "Your library";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(12, 12);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(829, 512);
            this.axWindowsMediaPlayer1.TabIndex = 6;
            this.axWindowsMediaPlayer1.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter_1);
            // 
            // domiplaying
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 637);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.textBox_domi);
            this.Controls.Add(this.button_domi_click);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listBox_domi);
            this.Name = "domiplaying";
            this.Text = "Playing | Tune Source";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_domi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_domi_click;
        private System.Windows.Forms.TextBox textBox_domi;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button button2;
    }
}