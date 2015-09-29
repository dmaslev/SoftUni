import java.util.Scanner;

public class Timespan {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		String start = scanner.nextLine();
		String end = scanner.nextLine();
		long startSeconds = convertToSeconds(start);
		long endSeconds = convertToSeconds(end);
		
		long resultSeconds = startSeconds - endSeconds;
		Integer hours = (int) (resultSeconds/3600);
		Integer minutes =  (int) (resultSeconds% 3600/60);
		Integer seconds = (int) (resultSeconds % 60);
		System.out.printf("%d:%02d:%02d", hours, minutes, seconds);
	}

	private static long convertToSeconds(String time) {
		int firstIndex = time.indexOf(':');
		int secondIndex = time.indexOf(':', firstIndex + 1);

		Long hours = Long.parseLong(time.substring(0, firstIndex));
		int minutes = Integer.parseInt(time.substring(firstIndex + 1, secondIndex));
		int seconds = Integer.parseInt(time.substring(secondIndex + 1));
		return hours * 3600 + minutes * 60 + seconds;
	}
}
