namespace AddressBook.Models
{
    public class PersonModel
    {
        public int Id { get; set; }  // Id her objenin olmazsa olmaz alanlarından birisidir.
                                     // İnsanlarda tc kimlik no ne işe yarıyorsa Id de objeler için aynı işe yarar.
                                     // Kayıtlı id ile istediğimiz objeyi getirip istediğimizi değiştirebiliriz.
                                     // İstediğimiz işlemlerde ayırt edici rol üstlenir kısacası.
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
    }
}
