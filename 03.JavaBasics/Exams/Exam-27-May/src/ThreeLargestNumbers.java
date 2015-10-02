import java.math.BigDecimal;
import java.util.Arrays;
import java.util.Scanner;

public class ThreeLargestNumbers {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		int n = Integer.parseInt(scanner.nextLine());
		BigDecimal[] allNumbers = new BigDecimal[n];
		
		for (int i = 0; i < allNumbers.length; i++) {
			allNumbers[i] = new BigDecimal(scanner.nextLine());
		}
		
		Arrays.sort(allNumbers);
		
		for (int i = allNumbers.length- 1; i >= Math.max(0, allNumbers.length-3); i--) {
			System.out.println(allNumbers[i].toPlainString());
		}
	}
}
