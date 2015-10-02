import java.util.LinkedHashMap;
import java.util.Scanner;

import org.omg.PortableInterceptor.SYSTEM_EXCEPTION;

public class CouplesFrequency {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		String[] numbers = scanner.nextLine().split(" ");
		LinkedHashMap<String, Integer> dict = new LinkedHashMap<>();
		
		for (int i = 0; i < numbers.length - 1; i++) {
			String couple = String.format("%s %s", numbers[i], numbers[i+1]);
			
			if (!dict.containsKey(couple)) {
				dict.put(couple, 0);
			}
			
			dict.put(couple, dict.get(couple) + 1);
		}
		
		for (String couple : dict.keySet()) {
			System.out.printf("%s -> %.2f%%\n", couple, dict.get(couple) * 100.0 / (numbers.length - 1));
		}
	}
}
