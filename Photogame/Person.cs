using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Person : MonoBehaviour
{
private bool justBool;
private Vector3 firstPoint;
private Vector3 secondPoint;
public GameObject fCanvas;
private float _time;
public float Step;
public float Stand;

    // Start is called before the first frame update
    void Start()
    {
	firstPoint = new Vector3(58.0f,78.0f,0.0f);
	secondPoint = new Vector3(310.0f,104.0f,0.0f);
	firstPoint+=fCanvas.transform.position;
	secondPoint+=fCanvas.transform.position;
        justBool= true;//
	_time = 0;
	//Debug.Log(transform.position.x);
    }

    // Update is called once per frame
    void Update()
    {
        if (justBool)//Есле жастбул тру, то силует движется из точки а в точку б, если нет из точки б в точку а
{
	
	transform.position = Vector3.MoveTowards(transform.position, secondPoint, 0.5f);// скорость
	if (transform.position == secondPoint)
		_time+=Step*Time.deltaTime;
if (_time>Stand)
{
	justBool = false;
_time=0.0f;
}
}
else 
{
transform.position = Vector3.MoveTowards(transform.position, firstPoint, 0.5f);
	if (transform.position == firstPoint)
{
		_time+=Step*Time.deltaTime;
if (_time>Stand)
	{
	justBool = true;
_time=0.0f;
}
}


}
    }
}
