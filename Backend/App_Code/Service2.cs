using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service2" in code, svc and config file together.
public class Service2 : IService2
{
    DataClassesDataContext db = new DataClassesDataContext();

    public int book(BookingClass b)
    {
        var add = new Booking
        {
            Id = b.id,
            Date = b.date,
            Time = b.time,
          //  Amount = (decimal)b.amount,
            Hairstyle = b.hairstyle,
        };
        db.Bookings.InsertOnSubmit(add);

        try
        {
            db.SubmitChanges();
            return 1;
        }
        catch (Exception ex)
        {
            ex.GetBaseException();
            return -1;
        }

    }

    public bool edit(UserClass u, int id)
    {
        var check = (from d in db.Users
                     where d.Id.Equals(id)
                     select d).SingleOrDefault();
        if (check != null)
        {
            check.FirstName = u.firstName;
            check.LastName = u.lastName;
            check.Email = u.email;
            check.PhoneNumber = u.phoneNumber;
            check.Address = u.address;
            check.City = u.city;
            check.PostalCode = u.postalcode;
            check.UserName = u.username;
            check.Password = u.password;
            check.PostalCode = u.postalcode;
            db.SubmitChanges();
            return true;
        }
        else
        {
            return false;
        }
    }
    public bool editUserName(string username, string username1)
    {
        //Check if user exists
        var check = (from d in db.Users
                     where d.UserName.Equals(username)
                     select d).FirstOrDefault();

        if (check != null)
        {
            check.UserName = username1;
            db.SubmitChanges();
            return true;
        }
        else
        {
            return false;
        }

    }

    public bool exists(string date, string time)
    {
        throw new NotImplementedException();
    }



    public bool isReg(string username, string password)
    {
        var check = (from d in db.Users
                     where d.UserName.Equals(username) && d.Password.Equals(password)
                     select d).FirstOrDefault();
        if (check != null)
        {
            return true;
        }
        else
            return false;
    }

    public bool login(string username, string password)
    {
        var check = (from d in db.Users
                     where d.UserName.Equals(username) && d.Password.Equals(password)
                     select d).FirstOrDefault();
        if (check != null)
        {
            return true;
        }
        else
            return false;
    }
    public User getUser(int id)
    {
        var check = (from d in db.Users
                     where d.Id.Equals(id)
                     select d).FirstOrDefault();
        if (check != null)
        {
            return check;
        }
        else
        {
            return null;
        }
    }
    public int register(UserClass u)
    {
        User addUser = new User
        {
            FirstName = u.firstName,
            LastName = u.lastName,
            Email = u.email,
            PhoneNumber = u.phoneNumber,
            Address = u.address,
            City = u.city,
            PostalCode = u.postalcode,
            UserName = u.username,
            Password = u.password,
            ConfirmPassword = u.confirmpass
        };
        db.Users.InsertOnSubmit(addUser);
        try
        {
            db.SubmitChanges();
            return 1;
        }
        catch (Exception ex)
        {
            ex.GetBaseException();
            return -1;
        }

    }

