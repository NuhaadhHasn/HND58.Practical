public class Principle {
    private String Name;
    private int Age;
    private int Salary;
    private static int count = 0;

    private Principle (String Name, int Salary, int Age) {
        this.Name = Name;
        this.Salary = Salary;
        this.Age = Age;
        this.count++;
    }

    public static Principle getPrinciple(String Name,int Salary, int Age) {
        if (count == 0){
            Principle principle = new Principle(Name,Salary,Age);
            return principle;
        }
        else {
            System.out.println("Principle Already Exists!!!");
            return null;
        }
    }

    public void showDetails() {
        System.out.println("Name : " + Name);
        System.out.println("Salary : " + Salary);
        System.out.println("Age : " + Age);
    }
}
