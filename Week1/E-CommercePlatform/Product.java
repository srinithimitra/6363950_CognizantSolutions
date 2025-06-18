class Product{
    int productId;
    String productName;
    String productCatergory;

public Product(int productId,String productName,String productCategory){
    this.productId=productId;
    this.productName=productName;
    this.productCatergory=productCategory;
}
public String result(){
    return "Product ID: " +productId+", Name: " +productName+", Category: "+productCatergory;
}
}