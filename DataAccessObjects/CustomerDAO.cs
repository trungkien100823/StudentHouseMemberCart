using BusinessObjects;

namespace DataAccessObjects
{
    public class CustomerDAO
    {
        //use Singleton
        private static CustomerDAO instance = null;
        private CustomerDAO() { }
        public static CustomerDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CustomerDAO();
                }
                return instance;
            }
        }
        //end Singleton

        public static List<Customer> GetCustomers()
        {
            List<Customer> listCustomer = new List<Customer>();
            try
            {
                using (var context = new StudentHouseMembershipContext()) //goi toi database
                {
                    listCustomer = context.Customers.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return listCustomer;
        }
        public static Customer AddCustomer()
        {
            Customer customer = new Customer();
            try
            {
                using (var context = new StudentHouseMembershipContext())
                {
                    context.Customers.Add(customer);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return customer;

        }
        public static Customer UpdateCustomer(Customer customer)
        {
            try
            {
                using (var context = new StudentHouseMembershipContext())
                {
                    context.Customers.Update(customer);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return customer;
        }
        public static Customer DeleteCustomer(Customer customer)
        {
            try
            {
                using (var context = new StudentHouseMembershipContext())
                {
                    context.Customers.Remove(customer);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return customer;
        }

    }
}
