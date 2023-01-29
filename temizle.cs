using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class temizle : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D temas){

		float rastgeleX=Random.Range(-5f,5f);
		float rastgeleY=15f;

		if(temas.tag =="platform"){
			temas.transform.position=new Vector3(rastgeleX,temas.transform.position.y+rastgeleY,temas.transform.position.z);//SONSUZLUK KODU

		}
	}
}
