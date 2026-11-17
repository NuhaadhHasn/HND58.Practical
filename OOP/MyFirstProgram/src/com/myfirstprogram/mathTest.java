package src.com.myfirstprogram;

public class mathTest {
    public static void main(String[] args) {
        double w = 10;
        double x = 3.14;
        double y = -10;

        double z = Math.max(x, y); // find maxinum value
        System.out.println("MAX " + z);

        z = Math.min(x, y); // find minimum value
        System.out.println("MIN " + z);

        z = Math.abs(y); // get the amount without negative value
        System.out.println("ABS " + z);

        z = Math.sqrt(w); // find square root
        System.out.println("SQR " + z);

        z = Math.round(x); // round value
        System.out.println("ROUND " + z);

        z = Math.ceil(x); // round value up
        System.out.println("CEIL " + z);

        z = Math.floor(x); // round value down
        System.out.println("FLOOR " + z);
    }
}
