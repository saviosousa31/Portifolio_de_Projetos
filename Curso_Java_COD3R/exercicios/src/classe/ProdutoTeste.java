package classe;

public class ProdutoTeste {

	public static void main(String[] args) {

		Produto p1 = new Produto("Notebook", 4356.89);

		System.out.printf("Produto: %s\nPreço: R$%.2f\nPreço com desconto: R$%.2f", 
				p1.nome, p1.preco, p1.precoComDesconto());
	}
}
