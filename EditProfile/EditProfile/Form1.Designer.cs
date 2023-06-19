namespace EditProfile
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            background = new Panel();
            backgroundedit = new Panel();
            pictureBox2 = new PictureBox();
            textBox4 = new TextBox();
            Provinsi = new ComboBox();
            Kecamatan = new ComboBox();
            Kabupaten = new ComboBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            namalengkap = new TextBox();
            DataPriabdi = new TextBox();
            EditButton = new Button();
            pictureBox1 = new PictureBox();
            background.SuspendLayout();
            backgroundedit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // background
            // 
            background.BackgroundImage = (Image)resources.GetObject("background.BackgroundImage");
            background.Controls.Add(backgroundedit);
            background.Location = new Point(0, 0);
            background.Margin = new Padding(3, 4, 3, 4);
            background.Name = "background";
            background.Size = new Size(1446, 911);
            background.TabIndex = 0;
            // 
            // backgroundedit
            // 
            backgroundedit.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            backgroundedit.BackColor = SystemColors.ControlLight;
            backgroundedit.Controls.Add(pictureBox2);
            backgroundedit.Controls.Add(textBox4);
            backgroundedit.Controls.Add(Provinsi);
            backgroundedit.Controls.Add(Kecamatan);
            backgroundedit.Controls.Add(Kabupaten);
            backgroundedit.Controls.Add(textBox3);
            backgroundedit.Controls.Add(textBox2);
            backgroundedit.Controls.Add(textBox1);
            backgroundedit.Controls.Add(namalengkap);
            backgroundedit.Controls.Add(DataPriabdi);
            backgroundedit.Controls.Add(EditButton);
            backgroundedit.Controls.Add(pictureBox1);
            backgroundedit.Location = new Point(115, 167);
            backgroundedit.Margin = new Padding(3, 4, 3, 4);
            backgroundedit.Name = "backgroundedit";
            backgroundedit.Size = new Size(1230, 539);
            backgroundedit.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1126, 288);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(42, 43);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click_1;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(46, 288);
            textBox4.Margin = new Padding(3, 4, 3, 4);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(1073, 27);
            textBox4.TabIndex = 10;
            // 
            // Provinsi
            // 
            Provinsi.Location = new Point(46, 352);
            Provinsi.Margin = new Padding(3, 4, 3, 4);
            Provinsi.Name = "Provinsi";
            Provinsi.Size = new Size(1099, 28);
            Provinsi.TabIndex = 9;
            // 
            // Kecamatan
            // 
            Kecamatan.FormattingEnabled = true;
            Kecamatan.Location = new Point(46, 485);
            Kecamatan.Margin = new Padding(3, 4, 3, 4);
            Kecamatan.Name = "Kecamatan";
            Kecamatan.Size = new Size(1099, 28);
            Kecamatan.TabIndex = 8;
            // 
            // Kabupaten
            // 
            Kabupaten.FormattingEnabled = true;
            Kabupaten.Location = new Point(46, 417);
            Kabupaten.Margin = new Padding(3, 4, 3, 4);
            Kabupaten.Name = "Kabupaten";
            Kabupaten.Size = new Size(1099, 28);
            Kabupaten.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.ControlLight;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Montserrat", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox3.ForeColor = SystemColors.WindowFrame;
            textBox3.Location = new Point(46, 452);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(163, 23);
            textBox3.TabIndex = 6;
            textBox3.Text = "Kecamatan";
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.ControlLight;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Montserrat", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.ForeColor = SystemColors.WindowFrame;
            textBox2.Location = new Point(46, 384);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(163, 23);
            textBox2.TabIndex = 5;
            textBox2.Text = "Kota/Kabupaten";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ControlLight;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Montserrat", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.ForeColor = SystemColors.WindowFrame;
            textBox1.Location = new Point(46, 320);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(163, 23);
            textBox1.TabIndex = 4;
            textBox1.Text = "Provinsi";
            // 
            // namalengkap
            // 
            namalengkap.BackColor = SystemColors.ControlLight;
            namalengkap.BorderStyle = BorderStyle.None;
            namalengkap.Font = new Font("Montserrat", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            namalengkap.ForeColor = SystemColors.WindowFrame;
            namalengkap.Location = new Point(46, 255);
            namalengkap.Margin = new Padding(3, 4, 3, 4);
            namalengkap.Name = "namalengkap";
            namalengkap.Size = new Size(163, 23);
            namalengkap.TabIndex = 3;
            namalengkap.Text = "Nama Lengkap";
            // 
            // DataPriabdi
            // 
            DataPriabdi.BackColor = SystemColors.ControlLight;
            DataPriabdi.BorderStyle = BorderStyle.None;
            DataPriabdi.Font = new Font("Montserrat", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            DataPriabdi.Location = new Point(46, 212);
            DataPriabdi.Margin = new Padding(3, 4, 3, 4);
            DataPriabdi.Name = "DataPriabdi";
            DataPriabdi.Size = new Size(181, 32);
            DataPriabdi.TabIndex = 2;
            DataPriabdi.Text = "Data Pribadi";
            // 
            // EditButton
            // 
            EditButton.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            EditButton.Location = new Point(46, 160);
            EditButton.Margin = new Padding(3, 4, 3, 4);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(88, 44);
            EditButton.TabIndex = 1;
            EditButton.Text = "Edit";
            EditButton.UseVisualStyleBackColor = true;
            EditButton.Click += EditButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(46, 55);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(88, 97);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1445, 908);
            Controls.Add(background);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            background.ResumeLayout(false);
            backgroundedit.ResumeLayout(false);
            backgroundedit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel background;
        private Panel backgroundedit;
        private Button EditButton;
        private PictureBox pictureBox1;
        private TextBox DataPriabdi;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox namalengkap;
        private ComboBox Provinsi;
        private ComboBox Kecamatan;
        private ComboBox Kabupaten;
        private PictureBox pictureBox2;
        private TextBox textBox4;
    }
}