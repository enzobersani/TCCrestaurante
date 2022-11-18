using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TccRestaurante
{
    public partial class Caixa : Form
    {
        public Caixa()
        {
            InitializeComponent();
        }

        private MySqlConnection Conexao;
        private string data_source = "Server = localhost; Database=restaurantetcc;Uid=root;Pwd=";

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //new TelaGerarRelatorioVenda().Show();
            //this.Hide();
            TelaGerarRelatorioVenda telaGerarRelatorioVenda = new TelaGerarRelatorioVenda();
            telaGerarRelatorioVenda.ShowDialog();
        }

        private void txtCodigoFuncionario_Leave(object sender, EventArgs e)
        {
            try
            {
                string codigo = txtCodigoFuncionario.Text;

                Conexao = new MySqlConnection(data_source);

                string sql = "SELECT * " +
                            "FROM funcionario " +
                            "WHERE id=" + codigo;

                Conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, Conexao);
                
                MySqlDataReader reader = comando.ExecuteReader();

                if (reader.Read())
                {
                    txtDescricaoFuncionario.Text = reader.GetString(1);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.Close();
            }
        }

        private void txtProduto1_Leave(object sender, EventArgs e)
        {
            try
            {
                string codigo = txtProduto1.Text;

                Conexao = new MySqlConnection(data_source);

                string sql = "SELECT * " +
                            "FROM produto " +
                            "WHERE id=" + codigo;

                Conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, Conexao);

                MySqlDataReader reader = comando.ExecuteReader();

                if (reader.Read())
                {
                    txtDesc1.Text = reader.GetString(1);
                    txtValor1.Text = reader.GetString(3);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.Close();
            }
        }

        private void txtProduto2_Leave(object sender, EventArgs e)
        {
            try
            {
                string codigo = txtProduto2.Text;

                Conexao = new MySqlConnection(data_source);

                string sql = "SELECT * " +
                            "FROM produto " +
                            "WHERE id=" + codigo;

                Conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, Conexao);

                MySqlDataReader reader = comando.ExecuteReader();

                if (reader.Read())
                {
                    txtDesc2.Text = reader.GetString(1);
                    txtValor2.Text = reader.GetString(3);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.Close();
            }
        }

        private void txtProduto3_Leave(object sender, EventArgs e)
        {
            try
            {
                string codigo = txtProduto3.Text;

                Conexao = new MySqlConnection(data_source);

                string sql = "SELECT * " +
                            "FROM produto " +
                            "WHERE id=" + codigo;

                Conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, Conexao);

                MySqlDataReader reader = comando.ExecuteReader();

                if (reader.Read())
                {
                    txtDesc3.Text = reader.GetString(1);
                    txtValor3.Text = reader.GetString(3);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.Close();
            }
        }

        private void txtProduto4_Leave(object sender, EventArgs e)
        {
            try
            {
                string codigo = txtProduto4.Text;

                Conexao = new MySqlConnection(data_source);

                string sql = "SELECT * " +
                            "FROM produto " +
                            "WHERE id=" + codigo;

                Conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, Conexao);

                MySqlDataReader reader = comando.ExecuteReader();

                if (reader.Read())
                {
                    txtDesc4.Text = reader.GetString(1);
                    txtValor4.Text = reader.GetString(3);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.Close();
            }
        }

        private void txtProduto5_Leave(object sender, EventArgs e)
        {
            try
            {
                string codigo = txtProduto5.Text;

                Conexao = new MySqlConnection(data_source);

                string sql = "SELECT * " +
                            "FROM produto " +
                            "WHERE id=" + codigo;

                Conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, Conexao);

                MySqlDataReader reader = comando.ExecuteReader();

                if (reader.Read())
                {
                    txtDesc5.Text = reader.GetString(1);
                    txtValor5.Text = reader.GetString(3);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.Close();
            }
        }

        private void txtProduto6_Leave(object sender, EventArgs e)
        {
            try
            {
                string codigo = txtProduto6.Text;

                Conexao = new MySqlConnection(data_source);

                string sql = "SELECT * " +
                            "FROM produto " +
                            "WHERE id=" + codigo;

                Conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, Conexao);

                MySqlDataReader reader = comando.ExecuteReader();

                if (reader.Read())
                {
                    txtDesc6.Text = reader.GetString(1);
                    txtValor6.Text = reader.GetString(3);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.Close();
            }
        }

        private void txtProduto7_Leave(object sender, EventArgs e)
        {
            try
            {
                string codigo = txtProduto7.Text;

                Conexao = new MySqlConnection(data_source);

                string sql = "SELECT * " +
                            "FROM produto " +
                            "WHERE id=" + codigo;

                Conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, Conexao);

                MySqlDataReader reader = comando.ExecuteReader();

                if (reader.Read())
                {
                    txtDesc7.Text = reader.GetString(1);
                    txtValor7.Text = reader.GetString(3);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.Close();
            }
        }

        private void txtQtTotal_TextChanged(object sender, EventArgs e)
        {
            {
                int valor1, valor2, valor3, valor4, valor5, valor6, valor7, resultado;
                valor1 = Convert.ToInt32(txtValor1.Text);
                valor2 = Convert.ToInt32(txtValor2.Text);
                valor3 = Convert.ToInt32(txtValor3.Text);
                valor4 = Convert.ToInt32(txtValor4.Text);
                valor5 = Convert.ToInt32(txtValor5.Text);
                valor6 = Convert.ToInt32(txtValor6.Text);
                valor7 = Convert.ToInt32(txtValor7.Text);
                resultado = valor1 + valor2 + valor3 + valor4 + valor5 + valor6 + valor7;
                txtQtTotal.Text = resultado.ToString();
            }
        }
    }
}
