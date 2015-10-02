import java.util.HashMap;
import java.util.LinkedHashMap;
import java.util.Scanner;
import java.util.TreeMap;

import javax.xml.bind.ValidationEvent;

public class Orders {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		int lines = Integer.parseInt(scanner.nextLine());
		LinkedHashMap<String, TreeMap<String, Integer>> orders = new LinkedHashMap<>();
		
		for (int i = 0; i < lines; i++) {
			String[] inputInfo = scanner.nextLine().split(" ");
			String customer = inputInfo[0];
			Integer amount = Integer.parseInt(inputInfo[1]);
			String product = inputInfo[2];
			
			if (!orders.containsKey(product)) {
				orders.put(product, new TreeMap<>());
				orders.get(product).put(customer, amount);
			} else {
				if (!orders.get(product).containsKey(customer)) {
					orders.get(product).put(customer, amount);
				} else {
					int old = orders.get(product).get(customer);
					orders.get(product).put(customer, old + amount);
				}
			}
		}
		
		for (String	product : orders.keySet()) {
			System.out.printf("%s: ", product);
			
			boolean isFirst = true;
			for (String curstomer : orders.get(product).keySet()) {
				if (!isFirst) {
					System.out.print(", ");
				}
				
				System.out.printf("%s %d", curstomer, orders.get(product).get(curstomer));
				isFirst = false;
			}
			System.out.println();
		}
	}
}
