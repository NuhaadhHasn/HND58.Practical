import java.util.ArrayList;
public class Newspaper implements Subject {
    private ArrayList<Observer> readers;
    private String news;

    public Newspaper() {
        readers = new ArrayList<Observer>();
    }

    @Override
    public void registerObserver(Observer reader) {
        readers.add(reader);
    }

    @Override
    public void removeObserver(Observer reader) {
        int index = readers.indexOf(reader);
        if (index >= 0) {
            readers.remove(index);
        }
    }

    @Override
    public void notifyObservers() {
        for (Observer reader : readers) {
            reader.update(news);
        }
    }

    public void setNews(String news) {
        this.news = news;
        notifyObservers();
    }
}