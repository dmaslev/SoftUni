import java.util.Scanner;

public class LongestIncreasingSequence {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		String[] input = scanner.nextLine().split("\\s+");
		int[] numbers = new int[input.length];
		for (int i = 0; i < numbers.length; i++) {
			numbers[i] = Integer.parseInt(input[i]);
		}

		String currentSequence = "" + numbers[0];
		String longestSequence = "" + numbers[0];
		int longestSequenceCount = 1;
		int currentSequenceCount = 1;
		
		for (int i = 1; i < numbers.length; i++) {
			if (numbers[i] > numbers[i-1]) {
				currentSequence += " " + numbers[i];
				currentSequenceCount++;
			}else {
				System.out.println(currentSequence);
				currentSequence = "" + numbers[i];
				currentSequenceCount = 1;
			}
			
			if (currentSequenceCount > longestSequenceCount) {
				longestSequenceCount = currentSequenceCount;
				longestSequence = currentSequence;
			}
		}
		System.out.println(currentSequence);
		System.out.printf("Longest: %s", longestSequence);
	}
}
