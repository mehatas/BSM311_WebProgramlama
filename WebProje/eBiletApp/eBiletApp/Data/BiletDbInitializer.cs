using eBiletApp.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.CodeAnalysis.Differencing;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace eBiletApp.Data
{
    public class BiletDbInitializer
    {
        public static void EklenecekVeriler(IApplicationBuilder ab)
        {
            using(var scope = ab.ApplicationServices.CreateScope())
            {
                var context = scope.ServiceProvider.GetService<BiletDbContext>();

                //veritabaninin olup olmadigi kontrol ediliyor.
                context.Database.EnsureCreated();

               
                if (!context.Sinemalar.Any())
                {
                    context.Sinemalar.AddRange(new List<Sinema>()
                    {
                            new Sinema()
                        {
                            SinemaAdi = "Büyülü Fener Sineması",
                            SinemaFotografi = "~/images/Sinemalar/buyulu-fener.jpg",
                            SinemaHakkinda = "1996 yılında, Ankara'da son dönemlerin en modern sineması Büyülü Fener inşa edildi." +
                            "Sinema 1999 yılında Ankara Film Festivali tarafından nitelikli sinemanın izlenmesine yaptığı katkılardan ötürü kitle İletişim Ödülü'ne layık bulundu. " +
                            "Sinemamızdaki salonların isimleri düzenlenen bir yarışmayla belirlendi. " +
                            "Atıf Yılmaz, Türkan Şoray ve Şener Şen gibi önemli sanatçıların isimleri salonlara verilerek, " +
                            "sanatçılarımız yaşarken onurlandırılmaya çalışıldı. Sinemamızın kurucusu ve sahibi İrfan Demirkol 1997 yılında Tempo dergisi tarafından " +
                            "Ankara'nın vazgeçilemeyen 100 kişisinden biri seçildi."
                        },
                        new Sinema()
                        {
                            SinemaAdi = "Cinemaximum",
                            SinemaFotografi = "~/images/Sinemalar/cinemaximum.png",
                            SinemaHakkinda = "Mars Cinema Group; 2001 yılında teknoloji ve konforu, beklentilerin üzerinde hizmet anlayışı ile birleştirerek, " +
                                            "Türkiye’de farklı ve kendine özgü bir sinema deneyimi yaratma felsefesiyle kurulmuştur."+
                                            "Sunmuş olduğu hizmet ve teknolojik yenilikler ile 2013 yılında dünyanın en büyük sinema birliği olan " +
                                            "UNIC (International Union of Cinemas) tarafından “Uluslararası Yılın Sinema Grubu” ödülüne layık görülen Mars Cinema Group," +
                                            " 36 şehirde 97 sinema işletmesi ve 848 salon sayısı ile Türkiye’nin en büyük sinema zinciridir."
                        },
                         new Sinema()
                        {
                            SinemaAdi = "Prestige Sinema Dünyası",
                            SinemaFotografi = "~/images/Sinemalar/prestigeSinema.jpg",
                            SinemaHakkinda = "Hani biletinizi elinize aldığınızdaki o güzel tebesüm ile salonun yolunu tutarsınız ya, o rahat deri koltuklara oturduğunuzda, " +
                            "hiç tanımadığınız kişiler ile aynı keyfi paylaşırken, filmin sonunda salondan çıkarken, bu keyfin hiç bitmemesini istersiniz, " +
                            "üstelik bir sonraki güzel anılarınız için plan yapmaya başlarsınız; " +
                            "İşte tüm bu heyecan ve güzel anılara sahip olmanız için çalışan ekibimizi sizlerle tanıştırmak isteriz."
                        },
                        new Sinema()
                        {
                            SinemaAdi = "Sinema Yedi",
                            SinemaFotografi = "~/images/Sinemalar/sinemaYedi.jpg",
                            SinemaHakkinda = "Bizim misyonumuz, oda sineması veya kişiye özel sinema konseptiyle, " +
                            "filmseverlere güzel bir kültürel aktiviteyi mümkün olan en huzurlu ortamda, en kaliteli haliyle yaşatmaktır."
                        },
                        new Sinema()
                        {
                            SinemaAdi = "Cinema Pink",
                            SinemaFotografi = "~/images/Sinemalar/cinemapink.jpg",
                            SinemaHakkinda = "Sinema salonu işletmeciliğini bilinen kalıpların dışına çıkarmayı kendine hedef olarak belirleyen Cinema Pink,"+
                                                "öncelikle hem salonlarda, hem de fuaye alanlarında seyircinin rahatını ön planda tutmaktadır."+
                                                "Bunu sadece konfor olarak değil, gişe, cafe ve büfelerdeki fiyatlandırma politikasında da görmeniz mümkündür."+
                                                "‘’Kalite” ve “ucuzluğu” bir arada uygulamak bizim için her zaman öncelikli hedef olmuştur."
                        },
                       
                    
                    });
                    context.SaveChanges();
                }

                if (!context.Oyuncular.Any())
                {
                    context.Oyuncular.AddRange(new List<Oyuncu>()
                    {
                        new Oyuncu()
                        {
                            OyuncuAdSoyad = "Erdal Beşikçioğlu",
                            OyuncuHakkinda = "5 Ocak 1970 yılında, Ünyeli bir baba ve Kosova Priştine'den Ankara'ya göç etmiş " +
                            "Arnavut bir ailenin kızı olan bir annenin ilk çocuğu olarak Ankara'da dünyaya geldi." +
                            " Orta öğrenimini İzmir Özel Türk Kolejinde tamamladı." +
                            " İzmir Narlıdere Mehmet Seyfi Eraltay Lisesinden mezun oldu. 1989 yılında Hacettepe Üniversitesi Devlet Konservatuvarına girdi." +
                            " Konservatuvar eğitimi sırasında William Guskill ile yaratıcı drama üzerine atölye çalışmalarına katıldı. " +
                            "1993 yılında mezun oldu ve aynı yıl Devlet Tiyatrolarında oyuncu olarak göreve başladı." +
                            " 1995-96 sezonunda Diyarbakır Devlet Tiyatrosunda müdür vekili olarak görev aldı.",
                            OyuncuFotografi = "~/images/Oyuncular/erdalbesikcioglu.jpg"
                        },
                        new Oyuncu()
                        {
                            OyuncuAdSoyad = "Haluk Bilginer",
                            OyuncuHakkinda = "5 Haziran 1954 günü üç kardeşin ortancası olarak dünyaya gelmiştir. İzmir Türk Koleji'nden mezun olmuştur." +
                            "Lise son sınıfta okulunun tiyatro koluna girmiş ve Cahit Gürkan'ın öğrencisi olmuştur. Liselerarası tiyatro yarışmasında ilk ödülünü almıştır. " +
                            "Jürideki tiyatro müdürü Ragıp Haykır'ın davetiyle İzmir Devlet Tiyatrosu'nda konuk oyuncu olarak çalıştı." +
                            " Gençlik yıllarında İngiltere'de ün yaptı. Öyle ki; İngiltere'deki bir dergiye en seksi Türk başlığıyla kapak oldu.",

                            OyuncuFotografi = "~/images/Oyuncular/halukbilginer.jpg"

                        },
                        new Oyuncu()
                        {
                            OyuncuAdSoyad = "Nejat İşler",
                            OyuncuHakkinda = "1972 İstanbul Eyüp doğumlu olan Nejat İşler, tiyatroya lise yıllarında başlamıştır." +
                            " Okul hayatından sonra ufak tefek alım-satım işlerine giren İşler, Yıldız Teknik Üniversitesi Fotoğraf bölümünü kazanmasına rağmen okula gitmez" +
                            " ve askerliğini yapıp İstanbul’a geri döner. 1991’de Mimar Sinan Üniversitesi Konservatuar Bölümüne giren İşler 1995’te mezun oluncaya kadar devlet tiyatrosunda " +
                            "ve televizyon dizilerinde rol aldı. ",
                            OyuncuFotografi = "~/images/Oyuncular/nejatisler.jpg"
                        },
                        new Oyuncu()
                        {
                            OyuncuAdSoyad = "Cem Yılmaz",
                            OyuncuHakkinda = "23 Nisan 1973 tarihinde İstanbul'da doğdu. Aslen Gürün, Sivaslıdır. " +
                            "İlköğrenimini Mehmet Âkif İlkokulunda tamamladı. Ortaokulda Bahçelievler Kâzım Karabekir Ortaokulunu, " +
                            "sonrasında da Etiler Anadolu Otelcilik ve Turizm Meslek Lisesi ve Boğaziçi Üniversitesi Turizm İşletmeciliği Bölümünü bitirdi."+
                            "Karikatüre olan ilgisi ve yeteneği sayesinde üniversite yıllarında Leman isimli mizah dergisinde çalışmaya başladı. İlk gösterisini dergide çalıştığı yıllarda, " +
                            "Leman Kültür Merkezinde gerçekleştirdi. Sonrasında Beşiktaş Kültür Merkezinde sahne almaya başladı ve burada düzenlediği " +
                            "gösteriler ile adını duyurmayı başararak günümüze kadar toplamda 4.000'den fazla kez sahneye çıktı.",
                            OyuncuFotografi = "~/images/Oyuncular/cemyilmaz.jfif"
                        },
                        new Oyuncu()
                        {
                            OyuncuAdSoyad = "Zafer Algöz",
                            OyuncuHakkinda = "Dedesi besteci Kemani Haydar Telhüner'dir. 1975 sezonunda Bursa Devlet Tiyatroları Genel Müdürlüğünde açılan " +
                            "Gençlik Kursları ile tiyatro eğitimi alan sanatçı, 1981 yılında Ankara Devlet Konservatuvarı Tiyatro Bölümünü kazandı. " +
                            "1985 yılında mezun olup aynı yıl Bursa Devlet Tiyatrosu'nda sanat yaşamına başladı."+
                            "1989 yılında İstanbul Devlet Tiyatroları’na tayin olan Algöz, birçok oyunda rol aldı, dizi ve sinema filmleri çevirdi. " +
                            "İstanbul Devlet Tiyatroları'nda oyuncu olarak çalışmaktadır. Ayrıca League of Legends adlı MOBA oyununda " +
                            "Türkiye sunucusu açılışa özel Gangplank adlı şampiyonun Barbaros adlı kostümünü seslendirmiştir.",
                            OyuncuFotografi = "~/images/Oyuncular/zaferalgoz.jpg"
                        },
                        new Oyuncu()
                        {
                            OyuncuAdSoyad = "Ozan Güven",
                            OyuncuHakkinda = "1975 yılında Almanya'da doğan Ozan Güven, Mimar Sinan Üniversitesi İstanbul Devlet Konservatuvarı'nın modern " +
                            "dans bölümünden mezun oldu. İzmir Belediye Konservatuvarı'nda oyunculuk dersleri aldı ve ardından " +
                            "Şahika Tekand Tiyatrosu'nda çalıştı. İkinci Bahar, Çiçeği Büyütmek, Koçum Benim," +
                            " Aslı ile Kerem, Bir İstanbul Masalı, Canım Ailem, Koyu Kırmızı, Muhteşem Yüzyıl ve Fi gibi televizyon dizilerinde rol aldı." +
                            " G.O.R.A, A.R.O.G, Yahşi Batı, Arif V 216 ve Pek Yakında filmlerinde yakın arkadaşı olan Cem Yılmaz'la oynadı.",
                            OyuncuFotografi = "~/images/Oyuncular/ozanguven.jpg"
                        },
                         new Oyuncu()
                        {
                            OyuncuAdSoyad = "Farah Zeynep Abdullah",
                            OyuncuHakkinda = "Farah Zeynep, üniversiteye başlamaya hazırlanırken Öyle Bir Geçer Zaman Ki adlı dizi için teklif aldı. " +
                            "İngiltere'deki okuluna dönmesine üç gün kala," +
                            " deneme çekimlerinde başarılı bulunduğunu ve Aylin rolüne seçildiğini öğrendi. " +
                            "Bu dizide dört çocuklu bir ailenin ikinci çocuğu olan Aylin'i canlandırdı. Daha sonra Yılmaz Erdoğan'ın filmi " +
                            "Kelebeğin Rüyası'nda oynadı. Bu filmde başrolleri Kıvanç Tatlıtuğ ve Mert Fırat ile paylaştı. 2014 senesinde " +
                            "Star TV'de yayınlanan Kurt Seyit ve Şura adlı dizide başrol oynadı. Ardından 14 Şubat 2014'te Kerem Deren'in yönetmenliğini üstlendiği " +
                            "Bi Küçük Eylül Meselesi filminde Engin Akyürek ile başrolü paylaştı. Çağan Irmak'ın yönettiği, 2014 yılının en başarılı filmlerinden olan" +
                            " Unutursam Fısılda filminde Hümeyra'nın da oynadığı Hatice (Ayperi) karakterinin gençliğini canlandırdı.",
                            OyuncuFotografi = "~/images/Oyuncular/farahzeynep.jfif"
                        },
                          new Oyuncu()
                        {
                            OyuncuAdSoyad = "İsmail Hacıoğlu",
                            OyuncuHakkinda = "İsmail Hacıoğlu 30 Kasım 1985 yılında doğdu. Oyunculuğa ilkokul 5. sınıftayken piyeslerde oynayarak başlayan oyuncu," +
                            " eğitimini Müjdat Gezen Sanat Merkezi Tiyatro Bölümü'nde aldı. Ardından Mimar Sinan Üniversitesi, Devlet Konservatuarı Tiyatro Bölümü'nü kazanan oyuncu okulu ilk senesinde bıraktı." +
                            " Kariyerinin başlangıcından beni parlak bir çizgide ilerleyen Hacıoğlu, " +
                            "2003 yılında çekilen Karşılaşma filmindeki performansıyla 40. Antalya Altın Portakal Film Festivali Umut Veren Genç Oyuncu Ödülü kazandı.",
                            OyuncuFotografi = "~/images/Oyuncular/ismail.jpg"
                        },
                  
                           new Oyuncu()
                        {
                            OyuncuAdSoyad = "Şahan Gökbakar",
                            OyuncuHakkinda = "Şahan Gökbakar (d. 22 Ekim 1980, İzmir), Türk komedyen ve oyuncu; Recep İvedik film serisinin yapımcısı, senaristi ve oyuncusu. " +
                            "İlk rol aldığı film 2006 yapımı Gen, ilk başrol oynadığı filmi ise 2008 yapımı Recep İvedik'tir.",
                            OyuncuFotografi = "~/images/Oyuncular/sahan.jpg"
                        },
                            new Oyuncu()
                        {
                            OyuncuAdSoyad = "Öznür Serçeler",
                            OyuncuHakkinda = "Öznur Serçeler, 10 Ekim 1987'de Kayseri'de doğdu. Müzik eğitimine 2001 yılında Mersin Üniversitesi Konservatuvarında Turkol Çankaya ile başladı." +
                            " Ardından 2003 yılında Bilkent Üniversitesi Müzik ve Sahne Sanatları Fakültesi'nde müzik eğitimine devam etti. " +
                            "2007 yılında Dünya Gençlik Orkestrası projesine katıldı ve Berlin, Kasel ve Bodrum'da konserlere katıldı. 2007 yılında Öznur Serçeler Elite Model Look'a katıldı.",
                            OyuncuFotografi = "~/images/Oyuncular/oznurserceler.png"
                        }
                    });
                    context.SaveChanges();
                }

                if (!context.Yonetmenler.Any())
                {
                    context.Yonetmenler.AddRange(new List<Yonetmen>()
                    {
                    new Yonetmen()
                    {
                        YonetmenAdSoyad = "Nuri Bilge Ceylan",
                        YonetmenHakkinda = "Nuri Bilge Ceylan, Türk yönetmen, senarist ve fotoğrafçı. " +
                        "1998 yılından itibaren çektiği uzun metrajlı filmler ile birçok ödül kazanmış ve uluslararası alanda tanınmıştır. " +
                        "Kış Uykusu filmi 2014 Cannes Film Festivali'nde Altın Palmiye Ödülü kazanmış ve sinema tarihinde bu ödülü kazanan ikinci Türk filmi olmuştur.",
                        YonetmenFotografi = "~/images/Yonetmenler/nuribilge.jpg"

                    },

                    new Yonetmen()
                    {
                        YonetmenAdSoyad = "Can Ulkay",
                        YonetmenHakkinda = "Can Ulkay, Türk, film yönetmeni. 90. Akademi Ödülleri'nin Yabancı Dilde En İyi Film Ödülü" +
                        "kategorisinde yarışmak üzere Türkiye'nin aday adayı olarak seçilen Ayla filmi ile tanınmaktadır. ",
                        YonetmenFotografi = "~/images/Yonetmenler/canulkay.jpeg"

                    },
                      new Yonetmen()
                    {
                        YonetmenAdSoyad = "Cem Yılmaz",
                        YonetmenHakkinda = "23 Nisan 1973 tarihinde İstanbul'da doğdu. Aslen Gürün, Sivaslıdır. " +
                            "İlköğrenimini Mehmet Âkif İlkokulunda tamamladı. Ortaokulda Bahçelievler Kâzım Karabekir Ortaokulunu, " +
                            "sonrasında da Etiler Anadolu Otelcilik ve Turizm Meslek Lisesi ve Boğaziçi Üniversitesi Turizm İşletmeciliği Bölümünü bitirdi."+
                            "Karikatüre olan ilgisi ve yeteneği sayesinde üniversite yıllarında Leman isimli mizah dergisinde çalışmaya başladı. İlk gösterisini dergide çalıştığı yıllarda, " +
                            "Leman Kültür Merkezinde gerçekleştirdi. Sonrasında Beşiktaş Kültür Merkezinde sahne almaya başladı ve burada düzenlediği " +
                            "gösteriler ile adını duyurmayı başararak günümüze kadar toplamda 4.000'den fazla kez sahneye çıktı.",
                            YonetmenFotografi = "~/images/Oyuncular/cemyilmaz.jfif"


                    },
                    new Yonetmen()
                    {
                        YonetmenAdSoyad = "Mehmet Binay",
                        YonetmenHakkinda = "31 Ekim 1972, İstanbul doğumlu. 16 yıl önce master öğrencisiyken ilerideki kariyerime dair adımlar atıyor," +
                        " seyahat edip bazı yerlerde kalıp dil öğreniyordum. İnternette oluşturulan ilk Türkçe elektronik dergi için ve farklı yerlerde yazıyordum." +
                        " Düşünselliğin ağır bastığı bir dönemdeydim. Üniversitedeyken fotoğraf çekmeye başlamıştım, sonrasında NTV’de televizyon haberciliğini öğrendim. ",
                        YonetmenFotografi = "~/images/Yonetmenler/mehmet.jpg"

                    },

                    new Yonetmen()
                    {
                        YonetmenAdSoyad = "Togan Gökbakar",
                        YonetmenHakkinda = "Togan Gökbakar, Türk sinema film yönetmeni ve senaristi.",
                        YonetmenFotografi = "~/images/Yonetmenler/togan.jpeg"

                    },


                    });
                    context.SaveChanges();
                }

                if (!context.Filmler.Any())
                {
                    context.Filmler.AddRange(new List<Film>()
                    {
                        new Film()
                        {
                            FilmAdi = "Ayla",
                            FilmHakkinda = "Gerçek olaylardan esinlenilen bu yürek sızlatan drama, savaşın ortasında Koreli bir yetimi kurtarıp onunla bağ kuran bir astsubayın hikâyesini anlatıyor.",
                            FilmUcreti = 25,
                            FilmFotografi = "~/images/Filmler/ayla.jpg",
                            FilmBaslamaSaati1 = "19:30",
                            FilmBaslamaSaati2 = "21:45",
                            FilmBaslamaSaati3="23:00",
                            SinemaId = 1,
                            YonetmenId = 2,
                            FilmKategorisi = FilmKategorisi.Dram
                            
                        },

                        new Film()
                        {
                                
                            FilmAdi = "Bergen",
                            FilmHakkinda = "Türk arabesk şarkıcısı Bergen, hayatındaki tüm zorluklara rağmen ayakta kalma mücadelesi vermektedir." +
                            "Acıların Kadını lakaplı ünlü arabesk sanatçısı Bergen’in hayatının anlatıldığı bu filmde Bergen'e Farah Zeynep Abdullah hayat veriyor.",
                            FilmUcreti = 19,
                            FilmFotografi = "~/images/Filmler/bergen.jpeg",
                            FilmBaslamaSaati1 = "09:15",
                            FilmBaslamaSaati2 = "12:30",
                            FilmBaslamaSaati3="15:00",
                            SinemaId = 2,
                            YonetmenId = 4,
                            FilmKategorisi = FilmKategorisi.Dram
                        },
                        new Film()
                        {
                         
                            FilmAdi = "Recep İvedik 7",
                            FilmHakkinda = " Hayat şartlarının zorluğu ve şehrin gürültüsünden bunalan Recep, " +
                            "Nurullah’ı da yanına alarak babaannesinden miras kalan köy evine gider.",
                            FilmUcreti = 30,
                            FilmFotografi = "~/images/Filmler/Recepİvedik7.jpg",
                            FilmBaslamaSaati1 = "20:30",
                            FilmBaslamaSaati2 = "21:45",
                            FilmBaslamaSaati3="23:15",
                            SinemaId = 5,
                            YonetmenId = 5,
                            FilmKategorisi = FilmKategorisi.Komedi
                            
                        },

                        new Film()
                        {
                            FilmAdi = "Yahşi Batı",
                            FilmHakkinda = "Yahşi Batı, Ömer Faruk Sorak'ın yönetmenliğini," +
                            " Cem Yılmaz'ın ise senaristliğini ve başrolünü üstlendiği, 2009 yılı yapımı bir Türk komedi-western filmidir. Filmde Cem Yılmaz, " +
                            "1881 yılında ABD başkanına Padişah'ın hediyesini vermek üzere gönderilen Teşkilat-ı Mahsusa üyesi ajan Aziz Vefa'yı canlandırmıştır. ",
                            FilmUcreti = 27,
                            FilmFotografi = "~/images/Filmler/yahsibati.jpg",
                            FilmBaslamaSaati1 = "15:45",
                            FilmBaslamaSaati2 = "18:00",
                            FilmBaslamaSaati3="21:15",
                            SinemaId = 4,
                            YonetmenId = 3,
                            FilmKategorisi = FilmKategorisi.Aksiyon
                           
                        },

                        new Film()
                        {
                            FilmAdi = "Arifv216",
                            FilmHakkinda = "Cem Yılmaz'ın senaryosunu kaleme alıp başrolünde yer aldığı Arif v 216, G.O.R.A filmiyle tanıştığımız" +
                            " Arif ve Robot 216 karakterlerini yeniden bir araya getiriyor.",
                            FilmUcreti = 30,
                            FilmFotografi = "~/images/Filmler/arifv216.jpg",
                            FilmBaslamaSaati1 = "12:00",
                            FilmBaslamaSaati2 = "15:30",
                            FilmBaslamaSaati3="17:45",
                            SinemaId = 2,
                            YonetmenId = 3,
                            FilmKategorisi = FilmKategorisi.Komedi
                         
                        },

                         new Film() 
                        {
                            FilmAdi = "Kış Uykusu",
                            FilmHakkinda = " Kış Uykusu filmi, eski bir tiyatro oyuncusu olan Aydın'ın, Anadolu bozkırlarının ortasında, " +
                            "adeta bir kış uykusuna yatmış gibi görünen ıssız bir mekanda, kendisiyle, hayalleriyle, sevdikleri ve taşrayla kurduğu " +
                            "ve düşe kalka sürdürmeye çalıştığı ilişkilerini konu alıyor.",
                            FilmUcreti = 35,
                            FilmFotografi = "~/images/Filmler/kisuykusu.jpg",
                            FilmBaslamaSaati1 = "10:30",
                            FilmBaslamaSaati2 = "14:15",
                            FilmBaslamaSaati3="16:00",
                            SinemaId = 3,
                            YonetmenId = 1,
                            FilmKategorisi = FilmKategorisi.Dram
                        },

                    });
                    context.SaveChanges();
                }
              

                if (!context.FilmlerOyuncular.Any())
                {
                    context.FilmlerOyuncular.AddRange(new List<FilmOyuncu>()
                    {
                        new FilmOyuncu()
                        {
                            FilmId = 1,
                            OyuncuId = 8
                        },

                        new FilmOyuncu()
                        {
                            FilmId = 2,
                            OyuncuId = 7
                        },

                        new FilmOyuncu()
                        {
                            FilmId = 2,
                            OyuncuId = 1
                        },

                        new FilmOyuncu()
                        {
                            FilmId = 3,
                            OyuncuId = 9
                        },

                        new FilmOyuncu()
                        {
                            FilmId = 3,
                            OyuncuId = 10
                        },

                        new FilmOyuncu()
                        {
                            FilmId = 4,
                            OyuncuId = 5
                        },
                        new FilmOyuncu()
                        {
                            FilmId = 4,
                            OyuncuId = 4
                        },
                        new FilmOyuncu()
                        {
                            FilmId = 4,
                            OyuncuId = 6
                        },
                           new FilmOyuncu()
                        {
                            FilmId = 5,
                            OyuncuId = 5
                        },
                        new FilmOyuncu()
                        {
                            FilmId = 5,
                            OyuncuId = 4
                        },
                        new FilmOyuncu()
                        {
                            FilmId = 5,
                            OyuncuId = 6
                        },
                         new FilmOyuncu()
                        {
                            FilmId = 6,
                            OyuncuId = 2
                        },
                            new FilmOyuncu()
                        {
                            FilmId = 6,
                            OyuncuId = 3
                        },

                    });
                    context.SaveChanges();
                }
            }            
        }
    
        public static async Task KullaniciVeRolEkle(IApplicationBuilder ab)
        {
            using(var scope = ab.ApplicationServices.CreateScope())
            {
                var rm = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
                if(!await rm.RoleExistsAsync(Roller.Admin))
                {
                    await rm.CreateAsync(new IdentityRole(Roller.Admin));
                }
                if (!await rm.RoleExistsAsync(Roller.Kullanici))
                {
                    await rm.CreateAsync(new IdentityRole(Roller.Kullanici));
                }


                var um = scope.ServiceProvider.GetRequiredService<UserManager<Kullanici>>();
                var admin = await um.FindByEmailAsync("g201210382@sakarya.edu.tr");
                if (admin == null)
                {
                    var adminOlustur = new Kullanici()
                    {
                        AdSoyad = "Admin",
                        UserName = "admin",
                        Email = "g201210382@sakarya.edu.tr",
                        EmailConfirmed = true                   
                    };
                    await um.CreateAsync(adminOlustur, "sau");
                    await um.AddToRoleAsync(adminOlustur, Roller.Admin);
                }

                var kullanici = await um.FindByEmailAsync("g181210382@sakarya.edu.tr");
                if (kullanici == null)
                {
                    var kullaniciOlustur = new Kullanici()
                    {
                        AdSoyad = "Hakan Yilmaz",
                        UserName = "hakanyilmaz",
                        Email = "g181210382@sakarya.edu.tr",
                        EmailConfirmed = true
                    };
                    await um.CreateAsync(kullaniciOlustur, "sau");
                    await um.AddToRoleAsync(kullaniciOlustur, Roller.Kullanici);
                }
            }
        }
    }
}
