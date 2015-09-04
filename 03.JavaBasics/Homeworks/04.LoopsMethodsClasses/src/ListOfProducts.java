import java.io.BufferedReader;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.IOException;
import java.math.BigDecimal;
import java.util.ArrayList;
import java.util.Collections;

public class ListOfProducts {
	public static void main(String[] args) throws IOException {
		try {
			FileReader fileReader = new FileReader("ProductsInput.txt");
			ArrayList<Product> products = new ArrayList<>();
			
			BufferedReader bufferedReader = new BufferedReader(fileReader);
			String line = bufferedReader.readLine();
			while (line != null) {
				String name = line.substring(0, line.indexOf(' '));
				BigDecimal price = new BigDecimal(line.substring(line.indexOf(' ') + 1));
				products.add(new Product(name, price));
				
				line = bufferedReader.readLine();
			}
			
			Collections.sort(products);
			
			for (Product product : products) {
				System.out.printf("%s %.2f", product.getName(), product.getPrice()).println();;
			}
			bufferedReader.close();
			
		} catch (FileNotFoundException e) {
			System.out.println("File not found");
		}
	}
}
