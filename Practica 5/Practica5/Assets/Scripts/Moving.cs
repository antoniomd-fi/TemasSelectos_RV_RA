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
	bool isJump = false;
	public float jumpForce = 10f;
	private bool floorDetected;
	public GameObject gizmo;

	private Rigidbody character;
    // Start is called before the first frame update
    void Start()
    {
	    character = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
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

	    if (Physics.Raycast(gizmo.transform.position, floor, 0.3f))
	    {
		    floorDetected = true;
		    
	    }
	    else
	    {
		    floorDetected = false;
		    
	    }
	    
	    isJump = Input.GetButton("Jump");

	    if (isJump && floorDetected)
	    {
		    character.AddForce(new Vector3(0, jumpForce,0),ForceMode.Impulse);

	    }




	    /*if(Input.GetAxis("Vertical")>0)
            posCam.transform.Translate(Vector3.forward * velocidad);
	    if(Input.GetAxis("Vertical")<0)
		    posCam.transform.Translate(Vector3.forward * -velocidad);*/


    }
}
