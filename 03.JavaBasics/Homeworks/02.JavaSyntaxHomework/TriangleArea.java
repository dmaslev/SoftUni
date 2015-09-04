import java.util.Scanner;

public class TriangleArea {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		
		int a1 = scanner.nextInt();
		int a2 = scanner.nextInt();
		int b1 = scanner.nextInt();
		int b2 = scanner.nextInt();
		int c1 = scanner.nextInt();
		int c2 = scanner.nextInt();
		double area = (a1 * (b2 - c2) + b1 * (c2 - a2) + c1 * (a2 - b2)) / 2;
		System.out.printf("%.0f", Math.abs(area));	
	}
}
