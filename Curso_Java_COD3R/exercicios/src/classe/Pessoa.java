package classe;

public class Pessoa {
	
	String nome;
	double peso;
	
	Pessoa(){
		this("joao", 60.0);		
	}
	
	Pessoa(String nome, double peso){
		this.nome = nome;
		this.peso = peso;
	}
	
	void comer(Comida c){
		peso += c.peso;
		
	}
}
