# Attribute(Öz Nitelik) Nedir?
Attribute kelime anlamı olarak öz nitelik anlamına gelmektedir. Nesnelere, nesnelerin özelliklerine veya metodlarına anlam katmak için kullanılan bir yapıdır. Attrabute bir abstract sınıftır. Hazır attributelar olduğu gibi bizde kendi attributelarımızı oluşturup tanımlamalar ve kurallar oluşturabiliriz.

## Attribute Kullanımı
Classlar, propertyler, metodlar gibi bir çok yerlerde attributeları kullanmamız mümkündür. Attributeları kullanırken oluşturduğumuz kod yapısının üzerine **[AttributeAdı]** şeklinde tanımlayarak kullanabiliriz. Tabi ki bu kullanımların farklı yolları da bulunmaktadır.
<br><br>
Tanımladığımız bu attribute hazır değilde kendimiz oluşturduysak. Bu attribute classını oluşturmamız gerekmektedir. Classı oluştururken attribute verdiğimiz adın sonuna Attribute kelimesini eklememiz gerekmektedir.`AttributeAdıAttribute`olarak isimlendirmemiz gerekmektedir. Aynı zamanda bu isimlendirmeden sonra Attribute sınıfından türettiğimizi de belirtmemiz gerekmektedir. `AttributeAdıAttribute : Attribute`şeklinde kullanmamız gerekmektedir.
<br>
## Şartlı Attributeler
Şartlı attributeler kendi oluşturduğumuz attributelere belirli şartlar sunarak kullanılmasını sağladığımız yapıdır. Oluşturduğuumuuz attributelerin hangi kod yapılarında kullanılacağını veya birden fazla yerde kullanılıp kullanılmayacağını belirtiriz. Bu kuralları oluşturduğumuz attribute classının hemen üstünde tanımlamaktayız.
<br>
![banner resmi](https://github.com/sonmezhakan/Attributes/blob/main/%C5%9Eartl%C4%B1%20Attribute.JPG)
