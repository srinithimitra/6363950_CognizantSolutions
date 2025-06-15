package CommandPatternExample;

public class Main {
    public static void main(String[] args) {
        Light livingRoomLight=new Light();
        Command lighton=new LightOnCommand(livingRoomLight);
        Command lightoff=new LightOffCommand(livingRoomLight);
        RemoteControl remote=new RemoteControl();
        remote.setCommand(lighton);
        remote.pressButton();

        remote.setCommand(lightoff);
        remote.pressButton();
    }
    
}
