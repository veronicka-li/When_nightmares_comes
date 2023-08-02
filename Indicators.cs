using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Indicators : MonoBehaviour {

public float Health;
public float Food;
public float Jajda;
public float Money;
public float Sleep;
private CharacterController chcon;
public MaleMovement mm;

	private Animator animat;
	// Use this for initialization
	void Start () {
		Health = 100.0f;
		Food = 100.0f;
		Jajda=100.0f;
		Sleep = 100.0f;

	chcon = GetComponent<CharacterController>();
	animat = GetComponent<Animator>();
	
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Jajda >=100.0f)
Jajda = 100.0f;
if(Sleep>=100.0f)
Sleep=100.0f;
if(Food>=100.0f)
Food=100.0f;
if(Health>=100.0f)
Health=100.0f;
	if (Jajda<0.0f || Food<0.0f)
	{
		Health = -1.0f;
	}

	if (Health<0.0f)
	{
		animat.SetBool("isDead",true);
		mm.speedMove = 0.0f;
	}
	

	}
}
