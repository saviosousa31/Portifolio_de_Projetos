package fundamentos;

import javax.swing.JOptionPane;

public class JanelaInterativa {
	
	public static void main(String[] args) {
		
		String valor1 = JOptionPane.showInputDialog("Digite o primeiro n�mero: ");
		String valor2 = JOptionPane.showInputDialog("Digite o segundo n�mero: ");
		
		double numero1 = Double.parseDouble(valor1);
		double numero2 = Double.parseDouble(valor2);
		double soma = numero1 + numero2;
		
		JOptionPane.showMessageDialog(null, soma);
	}

}
