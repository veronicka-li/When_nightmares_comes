using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthControl : MonoBehaviour
{
    public int plrHealth;
    private int qEnemy;
    public GameObject personaj;
    // Start is called before the first frame update
    void Start()
    {
        qEnemy = 2;
    }

    void Update() {
        if (qEnemy == 0) {
            Application.Quit();
        }
    }

    // Update is called once per frame
    void getDamage() {
        if (plrHealth <= 0) {
            if (transform.parent.gameObject.name == "Player") {
                Application.Quit();
            }
            else qEnemy--;
            Destroy(transform.parent.gameObject);
            personaj.SetActive(false);
        }
        else plrHealth--;
        print("hit");
    }
    
}
