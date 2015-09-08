import java.util.ArrayList;
import java.util.Arrays;
import java.util.Scanner;

public class CombineListOfLetters {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		String[] l1 = scanner.nextLine().split(" ");
		String[] l2 = scanner.nextLine().split(" ");
		ArrayList<Character> firstList = new ArrayList<Character>();
		ArrayList<Character> secondList = new ArrayList<Character>();

		addCharactersToList(l1, firstList);
		addCharactersToList(l2, secondList);

		for (Character character : secondList) {
			if (!firstList.contains(character)) {
				firstList.add(character);
			}
		}

		for (Character character : firstList) {
			System.out.print(character + " ");
		}
	}

	private static void addCharactersToList(String[] l1, ArrayList<Character> firstList) {
		for (String character : l1) {
			firstList.add(character.charAt(0));
		}
	}
}
