import java.util.Scanner;

public class AngleUnitConverter {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		int lines = Integer.parseInt(scanner.nextLine());

		for (int i = 0; i < lines; i++) {
			double degrees = scanner.nextDouble();
			String measure = scanner.nextLine().trim();

			double result;
			if (measure.equals("deg")) {
				result = convertDegreesToRadians(degrees);
				System.out.printf("%.6f rad", result).println();;
			} else {
				result = convertRadiansToDegrees(degrees);
				System.out.printf("%.6f deg", result).println();;
			}
			
		}
		
		scanner.close();
	}

	public static double convertDegreesToRadians(Double degrees) {
		double radians = degrees * (Math.PI /180);
		return radians;
	}

	public static double convertRadiansToDegrees(Double radians) {
		double degrees = radians * (180 / Math.PI);
		return degrees;
	}
}
