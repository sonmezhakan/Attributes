
Customer customer = new Customer { Id= 1, LastName="Sönmez",Age=27};
CustomerDal customerDal = new CustomerDal();
customerDal.Add(customer);//Add metodunda Obsolete attribute kullanıldığı için altı yeşil çizgili üzerine gelindiğinde Obsolete attributeden gelen mesaj varsa onuda gösterir.
Console.ReadLine();


//Customer nesnesinin veri tabanında Customers tablosuna denk geldiğini belirtiyoruz. Burada tablo adını parametre olarak gönderiyoruz.
//Attribute parametre gönderebilmek için de constructordan set ederiz.
[ToTable("Customers")]
class Customer
{
    public int Id { get; set; }
    [RequiredProperty]//Bu özelliğin verilmesinin zorunlu olduğu attribute tanımlıyoruz.
    public string FirstName { get; set; }
    [RequiredProperty]
    public string LastName { get; set; }
    public int Age { get; set; }
}

class CustomerDal
{
    /*Hazır attributelarda vardır. Örnek olarak Add metodunun yeni bir versiyonu oluşturuldu.
    Obsolete attribute kullanıdığı zaman Add metodu ile ilgili işlem yapılacağı zaman kodun altını yeşil olarak işaretler ve herhangi bir uyarı metni varsa gösterir.Aynı zamanda
    obsolete türkçe karşılığı eski/modası geçmiş anlamına gelmektedir.*/
    [Obsolete("Add yerine AddNew metodunu kullanınız")]
    public void Add(Customer customer)
    {
        Console.WriteLine("{0},{1},{2},{3} added!", customer.Id, customer.FirstName, customer.LastName, customer.Age);
    }

    public void AddNew(Customer customer)
    {
        Console.WriteLine("{0},{1},{2},{3} added!", customer.Id, customer.FirstName, customer.LastName, customer.Age);
    }
}

/*AttributeUssage ile attributeların nerelerde kullanılabileceğini belirtiriz.
AttributeTargets.All -> Her yerde kullanabileceğimiz anlamına geliyor.
AttributeTargets.Class -> Sadece classlarda kullanabileceğimiz anlamına geliyor.
AttributeTargets.Method -> Sadece metodlarda kullanbileceğimiz anlıma geliyor.
AttributeTargets.Property -> Sadece nesnenin özelliklerinde kullanabileceğimiz anlamına geliyor. Bunun gibi bir çok kısıtlamalarda bulunabiliyoruz.
AllowMultiple ise attribute birden fazla yerde kullanılıp kullanılamayacağını belirtmemize olanak sağlıyor..*/
[AttributeUsage(AttributeTargets.Property, AllowMultiple =true)]//Customer classının özelliklerinde kullandığımız için sadece nesne özellikleri için kullanabileceğimizi belirtiyoruz.
class RequiredPropertyAttribute :Attribute
{
    
}

//Burada constructor oluşturup gelecek değerin adını tableName olarak belirliyoruz
[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]//Customer classında kullandığımız için sadece classlarda kullanabileceğimizi belirtiyoruz.
class ToTableAttribute : Attribute
{
    private string _tableName;

    public ToTableAttribute(string tableName)
    {
        _tableName = tableName;
    }
}



