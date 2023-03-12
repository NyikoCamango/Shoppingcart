using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService3" in both code and config file together.
[ServiceContract]
public interface IService2
{
    [OperationContract]

   bool StatusProduct(int ID, int num);
    [OperationContract]
    int book(BookingClass b);
    [OperationContract] 
    bool exists(string date, string time);
    [OperationContract]
    bool isReg(string username, string password);
    [OperationContract]
    int register(UserClass u);
    [OperationContract]
    bool login(string username, string password);
    [OperationContract]
    User getUser(int id);

    [OperationContract]
    User getUserInfo(string username, string password);

    [OperationContract]
    bool edit(UserClass u, int id);
    [OperationContract]
    bool editUserName(string username,string username1);
    [OperationContract]
    bool editPassword(string username, string password);
    [OperationContract]
    bool editPhoneNumber(string username, string phoneNumber);
    [OperationContract]
    bool editAddress(string username, string address);
    [OperationContract] 
    List<User> getUsers(User u);
    [OperationContract]
    bool emailExists(string email);
    [OperationContract]
    string getPassword(string username);
    [OperationContract]
    bool addStylist(StylistClass s);
    [OperationContract]
    bool editPrice(int id, double price);
    [OperationContract]
    bool editDescription(int id, string description);
    [OperationContract]
    bool editImage(int id, string description);
    [OperationContract]
    bool addManager(ManagerClass m);
    [OperationContract]
    List<Stylist> getStylists(Stylist s);
    [OperationContract]

    List<Product> getProd(Product pr);
    [OperationContract]
    bool stylistExist(string username);
    [OperationContract]
    User searchUser(string email);
    [OperationContract]
    Stylist searchStylist(string email);
    [OperationContract]
    int deleteUser(string email);
    [OperationContract]
    int deleteStylist(string email);
    [OperationContract]
    bool addHairstyle(HairstyleClass h);
    [OperationContract]
    List<Hairstyle> getHairstyle(Hairstyle h);
    [OperationContract]
    int logintype(string username, string password);
   
    [OperationContract]
    bool editStylistPhoneNumber(string username, string phoneNumber);
    [OperationContract]
    bool editStylistEmail(string username, string email);
    [OperationContract]
    bool editStylistAddress(string username, string address);
    [OperationContract]
    bool editStylistCity(string username, string city);
    [OperationContract]
    bool editStylistPostalCode(string username, string postalCode);
    [OperationContract]
    bool editStylistUsername(string username, string username1);
    [OperationContract]
    bool editStylistPassword(string username, string password);
    [OperationContract]
    bool editSalonName(string username, string salonName);
    [OperationContract]
    bool editSalonAdress(string username, string address);
    [OperationContract]
    bool editSalonStreet(string username, string street);
    [OperationContract]
    bool editSalonPostalCode(string username, string postalcode);
    [OperationContract]
    bool editManagerAddress(string username, string Address);
    [OperationContract]
    bool editManagerPhoneNumber(string username, string phoneNumber);
    [OperationContract]
    bool editManagerEmail(string username, string email);
    [OperationContract]
    bool editManagerUsername(string username, string username1);
    [OperationContract]
    bool editManagerPassword(string username, string password);
    [OperationContract]
    bool addProduct(ProductClass p);

    [OperationContract]
    Product getProduct(int id);

    [OperationContract]
    Purchase getPurchase(int id);

    [OperationContract]
    List<Review> getAllReviews();

    [OperationContract]
    int addReview(Review rev);

    [OperationContract]
    List<Transaction> getAllTransactions();

    [OperationContract]
    int logTransaction(Transaction trans);

    [OperationContract]
    int addBankAccount(Bank_Account acc);

    [OperationContract]
    Bank_Account getAccount(int id);

    [OperationContract]
    List<Bank_Account> getAllAccounts();

    [OperationContract]
    int makePurchase(Purchase pay);

    [OperationContract]
    List<Purchase> getAllPurchases();

    //Nosipho's functions

    [OperationContract]
    bool AddItem(ProductClass Prod);
    [OperationContract]
    bool NewItem(String Code);
    [OperationContract]

    bool addAppointment(AppointmentClass a);
    [OperationContract]
    List<ProductClass> GetAllItem();
    [OperationContract]
    List<ProductClass> GetAllItems();
    [OperationContract]
    bool EditItem(ProductClass Prod, int ID);
    [OperationContract]
    ProductClass GetItem(string ID);
    [OperationContract]
  List<getCartItemsResult> GetCartProducts(int ID);

    [OperationContract]

    bool becomeStylist(string username, string salonName, string salonAddress, string salonStreet, string postalCode, string image);

    [OperationContract]
    List<Hairstyle1> getHairstyle1(int stylistID);

    [OperationContract]
    bool addHairstyle1(int stylistID, string stylename, double price, string image);

    [OperationContract]
    List<ProductClass> sortPrice();

    [OperationContract]
    List<ProductClass> sortName();

    [OperationContract]

    bool UpdateQuantity(int userID, int prodID, int qua);
    [OperationContract]
    bool AddToCart(string userID, string prodID, int quantity);

    [OperationContract]
    List<Product> getProducts();

    [OperationContract]
    int getStylist(string username);
    [OperationContract]
    int getUserAppointment(string username);
    [OperationContract]
    int getMyUser(string username);
    [OperationContract]
    List<Appointment> stylistAppointment(string salonName);

    [OperationContract]
    string getSalonName(int id);

    [OperationContract]
    bool editAppointment(int id, string date, string time);

    [OperationContract]
    List<Appointment> getAppointMent(int userID);
    [OperationContract]
    List<Appointment> getApp(string email);
    [OperationContract]
    bool deleteAppointment(int id);
}
