import java.util.Scanner;

public class Generate3LetterWords {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		char[] letters = scanner.nextLine().toCharArray();
		
		for (int i = 0; i < letters.length; i++) {
			for (int j = 0; j < letters.length; j++) {
				for (int k = 0; k < letters.length; k++) {
					System.out.printf("%c%c%c ", letters[i], letters[j], letters[k]);
				}
			}
		}
	}
}
