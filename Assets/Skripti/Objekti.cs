using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objekti : MonoBehaviour
{
    //GameObject, kas uzglabā visus velkamos objektus
    public GameObject atkritumuMasina;
    public GameObject atroMasina;
    public GameObject autobuss;
    public GameObject b2;
    public GameObject CementaMasina;
    public GameObject Policija;
    public GameObject e46;
    public GameObject Traktors1;
    public GameObject Traktors5;
    public GameObject UgunsDzeseji;
    public GameObject Eskavators;
    /*Uzglabās velkamo objektu sākotnējās pozīcijas
    koordinātas (lai zinātu, kur aizmest objektu, ja tas nolikts nepareizajā vietā)*/
    //Objekti paliek Public, taču paslēpj no Inspector loga
    [HideInInspector]
    public Vector2 atkrKoord;
    [HideInInspector]
    public Vector2 atroKoord;
    [HideInInspector]
    public Vector2 bussKoord;
    [HideInInspector]
    public Vector2 b2Koord;
    [HideInInspector]
    public Vector2 Trak1Koord;
    [HideInInspector]
    public Vector2 Trak5Koord;
    [HideInInspector]
    public Vector2 PolicijaKoord;
    [HideInInspector]
    public Vector2 e46Koord;
    [HideInInspector]
    public Vector2 UgunsKoord;
    [HideInInspector]
    public Vector2 cementKoord;
    [HideInInspector]
    public Vector2 eskvKoord;
    //Uzglabās ainā esošo kanvu
    public Canvas kanva;
    //Uzglabās skaņas avotu, kurā atskaņot audio failu
    public AudioSource skanasAvots;
    //Masīvs, kas uzglabās visas skaņas
    public AudioClip[] skanaKoAtskanot;
    //Uzglabās objektu, kurš ir pēdējais pārvietotais
    [HideInInspector]
    public GameObject pedejaisVilktais = null;
    //Mainīgais atbild par to vai objekts ir nolikts pareizi vai nepareizi
    [HideInInspector]
    public bool vaiIstajaVieta = false;

    //Funkcija nostrādā tiklīdz nospiesta play poga
    private void Awake()
    {
        atkrKoord = atkritumuMasina.GetComponent<RectTransform>().localPosition;
        atroKoord = atroMasina.GetComponent<RectTransform>().localPosition;
        bussKoord = autobuss.GetComponent<RectTransform>().localPosition;
        b2Koord = b2.GetComponent<RectTransform>().localPosition;
        cementKoord = CementaMasina.GetComponent<RectTransform>().localPosition;
        PolicijaKoord = Policija.GetComponent<RectTransform>().localPosition;
       e46Koord = e46.GetComponent<RectTransform>().localPosition;
        Trak1Koord = Traktors1.GetComponent<RectTransform>().localPosition;
        Trak5Koord = Traktors5.GetComponent<RectTransform>().localPosition;
       UgunsKoord = UgunsDzeseji.GetComponent<RectTransform>().localPosition;
        eskvKoord = Eskavators.GetComponent<RectTransform>().localPosition;
    }
}
