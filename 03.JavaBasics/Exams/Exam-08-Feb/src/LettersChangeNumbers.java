import java.util.Scanner;

public class LettersChangeNumbers {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		double result = 0;
		String[] elements = scanner.nextLine().split("\\s+");
		
		for (String word : elements) {
			double number = Double.parseDouble(word.substring(1, word.length()-1));
			if (Character.isUpperCase(word.charAt(0))) {
				result += number / (word.charAt(0) - 64);
			}else {
				result += number * (word.charAt(0) - 96);
			}
			
			if (Character.isUpperCase(word.charAt(word.length() - 1))) {
				result -= word.charAt(word.length() - 1) - 64;
			} else {
				result += word.charAt(word.length() - 1) - 96;
			}			
		}
		
		System.out.printf("%.2f", result);
	}
}
