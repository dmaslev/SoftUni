import java.util.LinkedHashMap;
import java.util.Scanner;
import java.util.TreeMap;

public class Nuts {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		int lines = Integer.parseInt(scanner.nextLine());
		TreeMap<String, LinkedHashMap<String, Integer>> nuts = new TreeMap<>();
		
		for (int i = 0; i < lines; i++) {
			String[] inputInfo = scanner.nextLine().split(" ");
			String company = inputInfo[0];
			String nut = inputInfo[1];
			int amount = Integer.parseInt(inputInfo[2].substring(0, inputInfo[2].length()-2));
			
			if (!nuts.containsKey(company)) {
				nuts.put(company, new LinkedHashMap<String, Integer>());
				nuts.get(company).put(nut, amount);
			} else {
				if (!nuts.get(company).containsKey(nut)) {
					nuts.get(company).put(nut, amount);
				} else {
					int oldAmount = nuts.get(company).get(nut);
					nuts.get(company).put(nut, oldAmount + amount);
				}
			}
		}
		
		PrintOutput(nuts);
	}

	private static void PrintOutput(TreeMap<String, LinkedHashMap<String, Integer>> nuts) {
		for (String company : nuts.keySet()) {
			System.out.printf("%s: ", company);
			
			boolean isFirst = true;
			for (String	 nut : nuts.get(company).keySet()) {
				if (!isFirst) {
					System.out.print(", ");
				}
				
				System.out.printf("%s-%dkg", nut, nuts.get(company).get(nut));
				isFirst = false;
			}
			System.out.println();
		}
	}
}
