import java.util.Scanner;

public class CountBeers {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		int allBeers = 0;

		String input = scanner.nextLine();
		while (!input.equals("End")) {
			String[] info = input.split(" ");
			int count = Integer.parseInt(info[0]);
			if (info[1].equals("beers")) {
				allBeers += count;
			} else {
				allBeers += count * 20;
			}
			input = scanner.nextLine();
		}

		System.out.printf("%d stacks + %d beers", allBeers / 20, allBeers % 20);
	}
}
