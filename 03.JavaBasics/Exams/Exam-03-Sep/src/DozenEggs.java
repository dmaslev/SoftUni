import java.util.Scanner;

public class DozenEggs {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		int allEggs = 0;
		for (int i = 0; i < 7; i++) {
			String[] input = scanner.nextLine().split(" ");
			int current = Integer.parseInt(input[0]);
			if (input[1].equals("eggs")) {
				allEggs += current;
			} else {
				allEggs += current * 12;
			}
		}
		
		System.out.printf("%d dozens + %d eggs", allEggs/12, allEggs% 12);
	}
}
