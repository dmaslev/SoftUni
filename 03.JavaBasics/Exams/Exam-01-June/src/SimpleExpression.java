import java.math.BigDecimal;
import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class SimpleExpression {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		BigDecimal sum = BigDecimal.ZERO;
		String input = scanner.nextLine().replaceAll("\\s+", "");

		Pattern pattern = Pattern.compile("[-+]*\\d+[.\\d]*");
		Matcher matcher = pattern.matcher(input);
		while (matcher.find()) {
			BigDecimal currentValue = new BigDecimal(matcher.group());
			sum = sum.add(currentValue);
		}

		System.out.printf("%.7f\n", sum);
	}
}
