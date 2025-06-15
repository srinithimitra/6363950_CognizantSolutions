package AdapterPatternExample;

public class PaypalGateway{
    public void send(double amt){
        System.out.println("Pay via Paypal: "+amt);
    }
}