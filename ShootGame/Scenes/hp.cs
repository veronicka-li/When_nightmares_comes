using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hp : MonoBehaviour
{
    public GameObject a;
    public Text b;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        healthControl hc = a.GetComponent<healthControl>();
        b.text = "Жизней: " + hc.plrHealth.ToString();

    }
}