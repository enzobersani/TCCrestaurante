using MySql.Data.MySqlClient;
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
    public partial class ListaProduto : Form
    {
        private MySqlConnection Conexao;
        private string data_source = "Server = localhost; Database=restaurantetcc;Uid=root;Pwd=";

        public ListaProduto()
        {
            InitializeComponent();

            lstProduto.View = View.Details;
            lstProduto.LabelEdit = true;
            lstProduto.AllowColumnReorder = true;
            lstProduto.FullRowSelect = true;
            lstProduto.GridLines = true;

            lstProduto.Columns.Add("Código", 70, HorizontalAlignment.Left);
            lstProduto.Columns.Add("Produto", 200, HorizontalAlignment.Left);
            lstProduto.Columns.Add("Descrição", 200, HorizontalAlignment.Left);
            lstProduto.Columns.Add("Valor Unit.", 200, HorizontalAlignment.Left);
            lstProduto.Columns.Add("Qt. Estoque", 200, HorizontalAlignment.Left);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string q = "'%" + txtProduto.Text + "%'";

                Conexao = new MySqlConnection(data_source);

                string sql = "SELECT * " +
                            "FROM produto " +
                            "WHERE nomeProduto LIKE " + q;

                Conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, Conexao);

                MySqlDataReader reader = comando.ExecuteReader();

                lstProduto.Items.Clear();

                while (reader.Read())
                {
                    string[] row =
                    {
                        reader.GetString(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(3),
                        reader.GetString(4)
                    };

                    var linha_listview = new ListViewItem(row);

                    lstProduto.Items.Add(linha_listview);
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

        private void button3_Click(object sender, EventArgs e)
        {
            var codigo = txtCodigoProduto.Text;

            if (txtCodigoProduto.Text != "")
            {
                try
                {

                    Conexao = new MySqlConnection(data_source);

                    string sql = "SELECT * " +
                                "FROM produto " +
                                "WHERE id =" + codigo;

                    Conexao.Open();

                    MySqlCommand comando = new MySqlCommand(sql, Conexao);

                    MySqlDataReader reader = comando.ExecuteReader();

                    lstProduto.Items.Clear();

                    while (reader.Read())
                    {
                        string[] row =
                        {
                        reader.GetString(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(3),
                        reader.GetString(4)
                    };

                        var linha_listview = new ListViewItem(row);

                        lstProduto.Items.Add(linha_listview);
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

                Conexao = new MySqlConnection(data_source);

                string sql = "SELECT * FROM produto";

                Conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, Conexao);

                MySqlDataReader reader = comando.ExecuteReader();

                lstProduto.Items.Clear();

                while (reader.Read())
                {
                    string[] row =
                    {
                        reader.GetString(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(3),
                        reader.GetString(4)
                    };

                    var linha_listview = new ListViewItem(row);

                    lstProduto.Items.Add(linha_listview);

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

        private void ListaProduto_Load(object sender, EventArgs e)
        {
            try
            {

                Conexao = new MySqlConnection(data_source);

                string sql = "SELECT * FROM produto";

                Conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, Conexao);

                MySqlDataReader reader = comando.ExecuteReader();

                lstProduto.Items.Clear();

                while (reader.Read())
                {
                    string[] row =
                    {
                        reader.GetString(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(3),
                        reader.GetString(4)
                    };

                    var linha_listview = new ListViewItem(row);

                    lstProduto.Items.Add(linha_listview);

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

        private void button4_Click(object sender, EventArgs e)
        {
            FrmRelProdutos frmRelProdutos = new FrmRelProdutos();
            frmRelProdutos.Show();
        }
    }
}
