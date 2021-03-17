package fundamentos;
import java.util.Date;
import java.util.Scanner;

public class AreaCircunferencia {
	public static void main(String[] args) {
		
		double raio;
		
		Scanner entrada = new Scanner(System.in);
		raio = entrada.nextDouble();
		
		final double PI = 3.14159;    // usar final para constantes
		double area = PI * raio * raio;
		entrada.close();
		
		System.out.println(area);
	}

}
