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
            this.datePickerSystem = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Vacunacion = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.SendSymt = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.secDose = new System.Windows.Forms.TabPage();
            this.dateTimePicker5 = new System.Windows.Forms.DateTimePicker();
            this.bttn_sendsym = new System.Windows.Forms.Button();
            this.secondAppointment = new System.Windows.Forms.Button();
            this.TimePick = new System.Windows.Forms.DateTimePicker();
            this.labelTime = new System.Windows.Forms.Label();
            this.textBSym = new System.Windows.Forms.TextBox();
            this.labelSym = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).BeginInit();
            this.TabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.Vacunacion.SuspendLayout();
            this.secDose.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label3.Location = new System.Drawing.Point(301, 7);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(441, 71);
            this.label3.TabIndex = 3;
            this.label3.Text = "SEGUIMIENTO DE CITAS DE VACUNAS COVID-19";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.Location = new System.Drawing.Point(353, 128);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "DUI";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(353, 158);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(368, 22);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.Location = new System.Drawing.Point(415, 266);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 52);
            this.label2.TabIndex = 2;
            this.label2.Text = "¿Otorga su consentimiento para ser vacunado?";
            // 
            // check_No
            // 
            this.check_No.Enabled = false;
            this.check_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.check_No.Location = new System.Drawing.Point(577, 329);
            this.check_No.Margin = new System.Windows.Forms.Padding(4);
            this.check_No.Name = "check_No";
            this.check_No.Size = new System.Drawing.Size(81, 32);
            this.check_No.TabIndex = 5;
            this.check_No.Text = "No.";
            this.check_No.UseVisualStyleBackColor = true;
            this.check_No.CheckedChanged += new System.EventHandler(this.check_No_CheckedChanged);
            // 
            // check_yes
            // 
            this.check_yes.Enabled = false;
            this.check_yes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.check_yes.Location = new System.Drawing.Point(415, 333);
            this.check_yes.Margin = new System.Windows.Forms.Padding(4);
            this.check_yes.Name = "check_yes";
            this.check_yes.Size = new System.Drawing.Size(81, 25);
            this.check_yes.TabIndex = 4;
            this.check_yes.Text = "Si.";
            this.check_yes.UseVisualStyleBackColor = true;
            this.check_yes.CheckedChanged += new System.EventHandler(this.check_yes_CheckedChanged);
            // 
            // bttn_Verifydata
            // 
            this.bttn_Verifydata.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bttn_Verifydata.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (224)))), ((int) (((byte) (224)))), ((int) (((byte) (224)))));
            this.bttn_Verifydata.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_Verifydata.Location = new System.Drawing.Point(436, 199);
            this.bttn_Verifydata.Margin = new System.Windows.Forms.Padding(4);
            this.bttn_Verifydata.Name = "bttn_Verifydata";
            this.bttn_Verifydata.Size = new System.Drawing.Size(200, 38);
            this.bttn_Verifydata.TabIndex = 7;
            this.bttn_Verifydata.Text = "Verificar datos";
            this.bttn_Verifydata.UseVisualStyleBackColor = false;
            this.bttn_Verifydata.Click += new System.EventHandler(this.bttn_Verifydata_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label4.Location = new System.Drawing.Point(80, 75);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(243, 52);
            this.label4.TabIndex = 8;
            this.label4.Text = "Fecha y hora de entrada a la fila";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(80, 136);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.MaxDate = new System.DateTime(2022, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(372, 29);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label5.Location = new System.Drawing.Point(80, 204);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(291, 52);
            this.label5.TabIndex = 10;
            this.label5.Text = "Fecha y hora en la que se aplico la vacuna";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Enabled = false;
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(80, 259);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker2.MaxDate = new System.DateTime(2022, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker2.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(372, 29);
            this.dateTimePicker2.TabIndex = 11;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Enabled = false;
            this.dateTimePicker3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker3.Location = new System.Drawing.Point(507, 136);
            this.dateTimePicker3.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(127, 29);
            this.dateTimePicker3.TabIndex = 12;
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.Enabled = false;
            this.dateTimePicker4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.dateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker4.Location = new System.Drawing.Point(507, 259);
            this.dateTimePicker4.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(127, 29);
            this.dateTimePicker4.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 7);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // datePickerSystem
            // 
            this.datePickerSystem.Location = new System.Drawing.Point(435, 82);
            this.datePickerSystem.Margin = new System.Windows.Forms.Padding(4);
            this.datePickerSystem.Name = "datePickerSystem";
            this.datePickerSystem.Size = new System.Drawing.Size(187, 22);
            this.datePickerSystem.TabIndex = 15;
            this.datePickerSystem.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 417);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(877, 89);
            this.dataGridView1.TabIndex = 16;
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.tabPage1);
            this.TabControl.Controls.Add(this.Vacunacion);
            this.TabControl.Controls.Add(this.secDose);
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Margin = new System.Windows.Forms.Padding(4);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(889, 413);
            this.TabControl.TabIndex = 17;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.datePickerSystem);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.bttn_Verifydata);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.check_yes);
            this.tabPage1.Controls.Add(this.check_No);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(881, 384);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Prechequeo";
            // 
            // Vacunacion
            // 
            this.Vacunacion.Controls.Add(this.button1);
            this.Vacunacion.Controls.Add(this.SendSymt);
            this.Vacunacion.Controls.Add(this.label6);
            this.Vacunacion.Controls.Add(this.label4);
            this.Vacunacion.Controls.Add(this.dateTimePicker1);
            this.Vacunacion.Controls.Add(this.dateTimePicker4);
            this.Vacunacion.Controls.Add(this.label5);
            this.Vacunacion.Controls.Add(this.dateTimePicker3);
            this.Vacunacion.Controls.Add(this.dateTimePicker2);
            this.Vacunacion.Location = new System.Drawing.Point(4, 25);
            this.Vacunacion.Margin = new System.Windows.Forms.Padding(4);
            this.Vacunacion.Name = "Vacunacion";
            this.Vacunacion.Padding = new System.Windows.Forms.Padding(4);
            this.Vacunacion.Size = new System.Drawing.Size(881, 384);
            this.Vacunacion.TabIndex = 1;
            this.Vacunacion.Text = "Paso de Vacunacion";
            this.Vacunacion.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (224)))), ((int) (((byte) (224)))), ((int) (((byte) (224)))));
            this.button1.Enabled = false;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(700, 259);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 29);
            this.button1.TabIndex = 16;
            this.button1.Text = "Enviar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SendSymt
            // 
            this.SendSymt.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (224)))), ((int) (((byte) (224)))), ((int) (((byte) (224)))));
            this.SendSymt.Enabled = false;
            this.SendSymt.FlatAppearance.BorderSize = 0;
            this.SendSymt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendSymt.Location = new System.Drawing.Point(700, 136);
            this.SendSymt.Margin = new System.Windows.Forms.Padding(4);
            this.SendSymt.Name = "SendSymt";
            this.SendSymt.Size = new System.Drawing.Size(81, 29);
            this.SendSymt.TabIndex = 15;
            this.SendSymt.Text = "Enviar";
            this.SendSymt.UseVisualStyleBackColor = true;
            this.SendSymt.Click += new System.EventHandler(this.SendSymt_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label6.Location = new System.Drawing.Point(33, 4);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(566, 71);
            this.label6.TabIndex = 14;
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // secDose
            // 
            this.secDose.Controls.Add(this.dateTimePicker5);
            this.secDose.Controls.Add(this.bttn_sendsym);
            this.secDose.Controls.Add(this.secondAppointment);
            this.secDose.Controls.Add(this.TimePick);
            this.secDose.Controls.Add(this.labelTime);
            this.secDose.Controls.Add(this.textBSym);
            this.secDose.Controls.Add(this.labelSym);
            this.secDose.Controls.Add(this.label10);
            this.secDose.Controls.Add(this.checkBox2);
            this.secDose.Controls.Add(this.checkBox1);
            this.secDose.Controls.Add(this.label7);
            this.secDose.Location = new System.Drawing.Point(4, 25);
            this.secDose.Margin = new System.Windows.Forms.Padding(4);
            this.secDose.Name = "secDose";
            this.secDose.Padding = new System.Windows.Forms.Padding(4);
            this.secDose.Size = new System.Drawing.Size(881, 384);
            this.secDose.TabIndex = 2;
            this.secDose.Text = "Efectos secundarios";
            this.secDose.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker5
            // 
            this.dateTimePicker5.Location = new System.Drawing.Point(423, 365);
            this.dateTimePicker5.Name = "dateTimePicker5";
            this.dateTimePicker5.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker5.TabIndex = 25;
            this.dateTimePicker5.Visible = false;
            // 
            // bttn_sendsym
            // 
            this.bttn_sendsym.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (224)))), ((int) (((byte) (224)))), ((int) (((byte) (224)))));
            this.bttn_sendsym.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_sendsym.Location = new System.Drawing.Point(421, 283);
            this.bttn_sendsym.Margin = new System.Windows.Forms.Padding(4);
            this.bttn_sendsym.Name = "bttn_sendsym";
            this.bttn_sendsym.Size = new System.Drawing.Size(233, 49);
            this.bttn_sendsym.TabIndex = 24;
            this.bttn_sendsym.Text = "Enviar informe de sintomas";
            this.bttn_sendsym.UseVisualStyleBackColor = false;
            this.bttn_sendsym.Visible = false;
            this.bttn_sendsym.Click += new System.EventHandler(this.bttn_sendsym_Click);
            // 
            // secondAppointment
            // 
            this.secondAppointment.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (224)))), ((int) (((byte) (224)))), ((int) (((byte) (224)))));
            this.secondAppointment.Enabled = false;
            this.secondAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.secondAppointment.Location = new System.Drawing.Point(27, 283);
            this.secondAppointment.Margin = new System.Windows.Forms.Padding(4);
            this.secondAppointment.Name = "secondAppointment";
            this.secondAppointment.Size = new System.Drawing.Size(233, 49);
            this.secondAppointment.TabIndex = 18;
            this.secondAppointment.UseVisualStyleBackColor = false;
            this.secondAppointment.Click += new System.EventHandler(this.secondAppointment_Click);
            // 
            // TimePick
            // 
            this.TimePick.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.TimePick.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TimePick.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TimePick.Location = new System.Drawing.Point(421, 234);
            this.TimePick.Margin = new System.Windows.Forms.Padding(4);
            this.TimePick.Name = "TimePick";
            this.TimePick.Size = new System.Drawing.Size(191, 29);
            this.TimePick.TabIndex = 20;
            this.TimePick.Visible = false;
            // 
            // labelTime
            // 
            this.labelTime.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.labelTime.Location = new System.Drawing.Point(421, 188);
            this.labelTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(358, 33);
            this.labelTime.TabIndex = 19;
            this.labelTime.Text = "Hora que comenzaron los efectos:";
            this.labelTime.Visible = false;
            // 
            // textBSym
            // 
            this.textBSym.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.textBSym.Location = new System.Drawing.Point(421, 143);
            this.textBSym.Margin = new System.Windows.Forms.Padding(4);
            this.textBSym.Multiline = true;
            this.textBSym.Name = "textBSym";
            this.textBSym.Size = new System.Drawing.Size(436, 31);
            this.textBSym.TabIndex = 17;
            this.textBSym.Visible = false;
            // 
            // labelSym
            // 
            this.labelSym.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSym.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.labelSym.Location = new System.Drawing.Point(421, 105);
            this.labelSym.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSym.Name = "labelSym";
            this.labelSym.Size = new System.Drawing.Size(277, 34);
            this.labelSym.TabIndex = 16;
            this.labelSym.Text = "Efectos secundarios sufridos:";
            this.labelSym.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelSym.Visible = false;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label10.Location = new System.Drawing.Point(27, 110);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(309, 34);
            this.label10.TabIndex = 23;
            this.label10.Text = "Presenta efectos secundarios?";
            // 
            // checkBox2
            // 
            this.checkBox2.Enabled = false;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.checkBox2.Location = new System.Drawing.Point(27, 188);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(112, 33);
            this.checkBox2.TabIndex = 22;
            this.checkBox2.Text = "No";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.Enabled = false;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.checkBox1.Location = new System.Drawing.Point(27, 148);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(112, 33);
            this.checkBox1.TabIndex = 21;
            this.checkBox1.Text = "Si";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label7.Location = new System.Drawing.Point(148, 4);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(566, 71);
            this.label7.TabIndex = 15;
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Prechequeo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(891, 520);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.dataGridView1);
            this.Location = new System.Drawing.Point(15, 15);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Prechequeo";
            this.ShowIcon = false;
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).EndInit();
            this.TabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.Vacunacion.ResumeLayout(false);
            this.secDose.ResumeLayout(false);
            this.secDose.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DateTimePicker dateTimePicker5;

        private System.Windows.Forms.Button bttn_sendsym;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.Button SendSymt;

        private System.Windows.Forms.DateTimePicker TimePick;

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button secondAppointment;
        
        private System.Windows.Forms.Label labelSym;

        private System.Windows.Forms.TextBox textBSym;

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage secDose;
        private System.Windows.Forms.Label labelTime;

        private System.Windows.Forms.TabPage Vacunacion;

        private System.Windows.Forms.TabControl TabControl;

        private System.Windows.Forms.TabPage tabPage1;

        private System.Windows.Forms.DataGridView dataGridView1;

        private System.Windows.Forms.DateTimePicker datePickerSystem;


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