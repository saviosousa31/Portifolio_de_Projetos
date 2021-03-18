package controle;

import java.util.Scanner;

public class ex4 {

	public static void main(String[] args) {
		Scanner entrada = new Scanner(System.in);

		int resultado = 0;
		System.out.println("Digite um número: ");
		int num = entrada.nextInt();

		for (int i = 2; i <= num - 1; i++) {
			if (num % i == 0)
				resultado++;
		}

		if (resultado == 0)
			System.out.println("O número " + num + " é primo!");
		else
			System.out.println("O número " + num + "  não é primo!");

		entrada.close();
	}
}
