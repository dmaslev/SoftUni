import java.util.Scanner;

public class FireTheArrows {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		int numberRows = Integer.parseInt(scanner.nextLine());
		char[][] matrix = new char[numberRows][];

		for (int i = 0; i < numberRows; i++) {
			matrix[i] = scanner.nextLine().toCharArray();
		}

		boolean hasNextMove = true;
		while (hasNextMove) {
			hasNextMove = false;
			for (int row = 0; row < matrix.length; row++) {
				for (int col = 0; col < matrix[row].length; col++) {
					if (matrix[row][col] == 'o') {
						continue;
					}
					int nextRow = row;
					int nextCol = col;
					switch (matrix[row][col]) {
					case '<':
						nextCol--;
						break;
					case '>':
						nextCol++;
						break;
					case '^':
						nextRow--;
						break;
					case 'v':
						nextRow++;
						break;
					default:
						break;
					}
					
					if (canMove(matrix, nextRow, nextCol)) {
						matrix[nextRow][nextCol] = matrix[row][col];
						matrix[row][col] = 'o';
						hasNextMove = true;
					}
				}
			}
		}
		
		PrintMatrix(matrix);
	}

	private static void PrintMatrix(char[][] matrix) {
		for (int row = 0; row < matrix.length; row++) {
			for (int col = 0; col < matrix[row].length; col++) {
				System.out.print(matrix[row][col]);				
			}
			System.out.println();
		}		
	}

	private static boolean canMove(char[][] matrix, int nextRow, int nextCol) {
		try {
			if (matrix[nextRow][nextCol] == 'o') {
				return true;
			}
			return false;
			
		} catch (IndexOutOfBoundsException e) {
			return false;
		}
	}
}
