import java.util.Scanner;

public class MirrorNumbers {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		int n = Integer.parseInt(scanner.nextLine());
		int[] numbers = new int[n];

		for (int i = 0; i < numbers.length; i++) {
			numbers[i] = scanner.nextInt();
		}

		boolean foundMirrorNumbers = false;
		for (int i = 0; i < numbers.length; i++) {
			for (int j = i + 1; j < numbers.length; j++) {
				String firstNumber = "" + numbers[i];
				String secondNumber = "" + numbers[j];
				if (firstNumber.equals(new StringBuilder(secondNumber).reverse().toString())) {
					System.out.printf("%s<!>%s\n", firstNumber, secondNumber);
					foundMirrorNumbers = true;
				}
			}
		}

		if (!foundMirrorNumbers) {
			System.out.println("No");
		}
	}
}
