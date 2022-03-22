using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EventoTouch : MonoBehaviour
{
   
   Renderer esfera;
    public Texture[] texturas;

    private int i=0;
    // Start is called befre the first frame update
    void Start()
    {
        esfera = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
       
            foreach(Touch touch in Input.touches) {
                if (touch.phase == TouchPhase.Began) 
                {
                    if (i == 2)
                    {
                        i = 0;
                        esfera.material.SetTexture("_MainTex", texturas[i]);
                    }
                    else
                    {
                        i++;
                        esfera.material.SetTexture("_MainTex", texturas[i]);
                    }
                }
            }
            
        
    }
}
