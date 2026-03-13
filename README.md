# Sayaç Problemi

## Proje Hakkında
Bu proje, belirli bir rakamı atlayarak sayma işlemi gerçekleştiren hatalı veya özel tasarlanmış sayaçların durumunu hesaplamak amacıyla geliştirilmiş bir uygulamadır. İlk olarak 2013 yılında Problem Tanımı'nda yer alan matematik problemini çözmek için oluşturulmuş, daha sonra kod yapısı yeniden incelenerek algoritmik iyileştirmeler yapılmış ve benzer yapıdaki farklı problemlere uyarlanabilecek şekilde genelleştirilmiştir.

## Problem Tanımı
Uygulamanın temelini oluşturan matematik problemi şu şekildedir:

> "Bir aracın kilometre sayacı 4 rakamına her geldiğinde atlayarak 5 rakamına geçiyor. Bu araç 1412 km yol yaptığında sayaç kaç değerini gösterir?"

Bu tür problemler, sayı tabanlarının dönüştürülmesi mantığına benzer bir yapı sunar. Proje, sadece belirli bir rakamı atlayan sayaçlar için değil, kurulan genel algoritma mantığı sayesinde farklı atlama senaryoları için de çözüm üretebilecek bir altyapı hedeflenerek tasarlanmıştır.

## Çözüm ve Algoritma Yaklaşımı
Problem, temelde standart onluk (decimal) sayı sisteminden farklı davranan bir yapı içerir. Herhangi bir rakam atlandığında, sayacın gösterdiği sayı ile gerçekte kat edilen mesafe arasındaki ilişki doğrusallıktan (lineerlikten) çıkar. Uygulama, gerçek mesafe değerini alıp, sayacın kaçıracağı adım sayısını hesaplayarak ekranda görünecek nihai sayıyı algoritmik olarak belirler.

## Kullanılan Teknolojiler
* **Programlama Dili:** C#
* **Geliştirme Ortamı:** Microsoft Visual Studio (veya .NET uyumlu diğer IDE/Editörler)

## Kurulum ve Çalıştırma
Projeyi yerel ortamınıza indirip çalıştırmak için aşağıdaki adımları izleyebilirsiniz:

1.  Depoyu bilgisayarınıza klonlayın:
    ```bash
    git clone [https://github.com/haruncetin/SayacProblemi.git](https://github.com/haruncetin/SayacProblemi.git)
    ```

2.  Klonlanan proje dizinine gidin:
    ```bash
    cd SayacProblemi
    ```

3.  Projeyi derlemek ve çalıştırmak için `SayacProblemi.sln` dosyasını Visual Studio ile açıp çalıştırabilir veya .NET CLI kullanarak komut satırından aşağıdaki komutları verebilirsiniz:
    ```bash
    dotnet build
    dotnet run --project SayacProblemi
    ```

## Lisans
Bu proje **GPL-3.0** lisansı altında açık kaynak olarak paylaşılmıştır. Detaylı kullanım ve dağıtım hakları için depoda bulunan `LICENSE.txt` dosyasını inceleyebilirsiniz.
