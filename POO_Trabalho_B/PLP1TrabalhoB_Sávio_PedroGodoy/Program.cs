using System;

namespace PLP1TrabalhoB_Sávio_PedroGodoy
{
    public class Pessoa
    {
        private string cpf, nome, rg, telefone, email;
        private bool liberado = true;
        private DateTime dtNascimento;
        private Endereco endereco;

        public Pessoa()
        {
        }

        public Pessoa(string cpf, string nome, string rg, string telefone, string email, bool liberado, DateTime dtNascimento, Endereco endereco)
        {
            this.cpf = cpf;
            this.nome = nome;
            this.rg = rg;
            this.telefone = telefone;
            this.email = email;
            this.liberado = liberado;
            this.dtNascimento = dtNascimento;
            this.endereco = endereco;
        }
        public void setCpf(string cpf)
        {
            this.cpf = cpf;
        }
        public string getCpf()
        {
            return cpf;
        }
        public void setNome(string nome)
        {
            this.nome = nome;
        }
        public string getNome()
        {
            return nome;
        }
        public void setRg(string rg)
        {
            this.rg = rg;
        }
        public string getRg()
        {
            return rg;
        }
        public void setTelefone(string telefone)
        {
            this.telefone = telefone;
        }
        public string getTelefone()
        {
            return telefone;
        }
        public void setEmail(string email)
        {
            this.email = email;
        }
        public string getEmail()
        {
            return email;
        }
        public void setLiberado(bool liberado)
        {
            this.liberado = liberado;
        }
        public bool getLiberado()
        {
            return liberado;
        }
        public void setDtNascimento(DateTime dtNascimento)
        {
            this.dtNascimento = dtNascimento;
        }
        public DateTime getDtNascimento()
        {
            return dtNascimento;
        }
        public void setEndereco(Endereco endereco)
        {
            this.endereco = endereco;
        }
        public Endereco getEndereco()
        {
            return endereco;
        }
    } // Fecha classe Pessoa

    public class Livro
    {
        private int cod, anoLancamento, edicao;
        private string nome, autor, editora;

        public Livro()
        {
        }

        public Livro(int cod, int anoLancamento, int edicao, string nome, string autor, string editora)
        {
            this.cod = cod;
            this.anoLancamento = anoLancamento;
            this.edicao = edicao;
            this.nome = nome;
            this.autor = autor;
            this.editora = editora;
        }
        public void setCod(int cod)
        {
            this.cod = cod;
        }
        public int getCod()
        {
            return cod;
        }
        public void setAnoLancamento(int anoLancamento )
        {
            this.anoLancamento = anoLancamento;
        }
        public int getAnoLancamento()
        {
            return anoLancamento;
        }
        public void setEdicao(int edicao)
        {
            this.edicao = edicao;
        }
        public int getEdicao()
        {
            return edicao;
        }
        public void setNome(string nome)
        {
            this.nome = nome;
        }
        public string getNome()
        {
            return nome;
        }
        public void setAutor(string autor)
        {
            this.autor = autor;
        }
        public string getAutor()
        {
            return autor;
        }
        public void setEditora(string editora)
        {
            this.editora = editora;
        }
        public string getEditora()
        {
            return editora;
        }
    } // Fecha classe Livro

    public class Endereco
    {
        private string cep, logradouro, bairro, cidade, estado, complemento;
        private int numero;

        public Endereco()
        {
        }

        public Endereco(string cep, string logradouro, string bairro, string cidade, string estado, string complemento, int numero)
        {
            this.cep = cep;
            this.logradouro = logradouro;
            this.bairro = bairro;
            this.cidade = cidade;
            this.estado = estado;
            this.complemento = complemento;
            this.numero = numero;
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
        public void setComplemento(string complemento)
        {
            this.complemento = complemento;
        }
        public string getComplemento()
        {
            return complemento;
        }
        public void setNumero(int numero)
        {
            this.numero = numero;
        }
        public int getNumero()
        {
            return numero;
        }
    } // Fecha classe Endereco

    public class Curso
    {
        private string nome, area;
        private double valorMensalidade;

        public Curso()
        {            
        }

