import java.util.Scanner;
import java.util.concurrent.ConcurrentHashMap;

public class StuckNumbers {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		int count = Integer.parseInt(scanner.nextLine());
		int[] numbers = new int[count];
		for (int i = 0; i < count; i++) {
			numbers[i] = scanner.nextInt();
		}

		boolean foundStuckNumbers = false;
		for (int i = 0; i < numbers.length; i++) {
			for (int j = 0; j < numbers.length; j++) {
				for (int j2 = 0; j2 < numbers.length; j2++) {
					for (int k = 0; k < numbers.length; k++) {
						if (i != j && i != j2 && i != k && j != j2 && j != k && j2 != k) {
							String first = "" + numbers[i] + numbers[j];
							String second = "" + numbers[j2] + numbers[k];
							if (first.equals(second)) {
								System.out.printf("%d|%d==%d|%d", numbers[i], numbers[j], numbers[j2], numbers[k])
										.println();
								foundStuckNumbers = true;
							}
						}
					}
				}
			}
		}

		if (!foundStuckNumbers) {
			System.out.println("No");
		}
	}
}
