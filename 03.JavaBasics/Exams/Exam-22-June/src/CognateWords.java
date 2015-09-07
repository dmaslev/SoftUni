import java.util.HashSet;
import java.util.Scanner;

public class CognateWords {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		String[] words = scanner.nextLine().split("[^a-zA-Z]+");
		
		HashSet<String> result = new HashSet<>();
		for (String string : words) {
			for (int i = 0; i < words.length; i++) {
				for (int j = 0; j < words.length; j++) {
					if (string.equals(words[i] + words[j])) {
						result.add(String.format("%s|%s=%s", words[i], words[j], string));
					}
				}
			}
		}
		if (result.isEmpty()) {
			System.out.println("No");
			return;
		}
		
		for (String string : result) {
			System.out.println(string);
		}
	}
}
