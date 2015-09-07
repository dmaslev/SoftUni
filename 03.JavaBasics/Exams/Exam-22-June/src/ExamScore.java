import java.util.ArrayList;
import java.util.Collection;
import java.util.Collections;
import java.util.HashMap;
import java.util.Map;
import java.util.Scanner;
import java.util.TreeMap;

import javax.lang.model.element.VariableElement;

public class ExamScore {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		for (int i = 0; i < 3; i++) {
			scanner.nextLine();
		}

		TreeMap<Integer, ArrayList<String>> names = new TreeMap<Integer, ArrayList<String>>();
		Map<Integer, Double> grades = new HashMap<Integer, Double>();

		String[] line = scanner.nextLine().split("\\s*\\|\\s*");
		while (line.length > 2) {
			String name = line[1];
			Integer examScore = Integer.parseInt(line[2]);
			double grade = Double.parseDouble(line[3]);

			if (!names.containsKey(examScore)) {
				names.put(examScore, new ArrayList<>());
				grades.put(examScore, 0.0);
			}
			names.get(examScore).add(name);
			grades.put(examScore, grades.get(examScore) + grade);
			line = scanner.nextLine().split("\\s*\\|\\s*");
		}
		
		for (Integer string : names.keySet()) {
			System.out.print(string + " -> [");
			Collections.sort(names.get(string));
			boolean isFirst = true;
			for (String stringName : names.get(string)) {
				if (isFirst) {
					System.out.print(stringName);
					isFirst = false;
				}
				else {
					System.out.print(", " + stringName);

				}
			}
			System.out.print("]; ");
			double avg = grades.get(string) / names.get(string).size();
			avg *= 1000;
			avg = Math.round(avg);
			avg /=1000;
			System.out.printf("avg=%.2f\n", avg);
		}
	}
}
