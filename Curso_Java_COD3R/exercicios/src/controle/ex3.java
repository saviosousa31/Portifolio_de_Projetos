package controle;

import java.util.Scanner;

public class ex3 {

	public static void main(String[] args) {
		Scanner entrada = new Scanner(System.in);

		System.out.println("Digite a nota do aluno: ");
		double nota = entrada.nextDouble();

		if (nota > 10 || nota < 0) {
			System.out.println("A nota é inválida!");
		} else {
			if (nota >= 7) {
				System.out.println("Aprovado!");
			} else if (nota >= 4) {
				System.out.println("Recuperação!");
			} else
				System.out.println("Reprovado");
		}

		entrada.close();
	}
}
