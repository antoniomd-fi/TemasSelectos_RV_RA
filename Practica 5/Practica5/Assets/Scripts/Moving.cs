﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
	public Transform posCam;
	public float velocidad;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
	if(Input.GetAxis("Vertical")<0)
        	posCam.transform.Translate(Vector3.forward * velocidad);
	if(Input.GetButton("Fire1"))
		posCam.transform.Translate(Vector3.forward * velocidad);
    }
}