        public Curso(string nome, string area, double valorMensalidade)
        {
            this.nome = nome;
            this.area = area;
            this.valorMensalidade = valorMensalidade;
        }
        public void setNome(string nome)
        {
            this.nome = nome;
        }
        public string getNome()
        {
            return nome;
        }
        public void setArea(string area)
        {
            this.area = area;
        }
        public string getArea()
        {
            return area;
        }
        public void setValorMensalidade(double valorMensalidade)
        {
            this.valorMensalidade = valorMensalidade;
        }
        public double getValorMensalidade()
        {
            return valorMensalidade;
        }
    } // Fecha classe Curso

    public class Exemplar
    {
        private int cod, numExemplar;
        private Livro livro;
        private bool exclusivo = false;

        public Exemplar()
        {
        }

        public Exemplar(int cod, int numExemplar, Livro livro, bool exclusivo)
        {
            this.cod = cod;
            this.numExemplar = numExemplar;
            this.livro = livro;
            this.exclusivo = exclusivo;
        }
        public void setCod(int cod)
        {
            this.cod = cod;
        }
        public int getCod()
        {
            return cod;
        }
        public void setNumExemplar(int numExemplar)
        {
            this.numExemplar = numExemplar;
        }
        public int getNumExemplar()
        {
            return numExemplar;
        }
        public void setLivro(Livro livro)
        {
            this.livro = livro;
        }
        public Livro getLivro()
        {
            return livro;
        }
        public void setExclusivo(bool exclusivo)
        {
            this.exclusivo = exclusivo;
        }
        public bool getExclusivo()
        {
            return exclusivo;
        }
    } // Fecha classe Exemplar

    public class Emprestimo
    {
        private int cod;
        private Exemplar exemplar;
        private Pessoa pessoa;
        private DateTime dtEmprestimo, dtDevolucao;
        private double valorMulta;

        public Emprestimo()
        {
        }

        public Emprestimo(int cod, Exemplar exemplar, Pessoa pessoa, DateTime dtEmprestimo, DateTime dtDevolucao, double valorMulta)
        {
            this.cod = cod;
            this.exemplar = exemplar;
            this.pessoa = pessoa;
            this.dtEmprestimo = dtEmprestimo;
            this.dtDevolucao = dtDevolucao;
            this.valorMulta = valorMulta;
        }
        public void setCod(int cod )
        {
            this.cod = cod;
        }
        public int getCod()
        {
            return cod;
        }
        public void setExemplar(Exemplar exemplar)
        {
            this.exemplar = exemplar;
        }
        public Exemplar getExemplar()
        {
            return exemplar;
        }
        public void setPessoa(Pessoa pessoa)
        {
            this.pessoa = pessoa;
        }
        public Pessoa getPessoa()
        {
            return pessoa;
        }
        public void setDtEmprestimo(DateTime dtEmprestimo)
        {
            this.dtEmprestimo = dtEmprestimo;
        }
        public DateTime getDtEmprestimo()
        {
            return dtEmprestimo;
        }
        public void setDtDevolucao(DateTime dtDevolucao)
        {
            this.dtDevolucao = dtDevolucao;
        }
        public DateTime getDtDevolucao()
        {
            return dtDevolucao;
        }
        public void setValorMulta(double valorMulta)
        {
            this.valorMulta = valorMulta;
        }
        public double getValorMulta()
        {
            return valorMulta;
        }
    } // Fecha classe Emprestimo

    public class Aluno : Pessoa
    {
        private int matricula;
        private Curso curso;
        private DateTime dtInicio, dtConclusao;
        private double valorDesconto;
        private string situacao;

        public Aluno()
        {
        }
        public Aluno(string cpf, string nome, string rg, string telefone, string email, bool liberado, DateTime dtNascimento, Endereco endereco, int matricula, Curso curso, DateTime dtInicio, DateTime dtConclusao, double valorDesconto, string situacao) : base(cpf, nome, rg, telefone, email, liberado, dtNascimento, endereco)
        {
            this.matricula = matricula;
            this.curso = curso;
            this.dtInicio = dtInicio;
            this.dtConclusao = dtConclusao;
            this.valorDesconto = valorDesconto;
            this.situacao = situacao;
        }
        public void setMatricula(int matricula)
        {
            this.matricula = matricula;
        }
        public int getMatricula()
        {
            return matricula;
        }
        public void setCurso(Curso curso)
        {
            this.curso = curso;
        }
        public Curso getCurso()
        {
            return curso;
        }
        public void setDtInicio(DateTime dtInicio)
        {
            this.dtInicio = dtInicio;
        }
        public DateTime getDtInicio()
        {
            return dtInicio;
        }
        public void setDtConclusao(DateTime dtConclusao)
        {
            this.dtConclusao = dtConclusao;
        }
        public DateTime getDtConclusao()
        {
            return dtConclusao;
        }
        public void setValorDesconto(double valorDesconto)
        {
            this.valorDesconto = valorDesconto;
        }
        public double getValorDesconto()
        {
            return valorDesconto;
        }
        public void setSituacao(string situacao)
        {
            this.situacao = situacao;
        }
        public string getSituacao()
        {
            return situacao;
        }
    } // Fecha classe Aluno

