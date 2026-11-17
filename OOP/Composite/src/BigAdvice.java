import java.util.Vector;

public class BigAdvice extends Advice{
    private Vector AdviceList;
    public BigAdvice() {
        AdviceList = new Vector();
    }

    public void addAdvice(Advice advice) {
        AdviceList.addElement(advice);
    }

    public void display(){
        int count=0;

        while (count < AdviceList.size()) {
            SimpleAdvice simpleAdvice = (SimpleAdvice) AdviceList.elementAt(count);
            simpleAdvice.display();
            count++;
        }
    }
}
