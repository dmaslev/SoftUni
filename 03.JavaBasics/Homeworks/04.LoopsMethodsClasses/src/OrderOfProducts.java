import java.io.BufferedReader;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.IOException;
import java.math.BigDecimal;
import java.util.ArrayList;
import java.util.Collections;

public class OrderOfProducts {
	public static void main(String[] args) throws IOException {
		try {
			FileReader fileReader = new FileReader("Products.txt");
			ArrayList<Product> products = new ArrayList<>();
			
			BufferedReader bufferedReader = new BufferedReader(fileReader);
			String line = bufferedReader.readLine();
			while (line != null) {
				String name = line.substring(0, line.indexOf(' '));
				BigDecimal price = new BigDecimal(line.substring(line.indexOf(' ') + 1));
				products.add(new Product(name, price));
				
				line = bufferedReader.readLine();
			}
			
			fileReader = new FileReader("Order.txt");
			bufferedReader = new BufferedReader(fileReader);
			BigDecimal totalPrice = BigDecimal.ZERO;		
			line = bufferedReader.readLine();
			while (line != null) {
				BigDecimal quantity = new BigDecimal(line.substring(0, line.indexOf(' ')));
				String product = line.substring(line.lastIndexOf(' ') +1);
				
				for (Product p : products) {
					if (p.getName().equals(product)) {
						BigDecimal price = p.getPrice();
						BigDecimal temp = price.multiply(quantity);
						totalPrice = totalPrice.add(temp);
					}
				}
				
				line = bufferedReader.readLine();
			}
			
			System.out.println(totalPrice);
			
		} catch (FileNotFoundException e) {
			System.out.println("File not found");
		}
	}
}
