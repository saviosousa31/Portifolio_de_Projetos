package controle;

import java.util.Scanner;

public class ex1 {

	public static void main(String[] args) {
		Scanner entrada = new Scanner(System.in);
		
		System.out.println("Digite um n�mero par e que esteja entre 0 e 10: ");
		int num = entrada.nextInt();
		
		if(num > 0 && num < 10 && num % 2 == 0) {
			System.out.println("O n�mero � par e est� entre 0 e 10!");
		} else {
			System.out.println("O n�mero n�o corresponde aos requisitos!");
		}
		
		entrada.close();
	}
}
