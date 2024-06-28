
# Unity Android Oyun Projesi

![2](https://github.com/MuhammetKoprubasi/DontHitTheObstacle/assets/6284985/27797b3b-542b-46d6-9356-b04a1061c80f)
![3](https://github.com/MuhammetKoprubasi/DontHitTheObstacle/assets/6284985/ab3a98ed-c23b-4673-91ba-4d9ee4cdb1a1)

## İçindekiler

- [Giriş](#giriş)
- [Özellikler](#özellikler)
- [Başlarken](#başlarken)
  - [Gereksinimler](#gereksinimler)
  - [Kurulum](#kurulum)
- [Kullanım](#kullanım)
- [Oyun Mekanikleri](#oyun-mekanikleri)
- [Skriptler](#skriptler)
- [Katkıda Bulunma](#katkıda-bulunma)
- [Lisans](#lisans)

## Giriş

Oyun Projeme hoş geldiniz! Bu, oyuncuların engellerden kaçınarak mümkün olduğunca uzun süre hayatta kalmaları gereken basit ve eğlenceli bir oyundur. Amaç, mümkün olan en yüksek puana ulaşmaktır.

## Özellikler

- Dinamik engel oluşturma
- Skor takibi ve yüksek skor kaydetme
- Akıcı oyuncu kontrolleri
- Basit ve sezgisel kullanıcı arayüzü

## Başlarken

### Gereksinimler

Bu projeyi çalıştırmak için ihtiyacınız olanlar:

- [Unity](https://unity.com/) (versiyon 2020.3.34f1 veya daha üstü)

### Kurulum

1. Depoyu klonlayın:
   ```sh
   git clone https://github.com/ynsemref/DontHitTheObstacle.git
   ```
2. Projeyi Unity'de açın.

## Kullanım

1. Projeyi Unity'de açın.
2. Oyunu istediğiniz platformda derleyin ve çalıştırın.
3. Oyuncuyu kontrol etmek için ok tuşlarını veya dokunmatik girdiyi kullanın.

## Oyun Mekanikleri

- **Oyuncu Hareketi**: Oyuncuyu sola veya sağa hareket ettirmek için ok tuşlarını veya dokunmatik girdiyi kullanın.
- **Skor**: Hayatta kalarak ve öğeleri toplayarak puan kazanın. Puan kaybetmemek için engellerden kaçının.
- **Sağlık**: Oyuncunun engellerle çarpıştığında azalan bir sağlık çubuğu vardır. Sağlık sıfıra düştüğünde oyun sona erer.

## Skriptler

### BackGroundController.cs

Arka plan hareketini kontrol eder ve kaydırma efekti oluşturur.

### CameraFollow.cs

Kameranın oyuncuyu takip etmesini sağlar.

### DestroyMe.cs

Belirli bir ömür süresinden sonra oyun nesnesini yok eder.

### engelolustur.cs

Engel oluşturmayı yönetir.

### MenuManagerMenuScene.cs

Ana menüyü ve sahne geçişlerini yönetir.

### PlayerController.cs

Oyuncu hareketini ve etkileşimlerini yönetir.

### PlayerManager.cs

Oyuncu sağlığını ve oyun sonu koşullarını yönetir.

### Restart.cs

Oyunun yeniden başlatılmasını yönetir.

### ScoreManager.cs

Skoru ve yüksek skoru takip eder ve günceller.

### Spawn2.cs

İkincil engellerin oluşturulmasını yönetir.

## Katkıda Bulunma

Depoyu forklayın ve değişikliklerinizle bir pull request oluşturun. Yeni özellikler veya değişiklikler için README dosyasını güncellediğinizden emin olun.

