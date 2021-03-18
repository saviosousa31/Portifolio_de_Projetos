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
			System.out.print("Sua tentativa de n�mero " + cont + " �: ");
			resposta = entrada.nextInt();
			if (resposta == numsorteado) {
				System.out.println("\nUAU! Voc� acertou o n�mero aleat�rio!");
			} else {
				System.out.println("\nVoc� errou!");
			}
			cont++;

		} while (cont < 11 && resposta != numsorteado);

		System.out.println("\nO n�mero aleat�rio era o n�mero " + numsorteado);
		entrada.close();
	}
}
