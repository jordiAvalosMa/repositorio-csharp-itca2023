namespace Ejercicio1
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
            selectFigura = new Label();
            panelSelectFigura = new Panel();
            panelCirculo = new Panel();
            cmbRadioOcircuferencia = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            cmbSelectFigura = new ComboBox();
            panelRectangulo = new Panel();
            txtBase = new TextBox();
            label3 = new Label();
            txtAltura = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtMedidaRadio = new TextBox();
            panelOpCircunferencia = new Panel();
            label7 = new Label();
            cmbOpcionCirculo = new ComboBox();
            label8 = new Label();
            Radio = new Label();
            panelMedidaRadio = new Panel();
            panelMedidaCircuferencia = new Panel();
            label4 = new Label();
            txtMedidaCircunferencia = new TextBox();
            btnCalcularArea = new Button();
            panelSelectFigura.SuspendLayout();
            panelCirculo.SuspendLayout();
            panelRectangulo.SuspendLayout();
            panelOpCircunferencia.SuspendLayout();
            panelMedidaRadio.SuspendLayout();
            panelMedidaCircuferencia.SuspendLayout();
            SuspendLayout();
            // 
            // selectFigura
            // 
            selectFigura.AutoSize = true;
            selectFigura.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            selectFigura.Location = new Point(3, 4);
            selectFigura.Name = "selectFigura";
            selectFigura.Size = new Size(145, 20);
            selectFigura.TabIndex = 0;
            selectFigura.Text = "Seleccione la Figura";
            // 
            // panelSelectFigura
            // 
            panelSelectFigura.Controls.Add(panelCirculo);
            panelSelectFigura.Controls.Add(cmbSelectFigura);
            panelSelectFigura.Controls.Add(selectFigura);
            panelSelectFigura.Location = new Point(11, 5);
            panelSelectFigura.Name = "panelSelectFigura";
            panelSelectFigura.Size = new Size(323, 73);
            panelSelectFigura.TabIndex = 1;
            // 
            // panelCirculo
            // 
            panelCirculo.Controls.Add(cmbRadioOcircuferencia);
            panelCirculo.Controls.Add(label5);
            panelCirculo.Controls.Add(label6);
            panelCirculo.Location = new Point(0, 66);
            panelCirculo.Name = "panelCirculo";
            panelCirculo.Size = new Size(341, 101);
            panelCirculo.TabIndex = 5;
            // 
            // cmbRadioOcircuferencia
            // 
            cmbRadioOcircuferencia.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            cmbRadioOcircuferencia.FormattingEnabled = true;
            cmbRadioOcircuferencia.Items.AddRange(new object[] { "Radio", "Circuferencia" });
            cmbRadioOcircuferencia.Location = new Point(20, 60);
            cmbRadioOcircuferencia.Name = "cmbRadioOcircuferencia";
            cmbRadioOcircuferencia.Size = new Size(296, 31);
            cmbRadioOcircuferencia.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(17, 32);
            label5.Name = "label5";
            label5.Size = new Size(227, 23);
            label5.TabIndex = 1;
            label5.Text = "Como vas a calcular el area?";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(58, 10);
            label6.Name = "label6";
            label6.Size = new Size(202, 23);
            label6.TabIndex = 0;
            label6.Text = "Calcular Area de Circulo";
            // 
            // cmbSelectFigura
            // 
            cmbSelectFigura.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            cmbSelectFigura.FormattingEnabled = true;
            cmbSelectFigura.Items.AddRange(new object[] { "Rectangulo", "Circulo" });
            cmbSelectFigura.Location = new Point(9, 30);
            cmbSelectFigura.Name = "cmbSelectFigura";
            cmbSelectFigura.Size = new Size(296, 31);
            cmbSelectFigura.TabIndex = 1;
            cmbSelectFigura.SelectedIndexChanged += cmbSelectFigura_SelectedIndexChanged;
            // 
            // panelRectangulo
            // 
            panelRectangulo.Controls.Add(txtBase);
            panelRectangulo.Controls.Add(label3);
            panelRectangulo.Controls.Add(txtAltura);
            panelRectangulo.Controls.Add(label2);
            panelRectangulo.Controls.Add(label1);
            panelRectangulo.Location = new Point(12, 81);
            panelRectangulo.Name = "panelRectangulo";
            panelRectangulo.Size = new Size(322, 137);
            panelRectangulo.TabIndex = 2;
            // 
            // txtBase
            // 
            txtBase.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtBase.Location = new Point(67, 97);
            txtBase.Name = "txtBase";
            txtBase.Size = new Size(235, 30);
            txtBase.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(6, 104);
            label3.Name = "label3";
            label3.Size = new Size(49, 23);
            label3.TabIndex = 3;
            label3.Text = "Base:";
            // 
            // txtAltura
            // 
            txtAltura.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtAltura.Location = new Point(67, 48);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(235, 30);
            txtAltura.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(6, 55);
            label2.Name = "label2";
            label2.Size = new Size(60, 23);
            label2.TabIndex = 1;
            label2.Text = "Altura:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(38, 10);
            label1.Name = "label1";
            label1.Size = new Size(236, 23);
            label1.TabIndex = 0;
            label1.Text = "Calcular Area de Rectangulo";
            // 
            // txtMedidaRadio
            // 
            txtMedidaRadio.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtMedidaRadio.Location = new Point(86, 9);
            txtMedidaRadio.Name = "txtMedidaRadio";
            txtMedidaRadio.Size = new Size(235, 30);
            txtMedidaRadio.TabIndex = 2;
            // 
            // panelOpCircunferencia
            // 
            panelOpCircunferencia.Controls.Add(label7);
            panelOpCircunferencia.Controls.Add(cmbOpcionCirculo);
            panelOpCircunferencia.Controls.Add(label8);
            panelOpCircunferencia.Location = new Point(5, 68);
            panelOpCircunferencia.Name = "panelOpCircunferencia";
            panelOpCircunferencia.Size = new Size(344, 101);
            panelOpCircunferencia.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(9, 33);
            label7.Name = "label7";
            label7.Size = new Size(201, 23);
            label7.TabIndex = 6;
            label7.Text = "Como calcularas el Area?";
            // 
            // cmbOpcionCirculo
            // 
            cmbOpcionCirculo.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            cmbOpcionCirculo.FormattingEnabled = true;
            cmbOpcionCirculo.Items.AddRange(new object[] { "Radio", "Circuferencia" });
            cmbOpcionCirculo.Location = new Point(18, 59);
            cmbOpcionCirculo.Name = "cmbOpcionCirculo";
            cmbOpcionCirculo.Size = new Size(296, 31);
            cmbOpcionCirculo.TabIndex = 6;
            cmbOpcionCirculo.SelectedIndexChanged += cmbOpcionCirculo_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(23, 3);
            label8.Name = "label8";
            label8.Size = new Size(282, 23);
            label8.TabIndex = 0;
            label8.Text = "Calcular  Area de la Circuferencia?";
            // 
            // Radio
            // 
            Radio.AutoSize = true;
            Radio.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Radio.Location = new Point(12, 12);
            Radio.Name = "Radio";
            Radio.Size = new Size(72, 23);
            Radio.TabIndex = 3;
            Radio.Text = "Medida:";
            // 
            // panelMedidaRadio
            // 
            panelMedidaRadio.Controls.Add(Radio);
            panelMedidaRadio.Controls.Add(txtMedidaRadio);
            panelMedidaRadio.Location = new Point(5, 175);
            panelMedidaRadio.Name = "panelMedidaRadio";
            panelMedidaRadio.Size = new Size(341, 52);
            panelMedidaRadio.TabIndex = 7;
            // 
            // panelMedidaCircuferencia
            // 
            panelMedidaCircuferencia.Controls.Add(label4);
            panelMedidaCircuferencia.Controls.Add(txtMedidaCircunferencia);
            panelMedidaCircuferencia.Location = new Point(5, 173);
            panelMedidaCircuferencia.Name = "panelMedidaCircuferencia";
            panelMedidaCircuferencia.Size = new Size(355, 71);
            panelMedidaCircuferencia.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(12, 12);
            label4.Name = "label4";
            label4.Size = new Size(72, 23);
            label4.TabIndex = 3;
            label4.Text = "Medida:";
            // 
            // txtMedidaCircunferencia
            // 
            txtMedidaCircunferencia.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtMedidaCircunferencia.Location = new Point(86, 9);
            txtMedidaCircunferencia.Name = "txtMedidaCircunferencia";
            txtMedidaCircunferencia.Size = new Size(235, 30);
            txtMedidaCircunferencia.TabIndex = 2;
            // 
            // btnCalcularArea
            // 
            btnCalcularArea.BackColor = Color.FromArgb(0, 192, 192);
            btnCalcularArea.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnCalcularArea.ForeColor = SystemColors.ButtonHighlight;
            btnCalcularArea.Location = new Point(11, 269);
            btnCalcularArea.Name = "btnCalcularArea";
            btnCalcularArea.Size = new Size(360, 51);
            btnCalcularArea.TabIndex = 9;
            btnCalcularArea.Text = "Calcular";
            btnCalcularArea.UseVisualStyleBackColor = false;
            btnCalcularArea.Click += btnCalcularArea_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(383, 332);
            Controls.Add(panelSelectFigura);
            Controls.Add(btnCalcularArea);
            Controls.Add(panelMedidaRadio);
            Controls.Add(panelOpCircunferencia);
            Controls.Add(panelRectangulo);
            Controls.Add(panelMedidaCircuferencia);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Ejercicio 1 - Calcular Area";
            Load += Form1_Load;
            panelSelectFigura.ResumeLayout(false);
            panelSelectFigura.PerformLayout();
            panelCirculo.ResumeLayout(false);
            panelCirculo.PerformLayout();
            panelRectangulo.ResumeLayout(false);
            panelRectangulo.PerformLayout();
            panelOpCircunferencia.ResumeLayout(false);
            panelOpCircunferencia.PerformLayout();
            panelMedidaRadio.ResumeLayout(false);
            panelMedidaRadio.PerformLayout();
            panelMedidaCircuferencia.ResumeLayout(false);
            panelMedidaCircuferencia.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label selectFigura;
        private Panel panelSelectFigura;
        private ComboBox cmbSelectFigura;
        private Panel panelRectangulo;
        private Label label1;
        private TextBox txtAltura;
        private Label label2;
        private TextBox txtBase;
        private Label label3;
        private Panel panelCirculo;
        private TextBox txtMedidaRadio;
        private Label label5;
        private Label label6;
        private ComboBox cmbRadioOcircuferencia;
        private Panel panelOpCircunferencia;
        private Label Radio;
        private Label label8;
        private Label label7;
        private ComboBox cmbOpcionCirculo;
        private Panel panelMedidaRadio;
        private Panel panelMedidaCircuferencia;
        private Label label4;
        private TextBox txtMedidaCircunferencia;
        private Button btnCalcularArea;
    }
}