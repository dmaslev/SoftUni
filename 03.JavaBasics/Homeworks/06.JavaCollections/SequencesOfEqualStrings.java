import java.util.ArrayList;
import java.util.Scanner;

public class SequencesOfEqualStrings {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		String[] inputElements = scanner.nextLine().split("\\s+");

		ArrayList<String> results = new ArrayList<>();
		results.add(inputElements[0]);
		for (int i = 1; i < inputElements.length; i++) {
			if (inputElements[i].equals(inputElements[i - 1])) {
				results.add(inputElements[i]);
			} else {
				System.out.println(String.join(" ", results));
				results.clear();
				results.add(inputElements[i]);
			}
		}
		System.out.println(String.join(" ", results));
	}
}
