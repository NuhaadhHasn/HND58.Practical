package empApp;

public class Employee {

    private int empID;
    private String firstName;
    private String lastName;

    public Employee() { // default Constructor
        empID = 111;    // initial Value
        firstName = "guest";
        lastName = "guest";
    }

    public Employee(int empID, String firstName, String lastName) { // Parameter Constructor
        this.empID = empID;
        this.firstName = firstName;
        this.lastName = lastName;
    }

    public void setEmpID(int empID) {
        this.empID = empID;
    }

    public int getEmpID() {
        return empID;
    }


    public void setFirstName(String firstName) {
        this.firstName = firstName;
    }

    public String getFirstName() {
        return firstName;
    }


    public void setLastName(String lastName) {
        this.lastName = lastName;
    }

    public String getLastName() {
        return lastName;
    }

    public String display() {
        String line = empID + " " + firstName + " " + lastName;
        return line;
    }
}
