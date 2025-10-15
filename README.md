# 🌈 Selection Sort Algoritması

Selection Sort (Seçmeli Sıralama), en temel ve anlaşılması kolay sıralama algoritmalarından biridir. Algoritmanın temel amacı, her adımda dizinin en küçük (veya en büyük) elemanını bulup onu dizinin başındaki elemanla yer değiştirmektir. Bu işlem, dizinin tamamı sıralanana kadar tekrarlanır.

---

## 🚀 Algoritmanın Çalışma Adımları

1. Dizinin ilk elemanından başlayarak en küçük elemanı bul.
2. Bulunan en küçük elemanı, dizinin ilk elemanı ile yer değiştir.
3. Dizinin kalan kısmı için (ilk eleman hariç) aynı işlemi tekrarla.
4. Son eleman sıralandığında algoritma tamamlanmış olur.

---

## 📊 Zaman Karmaşıklığı

- **En iyi durum:** O(n²)
- **Ortalama durum:** O(n²)
- **En kötü durum:** O(n²)
- **Ekstra bellek gereksinimi:** O(1) (in-place sıralama)

---

## ✅ Avantajları ve ❌ Dezavantajları

### Avantajları
- Uygulaması ve anlaşılması oldukça basittir.
- Ekstra bellek gereksinimi yoktur (in-place).

### Dezavantajları
- Büyük veri kümeleri için verimsizdir.
- Zaman karmaşıklığı yüksektir.

---

## 🎯 Kullanım Alanları

- Küçük veri kümeleri için uygundur.
- Sıralama algoritmalarını anlamak ve öğretmek için idealdir.

---


# 🌈 Insertion Sort Algoritması

Insertion Sort (Eklemeli Sıralama), basit ve anlaşılır bir sıralama algoritmasıdır. Özellikle küçük veri kümeleri için oldukça etkili çalışır. Algoritmanın temel fikri, dizinin sıralanmamış kısmındaki elemanları, sıralı kısmın doğru yerine “ekleyerek” diziyi sıralamaktır.

---

## 🚀 Algoritmanın Çalışma Adımları

1. Dizinin ilk elemanı zaten sıralı kabul edilir.
2. Sonraki eleman alınır ve sıralı olan bölümde doğru yere yerleştirilir.
3. Her eklenen eleman için, sıralı bölümdeki elemanlar sağa kaydırılır.
4. Tüm elemanlar doğru pozisyona yerleştirene kadar işlem devam eder.

---

## 📊 Zaman Karmaşıklığı

- **En iyi durum:** O(n) (dizi zaten sıralıysa)
- **Ortalama durum:** O(n²)
- **En kötü durum:** O(n²)
- **Ekstra bellek gereksinimi:** O(1) (in-place sıralama)

---

## ✅ Avantajları ve ❌ Dezavantajları

### Avantajları
- Küçük veri kümeleri için hızlı ve verimlidir.
- Uygulaması oldukça basittir.
- Ekstra bellek gereksinimi yoktur (in-place).

### Dezavantajları
- Büyük veri kümeleri için verimsizdir.
- Zaman karmaşıklığı yüksektir.

---

## 🎯 Kullanım Alanları

- Küçük ve kısmen sıralı veri kümeleri için idealdir.
- Algoritma öğretiminde ve temel sıralama ihtiyaçlarında sıklıkla kullanılır.

---
