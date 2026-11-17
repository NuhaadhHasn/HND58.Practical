public class Main {
    public static void main(String[] args) {
        Employee CEO = new Employee("Anton", "Director", 1000000);

        Employee headDentist = new Employee("Supuni", "Dentist", 600000);
        Employee headNurse = new Employee("Nurse Director", "Nurse", 400000);

        Employee dentist1 = new Employee("Chamod", "Dentist", 600000);
        Employee dentist2 = new Employee("Madhavi", "Dentist", 600000);

        Employee nurse1 = new Employee("Piyal", "Nurse", 200000);
        Employee nurse2 = new Employee("Kamal", "Nurse", 200000);
        Employee nurse3 = new Employee("Kapila", "Nurse", 200000);

        CEO.add(headDentist);
        CEO.add(headNurse);

        headDentist.add(dentist1);
        headDentist.add(dentist2);

        headNurse.add(nurse1);
        headNurse.add(nurse2);
        headNurse.add(nurse3);

        System.out.println(CEO);
        for (Employee headEmployee : CEO.getSubordinates()) {
            System.out.println(headEmployee);
            for (Employee employee : headEmployee.getSubordinates()) {
                System.out.println(employee);
            }
        }
    }
}
