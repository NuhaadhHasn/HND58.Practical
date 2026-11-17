public class Main {
    public static void main(String[] args) {
        Newspaper newspaper = new Newspaper();

        Reader reader1 = new Reader("John");
        Reader reader2 = new Reader("Kramer");
        Reader reader3 = new Reader("Cavil");

        newspaper.registerObserver(reader1);
        newspaper.registerObserver(reader2);
        newspaper.registerObserver(reader3);

        newspaper.setNews("BBC Newspaper");
        newspaper.setNews("Newsday Newspaper");
    }
}
