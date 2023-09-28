namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        int tipoFigura;
        int opcionCircuferencia;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbSelectFigura.SelectedIndex = 0;
        }

        private void cmbSelectFigura_SelectedIndexChanged(object sender, EventArgs e)
        {
            tipoFigura = cmbSelectFigura.SelectedIndex;
            if (tipoFigura == 0)
            {
                this.panelRectangulo.Visible = true;
                this.panelCirculo.Visible = false;
                this.panelOpCircunferencia.Visible = false;
                this.panelMedidaRadio.Visible = false;
                this.panelMedidaCircuferencia.Visible = false;
            }
            else if (tipoFigura == 1)
            {
                this.panelCirculo.Visible = false;
                this.panelRectangulo.Visible = false;
                this.panelOpCircunferencia.Visible = true;
                this.panelMedidaRadio.Visible = false;
                this.panelMedidaCircuferencia.Visible = false;
                cmbOpcionCirculo.SelectedIndex = 0;
                this.panelMedidaRadio.Visible = true;
            }

        }

        public void areaFigura()
        {
            if (tipoFigura == 0)
            {
                Rectangulo objRectangulo = new Rectangulo();
                objRectangulo.Altura = double.Parse(txtAltura.Text);
                objRectangulo.Basee = double.Parse(txtBase.Text);
                objRectangulo.Area = objRectangulo.CalcularArea();
                MessageBox.Show("EL area es: " + objRectangulo.Area.ToString("N2"));
            }
            else if (tipoFigura == 1)
            {
                if (opcionCircuferencia == 0)
                {
                    Circulo objCirculo = new Circulo();
                    objCirculo.Radio = double.Parse(txtMedidaRadio.Text);
                    objCirculo.Area = objCirculo.CalcularArea();
                    MessageBox.Show($"EL area es: " + objCirculo.Area.ToString("N2"));

                }
                else if (opcionCircuferencia == 1)
                {
                    double circunferencia = double.Parse(txtMedidaCircunferencia.Text);
                    Circulo objCirculo = new Circulo(circunferencia);
                    objCirculo.Area = objCirculo.CalcularArea();
                    MessageBox.Show($"EL area es: " + objCirculo.Area.ToString("N2"));
                }

            }
        }

        private void cmbOpcionCirculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            opcionCircuferencia = cmbOpcionCirculo.SelectedIndex;
            if (opcionCircuferencia == 0)
            {
                this.panelMedidaRadio.Visible = true;
                this.panelMedidaCircuferencia.Visible = false;
            }
            else if (opcionCircuferencia == 1)
            {
                this.panelMedidaRadio.Visible = false;
                this.panelMedidaCircuferencia.Visible = true;
            }

        }

        private void btnCalcularArea_Click(object sender, EventArgs e)
        {
            areaFigura();
        }
    }
}