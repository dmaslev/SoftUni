import java.util.Scanner;

public class CountOfBitsOne {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		int number = scanner.nextInt();
		int counter = 0;
		
		for (int i = 0; i < 32; i++) {
			if ((number & (1 << i)) > 0) {
				counter++;
			}
		}
		System.out.println(counter);
	}
}
