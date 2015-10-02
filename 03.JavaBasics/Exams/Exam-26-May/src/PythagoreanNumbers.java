import java.util.Arrays;
import java.util.Scanner;

public class PythagoreanNumbers {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		int n = Integer.parseInt(scanner.nextLine());
		int[] numbers = new int[n];
		
		for (int i = 0; i < numbers.length; i++) {
			numbers[i] = Integer.parseInt(scanner.nextLine());
		}
		Arrays.sort(numbers);
		
		boolean foundPythagoreanNumbers = false;
		for (int i = 0; i < numbers.length; i++) {
			for (int j = i; j < numbers.length; j++) {
				for (int j2 = j; j2 < numbers.length; j2++) {
					int a = numbers[i];
					int b = numbers[j];
					int c = numbers[j2];
					if (a*a + b*b == c*c) {
						System.out.printf("%1$d*%1$d + %2$d*%2$d = %3$d*%3$d\n", a, b, c);
						foundPythagoreanNumbers = true;
					}
				}
			}
		}
		
		if (!foundPythagoreanNumbers) {
			System.out.println("No");
		}
	}
}
