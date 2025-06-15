

public class Computer {
    private String cpu,ram,storage;
   private Computer(Builder builder){
    this.cpu=builder.cpu;
    this.ram=builder.ram;
    this.storage=builder.storage;

   } 
   public String getCPU() { return cpu; }
    public String getRAM() { return ram; }
    public String getStorage() { return storage; }

    public void displayConfig() {
        System.out.println("Computer Configuration:");
        System.out.println("CPU: " + cpu);
        System.out.println("RAM: " + ram);
        System.out.println("Storage: " + storage);
    }

   public static class Builder{
   
    private String cpu,ram,storage;
    public Builder setCPU(String cpu){
        this.cpu=cpu;
        return this;
    }
    public Builder setRAM(String ram){
        this.ram=ram;
        return this;
    }
    public Builder setStorage(String storage){
        this.storage=storage;
        return this;
    }
        public Computer build(){
            return new Computer(this);
        
    }
}
}

    

