using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class videoPorCodigo : MonoBehaviour
{
    public GameObject boton;
    public VideoPlayer video1;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


    }

    public void  reproduce(){
        video1.Play();
        boton.gameObject.SetActive(false);
    }
}
