package controle;

import java.util.Scanner;

public class DesafioWhile {

	public static void main(String[] args) {

		double total = 0;
		int cont = 0;
		double resposta = 0;
		Scanner entrada = new Scanner(System.in);

		while (resposta != -1) {
			System.out.println("Digite uma nota: ");
			resposta = entrada.nextDouble();
			while (resposta < -1 || resposta > 10) {
				System.out.println("Digite uma nota v�lida! ");
				resposta = entrada.nextDouble();
			}
			if (resposta != -1) {
				total += resposta;
				cont++;
			}
		}
		System.out.println("A media das notas � de " + total / cont + " pontos.");
		entrada.close();
	}
}
