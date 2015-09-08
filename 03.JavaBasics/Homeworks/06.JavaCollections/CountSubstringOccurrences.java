import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class CountSubstringOccurrences {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		String text = scanner.nextLine().toLowerCase();
		String word = scanner.nextLine();

		Pattern pattern = Pattern.compile(word);
		Matcher matcher = pattern.matcher(text);

		int counter = 0;
		while (matcher.find()) {
			++counter;
			int firstIndex = matcher.start();
			matcher.region(firstIndex + 1, text.length());
		}
		
		System.out.println(counter);
	}
}
