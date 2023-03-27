namespace OCR_Vietnamese
{
    partial class Brightness
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Brightness));
            this.btn_choose = new System.Windows.Forms.Button();
            this.btn_ocr = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.picloading = new System.Windows.Forms.PictureBox();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_takephoto = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btn_saveresult = new System.Windows.Forms.Button();
            this.crop = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.adjust = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.lbBrightness = new System.Windows.Forms.Label();
            this.btn_ZoomIn = new System.Windows.Forms.Button();
            this.btn_ZoomOut = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picloading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_choose
            // 
            this.btn_choose.Location = new System.Drawing.Point(371, 44);
            this.btn_choose.Name = "btn_choose";
            this.btn_choose.Size = new System.Drawing.Size(89, 23);
            this.btn_choose.TabIndex = 1;
            this.btn_choose.Text = "Choose Image";
            this.btn_choose.UseVisualStyleBackColor = true;
            this.btn_choose.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_ocr
            // 
            this.btn_ocr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ocr.ForeColor = System.Drawing.Color.Red;
            this.btn_ocr.Location = new System.Drawing.Point(478, 180);
            this.btn_ocr.Name = "btn_ocr";
            this.btn_ocr.Size = new System.Drawing.Size(92, 89);
            this.btn_ocr.TabIndex = 2;
            this.btn_ocr.Text = "OCR";
            this.btn_ocr.UseVisualStyleBackColor = true;
            this.btn_ocr.Click += new System.EventHandler(this.button2_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.richTextBox1.Location = new System.Drawing.Point(587, 73);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(430, 414);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(798, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Result";
            // 
            // picloading
            // 
            this.picloading.Image = global::OCR_Vietnamese.Properties.Resources.loading;
            this.picloading.Location = new System.Drawing.Point(768, 240);
            this.picloading.Name = "picloading";
            this.picloading.Size = new System.Drawing.Size(107, 106);
            this.picloading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picloading.TabIndex = 7;
            this.picloading.TabStop = false;
            this.picloading.Visible = false;
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(12, 44);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(75, 23);
            this.btn_start.TabIndex = 8;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_takephoto
            // 
            this.btn_takephoto.Location = new System.Drawing.Point(209, 44);
            this.btn_takephoto.Name = "btn_takephoto";
            this.btn_takephoto.Size = new System.Drawing.Size(75, 23);
            this.btn_takephoto.TabIndex = 9;
            this.btn_takephoto.Text = "Take photo";
            this.btn_takephoto.UseVisualStyleBackColor = true;
            this.btn_takephoto.Click += new System.EventHandler(this.btn_takephoto_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(290, 44);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 10;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(93, 44);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(110, 21);
            this.comboBox1.TabIndex = 11;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Title = "ImageName|*.png";
            // 
            // btn_saveresult
            // 
            this.btn_saveresult.Location = new System.Drawing.Point(675, 505);
            this.btn_saveresult.Name = "btn_saveresult";
            this.btn_saveresult.Size = new System.Drawing.Size(97, 35);
            this.btn_saveresult.TabIndex = 12;
            this.btn_saveresult.Text = "Save";
            this.btn_saveresult.UseVisualStyleBackColor = true;
            this.btn_saveresult.Click += new System.EventHandler(this.btn_saveresult_Click);
            // 
            // crop
            // 
            this.crop.Location = new System.Drawing.Point(478, 110);
            this.crop.Margin = new System.Windows.Forms.Padding(2);
            this.crop.Name = "crop";
            this.crop.Size = new System.Drawing.Size(92, 38);
            this.crop.TabIndex = 13;
            this.crop.Text = "Crop";
            this.crop.UseVisualStyleBackColor = true;
            this.crop.Click += new System.EventHandler(this.Crop);
            this.crop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.crop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(531, 379);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 39);
            this.button1.TabIndex = 14;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(478, 379);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(37, 39);
            this.button2.TabIndex = 15;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // adjust
            // 
            this.adjust.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.adjust.Location = new System.Drawing.Point(12, 511);
            this.adjust.Margin = new System.Windows.Forms.Padding(2);
            this.adjust.Name = "adjust";
            this.adjust.Size = new System.Drawing.Size(88, 30);
            this.adjust.TabIndex = 16;
            this.adjust.Text = "Adjust";
            this.adjust.UseVisualStyleBackColor = true;
            this.adjust.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(442, 427);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 100;
            this.trackBar1.Location = new System.Drawing.Point(104, 511);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(2);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(151, 45);
            this.trackBar1.SmallChange = 5;
            this.trackBar1.TabIndex = 17;
            this.trackBar1.TickFrequency = 5;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // lbBrightness
            // 
            this.lbBrightness.AutoSize = true;
            this.lbBrightness.Location = new System.Drawing.Point(259, 511);
            this.lbBrightness.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbBrightness.Name = "lbBrightness";
            this.lbBrightness.Size = new System.Drawing.Size(13, 13);
            this.lbBrightness.TabIndex = 18;
            this.lbBrightness.Text = "0";
            // 
            // btn_ZoomIn
            // 
            this.btn_ZoomIn.Location = new System.Drawing.Point(478, 439);
            this.btn_ZoomIn.Name = "btn_ZoomIn";
            this.btn_ZoomIn.Size = new System.Drawing.Size(37, 34);
            this.btn_ZoomIn.TabIndex = 19;
            this.btn_ZoomIn.Text = "+";
            this.btn_ZoomIn.UseVisualStyleBackColor = true;
            this.btn_ZoomIn.Click += new System.EventHandler(this.btn_ZoomIn_Click);
            // 
            // btn_ZoomOut
            // 
            this.btn_ZoomOut.Location = new System.Drawing.Point(531, 439);
            this.btn_ZoomOut.Name = "btn_ZoomOut";
            this.btn_ZoomOut.Size = new System.Drawing.Size(39, 34);
            this.btn_ZoomOut.TabIndex = 20;
            this.btn_ZoomOut.Text = "-";
            this.btn_ZoomOut.UseVisualStyleBackColor = true;
            this.btn_ZoomOut.Click += new System.EventHandler(this.btn_ZoomOut_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(844, 505);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(122, 35);
            this.button5.TabIndex = 21;
            this.button5.Text = "Save In Nextcloud";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(448, 433);
            this.panel1.TabIndex = 22;
            // 
            // Brightness
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 552);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btn_ZoomOut);
            this.Controls.Add(this.btn_ZoomIn);
            this.Controls.Add(this.lbBrightness);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.adjust);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.crop);
            this.Controls.Add(this.btn_saveresult);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_takephoto);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.picloading);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btn_ocr);
            this.Controls.Add(this.btn_choose);
            this.Name = "Brightness";
            this.Text = "[C#] Convert Image To Text";
            ((System.ComponentModel.ISupportInitialize)(this.picloading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_choose;
        private System.Windows.Forms.Button btn_ocr;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picloading;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_takephoto;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btn_saveresult;
        private System.Windows.Forms.Button crop;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button adjust;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label lbBrightness;
        private System.Windows.Forms.Button btn_ZoomIn;
        private System.Windows.Forms.Button btn_ZoomOut;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel1;
    }
}

