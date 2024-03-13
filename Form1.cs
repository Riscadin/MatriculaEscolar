using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatriculaEscolar
{
    public partial class Form1 : Form
    {

        int matricula = 0;
        


        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }



        private void btnEncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAdicionarUsuario_Click(object sender, EventArgs e)
        {
            //Console.WriteLine("Data de nascimento: " + clienteA.DataNascimento.Day + "/" + clienteA.DataNascimento.Month + "/" + clienteA.DataNascimento.Year);
            //string data1 = Console.ReadLine();
            //clienteA.DataNascimento = DateTime.Parse(data1);



            if (!mskTBoxCpf.MaskCompleted || !mskTBoxDataNasc.MaskCompleted || gpBoxTurno.Text == "" || !mskTBoxCodigoTurma.MaskCompleted || txtBoxCurso.Text == "" || !mskTBoxRG.MaskCompleted )
            {
                string msg = ("ALGUNS CAMPOS NECESSÁRIOS ESTÃO EM BRANCO");
                string titulo = "CAMPO EM BRANCO";
                var result = MessageBox.Show(msg, titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if(!txtBoxEmail.Text.Contains('@') && !txtBoxEmail.Text.Contains('.'))
            {
                string msg = ("Email está incompleto");
                string titulo = "EMAIL ERRADO";
                var result = MessageBox.Show(msg, titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {



                string nome = txtBoxNome.Text;
                string sobrenome = txtBoxSobrenome.Text;
                string rg = mskTBoxRG.Text;
                string cpf = mskTBoxCpf.Text;
                string dataNas = mskTBoxDataNasc.Text;
                DateTime dataNascimento = DateTime.Parse(dataNas);
                string email = txtBoxEmail.Text;
                string numeroCelular = mskTBoxNumCelular.Text;
                string codigo = mskTBoxCodigoTurma.Text;
                int codigoTurma = int.Parse(codigo);
                string curso = txtBoxCurso.Text;

                dtGrid.Rows.Add(txtBoxMatricula.Text, mskTBoxCodigoTurma.Text, txtBoxCurso.Text, gpBoxTurno.Text, txtBoxNome.Text, txtBoxSobrenome.Text, mskTBoxRG.Text, mskTBoxCpf.Text,(dataNascimento.Day+"/"+dataNascimento.Month+"/"+dataNascimento.Year), txtBoxEmail.Text, mskTBoxNumCelular.Text, gpBoxSexo.Text);
                matricula += 1;
                txtBoxMatricula.Text = matricula.ToString();

                MessageBox.Show("ALUNO MATRICULADO !!");


            }






            
         
            



        }

        private void rdBtnMasc_CheckedChanged(object sender, EventArgs e)
        {
            gpBoxSexo.Text = "Masculino";
        }

        private void rdBtnFemi_CheckedChanged(object sender, EventArgs e)
        {
            gpBoxSexo.Text = "Feminino";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            matricula += 1;
            txtBoxMatricula.Text = matricula.ToString();
        }

        private void rdBtnMatutino_CheckedChanged(object sender, EventArgs e)
        {
            gpBoxTurno.Text = "Matutino";
        }

        private void rdBtnVespertino_CheckedChanged(object sender, EventArgs e)
        {
            gpBoxTurno.Text = "Vespertino";
        }

        private void rdBtnNoturno_CheckedChanged(object sender, EventArgs e)
        {
            gpBoxTurno.Text = "Noturno";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {


            txtBoxNome.Text = "";
            txtBoxSobrenome.Text = "";
            mskTBoxRG.Text = "";
            mskTBoxCpf.Text = "";
            mskTBoxDataNasc.Text = "";
            txtBoxEmail.Text = "";
            mskTBoxNumCelular.Text = "";
            rdBtnFemi.Checked = false;
            rdBtnMasc.Checked = false;
            rdBtnMatutino.Checked = false;
            rdBtnNoturno.Checked = false;
            rdBtnVespertino.Checked = false;
            mskTBoxCodigoTurma.Text = "";
            txtBoxCurso.Text = "";

        }

        private void btnExcluirUsuario_Click(object sender, EventArgs e)
        {


           
        }

        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {


            //// Verificar se uma célula está selecionada
            //if (dtGrid.SelectedCells.Count > 0)
            //{
            //    // Obter a célula selecionada
            //    DataGridViewCell cell = dtGrid.SelectedCells[0];

            //    // Permitir a edição da célula selecionada
            //    dtGrid.BeginEdit(true);


              





            //}
            //else
            //{
            //    MessageBox.Show("Selecione algo antes de editar.", "Aviso");
            //}

        }

        private void dtGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dtGrid__CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //string newValue = dtGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            //MessageBox.Show($"Novo valor: {newValue}");
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximized_Click(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState=FormWindowState.Normal;
            }

        }
    }
}


    


    
        

