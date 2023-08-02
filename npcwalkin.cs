using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npcwalkin : MonoBehaviour
{
private bool goin;
public float timer;
private CharacterController chcon;
public float speedMove;
private float _const;

    // Start is called before the first frame update
    void Start()
    {
        _const=timer;
chcon=GetComponent<CharacterController>();

    }

    // Update is called once per frame
    void Update()
    {
timer-=Time.deltaTime;
if (timer<0)
{
if (goin) goin=false;
else goin=true;
timer=_const;
}
if (goin)
{
        Vector3 moveVector = Vector3.forward*speedMove;
	Vector3 direct = Vector3.RotateTowards(transform.forward,moveVector,speedMove,0.0f);
   transform.rotation = Quaternion.LookRotation(direct); 
chcon.Move(moveVector*Time.deltaTime);
}
else
{
Vector3 moveVector = -1.0f * Vector3.forward*speedMove;
	Vector3 direct = Vector3.RotateTowards(transform.forward,moveVector,speedMove,0.0f);
   transform.rotation = Quaternion.LookRotation(direct); 
chcon.Move(moveVector*Time.deltaTime);
}


}
}
