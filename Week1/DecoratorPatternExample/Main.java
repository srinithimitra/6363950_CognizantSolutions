package DecoratorPatternExample;

public class Main {
    public static void main(String[] args) {
        Notifier notifier=new SmsNotifierDecorator(new EmailNotifier());
    notifier.send("Your report is ready");
     Notifier notifier_1=new SlackNotifierDecorator(new EmailNotifier());
    notifier_1.send("Your slack is ready");  
    }
  
    
}

