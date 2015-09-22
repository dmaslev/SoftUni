import java.util.ArrayList;
import java.util.Scanner;

public class GandalfStash {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		int mood = Integer.parseInt(scanner.nextLine());
		String[] elements = scanner.nextLine().toLowerCase().split("[^a-zA-Z]+");
		
		for (String food : elements) {
			switch (food) {
			case "cram": mood +=2;				
				break;
			case "lembas": mood +=3;				
			break;
			case "apple": mood +=1;				
			break;
			case "melon": mood +=1;				
			break;
			case "honeycake": mood +=5;				
			break;
			case "mushrooms": mood -=10;				
			break;

			default: mood -=1;
				break;
			}
		}
		
		System.out.println(mood);
		if (mood < -5 ) {
			System.out.println("Angry");
		} else if (mood < 0) {
			System.out.println("Sad");
		}else if (mood < 15) {
			System.out.println("Happy");
		}else {
			System.out.println("Special JavaScript mood");
		}
		
		scanner.close();
	}
}
