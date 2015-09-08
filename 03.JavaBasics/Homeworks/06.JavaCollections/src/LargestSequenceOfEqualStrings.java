import java.util.Scanner;

public class LargestSequenceOfEqualStrings {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		String[] inputElements = scanner.nextLine().split("\\s+");

		int longestSequenceCounter = 1;
		String longestSequenceWord = inputElements[0];
		int currentCounter = 1;

		for (int i = 1; i < inputElements.length; i++) {
			if (inputElements[i].equals(inputElements[i - 1])) {
				currentCounter++;
			}
			else {
				currentCounter = 1;
			}
			if (currentCounter > longestSequenceCounter) {
				longestSequenceCounter = currentCounter;
				longestSequenceWord = inputElements[i];
			}
		}

		for (int i = 0; i < longestSequenceCounter; i++) {
			System.out.printf("%s ", longestSequenceWord);
		}
	}
}
