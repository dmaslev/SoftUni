import java.util.ArrayList;
import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class ValidUsernames {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		String[] allUsernames = scanner.nextLine().split("[\\\\/()\\s]+");
		ArrayList<String> validUsernames = new ArrayList<>();

		Pattern pattern = Pattern.compile("[a-zA-Z]\\w{2,24}");
		for (String name : allUsernames) {
			Matcher matcher = pattern.matcher(name);
			if (matcher.find()) {
				if (matcher.group(0).equals(name)) {
					validUsernames.add(name);
				}
			}
		}
		
		int maxLength = validUsernames.get(0).length() + validUsernames.get(1).length();
		int firstIndex = 0;
		for (int i = 1; i < validUsernames.size() - 1; i++) {
			if (validUsernames.get(i).length() + validUsernames.get(i + 1).length() > maxLength) {
				maxLength = validUsernames.get(i).length() + validUsernames.get(i + 1).length();
				firstIndex = i;
			}
		}

		System.out.printf("%s\n%s\n", validUsernames.get(firstIndex), validUsernames.get(firstIndex + 1));
	}	
}
