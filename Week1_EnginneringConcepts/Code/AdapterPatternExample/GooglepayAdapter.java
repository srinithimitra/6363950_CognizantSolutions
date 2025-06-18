package Code.AdapterPatternExample;

public class GooglepayAdapter implements PaymentProcessor{
        private GooglePayGateway googlepay=new GooglePayGateway();
        public void ProcessPayment(double amount){
            googlepay.send(amount);
        }
    }
