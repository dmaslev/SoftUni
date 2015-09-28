import java.util.Scanner;

public class AddingAngels {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		int count = Integer.parseInt(scanner.nextLine());
		boolean fountResult = false;
		int[] degrees = new int[count];
		for (int i = 0; i < count; i++) {
			int current = scanner.nextInt();
			degrees[i] = current;
		}

		for (int i = 0; i < degrees.length; i++) {
			for (int j = i + 1; j < degrees.length; j++) {
				for (int j2 = j + 1; j2 < degrees.length; j2++) {
					int summ = degrees[i] + degrees[j] + degrees[j2];
					if (summ % 360 == 0) {
						System.out.printf("%d + %d + %d = %d degrees\n", degrees[i], degrees[j], degrees[j2], summ);
						fountResult = true;
					}
				}
			}
		}

		if (!fountResult) {
			System.out.println("No");
		}
	}
}
