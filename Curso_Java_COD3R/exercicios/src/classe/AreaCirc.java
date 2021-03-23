package classe;

public class AreaCirc {
	
	double raio;
	static final double pi = 3.14159; // constante pertencente à classe
	
	AreaCirc(double raio) {
		this.raio = raio;
	}
	
	double area() {
		return pi * Math.pow(raio, 2);
	}
	
	static double area(double raio) { // método de classe
		return pi * Math.pow(raio,2);
	}

}
