package ObserverPatternExample;

public class MobileApp implements Observer {
    public void update(float price){
        System.out.println("Mobile app-new Stock Price: "+price);
    }
    
}
