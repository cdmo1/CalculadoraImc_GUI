using System;
using System.Windows.Forms;

namespace CalculoIMC
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Calculadora_Load(object sender, EventArgs e)
        {

        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            double peso, altura, imc, imcOut;
            int idade;
            string categoria, imcDesejavel, riscos, recomendacao, sexo, nome;
            string erro = "", idadeR;


            nome = Convert.ToString(txtnome);
            idade = int.Parse(txt_idade.Text);
            peso = double.Parse(txt_peso.Text);
            altura = double.Parse(txt_altura.Text);
            sexo = Convert.ToString(txt_sexo.Text);
            imc = (peso / (altura * altura));
            idadeR = Convert.ToString(idade);
            imcOut = Math.Round(imc, 2); //Utilizacao de metodo C# para "cortar" casa decimal

            if (idade > 0 && idade < 12)
            {
                categoria = "Infantil";
            }
            else if ((idade >= 12) && (idade <= 20))
            {
                categoria = "Juvenil";
            }
            else if ((idade >= 21) && (idade <= 65))
            {
                categoria = "Adulto";
            }
            else
            {
                categoria = "Idoso";
            }


            if (idade < 20)
            {
                imcDesejavel = "abaixo de 20";
            }
            else if ((idade >= 20) && (idade < 25))
            {
                imcDesejavel = "entre 20 e 24";
            }
            else if ((idade >= 25) && (idade < 30))
            {
                imcDesejavel = "entre 25 e 29";
            }
            else if ((idade >= 30) && (idade < 36))
            {
                imcDesejavel = "entre 30 e 35";
            }
            else
            {
                imcDesejavel = "acima de 35";
            }


            if (imc < 20)
            {
                riscos = "Muitas complicações de saúde como doenças pulmonares e cardiovasculares podem estar associadas ao baixo peso.";
            }
            else if ((imc >= 20) && (imc < 25))
            {
                riscos = "Seu peso está ideal para suas referências.";
            }
            else if ((imc >= 25) && (imc < 30))
            {
                riscos = "Aumento de peso apresenta risco moderado para outras doenças crônicas e cardiovasculares.";
            }
            else if ((imc >= 30) && (imc < 35))
            {
                riscos = "Aumento de peso apresenta risco moderado para outras doenças crônicas e cardiovasculares.";
            }
            else
            {
                riscos = "O obeso mórbido vive menos, tem alto risco de mortalidade geral por diversas causas.";
            }



            if (imc < 20)
            {
                recomendacao = "Inclua carboidratos simples em sua dieta, além de proteínas - indispensáveis para ganho de massa magra.Procure um profissional.";
            }
            else if ((imc >= 20) && (imc < 25))
            {
                recomendacao = "Mantenha uma dieta saudável e faça seus exames periódicos.";
            }
            else if ((imc >= 25) && (imc < 30))
            {
                recomendacao = "Adote um tratamento baseado em dieta balanceada, exercício físico e medicação.A ajuda de um profissional pode ser interessante.";
            }
            else if ((imc >= 30) && (imc < 35))
            {
                recomendacao = "Adote uma dieta alimentar rigorosa, com o acompanhamento de um nutricionista e um médico especialista(endócrino).";
            }
            else
            {
                recomendacao = "Procure com urgência o acompanhamento de um nutricionista para realizar reeducação alimentar, um psicólogo e um médico especialista(endócrino).";
            }




            string sexo2 = "";
            if (sexo.ToLower() == "masculino")
            {
                sexo2 = "Masculino";
            }
            else if (sexo.ToLower() == "feminino")
            {
                sexo2 = "Feminino";
            }
            else
            {
                erro = ("Voce digitou um sexo invalido, digite conforme as especificacoes (masculino ou feminino)......");
                MessageBox.Show(erro);
            }



            //Validacao de Idade
            if (idade <= 0 || idadeR == null)
            {
                erro = "Por favor digite uma idade valido!";
                MessageBox.Show(erro);

            }


            //Validacao de nome
            if (nome == "")
            {
                erro = "Por favor digite um nome valido!";
                MessageBox.Show(erro);

            }



            //Validacao de altura
            if (altura <= 0)
            {
                erro = "Por favor digite uma altura valida!";
                MessageBox.Show(erro);

            }

            //Validacao de Peso
            if (peso <= 0)
            {
                erro = "Por favor digite um peso valida!";
                MessageBox.Show(erro);
            }


            lbl_sexo.Text = Convert.ToString(sexo2);
            lbl_idade.Text = Convert.ToString(idade);
            lbl_recomendacao.Text = Convert.ToString(recomendacao);
            lbl_riscos.Text = Convert.ToString(riscos);
            lbl_imc_desejavel.Text = Convert.ToString(imcDesejavel);
            lbl_categoria.Text = Convert.ToString(categoria);
            lbl_result_imc.Text = Convert.ToString(imcOut);
        }
    }
}
