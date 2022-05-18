using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFLogin
{
    public partial class CadastroAluno : Form
    {
        public CadastroAluno()
        {
            InitializeComponent();
        }

        private void btnMostrarLista_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LUCAS\SQLEXPRESS;Initial Catalog=ServerCast;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from aluno",con);
            //cmd.Connection = con;
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            btnMostrarLista.Text = "Atualizar Lista de Alunos";
            con.Close();
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LUCAS\SQLEXPRESS;Initial Catalog=ServerCast;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand();

          
       
           // cmd.ExecuteNonQuery();
          




            if (rdbJava.Checked) {

                cmd.Parameters.AddWithValue("@NomeAluno", txtNome.Text);
                cmd.Parameters.AddWithValue("@Rg", txtRg.Text);
                cmd.Parameters.AddWithValue("@Turma", rdbJava.Text);
                cmd.CommandText = "insert into aluno(NomeAluno,Rg,Turma) values (@NomeAluno,@Rg,@turma)";
                cmd.Connection = con;
                cmd.ExecuteNonQuery();

                
                MessageBox.Show("Cadastrado com sucesso!");
                txtNome.Clear();
                txtRg.Clear();
                rdbJava.Checked = false;


            }
            if (rdbNet.Checked)
            {

                cmd.Parameters.AddWithValue("@NomeAluno", txtNome.Text);
                cmd.Parameters.AddWithValue("@Rg", txtRg.Text);
                cmd.Parameters.AddWithValue("@Turma", rdbNet.Text);
                cmd.CommandText = "insert into aluno(NomeAluno,Rg,Turma) values (@NomeAluno,@Rg,@turma)";
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                txtNome.Clear();
                txtRg.Clear();
                rdbNet.Checked = false;

                MessageBox.Show("Cadastrado com sucesso!");
              


            }
            if(!rdbNet.Checked && !rdbJava.Checked)
            {
                MessageBox.Show("Escolha uma turma para o Aluno");
            }
            
            



        }

        private void rdbNet_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LUCAS\SQLEXPRESS;Initial Catalog=ServerCast;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand();

            if (rdbJava.Checked)
            {

                cmd.Parameters.AddWithValue("@NomeAluno", txtNome.Text);
                cmd.Parameters.AddWithValue("@Rg", txtRg.Text);
                cmd.Parameters.AddWithValue("@Turma", rdbJava.Text);
               
               

                cmd.CommandText = "update aluno set NomeAluno=@NomeAluno, Rg=@Rg, Turma=@Turma where Rg = @Rg";
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Atualizado com sucesso!");
                txtNome.Clear();
                txtRg.Clear();
                rdbJava.Checked = false;


            }
            if (rdbNet.Checked)
            {

                cmd.Parameters.AddWithValue("@NomeAluno", txtNome.Text);
                cmd.Parameters.AddWithValue("@Rg", txtRg.Text);
                cmd.Parameters.AddWithValue("@Turma", rdbNet.Text);
                cmd.CommandText = "update aluno set NomeAluno=@NomeAluno, Rg=@Rg, Turma=@Turma where Rg = @Rg";
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                txtNome.Clear();
                txtRg.Clear();
                rdbNet.Checked = false;

                MessageBox.Show("Atualizado com sucesso!");



            }
            if (!rdbNet.Checked && !rdbJava.Checked)
            {
                MessageBox.Show("Escolha uma turma para o Aluno");
            }





        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LUCAS\SQLEXPRESS;Initial Catalog=ServerCast;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand();



            cmd.Parameters.AddWithValue("@NomeAluno", txtNome.Text);
            cmd.Parameters.AddWithValue("@Rg", txtRg.Text);
            cmd.Parameters.AddWithValue("@Turma", rdbJava.Text);



            cmd.CommandText = "delete from aluno where Rg = @Rg";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Deletado com sucesso!");
            txtNome.Clear();
            txtRg.Clear();
        }
    }
}
