public class LinearSearch {
    public static Product LinearSearchFunction(Product[] products,String name) {
        for(Product product:products){
            if(product.productName.equalsIgnoreCase(name)){
                return product;
            }
        }
        return null;
    }
}
