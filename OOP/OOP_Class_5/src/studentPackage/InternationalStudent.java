package studentPackage;

public final class InternationalStudent extends Students {
    // if we make class as final we can't create subclasses on it.
    private String passport;
    private String country;

    public InternationalStudent() {

    }

    public InternationalStudent(int studentID, String firstName, String lastName, String passport, String country) {
        super(studentID, firstName, lastName);
        this.passport = passport;
        this.country = country;
    }

    public String getPassport() {
        return passport;
    }

    public void setPassport(String passport) {
        this.passport = passport;
    }

    public String getCountry() {
        return country;
    }

    public void setCountry(String country) {
        this.country = country;
    }

    @Override
    public String display() {
        return super.display() + " " + passport + " " + country;
    }
}
