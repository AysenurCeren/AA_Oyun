using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class oyunsonu : MonoBehaviour
{
	public GameObject B�y�kcember;
	public GameObject yeniler;


   public void bitir()
   {
	   B�y�kcember.GetComponent<buyukcember>().enabled = false;//buyukcembere scriptine eri�erek kapat
		yeniler.GetComponent<yenicubukspam>().enabled = false;
		
	}
}
