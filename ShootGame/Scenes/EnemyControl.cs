using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : MonoBehaviour
{
    public Transform bulletPref;
    public Transform Pivot;
    public int health;
    public float value = 100;
    public float speed = 5;
    private bool isShoot;
    // Start is called before the first frame update
    void Start()
    {
        health = 10;
        isShoot = true;
        StartCoroutine(EnBehavior());
    }

    IEnumerator EnBehavior() {

        float tmp = Random.Range(1, 3);
        takeCover(tmp);
        yield return new WaitForSeconds(tmp);

        while (health > 0) {
            if (isShoot) {
                int qS = Random.Range(3, 10);
                float waitTime = 0.4f;
                StartCoroutine(shoot(qS, waitTime));
                isShoot = false;
                yield return new WaitForSeconds(qS * waitTime);
            }
            else {
                float waitTime = Random.Range(3, 7);
                StartCoroutine(takeCover(waitTime));
                isShoot = true;
                yield return new WaitForSeconds(waitTime);
            }
        }
    }


    IEnumerator shoot(int qS, float waitTime) {
        
        for(int i = 0; i < qS; i++) {
            Instantiate(bulletPref, Pivot.position, Pivot.rotation);
            yield return new WaitForSeconds(waitTime);
        }
        isShoot = false;
    }

    IEnumerator takeCover(float waitTime) {
        gameObject.transform.Translate(0, -0.6f, 0);
        yield return new WaitForSeconds(waitTime);
        gameObject.transform.Translate(0, 0.6f, 0);
        isShoot = true;
    }
}
