import java.util.Scanner;

public class FullHouse {
	public static void main(String[] args) {
		String[] cardFaces = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
		char[] cardSuits =  { '\u2663', '\u2666', '\u2665', '\u2660' };
		int counter = 0;

		for (int i = 0; i < cardFaces.length; i++) {
			for (int j = 0; j < cardFaces.length; j++) {
				if (i != j) {
					for (int j2 = 0; j2 < cardSuits.length; j2++) {
						for (int k = j2 + 1; k < cardSuits.length; k++) {
							for (int k2 = k + 1; k2 < cardSuits.length; k2++) {
								for (int l = 0; l < cardSuits.length; l++) {
									for (int l2 = l + 1; l2 < cardSuits.length; l2++) {
										System.out.printf("(%s%c %s%c %s%c %s%c %s%c)", cardFaces[i], cardSuits[j2],
												cardFaces[i], cardSuits[k], cardFaces[i], cardSuits[k2], cardFaces[j],
												cardSuits[l], cardFaces[j], cardSuits[l2]);
										System.out.println();
										++counter;
									}
								}
							}
						}
					}
				}
			}
		}
		System.out.printf("%d full houses", counter);
	}
}
