using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
	public Camera cam; 
	
	public GameObject plant; 
	
	public int timeInterval; 
	
	public int time; 
	
	private float left; 
	private float right;  
	
	private float bottom; 
	private float top; 
    // Start is called before the first frame update
    void Start()
    {
        time = timeInterval; 
		left = cam.ViewportToWorldPoint(new Vector3(0f, 0f, 0f)).x; 
		right =  cam.ViewportToWorldPoint(new Vector3(1.0f, 0f, 0f)).x;; 
		
		top = cam.ViewportToWorldPoint(new Vector3(0f, 1.0f, 0f)).y;; 
		bottom = cam.ViewportToWorldPoint(new Vector3(0f, 0f, 0f)).y;; 
    }

    // Update is called once per frame
    void Update()
    {
		time++; 
		//Every few seconds create a plant on screen 
		if(time % timeInterval == 0){
			//Spawn a plant in a random location on screen 
			
			float randX = Random.Range(left, right); 
			float randY = Random.Range(top, bottom); 
			
			//Create teh object
			Instantiate(plant, new Vector3(randX, randY, 0), Quaternion.identity);
			
		}
		

		
    }
}
