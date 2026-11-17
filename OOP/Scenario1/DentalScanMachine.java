public class DentalScanMachine {
    private static DentalScanMachine instance;
    private String serialNumber;
    private String make;
    private String countryOfOrigin;
    private int cost;

    private DentalScanMachine() {
    }

    public static DentalScanMachine getInstance() {
        if (instance == null) {
            instance = new DentalScanMachine();
        }
        return instance;
    }

    public void setDetails(String serialNumber, String make, String countryOfOrigin, int cost) {
        this.serialNumber = serialNumber;
        this.make = make;
        this.countryOfOrigin = countryOfOrigin;
        this.cost = cost;
    }

    public void displayDetails() {
        System.out.println("Dental Scan Machine Details:");
        System.out.println("Serial Number: " + serialNumber);
        System.out.println("Make: " + make);
        System.out.println("Country of Origin: " + countryOfOrigin);
        System.out.println("Cost: " + cost);
    }
}
