import java.util.ArrayList;
import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class WeirdStrings {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		String line = scanner.nextLine();
		line = line.replaceAll("[\\\\/()|\\s]+", "");

		ArrayList<String> allWords = new ArrayList<>();
		Pattern pattern = Pattern.compile("[a-zA-Z]+");
		Matcher matcher = pattern.matcher(line);
		while (matcher.find()) {
			allWords.add(matcher.group(0));
		}

		int maxWeight = Integer.MIN_VALUE;
		int firstIndex = 0;
		for (int i = 0; i < allWords.size() - 1; i++) {
			String currentWord = allWords.get(i).toLowerCase();
			String next = allWords.get(i + 1).toLowerCase();
			int currentWeight = 0;
			for (char ch : currentWord.toCharArray()) {
				currentWeight += ch - 96;
			}
			for (char ch : next.toCharArray()) {
				currentWeight += ch - 96;
			}

			if (currentWeight > maxWeight) {
				maxWeight = currentWeight;
				firstIndex = i;
			}
		}

		System.out.println(allWords.get(firstIndex));
		System.out.println(allWords.get(firstIndex + 1));
	}
}
