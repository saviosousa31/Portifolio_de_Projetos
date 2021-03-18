package classe;

public class Produto {

	String nome;
	double preco;
	double desconto;
	
	Produto(){
		
	}
	
	Produto(String nome, double preco, double desconto){
		this.nome = nome;
		this.preco = preco;
		this.desconto = desconto;
	}
	
	double precoComDesconto() {
		return preco * (1 - desconto);		 
	}
}
