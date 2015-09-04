import java.math.BigDecimal;

public class Product implements Comparable {
	private String name;

	private BigDecimal price;

	public Product(String name, BigDecimal price) {
		this.setName(name);
		this.setPrice(price);
	}

	public String getName() {
		return name;
	}

	public void setName(String name) {
		this.name = name;
	}

	public BigDecimal getPrice() {
		return price;
	}

	public void setPrice(BigDecimal price) {
		this.price = price;
	}

	@Override
	public int compareTo(Object arg0) {
		Product otherProduct = (Product) arg0;
		return this.price.compareTo(otherProduct.price);
	}
}
