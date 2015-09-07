import java.util.ArrayList;
import java.util.Arrays;
import java.util.Scanner;

public class StraightFlush {
	private static String[] allCards = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		String[] cards = scanner.nextLine().split("\\W+");
		boolean foundStraightFlush = false;

		for (String card : cards) {
			String currentCard = card;
			ArrayList<String> results = new ArrayList<>();
			results.add(currentCard);

			for (int i = 0; i < 4; i++) {
				String nextCard = getNextCard(currentCard, cards);
				if (nextCard != null) {
					results.add(nextCard);
					currentCard = nextCard;
				} else {
					break;
				}
			}
			if (results.size() > 4) {
				System.out.printf("[%s]\n", String.join(", ", results));
				foundStraightFlush = true;
			}

		}
		if (!foundStraightFlush) {
			System.out.println("No Straight Flushes");
		}

		scanner.close();

	}

	public static String getNextCard(String currentCard, String[] cards) {
		String face = currentCard.substring(0, currentCard.length() - 1);
		String suit = currentCard.substring(currentCard.length() - 1);
		int indexOfCurrentFace = Arrays.asList(allCards).indexOf(face);

		if (indexOfCurrentFace + 1 < allCards.length
				&& Arrays.asList(cards).contains(allCards[indexOfCurrentFace + 1] + suit)) {
			return allCards[indexOfCurrentFace + 1] + suit;
		}
		return null;
	}
}
