package labr1;

import java.util.ArrayList;
import java.util.Scanner;

public class MyTask2Edit {
	private ArrayList<Double> aa = new ArrayList<Double>();
	private int n;
	
	public void InputArray()
	{
		aa.clear();
		Scanner sc = new Scanner(System.in);
		System.out.print("������� ���������� ����� > ");
		int n = sc.nextInt();
		
		double a;
		for(int i = 0; i < n ; i++) {
			System.out.print("������� ����� " + String.valueOf(i+1) + " > ");
			a = sc.nextDouble();
			aa.add(a);
		}
		sc.close();
	}
	
	public void PrintResult() {
		double b = 0;
		System.out.println("�������������� ������������������: ");
		for(int i = 0 ; i < n; i++) {
			b += (aa.get(i) + i);
			System.out.println(b);
	}
}
}
