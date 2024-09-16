using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class oyunsonu : MonoBehaviour
{
	public GameObject Büyükcember;
	public GameObject yeniler;


   public void bitir()
   {
	   Büyükcember.GetComponent<buyukcember>().enabled = false;//buyukcembere scriptine eriþerek kapat
		yeniler.GetComponent<yenicubukspam>().enabled = false;
		
	}
}
