import java.math.BigInteger;
import java.util.Scanner;

public class FormattingNumbers {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		int a = scanner.nextInt();
		double b = scanner.nextDouble();
		double c = scanner.nextDouble();
		
		System.out.printf("|%-10x|%010d|%10.2f|%-10.3f|", a, new BigInteger(Integer.toBinaryString(a)), b, c);
	}
}
