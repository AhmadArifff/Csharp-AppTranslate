
namespace PROJECT_UAS
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
            this.filters = new System.Windows.Forms.ComboBox();
            this.List_Arti = new System.Windows.Forms.ListBox();
            this.List_Kata = new System.Windows.Forms.ListBox();
            this.Btn_Simpan = new System.Windows.Forms.Button();
            this.Btn_Edit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Arti = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Kata = new System.Windows.Forms.TextBox();
            this.Cari = new System.Windows.Forms.TextBox();
            this.Btn_Cari = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // filters
            // 
            this.filters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filters.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.filters.FormattingEnabled = true;
            this.filters.Items.AddRange(new object[] {
            "a->z",
            "z->a"});
            this.filters.Location = new System.Drawing.Point(272, 551);
            this.filters.Name = "filters";
            this.filters.Size = new System.Drawing.Size(81, 26);
            this.filters.TabIndex = 23;
            this.filters.SelectedIndexChanged += new System.EventHandler(this.filters_SelectedIndexChanged);
            // 
            // List_Arti
            // 
            this.List_Arti.BackColor = System.Drawing.SystemColors.Control;
            this.List_Arti.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.List_Arti.FormattingEnabled = true;
            this.List_Arti.ItemHeight = 18;
            this.List_Arti.Location = new System.Drawing.Point(462, 307);
            this.List_Arti.Name = "List_Arti";
            this.List_Arti.Size = new System.Drawing.Size(247, 220);
            this.List_Arti.TabIndex = 22;
            this.List_Arti.Click += new System.EventHandler(this.List_Arti_Click);
            this.List_Arti.SelectedIndexChanged += new System.EventHandler(this.List_Arti_SelectedIndexChanged);
            // 
            // List_Kata
            // 
            this.List_Kata.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.List_Kata.FormattingEnabled = true;
            this.List_Kata.ItemHeight = 18;
            this.List_Kata.Location = new System.Drawing.Point(106, 307);
            this.List_Kata.Name = "List_Kata";
            this.List_Kata.Size = new System.Drawing.Size(247, 220);
            this.List_Kata.TabIndex = 21;
            this.List_Kata.Click += new System.EventHandler(this.List_Kata_Click);
            this.List_Kata.SelectedIndexChanged += new System.EventHandler(this.List_Kata_SelectedIndexChanged);
            // 
            // Btn_Simpan
            // 
            this.Btn_Simpan.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.Btn_Simpan.Location = new System.Drawing.Point(599, 666);
            this.Btn_Simpan.Name = "Btn_Simpan";
            this.Btn_Simpan.Size = new System.Drawing.Size(110, 33);
            this.Btn_Simpan.TabIndex = 20;
            this.Btn_Simpan.Text = "Simpan";
            this.Btn_Simpan.UseVisualStyleBackColor = true;
            this.Btn_Simpan.Click += new System.EventHandler(this.Btn_Simpan_Click);
            // 
            // Btn_Edit
            // 
            this.Btn_Edit.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.Btn_Edit.Location = new System.Drawing.Point(599, 547);
            this.Btn_Edit.Name = "Btn_Edit";
            this.Btn_Edit.Size = new System.Drawing.Size(110, 33);
            this.Btn_Edit.TabIndex = 19;
            this.Btn_Edit.Text = "Edit";
            this.Btn_Edit.UseVisualStyleBackColor = true;
            this.Btn_Edit.Click += new System.EventHandler(this.Btn_Edit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(459, 603);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "Arti :";
            // 
            // Arti
            // 
            this.Arti.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Arti.Location = new System.Drawing.Point(462, 624);
            this.Arti.Name = "Arti";
            this.Arti.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Arti.Size = new System.Drawing.Size(247, 26);
            this.Arti.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(103, 603);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 18);
            this.label1.TabIndex = 16;
            this.label1.Text = "Kata :";
            // 
            // Kata
            // 
            this.Kata.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kata.Location = new System.Drawing.Point(106, 624);
            this.Kata.Name = "Kata";
            this.Kata.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Kata.Size = new System.Drawing.Size(247, 26);
            this.Kata.TabIndex = 15;
            this.Kata.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Kata_KeyUp);
            // 
            // Cari
            // 
            this.Cari.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cari.Location = new System.Drawing.Point(195, 229);
            this.Cari.Name = "Cari";
            this.Cari.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Cari.Size = new System.Drawing.Size(247, 26);
            this.Cari.TabIndex = 14;
            this.Cari.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Btn_Cari
            // 
            this.Btn_Cari.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.Btn_Cari.Location = new System.Drawing.Point(480, 225);
            this.Btn_Cari.Name = "Btn_Cari";
            this.Btn_Cari.Size = new System.Drawing.Size(110, 33);
            this.Btn_Cari.TabIndex = 13;
            this.Btn_Cari.Text = "Cari";
            this.Btn_Cari.UseVisualStyleBackColor = true;
            this.Btn_Cari.Click += new System.EventHandler(this.Btn_Cari_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(103, 554);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 18);
            this.label3.TabIndex = 24;
            this.label3.Text = "Sorting Bahasa :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(101, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 18);
            this.label4.TabIndex = 25;
            this.label4.Text = "NPM   : 40621190002";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(101, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 18);
            this.label5.TabIndex = 26;
            this.label5.Text = "Nama  : AHMAD ARIF";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(73, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(658, 18);
            this.label6.TabIndex = 27;
            this.label6.Text = "Aplikasi Translate Menggunakan Librrary get URL Transalate Google";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(103, 286);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(188, 18);
            this.label7.TabIndex = 28;
            this.label7.Text = "Bahasa Indonesia :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(459, 286);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(168, 18);
            this.label8.TabIndex = 29;
            this.label8.Text = "Bahasa Inggris :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 735);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.filters);
            this.Controls.Add(this.List_Arti);
            this.Controls.Add(this.List_Kata);
            this.Controls.Add(this.Btn_Simpan);
            this.Controls.Add(this.Btn_Edit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Arti);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Kata);
            this.Controls.Add(this.Cari);
            this.Controls.Add(this.Btn_Cari);
            this.Name = "Form1";
            this.Text = "Dictionary";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox filters;
        private System.Windows.Forms.ListBox List_Arti;
        private System.Windows.Forms.ListBox List_Kata;
        private System.Windows.Forms.Button Btn_Simpan;
        private System.Windows.Forms.Button Btn_Edit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Arti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Kata;
        private System.Windows.Forms.TextBox Cari;
        private System.Windows.Forms.Button Btn_Cari;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

