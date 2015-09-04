import java.util.Scanner;

public class DecimalToHex {
	public static void main(String[] args) {
		Scanner scanner  = new Scanner(System.in);
		int number = scanner.nextInt();
		
		System.out.printf("%x", number);
	}
}
