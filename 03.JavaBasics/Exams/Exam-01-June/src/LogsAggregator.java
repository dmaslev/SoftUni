import java.util.Collections;
import java.util.Map;
import java.util.Scanner;
import java.util.TreeMap;

public class LogsAggregator {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		int count = Integer.parseInt(scanner.nextLine());
		
		Map<String, TreeMap<String, Integer>> users = new TreeMap<String, TreeMap<String, Integer>>();
		for (int i = 0; i < count; i++) {
			String[] input = scanner.nextLine().split("\\s+");
			String ipAdress = input[0];
			String user = input[1];
			int duration = Integer.parseInt(input[2]);
			
			if (!users.containsKey(user)) {
				users.put(user, new TreeMap<>());
				users.get(user).put(ipAdress, duration);
			}else {
				if (!users.get(user).containsKey(ipAdress)) {
					users.get(user).put(ipAdress, duration);
				}else {
					int prevDuration = users.get(user).get(ipAdress);
					users.get(user).put(ipAdress, prevDuration + duration);
				}
			}
			
		}
		
		for (String user : users.keySet()) {
			int sumOfDurations = 0;
			for (Integer currentDuration : users.get(user).values()) {
				sumOfDurations += currentDuration;
			}
			
			System.out.printf("%s: %d [%s]\n", user, sumOfDurations, String.join(", ", users.get(user).keySet()));
		}
	}
}
