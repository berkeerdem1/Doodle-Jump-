using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seviye : MonoBehaviour
{
	public GameObject platformObjesi;
	public int platformSayisi;
	public float minX,maxX;
	public float minY,maxY;


    void Start()
    {
		Vector3 klonpozisyonu=new Vector3();
		for(int i=0;i<platformSayisi;i++){

			klonpozisyonu.x=Random.Range(minX,maxX);
			klonpozisyonu.x=Random.Range(minY,maxY);
			Instantiate (platformObjesi,klonpozisyonu,Quaternion.identity);//klonlama kodu:klonlanacak obje,pozisyonu,açısı		}
    	}

   
	}
}
