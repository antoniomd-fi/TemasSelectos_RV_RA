using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{ 
    private int timeBegin=1;
    private float speed;
    private Text text;
    private float timeFrame = 0f;
    private float timeView=150;
    void Start()
    {
        text = GetComponent<Text>();
    }


    void Update()
    {
        timeFrame = Time.deltaTime;
        timeView -= timeFrame;
        ActualizarReloj(timeView);
    }

    public void ActualizarReloj( float time)
    {
        int minutos = 0;
        int segundos = 0;
        string texto;

        minutos = (int) timeView / 60;
        segundos = (int) timeView % 60;

        texto = minutos.ToString("00") + ":" + segundos.ToString("00");
        text.text = texto;

        if (minutos==0 && segundos==0)
        {
            SceneManager.LoadScene("Laberinto");
        }
        
    
    }
    
    public voud restartTime(){
    
    }

  
}
