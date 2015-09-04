import java.io.BufferedReader;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.IOException;

public class SumNumbersFromTextFile {
	public static void main(String[] args) throws IOException {
		long summ = 0;
		
		try {
            FileReader fileReader = new FileReader("input.txt");
            BufferedReader bufferedReader = new BufferedReader(fileReader);
            
            String line = bufferedReader.readLine();
            while (line != null){
				summ += Integer.parseInt(line);
				line = bufferedReader.readLine();
			}
            
            System.out.println(summ);
            bufferedReader.close();

		} catch (FileNotFoundException e) {
			System.out.println("File not found.");
		}
	}
}
