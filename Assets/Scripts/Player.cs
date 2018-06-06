using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public float speed = 0.7f;
    public float rotSpeed = 100;
    public float jumpSpeed = 300;
    GameController gameController;

    // Use this for initialization
    void Start ()
    {
        gameController = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();

    }
	
	// Update is called once per frame
	void Update ()
    {
        
        
            float movX = Input.GetAxis("Horizontal") * speed * Time.deltaTime; // получить ось с предусмотреннами за это клавишами
            float movZ = Input.GetAxis("Vertical") * speed * Time.deltaTime;
            float rotY = Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime;
        float movY = 0;

        if (Input.GetButtonDown("Jump"))
        {
            movY = jumpSpeed * Time.deltaTime;
        }

        transform.Translate(0, movY, movZ); // перемещение объекта ( управоление колавишами )
            transform.Rotate(0, rotY, 0); // поворот игрока
        
        
	}

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Enemy") // папроверяем объект столкновения на соответствие (если предмет коснулся объект с тегом Emeny)
        {
            Debug.Log("You die");
            GetComponent<Renderer>().material.color = Color.red; // меняет цвет объекта
            //Time.timeScale = 0; // останавливает время
            gameController.Lose();
            enabled = false;
        }

     
    }

     void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Finish") // папроверяем объект столкновения на соответствие (если предмет коснулся объект с тегом Emeny)
        {
          
           // Time.timeScale = 0; // останавливает время
            gameController.Win();
            enabled = false;
        }
    }
}
