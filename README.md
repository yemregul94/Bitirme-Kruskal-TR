# Kruskal Algoritması Çözücüsü

Asgari tarama ağacı veya minimum kapsama ağacı; üzerindeki düğümlerin ağırlıklı ve yönsüz kenarlar aracılığı ile bağlanan bir ağaç yapısı üzerinde, tüm düğümleri düğüm yaratmadan en düşük maliyetle gezmeyi amaçlayan bir algoritma türüdür. İlk asgari tarama ağacı örneği 1926 yılında Otakar Brukva tarafından geliştirilmiştir, daha sonra 1956 yılında Joseph Kruskal tarafından geliştirilen ve Kruskal Algoritması olarak adlandırılan örneği ile yaygın kullanılan bir konuma gelmiştir. Kruskal algoritması, düğümler arasındaki en kısa yolları birleştirerek bir döngüye girmeden tüm düğümleri en düşük maliyet ile dolaşmayı hesaplayan bir algoritmadır. Günümüzde birçok alanda kullanılan Kruskal algoritması, tarama ağacı algoritmaları içinde en yaygın olanlardan biridir. Bu uygulamanın amacı Kruskal algoritmasını, örnekler üzerinde çözerek basit bir şekilde mantığını da anlatmaktır. Herhangi bir anlatım olmadan direkt sonuca ulaşma imkanı da mevcuttur.

## Kullanılan Yöntemler
Uygulamanın geliştirilmesinde Visual Studio geliştirme ortamı kullanılmıştır. Yazılım dili olarak da C# tercihedilmiştir. Uygulamanın görsel açıdan ihtiyacı karşılaması ve güzel bir görsellik sunması için form ara yüzü kullanılmıştır. Uygulamada düğüm ve kenarların saklanması için Liste veri tipi kullanılmıştır bu tercih verilerin, dinamik bir dizi üzerinde tutulmasına imkan sağlamıştır. Kullanıcıya düğüm ve kenar ekleyerek yeni bir ağaç oluşturma imkanı sunulurken diğer bir seçenek olarak da önceden tanımlı bir ağaç üzerinde Kruskal algoritmasını deneme imkanı verilmiştir. Kullanıcı sonuca adım adım gidebileceği gibi tek adımda dagidebilmektedir.

## Çalışma Mantığı
Uygulama, Kruskal algoritmasının kendi yapısına uygun olarak çalışmaktadır. Öncelikle kullanıcıdan alınan veya önceden tanımlanmış ağaç hazır duruma gelince kullanıcı ilerle veya hesapla butonlarından birine basar. Hesapla butonu direkt cevabı yansıtırken, ilerle butonu cevaba adım adım gider ve yandaki anlatım ekranında o anki işlemi anlatır. Kullanıcı ilerle butonuna bastığında öncelikle kenarlar küçükten büyüğe doğru sıralanır ardından ilk kenar yeni ağaca eklenir. Sonraki adımda ikinci kenar eklenir ardından gelen kenarlar eğer düğüm oluşturmuyorsa düğüm oluşturmadığı belirtilir ve ağaca eklenir, düğüm oluşturuyorsa düğüm oluşturduğu belirtilerek eklenmez. Tüm kenarlar gezildikten sonra gezme işlemi sona erer ve ağaca eklenen kenarların maliyetleri toplanıp ekrana mesaj olarak yansıtılır.

## Sonuçlar
Uygulama, Kruskal algoritmasını başarılı şekilde çalıştırmıştır. Başlangıçtaki ağaç içindeki kenarlar arasından döngü oluşturmadan en düşük maliyetli asgari tarama ağaçları elde edilmiştir. Tüm işlemler de kullanıcıya bilgi olarak sunulmuştur. Kullanıcının tercihine bağlı olarak ağaç önceden tanımlı veya dinamik ekleme imkanıyla kullanıcı girişli olarak eklenmiştir. Eklenen ağaçlar yine kullanıcının tercihine bağlı olarak adım adım anlatma şeklinde veya direkt olarak sonucu yansıtma şeklinde çözülmüştür. Kullanıcıya adım içindeki anlatım ve ekrana çizme farkını rahat görebilmesi için adım gecikmesini kaydırma çubuğu ile seçme imkanı verilmiştir.

# Ekran Görüntüleri
Aşağıda uygulamadan alınan resimler ve gif örnekleri yer almaktadır. 

## Ana Ekran ve Önceden Girilmiş Verilerle İşlem

