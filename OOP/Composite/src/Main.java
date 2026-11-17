public class Main {
    public static void main(String[] args) {
        System.out.println("Small Advice");
        System.out.println("=================\n");
        SimpleAdvice simpleAdvice1 = new SimpleAdvice("Wake Up Early");
        SimpleAdvice simpleAdvice2 = new SimpleAdvice("Drink A Coffee");
        SimpleAdvice simpleAdvice3 = new SimpleAdvice("Eat Healthy");
        SimpleAdvice simpleAdvice4 = new SimpleAdvice("Do Some Exercise");
        SimpleAdvice simpleAdvice5 = new SimpleAdvice("Smile At Work");
        SimpleAdvice simpleAdvice6= new SimpleAdvice("Stay Focused");
        SimpleAdvice simpleAdvice7 = new SimpleAdvice("Sleep More");

        simpleAdvice1.display();
        simpleAdvice2.display();
        simpleAdvice3.display();

        BigAdvice bigAdvice = new BigAdvice();
        bigAdvice.addAdvice(simpleAdvice4);
        bigAdvice.addAdvice(simpleAdvice5);
        bigAdvice.addAdvice(simpleAdvice6);
        bigAdvice.addAdvice(simpleAdvice7);
        System.out.println("\nBig Advice");
        System.out.println("=================\n");
        bigAdvice.display();

    }
}
