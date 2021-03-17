using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using trabalhoBD2.Controller;
using trabalhoBD2.Model;
using MySql.Data.MySqlClient;
using System.Globalization;

namespace trabalhoBD2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool validarTela()
        {
            bool resposta = true;
            if (textHost.Text.Trim().Length == 0)
            {
                MessageBox.Show("Atenção! Endereço Host do Banco de Dados em branco. Verifique!", "Trabalho BD2", MessageBoxButtons.OK, MessageBoxIcon.Error);
                resposta = false;
            }
            if (textUser.Text.Trim().Length == 0 && resposta)
            {
                MessageBox.Show("Atenção! Usuário de conexão com o Banco de Dados em branco. Verifique!", "Trabalho BD2", MessageBoxButtons.OK, MessageBoxIcon.Error);
                resposta = false;
            }
            /*if (textPass.Text.Trim().Length == 0 && resposta)
            {
                MessageBox.Show("Atenção! Senha de conexão com o Banco de Dados em branco. Verifique!", "Trabalho BD2", MessageBoxButtons.OK, MessageBoxIcon.Error);
                resposta = false;
            }*/
            if (textNomeBanco.Text.Trim().Length == 0 && resposta)
            {
                MessageBox.Show("Atenção! Nome do Banco de Dados em branco. Verifique!", "Trabalho BD2", MessageBoxButtons.OK, MessageBoxIcon.Error);
                resposta = false;
            }
            if (textPort.Text.Trim().Length == 0 && resposta)
            {
                textPort.Text = "3306";
            }
            return resposta;
        }

        public bool validarBD(int tipo = 0)
        {
            string[] txtResult = new string[11];
            string sql = "";
            MySqlCommand comando = null;
            MySqlDataReader dr = null;
            ConexaoBD conexaoBD = null;
            int existeProcedures = 0;
            int existeFunctions = 0;
            int existeTrigger = 0;
            bool resposta = false;
            if (testarConexao())
            {
                conexaoBD = new ConexaoBD(montarDados());
                try
                {                    
                    if (conexaoBD.conectar())
                    {
                        txtResult[0] = "- Proc_qteFuncionarios - NÃO";
                        txtResult[1] = "- Proc_qteFuncionariosCPFinv - NÃO";
                        txtResult[2] = "- func_folhaPagtoDepartamento - NÃO";
                        txtResult[3] = "- func_idade - NÃO";
                        txtResult[4] = "- func_mediaIdadeDepartamento - NÃO";
                        txtResult[5] = "- func_qteFuncionarioSexo - NÃO";
                        txtResult[6] = "- func_salarioMedio - NÃO";
                        txtResult[7] = "- func_salarioMedioDepartamento - NÃO";
                        txtResult[8] = "- func_somaSalarioTemp - NÃO";
                        txtResult[9] = "- func_validaCPF - NÃO";
                        txtResult[10] = "- trg_reajusteCargo - NÃO";

                        sql = "SHOW PROCEDURE STATUS WHERE Db = 'empresa'";
                        comando = new MySqlCommand(sql, conexaoBD.conexao);
                        dr = comando.ExecuteReader();
                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                switch (dr["Name"].ToString().Trim().ToUpper())
                                {
                                    case "PROC_QTEFUNCIONARIOS":
                                        txtResult[0] = "- Proc_qteFuncionarios - OK";
                                        existeProcedures++;
                                        break;
                                    case "PROC_QTEFUNCIONARIOSCPFINV":
                                        txtResult[1] = "- Proc_qteFuncionariosCPFinv - OK";
                                        existeProcedures++;
                                        break;
                                }
                            }
                        }
                        dr.Dispose();
                        dr.Close();

                        sql = "SHOW FUNCTION STATUS WHERE Db = 'empresa'";
                        comando = new MySqlCommand(sql, conexaoBD.conexao);
                        dr = comando.ExecuteReader();
                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                switch (dr["Name"].ToString().Trim().ToUpper())
                                {
                                    case "FUNC_FOLHAPAGTODEPARTAMENTO":
                                        txtResult[2] = "- func_folhaPagtoDepartamento - OK";
                                        existeFunctions++;
                                        break;
                                    case "FUNC_IDADE":
                                        txtResult[3] = "- func_idade - OK";
                                        existeFunctions++;
                                        break;
                                    case "FUNC_MEDIAIDADEDEPARTAMENTO":
                                        txtResult[4] = "- func_mediaIdadeDepartamento - OK";
                                        existeFunctions++;
                                        break;
                                    case "FUNC_QTEFUNCIONARIOSEXO":
                                        txtResult[5] = "- func_qteFuncionarioSexo - OK";
                                        existeFunctions++;
                                        break;
                                    case "FUNC_SALARIOMEDIO":
                                        txtResult[6] = "- func_salarioMedio - OK";
                                        existeFunctions++;
                                        break;
                                    case "FUNC_SALARIOMEDIODEPARTAMENTO":
                                        txtResult[7] = "- func_salarioMedioDepartamento - OK";
                                        existeFunctions++;
                                        break;
                                    case "FUNC_SOMASALARIOTEMP":
                                        txtResult[8] = "- func_somaSalarioTemp - OK";
                                        existeFunctions++;
                                        break;
                                    case "FUNC_VALIDACPF":
                                        txtResult[9] = "- func_validaCPF - OK";
                                        existeFunctions++;
                                        break;
                                }
                            }
                        }
                        dr.Dispose();
                        dr.Close();

                        sql = "SHOW TRIGGERS";
                        comando = new MySqlCommand(sql, conexaoBD.conexao);
                        dr = comando.ExecuteReader();
                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                switch (dr["Trigger"].ToString().Trim().ToUpper())
                                {
                                    case "TRG_REAJUSTECARGO":
                                        txtResult[10] = "- trg_reajusteCargo - OK";
                                        existeTrigger++;
                                        break;                                    
                                }
                            }
                        }
                        dr.Dispose();
                        dr.Close();

                        if (existeProcedures == 2 && existeFunctions == 8 && existeTrigger == 1)
                            resposta = true;

                    }
                    conexaoBD.desconectar();
                }
                catch (Exception ex)
                {
                    resposta = false;
                    MessageBox.Show("Erro ao buscar dados do banco de dados (01):\n" + ex.ToString(),
                                    "Trabalho BD2",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
            }
            if (tipo == 1)
            {
                foreach (string texto in txtResult)
                {
                    if(txtValiidarBD.Text.Trim().Length > 0) txtValiidarBD.Text = txtValiidarBD.Text + "\r\n";
                    txtValiidarBD.Text = txtValiidarBD.Text + texto;
                }
            }
            return resposta;
        }

        public DadosConexao montarDados()
        {
            DadosConexao dadosConexao = new DadosConexao(
                textHost.Text.Trim(),
                textUser.Text.Trim(),
                textPass.Text.Trim(),
                textNomeBanco.Text.Trim(),
                int.Parse(textPort.Text.Trim()));
            return dadosConexao;

        }

        private bool testarConexao()
        {
            bool resposta = true;
            if (validarTela())
            {
                ConexaoBD conexaoBD = new ConexaoBD(montarDados());
                try
                {
                    if (conexaoBD.conectar())
                    {
                        conexaoBD.desconectar();
                    }
                    else
                    {
                        resposta = false;
                    }
                }
                catch (Exception ex)
                {
                    resposta = false;
                    MessageBox.Show("Erro ao testar conexão com o Banco de Dados(b):\n" + ex.ToString(),
                                    "Trabalho BD2",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
            }
            else
            {
                resposta = false;
            }
            return resposta;
        }

        private void btnTestarConexao_Click(object sender, EventArgs e)
        {
            if (validarTela())
            {
                ConexaoBD conexaoBD = new ConexaoBD(montarDados());
                try
                {
                    if (conexaoBD.conectar())
                    {
                        MessageBox.Show("Conexão realizada com sucesso!!!", "Trabalho BD2", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        conexaoBD.desconectar();
                    }
                    else
                    {
                        MessageBox.Show("Conexão não realizada!", "Trabalho BD2", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao testar conexão com o Banco de Dados:\n" + ex.ToString(),
                                    "Trabalho BD2",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
            }
        }

        private void btnFecharAplicacao_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnFuncCadastrados_Click(object sender, EventArgs e)
        {
            String sql = "";
            int resposta = 0;
            MySqlCommand comando = null;
            MySqlDataReader dr = null;
            ConexaoBD conexaoBD = null;
            if (validarBD())
            {
                conexaoBD = new ConexaoBD(montarDados());
                try
                {
                    if (conexaoBD.conectar())
                    {
                        sql = "CALL proc_qteFuncionarios(0)";
                        comando = new MySqlCommand(sql, conexaoBD.conexao);
                        dr = comando.ExecuteReader();
                        if (dr.HasRows)
                        {
                            if (dr.Read())
                            {
                                resposta = int.Parse(dr["vQte"].ToString());
                            }
                        }
                        dr.Dispose();
                        dr.Close();
                    }
                }
                catch (Exception ex)
                {
                    resposta = 0;
                    MessageBox.Show("Erro ao buscar dados do banco de dados (01):\n" + ex.ToString(),
                                    "Trabalho BD2",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
            }
            txtQteFuncCadastrado.Text = resposta.ToString("D4");
        }

        private void btnQteFuncAtivos_Click(object sender, EventArgs e)
        {
            String sql = "";
            int resposta = 0;
            MySqlCommand comando = null;
            MySqlDataReader dr = null;
            ConexaoBD conexaoBD = null;

            if (validarBD())
            {
                conexaoBD = new ConexaoBD(montarDados());
                try
                {
                    if (conexaoBD.conectar())
                    {
                        sql = "CALL proc_qteFuncionarios(1)";
                        comando = new MySqlCommand(sql, conexaoBD.conexao);
                        dr = comando.ExecuteReader();
                        if (dr.HasRows)
                        {
                            if (dr.Read())
                            {
                                resposta = int.Parse(dr["vQte"].ToString());
                            }
                        }
                        dr.Dispose();
                        dr.Close();
                    }
                }
                catch (Exception ex)
                {
                    resposta = 0;
                    MessageBox.Show("Erro ao buscar dados do banco de dados (02):\n" + ex.ToString(),
                                    "Trabalho BD2",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
            }
            txtQteFuncAtivos.Text = resposta.ToString("D4");
        }

        private void btnQteCPFInvalidos_Click(object sender, EventArgs e)
        {
            String sql = "";
            int resposta = 0;
            MySqlCommand comando = null;
            MySqlDataReader dr = null;
            ConexaoBD conexaoBD = null;

            if (validarBD())
            {
                conexaoBD = new ConexaoBD(montarDados());
                try
                {
                    if (conexaoBD.conectar())
                    {
                        sql = "CALL proc_qteFuncionariosCPFinv()";
                        comando = new MySqlCommand(sql, conexaoBD.conexao);
                        dr = comando.ExecuteReader();
                        if (dr.HasRows)
                        {
                            if (dr.Read())
                            {
                                resposta = int.Parse(dr["vQte"].ToString());
                            }
                        }
                        dr.Dispose();
                        dr.Close();
                    }
                }
                catch (Exception ex)
                {
                    resposta = 0;
                    MessageBox.Show("Erro ao buscar dados do banco de dados (03):\n" + ex.ToString(),
                                    "Trabalho BD2",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
            }
            txtQteFuncCPFinvalidos.Text = resposta.ToString("D4");
        }

        private void btnQteFuncAtivosPorSexo_Click(object sender, EventArgs e)
        {
            String sql = "";
            int resposta0 = 0;
            int resposta1 = 0;
            MySqlCommand comando = null;
            MySqlDataReader dr = null;
            ConexaoBD conexaoBD = null;

            if (validarBD())
            {
                conexaoBD = new ConexaoBD(montarDados());
                try
                {
                    if (conexaoBD.conectar())
                    {
                        sql = "SELECT func_qteFuncionarioSexo(0) vQte";
                        comando = new MySqlCommand(sql, conexaoBD.conexao);
                        dr = comando.ExecuteReader();
                        if (dr.HasRows)
                        {
                            if (dr.Read())
                            {
                                resposta0 = int.Parse(dr["vQte"].ToString());
                            }
                        }
                        dr.Dispose();
                        dr.Close();

                        sql = "SELECT func_qteFuncionarioSexo(1) vQte";
                        comando = new MySqlCommand(sql, conexaoBD.conexao);
                        dr = comando.ExecuteReader();
                        if (dr.HasRows)
                        {
                            if (dr.Read())
                            {
                                resposta1 = int.Parse(dr["vQte"].ToString());
                            }
                        }
                        dr.Dispose();
                        dr.Close();
                    }
                }
                catch (Exception ex)
                {
                    resposta0 = 0;
                    resposta1 = 0;
                    MessageBox.Show("Erro ao buscar dados do banco de dados (04):\n" + ex.ToString(),
                                    "Trabalho BD2",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
            }
            txtQteFuncAtivosSexo0.Text = resposta0.ToString("D4");
            txtQteFuncAtivosSexo1.Text = resposta1.ToString("D4");
        }

        private void btnSalarioMedio_Click(object sender, EventArgs e)
        {
            String sql = "";
            double resposta = 0.0;
            MySqlCommand comando = null;
            MySqlDataReader dr = null;
            ConexaoBD conexaoBD = null;

            if (validarBD())
            {
                conexaoBD = new ConexaoBD(montarDados());
                try
                {
                    if (conexaoBD.conectar())
                    {
                        sql = "SELECT func_salarioMedio() vSalarioMedio";
                        comando = new MySqlCommand(sql, conexaoBD.conexao);
                        dr = comando.ExecuteReader();
                        if (dr.HasRows)
                        {
                            if (dr.Read())
                            {
                                resposta = double.Parse(dr["vSalarioMedio"].ToString());
                            }
                        }
                        dr.Dispose();
                        dr.Close();
                    }
                }
                catch (Exception ex)
                {
                    resposta = 0;
                    MessageBox.Show("Erro ao buscar dados do banco de dados (05):\n" + ex.ToString(),
                                    "Trabalho BD2",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
            }
            txtSalarioMedio.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", resposta);
        }

        private void btnFolhaDepComercial_Click(object sender, EventArgs e)
        {
            String sql = "";
            double resposta = 0.0;
            MySqlCommand comando = null;
            MySqlDataReader dr = null;
            ConexaoBD conexaoBD = null;

            if (validarBD())
            {
                conexaoBD = new ConexaoBD(montarDados());
                try
                {
                    if (conexaoBD.conectar())
                    {
                        sql = "SELECT func_folhaPagtoDepartamento(3) vSalario";
                        comando = new MySqlCommand(sql, conexaoBD.conexao);
                        dr = comando.ExecuteReader();
                        if (dr.HasRows)
                        {
                            if (dr.Read())
                            {
                                resposta = double.Parse(dr["vSalario"].ToString());
                            }
                        }
                        dr.Dispose();
                        dr.Close();
                    }
                }
                catch (Exception ex)
                {
                    resposta = 0;
                    MessageBox.Show("Erro ao buscar dados do banco de dados (06):\n" + ex.ToString(),
                                    "Trabalho BD2",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
            }
            txtFolhaDepComercial.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", resposta);
        }

        private void btnFolhaDepDesenvolvimento_Click(object sender, EventArgs e)
        {
            String sql = "";
            double resposta = 0.0;
            MySqlCommand comando = null;
            MySqlDataReader dr = null;
            ConexaoBD conexaoBD = null;

            if (validarBD())
            {
                conexaoBD = new ConexaoBD(montarDados());
                try
                {
                    if (conexaoBD.conectar())
                    {
                        sql = "SELECT func_folhaPagtoDepartamento(2) vSalario";
                        comando = new MySqlCommand(sql, conexaoBD.conexao);
                        dr = comando.ExecuteReader();
                        if (dr.HasRows)
                        {
                            if (dr.Read())
                            {
                                resposta = double.Parse(dr["vSalario"].ToString());
                            }
                        }
                        dr.Dispose();
                        dr.Close();
                    }
                }
                catch (Exception ex)
                {
                    resposta = 0;
                    MessageBox.Show("Erro ao buscar dados do banco de dados (07):\n" + ex.ToString(),
                                    "Trabalho BD2",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
            }
            txtFolhaDepDesenvolvimento.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", resposta);
        }

        private void btnFolhaDepSuporte_Click(object sender, EventArgs e)
        {
            String sql = "";
            double resposta = 0.0;
            MySqlCommand comando = null;
            MySqlDataReader dr = null;
            ConexaoBD conexaoBD = null;

            if (validarBD())
            {
                conexaoBD = new ConexaoBD(montarDados());
                try
                {
                    if (conexaoBD.conectar())
                    {
                        sql = "SELECT func_folhaPagtoDepartamento(1) vSalario";
                        comando = new MySqlCommand(sql, conexaoBD.conexao);
                        dr = comando.ExecuteReader();
                        if (dr.HasRows)
                        {
                            if (dr.Read())
                            {
                                resposta = double.Parse(dr["vSalario"].ToString());
                            }
                        }
                        dr.Dispose();
                        dr.Close();
                    }
                }
                catch (Exception ex)
                {
                    resposta = 0;
                    MessageBox.Show("Erro ao buscar dados do banco de dados (08):\n" + ex.ToString(),
                                    "Trabalho BD2",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
            }
            txtFolhaDepSuporte.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", resposta);
        }

        private void btnMediaSalDepComercial_Click(object sender, EventArgs e)
        {
            String sql = "";
            double resposta = 0.0;
            MySqlCommand comando = null;
            MySqlDataReader dr = null;
            ConexaoBD conexaoBD = null;

            if (validarBD())
            {
                conexaoBD = new ConexaoBD(montarDados());
                try
                {
                    if (conexaoBD.conectar())
                    {
                        sql = "SELECT func_salarioMedioDepartamento(3) vMedia";
                        comando = new MySqlCommand(sql, conexaoBD.conexao);
                        dr = comando.ExecuteReader();
                        if (dr.HasRows)
                        {
                            if (dr.Read())
                            {
                                resposta = double.Parse(dr["vMedia"].ToString());
                            }
                        }
                        dr.Dispose();
                        dr.Close();
                    }
                }
                catch (Exception ex)
                {
                    resposta = 0;
                    MessageBox.Show("Erro ao buscar dados do banco de dados (09):\n" + ex.ToString(),
                                    "Trabalho BD2",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
            }
            txtMediaSalDepComercial.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", resposta);
        }

        private void btnMediaSalDepDesenvolvimento_Click(object sender, EventArgs e)
        {
            String sql = "";
            double resposta = 0.0;
            MySqlCommand comando = null;
            MySqlDataReader dr = null;
            ConexaoBD conexaoBD = null;

            if (validarBD())
            {
                conexaoBD = new ConexaoBD(montarDados());
                try
                {
                    if (conexaoBD.conectar())
                    {
                        sql = "SELECT func_salarioMedioDepartamento(2) vMedia";
                        comando = new MySqlCommand(sql, conexaoBD.conexao);
                        dr = comando.ExecuteReader();
                        if (dr.HasRows)
                        {
                            if (dr.Read())
                            {
                                resposta = double.Parse(dr["vMedia"].ToString());
                            }
                        }
                        dr.Dispose();
                        dr.Close();
                    }
                }
                catch (Exception ex)
                {
                    resposta = 0;
                    MessageBox.Show("Erro ao buscar dados do banco de dados (10):\n" + ex.ToString(),
                                    "Trabalho BD2",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
            }
            txtMediaSalDepDesenvolvimento.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", resposta);
        }

        private void btnMediaSalDepSuporte_Click(object sender, EventArgs e)
        {
            String sql = "";
            double resposta = 0.0;
            MySqlCommand comando = null;
            MySqlDataReader dr = null;
            ConexaoBD conexaoBD = null;

            if (validarBD())
            {
                conexaoBD = new ConexaoBD(montarDados());
                try
                {
                    if (conexaoBD.conectar())
                    {
                        sql = "SELECT func_salarioMedioDepartamento(1) vMedia";
                        comando = new MySqlCommand(sql, conexaoBD.conexao);
                        dr = comando.ExecuteReader();
                        if (dr.HasRows)
                        {
                            if (dr.Read())
                            {
                                resposta = double.Parse(dr["vMedia"].ToString());
                            }
                        }
                        dr.Dispose();
                        dr.Close();
                    }
                }
                catch (Exception ex)
                {
                    resposta = 0;
                    MessageBox.Show("Erro ao buscar dados do banco de dados (11):\n" + ex.ToString(),
                                    "Trabalho BD2",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
            }
            txtMediaSalDepSuporte.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", resposta);
        }

        private void btnMediaIdadeDepComercial_Click(object sender, EventArgs e)
        {
            String sql = "";
            double resposta = 0.0;
            MySqlCommand comando = null;
            MySqlDataReader dr = null;
            ConexaoBD conexaoBD = null;

            if (validarBD())
            {
                conexaoBD = new ConexaoBD(montarDados());
                try
                {
                    if (conexaoBD.conectar())
                    {
                        sql = "SELECT func_mediaIdadeDepartamento(3) vMedia";
                        comando = new MySqlCommand(sql, conexaoBD.conexao);
                        dr = comando.ExecuteReader();
                        if (dr.HasRows)
                        {
                            if (dr.Read())
                            {
                                resposta = double.Parse(dr["vMedia"].ToString());
                            }
                        }
                        dr.Dispose();
                        dr.Close();
                    }
                }
                catch (Exception ex)
                {
                    resposta = 0;
                    MessageBox.Show("Erro ao buscar dados do banco de dados (12):\n" + ex.ToString(),
                                    "Trabalho BD2",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
            }
            txtMediaIdadeDepComercial.Text = string.Format("{0:0,0.00}", resposta);
        }

        private void btnMediaIdadeDepDesenvolvimento_Click(object sender, EventArgs e)
        {
            String sql = "";
            double resposta = 0.0;
            MySqlCommand comando = null;
            MySqlDataReader dr = null;
            ConexaoBD conexaoBD = null;

            if (validarBD())
            {
                conexaoBD = new ConexaoBD(montarDados());
                try
                {
                    if (conexaoBD.conectar())
                    {
                        sql = "SELECT func_mediaIdadeDepartamento(2) vMedia";
                        comando = new MySqlCommand(sql, conexaoBD.conexao);
                        dr = comando.ExecuteReader();
                        if (dr.HasRows)
                        {
                            if (dr.Read())
                            {
                                resposta = double.Parse(dr["vMedia"].ToString());
                            }
                        }
                        dr.Dispose();
                        dr.Close();
                    }
                }
                catch (Exception ex)
                {
                    resposta = 0;
                    MessageBox.Show("Erro ao buscar dados do banco de dados (13):\n" + ex.ToString(),
                                    "Trabalho BD2",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
            }
            txtMediaIdadeDepDesenvolvimento.Text = string.Format("{0:0,0.00}", resposta);
        }

        private void btnMediaIdadeDepSuporte_Click(object sender, EventArgs e)
        {
            String sql = "";
            double resposta = 0.0;
            MySqlCommand comando = null;
            MySqlDataReader dr = null;
            ConexaoBD conexaoBD = null;

            if (validarBD())
            {
                conexaoBD = new ConexaoBD(montarDados());
                try
                {
                    if (conexaoBD.conectar())
                    {
                        sql = "SELECT func_mediaIdadeDepartamento(1) vMedia";
                        comando = new MySqlCommand(sql, conexaoBD.conexao);
                        dr = comando.ExecuteReader();
                        if (dr.HasRows)
                        {
                            if (dr.Read())
                            {
                                resposta = double.Parse(dr["vMedia"].ToString());
                            }
                        }
                        dr.Dispose();
                        dr.Close();
                    }
                }
                catch (Exception ex)
                {
                    resposta = 0;
                    MessageBox.Show("Erro ao buscar dados do banco de dados (14):\n" + ex.ToString(),
                                    "Trabalho BD2",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
            }
            txtMediaIdadeDepSuporte.Text = string.Format("{0:0,0.00}", resposta);
        }

        private void btnReajusteTrigger_Click(object sender, EventArgs e)
        {
            String sql = "";
            double resposta = 0.0;
            double vrPorcent = 0.0;
            MySqlCommand comando = null;
            MySqlDataReader dr = null;
            ConexaoBD conexaoBD = null;

            if (validarBD() && txtVrReajuste.Value > 0)
            {
                conexaoBD = new ConexaoBD(montarDados());
                vrPorcent = double.Parse(txtVrReajuste.Value.ToString());
                vrPorcent = 1 + (vrPorcent / 100);
                try
                {
                    if (conexaoBD.conectar())
                    {
                        sql = "UPDATE cargo SET salariomedio = salariomedio * " + vrPorcent.ToString().Replace(",",".");
                        comando = new MySqlCommand(sql, conexaoBD.conexao);
                        comando.ExecuteNonQuery();
                        comando.Dispose();

                        sql = "SELECT func_somaSalarioTemp() vSoma";
                        comando = new MySqlCommand(sql, conexaoBD.conexao);
                        dr = comando.ExecuteReader();
                        if (dr.HasRows)
                        {
                            if (dr.Read())
                            {
                                resposta = double.Parse(dr["vSoma"].ToString());
                            }
                        }
                        dr.Dispose();
                        dr.Close();
                    }
                }
                catch (Exception ex)
                {
                    resposta = 0;
                    MessageBox.Show("Erro ao buscar dados do banco de dados (15):\n" + ex.ToString(),
                                    "Trabalho BD2",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
            }
            txtSomatorioSalarioTemp.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", resposta);
        }

        private void btnLimparCampos_Click(object sender, EventArgs e)
        {
            string sql = "";
            MySqlCommand comando = null;
            ConexaoBD conexaoBD = null;
            if (MessageBox.Show("Deseja realmente limpar os campos da tela?", "Trabalho BD2", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                //limpando campos
                txtFolhaDepComercial.Clear();
                txtFolhaDepDesenvolvimento.Clear();
                txtFolhaDepSuporte.Clear();
                txtMediaIdadeDepComercial.Clear();
                txtMediaIdadeDepDesenvolvimento.Clear();
                txtMediaIdadeDepSuporte.Clear();
                txtMediaSalDepComercial.Clear();
                txtMediaSalDepDesenvolvimento.Clear();
                txtMediaSalDepSuporte.Clear();
                txtQteFuncAtivos.Clear();
                txtQteFuncAtivosSexo0.Clear();
                txtQteFuncAtivosSexo1.Clear();
                txtQteFuncCadastrado.Clear();
                txtQteFuncCPFinvalidos.Clear();
                txtSalarioMedio.Clear();
                txtSomatorioSalarioTemp.Clear();
                txtValiidarBD.Clear();

                if (validarBD())
                {
                    conexaoBD = new ConexaoBD(montarDados());
                    try
                    {
                        if (conexaoBD.conectar())
                        {                            
                                                        
                            sql = "UPDATE cargo SET salariomedio = 2000 WHERE id = 1";
                            comando = new MySqlCommand(sql, conexaoBD.conexao);
                            comando.ExecuteNonQuery();
                            comando.Dispose();

                            sql = "UPDATE cargo SET salariomedio = 2500 WHERE id = 2";
                            comando = new MySqlCommand(sql, conexaoBD.conexao);
                            comando.ExecuteNonQuery();
                            comando.Dispose();

                            sql = "UPDATE cargo SET salariomedio = 3000 WHERE id = 3";
                            comando = new MySqlCommand(sql, conexaoBD.conexao);
                            comando.ExecuteNonQuery();
                            comando.Dispose();

                            sql = "UPDATE cargo SET salariomedio = 3500 WHERE id = 4";
                            comando = new MySqlCommand(sql, conexaoBD.conexao);
                            comando.ExecuteNonQuery();
                            comando.Dispose();

                            sql = "UPDATE cargo SET salariomedio = 4500 WHERE id = 5";
                            comando = new MySqlCommand(sql, conexaoBD.conexao);
                            comando.ExecuteNonQuery();
                            comando.Dispose();

                            sql = "UPDATE cargo SET salariomedio = 5500 WHERE id = 6";
                            comando = new MySqlCommand(sql, conexaoBD.conexao);
                            comando.ExecuteNonQuery();
                            comando.Dispose();

                            sql = "UPDATE cargo SET salariomedio = 5500 WHERE id = 7";
                            comando = new MySqlCommand(sql, conexaoBD.conexao);
                            comando.ExecuteNonQuery();
                            comando.Dispose();

                            sql = "UPDATE cargo SET salariomedio = 7500 WHERE id = 8";
                            comando = new MySqlCommand(sql, conexaoBD.conexao);
                            comando.ExecuteNonQuery();
                            comando.Dispose();

                            sql = "UPDATE cargo SET salariomedio = 6500 WHERE id = 9";
                            comando = new MySqlCommand(sql, conexaoBD.conexao);
                            comando.ExecuteNonQuery();
                            comando.Dispose();

                            sql = "UPDATE funcionario SET salariotemp = 0";
                            comando = new MySqlCommand(sql, conexaoBD.conexao);
                            comando.ExecuteNonQuery();
                            comando.Dispose();

                        }
                        conexaoBD.desconectar();
                        MessageBox.Show("Dados limpos com sucesso!", "Trabalho BD2", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao buscar dados do banco de dados (16):\n" + ex.ToString(),
                                        "Trabalho BD2",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void btnValidarBD_Click(object sender, EventArgs e)
        {
            validarBD(1);
        }

        private void textHost_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
