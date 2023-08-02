using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newGameScript : MonoBehaviour
{
    public GameObject btn;

    void OnDestroy() {
        btn.SetActive(true);
    }
}
