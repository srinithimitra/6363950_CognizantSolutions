package DecoratorPatternExample;

public class SmsNotifierDecorator extends NotifierDecorator{
    public SmsNotifierDecorator(Notifier notifier){
        super(notifier);
    }
    public void send (String message){
        super.send(message);
        System.out.println("SMS : "+message);
    }
}
