import java.util.Scanner;
import java.util.TreeMap;
import java.util.LinkedHashMap;
import java.util.PrimitiveIterator.OfInt;

public class OfficeStuff {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		int lines = Integer.parseInt(scanner.nextLine());
		TreeMap<String, LinkedHashMap<String, Integer>> office = new TreeMap<>();
		
		for (int i = 0; i < lines; i++) {
			String[] input = scanner.nextLine().split(" - ");
			String company = input[0].substring(1, input[0].length());
			Integer amount = Integer.parseInt(input[1]);
			String product = input[2].substring(0, input[2].length() - 1);
			
			if (!office.containsKey(company)) {
				office.put(company, new LinkedHashMap<>());
				office.get(company).put(product, amount);
			} else {
				if (!office.get(company).containsKey(product)) {
					office.get(company).put(product, amount);
				} else {
					int oldAmount = office.get(company).get(product);
					office.get(company).put(product, oldAmount + amount);
				}
			}
		}
		
		for (String	company : office.keySet()) {
			System.out.printf("%s: ", company);
			
			boolean isFirst = true;
			for (String product : office.get(company).keySet()) {
				if (!isFirst) {
					System.out.print(", ");
				}
				
				System.out.printf("%s-%d", product, office.get(company).get(product));
				isFirst = false;
			}
			System.out.println();
		}
	}
}
