package labr1;

import java.util.ArrayList;
import java.util.Scanner;

public class MyTask {
	public static void Dotask() {
		Scanner sc = new Scanner(System.in);
		System.out.print("¬ведите количество чисел > ");
		int n = sc.nextInt();
		
		double a;
		ArrayList<Double> aa = new ArrayList();
		
		for(int i = 0; i < n ; i++) {
			System.out.print("¬ведите число " + String.valueOf(i+1) + " > ");
			a = sc.nextDouble();
			aa.add(a);
		}
		
		double b = 0;
		System.out.println("–езультирующа€ последовательность: ");
		for(int i = 0 ; i < n; i++) {
			b += (aa.get(i) + i);
			System.out.println(b);
		}
		
		sc.close();
	}
}
