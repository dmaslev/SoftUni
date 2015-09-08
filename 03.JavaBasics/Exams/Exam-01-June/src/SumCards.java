import java.util.Scanner;

public class SumCards {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		String[] cards = scanner.nextLine().split(" ");
		int sum = 0;

		for (int i = 0; i < cards.length; i++) {
			String currentCardFace = cards[i].substring(0, cards[i].length() - 1);
			int currentValue = 0;
			switch (currentCardFace) {
			case "J":
				currentValue = 12;
				break;
			case "Q":
				currentValue = 13;
				break;
			case "K":
				currentValue = 14;
				break;
			case "A":
				currentValue = 15;
				break;

			default:
				currentValue = Integer.parseInt(currentCardFace);
				break;
			}
			if ((i + 1 < cards.length && cards[i + 1].contains(currentCardFace))
					|| (i - 1 >= 0 && cards[i - 1].contains(currentCardFace))) {
				sum += 2 * currentValue;
			} else {
				sum += currentValue;
			}
		}

		System.out.println(sum);
	}
}
