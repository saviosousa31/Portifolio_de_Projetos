package fundamentos;

import javax.swing.JOptionPane;

public class DesafioConversao {
	
	public static void main(String[] args) {
		
		
		String s1 = JOptionPane.showInputDialog("Digite o primeiro sal�rio:");
		String s2 = JOptionPane.showInputDialog("Digite o segundo sal�rio:");
		String s3 = JOptionPane.showInputDialog("Digite o terceiro sal�rio:");
		
		double sal1 = Double.parseDouble(s1.replace(',', '.'));
		double sal2 = Double.parseDouble(s2.replace(',', '.'));
		double sal3 = Double.parseDouble(s3.replace(',', '.'));
		
		double media = (sal1 + sal2 + sal3)/3;
		
		JOptionPane.showMessageDialog(null,"A m�dia dos sal�rios �: R$" + media + ".");
		
	}

}
