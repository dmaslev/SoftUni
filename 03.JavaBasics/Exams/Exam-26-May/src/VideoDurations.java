import java.util.Scanner;

public class VideoDurations {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		int hours = 0;
		int minutes = 0;
		
		String input = scanner.nextLine();
		while (!input.equals("End")) {
			String[] arr = input.split(":");
			minutes += Integer.parseInt(arr[1]);
			if (minutes> 59) {
				minutes = minutes-60;
				hours++;
			}
			
			hours += Integer.parseInt(arr[0]);
			
			input = scanner.nextLine();
		}
		
		
		System.out.printf("%d:%s%d", hours, minutes<10? "0": "",  minutes);
	}
}
