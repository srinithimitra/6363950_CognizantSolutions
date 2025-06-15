package ObserverPatternExample;

import java.util.ArrayList;

public class StockMarket implements Stock{
    private ArrayList<Observer> observers=new ArrayList<>();
    private float price;

    public void register(Observer o){
        observers.add(o);
    }
    public void remove(Observer o){
        observers.remove(o);
    }
    
    public void setPrice(float price){
        this.price=price;
        notifyObserver();
    }
    public void notifyObserver(){
        for(Observer o :observers){
            o.update(price);
        }
    }
   
    
    
}
