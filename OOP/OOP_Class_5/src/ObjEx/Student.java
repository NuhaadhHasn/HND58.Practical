package ObjEx;

public class Student {

    private int stdID;
    private String firstname;

    public void setStudent(int stdID, String firstname) {
        this.stdID = stdID;
        this.firstname = firstname;

    }

    public void display() {
        System.out.println(stdID + " " + firstname);
    }
}