    public class Professor : Pessoa
    {
        private int cod;
        private string graduacao;
        private DateTime dtAdmissao;
        private double salario;

        public Professor()
        {
        }
        public Professor(string cpf, string nome, string rg, string telefone, string email, bool liberado, DateTime dtNascimento, Endereco endereco, int cod, string graduacao, DateTime dtAdmissao, double salario) : base(cpf, nome, rg, telefone, email, liberado, dtNascimento, endereco)
        {
            this.cod = cod;
            this.graduacao = graduacao;
            this.dtAdmissao = dtAdmissao;
            this.salario = salario;
        }
        public void setCod(int cod)
        {
            this.cod = cod;
        }
        public int getCod()
        {
            return cod;
        }
        public void setGraduacao(string graduacao)
        {
            this.graduacao = graduacao;
        }
        public string getGraduacao()
        {
            return graduacao;
        }
        public void setDtAdmissao(DateTime dtAdmissao)
        {
            this.dtAdmissao = dtAdmissao;
        }
        public DateTime getDtAdmissao()
        {
            return dtAdmissao;
        }
        public void setSalario(double salario)
        {
            this.salario = salario;
        }
        public double getSalario()
        {
            return salario;
        }
    } // Fecha classe Professor

    public class Funcionario : Pessoa
    {
        private int cod;
        private string cargo;
        private DateTime dtAdmissao;
        private double salario;

