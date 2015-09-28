	import java.util.ArrayList;
import java.util.Collections;
import java.util.Scanner;
	
	public class BiggestThreePrimeNumbers {
		public static void main(String[] args) {
			Scanner scanner = new Scanner(System.in);
			String[] numbers = scanner.nextLine().split("[( )]+");
			ArrayList<Integer> primeNumbers = new ArrayList<>();
	
			for (String string : numbers) {
				if (!string.equals("")) {
					if (isPrimeNumber(Integer.parseInt(string))) {
						if (!primeNumbers.contains(Integer.parseInt(string))) {
							primeNumbers.add(Integer.parseInt(string));
						}
					}
				}
			}
	
			Collections.sort(primeNumbers);
			if (primeNumbers.size() >2) {
				int summ = 0;
				for (int i = primeNumbers.size() - 1; i > primeNumbers.size() - 4; i--) {
					summ+= primeNumbers.get(i);
				}
				System.out.println(summ);
			} else {
				System.out.println("No");
			}
		}
	
		private static boolean isPrimeNumber(Integer number) {
			if (number <= 1 ) {
				return false;
			}
			if (number <= 2) {
				return true;
			}
	
			for (int i = 2; i <= Math.sqrt(number); i++) {
				if (number % i == 0) {
					return false;
				}
			}
			return true;
		}
	}
