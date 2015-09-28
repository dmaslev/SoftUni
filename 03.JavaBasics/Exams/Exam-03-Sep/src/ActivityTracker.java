import java.util.Scanner;
import java.util.TreeMap;

public class ActivityTracker {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		int lines = Integer.parseInt(scanner.nextLine());
		TreeMap<Integer, TreeMap<String, Integer>> users = new TreeMap<Integer, TreeMap<String, Integer>>();
		for (int i = 0; i < lines; i++) {
			String[] currentLine = scanner.nextLine().split(" ");
			int month = Integer.parseInt(currentLine[0].substring(3, 5));
			String user = currentLine[1];
			Integer distance = Integer.parseInt(currentLine[2]);
			if (!users.containsKey(month)) {
				users.put(month, new TreeMap<String, Integer>());
				users.get(month).put(user, distance);
			} else {
				if (!users.get(month).containsKey(user)) {
					users.get(month).put(user, distance);
				} else {
					Integer oldDistance = users.get(month).get(user);
					users.get(month).put(user, oldDistance + distance);
				}
			}
		}
		
		PrintResult(users);
	}

	private static void PrintResult(TreeMap<Integer, TreeMap<String, Integer>> users) {
		for (Integer month : users.keySet()) {
			System.out.printf("%d: ", month);
			
			boolean isFirst = true;
			for (String user : users.get(month).keySet()) {
				if (!isFirst) {
					System.out.print(", ");
				}
				
				System.out.printf("%s(%d)", user, users.get(month).get(user));
				isFirst = false;
			}
			System.out.println();
		}
	}
}
