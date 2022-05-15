using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
	public GameObject plant; 
	
	public int timeInterval; 
	
	public int time; 
	
	private int minX; 
	private int minY; 
	
	private int maxX; 
	private int maxY; 
    // Start is called before the first frame update
    void Start()
    {
       /* time = 0; 
		maxX = ; 
		maxY = ; 
		
		minX = ; 
		minY = ; */
    }

    // Update is called once per frame
    void Update()
    {
		time++; 
		        //Every few seconds create a plant on screen 
		if(time % timeInterval == 0){
			//Spawn a plant in a random location on screen 
			/*
			float minX = ;
			float maxX = ; 
			
			float minY = ; 
			float maxY = Screen.height; ; 
			
			
			float randX  = ; 
			float randY =  ; 
			*/
			//Create teh object
			Instantiate(plant, new Vector3(0, 0, 0), Quaternion.identity);
			
		}
		

		
    }
}
