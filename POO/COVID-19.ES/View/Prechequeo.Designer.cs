using System.ComponentModel;

namespace COVID_19.ES
{
    partial class Prechequeo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prechequeo));
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.check_No = new System.Windows.Forms.CheckBox();
            this.check_yes = new System.Windows.Forms.CheckBox();
            this.bttn_Verifydata = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bttnback = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label3.Location = new System.Drawing.Point(175, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(394, 127);
            this.label3.TabIndex = 3;
            this.label3.Text = "SEGUIMIENTO DE CITAS DE VACUNAS COVID-19";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.Location = new System.Drawing.Point(12, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "DUI";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.textBox1.Location = new System.Drawing.Point(12, 182);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(264, 26);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.Location = new System.Drawing.Point(12, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 42);
            this.label2.TabIndex = 2;
            this.label2.Text = "¿Otorga su consentimiento para ser vacunado?";
            // 
            // check_No
            // 
            this.check_No.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.check_No.Location = new System.Drawing.Point(12, 282);
            this.check_No.Name = "check_No";
            this.check_No.Size = new System.Drawing.Size(91, 26);
            this.check_No.TabIndex = 5;
            this.check_No.Text = "No.";
            this.check_No.UseVisualStyleBackColor = true;
            this.check_No.CheckedChanged += new System.EventHandler(this.check_No_CheckedChanged);
            // 
            // check_yes
            // 
            this.check_yes.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.check_yes.Location = new System.Drawing.Point(12, 256);
            this.check_yes.Name = "check_yes";
            this.check_yes.Size = new System.Drawing.Size(91, 20);
            this.check_yes.TabIndex = 4;
            this.check_yes.Text = "Si.";
            this.check_yes.UseVisualStyleBackColor = true;
            this.check_yes.CheckedChanged += new System.EventHandler(this.check_yes_CheckedChanged);
            // 
            // bttn_Verifydata
            // 
            this.bttn_Verifydata.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bttn_Verifydata.BackColor = System.Drawing.Color.Thistle;
            this.bttn_Verifydata.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_Verifydata.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.bttn_Verifydata.Location = new System.Drawing.Point(104, 475);
            this.bttn_Verifydata.Name = "bttn_Verifydata";
            this.bttn_Verifydata.Size = new System.Drawing.Size(145, 55);
            this.bttn_Verifydata.TabIndex = 7;
            this.bttn_Verifydata.Text = "Verificar datos";
            this.bttn_Verifydata.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label4.Location = new System.Drawing.Point(12, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(366, 42);
            this.label4.TabIndex = 8;
            this.label4.Text = "Fecha y hora de entrada a la fila";
            this.label4.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 356);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(264, 26);
            this.dateTimePicker1.TabIndex = 9;
            this.dateTimePicker1.Visible = false;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label5.Location = new System.Drawing.Point(12, 385);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(366, 42);
            this.label5.TabIndex = 10;
            this.label5.Text = "Fecha y hora en la que se aplico la vacuna";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Visible = false;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarFont = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.dateTimePicker2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(12, 430);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(264, 26);
            this.dateTimePicker2.TabIndex = 11;
            this.dateTimePicker2.Visible = false;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker3.Location = new System.Drawing.Point(282, 356);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(96, 26);
            this.dateTimePicker3.TabIndex = 12;
            this.dateTimePicker3.Visible = false;
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.dateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker4.Location = new System.Drawing.Point(282, 430);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(96, 26);
            this.dateTimePicker4.TabIndex = 13;
            this.dateTimePicker4.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // bttnback
            // 
            this.bttnback.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bttnback.BackColor = System.Drawing.Color.Thistle;
            this.bttnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnback.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.bttnback.Location = new System.Drawing.Point(310, 475);
            this.bttnback.Name = "bttnback";
            this.bttnback.Size = new System.Drawing.Size(145, 55);
            this.bttnback.TabIndex = 15;
            this.bttnback.Text = "Volver";
            this.bttnback.UseVisualStyleBackColor = false;
            this.bttnback.Click += new System.EventHandler(this.bttnback_Click);
            // 
            // Prechequeo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(581, 542);
            this.Controls.Add(this.bttnback);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dateTimePicker4);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bttn_Verifydata);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.check_yes);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.check_No);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.Name = "Prechequeo";
            this.ShowIcon = false;
            this.Text = "Prechequeo";
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button bttnback;


        private System.Windows.Forms.PictureBox pictureBox1;

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;

        private System.Windows.Forms.CheckBox check_yes;
        private System.Windows.Forms.CheckBox check_No;

        private System.Windows.Forms.Button bttn_Verifydata;

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;

        #endregion
    }
}