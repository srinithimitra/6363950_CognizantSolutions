package ProxyPatternExample;
public class RealImage implements Image{
    
    private String filename;
    public RealImage(String filename){
        this.filename=filename;
        loadimageFromDisk();
    }


private void loadimageFromDisk(){
    System.out.println("Image is loading : "+filename);
}


@Override
public void display() {
    
    System.out.println("Displaying the image: "+filename);
}
}
