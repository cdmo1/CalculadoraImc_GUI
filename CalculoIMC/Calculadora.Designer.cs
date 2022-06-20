namespace CalculoIMC
{
    partial class Calculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculadora));
            this.Texto = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_idade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_altura = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_peso = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_sexo = new System.Windows.Forms.Label();
            this.lbl_idade = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_imc_desejavel = new System.Windows.Forms.Label();
            this.lbl_recomendacao = new System.Windows.Forms.Label();
            this.lbl_riscos = new System.Windows.Forms.Label();
            this.lbl_result_imc = new System.Windows.Forms.Label();
            this.lbl_imc = new System.Windows.Forms.Label();
            this.lbl_categoria = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_sexo = new System.Windows.Forms.TextBox();
            this.lbl_erro = new System.Windows.Forms.Label();
            this.lbl_erro2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Texto
            // 
            this.Texto.AutoSize = true;
            this.Texto.BackColor = System.Drawing.Color.Transparent;
            this.Texto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Texto.Location = new System.Drawing.Point(58, 80);
            this.Texto.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Texto.Name = "Texto";
            this.Texto.Size = new System.Drawing.Size(72, 24);
            this.Texto.TabIndex = 0;
            this.Texto.Text = "Nome:";
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(58, 122);
            this.txtnome.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(164, 26);
            this.txtnome.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 195);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sexo:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_idade
            // 
            this.txt_idade.Location = new System.Drawing.Point(607, 122);
            this.txt_idade.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txt_idade.Name = "txt_idade";
            this.txt_idade.Size = new System.Drawing.Size(164, 26);
            this.txt_idade.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(607, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Idade:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_altura
            // 
            this.txt_altura.Location = new System.Drawing.Point(328, 122);
            this.txt_altura.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txt_altura.Name = "txt_altura";
            this.txt_altura.Size = new System.Drawing.Size(164, 26);
            this.txt_altura.TabIndex = 11;
            this.txt_altura.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(340, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Altura:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt_peso
            // 
            this.txt_peso.Location = new System.Drawing.Point(347, 255);
            this.txt_peso.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txt_peso.Name = "txt_peso";
            this.txt_peso.Size = new System.Drawing.Size(164, 26);
            this.txt_peso.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(340, 195);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "Peso:";
            // 
            // btn_calcular
            // 
            this.btn_calcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calcular.Location = new System.Drawing.Point(587, 217);
            this.btn_calcular.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(242, 69);
            this.btn_calcular.TabIndex = 14;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = false;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.groupBox1.AutoSize = true;
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.lbl_sexo);
            this.groupBox1.Controls.Add(this.lbl_idade);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.lbl_imc_desejavel);
            this.groupBox1.Controls.Add(this.lbl_recomendacao);
            this.groupBox1.Controls.Add(this.lbl_riscos);
            this.groupBox1.Controls.Add(this.lbl_result_imc);
            this.groupBox1.Controls.Add(this.lbl_imc);
            this.groupBox1.Controls.Add(this.lbl_categoria);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(65, 378);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupBox1.Size = new System.Drawing.Size(967, 322);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resultado:";
            // 
            // lbl_sexo
            // 
            this.lbl_sexo.AutoSize = true;
            this.lbl_sexo.Location = new System.Drawing.Point(373, 92);
            this.lbl_sexo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_sexo.Name = "lbl_sexo";
            this.lbl_sexo.Size = new System.Drawing.Size(0, 20);
            this.lbl_sexo.TabIndex = 14;
            // 
            // lbl_idade
            // 
            this.lbl_idade.AutoSize = true;
            this.lbl_idade.Location = new System.Drawing.Point(373, 42);
            this.lbl_idade.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_idade.Name = "lbl_idade";
            this.lbl_idade.Size = new System.Drawing.Size(0, 20);
            this.lbl_idade.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(287, 92);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 20);
            this.label11.TabIndex = 12;
            this.label11.Text = "Sexo:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(287, 42);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 20);
            this.label10.TabIndex = 11;
            this.label10.Text = "Idade:";
            // 
            // lbl_imc_desejavel
            // 
            this.lbl_imc_desejavel.AutoSize = true;
            this.lbl_imc_desejavel.Location = new System.Drawing.Point(152, 92);
            this.lbl_imc_desejavel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_imc_desejavel.Name = "lbl_imc_desejavel";
            this.lbl_imc_desejavel.Size = new System.Drawing.Size(0, 20);
            this.lbl_imc_desejavel.TabIndex = 10;
            // 
            // lbl_recomendacao
            // 
            this.lbl_recomendacao.AutoSize = true;
            this.lbl_recomendacao.Location = new System.Drawing.Point(217, 238);
            this.lbl_recomendacao.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_recomendacao.Name = "lbl_recomendacao";
            this.lbl_recomendacao.Size = new System.Drawing.Size(0, 20);
            this.lbl_recomendacao.TabIndex = 9;
            // 
            // lbl_riscos
            // 
            this.lbl_riscos.AutoSize = true;
            this.lbl_riscos.Location = new System.Drawing.Point(98, 189);
            this.lbl_riscos.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_riscos.Name = "lbl_riscos";
            this.lbl_riscos.Size = new System.Drawing.Size(0, 20);
            this.lbl_riscos.TabIndex = 8;
            // 
            // lbl_result_imc
            // 
            this.lbl_result_imc.AutoSize = true;
            this.lbl_result_imc.Location = new System.Drawing.Point(153, 146);
            this.lbl_result_imc.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_result_imc.Name = "lbl_result_imc";
            this.lbl_result_imc.Size = new System.Drawing.Size(0, 20);
            this.lbl_result_imc.TabIndex = 7;
            // 
            // lbl_imc
            // 
            this.lbl_imc.AutoSize = true;
            this.lbl_imc.Location = new System.Drawing.Point(152, 92);
            this.lbl_imc.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_imc.Name = "lbl_imc";
            this.lbl_imc.Size = new System.Drawing.Size(0, 20);
            this.lbl_imc.TabIndex = 6;
            // 
            // lbl_categoria
            // 
            this.lbl_categoria.AutoSize = true;
            this.lbl_categoria.Location = new System.Drawing.Point(138, 42);
            this.lbl_categoria.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_categoria.Name = "lbl_categoria";
            this.lbl_categoria.Size = new System.Drawing.Size(0, 20);
            this.lbl_categoria.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 238);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(189, 20);
            this.label9.TabIndex = 4;
            this.label9.Text = "Recomendacao inicial:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 189);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "Riscos:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 92);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "IMC Desejavel:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 146);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Resultado IMC:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 42);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Categoria:";
            // 
            // txt_sexo
            // 
            this.txt_sexo.Location = new System.Drawing.Point(65, 255);
            this.txt_sexo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txt_sexo.Name = "txt_sexo";
            this.txt_sexo.Size = new System.Drawing.Size(164, 26);
            this.txt_sexo.TabIndex = 16;
            // 
            // lbl_erro
            // 
            this.lbl_erro.AutoSize = true;
            this.lbl_erro.BackColor = System.Drawing.Color.Transparent;
            this.lbl_erro.Location = new System.Drawing.Point(203, 329);
            this.lbl_erro.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_erro.Name = "lbl_erro";
            this.lbl_erro.Size = new System.Drawing.Size(0, 20);
            this.lbl_erro.TabIndex = 17;
            // 
            // lbl_erro2
            // 
            this.lbl_erro2.AutoSize = true;
            this.lbl_erro2.BackColor = System.Drawing.Color.Transparent;
            this.lbl_erro2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_erro2.ForeColor = System.Drawing.Color.Red;
            this.lbl_erro2.Location = new System.Drawing.Point(74, 329);
            this.lbl_erro2.Name = "lbl_erro2";
            this.lbl_erro2.Size = new System.Drawing.Size(0, 25);
            this.lbl_erro2.TabIndex = 18;
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1333, 692);
            this.Controls.Add(this.lbl_erro2);
            this.Controls.Add(this.lbl_erro);
            this.Controls.Add(this.txt_sexo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.txt_peso);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_altura);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_idade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.Texto);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Calculadora";
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Calculadora_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Texto;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_idade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_altura;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_peso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_recomendacao;
        private System.Windows.Forms.Label lbl_riscos;
        private System.Windows.Forms.Label lbl_result_imc;
        private System.Windows.Forms.Label lbl_imc;
        private System.Windows.Forms.Label lbl_categoria;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_imc_desejavel;
        private System.Windows.Forms.Label lbl_sexo;
        private System.Windows.Forms.Label lbl_idade;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_sexo;
        private System.Windows.Forms.Label lbl_erro;
        private System.Windows.Forms.Label lbl_erro2;
    }
}