import java.util.Collections;
import java.util.Map;
import java.util.Scanner;
import java.util.TreeMap;

public class MostFrequentWord {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		String[] input = scanner.nextLine().toLowerCase().split("\\W+");
		
		Map<String, Integer> words = new TreeMap<String, Integer>();
		
		for (String word : input) {
			if (!words.containsKey(word)) {
				words.put(word, 1);
			}else {
				int count = words.get(word);
				words.put(word, ++count);
			}
		}
		
		printResult(words);
	}

	private static void printResult(Map<String, Integer> words) {
		int maxCount = Collections.max(words.values());
		for (String word : words.keySet()) {
			if (words.get(word) == maxCount) {
				System.out.printf("%s -> %d times", word, words.get(word)).println();;
			}
		}
	}
}
