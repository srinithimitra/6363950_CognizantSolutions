
package StrategyPatternExample;

public class PayPalPayment implements PaymentStrategy{
    public void pay(int amount){
        System.out.println("Pay via credit card: "+amount);
    }
    
}