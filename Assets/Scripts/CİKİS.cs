using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CİKİS : MonoBehaviour
{
    public GameObject cikispanel;//panel tanımı

    void Start()
    {
        cikispanel.SetActive(false);
    }

    public void cikis(int deger)
    {
        if (deger == 1)
        {
            cikispanel.SetActive(true);//panel görünüm ayarı
        }
        else if (deger == 0)
        {
            cikispanel.SetActive(false);
        }
        else if (deger == -1)
        {
            Application.Quit();
        }
    }
}
