package ObserverPatternExample;

public class Main {
    public static void main(String[] args) {
        StockMarket market=new StockMarket();
        Observer mobileApp=new MobileApp();
        Observer webApp=new WebApp();
        market.register(mobileApp);
        market.register(webApp);
        market.setPrice(1750);
         market.setPrice(1550);

    }
    
}
