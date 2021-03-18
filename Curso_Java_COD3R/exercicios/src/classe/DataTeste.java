package classe;

public class DataTeste {

	public static void main(String[] args) {
		
		Data d1 = new Data(31, 1, 2001);
		Data d2 = new Data();
		
		System.out.println(d1.dataFormatada());
		System.out.println(d2.dataFormatada());
	}
}
