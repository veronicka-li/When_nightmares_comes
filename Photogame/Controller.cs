using System.Collections;
using UnityEngine.UI;
using UnityEngine;
using System;


public class Controller : MonoBehaviour
{
	private float _count;
	private bool End;
	public GameObject Person;
	public	GameObject _camera;
    public Text _text;
    public float speed = 5.0f;
    private float x, y ;
    private AudioSource audiod;
	public KeyCode F;


    private void Start()
    {
      
        audiod = GetComponent<AudioSource>();
End = false;
    }
    // Update is called once per frame
    void Update()
    {

if (!End){
        float transV = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        float transH = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
	//Debug.Log("a");
        transform.Translate(new Vector3(transH, transV, 0));

       

	Vector3 vec = _camera.transform.position;
	//Debug.Log(transform.position.x-Person.transform.position.x);


        if (Math.Abs(transform.position.x-Person.transform.position.x)< 10.0f && Math.Abs(transform.position.y-Person.transform.position.y)< 10.0f)
        {
		//Debug.Log("f");
            _text.enabled = true;
            if (Input.GetKeyDown(F))
            {
		_count++;
                    _text.text = "Нажмите F  Снимков: " + _count.ToString();
                audiod.Play();
            }

        }
      else  _text.enabled = false;

if (_count>=5.0f)
	End = true;
        

}


    }
}
