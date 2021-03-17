using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using aulaTransacaoA.Model;
using aulaTransacaoA.Controller;
using MySql.Data.MySqlClient;

namespace aulaTransacaoA
{
    public partial class Form1 : Form
    {
        string h = null, u = null, p = null, d = null;
        int port = 0;

        int sexo = 2;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
               DadosConexao dadosConexao = new DadosConexao(h, u, p, d, port);
               ConexaoBD conexaoBD = new ConexaoBD(dadosConexao);
               try
               {
                   if (conexaoBD.conectar())
                   {
                       MessageBox.Show("Conectou!", "Aplicação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       conexaoBD.desconectar();
                   }
                   else
                   {
                       MessageBox.Show("Não conectou!", "Aplicação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   }
               }
               catch (Exception ex)
               {
                   MessageBox.Show("Erro na conexão com o banco de dados: " + ex.ToString(),
                                       "Aplicação",
                                       MessageBoxButtons.OK,
                                       MessageBoxIcon.Error);
               }            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DadosConexao dadosConexao = new DadosConexao(h, u, p, d, port);
            ConexaoBD conexaoBD = new ConexaoBD(dadosConexao);
            cb_listapessoas.Items.Clear();
            try
            {
                if (conexaoBD.conectar())
                {
                    string sql = "SELECT * FROM pessoa ORDER BY nome LIMIT 100";
                    MySqlCommand comando = new MySqlCommand(sql, conexaoBD.conexao);
                    MySqlDataReader dr = comando.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            ComboboxItem item = new ComboboxItem();
                            item.Text = dr["nome"].ToString().ToUpper();
                            item.Value = dr["id_pessoa"].ToString();
                            cb_listapessoas.Items.Add(item);
                        }
                        MessageBox.Show("Pesquisa concluída!", "Aplicação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    dr.Dispose();
                    dr.Close();
                    conexaoBD.desconectar();
                }
                else
                {
                    MessageBox.Show("Não conectou!!!", "Aplicação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar pessoas no banco de dados: " + ex.ToString(),
                                    "Aplicação",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (cb_listapessoas.SelectedIndex >= 0)
            {
                ComboboxItem item = (cb_listapessoas.SelectedItem as ComboboxItem);
                //MessageBox.Show("Id_pessoa: " + item.Value.ToString(),"Aplicação",MessageBoxButtons.OK, MessageBoxIcon.Information);
                try
                {
                    DadosConexao dadosConexao = new DadosConexao(h, u, p, d, port);
                    ConexaoBD conexaoBD = new ConexaoBD(dadosConexao);
                    if (conexaoBD.conectar())
                    {
                        string sql = "select *, func_idade(dt_nascimento) idade from pessoa where id_pessoa = " + item.Value.ToString();
                        MySqlCommand comando = new MySqlCommand(sql, conexaoBD.conexao);
                        MySqlDataReader dr = comando.ExecuteReader();
                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                string resposta = "A pessoa " + item.Text + " tem " + dr["idade"].ToString() + " anos de idade.";
                                MessageBox.Show(resposta, "Aplicação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao buscar idade de pessoas no banco de dados: " + ex.ToString(),
                                    "Aplicação",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Nenhum registro selecionado.", "Aplicação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MySqlTransaction transacao = null;
            bool iniTransacao = false;
            DadosConexao dadosConexao = new DadosConexao(h, u, p, d, port);
            ConexaoBD conexaoBD = new ConexaoBD(dadosConexao);
            if (cb_listapessoas.SelectedIndex >= 0)
            {
                try
                {
                    ComboboxItem item = (cb_listapessoas.SelectedItem as ComboboxItem);
                    if (conexaoBD.conectar())
                    {
                        transacao = conexaoBD.conexao.BeginTransaction(IsolationLevel.RepeatableRead);
                        iniTransacao = true;
                        //testar se a pessoa já é aluno
                        string sql = "SELECT COUNT(*) qte FROM aluno WHERE id_pessoa = " + item.Value.ToString();
                        MySqlCommand comando = new MySqlCommand(sql, conexaoBD.conexao);
                        MySqlDataReader dr = comando.ExecuteReader();
                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                int qte = int.Parse(dr["qte"].ToString());
                                if (qte > 0)
                                {
                                    MessageBox.Show("Esta pessoa já é aluno. Verifique!", "Aplicação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    iniTransacao = false;
                                }
                            }
                        }
                        dr.Dispose();
                        dr.Close();

                        //criar mensagem para testar transação:
                        sql = "INSERT INTO mensagens(id_aluno, dt_mensagem, mensagem) VALUES(1, now(), 'OI!');";
                        comando = new MySqlCommand(sql, conexaoBD.conexao);
                        comando.ExecuteNonQuery();

                        //caso não for, inserir:
                        if (iniTransacao)
                        {
                            sql = "INSERT INTO aluno(dt_cadastro, id_pessoa) VALUES(now(), " + item.Value.ToString() + ")";
                            comando = new MySqlCommand(sql, conexaoBD.conexao);
                            comando.ExecuteNonQuery();
                            transacao.Commit();
                            MessageBox.Show("Pessoa " + item.Text.ToString() + " inserida como aluno.", "Aplicação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            transacao.Rollback();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao inserir novo aluno!\n" + ex.ToString(),
                                    "Aplicação",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    if (iniTransacao)
                    {
                        transacao.Rollback();
                    }
                }
                finally
                {
                    conexaoBD.desconectar();
                }
            }
            else
            {
                MessageBox.Show("Nenhum registro selecionado.", "Aplicação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            h = txt_hostname.Text; //hostname
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            u = txt_user.Text.Trim(); //user
        }

        private void txt_cpf_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_dtnasc_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void rbtn_masculino_CheckedChanged(object sender, EventArgs e)
        {
            sexo = 1;
        }

        private void rbtn_feminino_CheckedChanged(object sender, EventArgs e)
        {
            sexo = 0;
        }

        private void btn_inserirpessoa_Click(object sender, EventArgs e)
        {
            DadosConexao dadosConexao = new DadosConexao(h, u, p, d, port);
            ConexaoBD conexaoBD = new ConexaoBD(dadosConexao);

            try 
            {
                if (conexaoBD.conectar())
                {
                    string sql = "INSERT INTO escola.pessoa(nome, cpf, dt_nascimento, sexo) VALUES('" +
                    txt_nome.Text.Trim() + "', '" + txt_cpf.Text.Trim() + "', '" + txt_dtnasc.Text.Trim() + "', " + sexo + ");";

                    if (txt_nome.Text.Trim() == "" || txt_cpf.Text.Trim() == "" || txt_dtnasc.Text.Trim() == "" || sexo == 2)
                    {
                        MessageBox.Show("Preencha todos os campos antes de inserir a pessoa!", "Aplicação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        MySqlCommand inserir = new MySqlCommand(sql, conexaoBD.conexao);
                        inserir.Connection = conexaoBD.conexao;
                        inserir.ExecuteNonQuery();
                        MessageBox.Show("Pessoa inserida com sucesso!", "Aplicação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        conexaoBD.desconectar();
                    }
                }
                else
                {
                    MessageBox.Show("Não conectou ao banco de dados!", "Aplicação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir pessoa: " + ex.ToString(), "Aplicação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            h = "localhost"; u = "root"; p = null; d = "escola"; port = 3306;
        }

        private void txt_nome_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_criarprofessor_Click(object sender, EventArgs e)
        {
            MySqlTransaction transacao = null;
            bool iniTransacao = false;
            DadosConexao dadosConexao = new DadosConexao(h, u, p, d, port);
            ConexaoBD conexaoBD = new ConexaoBD(dadosConexao);
            if(cb_listapessoas.SelectedIndex >= 0)
            {
                try
                {
                    ComboboxItem item = (cb_listapessoas.SelectedItem as ComboboxItem);
                    
                    if (conexaoBD.conectar())
                    {
                        transacao = conexaoBD.conexao.BeginTransaction(IsolationLevel.RepeatableRead);
                        iniTransacao = true;

                        string sql = "select count(*) qte from professor where id_pessoa = " + item.Value.ToString();
                        MySqlCommand comando = new MySqlCommand(sql, conexaoBD.conexao);
                        MySqlDataReader datareader = comando.ExecuteReader();
                        if (datareader.HasRows)
                        {
                            while (datareader.Read())
                            {
                                int qte = int.Parse(datareader["qte"].ToString());
                                if(qte > 0)
                                {
                                    MessageBox.Show("Esta pessoa já é um professor!", "Aplicação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    iniTransacao = false;
                                }
                            }
                        }
                        datareader.Dispose();
                        datareader.Close();
                        if (iniTransacao)
                        {                             
                            sql = "insert into professor(formacao, id_pessoa) values('Pessoa inserida via forms', " + item.Value.ToString() + ")";
                            comando = new MySqlCommand(sql, conexaoBD.conexao);
                            comando.ExecuteNonQuery();
                            transacao.Commit();
                            MessageBox.Show("Professor cadastrado com sucesso!", "Aplicação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            transacao.Rollback();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Erro ao conectar!", "Aplicação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Erro ao criar professor: " + ex.ToString(), "Aplicação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (iniTransacao)
                    {
                        transacao.Rollback();
                    }
                }
                finally
                {
                    conexaoBD.desconectar();
                }
            }
            else
            {
                MessageBox.Show("Nenhum registro selecionado", "Aplicação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void cb_listapessoas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btn_buscaalunos_Click(object sender, EventArgs e)
        {
            DadosConexao dadosConexao = new DadosConexao(h, u, p, d, port);
            ConexaoBD conexaoBD = new ConexaoBD(dadosConexao);
            cb_alunos.Items.Clear();
            
            if (conexaoBD.conectar())
            {
                try
                {
                    string sql = "select *, nome from aluno join pessoa where aluno.id_pessoa = pessoa.id_pessoa order by nome limit 100";
                    MySqlCommand comando = new MySqlCommand(sql, conexaoBD.conexao);
                    MySqlDataReader datareader = comando.ExecuteReader();
                    if (datareader.HasRows)
                    {
                        while (datareader.Read())
                        {
                            ComboboxItem item = new ComboboxItem();
                            item.Text = datareader["nome"].ToString().ToUpper();
                            item.Value = datareader["id_aluno"].ToString();
                            cb_alunos.Items.Add(item);
                        }
                        MessageBox.Show("Pesquisa concluída!", "Aplicação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    datareader.Dispose();
                    datareader.Close();
                    conexaoBD.desconectar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao buscar alunos no banco de dados: " + ex.ToString(), "Aplicação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Erro ao conectar!", "Aplicação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }

        private void btn_buscaprofessores_Click(object sender, EventArgs e)
        {
            DadosConexao dadosConexao = new DadosConexao(h, u, p, d, port);
            ConexaoBD conexaoBD = new ConexaoBD(dadosConexao);
            cb_professores.Items.Clear();

            if (conexaoBD.conectar())
            {
                try
                {
                    string sql = "select *, nome from professor join pessoa where professor.id_pessoa = pessoa.id_pessoa order by nome limit 100";
                    MySqlCommand comando = new MySqlCommand(sql, conexaoBD.conexao);
                    MySqlDataReader datareader = comando.ExecuteReader();
                    if (datareader.HasRows)
                    {
                        while (datareader.Read())
                        {
                            ComboboxItem item = new ComboboxItem();
                            item.Text = datareader["nome"].ToString().ToUpper();
                            item.Value = datareader["id_professor"].ToString();
                            cb_professores.Items.Add(item);
                        }
                        MessageBox.Show("Pesquisa concluída!", "Aplicação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    datareader.Dispose();
                    datareader.Close();
                    conexaoBD.desconectar();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Erro ao buscar professores no banco de dados: " + ex.ToString(), "Aplicação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Erro ao conectar!", "Aplicação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_excluiraluno_Click(object sender, EventArgs e)
        {
            DadosConexao dadosConexao = new DadosConexao(h, u, p, d, port);
            ConexaoBD conexaoBD = new ConexaoBD(dadosConexao);
            if(cb_alunos.SelectedIndex >= 0)
            {
                try
                {
                    if (conexaoBD.conectar())
                    {





                        MessageBox.Show("Aluno removido com sucesso!", "Aplicação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        conexaoBD.desconectar();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao conectar!", "Aplicação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao remover aluno do banco de dados: " + ex.ToString(), "Aplicação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Nenhum registro selecionado!", "Aplicação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }            
        }

        private void btn_excluirprofessor_Click(object sender, EventArgs e)
        {
            DadosConexao dadosConexao = new DadosConexao(h, u, p, d, port);
            ConexaoBD conexaoBD = new ConexaoBD(dadosConexao);
            if(cb_professores.SelectedIndex >= 0)
            {
                try
                {
                    if (conexaoBD.conectar())
                    {





                        MessageBox.Show("Professor removido com sucesso!", "Aplicação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        conexaoBD.desconectar();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao conectar!", "Aplicação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Erro ao remover professor do banco de dados: " + ex.ToString(), "Aplicação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Nenhum registro selecionado!", "Aplicação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            p = txt_password.Text.Trim(); //password
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            d = txt_database.Text.Trim(); //database                                      
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            port = Convert.ToInt32(txt_port.Text.Trim()); //port
        }

    }

    //criar objeto comboboxItem
    public class ComboboxItem
    {
        public string Text { get; set; }
        public object Value { get; set; }
        public override string ToString()
        {
            return Text;
        }

    }

}