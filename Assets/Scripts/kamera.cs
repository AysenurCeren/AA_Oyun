using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kamera : MonoBehaviour
{ 
    Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if(cubuk.bitti == true)
        {
            animator.SetBool("oyunbitti", true);//parametre ayarý
        }
    }
}
