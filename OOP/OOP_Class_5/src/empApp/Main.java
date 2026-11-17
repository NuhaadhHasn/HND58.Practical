package empApp;

public class Main {
    public static void main(String[] args) {
        Employee emp1 = new Employee();
        emp1.setEmpID(100);
        emp1.setFirstName("Nuhaadh");
        emp1.setLastName("Hassan");

        System.out.println(emp1.getEmpID() + " " + emp1.getFirstName() + " " + emp1.getLastName());

        Employee emp2 = new Employee();
        System.out.println(emp2.getEmpID() + " " + emp2.getFirstName() + " " + emp2.getLastName());

        Employee emp3 = new Employee(300, "Kapila", "Perara");
        System.out.println(emp3.getEmpID() + " " + emp3.getFirstName() + " " + emp3.getLastName());
        System.out.println(emp3.display());
    }
}
