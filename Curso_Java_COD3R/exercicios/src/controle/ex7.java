package controle;

import java.util.Scanner;

public class ex7 {

	public static void main(String[] args) {
		Scanner entrada = new Scanner(System.in);

		int total = 0;
		int resposta = 0;

		while (resposta >= 0) {
			System.out.print("Digite um número: ");
			resposta = entrada.nextInt();
			if (resposta >= 0) {
				total += resposta;
			}
			System.out.println("A soma dos valores digitados até o momento é " + total);
		}

		entrada.close();
	}
}
