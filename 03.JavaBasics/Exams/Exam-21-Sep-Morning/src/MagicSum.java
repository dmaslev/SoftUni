import java.util.ArrayList;
import java.util.Collections;
import java.util.Scanner;

public class MagicSum {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		int d = Integer.parseInt(scanner.nextLine());
		ArrayList<Integer> numbers = new ArrayList<>();
		String input = scanner.nextLine();

		while (!input.equals("End")) {
			numbers.add(Integer.parseInt(input));
			input = scanner.nextLine();
		}

		int maxSumm = Integer.MIN_VALUE;
		String result = "";
		for (int i = 0; i < numbers.size(); i++) {
			for (int j = i + 1; j < numbers.size(); j++) {
				for (int j2 = j + 1; j2 < numbers.size(); j2++) {
					int a = numbers.get(i);
					int b = numbers.get(j);
					int c = numbers.get(j2);
					int summ = a + b + c;
					if ((a + b + c) % d == 0) {
						if (summ > maxSumm) {
							maxSumm = summ;
							result = String.format("(%d + %d + %d) %% %d = 0", a, b, c, d);
						}
					}
				}
			}
		}
		if (!result.equals("")) {
			System.out.println(result);
		} else {
			System.out.println("No");
		}
	}
}
