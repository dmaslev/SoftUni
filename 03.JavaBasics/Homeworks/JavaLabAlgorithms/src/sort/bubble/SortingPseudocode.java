package sort.bubble;
import java.util.Scanner;

public class SortingPseudocode {

	public static void main(String[] args) {
		Scanner scan = new Scanner(System.in);

		String[] numbers = scan.nextLine().replace("[", "").replace("]", "").split(", ");
		Integer[] numbersArr = new Integer[numbers.length];

		for (int i = 0; i < numbers.length; i++) {
			numbersArr[i] = Integer.parseInt(numbers[i]);
		}

		boolean swapped = true;
		int j = 0;
		int tmp;
		while (swapped) {
			swapped = false;
			j++;
			for (int i = 0; i < numbersArr.length - j; i++) {
				if (numbersArr[i] > numbersArr[i + 1]) {
					tmp = numbersArr[i];
					numbersArr[i] = numbersArr[i + 1];
					numbersArr[i + 1] = tmp;
					swapped = true;
				}
			}
		}

		System.out.print("[");
		for (int i = 0; i < numbersArr.length - 1; i++) {
			System.out.printf("%d, ", numbersArr[i]);
		}
		System.out.printf("%d]", numbersArr[numbersArr.length - 1]);
	}
}