    public bool editPassword(string username, string password)
    {
        //Check if user exists
        var check = (from d in db.Users
                     where d.UserName.Equals(username)
                     select d).FirstOrDefault();

        if (check != null)
        {
            check.Password = password;
            check.ConfirmPassword = password;
            db.SubmitChanges();
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool editPhoneNumber(string username, string phoneNumber)
    {
        //Check if user exists
        var check = (from d in db.Users
                     where d.UserName.Equals(username)
                     select d).FirstOrDefault();

        if (check != null)
        {
            check.PhoneNumber = phoneNumber;
            db.SubmitChanges();
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool editAddress(string username, string address)
    {
        //Check if user exists
        var check = (from d in db.Users
                     where d.UserName.Equals(username)
                     select d).FirstOrDefault();

        if (check != null)
        {
            check.Address = address;
            db.SubmitChanges();
            return true;
        }
        else
        {
            return false;
        }
    }

    public List<User> getUsers(User u)
    {
        dynamic users = (from d in db.Users
                         select d).ToList();
        List<User> mylist = new List<User>();

        foreach (User k in users)
        {
            mylist.Add(k);
        }
        return mylist;

    }

    public bool emailExists(string email)
    {
        var check = (from d in db.Users
                     where d.Email.Equals(email)
                     select d).FirstOrDefault();
        if (check != null)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool editAddress(string address)
    {
        throw new NotImplementedException();
    }

    public string getPassword(string email)
    {
        var check = (from d in db.Users
                     where d.Email.Equals(email)
                     select d).FirstOrDefault();

        var style = (from d in db.Stylists
                     where d.Email.Equals(email)
                     select d).FirstOrDefault();
        var manager = (from d in db.Managers
                       where d.Email.Equals(email)
                       select d).FirstOrDefault();

        if (check != null)
        {
            return check.Password;
        }
        else if (style != null)
        {
            return style.Password;
        }
        else if (manager != null)
        {
            return manager.Password;
        }
        {
            return null;
        }
    }

    public bool addStylist(StylistClass s)
    {
        Stylist stylist = new Stylist
        {
            LastName = s.lastName,
            Email = s.email,
            Address = s.address,
            PhoneNumber = s.phoneNumber,
            UserName = s.username,
            Password = s.password
        };
        db.Stylists.InsertOnSubmit(stylist);
        try
        {
            db.SubmitChanges();
            return true;
        }
        catch (Exception ex)
        {
            ex.GetBaseException();
            return false;
        }


    }
    /*
    public bool editPrice(int id, double price)
    {
        var check = (from d in db.Stylists
                     where d.Id.Equals(id)
                     select d).FirstOrDefault();
        if (check != null)
        {
            check.StylePrice = (decimal)price;
            db.SubmitChanges();
            return true;
        }
      else
        {
            return false;
        }
    }*/
    /*
    public bool editDescription(int id, string description)
    {
        var check = (from d in db.Stylists
                     where d.Id.Equals(id)
                     select d).FirstOrDefault();
        if (check != null)
        {
            check.StyleDescription = description;
            db.SubmitChanges();
            return true;
        }
        else
        {
            return false;
        }
    }
    */
    /*
    public bool editImage(int id, string description)
    {
        var check = (from d in db.Stylists
                     where d.Id.Equals(id)
                     select d).FirstOrDefault();
        if (check != null)
        {
            check.StyleDescription = description;
            db.SubmitChanges();
            return true;
        }
        else
        {
            return false;
        }
    }
    */
    public bool addManager(ManagerClass m)
    {
        Manager manager = new Manager
        {
            FirstName = m.firstName,
            LastName = m.lastName,
            Email = m.email,
            PhoneNumber = m.phoneNumber,
            Address = m.address,
            UserName = m.username,
            Password = m.password
        };
        db.Managers.InsertOnSubmit(manager);
        try
        {
            db.SubmitChanges();
            return true;
        }
        catch (Exception ex)
        {
            ex.GetBaseException();
            return false;
        }

    }

    public List<Stylist> getStylists(Stylist s)
    {
        dynamic get = (from d in db.Stylists
                       select d).ToList();
        List<Stylist> mylist = new List<Stylist>();

        foreach (Stylist k in get)
        {
            mylist.Add(k);
        }
        return mylist;
    }

    public bool editPrice(int id, double price)
    {
        throw new NotImplementedException();
    }

    public bool editDescription(int id, string description)
    {
        throw new NotImplementedException();
    }

    public bool editImage(int id, string description)
    {
        throw new NotImplementedException();
    }

    public List<Appointment> getApp(string email)
    {
        dynamic appointments = (from d in db.Appointments where d.UserName.Equals(email) select d).ToList();
        List<Appointment> mylist = new List<Appointment>();
        foreach (Appointment k in appointments)
        {
            mylist.Add(k);
        }
        return mylist;
    }

    public bool deleteAppointment(int id)
    {
        var check = (from d in db.Appointments
                     where d.UserID.Equals(id)
                     select d).FirstOrDefault();
        if (check != null)
        {
            db.Appointments.DeleteOnSubmit(check);
            db.SubmitChanges();
            return true;
        }
        else
        {
            return false;
        }

    }

    public List<Appointment> getAppointMent(int userID)
    {
        dynamic appointments = (from d in db.Appointments where d.UserID.Equals(userID) select d).ToList();
        List<Appointment> mylist = new List<Appointment>();
        foreach (Appointment k in appointments)
        {
            mylist.Add(k);
        }
        return mylist;
    }

    public User searchUser(string email)
    {
        var check = (from d in db.Users
                     where d.Email.Equals(email)
                     select d).FirstOrDefault();
        if (check != null)
        {
            return check;
        }
        else return null;

    }

    public Stylist searchStylist(string email)
    {
        var check = (from d in db.Stylists
                     where d.Email.Equals(email)
                     select d).FirstOrDefault();
        if (check != null)
        {
            return check;
        }
        else return null;
    }

    public int deleteUser(string email)
    {
        var copy = (from d in db.Users
                    where d.Email.Equals(email)
                    select d
                   ).FirstOrDefault();
        if (copy != null)
        {
            SuspendedUser s = new SuspendedUser
            {
                FirstName = copy.FirstName,
                LastName = copy.LastName,
                PhoneNumber = copy.PhoneNumber,
                Email = copy.Email,
                Address = copy.Address,
                City = copy.City,
                PostalCode = copy.PostalCode,
                UserName = copy.City,
                Password = copy.Password,
                ConfirmPassword = copy.ConfirmPassword
            };
            db.SuspendedUsers.InsertOnSubmit(s);
            try
            {
                db.SubmitChanges();
                db.Users.DeleteOnSubmit(copy);
                db.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                ex.GetBaseException();
                return 2;
            }
        }
        else return 3;
    }

    public int deleteStylist(string email)
    {
        var copy = (from d in db.Stylists
                    where d.Email.Equals(email)
                    select d).FirstOrDefault();
        if (copy != null)
        {
            SuspendedStylist s = new SuspendedStylist
            {
                LastName = copy.LastName,
                PhoneNumber = copy.PhoneNumber,
                Email = copy.Email,
                Address = copy.Address,

            };
            db.SuspendedStylists.InsertOnSubmit(s);
            db.SubmitChanges();
            db.Stylists.DeleteOnSubmit(copy);
            db.SubmitChanges();
            return 1;
        }
        else
        {
            return 0;
        }

    }

    public bool addHairstyle(HairstyleClass h)
    {
        var add = new Hairstyle
        {
            HairstyleName = h.HairStyleName,
            Price = (decimal)h.price,
            Image = h.image
        };
        db.Hairstyles.InsertOnSubmit(add);
        try
        {
            db.SubmitChanges();
            return true;
        }
        catch (Exception ex)
        {
            ex.GetBaseException();
            return false;
        }

    }

    public bool addHairstyle1(int stylistID, string stylename, double price, string image)
    {
        var add = new Hairstyle1
        {
            StylistID = stylistID,
            HairstyleName = stylename,
            HairstylePrice = Convert.ToDecimal(price),
            Image = image

        };
        db.Hairstyle1s.InsertOnSubmit(add);
        try
        {
            db.SubmitChanges();
            return true;
        }
        catch (Exception ex)
        {
            ex.GetBaseException();
            return false;
        }

    }

    public List<Hairstyle> getHairstyle(Hairstyle h)
    {
        dynamic getstyles = (from d in db.Hairstyles select d).ToList();
        List<Hairstyle> mylist = new List<Hairstyle>();
        foreach (Hairstyle k in getstyles)
        {
            mylist.Add(k);
        }
        return mylist;
    }

    public List<Hairstyle1> getHairstyle1(int stylistID)
    {
        dynamic getstyles = (from d in db.Hairstyle1s where d.StylistID.Equals(stylistID) select d).ToList();
        List<Hairstyle1> mylist = new List<Hairstyle1>();
        foreach (Hairstyle1 k in getstyles)
        {
            mylist.Add(k);
        }
        return mylist;
    }
    public int logintype(string username, string password)
    {
        var user = (from d in db.Users
                    where d.UserName.Equals(username) && d.Password.Equals(password)
                    select d).FirstOrDefault();

        var stylist = (from d in db.Stylists
                       where d.UserName.Equals(username) && d.Password.Equals(password)
                       select d).FirstOrDefault();

        var manager = (from d in db.Managers
                       where d.UserName.Equals(username) && d.Password.Equals(password)
                       select d).FirstOrDefault();
        if (user != null)
        {
            return 1;
        }
        else if (stylist != null)
        {
            return 2;
        }
        else if (manager != null)
        {
            return 3;
        }
        else
        {
            return 0;
        }


        throw new NotImplementedException();
    }

    public bool becomeStylist(string username, string salonName, string salonAddress, string salonStreet, string postalCode, string image)
    {
        var exists = (from d in db.Users
                      where d.UserName.Equals(username)
                      select d).FirstOrDefault();
        if (exists != null)
        {
            Stylist s = new Stylist
            {
                FirstName = exists.FirstName,
                LastName = exists.LastName,
                PhoneNumber = exists.PhoneNumber,
                Email = exists.Email,
                Address = exists.Address,
                City = exists.City,
                PostalCode = exists.PostalCode,
                UserName = exists.UserName,
                Password = exists.Password,
                ConfirmPassword = exists.ConfirmPassword,
                SalonName = salonName,
                SalonAddress = salonAddress,
                SalonStreet = salonStreet,
                SalonPostalCode = postalCode,
                image = image
            };
            db.Stylists.InsertOnSubmit(s);
            try
            {
                db.SubmitChanges();
                db.Users.DeleteOnSubmit(exists);
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                ex.GetBaseException();
                return false;
            }
        }
        else return false;


    }

   

    public bool editStylistPhoneNumber(string username, string phoneNumber)
    {
        var check = (from d in db.Stylists
                     where d.UserName.Equals(username)
                     select d).FirstOrDefault();

        if (check != null)
        {
            check.PhoneNumber = phoneNumber;
            db.SubmitChanges();
            return true;
        }
        else
        {
            return false;
        }

    }

    public bool editStylistEmail(string username, string email)
    {
        var check = (from d in db.Stylists
                     where d.UserName.Equals(username)
                     select d).FirstOrDefault();

        if (check != null)
        {
            check.Email = email;
            db.SubmitChanges();
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool editStylistAddress(string username, string address)
    {
        var check = (from d in db.Stylists
                     where d.UserName.Equals(username)
                     select d).FirstOrDefault();

        if (check != null)
        {
            check.Address = address;
            db.SubmitChanges();
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool editStylistCity(string username, string city)
    {
        var check = (from d in db.Stylists
                     where d.UserName.Equals(username)
                     select d).FirstOrDefault();

        if (check != null)
        {
            check.City = city;
            db.SubmitChanges();
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool editStylistPostalCode(string username, string postalCode)
    {
        var check = (from d in db.Stylists
                     where d.UserName.Equals(username)
                     select d).FirstOrDefault();

        if (check != null)
        {
            check.PostalCode = postalCode;
            db.SubmitChanges();
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool editStylistUsername(string username, string username1)
    {
        var check = (from d in db.Stylists
                     where d.UserName.Equals(username)
                     select d).FirstOrDefault();

        if (check != null)
        {
            check.UserName = username1;
            db.SubmitChanges();
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool editStylistPassword(string username, string password)
    {
        var check = (from d in db.Stylists
                     where d.UserName.Equals(username)
                     select d).FirstOrDefault();

        if (check != null)
        {
            check.Password = password;
            check.ConfirmPassword = password;
            db.SubmitChanges();
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool editSalonName(string username, string salonName)
    {
        var check = (from d in db.Stylists
                     where d.UserName.Equals(username)
                     select d).FirstOrDefault();

        if (check != null)
        {
            check.SalonName = salonName;
            db.SubmitChanges();
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool editSalonAdress(string username, string address)
    {
        var check = (from d in db.Stylists
                     where d.UserName.Equals(username)
                     select d).FirstOrDefault();

        if (check != null)
        {
            check.SalonAddress = address;
            db.SubmitChanges();
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool editSalonStreet(string username, string street)
    {
        var check = (from d in db.Stylists
                     where d.UserName.Equals(username)
                     select d).FirstOrDefault();

        if (check != null)
        {
            check.SalonStreet = street;
            db.SubmitChanges();
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool editSalonPostalCode(string username, string postalcode)
    {
        var check = (from d in db.Stylists
                     where d.UserName.Equals(username)
                     select d).FirstOrDefault();

        if (check != null)
        {
            check.SalonPostalCode = postalcode;
            db.SubmitChanges();
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool editManagerAddress(string username, string Address)
    {
        var check = (from d in db.Managers
                     where d.UserName.Equals(username)
                     select d).FirstOrDefault();

        if (check != null)
        {
            check.Address = Address;
            db.SubmitChanges();
            return true;
        }
        else
        {
            return false;
        }

    }

    public bool editManagerPhoneNumber(string username, string phoneNumber)
    {
        var check = (from d in db.Managers
                     where d.UserName.Equals(username)
                     select d).FirstOrDefault();

        if (check != null)
        {
            check.PhoneNumber = phoneNumber;
            db.SubmitChanges();
            return true;
        }
        else
        {
            return false;
        }

    }

    public bool editManagerEmail(string username, string email)
    {
        var check = (from d in db.Managers
                     where d.UserName.Equals(username)
                     select d).FirstOrDefault();

        if (check != null)
        {
            check.Email = email;
            db.SubmitChanges();
            return true;
        }
        else
        {
            return false;
        }

    }

    public bool editManagerUsername(string username, string username1)
    {
        var check = (from d in db.Managers
                     where d.UserName.Equals(username)
                     select d).FirstOrDefault();

        if (check != null)
        {
            check.UserName = username;
            db.SubmitChanges();
            return true;
        }
        else
        {
            return false;
        }

    }

    public bool editManagerPassword(string username, string password)
    {
        var check = (from d in db.Managers
                     where d.UserName.Equals(username)
                     select d).FirstOrDefault();

        if (check != null)
        {
            check.Password = password;
            db.SubmitChanges();
            return true;
        }
        else
        {
            return false;
        }

    }

    public bool addProduct(ProductClass p)
    {
        var add = new Product
        {
            ProductName = p.productName,
            ProductDescription = p.productDescription,
            ProductPrice = Convert.ToDecimal(p.productPrice),
            ProductImage = p.image,
            
            
        };
        db.Products.InsertOnSubmit(add);
        try
        {
            db.SubmitChanges();
            return true;
        }
        catch (Exception ex)
        {
            ex.GetBaseException();
            return false;
        }

    }

    public List<Review> getAllReviews()
    {
        //Declare result list
        var result = new List<Review>();

        dynamic test = (from r in db.Reviews select r);

        foreach (Review rev in test)
        {
            var user = getUser(rev.User_ID);

            var newReview = new Review
            {
                User_ID = user.Id,
                Image = rev.Image,
                Description = rev.Description,
                Rating = rev.Rating
            };

            result.Add(newReview);
        }

        return result;
    }

    public int addReview(Review rev)
    {
        //Check if the user is subscribed
        var user = (from u in db.Users
                    where u.Id.Equals(rev.User_ID)
                    select u).FirstOrDefault();

        if (user != null)
        {
            db.Reviews.InsertOnSubmit(rev);

            try
            {
                db.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                ex.GetBaseException();
                return -1;
            }
        }
        else
        {
            return 0;
        }
    }

    public Product getProduct(int id)
    {
        //get the product matching with id
        var product = (from p in db.Products
                       where p.Id.Equals(id)
                       select p).FirstOrDefault();

        if (product == null)
            return null;
        return product;
    }

    public Purchase getPurchase(int id)
    {
        var purchase = (from p in db.Purchases
                        where p.Id.Equals(id)
                        select p).FirstOrDefault();

        if (purchase == null)
            return null;
        return purchase;
    }

    public List<Transaction> getAllTransactions()
    {
        // get a list of all available transactions
        var result = new List<Transaction>();

        dynamic test = (from t in db.Transactions select t);

        foreach (Transaction trans in test)
        {
            var Trxn = new Transaction
            {
                Id = trans.Id,
                T_Date = trans.T_Date,
                Amount = trans.Amount,
                P_ID = trans.P_ID,
                ACC_ID = trans.ACC_ID
            };

            result.Add(Trxn);
        }

        return result;
    }

    public int logTransaction(Transaction trans)
    {
        var account = (from b in db.Bank_Accounts
                       where b.Id.Equals(trans.ACC_ID)
                       select b).FirstOrDefault();

        if (account != null)
        {
            db.Transactions.InsertOnSubmit(trans);

            try
            {
                db.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                ex.GetBaseException();
                return -1;
            }
        }
        else
        {
            return 0;
        }
    }

    public int addBankAccount(Bank_Account acc)
    {
        //Check if user is registered
        var customer = (from u in db.Users
                        where u.Id.Equals(acc.Cust_Id)
                        select u);

        if (customer != null)
        {
            db.Bank_Accounts.InsertOnSubmit(acc);

            try
            {
                db.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                ex.GetBaseException();
                return -1;
            }
        }
        else
        {
            return 0;
        }
    }

    public List<Product> getProducts()
    {
        dynamic products = (from d in db.Products
                            select d).ToList();
        List<Product> myist = new List<Product>();
        foreach (Product p in products)
        {
            myist.Add(p);
        }
        return myist;
    }

    public int getStylist(string username)
    {
        var check = (from d in db.Stylists
                     where d.UserName.Equals(username)
                     select d).FirstOrDefault();
        if (check != null)
        {
            return check.Id;
        }
        else return 0;
    }

    public int getUserAppointment(string username)
    {
        var check = (from d in db.Appointments
                     where d.UserName.Equals(username)
                     select d).FirstOrDefault();
        if (check != null)
        {
            return check.Id;
        }
        else
        {
            return 0;
        }
    }

    public int getMyUser(string username)
    {
        var check = (from d in db.Users
                     where d.UserName.Equals(username)
                     select d).FirstOrDefault();
        if (check != null)
        {
            return check.Id;
        }
        else
        { return 0; }
    }

    public List<Appointment> stylistAppointment(string salonName)
    {
        dynamic appointments = (from d in db.Appointments where d.SalonName.Equals(salonName) select d).ToList();
        List<Appointment> mylist = new List<Appointment>();
        foreach (Appointment k in appointments)
        {
            mylist.Add(k);
        }
        return mylist;
    }

    public string getSalonName(int id)
    {
        var check = (from d in db.Stylists
                     where d.Id.Equals(id)
                     select d).FirstOrDefault();
        if (check != null)
        {
            return check.SalonName;
        }
        else
        {
            return null;
        }
    }

    public bool editAppointment(int id, string date, string time)
    {
        var check = (from d in db.Appointments
                     where d.UserID.Equals(id)
                     select d).FirstOrDefault();
        if (check != null)
        {
            check.Date = date;
            check.Time = time;
            db.SubmitChanges();
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool stylistExist(string username)
    {
        var check = (from d in db.Stylists
                     where d.UserName.Equals(username)
                     select d).FirstOrDefault();
        if (check != null)
        {
            return true;
        }
        else return false;
    }

    public Bank_Account getAccount(int id)
    {
        var account = (from b in db.Bank_Accounts
                       where b.Cust_Id.Equals(id)
                       select b).FirstOrDefault();

        if (account != null)
            return account;
        return null;
    }

    public List<Bank_Account> getAllAccounts()
    {
        List<Bank_Account> result = new List<Bank_Account>();

        dynamic accounts = (from a in db.Bank_Accounts select a);

        foreach(Bank_Account acc in accounts)
        {
            var user = getUser(acc.Cust_Id);
            var newAccount = new Bank_Account
            {
                A_Name = acc.A_Name,
                Credit_Card_Nr = acc.Credit_Card_Nr,
                Expiry_Date = acc.Expiry_Date,
                CVV = acc.CVV,
                Cust_Id = user.Id
            };
            result.Add(newAccount);
        }

        return result;
    }

    public int makePurchase(Purchase pay)
    {
        //Check if user is registered
        var customer = (from u in db.Users
                        where u.Id.Equals(pay.Cust_Id)
                        select u).FirstOrDefault();

        if (customer != null)
        {
            db.Purchases.InsertOnSubmit(pay);

            try
            {
                db.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                ex.GetBaseException();
                return -1;
            }
        }
        else
        {
            return 0;
        }
    }

    public User getUserInfo(string username, string password)
    {
        var user = (from u in db.Users
                    where u.UserName.Equals(username) && u.Password.Equals(password)
                    select u).FirstOrDefault();

        if (user != null)
            return user;
        return null;
    }

    //Nosipho's functions from here onwards
    public ProductClass GetItem(string ID)
    {
        var item = (from p in db.Products
                    where p.Id.Equals(ID)
                    select p).FirstOrDefault();

        ProductClass prod = new ProductClass
        {
            productName= item.ProductName,
            productDescription= item.ProductDescription,
            productPrice=item.ProductPrice,
            image = item.ProductImage,
             quantity = item.Quantity, 
             gender=item.Gender,
     active= item.Active,
    type= item.Type,
    code= item.Code,
    special= item.Special,

};

        return prod;
    }

    // private decimal GetPrice(string ID)
    //{
    //  var price = (from p in db.Products
    //             where p.Id.Equals(ID)
    //           select p.Price).FirstOrDefault();

    //        return price;
    //  }

    // public int FindItemID(string ID)
    //{
    //  var FoundPart = (from p in db.Products
    //                 where p.Id.Equals(ID)
    //               select p).FirstOrDefault();

    //        if (FoundPart != null)
    //      {
    //        return FoundPart.Code;
    //  }
    // else
    //{
    //  return 0;
    //}

    //    }

    
    public bool EditItem(ProductClass Prod, int ID)
    {
        var item = (from i in db.Products
                 //   where i.Code.Equals(ID)
                    select i).FirstOrDefault();

      
        item.ProductName = Prod.productName;
            item.ProductPrice = Prod.productPrice;
        item.ProductImage = Prod.image;

        try
        {
            db.SubmitChanges();
            return true;
        }
        catch (IndexOutOfRangeException ex)
        {
            ex.GetBaseException();
            return false;
        }
    }
    
    public List<ProductClass> GetAllItems()
    {
        dynamic items = (from i in db.Products
                      //   where i.Active.Equals(1)
                         orderby i.Id descending
                         select i);

        List<ProductClass> itemList = new List<ProductClass>();

        foreach (Product i in items)
        {
            ProductClass p = new ProductClass
            {
                ID = i.Id,
                productName= i.ProductName,
                productPrice= i.ProductPrice,
                productDescription= i.ProductDescription,
               
            };

            itemList.Add(p);
        }

        return itemList;
    }

    public List<Product> getProd(Product pr)
    {
        dynamic get = (from d in db.Products
                       select d).ToList();
                       List<Product> myProduct = new List<Product>();
        foreach(Product k in get)
        {
            myProduct.Add(k);
        }
        return myProduct;
    }

    public bool addAppointment(AppointmentClass a)
    {
        var add = new Appointment
        {
            Name = a.name,
            Email = a.email,
            Date = a.date,
            Time = a.time,
            PhoneNumber = a.phone,
            Message = a.message,
            UserName = a.username,
            UserID = Convert.ToInt32(a.userid),
            SalonName = a.salonname
        };
        db.Appointments.InsertOnSubmit(add);
        try
        {
            db.SubmitChanges();
            return true;
        }
        catch (Exception ex)
        {
            ex.GetBaseException();
            return false;
        }
    }

    public List<ProductClass> GetAllItem()
    {
        dynamic items = (from i in db.Products
                         orderby i.Id descending
                         select i);

        List<ProductClass> itemList = new List<ProductClass>();

        foreach (Product i in items)
        {
            ProductClass p = new ProductClass
            {
                ID= i.Id,
                productName= i.ProductName,
                productDescription=i.ProductDescription,
                productPrice=i.ProductPrice,
                quantity=i.Quantity,
                active=i.Active
                
              
            };

            itemList.Add(p);
        }

        return itemList;
    }
  
    public bool NewItem(String Code)
    {
        var item = (from i in db.Products
                    where i.Id.Equals(Code)
                    select i).FirstOrDefault();
        if (item == null)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    public bool StatusProduct(int ID, int num)
    {
        var prod = (from p in db.Products
                    where p.Id.Equals(ID)
                    select p).FirstOrDefault();
        if (num == 1)
        {
            prod.Active = (char)0;
        }
        else
        {
            prod.Active = (char)1;
        }


        try
        {
            db.SubmitChanges();
            return true;
        }
        catch (Exception e)
        {
            e.GetBaseException();
            return false;
        }
    }


   public List<getCartItemsResult> GetCartProducts(int ID)
    {
      dynamic cart = db.getCartItems(ID);

        List<getCartItemsResult> list = new List<getCartItemsResult>();
        foreach (getCartItemsResult i in cart)
        {
            list.Add(i);
        }

        return list;
    }

    public List<ProductClass> sortPrice()
    {
        dynamic items = (from i in db.Products
                         where i.Active.Equals(1)
                         orderby i.ProductPrice ascending
                         select i);

        List<ProductClass> itemList = new List<ProductClass>();

        foreach (Product i in items)
        {
            ProductClass p = new ProductClass
            {
                ID = i.Id,
                code = i.Code,
                productName = i.ProductName,
                productDescription = i.ProductDescription,
                productPrice = i.ProductPrice,
                quantity = i.Quantity,
                type = i.Type,
                special = i.Special,
                active = i.Active,
                image = i.ProductImage,
                gender = i.Gender
            };

            itemList.Add(p);
        }

        return itemList;
    }
    private decimal GetPrice(string ID)
    {
        var price = (from p in db.Products
                     where p.Id.Equals(ID)
                     select p.ProductPrice).FirstOrDefault();

        return price;
    }
    public bool UpdateQuantity(int userID, int prodID, int qua)
    {
        var price = GetPrice(Convert.ToString(prodID));

        var cart = (from c in db.ShoppingCarts
                    where c.User_ID.Equals(userID) && c.Prod_ID.Equals(prodID)
                    select c).FirstOrDefault();

        if (cart != null)
        {
            cart.Quantity = qua;
            cart.Total = (int)(qua * price);

            try
            {
                db.SubmitChanges();
                return true;
            }
            catch (Exception e)
            {
                e.GetBaseException();
                return false;
            }
        }
        else
        {
            return false;
        }
    }

    public bool AddToCart(string userID, string prodID, int quantity)
    {
        var price = GetPrice(prodID);

        ShoppingCart item = new ShoppingCart()
        {
            User_ID = Convert.ToInt32(userID),//Request.QueryString["UID"]),
            Prod_ID = Convert.ToInt32(prodID),
           
            Total =Convert.ToDecimal(price * quantity),
            Quantity = quantity
        };

        db.ShoppingCarts.InsertOnSubmit(item);
        try
        {
            db.SubmitChanges();
            return true;
        }
        catch (Exception e)
        {
            e.GetBaseException();
            return false;
        }
    }

    public List<ProductClass> sortName()
    {
        dynamic items = (from i in db.Products
                         where i.Active.Equals(1)
                         orderby i.ProductName ascending
                         select i);

        List<ProductClass> itemList = new List<ProductClass>();

        foreach (Product i in items)
        {
            ProductClass p = new ProductClass
            {
                ID = i.Id,
                code = i.Code,
                productName= i.ProductName,
                productDescription= i.ProductDescription,
                productPrice = i.ProductPrice,
                quantity = i.Quantity,
                type = i.Type,
                special = i.Special,
                active = i.Active,
                image = i.ProductImage,
                gender = i.Gender
            };

            itemList.Add(p);
        }

        return itemList;
    }


    public bool AddItem(ProductClass Prod)
    {
        Product p = new Product
        {
            ProductName= Prod.productName,
            ProductDescription= Prod.productDescription,
            ProductPrice= Prod.productPrice,
            ProductImage = Prod.image,
            

        };

        db.Products.InsertOnSubmit(p);
        try
        {
            db.SubmitChanges();
            return true;
        }
        catch (Exception ex)
        {
            ex.GetBaseException();
            return false;
        }
    }

    public List<Purchase> getAllPurchases()
    {
        List<Purchase> result = new List<Purchase>();

        dynamic test = (from p in db.Purchases select p);

        foreach(Purchase pay in test)
        {
            Purchase p = new Purchase { 
                Id = pay.Id,
                P_Date = pay.P_Date,
                Quantity = pay.Quantity,
                Cust_Id = pay.Cust_Id,
                Prod_Id = pay.Prod_Id
            };

            result.Add(p);
        }

        return result;
    }
}
