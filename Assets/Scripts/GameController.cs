using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameController : MonoBehaviour
{
    public Text endText;
    public Text WinText;


    public void Lose()
    {
        endText.text = "Ты проиграл!";
        endText.color = Color.red;
        //SceneManager.LoadScene(0);
        // SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        // Time.timeScale = 1;
        StartCoroutine(Restart()); // Запускает сопрограмму рестарт
    } 
	

    public void Win()
    {
        endText.text = "Ты победил!";
        endText.color = new Color(0, 1, 0);
        StartCoroutine(Restart()); // Запускает сопрограмму рестарт
    }

    IEnumerator Restart()
    {
       
        yield return new WaitForSeconds(1); // ждёт 3 секунды
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // перезакгружает уровекнь
    }
   
}
