package controle;

import java.util.Random;
import java.util.Scanner;

public class ex6 {

	public static void main(String[] args) {
		Scanner entrada = new Scanner(System.in);

		int cont = 1;
		Random numaleatorio = new Random();
		int numsorteado = numaleatorio.nextInt(101);
		int resposta;

		do {
			System.out.print("Sua tentativa de número " + cont + " é: ");
			resposta = entrada.nextInt();
			if (resposta == numsorteado) {
				System.out.println("\nUAU! Você acertou o número aleatório!");
			} else {
				System.out.println("\nVocê errou!");
			}
			cont++;

		} while (cont < 11 && resposta != numsorteado);

		System.out.println("\nO número aleatório era o número " + numsorteado);
		entrada.close();
	}
}
