using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ind : MonoBehaviour
{
public GameObject hero;
public Text _tex;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Indicators _ind = hero.GetComponent<Indicators>();
	_tex.text = "Здоровье:" + _ind.Health.ToString() + "%\r\n" + "Сытость:"+_ind.Food.ToString() + "%\r\n" + "Жажда:" + _ind.Food.ToString() + "%\r\n" + "Сон:" + _ind.Sleep.ToString() + "%\r\n" + "Деньги:" + _ind.Money.ToString() + "$";
    }
}
