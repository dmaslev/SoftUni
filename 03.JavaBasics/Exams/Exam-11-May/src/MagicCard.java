import java.nio.file.ReadOnlyFileSystemException;
import java.util.Scanner;

public class MagicCard {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		String[] cards = scanner.nextLine().split(" ");
		String evenOrOdd = scanner.nextLine();
		String magicCard = scanner.nextLine();
		int start = 0;
		if (evenOrOdd.equals("odd")) {
			start = 1;
		}
		int summ = 0;
		for (int i = start; i < cards.length; i += 2) {
			String currentCard = cards[i];
			String face = currentCard.substring(0, currentCard.length() - 1);
			int currentValue = getCardValue(face);
			
			if (magicCard.substring(0, magicCard.length() - 1).equals(face)) {
				 summ += 3 * currentValue;
			}else if (magicCard.substring(magicCard.length()-1).equals(currentCard.substring(currentCard.length()-1))) {
				summ += 2* currentValue;
			}else {
				summ += currentValue;
			}			
		}
		System.out.println(summ);
		scanner.close();
	}

	private static int getCardValue(String face) {
		int result = 0;
		switch (face) {
		case "J":
			result = 12;
			break;
		case "Q":
			result = 13;
			break;
		case "K":
			result = 14;
			break;
		case "A":
			result = 15;
			break;
		default:
			result = Integer.parseInt(face);
			break;
		}
		
		return result * 10;
	}
}
