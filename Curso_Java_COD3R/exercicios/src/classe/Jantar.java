package classe;

public class Jantar {
	
	public static void main(String[] args) {
		
		Pessoa p1 = new Pessoa();
		Comida c1 = new Comida("macarrao", 0.250);
		Comida c2 = new Comida("brigadeiro", 0.150);
		
		System.out.println(p1.nome + " - " + p1.peso);

		p1.comer(c1);
		System.out.println(p1.nome + " - " + p1.peso);

		p1.comer(c2);
		System.out.println(p1.nome + " - " + p1.peso);
	}

}
