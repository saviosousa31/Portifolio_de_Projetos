using System;

namespace POO_Exercicio_1_Savio_Sousa
{
    public class Produto
    {
        private string descricao, marca, tipo;

        public Produto(string descricao, string marca, string tipo)
        {
            this.descricao = descricao;
            this.marca = marca;
            this.tipo = tipo;
        }

        public void setDescricao(string descricao)
        {
            this.descricao = descricao;
        }
        public string getDescricao()
        {
            return descricao;
        }
        public void setMarca(string marca)
        {
            this.marca = marca;
        }
        public string getMarca()
        {
            return marca;
        }
        public void setTipo(string tipo)
        {
            this.tipo = tipo;
        }
        public string getTipo()
        {
            return tipo;
        }
    }
    public class ItemProduto : Produto
    {
        private double preco_custo, preco_venda, margem_lucro;
        private bool vendido = false;

        public ItemProduto(string descricao, string marca, string tipo, double preco_custo, double preco_venda, double margem_lucro, bool vendido):base(descricao, marca, tipo) { 
            this.preco_custo = preco_custo;
            this.preco_venda = preco_venda;
            this.vendido = vendido;
        }
        public void setPrecoCusto(double preco_custo)
        {
            this.preco_custo = preco_custo;
        }
        public double getPrecoCusto()
        {
            return preco_custo;
        }
        public void setPrecoVenda(double preco_venda)
        {
            if(preco_venda < preco_custo)
            {
                Console.WriteLine("O preco de venda deve ser maior que o preco de custo. Por favor, insira um novo valor: ");
                setPrecoVenda(preco_venda);
            }
            this.preco_venda = preco_venda;
        }
        public double getPrecoVenda()
        {
            return preco_venda;
        }
        public void setVendido(bool vendido)
        {
            this.vendido = vendido;
        }
        public bool getVendido()
        {
            return vendido;
        }
        public double CalcularMargemLucro()
        {
            margem_lucro = preco_venda - preco_custo;
            return margem_lucro;
        }        
        public double MargemLucroPorcentagem()
        {
            return ((preco_venda * 100) / preco_custo) - 100;
        }
    }

    class Exercicio_1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o preco de custo do produto: ");
            double pc = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o preco de venda do produto: ");
            double pv = Convert.ToDouble(Console.ReadLine());
            if(pv < pc)
            {
                while (pv < pc)
                {
                    Console.WriteLine("O preco de venda deve ser maior que o preco de custo. Por favor, insira um novo valor: ");
                    pv = Convert.ToDouble(Console.ReadLine());
                }
            }
            double margem_lucro = pv - pc;
            Console.WriteLine("O produto ja foi vendido? [Digite 'true' para sim, e 'false' para nao: ");
            bool vendido = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Digite a descricao do produto: ");
            string descricao = Console.ReadLine();
            Console.WriteLine("Digite a marca do produto: ");
            string marca = Console.ReadLine();
            Console.WriteLine("Digite o tipo do produto: ");
            string tipo = Console.ReadLine();
            Console.WriteLine("------------------------------------------------------------------");


            ItemProduto prod1 = new ItemProduto(descricao, marca, tipo, pc,pv, margem_lucro, vendido);
            Console.WriteLine("Preco de custo: " + prod1.getPrecoCusto());
            Console.WriteLine("Preco de venda: " + prod1.getPrecoVenda());
            Console.WriteLine("O produto ja foi vendido? " + prod1.getVendido());
            Console.WriteLine("Marca do produto: " + prod1.getMarca());
            Console.WriteLine("Tipo do produto: " + prod1.getTipo());
            Console.WriteLine("Descricao do produto: " + prod1.getDescricao());
            Console.WriteLine("Lucro em Moeda: " + prod1.CalcularMargemLucro());
            Console.WriteLine("Lucro percentual: " + prod1.MargemLucroPorcentagem() + "%");
        }
    }
}