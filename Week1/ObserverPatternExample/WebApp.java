package ObserverPatternExample;

public class WebApp implements Observer {
    public void update(float price){
        System.out.println("Web app-new Stock Price: "+price);
    }
    
}