<a href="https://github.com/yemregul94/Kruskal-Algoritma-Cozucu/blob/main/screenshots/1_main.png" target="_blank">
<img src="https://github.com/yemregul94/Kruskal-Algoritma-Cozucu/blob/main/screenshots/1_main.png" width="400" style="max-width:100%;"></a>

<a href="https://github.com/yemregul94/Kruskal-Algoritma-Cozucu/blob/main/screenshots/2_standard.png" target="_blank">
<img src="https://github.com/yemregul94/Kruskal-Algoritma-Cozucu/blob/main/screenshots/2_standard.png" width="400" style="max-width:100%;"></a>

<a href="https://github.com/yemregul94/Kruskal-Algoritma-Cozucu/blob/main/screenshots/3_calculate.png" target="_blank">
<img src="https://github.com/yemregul94/Kruskal-Algoritma-Cozucu/blob/main/screenshots/3_calculate.png" width="400" style="max-width:100%;"></a>

<a href="https://github.com/yemregul94/Kruskal-Algoritma-Cozucu/blob/main/screenshots/4_step.png" target="_blank">
<img src="https://github.com/yemregul94/Kruskal-Algoritma-Cozucu/blob/main/screenshots/4_step.png" width="400" style="max-width:100%;"></a>

## Kullanıcıdan Giriş Alma

<a href="https://github.com/yemregul94/Kruskal-Algoritma-Cozucu/blob/main/screenshots/5_user_input.png" target="_blank">
<img src="https://github.com/yemregul94/Kruskal-Algoritma-Cozucu/blob/main/screenshots/5_user_input.png" width="400" style="max-width:100%;"></a>

<a href="https://github.com/yemregul94/Kruskal-Algoritma-Cozucu/blob/main/screenshots/14_min_tree.png" target="_blank">
<img src="https://github.com/yemregul94/Kruskal-Algoritma-Cozucu/blob/main/screenshots/14_min_tree.png" width="400" style="max-width:100%;"></a>

<a href="https://github.com/yemregul94/Kruskal-Algoritma-Cozucu/blob/main/screenshots/6_add_node.png" target="_blank">
<img src="https://github.com/yemregul94/Kruskal-Algoritma-Cozucu/blob/main/screenshots/6_add_node.png" width="400" style="max-width:100%;"></a>

<a href="https://github.com/yemregul94/Kruskal-Algoritma-Cozucu/blob/main/screenshots/7_add_edge.png" target="_blank">
<img src="https://github.com/yemregul94/Kruskal-Algoritma-Cozucu/blob/main/screenshots/7_add_edge.png" width="400" style="max-width:100%;"></a>

<a href="https://github.com/yemregul94/Kruskal-Algoritma-Cozucu/blob/main/screenshots/8_edge_exist.png" target="_blank">
<img src="https://github.com/yemregul94/Kruskal-Algoritma-Cozucu/blob/main/screenshots/8_edge_exist.png" width="400" style="max-width:100%;"></a>

<a href="https://github.com/yemregul94/Kruskal-Algoritma-Cozucu/blob/main/screenshots/9_missing_tree.png" target="_blank">
<img src="https://github.com/yemregul94/Kruskal-Algoritma-Cozucu/blob/main/screenshots/9_missing_tree.png" width="400" style="max-width:100%;"></a>

<a href="https://github.com/yemregul94/Kruskal-Algoritma-Cozucu/blob/main/screenshots/10_user_tree.png" target="_blank">
<img src="https://github.com/yemregul94/Kruskal-Algoritma-Cozucu/blob/main/screenshots/10_user_tree.png" width="400" style="max-width:100%;"></a>

<a href="https://github.com/yemregul94/Kruskal-Algoritma-Cozucu/blob/main/screenshots/11_user_result.png" target="_blank">
<img src="https://github.com/yemregul94/Kruskal-Algoritma-Cozucu/blob/main/screenshots/11_user_result.png" width="400" style="max-width:100%;"></a>

## GIF ile Çözümler

<a href="https://github.com/yemregul94/Kruskal-Algoritma-Cozucu/blob/main/screenshots/12_standard_gif.gif" target="_blank">
<img src="https://github.com/yemregul94/Kruskal-Algoritma-Cozucu/blob/main/screenshots/12_standard_gif.gif" width="800" style="max-width:100%;"></a>

<a href="https://github.com/yemregul94/Kruskal-Algoritma-Cozucu/blob/main/screenshots/13_user_gif.gif" target="_blank">
<img src="https://github.com/yemregul94/Kruskal-Algoritma-Cozucu/blob/main/screenshots/13_user_gif.gif" width="800" style="max-width:100%;"></a>
