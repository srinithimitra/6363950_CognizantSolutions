

public class Main {
    public static void main(String[] args) {
        Computer pc=new Computer.Builder().setCPU("i7").setRAM("13GB").setStorage("152GM SSD").build();
        pc.displayConfig();
    }
    
}
