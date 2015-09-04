import java.util.Scanner;

public class PointsInsideFigure {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		double x = scanner.nextDouble();
		double y = scanner.nextDouble();
		boolean isInside = false;
		
		if ((x >= 12.5 && x <= 22.5 && y >=6 && y <= 8.5) ||
			((x >= 12.5 && x <= 17.5) || (x >= 20 && x <= 22.5)) && (y >=8.5 && y <=13.5 )) {
			isInside = true;
		}
		
		System.out.println(isInside ? "Inside" : "Ouside");
	}

}
