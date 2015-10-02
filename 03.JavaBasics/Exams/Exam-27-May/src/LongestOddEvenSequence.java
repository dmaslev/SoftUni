import java.util.ArrayList;
import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class LongestOddEvenSequence {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		ArrayList<String> list = new ArrayList<>();
		String input = scanner.nextLine();

		Pattern pattern = Pattern.compile("-*\\d+");
		Matcher matcher = pattern.matcher(input);
		while (matcher.find()) {
			list.add(matcher.group(0).toString());
		}

		int[] numbers = new int[list.size()];
		for (int i = 0; i < numbers.length; i++) {
			numbers[i] = Integer.parseInt(list.get(i));
		}

		int bestLen = 0;
		int len = 0;
		boolean shouldBeOdd = (numbers[0] % 2 != 0);
		for (int num : numbers) {
			boolean isOdd = num % 2 != 0;
			if (isOdd == shouldBeOdd || num == 0) {
				len++;
			} else {
				shouldBeOdd = isOdd;
				len = 1;
			}
			shouldBeOdd = !shouldBeOdd;
			if (len > bestLen) {
				bestLen = len;
			}
		}

		System.out.println(bestLen);

	}
}
