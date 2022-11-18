using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1;
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

namespace TccRestaurante
{
    public partial class ListaFuncionario : Form
    {
        public ListaFuncionario()
        {
            InitializeComponent();

            lstFuncionario.View = View.Details;
            lstFuncionario.LabelEdit = true;
            lstFuncionario.AllowColumnReorder = true;
            lstFuncionario.FullRowSelect = true;
            lstFuncionario.GridLines = true;

            lstFuncionario.Columns.Add("Código",70, HorizontalAlignment.Left);
            lstFuncionario.Columns.Add("Nome", 200, HorizontalAlignment.Left);
            lstFuncionario.Columns.Add("Cpf", 200, HorizontalAlignment.Left);
            lstFuncionario.Columns.Add("Email", 200, HorizontalAlignment.Left);

            carregar_dados();
        }

        MySqlConnection Conexao = null;
        private string strCon = "Server = localhost; Database=restaurantetcc;Uid=root;Pwd=";

        private void txtCodigoUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void carregar_dados()
        {
            try
            {
                Conexao = new MySqlConnection(strCon);
                Conexao.Open();

                MySqlCommand comando = new MySqlCommand();

                comando.Connection = Conexao;
                comando.CommandText = "SELECT * FROM funcionario ORDER BY id DESC";
                comando.Prepare();

                MySqlDataReader reader = comando.ExecuteReader();

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
 

        private void button1_Click(object sender, EventArgs e)
        {

            var codigo = txtCodigoFuncionario.Text;

            if (txtCodigoFuncionario.Text != "")
            {
                string sql = "SELECT * FROM funcionario WHERE id =" + codigo;
                Conexao = new MySqlConnection(strCon);
                MySqlCommand comando = new MySqlCommand(sql, Conexao);


                try
                {
                    Conexao.Open();
                    MySqlDataReader reader = comando.ExecuteReader();

                    lstFuncionario.Items.Clear();

                    while (reader.Read())
                    {
                        string[] row =
                        {
                            reader.GetString(0),
                            reader.GetString(1),
                            reader.GetString(2),
                            reader.GetString(3),
                        };

                        var linha_listview = new ListViewItem(row);

                        lstFuncionario.Items.Add(linha_listview);

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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string q = "'%" + txtNomeFuncionario.Text + "%'";

                Conexao = new MySqlConnection(strCon);

                string sql = "SELECT * FROM funcionario WHERE nome LIKE " + q;

                Conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, Conexao);

                MySqlDataReader reader = comando.ExecuteReader();

                lstFuncionario.Items.Clear();

                while (reader.Read())
                {
                    string[] row =
                    {
                        reader.GetString(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(3),
                    };

                    var linha_listview = new ListViewItem(row);

                    lstFuncionario.Items.Add(linha_listview);

                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally 
            {
                Conexao.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                Conexao = new MySqlConnection(strCon);

                string sql = "SELECT * FROM funcionario";

                Conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, Conexao);

                MySqlDataReader reader = comando.ExecuteReader();

                lstFuncionario.Items.Clear();

                while (reader.Read())
                {
                    string[] row =
                    {
                        reader.GetString(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(3),
                    };

                    var linha_listview = new ListViewItem(row);

                    lstFuncionario.Items.Add(linha_listview);

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

        private void ListaFuncionario_Load(object sender, EventArgs e)
        {
            try
            {
                Conexao = new MySqlConnection(strCon);

                string sql = "SELECT * FROM funcionario";

                Conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, Conexao);

                MySqlDataReader reader = comando.ExecuteReader();

                lstFuncionario.Items.Clear();

                while (reader.Read())
                {
                    string[] row =
                    {
                        reader.GetString(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(3),
                    };

                    var linha_listview = new ListViewItem(row);

                    lstFuncionario.Items.Add(linha_listview);

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

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult confirmar = MessageBox.Show("Deseja realmente excluir o registro?", "", MessageBoxButtons.YesNo, 
                    MessageBoxIcon.Warning);

                if (confirmar == DialogResult.Yes)
                {
                    MessageBox.Show("Funcionário excluido com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    carregar_dados();
                }


            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocorreu um erro!");
            }
            finally
            {
                Conexao.Close();
            }
        }
    }
}
