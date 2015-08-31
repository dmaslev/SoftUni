import java.util.Scanner;

public class SortArrayOfStrings {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		int numberOfElements = Integer.parseInt(scanner.nextLine());
		String[] elements = new String[numberOfElements];

		for (int i = 0; i < elements.length; i++) {
			elements[i] = scanner.nextLine();
		}
		sortArray(elements);

		for (String name : elements) {
			System.out.println(name);
		}

		scanner.close();
	}

	public static void sortArray(String[] array){
		for (int i = 0; i < array.length - 1; i++) {
			int minIndex = i;
			String smallestElement = array[i];
			for (int j = i+1; j < array.length; j++) {
				if (smallestElement.compareTo(array[j]) > 0) {
					smallestElement = array[j];
					minIndex = j;
				}
			}
			String temp = array[minIndex];
			array[minIndex] = array[i];
			array[i] = temp;
			
		}
	}
}
