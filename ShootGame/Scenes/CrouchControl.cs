using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrouchControl : MonoBehaviour
{

    // Start is called before the first frame update
    void Start() {
    }
    // Update is called once per frame
    void Update() {
            if (Input.GetKeyDown(KeyCode.Space))
                transform.Translate(0, -0.6f, 0);
            if (Input.GetKeyUp(KeyCode.Space))
                transform.Translate(0, 0.6f, 0);
        }
}
