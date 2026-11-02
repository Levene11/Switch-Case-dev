using UnityEngine;

public class OtoparkSistemi : MonoBehaviour
{ [SerializeField] private int parkSuresi = 5;
    void Start()
    {

        switch (parkSuresi)
        {
            case 0:
                Debug.Log("Geçersiz Süre");
                break;

            case 1:
                Debug.Log("Otoparkta Kalınan süre: 1 saat");
                Debug.Log("Otopark Ücreti = 120 TL");
                break;

            case 2:
                Debug.Log("Otoparkta Kalınan süre: 2 saat");
                Debug.Log("Otopark Ücreti = 200 TL");
                break;

            case 3:
                Debug.Log("Otoparkta Kalınan süre: 3 saat");
                Debug.Log("Otopark Ücreti = 300 TL");
                break;

            case 4:
                Debug.Log("Otoparkta Kalınan süre: 4 saat");
                Debug.Log("Otopark Ücreti = 400 TL");
                break;

            default:
                Debug.Log("Otoparkta Kalınan süre: 5 saat ve üzeri");
                Debug.Log("Otopark Ücreti = 550 TL");
                break;
        }
    }
}
//Ee hocam.. Açıkcası ne desem.. Çoğu ders ee Sanki siz tahtada kitap okuyormuşsunuz gibi hissettiriyor.
//Siz tahtada kitap okuyorsunuz sınıfta bazıları cümle okumayı bazıları hatta kurmayı biliyor ama
//...ben çoğu zaman Alfabeyi daha yeni öğrenmiş bir çocuk gibi hissediyorum. O yüzden evet anlıyorum ama.. daha geç geliyorum.
//Evde tekrar yapıyorum verdiğiniz İsimlerden Bracekeysle başlamıştım hatta bi küp level oyunu yaptım :D
//Onda deniyorum.. Eğleniyorum yalan yok.. Ama coğu zaman geç kalmışım gibi hissediyorum..Elimden gelenin daha fazlasını yapmam gerekiyormuş gibi.
//O yüzden dediğim gibide elimden gelenin daha fazlasını yapmak için çabalayacağım. Niye yazdım bende bilmiyorum ama söylemek istedim. Boş konuşmuş olduysam Özür dilerim.
