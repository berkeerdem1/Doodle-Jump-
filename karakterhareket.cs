using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class karakterhareket : MonoBehaviour
{
	public float hiz;
	public Rigidbody2D doodle;
	private float hareketInput;
	public TextMeshProUGUI skoryazi;
	int skor;

	Rigidbody2D rb;

	bool faceRight=true;

	
    void Update()
    {
		skoryazi.text="skor:"+skor;

		hareketInput=Input.GetAxis ("Horizontal");//Yatayda hareket için
		doodle.velocity = new Vector2(hiz*hareketInput,doodle.velocity.y);

    }
	void OnCollisionEnter2D(Collision2D temas){
		if(temas.gameObject.tag=="bitis"){
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		
		}
		if(temas.gameObject.tag == "platform"){
			skor += 10;
		}
	}
	private void FixedUpdate(){
		rb=GetComponent<Rigidbody2D>();

		float moveInput=Input.GetAxis("Horizontal");
		rb.velocity=new Vector2(moveInput * hiz,rb.velocity.y);
		
	
		
		
		if(faceRight==true && moveInput<0){ //ÖNEMLi
			Flip ();
		}
		else if(faceRight==false && moveInput>0){
			Flip ();
		}

	}
	private void Flip(){  //KARAKTERi X EKSENiNDE TERS YÖNE DÖNDÜRME
		faceRight=!faceRight;
		Vector3 scaler=transform.localScale;
		scaler.x*=-1;
		transform.localScale=scaler;
	}
}
