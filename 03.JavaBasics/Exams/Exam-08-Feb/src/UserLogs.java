import java.util.LinkedHashMap;
import java.util.Map;
import java.util.Scanner;
import java.util.TreeMap;

public class UserLogs {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		Map<String, LinkedHashMap<String, Integer>> dict = new TreeMap<String, LinkedHashMap<String, Integer>>();

		String input = scanner.nextLine();
		while (!input.equals("end")) {
			String[] userInfo = input.split("\\s+");
			String user = userInfo[2].substring(5);
			String ip = userInfo[0].substring(3);

			if (!dict.containsKey(user)) {
				dict.put(user, new LinkedHashMap<String, Integer>());
				dict.get(user).put(ip, 1);
			} else {
				if (!dict.get(user).containsKey(ip)) {
					dict.get(user).put(ip, 1);
				} else {
					dict.get(user).put(ip, dict.get(user).get(ip) + 1);
				}
			}

			input = scanner.nextLine();
		}
		
		for (String user : dict.keySet()) {
			System.out.printf("%s: \n", user);
			
			for (String ip : dict.get(user).keySet()) {
				System.out.printf("%s => %d", ip, dict.get(user).get(ip));
				
				String lastKey = getLastKey(dict.get(user));
				if (ip.equals(lastKey)) {
					System.out.println(".");
				}else {
					System.out.print(", ");
				}
			}
		}
	}

	private static String getLastKey(LinkedHashMap<String, Integer> linkedHashMap) {
		String lastKey = "";
		for (String ip : linkedHashMap.keySet()) {
			lastKey = ip;
		}
		
		return lastKey;
	}

	
}
