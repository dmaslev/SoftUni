import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.Scanner;

public class LargestThreeRectangles {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		String input = scanner.nextLine().trim().replaceAll("\\s+", "");
		String[] withEmpty = input.trim().split("[\\[\\]]"); 		
		List<String> list = new ArrayList<String>(Arrays.asList(withEmpty));
		list.removeAll(Arrays.asList("", null));
		
		String[] rectangles = new String[list.size()];
		for (int i = 0; i < rectangles.length; i++) {
			rectangles[i] = list.get(i);
		}
		
		int maxRecArea = Integer.MIN_VALUE;
		for (int i = 0; i < rectangles.length - 2; i++) {
			int currentArea = 0;
			String[] first = rectangles[i].split("x");
			currentArea += Integer.parseInt(first[0]) * Integer.parseInt(first[1]);
			String[] second = rectangles[i + 1].split("x");
			currentArea += Integer.parseInt(second[0]) * Integer.parseInt(second[1]);
			String[] third = rectangles[i + 2].split("x");
			currentArea += Integer.parseInt(third[0]) * Integer.parseInt(third[1]);
			
			if (currentArea > maxRecArea) {
				maxRecArea = currentArea;
			}
		}
		System.out.println(maxRecArea);
	}
}
