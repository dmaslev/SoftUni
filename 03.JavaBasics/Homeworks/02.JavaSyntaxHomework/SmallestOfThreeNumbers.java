import java.text.DecimalFormat;
import java.util.Arrays;
import java.util.Scanner;

public class SmallestOfThreeNumbers {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		double a = scanner.nextDouble();
		double b = scanner.nextDouble();
		double c = scanner.nextDouble();
		double[] numbers = {a,b,c};
	    Arrays.sort(numbers);
	    
	    DecimalFormat format = new DecimalFormat();
	    
        System.out.println(format.format(numbers[0]));
	}
}
