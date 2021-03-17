package fundamentos;

import javax.swing.JOptionPane;

public class DesafioConversao {
	
	public static void main(String[] args) {
		
		
		String s1 = JOptionPane.showInputDialog("Digite o primeiro salário:");
		String s2 = JOptionPane.showInputDialog("Digite o segundo salário:");
		String s3 = JOptionPane.showInputDialog("Digite o terceiro salário:");
		
		double sal1 = Double.parseDouble(s1.replace(',', '.'));
		double sal2 = Double.parseDouble(s2.replace(',', '.'));
		double sal3 = Double.parseDouble(s3.replace(',', '.'));
		
		double media = (sal1 + sal2 + sal3)/3;
		
		JOptionPane.showMessageDialog(null,"A média dos salários é: R$" + media + ".");
		
	}

}
