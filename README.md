# ChainOfResponsibility

🚀 Merhaba herkese! 🌟 M&Y Yazılım Eğitim Akademi Danışmanlık eğitimim kapsamında Murat Yücedağ Hocamla geliştirdiğim uygulama, bir Chain of Responsibility deseni gerçeklemesi üzerine kurulu! 🎉 Projem, kredi çekme uygulamasını ele alıyor. 💳

Kullanıcıların çekmek istedikleri kredi miktarına göre, farklı yetkilendirme seviyelerine sahip olan kredi onaylayıcılar tarafından işleniyor. Örneğin, küçük miktarlarda kredi talepleri doğrudan düşük seviye yetkilendirme sahibi bir onaylayıcı tarafından onaylanabilirken, büyük miktarlarda talepler daha üst seviyedeki onaylayıcılara yönlendirilir.

Chain of Responsibility deseni, bir isteği işlemek için bir dizi nesne hiyerarşisi sağlar. İsteğin işlenmesi sırasında herhangi bir nesnenin yetki ve işlem yapabilme durumuna göre doğru onaylayıcıya yönlendirilmesini sağlar. Bu desenin temel fikri, isteği işleyebilecek nesnelerin bir zincirinde yer alması ve isteğin kaynağına doğru ilerlerken herhangi bir nesnenin işleme yetkisini almasını sağlamaktır.

Avantajlarından bazıları şunlardır:

⚙ Esneklik: Her bir işleme nesnesi belirli bir işlemi gerçekleştirebilir veya işlemeyebilir. Bu, sistemin gereksinimlerine göre dinamik olarak ayarlanabilir.

⚙ Kolay Bakım: Her nesne sadece belirli bir işlemle ilgilenir, bu da değişiklikleri kolaylaştırır. Yeni işlem türleri eklemek veya mevcut olanları kaldırmak daha az etkili olur.

⚙ İstek Zinciri: İstek, zincirdeki bir nesne tarafından işlenmezse, zincir boyunca ilerler. Bu, her bir nesnenin belirli bir işlemi kabul edip etmediğini kontrol etmek için bir mekanizma sağlar.

⚙ Basitleştirilmiş İstemci: İstemcinin bir isteği işlemek için hangi nesnenin kullanılacağına dair bilgisi yoktur. Sadece isteği zincire iletir ve zincirdeki nesnelerin ilgilenmesine izin verir.

Bu desen özellikle kullanıcı taleplerini işlemek, günlük olayları filtrelemek veya farklı seviyelerde yetkilendirme yapmak gibi durumlarda faydalıdır.

![Ekran görüntüsü 2024-05-10 213610](https://github.com/ErtugrulGDuman/ChainOfResponsibility/assets/101699189/7dd507d4-81f5-4ea8-8c51-3d2796e7d48e)
![Ekran görüntüsü 2024-05-10 213744](https://github.com/ErtugrulGDuman/ChainOfResponsibility/assets/101699189/3f242e6d-289a-4b06-a3f3-847fc86e5716)
![Ekran görüntüsü 2024-05-10 213822](https://github.com/ErtugrulGDuman/ChainOfResponsibility/assets/101699189/cdd00fd4-2492-495b-accf-aacdf360898b)
