# Net Core Backend Project

Bu repository, [Yazılım Geliştirici Eğitim Kampı](https://www.kodlama.io/p/yazilim-gelistirici-yetistirme-kampi) kapsamında geliştirilen bir E-Ticaret projesinin backend tarafını içermektedir.

## Proje Tanımı

Proje, N-Katmanlı Solid mimari yapısını benimseyen bir E-Ticaret uygulamasının backend tarafını içermektedir. Temel amacı, yazılım geliştirme prensiplerine uygun bir biçimde tasarlanmış, genişletilebilir, sürdürülebilir ve güvenli bir altyapı sağlamaktır.

## Teknolojiler ve Kullanılan Araçlar

- **`Dil: C#`**

  - C#, Microsoft tarafından geliştirilen, genel amaçlı, modern bir programlama dilidir. .NET platformu üzerinde çalışır ve nesne yönelimli programlama (OOP) prensiplerine dayanır. .NET Core, çoklu platformlarda çalışabilen ve açık kaynaklı bir framework olduğu için tercih edilmiştir.

- **`Çatı/Framework: .NET Core`**

  - .NET Core, Microsoft tarafından geliştirilen, çoklu platformlarda çalışabilen, modüler ve açık kaynaklı bir framework'tür. Genellikle web uygulamaları, mikro hizmetler, bulut uygulamaları ve çeşitli platformlarda çalışan uygulamalar geliştirmek için kullanılır.

- **`ORM (Object-Relational Mapping): Entity Framework Core`**

  - Entity Framework Core, .NET Core platformu için geliştirilmiş bir ORM aracıdır. Veritabanı işlemlerini daha nesne odaklı bir yaklaşımla yönetmeyi sağlar. Veritabanı ile nesne modeli arasında bir eşleme (mapping) yaparak, veritabanı işlemlerini kolaylaştırır.

- **`IoC Container: Autofac`**

  - Autofac, Inversion of Control (IoC) prensibine dayanan bir IoC konteyneridir. IoC, bir bileşenin bağımlılıklarının dışarıdan enjekte edilmesini sağlayarak, bağımlılıklar arasındaki sıkı bağımlılığı azaltır. Autofac, .NET platformunda sıkça kullanılan bir IoC konteyneridir.

- **`Doğrulama ve Yetkilendirme: JSON Web Token (JWT)`**

  - JSON Web Token (JWT), iki taraf arasında veri transferi için kullanılan bir açık standarda dayalı bir token formatıdır. Web uygulamalarında kullanıcı doğrulama ve yetkilendirme işlemlerinde sıkça kullanılır. JWT'ler, verilerin güvenli bir şekilde iletilmesini sağlar.

- **`Veri Doğrulama: FluentValidation`**

  - FluentValidation, nesne üzerinde doğrulama kurallarını belirlemek için kullanılan bir kütüphanedir. Özellikle DTO'lar üzerinde yapılan veri doğrulama işlemlerinde kullanılır. FluentValidation, kuralların okunabilir bir şekilde ifade edilmesine olanak tanır.

- **`Cache Yönetimi: Bellek Tabanlı Önbellekleme`**
  - Bellek tabanlı önbellekleme, sıkça kullanılan verilerin bellekte tutularak tekrar erişimde hız kazanılmasını sağlayan bir yöntemdir. Özellikle performansı artırmak amacıyla sıkça erişilen verilerin tekrar tekrar veritabanından çekilmesini önler ve uygulama yanıtlarını hızlandırır.

## Proje Yapısı ve Modüller

![Proje Yapısı](https://github.com/muazerdemyigit/NetCoreBackendProject/blob/main/images/image.png)

| **_Modül_**                                                                                  | **_Açıklama_**                                               |
| -------------------------------------------------------------------------------------------- | ------------------------------------------------------------ |
| [`Business`](https://github.com/muazerdemyigit/NetCoreBackendProject/tree/main/Business)     | İş mantığına ait soyutlamalar, somut uygulamalar ve sabitler |
| [`Core`](https://github.com/muazerdemyigit/NetCoreBackendProject/tree/main/Core)             | Temel yapı ve çekirdek bileşenler                            |
| [`DataAccess`](https://github.com/muazerdemyigit/NetCoreBackendProject/tree/main/DataAccess) | Veritabanı erişimi için soyutlamalar ve somut uygulamalar    |
| [`Entities`](https://github.com/muazerdemyigit/NetCoreBackendProject/tree/main/Entities)     | Veritabanı varlıkları ve DTO'lar                             |
| [`WebAPI`](https://github.com/muazerdemyigit/NetCoreBackendProject/tree/main/WebAPI)         | API endpoint'leri ve kontrolörler                            |

---

### `Business`

![Business](https://github.com/muazerdemyigit/NetCoreBackendProject/blob/main/images/image-1.png)

- **`Abstract`**
  - [`IAuthService.cs`](https://github.com/muazerdemyigit/NetCoreBackendProject/blob/main/Business/Abstract/IAuthService.cs): Kullanıcı kimlik doğrulama servisi için arayüz.
  - [`ICategoryService.cs`](https://github.com/muazerdemyigit/NetCoreBackendProject/blob/main/Business/Abstract/ICategoryService.cs): Kategori işlemleri servisi için arayüz.
  - [`IProductService.cs`](https://github.com/muazerdemyigit/NetCoreBackendProject/blob/main/Business/Abstract/IProductService.cs): Ürün işlemleri servisi için arayüz.
  - [`IUserService.cs`](https://github.com/muazerdemyigit/NetCoreBackendProject/blob/main/Business/Abstract/IUserService.cs): Kullanıcı işlemleri servisi için arayüz.
- **`BusinessAspects/Autofac`**
  - [`SecuredOperation.cs`](https://github.com/muazerdemyigit/NetCoreBackendProject/blob/main/Business/BusinessAspects/Autofac/SecuredOperation.cs): Güvenli işlemler için Autofac aspect'i.
- **`Concrete`**
  - [`AuthManager.cs`](https://github.com/muazerdemyigit/NetCoreBackendProject/blob/main/Business/Concrete/AuthManager.cs): Kullanıcı kimlik doğrulama işlemlerini yapan sınıf.
  - [`CategoryManager.cs`](https://github.com/muazerdemyigit/NetCoreBackendProject/blob/main/Business/Concrete/CategoryManager.cs): Kategori işlemlerini yapan sınıf.
  - [`ProductManager.cs`](https://github.com/muazerdemyigit/NetCoreBackendProject/blob/main/Business/Concrete/ProductManager.cs): Ürün işlemlerini yapan sınıf.
  - [`UserManager.cs`](https://github.com/muazerdemyigit/NetCoreBackendProject/blob/main/Business/Concrete/UserManager.cs): Kullanıcı işlemlerini yapan sınıf.
- **`Constants`**
  - [`Messages.cs`](https://github.com/muazerdemyigit/NetCoreBackendProject/blob/main/Business/Constants/Messages.cs): Uygulama genelinde kullanılan mesaj sabitleri.
- **`DependencyResolvers/Autofac`**
  - [`AutofacBusinessModule.cs`](https://github.com/muazerdemyigit/NetCoreBackendProject/blob/main/Business/DependencyResolvers/Autofac/AutofacBusinessModule.cs): Autofac modülü.
- **`ValidationRules/FluentValidation`**
  - [`ProductValidator.cs`](https://github.com/muazerdemyigit/NetCoreBackendProject/blob/main/Business/ValidationRules/FluentValidation/ProductValidator.cs): Ürün doğrulama kurallarını içeren sınıf.

---

### `Core`

![Core](https://github.com/muazerdemyigit/NetCoreBackendProject/blob/main/images/image-2.png)

- **`Aspects/Autofac`**
  - **`Caching`**
    - [`CacheAspect.cs`](https://github.com/muazerdemyigit/NetCoreBackendProject/blob/main/Core/Aspects/Autofac/Caching/CacheAspect.cs): Önbellek yönetimi için Autofac aspect'i.
    - [`CacheRemoveAspect.cs`](https://github.com/muazerdemyigit/NetCoreBackendProject/blob/main/Core/Aspects/Autofac/Caching/CacheRemoveAspect.cs): Önbellekten veri kaldırma için Autofac aspect'i.
  - **`Performance`**
    - [`PerformanceAspect.cs`](https://github.com/muazerdemyigit/NetCoreBackendProject/blob/main/Core/Aspects/Autofac/Performance/PerformanceAspect.cs): Performans yönetimi için Autofac aspect'i.
    - **`Transaction`**
    - [`TransactionScopeAspect.cs`](https://github.com/muazerdemyigit/NetCoreBackendProject/blob/main/Core/Aspects/Autofac/Transaction/TransactionScopeAspect.cs): Transaction yönetimi için Autofac aspect'i.
  - **`Validation`**
    - [`ValidationAspect.cs`](https://github.com/muazerdemyigit/NetCoreBackendProject/blob/main/Core/Aspects/Autofac/Validation/ValidationAspect.cs): Veri doğrulama için Autofac aspect'i.
- **`CrossCuttingConserns`**
  - **`Caching`**
    - **`Microsoft`**
      - [`MemoryCacheManager.cs`](https://github.com/muazerdemyigit/NetCoreBackendProject/blob/main/Core/CrossCuttingConserns/Caching/Microsoft/MemoryCacheManager.cs): Bellek tabanlı önbellekleme yönetimi.
    - [`ICacheManager.cs`](https://github.com/muazerdemyigit/NetCoreBackendProject/blob/main/Core/CrossCuttingConserns/Caching/ICacheManager.cs): Önbellekleme işlemleri için arayüz.
  - **`Validation`**
    - [`ValidationTool.cs`](https://github.com/muazerdemyigit/NetCoreBackendProject/blob/main/Core/CrossCuttingConserns/Validation/ValidationTool.cs): Genel veri doğrulama işlemleri.
- **`DataAccess`**
  - **`EntityFramework`**
    - [`EfEntityRepositoryBase.cs`](https://github.com/muazerdemyigit/NetCoreBackendProject/blob/main/Core/DataAccess/EntityFramework/EfEntityRepositoryBase.cs): Entity Framework temelli genel veri erişim sınıfı.
  - [`IEntityRepository.cs`](https://github.com/muazerdemyigit/NetCoreBackendProject/blob/main/Core/DataAccess/IEntityRepository.cs): Genel veri erişim arayüzü.
- **`DependencyResolvers`**
  - [`CoreModule.cs`](https://github.com/muazerdemyigit/NetCoreBackendProject/blob/main/Core/DependencyResolvers/CoreModule.cs): Core katmanındaki bağımlılıkları çözen Autofac modülü.
- **`Entities`**
  - **`Concrete`**
    - [`OperationClaim.cs`](https://github.com/muazerdemyigit/NetCoreBackendProject/blob/main/Core/Entities/Concrete/OperationClaim.cs): Kullanıcı operasyon yetkileri.
    - [`User.cs`](https://github.com/muazerdemyigit/NetCoreBackendProject/blob/main/Core/Entities/Concrete/User.cs): Kullanıcı bilgileri.
    - [`UserOperationClaim.cs`](https://github.com/muazerdemyigit/NetCoreBackendProject/blob/main/Core/Entities/Concrete/UserOperationClaim.cs): Kullanıcı operasyon yetki ilişkisi.
  - [`IDto.cs`](https://github.com/muazerdemyigit/NetCoreBackendProject/blob/main/Core/Entities/IDto.cs): Veritabanı nesnesi arayüzü.
  - [`IEntity.cs`](https://github.com/muazerdemyigit/NetCoreBackendProject/blob/main/Core/Entities/IEntity.cs): Veritabanı nesnesi arayüzü.
- **`Extensions`**
  - [`ClaimExtensions.cs`](https://github.com/muazerdemyigit/NetCoreBackendProject/blob/main/Core/Extensions/ClaimExtensions.cs): Kullanıcı operasyon yetkileri için uzantılar.
  - [`ClaimsPrincipalExtensions.cs`](https://github.com/muazerdemyigit/NetCoreBackendProject/blob/main/Core/Extensions/ClaimsPrincipalExtensions.cs): Kullanıcı yetki uzantıları.
  - [`ServiceCollectionExtensions.cs`](https://github.com/muazerdemyigit/NetCoreBackendProject/blob/main/Core/Extensions/ServiceCollectionExtensions.cs): IServiceCollection için uzantılar.
- **`Utilities`**
  - **`Business`**
    - [`BusinessRules.cs`](https://github.com/muazerdemyigit/NetCoreBackendProject/blob/main/Core/Utilities/Business/BusinessRules.cs): İş kuralları için yardımcı sınıf.
  - **`Interceptors`**
    - [`AspectInterceptorSelector.cs`](https://github.com/muazerdemyigit/NetCoreBackendProject/blob/main/Core/Utilities/Interceptors/AspectInterceptorSelector.cs): Aspect interceptor seçimi için sınıf.
    - [`MethodInterception.cs`](https://github.com/muazerdemyigit/NetCoreBackendProject/blob/main/Core/Utilities/Interceptors/MethodInterception.cs): Metodun önünden ve sonundan işlem yapmak için sınıf.
    - [`MethodInterceptionBaseAttribute.cs`](https://github.com/muazerdemyigit/NetCoreBackendProject/blob/main/Core/Utilities/Interceptors/MethodInterceptionBaseAttribute.cs): Metot intercept eden temel sınıf.
  - **`IoC`**
    - [`ICoreModule.cs`](https://github.com/muazerdemyigit/NetCoreBackendProject/blob/main/Core/Utilities/IoC/ICoreModule.cs): Core module arayüzü.
    - [`ServiceTool.cs`](https://github.com/muazerdemyigit/NetCoreBackendProject/blob/main/Core/Utilities/IoC/ServiceTool.cs): IServiceCollection ve Autofac için yardımcı sınıf.
  - **`Results`**
    - [`DataResult.cs`](https://github.com/muazerdemyigit/NetCoreBackendProject/blob/main/Core/Utilities/Results/DataResult.cs): Veri sonuçları için temel sınıf.
    - [`ErrorDataResult.cs`](https://github.com/muazerdemyigit/NetCoreBackendProject/blob/main/Core/Utilities/Results/ErrorDataResult.cs): Hata içeren veri sonuçları için sınıf.
    - [`ErrorResult.cs`](https://github.com/muazerdemyigit/NetCoreBackendProject/blob/main/Core/Utilities/Results/ErrorResult.cs): Hata sonuçları için sınıf.
    - [`IDataResult.cs`](https://github.com/muazerdemyigit/NetCoreBackendProject/blob/main/Core/Utilities/Results/IDataResult.cs): Veri sonuçları için arayüz.
    - [`IResult.cs`](https://github.com/muazerdemyigit/NetCoreBackendProject/blob/main/Core/Utilities/Results/IResult.cs): Sonuçlar için arayüz.
    - [`Result.cs`](https://github.com/muazerdemyigit/NetCoreBackendProject/blob/main/Core/Utilities/Results/Result.cs): Temel sonuç sınıfı.
    - [`SuccessDataResult.cs`](https://github.com/muazerdemyigit/NetCoreBackendProject/blob/main/Core/Utilities/Results/SuccessDataResult.cs): Başarılı ve veri içeren sonuçlar için sınıf.
    - [`SuccessResult.cs`](https://github.com/muazerdemyigit/NetCoreBackendProject/blob/main/Core/Utilities/Results/SuccessResult.cs): Başarılı sonuçlar için sınıf.
  - **`Security`**
    - **`Encryption`**
      - [`SecurityKeyHelper.cs`](https://github.com/muazerdemyigit/NetCoreBackendProject/blob/main/Core/Utilities/Security/Encryption/SecurityKeyHelper.cs): Güvenlik anahtarları için yardımcı sınıf.
    - **`Hashing`**
      - [`HashingHelper.cs`](https://github.com/muazerdemyigit/NetCoreBackendProject/blob/main/Core/Utilities/Security/Hashing/HashingHelper.cs): Hash fonksiyonları için yardımcı sınıf.
    - **`JWT`**
      - [`AccessToken.cs`](https://github.com/muazerdemyigit/NetCoreBackendProject/blob/main/Core/Utilities/Security/JWT/AccessToken.cs): Access token modeli.
      - [`ITokenHelper.cs`](https://github.com/muazerdemyigit/NetCoreBackendProject/blob/main/Core/Utilities/Security/JWT/ITokenHelper.cs): JWT token yardımcısı arayüzü.
      - [`JwtHelper.cs`](https://github.com/muazerdemyigit/NetCoreBackendProject/blob/main/Core/Utilities/Security/JWT/JwtHelper.cs): JWT token yardımcısı sınıfı.
      - [`TokenOptions.cs`](https://github.com/muazerdemyigit/NetCoreBackendProject/blob/main/Core/Utilities/Security/JWT/TokenOptions.cs): JWT token seçenekleri.

---

### `DataAccess`
![DataAccess](https://github.com/muazerdemyigit/NetCoreBackendProject/blob/main/images/image-3.png)
- **`Abstract`**
  - [`ICategoryDal.cs`](https://github.com/muazerdemyigit/NetCoreBackendProject/blob/main/DataAccess/Abstract/ICategoryDal.cs): Kategori veri erişim arayüzü.
  - [`ICustomerDal.cs`](https://github.com/muazerdemyigit/NetCoreBackendProject/blob/main/DataAccess/Abstract/ICustomerDal.cs): Müşteri veri erişim arayüzü.
  - [`IOrderDal.cs`](https://github.com/muazerdemyigit/NetCoreBackendProject/blob/main/DataAccess/Abstract/IOrderDal.cs): Sipariş veri erişim arayüzü.
  - [`IProductDal.cs`](https://github.com/muazerdemyigit/NetCoreBackendProject/blob/main/DataAccess/Abstract/IProductDal.cs): Ürün veri erişim arayüzü.
  - [`IUserDal.cs`](https://github.com/muazerdemyigit/NetCoreBackendProject/blob/main/DataAccess/Abstract/IUserDal.cs): Kullanıcı veri erişim arayüzü.
- **`Concrete`**
  - **`EntityFramework`**
    - [`EfCategoryDal.cs`](https://github.com/muazerdemyigit/NetCoreBackendProject/blob/main/DataAccess/Concrete/EntityFramework/EfCategoryDal.cs): Kategori veri erişim sınıfı.
    - [`EfOrderDal.cs`](https://github.com/muazerdemyigit/NetCoreBackendProject/blob/main/DataAccess/Concrete/EntityFramework/EfOrderDal.cs): Sipariş veri erişim sınıfı.
    - [`EfProductDal.cs`](https://github.com/muazerdemyigit/NetCoreBackendProject/blob/main/DataAccess/Concrete/EntityFramework/EfProductDal.cs): Ürün veri erişim sınıfı.
    - [`EfUserDal.cs`](https://github.com/muazerdemyigit/NetCoreBackendProject/blob/main/DataAccess/Concrete/EntityFramework/EfUserDal.cs): Kullanıcı veri erişim sınıfı.
    - [`NorthwindContext.cs`](https://github.com/muazerdemyigit/NetCoreBackendProject/blob/main/DataAccess/Concrete/EntityFramework/NorthwindContext.cs): Entity Framework veritabanı bağlamı.
  - **`InMemory`**
    - [`InMemoryProductDal.cs`](https://github.com/muazerdemyigit/NetCoreBackendProject/blob/main/DataAccess/Concrete/InMemory/InMemoryProductDal.cs): Ürün veri erişim sınıfı (In-memory).

---

### `Entities`
![Entities](https://github.com/muazerdemyigit/NetCoreBackendProject/blob/main/images/image-4.png)
- **`Concrete`**
  - [`Category.cs`](https://github.com/muazerdemyigit/NetCoreBackendProject/blob/main/Entities/Concrete/Category.cs): Kategori varlık sınıfı.
  - [`Customer.cs`](https://github.com/muazerdemyigit/NetCoreBackendProject/blob/main/Entities/Concrete/Customer.cs): Müşteri varlık sınıfı.
  - [`Order.cs`](https://github.com/muazerdemyigit/NetCoreBackendProject/blob/main/Entities/Concrete/Order.cs): Sipariş varlık sınıfı.
  - [`Product.cs`](https://github.com/muazerdemyigit/NetCoreBackendProject/blob/main/Entities/Concrete/Product.cs): Ürün varlık sınıfı.
- **`DTOs`**
  - [`ProductDetailDto.cs`](https://github.com/muazerdemyigit/NetCoreBackendProject/blob/main/Entities/DTOs/ProductDetailDto.cs): Ürün detay DTO sınıfı.
  - [`UserForLoginDto.cs`](https://github.com/muazerdemyigit/NetCoreBackendProject/blob/main/Entities/DTOs/UserForLoginDto.cs): Giriş yapma için kullanıcı DTO sınıfı.
  - [`UserForRegisterDto.cs`](https://github.com/muazerdemyigit/NetCoreBackendProject/blob/main/Entities/DTOs/UserForRegisterDto.cs): Kayıt olma için kullanıcı DTO sınıfı.


---

### `WebAPI`
![WebAPI](https://github.com/muazerdemyigit/NetCoreBackendProject/blob/main/images/image-5.png)
- **`Controllers`**
  - [`AuthController.cs`](https://github.com/muazerdemyigit/NetCoreBackendProject/blob/main/WebAPI/Controllers/AuthController.cs): Kimlik doğrulama işlemleri için API controller'ı.
  - [`ProductsController.cs`](https://github.com/muazerdemyigit/NetCoreBackendProject/blob/main/WebAPI/Controllers/ProductsController.cs): Ürün işlemleri için API controller'ı.
- [`Program.cs`](https://github.com/muazerdemyigit/NetCoreBackendProject/blob/main/WebAPI/Program.cs): Web API uygulamasının başlangıç noktası.
- [`appsettings.json`](https://github.com/muazerdemyigit/NetCoreBackendProject/blob/main/WebAPI/appsettings.json): Uygulama ayarlarını içeren JSON dosyası.


---
***`Bütün Proje Yapısı:`*** [***`İnteraktif olarak bakmak için tıklayınız`***](https://mm.tt/app/map/3055308271?t=WIZ3yInGCN)

 ![Proje Yapısı Açık](https://github.com/muazerdemyigit/NetCoreBackendProject/blob/main/images/image-6.png)

