using System;
using System.Windows.Forms;
using System.Globalization;

namespace TDSN2024
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmbForma_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarVisibCampos();
        }

        private void AtualizarVisibCampos()
        {
            ExibirRaio(cmbForma.Text == "Circunferência");
            ExibirLado(cmbForma.Text == "Quadrado");
            ExibirBase(cmbForma.Text == "Retângulo" || cmbForma.Text.Contains("Triângulo"));
            ExibirAltura(cmbForma.Text == "Retângulo" || cmbForma.Text.Contains("Triângulo"));
            ExibirTriangulo(cmbForma.Text == "Triângulo");
        }

        private void ExibirLado(bool visivel) => lblLado.Visible = txtLado.Visible = visivel;
        private void ExibirRaio(bool visivel) => lblRaio.Visible = txtRaio.Visible = visivel;
        private void ExibirBase(bool visivel) => lblBase.Visible = txtBase.Visible = visivel;
        private void ExibirAltura(bool visivel) => lblAltura.Visible = txtAltura.Visible = visivel;
        private void ExibirTriangulo(bool visivel) => lblTriangulo.Visible = cmbTriangulo.Visible = visivel;

        private void btnCriar_Click(object sender, EventArgs e)
        {
            FormaGeometrica objeto = CriarForma();
            if (objeto != null)
            {
                cmbObjetos.Items.Add(objeto);
                LimparCampos();
            }
        }

        private FormaGeometrica CriarForma()
        {
            try
            {
                switch (cmbForma.Text)
                {
                    case "Circunferência":
                        return new Circunferencia { Raio = double.Parse(txtRaio.Text, new CultureInfo("pt-BR")) };
                    case "Quadrado":
                        return new Quadrado { Lado = double.Parse(txtLado.Text, new CultureInfo("pt-BR")) };
                    case "Retângulo":
                        return new Retangulo { Base = double.Parse(txtBase.Text, new CultureInfo("pt-BR")), Altura = double.Parse(txtAltura.Text, new CultureInfo("pt-BR")) };
                    case "Triângulo":
                        return CriarTriangulo();
                    default:
                        return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao criar a forma: " + ex.Message);
                return null;
            }
        }

        private FormaGeometrica CriarTriangulo()
        {
            switch (cmbTriangulo.Text)
            {
                case "Equilátero":
                    return new TrianguloEquilatero { Base = double.Parse(txtBase.Text, new CultureInfo("pt-BR")), Altura = double.Parse(txtAltura.Text, new CultureInfo("pt-BR")) };
                case "Isósceles":
                    return new TrianguloIsosceles { Base = double.Parse(txtBase.Text, new CultureInfo("pt-BR")), Altura = double.Parse(txtAltura.Text, new CultureInfo("pt-BR")) };
                case "Reto":
                    return new TrianguloReto { Base = double.Parse(txtBase.Text, new CultureInfo("pt-BR")), Altura = double.Parse(txtAltura.Text, new CultureInfo("pt-BR")) };
                default:
                    throw new Exception("Selecione um tipo de triângulo");
            }
        }

        private void LimparCampos()
        {
            txtRaio.Clear();
            txtLado.Clear();
            txtBase.Clear();
            txtAltura.Clear();
        }

        private double ParseDouble(string texto)
        {
            return double.Parse(texto.Replace(',', '.'));
        }

        private void cmbObjetos_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormaGeometrica objeto = cmbObjetos.SelectedItem as FormaGeometrica;
            if (objeto != null)
            {
                txtArea.Text = objeto.CalcularArea().ToString();
                txtPerimetro.Text = objeto.CalcularPerimetro().ToString();
            }
        }
    }
}
