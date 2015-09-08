import java.util.Arrays;
import java.util.Scanner;

public class SortArrayOfNumbers {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		int numberOfElements = Integer.parseInt(scanner.nextLine());
		int[] numbers = new int[numberOfElements];
		
		for (int i = 0; i < numberOfElements; i++) {
			numbers[i] = scanner.nextInt();
		}
		
		Arrays.sort(numbers);
		
		for (int number : numbers) {
			System.out.printf("%d ", number);
		}
	}
}
