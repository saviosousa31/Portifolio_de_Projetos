package controle;

import java.util.Scanner;

public class ex9 {

	public static void main(String[] args) {
		Scanner entrada = new Scanner(System.in);
		
		int numfinal = 0;
		
		for (int i = 0; i < 10; i++) {
			
			System.out.print("Digite um número: ");
			int resposta = entrada.nextInt();
			if(resposta > numfinal)
				numfinal = resposta;
		}		
		
		System.out.println("O maior número digitado foi: " + numfinal);
		
		entrada.close();
	}
}
