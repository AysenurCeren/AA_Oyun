using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubuk : MonoBehaviour
{
    Rigidbody2D rb;
    public float hýz;
    public bool hareketkýsýtlý;
    public GameObject Yonetici;
    public static bool bitti;
    private skor skorScript; // skor scriptine eriþmek için referans


    void Start()
    {
        //prefab olduðu için küçük çember tag etiketi ile atama olmadý kodla yapýldý.
        Yonetici = GameObject.FindGameObjectWithTag("yönetici");//yönetici etiketine sahip objeye eþle
        
        rb = GetComponent<Rigidbody2D>();  //koddaki Rigidbody'i küçük çemberinkine eþitlemek için.

        skorScript = FindObjectOfType<skor>(); // skor scriptine referansý atar

    }

    void Update()
    {
        //hareket ediyorsa 
       if(hareketkýsýtlý == false)
        {
            rb.MovePosition(rb.position+Vector2.up*hýz*Time.deltaTime); //rb'nin hareket etmesini saðlar. up= y'nin 1 artmasýný saðlar devamlý   
        }
    }
    
    void OnTriggerEnter2D(Collider2D col)
    {
        //büyük çembere temas ederse çubuk durucak
        if(col.gameObject.tag =="BuyukCember")
        {
            transform.SetParent(col.transform);//temas edilen objenin child objesi olur
            hareketkýsýtlý = true;
            if (skorScript != null)
            {
                skorScript.IncreaseScore(1); // Skoru 1 artýr
            }
           



        }

        if(col.gameObject.tag == "kucukcember")
        {
            Yonetici.GetComponent<oyunsonu>().bitir();//yönetici objectinden oyunsonu scriptindeki bitir fonk. eriþim
            bitti = true;

        }
       
    }
}
