package controle;

import java.util.Scanner;

public class ex1 {

	public static void main(String[] args) {
		Scanner entrada = new Scanner(System.in);
		
		System.out.println("Digite um número par e que esteja entre 0 e 10: ");
		int num = entrada.nextInt();
		
		if(num > 0 && num < 10 && num % 2 == 0) {
			System.out.println("O número é par e está entre 0 e 10!");
		} else {
			System.out.println("O número não corresponde aos requisitos!");
		}
		
		entrada.close();
	}
}
