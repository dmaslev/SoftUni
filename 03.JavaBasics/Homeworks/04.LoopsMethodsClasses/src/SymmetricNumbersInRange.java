import java.util.Scanner;

public class SymmetricNumbersInRange {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		int start = scanner.nextInt();
		int end = scanner.nextInt();

		for (int i = start; i <= end; i++) {
			if (checIfIsSymmetric(i)) {
				System.out.printf("%d ", i);
			}
		}

		scanner.close();
	}

	private static boolean checIfIsSymmetric(int number) {
		String numberAsString = Integer.toString(number);
		String reversedNumber = new StringBuilder(numberAsString).reverse().toString();

		if (numberAsString.compareTo(reversedNumber) ==0) {
			return true;
		}

		return false;
	}
}
