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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void lblEsqueciSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open link that was clicked.");
            }
        }
        private void VisitLink()
        {
          

            lblEsqueciSenha.LinkVisited = true;
           
            System.Diagnostics.Process.Start("https://whats.link/suporteticast");
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LUCAS\SQLEXPRESS;Initial Catalog=ServerCast;Integrated Security=True");
            con.Open();
            SqlDataReader dr; 
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            

            cmd.Parameters.AddWithValue("@email",txtEmail.Text);
            cmd.Parameters.AddWithValue("@senha", txtSenha.Text);
            cmd.CommandText = "Select * from Entrar where email = @email and senha = @senha";
          
            dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                CadastroAluno c = new CadastroAluno();
                c.ShowDialog();
            }
            else
            {
                MessageBox.Show("Senha Incorreta! Tente Novamente ou Clique em Esqueci a Senha", "Tente novamente");
            }

            con.Close();
        }
    }
   
}
