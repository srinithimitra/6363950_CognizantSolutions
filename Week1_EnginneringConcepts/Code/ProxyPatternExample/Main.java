package ProxyPatternExample;

public class Main {
    public static void main(String[] args) {
        Image image1=new ProxyImage("high_res_image.jpg");
        Image image2=new ProxyImage("high_res_image2.jpg");
        image1.display();
        image1.display();
        image2.display();
    }
}
