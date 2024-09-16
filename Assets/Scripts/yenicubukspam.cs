using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yenicubukspam : MonoBehaviour
{
    public GameObject kucukcubuk;


    void Update()
    {
      if(Input.GetMouseButtonDown(0))//sol týk basýlýnca 
      {
          kucukcubukspam();
      }  
    }
    void kucukcubukspam()
    {
        Instantiate(kucukcubuk,transform.position,transform.rotation);//spam kodu
    }
}
