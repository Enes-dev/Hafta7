// 1. Temel Seçiciler

// Element Seçici: Belirli bir HTML etiketini seçer.
p {
    color: blue; /* Tüm <p> etiketlerinin yazı rengini mavi yapar */
}

// Class Seçici: Belirli bir sınıfa sahip olan tüm elementleri seçer. Sınıf, '.' ile başlar.
.highlight {
    background-color: yellow; /* .highlight sınıfına sahip elementlerin arka planını sarı yapar */
}

//ID Seçici: Belirli bir ID’ye sahip olan elementi seçer. ID, '#' ile başlar
#header {
    font-size: 24px; /* #header ID’sine sahip elementin yazı boyutunu 24px yapar */
}


// 2. Birleşik Seçiciler

// Element.Class: Belirli bir elementin belirli bir sınıfa sahip olduğu durumda seçilir.
div.alert {
    border: 1px solid red; /* div elementleri içinde .alert sınıfına sahip olanları seçer */
}

// Element#ID: Belirli bir elementin belirli bir ID’ye sahip olduğu durumda seçilir.
h1#main-title {
    color: green; /* h1 etiketleri içinde #main-title ID’sine sahip olanı seçer */
}

// 3. Pseudo-class Seçicileri

// Kullanıcı fare ile üzerine geldiğinde uygulanır.
a:hover {
    color: red; /* Bağlantının üzerine gelindiğinde rengi kırmızı yapar */
}

// Bir element üzerinde odaklandığında uygulanır.
input:focus {
    border: 2px solid blue; /* Input alanına tıklandığında kenarlığını mavi yapar */
}

//Kullanıcı bir elemente tıkladığında uygulanır.
button:active {
    background-color: grey; /* Butona tıklandığında arka plan rengi gri olur */
}



//1. Box Model
//Box Model, her HTML elementinin bir kutu olarak düşünüldüğünde dört ana bölümden oluştuğunu belirtir:

//Content: İçerik bölümü.
//Padding: İçerik ile sınır arasında yer alan boşluk.
//Border: Padding ile dış kenar arasındaki sınır.
//Margin: Kutunun dışındaki boşluk.

+--------------------------+
|         Margin           |
|  +--------------------+  |
|  |      Border        |  |
|  |  +-------------+   |  |
|  |  |   Padding   |   |  |
|  |  | +-------+   |   |  |
|  |  | |Content|   |   |  |
|  |  | +-------+   |   |  |
|  |  +-------------+   |  |
|  +--------------------+  |
+--------------------------+

//2. Display Özellikleri

// block: Eleman, yeni bir satırda başlar ve genişliği varsayılan olarak tam genişliktedir.
.block-element {
    display: block;
}

// inline: Eleman, yeni bir satıra geçmez ve yalnızca içeriği kadar yer kaplar.
.inline-element {
    display: inline;
}

// inline-block: Eleman, yeni bir satıra geçmez ancak genişliği ve yüksekliği ayarlanabilir.
.inline-block-element {
    display: inline-block;
}

// none: Eleman, sayfada görünmez.
.hidden {
    display: none;
}

// 3. Positioning

//static: Varsayılan konumlandırmadır; eleman normal akışta yer alır.
//relative: Elemanın normal konumuna göre yerini ayarlayabilirsiniz.
.relative {
    position: relative;
    top: 10px; /* Yukarıdan 10px kaydırır */
}

//absolute: Eleman, en yakın konumlandırılmış üst elemente göre yer alır.
.absolute {
    position: absolute;
    right: 10px; /* Sağdan 10px kaydırır */
}

//fixed: Eleman, pencereyle sabit kalır, kaydırma ile birlikte hareket etmez.
.fixed {
    position: fixed;
    bottom: 0; /* Alt kısımda sabit kalır */
}

//sticky: Eleman, belirli bir kaydırma noktasında sabitlenir.
.sticky {
    position: sticky;
    top: 0; /* Üst kısımda yapışkan olur */
}

// 1. Renkler
// color: Yazı rengini ayarlar.
// background-color: Arka plan rengini ayarlar.
// Renk Değerleri:

// Hex: #FF5733
// RGB: rgb(255, 87, 51)
// HSL: hsl(12, 100%, 60%)
body {
    color: #333;
    background-color: rgb(240, 240, 240);
}

// 2. Arka Plan Özellikleri
// background-image: Arka plana resim ekler.
// background-size: Resmin boyutunu ayarlar.
// background-repeat: Resmin tekrarını ayarlar.
// background-position: Resmin konumunu ayarlar.
.header {
    background-image: url('header-bg.jpg');
    background-size: cover;
    background-repeat: no-repeat;
    background-position: center;
}

// 1. Font Özellikleri
// font-family: Yazı tipini ayarlar.
// font-size: Yazı boyutunu ayarlar.
// font-weight: Yazının kalınlığını ayarlar.
// font-style: Yazının stilini ayarlar (normal, italic).
// line-height: Satır yüksekliğini ayarlar.
h1 {
    font-family: Arial, sans-serif;
    font-size: 28px;
    font-weight: bold;
    line-height: 1.5;
}

// 2. Metin Stilleri
// text-align: Metin hizalamasını ayarlar (sol, sağ, ortada).
// text-transform: Metin dönüşümünü ayarlar (büyük harf, küçük harf).
// text-decoration: Metin dekorasyonunu ayarlar (altı çizili, üstü çizili).
// letter-spacing: Harfler arasındaki boşluğu ayarlar.
p {
    text-align: justify;
    text-transform: uppercase;
    text-decoration: underline;
    letter-spacing: 1px;
}


// 1. Kenarlık
// border: Kenar çizgisini ayarlar.
// border-radius: Kenar yuvarlaklığını ayarlar.
// border-width: Kenar kalınlığını ayarlar.
// border-style: Kenar stilini ayarlar (solid, dashed, dotted).
// border-color: Kenar rengini ayarlar.
.box {
    border: 2px solid black;
    border-radius: 10px;
    padding: 10px;
}

// 2. Kutunun Kenarları
// Margin: Kutunun dışındaki boşluk.
// Padding: Kutunun içindeki boşluk.
// Border: Kutunun etrafındaki çizgi.
.container {
    margin: 20px;
    padding: 10px;
    border: 1px solid gray;
}


// 1. Media Queries
// @media kuralı, farklı ekran boyutlarına göre stil değişiklikleri yapmak için kullanılır.
@media (max-width: 600px) {
    body {
        background-color: lightblue; /* Ekran 600px’den küçükse arka plan mavi olur */
    }
}

// 2. Viewport Units
// vw: Genişliğin %1’i.
// vh: Yüksekliğin %1’i.
// vmin: Genişlik veya yükseklikten en küçüğü.
// vmax: Genişlik veya yükseklikten en büyüğü.
.box {
    width: 50vw; /* Genişliği ekranın yarısı kadar */
    height: 50vh; /* Yüksekliği ekranın yarısı kadar */
}

