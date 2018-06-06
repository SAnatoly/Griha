using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moove : MonoBehaviour {

    public float speed = 0.5f;
    public float distance = 8;
	void Start ()
    {
        Debug.Log(speed); // выводит в консоль надпись speed

	}
	
	
	void Update ()
    {
        if (transform.position.x >= distance || transform.position.x <= -distance) // финкция с функцией если if и ||(или)
        {
            speed = -speed;
        }
       /* else
        {
            transform.Translate(speed, 0, 0); // объект остановится если он выпоолнил действие
        }8*/
        //transform.Translate(3, 0, 0); // передвиает объект на определённое растояние
        transform.Translate(speed * Time.deltaTime, 0, 0); // передвиает объект на определённое растояние
    
    }
}
