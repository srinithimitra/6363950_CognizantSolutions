package DependencyInjectionExample;

public class CustomerService {
    private final CustomerRepository repository;

    public CustomerService(CustomerRepository repository) {
        this.repository = repository;
    }

    public void getCustomer(String id) {
        System.out.println(repository.findCustomerById(id));
    }
}
