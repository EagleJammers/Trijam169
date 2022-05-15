using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
	
	public float rotateSpeed; 
	public float moveSpeed; 
	
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		//On Left Click
		transform.Rotate(0.0f, 0, -Input.GetAxis ("Horizontal") * rotateSpeed);
		transform.Translate(0, Input.GetAxis("Vertical") * moveSpeed, 0); 
			
			//Turn some degree
		//On Right Click
			//Turn negative some degrees
		
		
		//On Up Key
			//Move forward
    }
}
