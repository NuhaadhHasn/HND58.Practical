package studentPackage;

public class Main {
    public static void main(String[] args) {  // cant use an object after making Student as "Abstract"
//        Students s = new Students(100, "Nimali", "Perera");   // cant use an object after making Student as "Abstract"
//        System.out.println(s.display());

        LocalStudent s2 = new LocalStudent(200, "Nuhaadh", "Hassan", "200000000000");
        System.out.println(s2.display());

        InternationalStudent s3 = new InternationalStudent(300, "Nimali", "Perera", "123456", "Sri Lanka");
        System.out.println(s3.display());
    }
}
