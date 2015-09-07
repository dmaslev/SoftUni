import java.util.Scanner;

public class Enigma {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		int n = Integer.parseInt(scanner.nextLine());

		for (int i = 0; i < n; i++) {
			String decryptedMessage = scanner.nextLine();
			String encryptedMessage = "";
			int lenght = 0;
			for (int j = 0; j < decryptedMessage.length(); j++) {
				if (decryptedMessage.charAt(j) != ' ' && (decryptedMessage.charAt(j) < 47 || decryptedMessage.charAt(j) > 57)) {
					lenght++;
				}
			}

			for (int j = 0; j < decryptedMessage.length(); j++) {
				if (decryptedMessage.charAt(j) != ' ' && (decryptedMessage.charAt(j) < 47 || decryptedMessage.charAt(j) > 57)) {
					encryptedMessage += (char) (decryptedMessage.charAt(j) + lenght / 2);
				}else {
					encryptedMessage += decryptedMessage.charAt(j);
				}
			}

			System.out.println(encryptedMessage);
		}
	}
}
