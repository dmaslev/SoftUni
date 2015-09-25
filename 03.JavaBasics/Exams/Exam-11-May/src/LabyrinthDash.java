import java.util.Scanner;

public class LabyrinthDash {
	static int lives = 3;
	static int totalMovesMade = 0;
	
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		
		int row = Integer.parseInt(scanner.nextLine());
		char[][] labyrinth = new char[row][];

		for (int i = 0; i < row; i++) {
			labyrinth[i] = scanner.nextLine().toCharArray();
		}

		int[] cordinates = new int[2];
		String moves = scanner.nextLine();
		for (int i = 0; i < moves.length(); i++) {
			if (lives == 0) {
				break;
			}
			MakeAMove(moves.charAt(i), labyrinth, cordinates);
		}
		System.out.printf("Total moves made: %d\n", totalMovesMade);
	}

	private static void MakeAMove(char direction, char[][] labyrinth, int[] cordinates) {
		int currentRow = cordinates[0];
		int currentCol = cordinates[1];
		switch (direction) {
		case '^':
			currentRow--;
			break;
		case '>':
			currentCol++;
			break;
		case 'v':
			currentRow++;
			break;
		case '<':
			currentCol--;
			break;
		default:
			break;
		}
		
		if (currentRow < 0 || currentCol <0 || currentRow >= labyrinth.length || currentCol >= labyrinth[currentRow].length || labyrinth[currentRow][currentCol] == ' ') {
			System.out.println("Fell off a cliff! Game Over!");
			lives = 0;
			totalMovesMade++;
			return;
		}else if (labyrinth[currentRow][currentCol] == '_' || labyrinth[currentRow][currentCol] == '|') {			
			System.out.println("Bumped a wall.");
			return;
		}else if (labyrinth[currentRow][currentCol] == '@' || labyrinth[currentRow][currentCol] == '#' || labyrinth[currentRow][currentCol] == '*') {
			lives--;
			totalMovesMade++;			
			System.out.printf("Ouch! That hurt! Lives left: %d\n", lives);

			if (lives ==0) {
				System.out.println("No lives left! Game Over!");
				return;
			}
		}else if (labyrinth[currentRow][currentCol] == '$') {
			lives++;
			totalMovesMade++;			

			labyrinth[currentRow][currentCol] = '.';
			System.out.printf("Awesome! Lives left: %d\n", lives);
		}else if (labyrinth[currentRow][currentCol] == '.') {
			totalMovesMade++;			
			System.out.println("Made a move!");
		}
		
		cordinates[0] = currentRow;
		cordinates[1] = currentCol;
	}
}