        public Funcionario()
        {
        }
        public Funcionario(string cpf, string nome, string rg, string telefone, string email, bool liberado, DateTime dtNascimento, Endereco endereco, int cod, string cargo, DateTime dtAdmissao, double salario) : base(cpf, nome, rg, telefone, email, liberado, dtNascimento, endereco)
        {
            this.cod = cod;
            this.cargo = cargo;
            this.dtAdmissao = dtAdmissao;
            this.salario = salario;
        }
        public void setCod(int cod)
        {
            this.cod = cod;
        }
        public int getCod()
        {
            return cod;
        }
        public void setCargo(string cargo)
        {
            this.cargo = cargo;
        }
        public string getCargo()
        {
            return cargo;
        }
        public void setDtAdmissao(DateTime dtAdmissao)
        {
            this.dtAdmissao = dtAdmissao;
        }
        public DateTime getDtAdmissao()
        {
            return dtAdmissao;
        }
        public void setSalario(double salario)
        {
            this.salario = salario;
        }
        public double getSalario()
        {
            return salario;
        }
    } // Fecha classe Funcionario

    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            Pessoa pes = new Pessoa(); Aluno a = new Aluno(); Professor p = new Professor(); Funcionario f = new Funcionario();
            Curso c = new Curso();            
            Livro l = new Livro(); Exemplar ex = new Exemplar(); Exemplar ex2 = new Exemplar(); Emprestimo emp = new Emprestimo();
            Endereco e1 = new Endereco(); Endereco e2 = new Endereco(); Endereco e3 = new Endereco(); Endereco e4 = new Endereco();                        
            while (x != 0)
            {
                Console.WriteLine("===============================================================\n                      BIBLIOTECA ONLINE                        \n===============================================================\n");
                Console.WriteLine("1) Cadastrar curso\n2) Cadastrar aluno\n3) Cadastrar livro\n4) Cadastrar exemplar\n5) Cadastrar empréstimo\n6) Cadastrar professor\n7) Cadastrar funcionário\n -   -   -   -   -   -   -\n8) Visualizar curso\n9) Visualizar aluno\n10) Visualizar livro\n11) Visualizar exemplar\n12) Visualizar empréstimo\n13) Visualizar professor\n14) Visualizar funcionário\n\n0) Sair do programa\n- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -\n");
                Console.WriteLine("Escolha uma opção para prosseguir:");
                int r = Convert.ToInt32(Console.ReadLine());
                while (r < 0 || r > 14)
                {
                    Console.WriteLine("\n -   -   -   -   -   -   -   -   -   -\nPor favor, insira um número válido:");
                    r = Convert.ToInt32(Console.ReadLine());
                }
                if (r == 1) // Cadastrar curso
                {
                        Console.Clear();
                        Console.WriteLine("\n=========================== Cadastrar Curso ===========================\n");
                        Console.WriteLine("\nInforme o nome do curso:");
                        c.setNome(Console.ReadLine());
                        Console.WriteLine("\nInforme a área do curso:");
                        c.setArea(Console.ReadLine());
                        Console.WriteLine("\nInforme o valor da mensalidade do curso:");
                        c.setValorMensalidade(Convert.ToDouble(Console.ReadLine()));
                        Console.WriteLine("\nCurso cadastrado com sucesso!\n");
                }
                if (r == 2) // Cadastrar aluno
                {
                    Console.Clear();
                    Console.WriteLine("\n=========================== Cadastrar Aluno ===========================\n");
                    Console.WriteLine("\nInforme o nome:");
                    a.setNome(Console.ReadLine());
                    Console.WriteLine("\nInforme a matrícula:");
                    a.setMatricula(Convert.ToInt32(Console.ReadLine()));
                    Console.WriteLine("\nInforme o CPF:");
                    a.setCpf(Console.ReadLine());
                    Console.WriteLine("\nInforme o RG:");
                    a.setRg(Console.ReadLine());
                    Console.WriteLine("\nInforme o telefone:");
                    a.setTelefone(Console.ReadLine());
                    Console.WriteLine("\nInforme o email:");
                    a.setEmail(Console.ReadLine());
                    Console.WriteLine("\nInforme a situação:");
                    a.setSituacao(Console.ReadLine());
                    Console.WriteLine("\nInforme a data de nascimento ('aaaa,mm,dd'):");
                    a.setDtNascimento(Convert.ToDateTime(Console.ReadLine()));
                    Console.WriteLine("\nO aluno está liberado? (Digite 'true' se estiver, ou digite 'false' se não estiver: ");
                    a.setLiberado(Convert.ToBoolean(Console.ReadLine()));
                    Console.WriteLine("\n - - - Informe o endereço: - - -");
                    Console.WriteLine("\nInforme o CEP:");
                    e1.setCep(Console.ReadLine());
                    Console.WriteLine("\nInforme o logradouro:");
                    e1.setLogradouro(Console.ReadLine());
                    Console.WriteLine("\nInforme o número:");
                    e1.setNumero(Convert.ToInt32(Console.ReadLine()));
                    Console.WriteLine("\nInforme o bairro:");
                    e1.setBairro(Console.ReadLine());
                    Console.WriteLine("\nInforme o estado:");
                    e1.setEstado(Console.ReadLine());
                    Console.WriteLine("\nInforme a cidade:");
                    e1.setCidade(Console.ReadLine());
                    Console.WriteLine("\nInforme o complemento:");
                    e1.setBairro(Console.ReadLine());
                    a.setEndereco(e1);
                    a.setCurso(c);
                    Console.WriteLine("\nInforme a data de início do curso ('aaaa,mm,dd'):");
                    a.setDtInicio(Convert.ToDateTime(Console.ReadLine()));
                    Console.WriteLine("\nInforme a data de término do curso ('aaaa,mm,dd'):");
                    a.setDtConclusao(Convert.ToDateTime(Console.ReadLine()));
                    Console.WriteLine("\nInforme o valor de desconto da mensalidade:");
                    a.setValorDesconto(Convert.ToDouble(Console.ReadLine()));
                }
                if (r == 3) // Cadastrar livro
                {
                    Console.Clear();
                    Console.WriteLine("\n=========================== Cadastrar Livro ===========================\n");
                    Console.WriteLine("\nInforme o código do livro:");
                    l.setCod(Convert.ToInt32(Console.ReadLine()));
                    Console.WriteLine("\nInforme o nome do livro:");
                    l.setNome(Console.ReadLine());
                    Console.WriteLine("\nInforme o nome do autor:");
                    l.setAutor(Console.ReadLine());
                    Console.WriteLine("\nInforme a editora do livro:");
                    l.setEditora(Console.ReadLine());
                    Console.WriteLine("\nInforme a edição do livro:");
                    l.setEdicao(Convert.ToInt32(Console.ReadLine()));
                    Console.WriteLine("\nInforme o ano de lançamento do livro:");
                    l.setAnoLancamento(Convert.ToInt32(Console.ReadLine()));
                    Console.WriteLine("\nLivro cadastrado com sucesso!\n");
                }
                if (r == 4) // Cadastrar exemplar
                {
                    Console.Clear();
                    Console.WriteLine("\n=========================== Cadastrar Exemplar ===========================\n");
                    Console.WriteLine("\nInforme o código:");
                    ex.setCod(Convert.ToInt32(Console.ReadLine()));
                    Console.WriteLine("\nInforme o número do exemplar:");
                    ex.setNumExemplar(Convert.ToInt32(Console.ReadLine()));
                    Console.WriteLine("\nO exemplar é exclusivo? (Digite 'true' se for, ou digite 'false' se não for:");
                    ex.setExclusivo(Convert.ToBoolean(Console.ReadLine()));
                    ex.setLivro(l);
                }
                if (r == 5) // Cadastrar empréstimo
                {
                    Console.Clear();
                    Console.WriteLine("\n=========================== Cadastrar Empréstimo ===========================\n");
                    Console.WriteLine("\nInforme o código:");
                    emp.setCod(Convert.ToInt32(Console.ReadLine()));
                    Console.WriteLine("\nInforme a data de empréstimo ('aaaa,mm,dd'):");
                    emp.setDtEmprestimo(Convert.ToDateTime(Console.ReadLine()));
                    Console.WriteLine("\nInforme a data de devolução ('aaaa,mm,dd'):");
                    emp.setDtDevolucao(Convert.ToDateTime(Console.ReadLine()));
                    Console.WriteLine("\nInforme o valor da multa:");
                    emp.setValorMulta(Convert.ToDouble(Console.ReadLine()));
                    emp.setExemplar(ex2);
                    Console.WriteLine("- - - Dados Pessoais - - -");
                    Console.WriteLine("\nInforme o nome:");
                    pes.setNome(Console.ReadLine());
                    Console.WriteLine("\nInforme o CPF:");
                    pes.setCpf(Console.ReadLine());
                    Console.WriteLine("\nInforme o RG:");
                    pes.setRg(Console.ReadLine());
                    Console.WriteLine("\nInforme o telefone:");
                    pes.setTelefone(Console.ReadLine());
                    Console.WriteLine("\nInforme o email:");
                    pes.setEmail(Console.ReadLine());
                    Console.WriteLine("\nInforme a data de nascimento ('aaaa,mm,dd'):");
                    pes.setDtNascimento(Convert.ToDateTime(Console.ReadLine()));
                    Console.WriteLine("\nA pessoa está liberada(o)? (Digite 'true' se estiver, ou digite 'false' se não estiver: ");
                    pes.setLiberado(Convert.ToBoolean(Console.ReadLine()));
                    Console.WriteLine("\n - - - Informe o endereço: - - -");
                    Console.WriteLine("\nInforme o CEP:");
                    e4.setCep(Console.ReadLine());
                    Console.WriteLine("\nInforme o logradouro:");
                    e4.setLogradouro(Console.ReadLine());
                    Console.WriteLine("\nInforme o número:");
                    e4.setNumero(Convert.ToInt32(Console.ReadLine()));
                    Console.WriteLine("\nInforme o bairro:");
                    e4.setBairro(Console.ReadLine());
                    Console.WriteLine("\nInforme o estado:");
                    e4.setEstado(Console.ReadLine());
                    Console.WriteLine("\nInforme a cidade:");
                    e4.setCidade(Console.ReadLine());
                    Console.WriteLine("\nInforme o complemento:");
                    e4.setBairro(Console.ReadLine());
                    pes.setEndereco(e4);
                }
                if (r == 6) // Cadastrar professor
                {
                    Console.Clear();
                    Console.WriteLine("\n=========================== Cadastrar Professor ===========================\n");
                    Console.WriteLine("\nInforme o nome:");
                    p.setNome(Console.ReadLine());
                    Console.WriteLine("\nInforme a graduação:");
                    p.setGraduacao(Console.ReadLine());
                    Console.WriteLine("\nInforme o CPF:");
                    p.setCpf(Console.ReadLine());
                    Console.WriteLine("\nInforme o RG:");
                    p.setRg(Console.ReadLine());
                    Console.WriteLine("\nInforme o telefone:");
                    p.setTelefone(Console.ReadLine());
                    Console.WriteLine("\nInforme o email:");
                    p.setEmail(Console.ReadLine());
                    Console.WriteLine("\nInforme o codigo:");
                    p.setCod(Convert.ToInt32(Console.ReadLine()));
                    Console.WriteLine("\nInforme a data de nascimento ('aaaa,mm,dd'):");
                    p.setDtNascimento(Convert.ToDateTime(Console.ReadLine()));
                    Console.WriteLine("\nO professor está liberado? (Digite 'true' se estiver, ou digite 'false' se não estiver: ");
                    p.setLiberado(Convert.ToBoolean(Console.ReadLine()));
                    Console.WriteLine("\n - - - Informe o endereço: - - -");
                    Console.WriteLine("\nInforme o CEP:");
                    e2.setCep(Console.ReadLine());
                    Console.WriteLine("\nInforme o logradouro:");
                    e2.setLogradouro(Console.ReadLine());
                    Console.WriteLine("\nInforme o número:");
                    e2.setNumero(Convert.ToInt32(Console.ReadLine()));
                    Console.WriteLine("\nInforme o bairro:");
                    e2.setBairro(Console.ReadLine());
                    Console.WriteLine("\nInforme o estado:");
                    e2.setEstado(Console.ReadLine());
                    Console.WriteLine("\nInforme a cidade:");
                    e2.setCidade(Console.ReadLine());
                    Console.WriteLine("\nInforme o complemento:");
                    e2.setBairro(Console.ReadLine());
                    p.setEndereco(e2);
                    Console.WriteLine("\nInforme a data de admissão ('aaaa,mm,dd'):");
                    p.setDtAdmissao(Convert.ToDateTime(Console.ReadLine()));
                    Console.WriteLine("\nInforme o salário:");
                    p.setSalario(Convert.ToDouble(Console.ReadLine()));
                }
                if (r == 7) // Cadastrar funcionário
                {
                    Console.Clear();
                    Console.WriteLine("\n=========================== Cadastrar Funcionário ===========================\n");
                    Console.WriteLine("\nInforme o nome:");
                    f.setNome(Console.ReadLine());
                    Console.WriteLine("\nInforme o cargo:");
                    f.setCargo(Console.ReadLine());
                    Console.WriteLine("\nInforme o CPF:");
                    f.setCpf(Console.ReadLine());
                    Console.WriteLine("\nInforme o RG:");
                    f.setRg(Console.ReadLine());
                    Console.WriteLine("\nInforme o telefone:");
                    f.setTelefone(Console.ReadLine());
                    Console.WriteLine("\nInforme o email:");
                    f.setEmail(Console.ReadLine());
                    Console.WriteLine("\nInforme o codigo:");
                    f.setCod(Convert.ToInt32(Console.ReadLine()));
                    Console.WriteLine("\nInforme a data de nascimento ('aaaa,mm,dd'):");
                    f.setDtNascimento(Convert.ToDateTime(Console.ReadLine()));
                    Console.WriteLine("\nO funcionário está liberado? (Digite 'true' se estiver, ou digite 'false' se não estiver: ");
                    f.setLiberado(Convert.ToBoolean(Console.ReadLine()));
                    Console.WriteLine("\n - - - Informe o endereço: - - -");
                    Console.WriteLine("\nInforme o CEP:");
                    e3.setCep(Console.ReadLine());
                    Console.WriteLine("\nInforme o logradouro:");
                    e3.setLogradouro(Console.ReadLine());
                    Console.WriteLine("\nInforme o número:");
                    e3.setNumero(Convert.ToInt32(Console.ReadLine()));
                    Console.WriteLine("\nInforme o bairro:");
                    e3.setBairro(Console.ReadLine());
                    Console.WriteLine("\nInforme o estado:");
                    e3.setEstado(Console.ReadLine());
                    Console.WriteLine("\nInforme a cidade:");
                    e3.setCidade(Console.ReadLine());
                    Console.WriteLine("\nInforme o complemento:");
                    e3.setBairro(Console.ReadLine());
                    f.setEndereco(e3);
                    Console.WriteLine("\nInforme a data de admissão ('aaaa,mm,dd'):");
                    f.setDtAdmissao(Convert.ToDateTime(Console.ReadLine()));
                    Console.WriteLine("\nInforme o salário:");
                    f.setSalario(Convert.ToDouble(Console.ReadLine()));
                }
                if (r == 8) // Visualizar cursos
                {
                    Console.Clear();
                    Console.WriteLine("\n=========================== Visualizar Curso ===========================\n");
                    Console.WriteLine("Nome: " + c.getNome());
                    Console.WriteLine("Área: " + c.getArea());
                    Console.WriteLine("Valor da mensalidade: " + c.getValorMensalidade());
                }
                if (r == 9) // Visualizar alunos
                {
                    Console.Clear();
                    Console.WriteLine("\n=========================== Visualizar Aluno ===========================\n");
                    Console.WriteLine("Nome: " + a.getNome());
                    Console.WriteLine("CPF: " + a.getCpf());
                    Console.WriteLine("RG: " + a.getRg());
                    Console.WriteLine("Matrícula: " + a.getMatricula());
                    Console.WriteLine("Telefone: " + a.getTelefone());
                    Console.WriteLine("Email: " + a.getEmail());
                    Console.WriteLine("Data de nascimento: " + a.getDtNascimento());
                    Console.WriteLine("Liberado: " + a.getLiberado());
                    Console.WriteLine("Situação: " + a.getSituacao());
                    Console.WriteLine("Data de início: " + a.getDtInicio());
                    Console.WriteLine("Data de conclusão: " + a.getDtConclusao());
                    Console.WriteLine("\n - - - Endereço: - - -");
                    Console.WriteLine("Logradouro: " + e1.getLogradouro());
                    Console.WriteLine("Número: " + e1.getNumero());
                    Console.WriteLine("Bairro: " + e1.getBairro());
                    Console.WriteLine("Cidade: " + e1.getCidade());
                    Console.WriteLine("Estado: " + e1.getEstado());
                    Console.WriteLine("Complemento: " + e1.getComplemento());
                    Console.WriteLine("CEP: " + e1.getCep());
                    Console.WriteLine("\n - - - Curso: - - -");
                    Console.WriteLine("Nome: " + c.getNome());
                    Console.WriteLine("Área: " + c.getArea());
                    Console.WriteLine("Valor da mensalidade: " + c.getValorMensalidade());
                    Console.WriteLine("Valor de desconto: " + a.getValorDesconto());             
                }
                if (r == 10) // Visualizar livros 
                {
                    Console.Clear();
                    Console.WriteLine("\n=========================== Visualizar Livro ===========================\n");
                    Console.WriteLine("Código: " + l.getCod());
                    Console.WriteLine("Nome: " + l.getNome());
                    Console.WriteLine("Autor: " + l.getAutor());
                    Console.WriteLine("Editora: " + l.getEditora());
                    Console.WriteLine("Edição: " + l.getEdicao());
                    Console.WriteLine("Ano de lançamento: " + l.getAnoLancamento());
                }
                if (r == 11) // Visualizar exemplares 
                {
                    Console.Clear();
                    Console.WriteLine("\n=========================== Visualizar Exemplar ===========================\n");
                    Console.WriteLine("Código: " + ex.getCod());
                    Console.WriteLine("Número do exemplar: " + ex.getNumExemplar());
                    Console.WriteLine("Exclusivo: " + ex.getExclusivo());
                    Console.WriteLine("- - - Livro: - - -");
                    Console.WriteLine("Código: " + l.getCod());
                    Console.WriteLine("Nome: " + l.getNome());
                    Console.WriteLine("Autor: " + l.getAutor());
                    Console.WriteLine("Editora: " + l.getEditora());
                    Console.WriteLine("Edição: " + l.getEdicao());
                    Console.WriteLine("Ano de lançamento: " + l.getAnoLancamento());
                }
                if (r == 12) // Visualizar empréstimos 
                {
                    Console.Clear();
                    Console.WriteLine("\n=========================== Visualizar Empréstimo ===========================\n");
                    Console.WriteLine("Código: " + emp.getCod());
                    Console.WriteLine("Data de empréstimo: " + emp.getDtEmprestimo());
                    Console.WriteLine("Data de devolução: " + emp.getDtDevolucao());
                    Console.WriteLine("Valor da multa: " + emp.getValorMulta());
                    Console.WriteLine("- - - Exemplar do empréstimo - - -");
                    Console.WriteLine("Código: " + ex2.getCod());
                    Console.WriteLine("Número do exemplar: " + ex2.getNumExemplar());
                    Console.WriteLine("Exclusivo: " + ex2.getExclusivo());
                    Console.WriteLine("- - - Livro: - - -");
                    Console.WriteLine("Código: " + l.getCod());
                    Console.WriteLine("Nome: " + l.getNome());
                    Console.WriteLine("Autor: " + l.getAutor());
                    Console.WriteLine("Editora: " + l.getEditora());
                    Console.WriteLine("Edição: " + l.getEdicao());
                    Console.WriteLine("Ano de lançamento: " + l.getAnoLancamento());
                    Console.WriteLine("- - - Dados Pessoais: - - -");
                    Console.WriteLine("Nome: " + pes.getNome());
                    Console.WriteLine("CPF: " + pes.getCpf());
                    Console.WriteLine("RG: " + pes.getRg());
                    Console.WriteLine("Telefone: " + pes.getTelefone());
                    Console.WriteLine("Email: " + pes.getEmail());
                    Console.WriteLine("Data de nascimento: " + pes.getDtNascimento());
                    Console.WriteLine("Liberado: " + pes.getLiberado());
                    Console.WriteLine("\n - - - Endereço: - - -");
                    Console.WriteLine("Logradouro: " + e4.getLogradouro());
                    Console.WriteLine("Número: " + e4.getNumero());
                    Console.WriteLine("Bairro: " + e4.getBairro());
                    Console.WriteLine("Cidade: " + e4.getCidade());
                    Console.WriteLine("Estado: " + e4.getEstado());
                    Console.WriteLine("Complemento: " + e4.getComplemento());
                    Console.WriteLine("CEP: " + e4.getCep());
                }
                if (r == 13) // Visualizar professores
                {
                    Console.Clear();
                    Console.WriteLine("\n=========================== Visualizar Professor ===========================\n");
                    Console.WriteLine("Codigo: " + p.getCod());
                    Console.WriteLine("Nome: " + p.getNome());
                    Console.WriteLine("CPF: " + p.getCpf());
                    Console.WriteLine("RG: " + p.getRg());
                    Console.WriteLine("Graduação: " + p.getGraduacao());
                    Console.WriteLine("Telefone: " + p.getTelefone());
                    Console.WriteLine("Email: " + p.getEmail());
                    Console.WriteLine("Data de nascimento: " + p.getDtNascimento());                    
                    Console.WriteLine("Liberado: " + p.getLiberado());
                    Console.WriteLine("Data de admissão: " + p.getDtAdmissao());
                    Console.WriteLine("Salario: " + p.getSalario());
                    Console.WriteLine("\n - - - Endereço: - - -");
                    Console.WriteLine("Logradouro: " + e2.getLogradouro());
                    Console.WriteLine("Número: " + e2.getNumero());
                    Console.WriteLine("Bairro: " + e2.getBairro());
                    Console.WriteLine("Cidade: " + e2.getCidade());
                    Console.WriteLine("Estado: " + e2.getEstado());
                    Console.WriteLine("Complemento: " + e2.getComplemento());
                    Console.WriteLine("CEP: " + e2.getCep());
                }
                if (r == 14) // Visualizar funcionários
                {
                    Console.Clear();
                    Console.WriteLine("\n=========================== Visualizar Funcionário ===========================\n");
                    Console.WriteLine("Codigo: " + f.getCod());
                    Console.WriteLine("Nome: " + f.getNome());
                    Console.WriteLine("CPF: " + f.getCpf());
                    Console.WriteLine("RG: " + f.getRg());
                    Console.WriteLine("Cargo: " + f.getCargo());
                    Console.WriteLine("Telefone: " + f.getTelefone());
                    Console.WriteLine("Email: " + f.getEmail());
                    Console.WriteLine("Data de nascimento: " + f.getDtNascimento());
                    Console.WriteLine("Liberado: " + f.getLiberado());
                    Console.WriteLine("Data de admissão: " + f.getDtAdmissao());
                    Console.WriteLine("Salario: " + f.getSalario());
                    Console.WriteLine("\n - - - Endereço: - - -");
                    Console.WriteLine("Logradouro: " + e3.getLogradouro());
                    Console.WriteLine("Número: " + e3.getNumero());
                    Console.WriteLine("Bairro: " + e3.getBairro());
                    Console.WriteLine("Cidade: " + e3.getCidade());
                    Console.WriteLine("Estado: " + e3.getEstado());
                    Console.WriteLine("Complemento: " + e3.getComplemento());
                    Console.WriteLine("CEP: " + e3.getCep());
                }
                Console.WriteLine("\n================================================================================================\nTecle '0' para sair do programa, ou tecle qualquer outro número para realizar uma nova operação: ");
                x = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            }
        }
    }
}
