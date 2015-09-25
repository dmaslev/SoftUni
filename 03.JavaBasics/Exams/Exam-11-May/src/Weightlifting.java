import java.util.Map;
import java.util.Scanner;
import java.util.TreeMap;
import java.util.jar.Attributes.Name;

public class Weightlifting {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		int n = Integer.parseInt(scanner.nextLine());
		Map<String, TreeMap<String, Integer>> players = new TreeMap<String, TreeMap<String,Integer>>();
		for (int i = 0; i < n; i++) {
			String[] inputInfo = scanner.nextLine().split("\\s+");
			String name = inputInfo[0];
			String exercise = inputInfo[1];
			int kg = Integer.parseInt(inputInfo[2]);
			
			if (!players.containsKey(name)) {
				players.put(name, new TreeMap<>());
				players.get(name).put(exercise, kg);
			}else {
				if (!players.get(name).containsKey(exercise)) {
					players.get(name).put(exercise, kg);
				}else {
					int newKg = players.get(name).get(exercise) + kg;
					players.get(name).put(exercise, newKg);
				}
			}
		}
		
		for (String player : players.keySet()) {
			System.out.printf("%s : ", player);
			
			boolean isFirst = true;
			for (String exer: players.get(player).keySet()) {
				if (!isFirst) {
					System.out.print(", ");
				}
				
				System.out.printf("%s - %d kg", exer, players.get(player).get(exer));
				isFirst = false;
			}
			
			System.out.println();
		}
		
	}
}
