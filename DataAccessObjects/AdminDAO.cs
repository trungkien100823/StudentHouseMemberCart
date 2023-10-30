using BusinessObjects;

namespace DataAccessObjects
{
    public class AdminDAO
    {
        public List<Admin> GetAllAdmins()
        {
            using (var context = new StudentHouseMembershipContext())
            {
                return context.Admins.ToList();
            }
        }
        public static Admin AddAdmin()
        {
            Admin admin = new Admin();
            try
            {
                using (var context = new StudentHouseMembershipContext())
                {
                    context.Admins.Add(admin);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return admin;
        }
        public static Admin UpdateAdmin(Admin admin)
        {
            try
            {
                using (var context = new StudentHouseMembershipContext())
                {
                    context.Admins.Update(admin);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return admin;
        }
        public static Admin DeleteAdmin(Admin admin)
        {
            try
            {
                using (var context = new StudentHouseMembershipContext())
                {
                    context.Admins.Remove(admin);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return admin;
        }

    }
}
