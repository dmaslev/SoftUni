import java.lang.reflect.Array;
import java.util.Scanner;

public class LegoBlocks {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		int rows = Integer.parseInt(scanner.nextLine());
		String[][] firstArray = new String[rows][];
		String[][] secondArray = new String[rows][];

		for (int i = 0; i < rows; i++) {
			firstArray[i] = scanner.nextLine().trim().split("\\s+");
		}

		for (int i = 0; i < rows; i++) {
			secondArray[i] = scanner.nextLine().trim().split("\\s+");
		}

		boolean isFit = true;
		int firstRow = firstArray[0].length + secondArray[0].length;
		int counter = firstRow;

		for (int i = 1; i < rows; i++) {
			if (firstRow != firstArray[i].length + secondArray[i].length) {
				isFit = false;
			}
			counter += firstArray[i].length + secondArray[i].length;
		}

		if (isFit) {
			for (int i = 0; i < rows; i++) {
				System.out.print("[");
				for (String element : firstArray[i]) {
					System.out.print(element + ", ");
				}
				for (int j = secondArray[i].length - 1; j >= 0; j--) {
					if (j != 0) {
						System.out.print(secondArray[i][j] + ", ");
					} else {
						System.out.print(secondArray[i][j] + "]");
					}
				}
				System.out.println();
			}
		} else {
			System.out.printf("The total number of cells is: %d", counter);
		}
		
		scanner.close();
	}
}
