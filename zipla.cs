using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zipla : MonoBehaviour
{
	public  float ziplamagucu;
	private Vector2 karakterhizi;
	private Rigidbody2D fizik;

	void OnCollisionEnter2D(Collision2D temas){//obje başka objeyle temasa geçtiğinde

		if(temas.relativeVelocity.y<=0){//bağıl  hız
		fizik=temas.collider.GetComponent<Rigidbody2D>();//temas ettiği collidere ulaş oradan da rigidbody2d'ye ulaş  ve bunu fiziğe ata

		if(fizik!=null){//fizikde rigidbody var ise;
			karakterhizi=fizik.velocity;//değerleri istenilen değerlere ata
			karakterhizi.y=ziplamagucu; //""
			fizik.velocity=karakterhizi;//""
			}
		}
	}
}
