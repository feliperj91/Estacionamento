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

namespace Estacionamento
{
    public partial class Frm_CadastrarVeiculo : Form
    {
        public Frm_CadastrarVeiculo()
        {
            InitializeComponent();
        }

        private void Btn_Gravar_Click(object sender, EventArgs e)
        {
            //Criada String de Conexão com o Banco de Dados
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-90QEV66;Initial Catalog=TESTE;Integrated Security=True");

            //String para inserção SQL
            string sql = "INSERT INTO Tb_Veiculo(ID, Proprietario, Celular, Email, Bloco, Apartamento) VALUES (@ID, @Proprietario, @Celular, @Email, @Bloco, @Apartamento)";

            //Criando numero random para ID
            int numeroID = 1;
            numeroID++;

            try
            {
                //Cria um objeto passando como parametro os argumentos conn e sql
                SqlCommand c = new SqlCommand(sql, conn);

                //Insere os dados no comando SQL
                c.Parameters.Add(new SqlParameter("@ID", numeroID));
                c.Parameters.Add(new SqlParameter("@Proprietario", Txt_NomeProprietario.Text));
                c.Parameters.Add(new SqlParameter("@Celular", Txt_Celular.Text));
                c.Parameters.Add(new SqlParameter("@Email", Txt_Email.Text));
                c.Parameters.Add(new SqlParameter("@Bloco", Txt_Bloco.Text));
                c.Parameters.Add(new SqlParameter("@Apartamento", Txt_Apartamento.Text));

                //Abre a conexão com o banco de dados
                conn.Open();

                //Executa o comando SQL no banco de dados
                c.ExecuteNonQuery();

                //Fecha conexão com o banco de dados
                conn.Close();

                MessageBox.Show("Dados Gravados com Sucesso!");




            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro ao gravar: " + ex);
            }

            finally
            {
                conn.Close();
            }


        }
    }
}
