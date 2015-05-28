namespace WorklistViewer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tbAccNumFilter = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbNameFilter = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbDNIFilter = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.nMinutos = new System.Windows.Forms.NumericUpDown();
            this.nHora = new System.Windows.Forms.NumericUpDown();
            this.cbMedico = new System.Windows.Forms.ComboBox();
            this.tbModalidad = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tbReferente = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.tbAccessionNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTecnico = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.tbPeso = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.rbNSNC = new System.Windows.Forms.RadioButton();
            this.rbFemenino = new System.Windows.Forms.RadioButton();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbEdad = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbDNI = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvWorklist = new System.Windows.Forms.DataGridView();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nMinutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHora)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorklist)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox5.Controls.Add(this.tbAccNumFilter);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.tbNameFilter);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.tbDNIFilter);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.dateTimePicker1);
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Location = new System.Drawing.Point(511, 7);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(415, 129);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Filtro";
            // 
            // tbAccNumFilter
            // 
            this.tbAccNumFilter.Location = new System.Drawing.Point(80, 97);
            this.tbAccNumFilter.Name = "tbAccNumFilter";
            this.tbAccNumFilter.Size = new System.Drawing.Size(145, 20);
            this.tbAccNumFilter.TabIndex = 13;
            this.tbAccNumFilter.Text = "*";
            this.tbAccNumFilter.TextChanged += new System.EventHandler(this.tbAccNumFilter_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 97);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Acc. No.";
            // 
            // tbNameFilter
            // 
            this.tbNameFilter.Location = new System.Drawing.Point(80, 71);
            this.tbNameFilter.Name = "tbNameFilter";
            this.tbNameFilter.Size = new System.Drawing.Size(328, 20);
            this.tbNameFilter.TabIndex = 6;
            this.tbNameFilter.Text = "*";
            this.tbNameFilter.TextChanged += new System.EventHandler(this.tbNameFilter_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Nombre";
            // 
            // tbDNIFilter
            // 
            this.tbDNIFilter.Location = new System.Drawing.Point(80, 45);
            this.tbDNIFilter.Name = "tbDNIFilter";
            this.tbDNIFilter.Size = new System.Drawing.Size(145, 20);
            this.tbDNIFilter.TabIndex = 4;
            this.tbDNIFilter.Text = "*";
            this.tbDNIFilter.TextChanged += new System.EventHandler(this.tbDNIFilter_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "DNI";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(80, 19);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 22);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(37, 13);
            this.label18.TabIndex = 0;
            this.label18.Text = "Fecha";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.nMinutos);
            this.groupBox3.Controls.Add(this.nHora);
            this.groupBox3.Controls.Add(this.cbMedico);
            this.groupBox3.Controls.Add(this.tbModalidad);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.tbReferente);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.dtFecha);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.tbAccessionNumber);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.cbTecnico);
            this.groupBox3.Location = new System.Drawing.Point(511, 306);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(414, 153);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos del estudio";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(389, 49);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(21, 13);
            this.label20.TabIndex = 22;
            this.label20.Text = "hs.";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(341, 48);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(10, 13);
            this.label19.TabIndex = 21;
            this.label19.Text = ":";
            // 
            // nMinutos
            // 
            this.nMinutos.Enabled = false;
            this.nMinutos.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nMinutos.Location = new System.Drawing.Point(351, 45);
            this.nMinutos.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nMinutos.Name = "nMinutos";
            this.nMinutos.Size = new System.Drawing.Size(37, 20);
            this.nMinutos.TabIndex = 20;
            // 
            // nHora
            // 
            this.nHora.Enabled = false;
            this.nHora.Location = new System.Drawing.Point(304, 45);
            this.nHora.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nHora.Name = "nHora";
            this.nHora.Size = new System.Drawing.Size(37, 20);
            this.nHora.TabIndex = 19;
            // 
            // cbMedico
            // 
            this.cbMedico.Enabled = false;
            this.cbMedico.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbMedico.FormattingEnabled = true;
            this.cbMedico.Location = new System.Drawing.Point(80, 71);
            this.cbMedico.Name = "cbMedico";
            this.cbMedico.Size = new System.Drawing.Size(328, 21);
            this.cbMedico.TabIndex = 18;
            this.cbMedico.Text = "(No declarado)";
            // 
            // tbModalidad
            // 
            this.tbModalidad.Location = new System.Drawing.Point(304, 19);
            this.tbModalidad.Name = "tbModalidad";
            this.tbModalidad.ReadOnly = true;
            this.tbModalidad.Size = new System.Drawing.Size(104, 20);
            this.tbModalidad.TabIndex = 17;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(242, 22);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 13);
            this.label15.TabIndex = 16;
            this.label15.Text = "Modalidad";
            // 
            // tbReferente
            // 
            this.tbReferente.Enabled = false;
            this.tbReferente.Location = new System.Drawing.Point(80, 97);
            this.tbReferente.Name = "tbReferente";
            this.tbReferente.Size = new System.Drawing.Size(328, 20);
            this.tbReferente.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Referente";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Médico";
            // 
            // dtFecha
            // 
            this.dtFecha.CustomFormat = "yyyy/MM/dd HH:mm:ss";
            this.dtFecha.Enabled = false;
            this.dtFecha.Location = new System.Drawing.Point(80, 45);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(207, 20);
            this.dtFecha.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fecha";
            // 
            // tbAccessionNumber
            // 
            this.tbAccessionNumber.Enabled = false;
            this.tbAccessionNumber.Location = new System.Drawing.Point(80, 19);
            this.tbAccessionNumber.Name = "tbAccessionNumber";
            this.tbAccessionNumber.Size = new System.Drawing.Size(145, 20);
            this.tbAccessionNumber.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "N°";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Técnico";
            // 
            // cbTecnico
            // 
            this.cbTecnico.Enabled = false;
            this.cbTecnico.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbTecnico.FormattingEnabled = true;
            this.cbTecnico.Location = new System.Drawing.Point(80, 123);
            this.cbTecnico.MaxDropDownItems = 20;
            this.cbTecnico.Name = "cbTecnico";
            this.cbTecnico.Size = new System.Drawing.Size(328, 21);
            this.cbTecnico.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.dtNacimiento);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.tbPeso);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.rbNSNC);
            this.groupBox2.Controls.Add(this.rbFemenino);
            this.groupBox2.Controls.Add(this.rbMasculino);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.tbEdad);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.tbNombre);
            this.groupBox2.Controls.Add(this.tbDNI);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(511, 142);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(415, 158);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del paciente";
            // 
            // dtNacimiento
            // 
            this.dtNacimiento.CustomFormat = "";
            this.dtNacimiento.Enabled = false;
            this.dtNacimiento.Location = new System.Drawing.Point(80, 74);
            this.dtNacimiento.Name = "dtNacimiento";
            this.dtNacimiento.Size = new System.Drawing.Size(207, 20);
            this.dtNacimiento.TabIndex = 22;
            this.dtNacimiento.ValueChanged += new System.EventHandler(this.dtNacimiento_ValueChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(155, 132);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(28, 13);
            this.label17.TabIndex = 15;
            this.label17.Text = "Kgs.";
            // 
            // tbPeso
            // 
            this.tbPeso.Enabled = false;
            this.tbPeso.Location = new System.Drawing.Point(80, 127);
            this.tbPeso.Name = "tbPeso";
            this.tbPeso.Size = new System.Drawing.Size(69, 20);
            this.tbPeso.TabIndex = 14;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(9, 131);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(31, 13);
            this.label16.TabIndex = 13;
            this.label16.Text = "Peso";
            // 
            // rbNSNC
            // 
            this.rbNSNC.AutoSize = true;
            this.rbNSNC.Enabled = false;
            this.rbNSNC.Location = new System.Drawing.Point(290, 104);
            this.rbNSNC.Name = "rbNSNC";
            this.rbNSNC.Size = new System.Drawing.Size(60, 17);
            this.rbNSNC.TabIndex = 12;
            this.rbNSNC.TabStop = true;
            this.rbNSNC.Text = "NS/NC";
            this.rbNSNC.UseVisualStyleBackColor = true;
            // 
            // rbFemenino
            // 
            this.rbFemenino.AutoSize = true;
            this.rbFemenino.Enabled = false;
            this.rbFemenino.ForeColor = System.Drawing.Color.Fuchsia;
            this.rbFemenino.Location = new System.Drawing.Point(181, 104);
            this.rbFemenino.Name = "rbFemenino";
            this.rbFemenino.Size = new System.Drawing.Size(71, 17);
            this.rbFemenino.TabIndex = 11;
            this.rbFemenino.TabStop = true;
            this.rbFemenino.Text = "Femenino";
            this.rbFemenino.UseVisualStyleBackColor = true;
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Enabled = false;
            this.rbMasculino.ForeColor = System.Drawing.Color.RoyalBlue;
            this.rbMasculino.Location = new System.Drawing.Point(80, 102);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(73, 17);
            this.rbMasculino.TabIndex = 10;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 104);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 13);
            this.label14.TabIndex = 9;
            this.label14.Text = "Sexo";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(375, 78);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(33, 13);
            this.label13.TabIndex = 8;
            this.label13.Text = "años.";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 78);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Nacimiento";
            // 
            // tbEdad
            // 
            this.tbEdad.Location = new System.Drawing.Point(326, 74);
            this.tbEdad.Name = "tbEdad";
            this.tbEdad.ReadOnly = true;
            this.tbEdad.Size = new System.Drawing.Size(49, 20);
            this.tbEdad.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(293, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Edad";
            // 
            // tbNombre
            // 
            this.tbNombre.Enabled = false;
            this.tbNombre.Location = new System.Drawing.Point(80, 46);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(328, 20);
            this.tbNombre.TabIndex = 3;
            // 
            // tbDNI
            // 
            this.tbDNI.Enabled = false;
            this.tbDNI.Location = new System.Drawing.Point(80, 16);
            this.tbDNI.Name = "tbDNI";
            this.tbDNI.Size = new System.Drawing.Size(145, 20);
            this.tbDNI.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "DNI";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.dgvWorklist);
            this.groupBox1.Location = new System.Drawing.Point(8, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(497, 452);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Worklist";
            // 
            // dgvWorklist
            // 
            this.dgvWorklist.AllowUserToAddRows = false;
            this.dgvWorklist.AllowUserToDeleteRows = false;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvWorklist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvWorklist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvWorklist.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvWorklist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvWorklist.Location = new System.Drawing.Point(3, 16);
            this.dgvWorklist.MultiSelect = false;
            this.dgvWorklist.Name = "dgvWorklist";
            this.dgvWorklist.ReadOnly = true;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvWorklist.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvWorklist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWorklist.Size = new System.Drawing.Size(491, 433);
            this.dgvWorklist.TabIndex = 0;
            this.dgvWorklist.SelectionChanged += new System.EventHandler(this.dgvWorklist_SelectionChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(939, 476);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Worklist Viewer";
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nMinutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHora)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorklist)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox tbAccNumFilter;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbNameFilter;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbDNIFilter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.NumericUpDown nMinutos;
        private System.Windows.Forms.NumericUpDown nHora;
        private System.Windows.Forms.ComboBox cbMedico;
        private System.Windows.Forms.TextBox tbModalidad;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbReferente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbAccessionNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTecnico;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtNacimiento;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tbPeso;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.RadioButton rbNSNC;
        private System.Windows.Forms.RadioButton rbFemenino;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbEdad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbDNI;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvWorklist;
    }
}

