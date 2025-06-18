package Code.AdapterPatternExample;

 public class PaypalAdapter implements PaymentProcessor{
        private PaypalGateway paypal=new PaypalGateway();
        public void ProcessPayment(double amount){
            paypal.send(amount);
        }
    }
