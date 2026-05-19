# Plaka Tanıma Sistemi

Türk plakaları otomatik olarak tanıyan ve kayıt altına alan bir masaüstü uygulamasıdır. Sistem yapay zeka teknolojileri kullanarak araç plakaları üzerindeki bilgileri işleyip veritabanına kaydeder.

## Özellikler

- Gerçek zamanlı plaka tanıma ve analizi
- Veritabanı entegrasyonu ile veri saklama
- Kullanıcı dostu arayüz
- SQL Server desteği
- Çoklu plaka tanıma yeteneği

## Ekran Görüntüleri

### Ana Arayüz
![Ana Arayüz](1.png)

### İşlem Ekranı 1
![İşlem Ekranı 1](2.png)

### İşlem Ekranı 2
![İşlem Ekranı 2](3.png)

### Detay Görünümü
![Detay Görünümü](4.png)

### Raporlama
![Raporlama](5.png)

## Teknoloji Yığını

- **Dil**: C#
- **Veritabanı**: SQL Server
- **Platform**: Windows Masaüstü Uygulaması
- **Framework**: .NET

## Kurulum

1. Projeyi klonlayın:
```bash
git clone https://github.com/Mahmutgovce/PlakaTanimaSistemi.git
cd PlakaTanimaSistemi
```

2. Çözümü Visual Studio'da açın (PlakaTanimaSistemi.slnx)

3. Gerekli NuGet paketlerini yükleyin

4. Veritabanı komut dosyalarını çalıştırın:
   - SQLQuery1.sql
   - SQLQuery2.sql
   - SQLQuery3.sql
   - SQLQuery4.sql
   - SQLQuery5.sql
   - SQLQuery6.sql

5. Uygulamayı derleyin ve çalıştırın

## Veritabanı

Veritabanı yapılandırması için proje köküne eklenen SQL script dosyaları kullanılır. Tablolar, ilişkiler ve başlangıç verileri bu dosyalarla otomatik olarak oluşturulur.

## Proje Yapısı

```
PlakaTanimaSistemi/
├── aaaaaa/
│   └── PlakaTanimaSistemi.csproj
├── SQLQuery1-6.sql (Veritabanı komut dosyaları)
├── PlakaTanimaSistemi.slnx (Çözüm dosyası)
└── README.md
```

## Kullanım

1. Uygulamayı başlatın
2. Plaka tanıma işlemini başlatın
3. Tanınan plakaları görüntüleyin
4. Bilgileri veritabanına kaydedin
5. Raporları oluşturun ve dışa aktarın

## Katkıda Bulunma

Projeye katkıda bulunmak istiyorsanız:

1. Depoyu fork edin
2. Özellik dalı oluşturun (`git checkout -b ozellik/YeniOzellik`)
3. Değişikliklerinizi commit edin (`git commit -m 'Yeni özellik ekle'`)
4. Dalınıza push yapın (`git push origin ozellik/YeniOzellik`)
5. Pull Request açın

## Gereksinimler

- Windows 7 veya daha yeni
- .NET Framework 4.7.2 veya üzeri
- SQL Server 2016 veya daha yeni
- Minimum 2GB RAM
- 500MB boş disk alanı

## Lisans

Bu proje açık kaynak koşullarında yayınlanmıştır.

## İletişim

Sorularınız veya önerileriniz için lütfen [Issues](https://github.com/Mahmutgovce/PlakaTanimaSistemi/issues) bölümünü kullanın.
