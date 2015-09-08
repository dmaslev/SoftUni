import java.util.HashSet;
import java.util.Scanner;
import java.util.Set;
import java.util.TreeSet;

public class ExtractAllUniqueWords {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		String[] text = scanner.nextLine().toLowerCase().split("\\W+");

		Set<String> uniqueWords = new TreeSet();
		for (String word : text) {
			uniqueWords.add(word);
		}

		System.out.println(String.join(" ", uniqueWords));
	}
}
