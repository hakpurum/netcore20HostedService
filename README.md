# .net core 2.0 HostedService Zamanlanmış Görevler
Merhaba arkadaşlar,

Bu bölümde sizlere .net core 2.0 ile beraber gelen HostedService işlemlerini anlatmaya çalışacağım. HostedService arkaplanda belirli zamanlarda zamanlanmış görevlerimizin çalışmasını sağlar. .net core Microsoft.Extensions.Hosting ile gelen bu özellik sayesinde zamanlanmış görevleriniz için ekstra Windows servis yazmaya yada hangfire gibi çok fazla kaynak tüketen uygulamaları kullanmaya gerek kalmayacak. Yönetimde tamamen sizin elinizde olacak. Belirli zamanlarda periyodik olarak çalışmasını istediğiniz işlemlerinizi bir sınıfta belirterek HostedService sınıfından türetip injection larınızı yapmanız yeterli olacaktır. Web uygulamanız ayağa kalktığında arkaplanda servislerinizde asenkron olarak çalışmaya başlayacaktır. Ben boş bir .net core 2.0 web projesi oluşturdum. Sonrasında ise  projemize HostedService isimli abstract bir class ekliyoruz.

http://www.yazilimcigunlugu.com/post/.net-core-20-hostedservice-zamanlanmis-gorevler
