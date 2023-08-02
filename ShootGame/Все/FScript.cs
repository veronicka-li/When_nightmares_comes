using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FScript : MonoBehaviour
{
    public GameObject btn;
    // Start is called before the first frame update
    void Start()
    {
        btn.SetActive(false);   
    }

    void foo() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
