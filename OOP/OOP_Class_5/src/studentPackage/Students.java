package studentPackage;

public abstract class Students {
    // can't create objects of the class after making it as "Abstract"

    private int studentID;
    private String firstName;
    private String lastName;

    public Students() {
    }

    public Students(int studentID, String firstName, String lastName) {
        this.studentID = studentID;
        this.firstName = firstName;
        this.lastName = lastName;
    }

    public void setStudentID(int studentID) {
        this.studentID = studentID;
    }

    public int getStudentID() {
        return studentID;
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
        return studentID + " " + firstName + " " + lastName;
    }


}
