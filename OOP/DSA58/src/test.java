public class test {
    int a = 5;
    int b = 6;
    int c = 0;

    public int add() {
        c = a + b;
        return c;
    }


    public static void main(String[] args) {
        
        test t = new test();
        t.add();
        System.out.println(t.c);
    }
}
