package studentPackage;

public class LocalStudent extends Students {
    private String nic;

    public LocalStudent() {
    }

    public LocalStudent(int studentID, String firstName, String lastName, String nic) {
        super(studentID, firstName, lastName);
        this.nic = nic;
    }

    public void setNic(String nic) {
        this.nic = nic;
    }

    public String getNic() {
        return nic;
    }

    @Override
    public String display() {
        return super.display() + " " + nic;
    }
}
