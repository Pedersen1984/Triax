namespace Triax_Fejlrapportering
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Navnbox = new System.Windows.Forms.ComboBox();
            this.VNummer = new System.Windows.Forms.ComboBox();
            this.ÅrsagBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Notebox = new System.Windows.Forms.TextBox();
            this.KompBox = new System.Windows.Forms.TextBox();
            this.Valbox = new System.Windows.Forms.TextBox();
            this.Stockbox = new System.Windows.Forms.TextBox();
            this.Tidbtn = new System.Windows.Forms.Button();
            this.Hentbutton = new System.Windows.Forms.Button();
            this.Fejlsøg = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.TidSlider = new System.Windows.Forms.TrackBar();
            this.Fejlpanel = new System.Windows.Forms.Panel();
            this.Findbtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.Pauseimg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.TidSlider)).BeginInit();
            this.Fejlpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pauseimg)).BeginInit();
            this.SuspendLayout();
            // 
            // Navnbox
            // 
            this.Navnbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Navnbox.FormattingEnabled = true;
            this.Navnbox.Location = new System.Drawing.Point(30, 23);
            this.Navnbox.Name = "Navnbox";
            this.Navnbox.Size = new System.Drawing.Size(121, 21);
            this.Navnbox.TabIndex = 0;
            // 
            // VNummer
            // 
            this.VNummer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VNummer.FormattingEnabled = true;
            this.VNummer.Location = new System.Drawing.Point(30, 63);
            this.VNummer.Name = "VNummer";
            this.VNummer.Size = new System.Drawing.Size(121, 21);
            this.VNummer.TabIndex = 1;
            this.VNummer.SelectedIndexChanged += new System.EventHandler(this.VNummer_SelectedIndexChanged);
            // 
            // ÅrsagBox
            // 
            this.ÅrsagBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ÅrsagBox.FormattingEnabled = true;
            this.ÅrsagBox.Location = new System.Drawing.Point(174, 23);
            this.ÅrsagBox.Name = "ÅrsagBox";
            this.ÅrsagBox.Size = new System.Drawing.Size(121, 21);
            this.ÅrsagBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Navn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Varenavn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tid";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(174, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Årsag";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Værdi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Komponent varenummer";
            // 
            // Notebox
            // 
            this.Notebox.Location = new System.Drawing.Point(174, 63);
            this.Notebox.Multiline = true;
            this.Notebox.Name = "Notebox";
            this.Notebox.Size = new System.Drawing.Size(121, 139);
            this.Notebox.TabIndex = 9;
            this.Notebox.Text = "Noter";
            this.Notebox.Enter += new System.EventHandler(this.Notebox_Enter);
            this.Notebox.Leave += new System.EventHandler(this.Notebox_Leave);
            // 
            // KompBox
            // 
            this.KompBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.KompBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.KompBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.KompBox.Location = new System.Drawing.Point(318, 23);
            this.KompBox.Name = "KompBox";
            this.KompBox.Size = new System.Drawing.Size(121, 20);
            this.KompBox.TabIndex = 10;
            this.KompBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.KompBox_MouseClick);
            this.KompBox.TextChanged += new System.EventHandler(this.KompBox_TextChanged);
            this.KompBox.Enter += new System.EventHandler(this.KompBox_Enter);
            this.KompBox.Leave += new System.EventHandler(this.KompBox_Leave);
            // 
            // Valbox
            // 
            this.Valbox.Location = new System.Drawing.Point(3, 19);
            this.Valbox.Name = "Valbox";
            this.Valbox.ReadOnly = true;
            this.Valbox.Size = new System.Drawing.Size(100, 20);
            this.Valbox.TabIndex = 11;
            // 
            // Stockbox
            // 
            this.Stockbox.Location = new System.Drawing.Point(3, 55);
            this.Stockbox.Name = "Stockbox";
            this.Stockbox.ReadOnly = true;
            this.Stockbox.Size = new System.Drawing.Size(100, 20);
            this.Stockbox.TabIndex = 12;
            // 
            // Tidbtn
            // 
            this.Tidbtn.Location = new System.Drawing.Point(30, 130);
            this.Tidbtn.Name = "Tidbtn";
            this.Tidbtn.Size = new System.Drawing.Size(75, 23);
            this.Tidbtn.TabIndex = 14;
            this.Tidbtn.Text = "Start/stop tid";
            this.Tidbtn.UseVisualStyleBackColor = true;
            this.Tidbtn.Click += new System.EventHandler(this.Tidbtn_Click);
            // 
            // Hentbutton
            // 
            this.Hentbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Hentbutton.Enabled = false;
            this.Hentbutton.Location = new System.Drawing.Point(30, 212);
            this.Hentbutton.Name = "Hentbutton";
            this.Hentbutton.Size = new System.Drawing.Size(121, 23);
            this.Hentbutton.TabIndex = 15;
            this.Hentbutton.Text = "Hent PDF";
            this.Hentbutton.UseVisualStyleBackColor = true;
            this.Hentbutton.Click += new System.EventHandler(this.Hentbutton_Click);
            // 
            // Fejlsøg
            // 
            this.Fejlsøg.Enabled = false;
            this.Fejlsøg.Location = new System.Drawing.Point(174, 212);
            this.Fejlsøg.Name = "Fejlsøg";
            this.Fejlsøg.Size = new System.Drawing.Size(121, 23);
            this.Fejlsøg.TabIndex = 16;
            this.Fejlsøg.Text = "Hent diagram";
            this.Fejlsøg.UseVisualStyleBackColor = true;
            this.Fejlsøg.Click += new System.EventHandler(this.Fejlsøg_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(318, 212);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(121, 23);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Gem";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // TidSlider
            // 
            this.TidSlider.LargeChange = 30;
            this.TidSlider.Location = new System.Drawing.Point(30, 107);
            this.TidSlider.Maximum = 240;
            this.TidSlider.Name = "TidSlider";
            this.TidSlider.Size = new System.Drawing.Size(104, 45);
            this.TidSlider.SmallChange = 5;
            this.TidSlider.TabIndex = 18;
            this.TidSlider.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // Fejlpanel
            // 
            this.Fejlpanel.Controls.Add(this.Findbtn);
            this.Fejlpanel.Controls.Add(this.Valbox);
            this.Fejlpanel.Controls.Add(this.Stockbox);
            this.Fejlpanel.Controls.Add(this.label6);
            this.Fejlpanel.Controls.Add(this.label5);
            this.Fejlpanel.Location = new System.Drawing.Point(318, 63);
            this.Fejlpanel.Name = "Fejlpanel";
            this.Fejlpanel.Size = new System.Drawing.Size(121, 123);
            this.Fejlpanel.TabIndex = 19;
            this.Fejlpanel.Visible = false;
            // 
            // Findbtn
            // 
            this.Findbtn.Location = new System.Drawing.Point(6, 82);
            this.Findbtn.Name = "Findbtn";
            this.Findbtn.Size = new System.Drawing.Size(97, 25);
            this.Findbtn.TabIndex = 13;
            this.Findbtn.Text = "Find komponent";
            this.Findbtn.UseVisualStyleBackColor = true;
            this.Findbtn.Click += new System.EventHandler(this.Findbtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(318, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Komponent placering";
            // 
            // Pauseimg
            // 
            this.Pauseimg.Image = global::Triax_Fejlrapportering.Properties.Resources.pause;
            this.Pauseimg.Location = new System.Drawing.Point(111, 130);
            this.Pauseimg.Name = "Pauseimg";
            this.Pauseimg.Size = new System.Drawing.Size(23, 23);
            this.Pauseimg.TabIndex = 21;
            this.Pauseimg.TabStop = false;
            this.Pauseimg.Visible = false;
            this.Pauseimg.Click += new System.EventHandler(this.Pauseimg_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 247);
            this.Controls.Add(this.Pauseimg);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Fejlpanel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.Fejlsøg);
            this.Controls.Add(this.Hentbutton);
            this.Controls.Add(this.Tidbtn);
            this.Controls.Add(this.KompBox);
            this.Controls.Add(this.Notebox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ÅrsagBox);
            this.Controls.Add(this.VNummer);
            this.Controls.Add(this.Navnbox);
            this.Controls.Add(this.TidSlider);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Triax Fejlrapportering";
            ((System.ComponentModel.ISupportInitialize)(this.TidSlider)).EndInit();
            this.Fejlpanel.ResumeLayout(false);
            this.Fejlpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pauseimg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Navnbox;
        private System.Windows.Forms.ComboBox VNummer;
        private System.Windows.Forms.ComboBox ÅrsagBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Notebox;
        private System.Windows.Forms.TextBox KompBox;
        private System.Windows.Forms.TextBox Valbox;
        private System.Windows.Forms.TextBox Stockbox;
        private System.Windows.Forms.Button Tidbtn;
        private System.Windows.Forms.Button Hentbutton;
        private System.Windows.Forms.Button Fejlsøg;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TrackBar TidSlider;
        private System.Windows.Forms.Panel Fejlpanel;
        private System.Windows.Forms.Button Findbtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox Pauseimg;
    }
}

