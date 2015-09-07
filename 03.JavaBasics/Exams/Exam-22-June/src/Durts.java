import java.util.Scanner;

public class Durts {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		int cx = scanner.nextInt();
		int cy = scanner.nextInt();
		int r = scanner.nextInt();
		int count = scanner.nextInt();
		int x;
		int y;
		
		for (int i = 0; i < count; i++) {
			x = scanner.nextInt();
			y = scanner.nextInt();
			if ((x >= cx - r && x <= cx + r && y >= cy -0.5 * r && y <= cy+ 0.5 * r) ||
			(y >= cy - r && y <= cy + r && x >= cx - 0.5 * r && x <= cx + 0.5 * r)){
				System.out.println("yes");
			}
			else {
				System.out.println("no");
			}
		}
	}
}
