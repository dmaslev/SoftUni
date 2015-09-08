import java.util.Scanner;

public class CountOfAllWords {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		String[] words = scanner.nextLine().split("\\W+");
		System.out.println(words.length);
	}
}
