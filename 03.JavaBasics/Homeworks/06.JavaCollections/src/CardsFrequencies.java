import java.util.HashMap;
import java.util.LinkedHashMap;
import java.util.Map;
import java.util.Scanner;

public class CardsFrequencies {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		String[] cards = scanner.nextLine().split(" ");
		
		Map<String, Integer> frequencies = new LinkedHashMap<String, Integer>();
		
		for (String card : cards) {
			String curretCard = card.substring(0, card.length()-1);
			if (!frequencies.containsKey(curretCard)) {
				frequencies.put(curretCard, 1);
			}else {
				int count = frequencies.get(curretCard);
				frequencies.put(curretCard, ++count);
			}
		}
		
		for (String card : frequencies.keySet()) {
			System.out.printf("%s -> %.2f%%", card, frequencies.get(card) * 100.0 / cards.length).println();;
		}
	}
}
