using AddressBook.Models;
using Microsoft.AspNetCore.Mvc;

namespace AddressBook.Controllers
{
    public class HomeController : Controller   //Web sitelerimizi oluşturmak ve back-end işlemlerini oluşturmak için
                                               // Controller dediğimiz özel classlar kullanıyoruz.
                                               // Controllerımız Controller classından kalıtım alıyor.
    {
        [HttpGet]    // Web sitelerinde temelde iki tip istek vardır, Get ve Post. Get istekleri fonksiyondan bir şey getirmek istediğinizde, Post ise fonksiyona bir şeyler yollayıp üzerinde işlem yapmak için kullanılır.
                     // Sayfaları açmak için kullandığımız fonksiyonlarda ise temelde sayfanın html kodlarını tarayıcıya iletip çalıştırır. 
                     // Yeni bir sayfa oluşturduğunuzda bunu yazmanıza gerek yok, sadece o sayfanın post methodunu yazarken o fonksiyona postu eklemeniz yeterli olur
        public IActionResult Index()   // Index fonksiyonumuz. Index sayfasına girmeye çalıştığımızda çalışan kod bloğudur.
                                       // Sayfa oluşturmak için fonksiyonun içine sağ tıklayıp Add View yapmanız gerekir. 
                                       // DİPNOT: SAKIN OLUŞTURACAĞINIZ VIEW IN ADINI FONKSİYONDAN FARKLI YAPMAYIN, SAYFANIZ AÇILMAZ.
        {
            return View();
        }

        [HttpPost]  // Index sayfamızın post methodu. Index sayfasından aldığımız bilgileri bu methoda iletip onunla istediğimiz işlemleri yapmamızı sağlar.
        public IActionResult Index(PersonModel person)
        {
            return RedirectToAction("SavedPerson","Home" , person);  // Back-end ile sayfa değiştirmek istiyorsak RedirectToAction kullanırız.
                                                                     // İlk string fonksiyonun adını,
                                                                     // ikinci string controllerın adını,
                                                                     // üçüncü değişkenimiz ise göndermek istersek bir obje veyahut veri göndermemizi sağlar.
        }


        public IActionResult SavedPerson(PersonModel person)   // Üzerinde HttpGet yazmamasına rağmen bu da bir get fonksiyonudur.
                                                               // Sayfa açılırken içerisine istediğimiz objeyi veyahut değeri fonksiyona parametre olarak ekleyebiliriz.
        {
            return View(person);  // sayfa oluşurken sayfanın htmline veri yollamak istiyorsak kullanımı bu şekilde.
        }


    }
}
