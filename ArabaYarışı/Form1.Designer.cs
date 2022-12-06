namespace ArabaYarışı
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
            this.components = new System.ComponentModel.Container();
            this.lblFinish = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pcbCar1 = new System.Windows.Forms.PictureBox();
            this.pcbCar2 = new System.Windows.Forms.PictureBox();
            this.pcbCar3 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblDurum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCar3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFinish
            // 
            this.lblFinish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblFinish.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFinish.Location = new System.Drawing.Point(684, 4);
            this.lblFinish.Name = "lblFinish";
            this.lblFinish.Size = new System.Drawing.Size(21, 447);
            this.lblFinish.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(-16, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(694, 22);
            this.label2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(0, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(678, 28);
            this.label3.TabIndex = 5;
            // 
            // pcbCar1
            // 
            this.pcbCar1.Image = global::ArabaYarışı.Properties.Resources.araba4;
            this.pcbCar1.Location = new System.Drawing.Point(0, 79);
            this.pcbCar1.Name = "pcbCar1";
            this.pcbCar1.Size = new System.Drawing.Size(100, 50);
            this.pcbCar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbCar1.TabIndex = 6;
            this.pcbCar1.TabStop = false;
            // 
            // pcbCar2
            // 
            this.pcbCar2.Image = global::ArabaYarışı.Properties.Resources.araba2;
            this.pcbCar2.Location = new System.Drawing.Point(0, 280);
            this.pcbCar2.Name = "pcbCar2";
            this.pcbCar2.Size = new System.Drawing.Size(100, 50);
            this.pcbCar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbCar2.TabIndex = 7;
            this.pcbCar2.TabStop = false;
            // 
            // pcbCar3
            // 
            this.pcbCar3.Image = global::ArabaYarışı.Properties.Resources.araba3;
            this.pcbCar3.Location = new System.Drawing.Point(0, 401);
            this.pcbCar3.Name = "pcbCar3";
            this.pcbCar3.Size = new System.Drawing.Size(100, 50);
            this.pcbCar3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbCar3.TabIndex = 8;
            this.pcbCar3.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.Location = new System.Drawing.Point(170, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Yarışı Sıfırla";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DimGray;
            this.button2.Location = new System.Drawing.Point(326, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(166, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Yarışı başlat";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Location = new System.Drawing.Point(43, 18);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(0, 15);
            this.lblDurum.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pcbCar3);
            this.Controls.Add(this.pcbCar2);
            this.Controls.Add(this.pcbCar1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblFinish);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbCar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCar3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblFinish;
        private Label label2;
        private Label label3;
        private PictureBox pcbCar1;
        private PictureBox pcbCar2;
        private PictureBox pcbCar3;
        private Button button1;
        private Button button2;
        private System.Windows.Forms.Timer timer1;
        private Label lblDurum;
    }
}