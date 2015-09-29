import java.util.ArrayList;
import java.util.Scanner;
import java.util.TreeMap;

public class SchoolSystem {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		TreeMap<String, TreeMap<String, ArrayList<Double>>> studens = new TreeMap<String, TreeMap<String, ArrayList<Double>>>();
		int n = Integer.parseInt(scanner.nextLine());

		for (int i = 0; i < n; i++) {
			String[] currentStudentInfo = scanner.nextLine().split(" ");
			String name = currentStudentInfo[0] + " " + currentStudentInfo[1];
			String subject = currentStudentInfo[2];
			double grade = Double.parseDouble(currentStudentInfo[3]);

			if (!studens.containsKey(name)) {
				studens.put(name, new TreeMap<String, ArrayList<Double>>());
				studens.get(name).put(subject, new ArrayList<>());
				studens.get(name).get(subject).add(grade);

			} else {
				if (!studens.get(name).containsKey(subject)) {
					studens.get(name).put(subject, new ArrayList<>());
					studens.get(name).get(subject).add(grade);
				}else {
					studens.get(name).get(subject).add(grade);	
				}				
			}
		}

		for (String name : studens.keySet()) {
			System.out.printf("%s: [", name);

			boolean isFirst = true;
			for (String subject : studens.get(name).keySet()) {
				if (!isFirst) {
					System.out.print(", ");
				}
				double summ = 0;
				for (double grade : studens.get(name).get(subject)) {
					summ += grade;
				}
				System.out.printf("%s - %.2f", subject, summ / studens.get(name).get(subject).size());

				isFirst = false;
			}
			System.out.println("]");
		}
	}
}
