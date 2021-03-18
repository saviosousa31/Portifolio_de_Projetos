package controle;

import java.util.Scanner;

public class ex2 {

	public static void main(String[] args) {
		Scanner entrada = new Scanner(System.in);
		System.out.println("Informe o ano atual: ");
		int ano = entrada.nextInt();
		if (ano % 400 == 0) {
			System.out.println("O ano " + ano + " é bissexto.");
		} else if ((ano % 4 == 0) && (ano % 100 != 0)) {
				System.out.println("O ano " + ano + " é bissexto.");
			} else
				System.out.println("O ano " + ano + " não é bissexto.");
			entrada.close();
	}
}