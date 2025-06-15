package DecoratorPatternExample;

public abstract class NotifierDecorator implements Notifier {
    protected Notifier wrap;
    public NotifierDecorator(Notifier notifier){
       this.wrap=notifier;
    }
     public void send(String message) {
        wrap.send(message);
    }
}
