import java.util.ArrayList;
import java.util.Arrays;
import java.util.Scanner;

public class Pyramid {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		int n = Integer.parseInt(scanner.nextLine().trim());
		String input = scanner.nextLine().trim();
		int firstNumber = Integer.parseInt(input);
		ArrayList<String> result = new ArrayList<>();
		result.add("" + firstNumber);

		for (int i = 0; i < n - 1; i++) {
			String[] array = scanner.nextLine().trim().split("\\s+");
			int[] numbers = new int[array.length];
			for (int j = 0; j < numbers.length; j++) {
				numbers[j] = Integer.parseInt(array[j]);
			}
			Arrays.sort(numbers);
			boolean isBreak = false;

			for (int j : numbers) {
				if (j > firstNumber) {
					result.add("" + j);
					firstNumber = j;
					isBreak = true;
					break;
				}
			}

			if (!isBreak) {
				firstNumber++;
			}
		}

		System.out.printf("%s", String.join(", ", result));
	}
}
