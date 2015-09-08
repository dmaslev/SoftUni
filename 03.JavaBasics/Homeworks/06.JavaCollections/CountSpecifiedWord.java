import java.util.Scanner;

public class CountSpecifiedWord {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		String[] allWords = scanner.nextLine().toLowerCase().split("\\W+");
		String specialWord = scanner.nextLine().toLowerCase();
		
		int counter = 0;
		for (String word : allWords) {
			if (word.equals(specialWord)) {
				counter++;
			}
		}
		
		System.out.println(counter);
	}
}
