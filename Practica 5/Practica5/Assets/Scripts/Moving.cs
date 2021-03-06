using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
	public Transform posCam;
	public float velocidad;
	public float speedH;
	public float speedV;
	public float speed =2f;
	private float yaw;
	private float pitch;
	private bool start=false;
	private bool pause=false;
	private Rigidbody character;
    // Start is called before the first frame update
    void Start()
    {
	    character = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
		if (start==true && pause==false){ 
			float moveHorizontal = Input.GetAxis("Horizontal");
	    	float moveHVertical = Input.GetAxis("Vertical");

	    	yaw += speedH = Input.GetAxis("Mouse X");
	    	pitch -= speedV = Input.GetAxis("Mouse Y");
	    	transform.eulerAngles = new Vector3(0.0f, yaw, 0.0f);

	    	if (moveHorizontal != 0.0f || moveHVertical != 0.0)
	    	{
		   		 Vector3 dirVertical = transform.forward * moveHVertical;
		   	 	Vector3 dir = dirVertical + transform.right * moveHorizontal;
		    	character.MovePosition(transform.position + dir * speed);
	   		 }

	    	Vector3 floor = transform.TransformDirection(Vector3.down);

		}



	    /*if(Input.GetAxis("Vertical")>0)
            posCam.transform.Translate(Vector3.forward * velocidad);
	    if(Input.GetAxis("Vertical")<0)
		    posCam.transform.Translate(Vector3.forward * -velocidad);*/


    }
	public void startGame(){
        start=true;
    }

    public void pauseGame(){
        if (pause==false){
            pause=true;
        }
        else
            pause=false;
    }
}
