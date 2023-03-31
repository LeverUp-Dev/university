
public class Test2 {
	public static void main(String[] args){
		int x = 25, y = 236;
		System.out.println(x>10 && x<20);
		System.out.println(y<100 || y>200);
		
		int year = 2023;
		System.out.println( year + "년도는" + ((year % 4 == 0 && year % 100 !=0) || (year % 400 == 0)));
		
	}

}
