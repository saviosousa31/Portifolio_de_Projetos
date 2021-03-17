using System;
using System.Collections.Generic;

namespace P1_TrabalhoPraticoA_Savio_PedroGodoy
{
    public class Pessoa
    {
        private string nome, cpf;
        private Endereco end;

        public Pessoa()
        {
        }
        public Pessoa(string nome, string cpf, Endereco end)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.end = end;
        }
        public void setNome(string nome)
        {
            this.nome = nome;
        }
        public string getNome()
        {
            return nome;
        }
        public void setCpf(string cpf)
        {
            this.cpf = cpf;
        }
        public string getCpf()
        {
            return cpf;
        }
        public void setEndereco(Endereco end)
        {
            this.end = end;
        }
        public void getEndereco()
        {
            end.imprimeEndereco();
        }
        public void imprimePessoa()
        {
            Console.WriteLine("\nNome: " + nome + "\nCPF: " + cpf + "\nEndereço: ");
            end.imprimeEndereco();
            Console.WriteLine("- - - - - - - - - - - - - - - - - - -\n");
        }
    } // Fecha classe Pessoa
    public class Endereco
    {
        private string logradouro, bairro, cidade, estado, cep, complemento;
        private int numero;

        public Endereco()
        {
        }
        public Endereco(string cep, string logradouro, int numero, string complemento, string bairro, string cidade, string estado)
        {
            this.cep = cep;
            this.logradouro = logradouro;
            this.numero = numero;
            this.complemento = complemento;
            this.bairro = bairro;
            this.cidade = cidade;
            this.estado = estado;
        }
        public void setCep(string cep)
        {
            this.cep = cep;
        }
        public string getCep()
        {
            return cep;
        }
        public void setLogradouro(string logradouro)
        {
            this.logradouro = logradouro;
        }
        public string getLogradouro()
        {
            return logradouro;
        }
        public void setNumero(int numero)
        {
            this.numero = numero;
        }
        public int getNumero()
        {
            return numero;
        }
        public void setComplemento(string complemento)
        {
            this.complemento = complemento;
        }
        public string getComplemento()
        {
            return complemento;
        }
        public void setBairro(string bairro)
        {
            this.bairro = bairro;
        }
        public string getBairro()
        {
            return bairro;
        }
        public void setCidade(string cidade)
        {
            this.cidade = cidade;
        }
        public string getCidade()
        {
            return cidade;
        }
        public void setEstado(string estado)
        {
            this.estado = estado;
        }
        public string getEstado()
        {
            return estado;
        }
        public void imprimeEndereco()
        {
            Console.WriteLine("CEP: " + cep + "\nLogradouro: " + logradouro + "\nNumero: " + numero + "\nComplemento: " + complemento + "\nBairro: " + bairro + "\nCidade: " + cidade + "\nEstado: " + estado + "\n- - - - - - - - - - - - - - - - - - -");
        }
    } // Fecha classe Endereço
    public class Cliente : Pessoa
    {
        private bool liberado = true;

        public Cliente()
        {

        }
        public Cliente(string nome, string cpf, Endereco end, bool liberado) : base(nome, cpf, end)
        {
            this.liberado = liberado;
        }
        public void setLiberado(bool liberado)
        {
            this.liberado = liberado;
        }
        public bool getLiberado()
        {
            return liberado;
        }
        public void imprimeCliente()
        {
            Console.WriteLine("\n===========================================================\nNome: " + getNome() + "\nCPF: " + getCpf() + "\nEndereço do cliente: ");
            getEndereco();
            Console.WriteLine("Liberado: " + liberado + "\n===========================================================");
        }
    } // Fecha classe Cliente
    public class Funcionario : Pessoa, Comissao
    {
        private double salario, percComissao;

        public Funcionario()
        {
        }
        public Funcionario(string nome, string cpf, Endereco end, double salario, double percComissao) : base(nome, cpf, end)
        {
            this.salario = salario;
            this.percComissao = percComissao;
        }
        public void setSalario(double salario)
        {
            this.salario = salario;
        }
        public double getSalario()
        {
            return salario;
        }
        public void setPercComissao(double percComissao)
        {
            this.percComissao = percComissao;
        }
        public double getPercComissao()
        {
            return percComissao;
        }
        public double CalcularComissao(double comissao)
        {
            return (percComissao/100) * comissao;
        }
        public void imprimeFuncionario()
        {
            Console.WriteLine("\n===========================================================\nNome: " + getNome() + "\nCPF: " + getCpf() + "\nEndereço: ");
            getEndereco();
            Console.WriteLine("Salario: " + salario + "\nPercentual de comissão: " + getPercComissao() + "%" + "\n===========================================================");
        }
    } // Fecha classe Funcionario
    public abstract class Imovel
    {
        private int quadra;
        private string lote, situacao = "Disponível";
        private double area, valor;
        private Cliente cli;
        private Endereco end;

        public Imovel()
        {
        }
        public Imovel(int quadra, string lote, string situacao, double area, double valor, Cliente cli, Endereco end)
        {
            this.quadra = quadra;
            this.lote = lote;
            this.situacao = situacao;
            this.area = area;
            this.valor = valor;
            this.cli = cli;
            this.end = end;
        }
        public void setQuadra(int quadra)
        {
            this.quadra = quadra;
        }
        public int getQuadra()
        {
            return quadra;
        }
        public void setLote(string lote)
        {
            this.lote = lote;
        }
        public string getLote()
        {
            return lote;
        }
        public void setSituacao(string situacao)
        {
            this.situacao = situacao;
        }
        public string getSituacao()
        {
            return situacao;
        }
        public void setArea(double area)
        {
            this.area = area;
        }
        public double getArea()
        {
            return area;
        }
        public void setValor(double valor)
        {
            this.valor = valor;
        }
        public double getValor()
        {
            return valor;
        }
        public void setCliente(Cliente cli)
        {
            this.cli = cli;
        }
        public void getCliente()
        {
            cli.imprimeCliente();
        }
        public Cliente getClienteC()
        {
            return cli;
        }
        public void setEndereco(Endereco end)
        {
            this.end = end;
        }
        public void getEndereco()
        {
            end.imprimeEndereco();
        }

        public abstract double CalcularIPTU();  // Metodo abstrato
    } // Fecha classe abstrata Imovel
    public class Casa : Imovel
    {
        private double areaConstruida;

        public Casa()
        {
        }
        public Casa(int quadra, string lote, string situacao, double area, double valor, Cliente cli, Endereco end, double areaConstruida) : base(quadra, lote, situacao, area, valor, cli, end)
        {
            this.areaConstruida = areaConstruida;
        }
        public void imprimeCasa()
        {
            Console.WriteLine("\nQuadra: " + getQuadra() + "\nLote: " + getLote() + "\nSituação: " + getSituacao() + "\nValor: R$" + getValor() + "\nÁrea construída: " + areaConstruida + "\nCliente responsável: ");
            getCliente();
            Console.WriteLine("\nEndereço do imóvel: ");
            getEndereco();
            Console.WriteLine("IPTU: R$" + CalcularIPTU() + "\n==============================================================\n");
        }
        public override double CalcularIPTU()
        {
            return (getValor() * 0.05);
        }
    } // Fecha classe Casa
    public class Terreno : Imovel
    {
        public Terreno()
        {
        }
        public Terreno(int quadra, string lote, string situacao, double area, double valor, Cliente cli, Endereco end) : base(quadra, lote, situacao, area, valor, cli, end)
        {
        }
        public void imprimeTerreno()
        {
            Console.WriteLine("\nQuadra: " + getQuadra() + "\nLote: " + getLote() + "\nSituação: " + getSituacao() + "\nValor: R$" + getValor() + "\nCliente responsável: ");
            getCliente();
            Console.WriteLine("\nEndereço do imóvel: ");
            getEndereco();
            Console.WriteLine("IPTU: R$" + CalcularIPTU() + "\n==============================================================\n");
        }
        public override double CalcularIPTU()
        {
            return (getValor() * 0.02);
        }
    } // Fecha classe Terreno
    public class Apartamento : Imovel
    {
        private string condominio;
        private int andar;

        public Apartamento()
        {
        }
        public Apartamento(int quadra, string lote, string situacao, double area, double valor, Cliente cli, Endereco end, string condominio, int andar) : base(quadra, lote, situacao, area, valor, cli, end)
        {
            this.condominio = condominio;
            this.andar = andar;
        }
        public void imprimeApartamento()
        {
            Console.WriteLine("\nQuadra: " + getQuadra() + "\nLote: " + getLote() + "\nSituação: " + getSituacao() + "\nValor: R$" + getValor() + "\nCondomínio: " + condominio + "\nAndar: " + andar + "° andar \nCliente responsável: ");
            getCliente();
            Console.WriteLine("\nEndereço do imóvel: ");
            getEndereco();
            Console.WriteLine("IPTU: R$" + CalcularIPTU() + "\n==============================================================\n");
        }
        public override double CalcularIPTU()
        {
            return (getValor() * 0.03);
        }
    } // Fecha classe Apartamento
    public class Venda : Contrato
    {
        private double valorTotal, valorComissao;
        private string formaPgto;
        private int totalParcelas;
        private Cliente cli;
        private Funcionario func;
        private Imovel imov;

        public Venda(Funcionario func)
        {
            this.func = func;
            valorComissao = func.CalcularComissao(valorTotal);
        }
        public Venda(double valorTotal, string formaPgto, int totalParcelas, double valorComissao, Cliente cli, Funcionario func, Imovel imov)
        {
            this.valorTotal = valorTotal;
            this.formaPgto = formaPgto;
            this.totalParcelas = totalParcelas;
            this.valorComissao = valorComissao;
            this.cli = cli;
            this.func = func;
            this.imov = imov;
        }
        public void setValorTotal(double valorTotal)
        {
            this.valorTotal = valorTotal;
        }
        public double getValorTotal()
        {
            return valorTotal;
        }
        public void setFormaPgto(string formaPgto)
        {
            this.formaPgto = formaPgto;
        }
        public string getFormaPgto()
        {
            return formaPgto;
        }
        public void setTotalParcelas(int totalParcelas)
        {
            this.totalParcelas = totalParcelas;
        }
        public int getTotalParcelas()
        {
            return totalParcelas;
        }
        public void setValorComissao(double valorComissao)
        {
            this.valorComissao = valorComissao;
        }
        public double getValorComissao()
        {
            return valorComissao;
        }
        public void setCliente(Cliente cli)
        {
            this.cli = cli;
        }
        public Cliente getCliente()
        {
            return cli;
        }
        public void setFuncionario(Funcionario func)
        {
            this.func = func;
        }
        public Funcionario getFuncionario()
        {
            return func;
        }
        public void setImovel(Imovel imov)
        {
            this.imov = imov;
        }
        public Imovel getImovel()
        {
            return imov;
        }
        public void GerarContrato()
        {
            Console.WriteLine("* Contrato de venda gerado com sucesso! *");
        }
    } // Fecha classe Venda
    public class Aluguel : Contrato
    {
        private double mensal;
        private int qtdMeses;
        private Cliente cli;
        private Funcionario func;
        private Imovel imov;

        public Aluguel()
        {
        }
        public Aluguel(double mensal, int qtdMeses, Cliente cli, Funcionario func, Imovel imov)
        {
            this.mensal = mensal;
            this.qtdMeses = qtdMeses;
            this.cli = cli;
            this.func = func;
            this.imov = imov;
        }
        public void setMensal(double mensal)
        {
            this.mensal = mensal;
        }
        public double getMensal()
        {
            return mensal;
        }
        public void setQtdMeses(int qtdMeses)
        {
            this.qtdMeses = qtdMeses;
        }
        public int getQtdMeses()
        {
            return qtdMeses;
        }
        public void setCliente(Cliente cli)
        {
            this.cli = cli;
        }
        public Cliente getCliente()
        {
            return cli;
        }
        public void setFuncionario(Funcionario func)
        {
            this.func = func;
        }
        public Funcionario getFuncionario()
        {
            return func;
        }
        public void setImovel(Imovel imov)
        {
            this.imov = imov;
        }
        public Imovel getImovel()
        {
            return imov;
        }
        public void GerarContrato()
        {
            Console.WriteLine("* Contrato de aluguel gerado com sucesso! *");
        }
    } // Fecha classe Aluguel
    public interface Comissao
    {
        double CalcularComissao(double comissao);
    } // Fecha interface Comissao
    public interface Contrato
    {
        void GerarContrato();
    } // Fecha interface Contrato

    class Program
    {
        public static void Main(string[] args)
        {
            LinkedList<Cliente> clientes = new LinkedList<Cliente>();
            LinkedList<Funcionario> funcionarios = new LinkedList<Funcionario>();
            LinkedList<Casa> casas = new LinkedList<Casa>();
            LinkedList<Apartamento> apartamentos = new LinkedList<Apartamento>();
            LinkedList<Terreno> terrenos = new LinkedList<Terreno>();
            LinkedList<Venda> vendas = new LinkedList<Venda>();
            LinkedList<Aluguel> alugueis = new LinkedList<Aluguel>();
            int r = 1;
            do
            {
                Console.Clear();
                Console.WriteLine("=======================================================================================================");
                Console.WriteLine("=                                         IMOBILIÁRIA VIRTUAL                                         =");
                Console.WriteLine("=======================================================================================================");
                Console.WriteLine("\n SELECIONE UMA OPÇÃO PARA PROSSEGUIR:\n");
                Console.WriteLine(" 1) Cadastrar cliente");
                Console.WriteLine(" 2) Cadastrar funcionário");
                Console.WriteLine(" 3) Cadastrar um imóvel do tipo casa");
                Console.WriteLine(" 4) Cadastrar um imóvel do tipo apartamento");
                Console.WriteLine(" 5) Cadastrar um imóvel do tipo terreno");
                Console.WriteLine("\n- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -\n");
                Console.WriteLine(" 6) Consultar imóveis cadastrados pela situação");
                Console.WriteLine(" 7) Consultar clientes cadastrados");
                Console.WriteLine(" 8) Consultar funcionários cadastrados");
                Console.WriteLine(" 9) Consultar imóveis de um determinado cliente");
                Console.WriteLine(" 10) Consultar salário de um determinado funcionário, acrescendo ao salário suas comissões");
                Console.WriteLine("\n- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -\n");
                Console.WriteLine(" 11) Alugar um imóvel");
                Console.WriteLine(" 12) Vender um imóvel");
                Console.WriteLine("\n- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -\n");
                Console.WriteLine(" 0) Sair do programa");
                Console.WriteLine("\n=======================================================================================================\n");
                Console.WriteLine("R: ");
                r = Convert.ToInt32(Console.ReadLine());
                switch (r)
                {
                    case 1: // Cadastrar cliente
                        Console.Clear();
                        Console.WriteLine("========================================= CADASTRAR CLIENTE =========================================");
                        string nome, cpf;
                        Endereco end = new Endereco();
                        bool liberado;
                        Console.WriteLine("\nNome: ");
                        nome = Console.ReadLine();
                        Console.WriteLine("\nCPF: ");
                        cpf = Console.ReadLine();
                        Console.WriteLine("\nLiberado (Digite 'true' para sim, ou 'false' para não): ");
                        liberado = Convert.ToBoolean(Console.ReadLine());
                        Console.WriteLine("\n\n + Cadastrar Endereço: + ");
                        Console.WriteLine("\nCEP: ");
                        end.setCep(Console.ReadLine());
                        Console.WriteLine("\nLogradouro: ");
                        end.setLogradouro(Console.ReadLine());
                        Console.WriteLine("\nNúmero: ");
                        end.setNumero(Convert.ToInt32(Console.ReadLine()));
                        Console.WriteLine("\nComplemento: ");
                        end.setComplemento(Console.ReadLine());
                        Console.WriteLine("\nBairro: ");
                        end.setBairro(Console.ReadLine());
                        Console.WriteLine("\nCidade: ");
                        end.setCidade(Console.ReadLine());
                        Console.WriteLine("\nEstado: ");
                        end.setEstado(Console.ReadLine());
                        Cliente cli = new Cliente(nome, cpf, end, liberado);
                        clientes.AddLast(cli);
                        Console.WriteLine("\n * Cliente cadastrado com sucesso! Aperte 'enter' para voltar ao menu principal... *");
                        Console.ReadLine();
                        break;
                    case 2: // Cadastrar funcionário
                        Console.Clear();
                        Console.WriteLine("======================================= CADASTRAR FUNCIONÁRIO =======================================");
                        string nomef, cpff;
                        Endereco endf = new Endereco();
                        double salario, comissao;
                        Console.WriteLine("\nNome: ");
                        nomef = Console.ReadLine();
                        Console.WriteLine("\nCPF: ");
                        cpff = Console.ReadLine();
                        Console.WriteLine("\nSalário: ");
                        salario = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("\nPercentual de comissão (%): ");
                        comissao = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("\n\n + Cadastrar Endereço: + ");
                        Console.WriteLine("\nCEP: ");
                        endf.setCep(Console.ReadLine());
                        Console.WriteLine("\nLogradouro: ");
                        endf.setLogradouro(Console.ReadLine());
                        Console.WriteLine("\nNúmero: ");
                        endf.setNumero(Convert.ToInt32(Console.ReadLine()));
                        Console.WriteLine("\nComplemento: ");
                        endf.setComplemento(Console.ReadLine());
                        Console.WriteLine("\nBairro: ");
                        endf.setBairro(Console.ReadLine());
                        Console.WriteLine("\nCidade: ");
                        endf.setCidade(Console.ReadLine());
                        Console.WriteLine("\nEstado: ");
                        endf.setEstado(Console.ReadLine());
                        Funcionario func = new Funcionario(nomef, cpff, endf, salario, comissao);
                        funcionarios.AddLast(func);
                        Console.WriteLine("\n * Funcionário cadastrado com sucesso! Aperte 'enter' para voltar ao menu principal... *");
                        Console.ReadLine();
                        break;
                    case 3: // Cadastrar casa
                        Console.Clear();
                        Console.WriteLine("=================================== CADASTRAR IMÓVEL DO TIPO CASA ===================================");
                        if (clientes.Count == 0)
                        {
                            Console.WriteLine(" * Cadastre pelo menos um cliente para prosseguir com essa operação. *");
                            Console.WriteLine("\n * Aperte 'enter' para voltar ao menu principal... *");
                            Console.ReadLine();
                        }
                        else
                        {
                            int quadrac;
                            string lotec, situacaoc, cnomec;
                            double areac, valorc, areaConstruidac;
                            Cliente clic;
                            Endereco endc = new Endereco();
                            Console.WriteLine("\nQuadra: ");
                            quadrac = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("\nLote: ");
                            lotec = Console.ReadLine();
                            Console.WriteLine("\nSituação (Disponível / Alugado / Vendido): ");
                            situacaoc = Console.ReadLine();
                            Console.WriteLine("\nÁrea: ");
                            areac = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("\nValor do imóvel: ");
                            valorc = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("\nÁrea construída: ");
                            areaConstruidac = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("\n\n + Cadastrar Endereço: + ");
                            Console.WriteLine("\nCEP: ");
                            endc.setCep(Console.ReadLine());
                            Console.WriteLine("\nLogradouro: ");
                            endc.setLogradouro(Console.ReadLine());
                            Console.WriteLine("\nNúmero: ");
                            endc.setNumero(Convert.ToInt32(Console.ReadLine()));
                            Console.WriteLine("\nComplemento: ");
                            endc.setComplemento(Console.ReadLine());
                            Console.WriteLine("\nBairro: ");
                            endc.setBairro(Console.ReadLine());
                            Console.WriteLine("\nCidade: ");
                            endc.setCidade(Console.ReadLine());
                            Console.WriteLine("\nEstado: ");
                            endc.setEstado(Console.ReadLine());
                            Console.WriteLine("\nInforme o nome do cliente referente ao imóvel: ");
                            cnomec = Console.ReadLine();
                            foreach (Cliente cada in clientes)
                            {
                                if (cada.getNome() == cnomec)
                                {
                                    clic = cada;
                                    Casa cas = new Casa(quadrac, lotec, situacaoc, areac, valorc, clic, endc, areaConstruidac);
                                    casas.AddLast(cas);
                                    Console.WriteLine("\n * Imóvel cadastrado com sucesso!");
                                }
                                Console.WriteLine("Aperte 'enter' para voltar ao menu principal... *");
                                Console.ReadLine();
                            }
                        }
                        break;
                    case 4: // Cadastrar apartamento
                        Console.Clear();
                        Console.WriteLine("=============================== CADASTRAR IMÓVEL DO TIPO APARTAMENTO ================================");
                        if (clientes.Count == 0)
                        {
                            Console.WriteLine(" * Cadastre pelo menos um cliente para prosseguir com essa operação. *");
                            Console.WriteLine("\n * Aperte 'enter' para voltar ao menu principal... *");
                            Console.ReadLine();
                        }
                        else
                        {
                            int quadraa, andara;
                            string lotea, situacaoa, condominioa, cnomea;
                            double areaa, valora;
                            Cliente clia;
                            Endereco enda = new Endereco();
                            Console.WriteLine("\nQuadra: ");
                            quadraa = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("\nLote: ");
                            lotea = Console.ReadLine();
                            Console.WriteLine("\nSituação (Disponível / Alugado / Vendido): ");
                            situacaoa = Console.ReadLine();
                            Console.WriteLine("\nÁrea: ");
                            areaa = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("\nValor do imóvel: ");
                            valora = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("\nAndar: ");
                            andara = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("\nCondomínio: ");
                            condominioa = Console.ReadLine();
                            Console.WriteLine("\n\n + Cadastrar Endereço: + ");
                            Console.WriteLine("\nCEP: ");
                            enda.setCep(Console.ReadLine());
                            Console.WriteLine("\nLogradouro: ");
                            enda.setLogradouro(Console.ReadLine());
                            Console.WriteLine("\nNúmero: ");
                            enda.setNumero(Convert.ToInt32(Console.ReadLine()));
                            Console.WriteLine("\nComplemento: ");
                            enda.setComplemento(Console.ReadLine());
                            Console.WriteLine("\nBairro: ");
                            enda.setBairro(Console.ReadLine());
                            Console.WriteLine("\nCidade: ");
                            enda.setCidade(Console.ReadLine());
                            Console.WriteLine("\nEstado: ");
                            enda.setEstado(Console.ReadLine());
                            Console.WriteLine("\nInforme o nome do cliente referente ao imóvel: ");
                            cnomea = Console.ReadLine();
                            foreach (Cliente cada in clientes)
                            {
                                if (cada.getNome() == cnomea)
                                {
                                    clia = cada;
                                    Apartamento ap = new Apartamento(quadraa, lotea, situacaoa, areaa, valora, clia, enda, condominioa, andara);
                                    apartamentos.AddLast(ap);
                                    Console.WriteLine("\n * Imóvel cadastrado com sucesso!");
                                }
                                Console.WriteLine("Aperte 'enter' para voltar ao menu principal... *");
                                Console.ReadLine();
                            }

                        }
                        break;
                    case 5: // Cadastrar terreno
                        Console.Clear();
                        Console.WriteLine("================================= CADASTRAR IMÓVEL DO TIPO TERRENO ==================================");
                        if (clientes.Count == 0)
                        {
                            Console.WriteLine(" * Cadastre pelo menos um cliente para prosseguir com essa operação. *");
                            Console.WriteLine("\n * Aperte 'enter' para voltar ao menu principal... *");
                            Console.ReadLine();
                        }
                        else
                        {
                            int quadrat;
                            string lotet, situacaot, cnomet;
                            double areat, valort;
                            Cliente clit;
                            Endereco endt = new Endereco();
                            Console.WriteLine("\nQuadra: ");
                            quadrat = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("\nLote: ");
                            lotet = Console.ReadLine();
                            Console.WriteLine("\nSituação (Disponível / Alugado / Vendido): ");
                            situacaot = Console.ReadLine();
                            Console.WriteLine("\nÁrea: ");
                            areat = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("\nValor do imóvel: ");
                            valort = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("\n\n + Cadastrar Endereço: + ");
                            Console.WriteLine("\nCEP: ");
                            endt.setCep(Console.ReadLine());
                            Console.WriteLine("\nLogradouro: ");
                            endt.setLogradouro(Console.ReadLine());
                            Console.WriteLine("\nNúmero: ");
                            endt.setNumero(Convert.ToInt32(Console.ReadLine()));
                            Console.WriteLine("\nComplemento: ");
                            endt.setComplemento(Console.ReadLine());
                            Console.WriteLine("\nBairro: ");
                            endt.setBairro(Console.ReadLine());
                            Console.WriteLine("\nCidade: ");
                            endt.setCidade(Console.ReadLine());
                            Console.WriteLine("\nEstado: ");
                            endt.setEstado(Console.ReadLine());
                            Console.WriteLine("\nInforme o nome do cliente referente ao imóvel: ");
                            cnomet = Console.ReadLine();
                            foreach(Cliente cada in clientes)
                            {
                                if(cada.getNome() == cnomet)
                                {
                                    clit = cada;
                                    Terreno ter = new Terreno(quadrat, lotet, situacaot, areat, valort, clit, endt);
                                    terrenos.AddLast(ter);
                                    Console.WriteLine("\n * Imóvel cadastrado com sucesso!");
                                }
                                Console.WriteLine("Aperte 'enter' para voltar ao menu principal... *");
                                Console.ReadLine();
                            }                               
                        }
                        break;
                    case 6: // Consultar imóveis
                        Console.Clear();
                        Console.WriteLine("================================== CONSULTAR IMÓVEIS PELA SITUÇÃO ===================================");
                        Console.WriteLine("\n INFORME A SITUAÇÃO DOS IMÓVEIS DESEJADOS:");
                        string sit = Console.ReadLine();
                        Console.WriteLine("\n CASAS CADASTRADAS COM A SITUAÇÃO '" + sit + "':");
                            foreach (Casa cada in casas)
                            {
                                if(cada.getSituacao() == sit)
                                {
                                cada.imprimeCasa();
                                }
                            }
                            Console.WriteLine("\n APARTAMENTOS CADASTRADOS COM A SITUAÇÃO '" + sit + "':");
                            foreach (Apartamento cada in apartamentos)
                            {
                                if (cada.getSituacao() == sit)
                                {
                                cada.imprimeApartamento();
                                }
                            }
                            Console.WriteLine("\n TERRENOS CADASTRADOS COM A SITUAÇÃO '" + sit + "':");
                            foreach (Terreno cada in terrenos)
                            {
                                if (cada.getSituacao() == sit)
                                {
                                    cada.imprimeTerreno();
                                }
                            }
                            Console.WriteLine("\n * Aperte 'enter' para voltar ao menu principal... *");
                            Console.ReadLine();
                        break;
                    case 7: // Consultar clientes
                        Console.Clear();
                        Console.WriteLine("======================================== CONSULTAR CLIENTES =========================================");
                        if (clientes.Count == 0)
                        {
                            Console.WriteLine(" * Cadastre pelo menos um cliente para prosseguir com essa operação. *");
                            Console.WriteLine("\n * Aperte 'enter' para voltar ao menu principal... *");
                            Console.ReadLine();
                        }
                        else
                        {
                            foreach (Cliente cada in clientes)
                            {
                                cada.imprimeCliente();
                            }
                            Console.WriteLine("\n * Aperte 'enter' para voltar ao menu principal... *");
                            Console.ReadLine();
                        }
                        break;
                    case 8: // Consultar funcionários
                        Console.Clear();
                        Console.WriteLine("====================================== CONSULTAR FUNCIONÁRIOS =======================================");
                        if (funcionarios.Count == 0)
                        {
                            Console.WriteLine(" * Cadastre pelo menos um funcionário para prosseguir com essa operação. *");
                            Console.WriteLine("\n * Aperte 'enter' para voltar ao menu principal... *");
                            Console.ReadLine();
                        }
                        else
                        {
                            foreach (Funcionario cada in funcionarios)
                            {
                                cada.imprimeFuncionario();
                            }
                            Console.WriteLine("\n * Aperte 'enter' para voltar ao menu principal... *");
                            Console.ReadLine();
                        }
                        break;
                    case 9: // Consultar imóveis de um determinado cliente
                        Console.Clear();
                        Console.WriteLine("================================== CONSULTAR IMÓVEIS DE UM CLIENTE ==================================");
                        if (clientes.Count == 0)
                        {
                            Console.WriteLine(" * Cadastre pelo menos um cliente para prosseguir com essa operação. *");
                            Console.WriteLine("\n * Aperte 'enter' para voltar ao menu principal... *");
                            Console.ReadLine();
                        }
                        else
                        {
                            string ncli;
                            Console.WriteLine("\nInforme o nome do cliente: ");
                            ncli = Console.ReadLine();
                            foreach(Casa cada in casas)
                            {
                                if(cada.getClienteC().getNome() == ncli)
                                {
                                    cada.imprimeCasa();
                                }
                            }
                            foreach (Apartamento cada in apartamentos)
                            {
                                if (cada.getClienteC().getNome() == ncli)
                                {
                                    cada.imprimeApartamento();
                                }
                            }
                            foreach (Terreno cada in terrenos)
                            {
                                if (cada.getClienteC().getNome() == ncli)
                                {
                                    cada.imprimeTerreno();
                                }
                            }
                            Console.WriteLine("\n * Aperte 'enter' para voltar ao menu principal... *");
                            Console.ReadLine();
                        }
                        break;
                    case 10: // Consultar Consultar salário de um determinado funcionário
                        Console.Clear();
                        Console.WriteLine("================================ CONSULTAR SALÁRIO DE UM FUNCIONÁRIO ================================");
                        if (funcionarios.Count == 0)
                        {
                            Console.WriteLine(" * Cadastre pelo menos um funcionário para prosseguir com essa operação. *");
                            Console.WriteLine("\n * Aperte 'enter' para voltar ao menu principal... *");
                            Console.ReadLine();
                        }
                        else
                        {
                            string nfunc;
                            Console.WriteLine("\nDigite o nome do funcionário: ");
                            nfunc = Console.ReadLine();
                            foreach(Funcionario cada in funcionarios)
                            {
                                if (cada.getNome() == nfunc)
                                {
                                    Console.WriteLine("\nNome: " + cada.getNome() + "\nCPF: " + cada.getCpf() + "\nSalário fixo: R$" + cada.getSalario());
                                    foreach(Venda cadav in vendas)
                                    {
                                        double comissaocalculada = 0;
                                        if (cadav.getFuncionario().getNome() == nfunc)
                                        {
                                            comissaocalculada = comissaocalculada + Convert.ToDouble(cada.CalcularComissao(cadav.getValorTotal()));
                                            cadav.setValorComissao(comissaocalculada);
                                        }
                                        Console.WriteLine("\nComissão recebida por venda realizada: R$" + cadav.getValorComissao());
                                    }
                                    
                                }
                            }
                            Console.WriteLine("\n * Aperte 'enter' para voltar ao menu principal... *");
                            Console.ReadLine();
                        }
                        break;
                    case 11: // Alugar um imóvel
                        Console.Clear();
                        int y;
                        Console.WriteLine("========================================= ALUGAR UM IMÓVEL ==========================================");
                        Console.WriteLine("\n SELECIONE O TIPO DE IMÓVEL DESEJADO:");
                        Console.WriteLine("\n 1) Casa\n 2) Apartamento\n 3) Terreno\n\nR: ");
                        y = Convert.ToInt32(Console.ReadLine());
                        switch (y)
                        {
                            case 1:
                                if (casas.Count == 0)
                                {
                                    Console.WriteLine(" * Cadastre pelo menos um imóvel do tipo casa para prosseguir com essa operação. *");
                                    Console.WriteLine("\n * Aperte 'enter' para voltar ao menu principal... *");
                                    Console.ReadLine();
                                }
                                else
                                {
                                    string alotec;
                                    Console.WriteLine("\nDigite o lote do imóvel: ");
                                    alotec = Console.ReadLine();
                                    foreach (Casa cada in casas)
                                    {
                                        if (cada.getLote() == alotec)
                                        {
                                            if (cada.getSituacao() == "Disponível" || cada.getSituacao() == "disponível" || cada.getSituacao() == "Disponivel" || cada.getSituacao() == "disponivel")
                                            {
                                                string ncli, nvend;
                                                Console.WriteLine("\nDigite o nome do cliente locatário: ");
                                                ncli = Console.ReadLine();
                                                foreach (Cliente cadacc in clientes)
                                                {
                                                    if (cadacc.getNome() == ncli)
                                                    {
                                                        if (cadacc.getLiberado() == true)
                                                        {
                                                            Console.WriteLine("\nDigite o nome do funcionário locador: ");
                                                            nvend = Console.ReadLine();
                                                            foreach (Funcionario cadav in funcionarios)
                                                            {
                                                                if (cadav.getNome() == nvend)
                                                                {
                                                                    Cliente comprador;
                                                                    Funcionario vendedor;
                                                                    Imovel alugado;
                                                                    comprador = cadacc;
                                                                    vendedor = cadav;
                                                                    alugado = cada;
                                                                    alugado.setSituacao("Alugado");
                                                                    Console.WriteLine("\nInsira o valor mensal do aluguel: ");
                                                                    double mensal = Convert.ToDouble(Console.ReadLine());
                                                                    Console.WriteLine("\nInsira a quantidade de meses do contrato: ");
                                                                    int qtdMeses = Convert.ToInt32(Console.ReadLine());                                                                    
                                                                    Aluguel alug = new Aluguel(mensal, qtdMeses, cadacc, cadav, alugado);
                                                                    alug.GerarContrato();
                                                                    alugueis.AddLast(alug);
                                                                    Console.WriteLine("\n * Imóvel alugado com sucesso!");
                                                                }
                                                            }
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine("\n * O cliente responsável por esse imóvel não está liberado a fazer esta transação... *");
                                                            break;
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                    Console.WriteLine("\n * Aperte 'enter' para voltar ao menu principal... *");
                                    Console.ReadLine();
                                }
                                break;
                            case 2:
                                if (apartamentos.Count == 0)
                                {
                                    Console.WriteLine(" * Cadastre pelo menos um imóvel do tipo apartamento para prosseguir com essa operação. *");
                                    Console.WriteLine("\n * Aperte 'enter' para voltar ao menu principal... *");
                                    Console.ReadLine();
                                }
                                else
                                {
                                    string alotea;
                                    Console.WriteLine("\nDigite o lote do imóvel: ");
                                    alotea = Console.ReadLine();
                                    foreach (Apartamento cada in apartamentos)
                                    {
                                        if (cada.getLote() == alotea)
                                        {
                                            if (cada.getLote() == alotea)
                                            {
                                                if (cada.getSituacao() == "Disponível" || cada.getSituacao() == "disponível" || cada.getSituacao() == "Disponivel" || cada.getSituacao() == "disponivel")
                                                {
                                                    string ncli, nvend;
                                                    Console.WriteLine("\nDigite o nome do cliente locatário: ");
                                                    ncli = Console.ReadLine();
                                                    foreach (Cliente cadacc in clientes)
                                                    {
                                                        if (cadacc.getNome() == ncli)
                                                        {
                                                            if (cadacc.getLiberado() == true)
                                                            {
                                                                Console.WriteLine("\nDigite o nome do funcionário locador: ");
                                                                nvend = Console.ReadLine();
                                                                foreach (Funcionario cadav in funcionarios)
                                                                {
                                                                    if (cadav.getNome() == nvend)
                                                                    {
                                                                        Cliente comprador;
                                                                        Funcionario vendedor;
                                                                        Imovel alugado;
                                                                        comprador = cadacc;
                                                                        vendedor = cadav;
                                                                        alugado = cada;
                                                                        alugado.setSituacao("Alugado");
                                                                        Console.WriteLine("\nInsira o valor mensal do aluguel: ");
                                                                        double mensal = Convert.ToDouble(Console.ReadLine());
                                                                        Console.WriteLine("\nInsira a quantidade de meses do contrato: ");
                                                                        int qtdMeses = Convert.ToInt32(Console.ReadLine());
                                                                        Aluguel alug = new Aluguel(mensal, qtdMeses, cadacc, cadav, alugado);
                                                                        alug.GerarContrato();
                                                                        alugueis.AddLast(alug);
                                                                        Console.WriteLine("\n * Imóvel alugado com sucesso!");
                                                                    }
                                                                }
                                                            }
                                                            else
                                                            {
                                                                Console.WriteLine("\n * O cliente responsável por esse imóvel não está liberado a fazer esta transação... *");
                                                                break;
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                    Console.WriteLine("\n * Aperte 'enter' para voltar ao menu principal... *");
                                    Console.ReadLine();
                                }
                                break;
                            case 3:
                                if (terrenos.Count == 0)
                                {
                                    Console.WriteLine(" * Cadastre pelo menos um imóvel do tipo terreno para prosseguir com essa operação. *");
                                    Console.WriteLine("\n * Aperte 'enter' para voltar ao menu principal... *");
                                    Console.ReadLine();
                                }
                                else
                                {
                                    string alotet;
                                    Console.WriteLine("\nDigite o lote do imóvel: ");
                                    alotet = Console.ReadLine();
                                    foreach (Terreno cada in terrenos)
                                    {
                                        if (cada.getLote() == alotet)
                                        {
                                            if (cada.getLote() == alotet)
                                            {
                                                if (cada.getSituacao() == "Disponível" || cada.getSituacao() == "disponível" || cada.getSituacao() == "Disponivel" || cada.getSituacao() == "disponivel")
                                                {
                                                    string ncli, nvend;
                                                    Console.WriteLine("\nDigite o nome do cliente locatário: ");
                                                    ncli = Console.ReadLine();
                                                    foreach (Cliente cadacc in clientes)
                                                    {
                                                        if (cadacc.getNome() == ncli)
                                                        {
                                                            if (cadacc.getLiberado() == true)
                                                            {
                                                                Console.WriteLine("\nDigite o nome do funcionário locador: ");
                                                                nvend = Console.ReadLine();
                                                                foreach (Funcionario cadav in funcionarios)
                                                                {
                                                                    if (cadav.getNome() == nvend)
                                                                    {
                                                                        Cliente comprador;
                                                                        Funcionario vendedor;
                                                                        Imovel alugado;
                                                                        comprador = cadacc;
                                                                        vendedor = cadav;
                                                                        alugado = cada;
                                                                        alugado.setSituacao("Alugado");
                                                                        Console.WriteLine("\nInsira o valor mensal do aluguel: ");
                                                                        double mensal = Convert.ToDouble(Console.ReadLine());
                                                                        Console.WriteLine("\nInsira a quantidade de meses do contrato: ");
                                                                        int qtdMeses = Convert.ToInt32(Console.ReadLine());
                                                                        Aluguel alug = new Aluguel(mensal, qtdMeses, cadacc, cadav, alugado);
                                                                        alug.GerarContrato();
                                                                        alugueis.AddLast(alug);
                                                                        Console.WriteLine("\n * Imóvel alugado com sucesso!");
                                                                    }
                                                                }
                                                            }
                                                            else
                                                            {
                                                                Console.WriteLine("\n * O cliente responsável por esse imóvel não está liberado a fazer esta transação... *");
                                                                break;
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                    Console.WriteLine("\n * Aperte 'enter' para voltar ao menu principal... *");
                                    Console.ReadLine();
                                }
                                break;
                            default:
                                Console.WriteLine("\n * Opção inválida! Aperte 'enter' para continuar... *");
                                Console.ReadLine();
                                break;
                        }
                        break;
                    case 12: // Vender um imóvel
                        Console.Clear();
                        int z;                        
                        Console.WriteLine("========================================= VENDER UM IMÓVEL ==========================================");
                        Console.WriteLine("\n SELECIONE O TIPO DE IMÓVEL DESEJADO:");
                        Console.WriteLine("\n 1) Casa\n 2) Apartamento\n 3) Terreno\n\nR: ");
                        z = Convert.ToInt32(Console.ReadLine());
                        switch (z)
                        {
                            case 1:
                                if (casas.Count == 0)
                                {
                                    Console.WriteLine(" * Cadastre pelo menos um imóvel do tipo casa para prosseguir com essa operação. *");
                                    Console.WriteLine("\n * Aperte 'enter' para voltar ao menu principal... *");
                                    Console.ReadLine();
                                }
                                else
                                {
                                    string vlotec;
                                    Console.WriteLine("\nDigite o lote do imóvel: ");
                                    vlotec = Console.ReadLine();
                                    foreach (Casa cada in casas)
                                    {
                                        if (cada.getSituacao() == "Disponível" || cada.getSituacao() == "disponível" || cada.getSituacao() == "Disponivel" || cada.getSituacao() == "disponivel")
                                        {
                                            string ncli, nvend;
                                            Console.WriteLine("\nDigite o nome do cliente comprador: ");
                                            ncli = Console.ReadLine();
                                            foreach(Cliente cadacc in clientes)
                                            {
                                                if (cadacc.getNome() == ncli)
                                                {
                                                    if (cadacc.getLiberado() == true)
                                                    {
                                                        Console.WriteLine("\nDigite o nome do vendedor: ");
                                                        nvend = Console.ReadLine();
                                                        foreach(Funcionario cadav in funcionarios)
                                                        {
                                                            if(cadav.getNome() == nvend)
                                                            {
                                                                Cliente comprador;
                                                                Funcionario vendedor;
                                                                Imovel vendido;
                                                                comprador = cadacc;
                                                                vendedor = cadav;
                                                                vendido = cada;
                                                                vendido.setSituacao("Vendido");
                                                                Console.WriteLine("\nInsira o valor total da venda: ");
                                                                double valorTotal = Convert.ToDouble(Console.ReadLine());
                                                                Console.WriteLine("\nInsira a forma de pagamento: ");
                                                                string formaPgto = Console.ReadLine();
                                                                Console.WriteLine("\nInsira o total de parcelas: ");
                                                                int totalParcelas = Convert.ToInt32(Console.ReadLine());
                                                                double valorComissao = cadav.CalcularComissao(valorTotal);
                                                                Venda vend = new Venda(valorTotal, formaPgto, totalParcelas, valorComissao, cadacc, cadav, vendido);
                                                                vendas.AddLast(vend);
                                                                Console.WriteLine("\n * Imóvel vendido com sucesso!");
                                                            }
                                                        }
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("\n * O cliente responsável por esse imóvel não está liberado a fazer esta transação... *");
                                                        break;
                                                    }
                                                }
                                            }
                                            
                                        }
                                        else
                                        {
                                            Console.WriteLine("\n * Esse imóvel não está disponível para venda...");
                                            break;
                                        }
                                    }
                                    Console.WriteLine("\n * Aperte 'enter' para voltar ao menu principal... *");
                                    Console.ReadLine();
                                }
                                break;
                            case 2:
                                if (apartamentos.Count == 0)
                                {
                                    Console.WriteLine(" * Cadastre pelo menos um imóvel do tipo apartamento para prosseguir com essa operação. *");
                                    Console.WriteLine("\n * Aperte 'enter' para voltar ao menu principal... *");
                                    Console.ReadLine();
                                }
                                else
                                {
                                    string vlotea;
                                    Console.WriteLine("\nDigite o lote do imóvel: ");
                                    vlotea = Console.ReadLine();
                                    foreach (Apartamento cada in apartamentos)
                                    {
                                        if (cada.getSituacao() == "Disponível" || cada.getSituacao() == "disponível" || cada.getSituacao() == "Disponivel" || cada.getSituacao() == "disponivel")
                                        {
                                            string ncli, nvend;
                                            Console.WriteLine("\nDigite o nome do cliente comprador: ");
                                            ncli = Console.ReadLine();
                                            foreach (Cliente cadacc in clientes)
                                            {
                                                if (cadacc.getNome() == ncli)
                                                {
                                                    if (cadacc.getLiberado() == true)
                                                    {
                                                        Console.WriteLine("\nDigite o nome do vendedor: ");
                                                        nvend = Console.ReadLine();
                                                        foreach (Funcionario cadav in funcionarios)
                                                        {
                                                            if (cadav.getNome() == nvend)
                                                            {
                                                                Cliente comprador;
                                                                Funcionario vendedor;
                                                                Imovel vendido;
                                                                comprador = cadacc;
                                                                vendedor = cadav;
                                                                vendido = cada;
                                                                vendido.setSituacao("Vendido");
                                                                Console.WriteLine("\nInsira o valor total da venda: ");
                                                                double valorTotal = Convert.ToDouble(Console.ReadLine());
                                                                Console.WriteLine("\nInsira a forma de pagamento: ");
                                                                string formaPgto = Console.ReadLine();
                                                                Console.WriteLine("\nInsira o total de parcelas: ");
                                                                int totalParcelas = Convert.ToInt32(Console.ReadLine());
                                                                double valorComissao = cadav.CalcularComissao(valorTotal);
                                                                Venda vend = new Venda(valorTotal, formaPgto, totalParcelas, valorComissao, cadacc, cadav, vendido);
                                                                vendas.AddLast(vend);
                                                                Console.WriteLine("\n * Imóvel vendido com sucesso!");
                                                            }
                                                        }
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("\n * O cliente responsável por esse imóvel não está liberado a fazer esta transação... *");
                                                        break;
                                                    }
                                                }
                                            }

                                        }
                                        else
                                        {
                                            Console.WriteLine("\n * Esse imóvel não está disponível para venda...");
                                            break;
                                        }
                                    }
                                    Console.WriteLine("\n * Aperte 'enter' para voltar ao menu principal... *");
                                    Console.ReadLine();
                                }
                                break;
                            case 3:
                                if (terrenos.Count == 0)
                                {
                                    Console.WriteLine(" * Cadastre pelo menos um imóvel do tipo terreno para prosseguir com essa operação. *");
                                    Console.WriteLine("\n * Aperte 'enter' para voltar ao menu principal... *");
                                    Console.ReadLine();
                                }
                                else
                                {
                                    string vlotet;
                                    Console.WriteLine("\nDigite o lote do imóvel: ");
                                    vlotet = Console.ReadLine();
                                    foreach (Terreno cada in terrenos)
                                    {
                                        if (cada.getSituacao() == "Disponível" || cada.getSituacao() == "disponível" || cada.getSituacao() == "Disponivel" || cada.getSituacao() == "disponivel")
                                        {
                                            string ncli, nvend;
                                            Console.WriteLine("\nDigite o nome do cliente comprador: ");
                                            ncli = Console.ReadLine();
                                            foreach (Cliente cadacc in clientes)
                                            {
                                                if (cadacc.getNome() == ncli)
                                                {
                                                    if (cadacc.getLiberado() == true)
                                                    {
                                                        Console.WriteLine("\nDigite o nome do vendedor: ");
                                                        nvend = Console.ReadLine();
                                                        foreach (Funcionario cadav in funcionarios)
                                                        {
                                                            if (cadav.getNome() == nvend)
                                                            {
                                                                Cliente comprador;
                                                                Funcionario vendedor;
                                                                Imovel vendido;
                                                                comprador = cadacc;
                                                                vendedor = cadav;
                                                                vendido = cada;
                                                                vendido.setSituacao("Vendido");
                                                                Console.WriteLine("\nInsira o valor total da venda: ");
                                                                double valorTotal = Convert.ToDouble(Console.ReadLine());
                                                                Console.WriteLine("\nInsira a forma de pagamento: ");
                                                                string formaPgto = Console.ReadLine();
                                                                Console.WriteLine("\nInsira o total de parcelas: ");
                                                                int totalParcelas = Convert.ToInt32(Console.ReadLine());
                                                                double valorComissao = cadav.CalcularComissao(valorTotal);
                                                                Venda vend = new Venda(valorTotal, formaPgto, totalParcelas, valorComissao, cadacc, cadav, vendido);
                                                                vendas.AddLast(vend);
                                                                Console.WriteLine("\n * Imóvel vendido com sucesso!");
                                                            }
                                                        }
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("\n * O cliente responsável por esse imóvel não está liberado a fazer esta transação... *");
                                                        break;
                                                    }
                                                }
                                            }

                                        }
                                        else
                                        {
                                            Console.WriteLine("\n * Esse imóvel não está disponível para venda...");
                                            break;
                                        }
                                    }
                                    Console.WriteLine("\n * Aperte 'enter' para voltar ao menu principal... *");
                                    Console.ReadLine();
                                }
                                break;
                            default:
                                Console.WriteLine("\n * Opção inválida! Aperte 'enter' para continuar... *");
                                Console.ReadLine();
                                break;
                        }
                        break;
                    case 0: // Sair do programa
                        Console.WriteLine("\n\n * Saindo do programa... *\n\n");
                        break;
                    default:
                        Console.WriteLine("\n * Opção inválida! Aperte 'enter' para continuar... *");
                        Console.ReadLine();
                        break;
                }
            } while (r != 0);
        }
    }
}