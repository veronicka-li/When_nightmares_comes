using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{

    public int speed;
    Vector3 LastPos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, 5);
        transform.Translate(Vector3.forward*speed*Time.deltaTime);
        RaycastHit hit;
        if (Physics.Linecast(LastPos, transform.position, out hit)) {
            if (hit.transform.gameObject.name == "Body") {
                hit.transform.gameObject.SendMessage("getDamage");
            }
            Destroy(gameObject);
            print(hit.transform.name);
        }
        LastPos = transform.position;
    }

    void OnCollisionEnter(Collision k) {
        Destroy(gameObject);
        Destroy(k.transform.gameObject);
    }
}
