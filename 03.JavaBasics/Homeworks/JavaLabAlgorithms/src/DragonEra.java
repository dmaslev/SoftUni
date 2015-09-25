
import java.util.Scanner;
import java.util.ArrayList;
import java.util.List;

public class DragonEra {
	public static int dragonsCount = 0;

	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);

		List<Dragon> dragons = new ArrayList<>();
		int dragonsStart = Integer.parseInt(scanner.nextLine());
		for (int i = 1; i <= dragonsStart; i++) {
			Dragon dragon = new Dragon("Dragon_" + i, 0);

			int eggs = Integer.parseInt(scanner.nextLine());
			for (int eggCount = 0; eggCount < args.length; eggCount++) {
				Egg egg = new Egg(0, dragon);
				dragon.lay(egg);
			}

			dragons.add(dragon);
		}

		dragonsCount = dragonsStart + 1;
		int years = Integer.parseInt(scanner.nextLine());
		for (int year = 1; year <= years; year++) {
			String yearType = scanner.nextLine();
			YearType yearFactor = YearType.valueOf(yearType);
			
			for (Dragon dragon : dragons) {
				passAge(dragon, yearFactor);				
			}
		}
	}
	
	public static void passAge(Dragon dragon, YearType factor) {
		dragon.age();
		dragon.lay();
		
		if (dragon.isAlive()) {
			for (Egg egg : dragon.getEggs()) {
				egg.setYearFactor(factor);
				egg.age();
				egg.hatch();
			}
		}
		
		for (Dragon child : dragon.getChildren()) {
			passAge(child, factor);
		}
	}
}

class Dragon {
	private final int AGE_DEATH = 6;
	private final int AGE_LAY_EGGS_START = 3;
	private final int AGE_LAY_EGGS_END = 4;

	private String name;
	private int age;
	private boolean isAlive;
	private List<Egg> eggs;
	private List<Dragon> children;

	public Dragon(String name, int age) {
		this.setName(name);		
		this.setAge(age);
		this.isAlive = true;
	}

	public String getName() {
		return this.name;
	}
	
	public boolean isAlive(){
		return this.isAlive;
	}

	private void setName(String name) {
		this.name = name;
	}

	public int getAge() {
		return this.age;
	}

	private void setAge(int age) {
		this.age = age;
	}
	
	public Iterable<Dragon> getChildren(){
		return this.children;
	}

	public void lay(Egg egg) {
		this.eggs.add(egg);
	}

	public void age() {
		if (this.isAlive) {
			this.age++;
		}

		if (this.age == AGE_DEATH) {
			this.isAlive = false;
		}
	}

	public void lay() {
		if (this.age >= AGE_LAY_EGGS_START && this.age <= AGE_LAY_EGGS_END) {
			Egg egg = new Egg(-1, this);
			this.eggs.add(egg);
		}
	}

	public void increaseOffspring(Dragon dragon) {
		this.children.add(dragon);
	}
	
	public Iterable<Egg> getEggs(){
		return this.eggs;
	}
}

class Egg {
	private final int AGE_HATCH = 2;

	private int age;
	private Dragon parent;
	private YearType yearFactor;

	public Egg(int age, Dragon parent) {
		this.setAge(age);
		this.setParent(parent);
	}

	public Dragon getParent() {
		return parent;
	}
	
	public void setYearFactor(YearType yearType) {
		this.yearFactor = yearType;
	}
	
	private void setParent(Dragon parent) {
		this.parent = parent;
	}

	public int getAge() {
		return age;
	}

	private void setAge(int age) {
		this.age = age;
	}

	public void age() {
		this.age++;
	}

	public void hatch() {
		if (this.age == AGE_HATCH) {
			int yearFactor = this.yearFactor.ordinal();
			for (int i = 0; i < yearFactor; i++) {
				Dragon baby = new Dragon(this.parent.getName() + "/" + DragonEra.dragonsCount, -1);
				this.parent.increaseOffspring(baby);
			}			
		}
	}
}

enum YearType {
	Bad,
	Normal,
	Good
}
