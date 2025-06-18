package Code.AdapterPatternExample;

public class Main {
    public static void main(String[] args) {
        PaymentProcessor processor=new PaypalAdapter();
        processor.ProcessPayment(1000);
        PaymentProcessor processor_1=new GooglepayAdapter();
        processor_1.ProcessPayment(100);
    }
}
