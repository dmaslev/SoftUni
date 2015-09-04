import java.util.Random;
import java.util.Scanner;

public class RandomHandsOf5Cards {
	public static void main(String[] args) {
		Scanner scanne = new Scanner(System.in);
		int n = scanne.nextInt();
		Random random = new Random();

		String[] suits = { "\u2660", "\u2665", "\u2666", "\u2663" };
		String[] faces = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

		for (int i = 0; i < n; i++) {
			for (int j = 0; j < 5; j++) {
				int face = random.nextInt(13);
				int suit = random.nextInt(4);
				System.out.printf("%s%s ", faces[face], suits[suit]);
			}
			System.out.println();
		}
	}
}
