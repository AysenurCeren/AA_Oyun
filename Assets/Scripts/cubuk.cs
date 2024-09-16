using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubuk : MonoBehaviour
{
    Rigidbody2D rb;
    public float h�z;
    public bool hareketk�s�tl�;
    public GameObject Yonetici;
    public static bool bitti;
    private skor skorScript; // skor scriptine eri�mek i�in referans


    void Start()
    {
        //prefab oldu�u i�in k���k �ember tag etiketi ile atama olmad� kodla yap�ld�.
        Yonetici = GameObject.FindGameObjectWithTag("y�netici");//y�netici etiketine sahip objeye e�le
        
        rb = GetComponent<Rigidbody2D>();  //koddaki Rigidbody'i k���k �emberinkine e�itlemek i�in.

        skorScript = FindObjectOfType<skor>(); // skor scriptine referans� atar

    }

    void Update()
    {
        //hareket ediyorsa 
       if(hareketk�s�tl� == false)
        {
            rb.MovePosition(rb.position+Vector2.up*h�z*Time.deltaTime); //rb'nin hareket etmesini sa�lar. up= y'nin 1 artmas�n� sa�lar devaml�   
        }
    }
    
    void OnTriggerEnter2D(Collider2D col)
    {
        //b�y�k �embere temas ederse �ubuk durucak
        if(col.gameObject.tag =="BuyukCember")
        {
            transform.SetParent(col.transform);//temas edilen objenin child objesi olur
            hareketk�s�tl� = true;
            if (skorScript != null)
            {
                skorScript.IncreaseScore(1); // Skoru 1 art�r
            }
           



        }

        if(col.gameObject.tag == "kucukcember")
        {
            Yonetici.GetComponent<oyunsonu>().bitir();//y�netici objectinden oyunsonu scriptindeki bitir fonk. eri�im
            bitti = true;

        }
       
    }
}
