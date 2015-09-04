import java.time.LocalDate;
import java.time.format.DateTimeFormatter;
import java.time.temporal.ChronoUnit;
import java.util.Scanner;

public class DaysBetweenTwoDates {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		
        DateTimeFormatter formatter = DateTimeFormatter.ofPattern("d-MM-yyyy");
        LocalDate startDate = LocalDate.parse(scanner.nextLine(), formatter);
        LocalDate endDate = LocalDate.parse(scanner.nextLine(), formatter);
        
        long result = ChronoUnit.DAYS.between(startDate, endDate);
        
        System.out.println(result);

        scanner.close();
	}
}
