namespace Ejercicio3_Alumno
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
            panel1 = new Panel();
            txtNota = new TextBox();
            label5 = new Label();
            txtEdad = new TextBox();
            label4 = new Label();
            txtApellido = new TextBox();
            label3 = new Label();
            txtNombre = new TextBox();
            label2 = new Label();
            txtCarnet = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            dataGridViewAlumnos = new DataGridView();
            btnAgregarAmlumnp = new Button();
            bntPromedio = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAlumnos).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txtNota);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtEdad);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtApellido);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtCarnet);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(360, 382);
            panel1.TabIndex = 0;
            // 
            // txtNota
            // 
            txtNota.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtNota.Location = new Point(105, 244);
            txtNota.Name = "txtNota";
            txtNota.Size = new Size(233, 30);
            txtNota.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(44, 247);
            label5.Name = "label5";
            label5.Size = new Size(54, 23);
            label5.TabIndex = 8;
            label5.Text = "Nota:";
            // 
            // txtEdad
            // 
            txtEdad.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtEdad.Location = new Point(105, 188);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(233, 30);
            txtEdad.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(44, 191);
            label4.Name = "label4";
            label4.Size = new Size(55, 23);
            label4.TabIndex = 6;
            label4.Text = "Edad:";
            // 
            // txtApellido
            // 
            txtApellido.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtApellido.Location = new Point(105, 131);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(233, 30);
            txtApellido.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(16, 134);
            label3.Name = "label3";
            label3.Size = new Size(83, 23);
            label3.TabIndex = 4;
            label3.Text = "Apellido:";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtNombre.Location = new Point(105, 76);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(233, 30);
            txtNombre.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(18, 79);
            label2.Name = "label2";
            label2.Size = new Size(81, 23);
            label2.TabIndex = 2;
            label2.Text = "Nombre:";
            // 
            // txtCarnet
            // 
            txtCarnet.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtCarnet.Location = new Point(105, 18);
            txtCarnet.Name = "txtCarnet";
            txtCarnet.Size = new Size(233, 30);
            txtCarnet.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(31, 25);
            label1.Name = "label1";
            label1.Size = new Size(68, 23);
            label1.TabIndex = 0;
            label1.Text = "Carnet:";
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridViewAlumnos);
            panel2.Location = new Point(388, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(701, 376);
            panel2.TabIndex = 1;
            // 
            // dataGridViewAlumnos
            // 
            dataGridViewAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAlumnos.Location = new Point(4, 4);
            dataGridViewAlumnos.Name = "dataGridViewAlumnos";
            dataGridViewAlumnos.RowHeadersWidth = 51;
            dataGridViewAlumnos.RowTemplate.Height = 29;
            dataGridViewAlumnos.Size = new Size(678, 299);
            dataGridViewAlumnos.TabIndex = 0;
            // 
            // btnAgregarAmlumnp
            // 
            btnAgregarAmlumnp.BackColor = SystemColors.ActiveCaption;
            btnAgregarAmlumnp.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregarAmlumnp.Location = new Point(12, 330);
            btnAgregarAmlumnp.Margin = new Padding(0);
            btnAgregarAmlumnp.Name = "btnAgregarAmlumnp";
            btnAgregarAmlumnp.Size = new Size(360, 58);
            btnAgregarAmlumnp.TabIndex = 2;
            btnAgregarAmlumnp.Text = "Agregar ";
            btnAgregarAmlumnp.UseVisualStyleBackColor = false;
            btnAgregarAmlumnp.Click += btnAgregarAmlumnp_Click;
            // 
            // bntPromedio
            // 
            bntPromedio.BackColor = Color.FromArgb(0, 192, 0);
            bntPromedio.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            bntPromedio.Location = new Point(391, 330);
            bntPromedio.Margin = new Padding(0);
            bntPromedio.Name = "bntPromedio";
            bntPromedio.Size = new Size(679, 58);
            bntPromedio.TabIndex = 3;
            bntPromedio.Text = "Promedio de Notas";
            bntPromedio.UseVisualStyleBackColor = false;
            bntPromedio.Click += bntPromedio_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1101, 402);
            Controls.Add(bntPromedio);
            Controls.Add(btnAgregarAmlumnp);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Alumnos";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewAlumnos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtCarnet;
        private Label label1;
        private TextBox txtApellido;
        private Label label3;
        private TextBox txtNombre;
        private Label label2;
        private TextBox txtNota;
        private Label label5;
        private TextBox txtEdad;
        private Label label4;
        private Panel panel2;
        private Button btnAgregarAmlumnp;
        private Button bntPromedio;
        private DataGridView dataGridViewAlumnos;
    }
}