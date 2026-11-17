public class SimpleAdvice extends Advice {
    private String Advice;

    public SimpleAdvice(String Advice) {
        this.Advice = Advice;
    }

    public void display() {
        System.out.println(" " + Advice);
    }
}
