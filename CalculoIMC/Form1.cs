using System;
using System.Windows.Forms;

namespace CalculoIMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var calc = new Calculadora();
            this.Hide();
            MessageBox.Show("Digite as informacoes no seguinte formato:\n" +
                "Altura: 1,80\n" + "Peso: 80kg\n" + "Idade: 25\n" + "Nome: Joao\n"+ "Sexo: Masculino");
            calc.Show();


        }
    }
}
