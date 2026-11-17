public class Main {
    public static void main(String[] args) {
        DentalScanMachine dsm1 = DentalScanMachine.getInstance();
        dsm1.setDetails("12345", "Toshiba", "Japan", 100000);
        dsm1.displayDetails();
        DentalScanMachine dsm2 = DentalScanMachine.getInstance();
        dsm2.displayDetails();
    }
}
