import java.util.Scanner;

public class TerroristsWin {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		String text = scanner.nextLine();
		int start = 0;
		char[] result = text.toCharArray();
		
		while (text.indexOf('|', start) != -1) {
			int startIndex = text.indexOf('|', start);
			int endIndex = text.indexOf('|', startIndex + 1);
			start = endIndex + 1;
			int bombPower = 0;
			for (int i = startIndex + 1; i < endIndex; i++) {
				bombPower += (int)text.charAt(i);
			}
			bombPower %= 10;
			
			for (int i = Math.max(0, startIndex - bombPower); i <= Math.min(result.length - 1, endIndex + bombPower); i++) {
				result[i] = '.';
			}
		}
		
		for (char c : result) {
			System.out.print(c);
		}
	}
}
