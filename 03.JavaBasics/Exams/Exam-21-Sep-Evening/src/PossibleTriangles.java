import java.util.Arrays;
import java.util.Scanner;

public class PossibleTriangles {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		String input = scanner.nextLine();
		boolean foundTriangle = false;
		
		while (!input.equals("End")) {
			String[] sides = input.split(" ");
			double[] doubleSides = new double[3];
			for (int i = 0; i < doubleSides.length; i++) {
				doubleSides[i] = Double.parseDouble(sides[i]);
			}
			
			Arrays.sort(doubleSides);
			if (doubleSides[0] + doubleSides[1] > doubleSides[2]) {
				System.out.printf("%.2f+%.2f>%.2f\n", doubleSides[0], doubleSides[1], doubleSides[2]);
				foundTriangle = true;
			}
			
			input = scanner.nextLine();
		}
		
		if (!foundTriangle) {
			System.out.println("No");
		}
	}
}
