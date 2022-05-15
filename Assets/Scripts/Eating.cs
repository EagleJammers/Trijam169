using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eating : MonoBehaviour
{
	
	//Goal Target
	public string goalTag;
	
	//Knockback 
	public float knockback = 0; 
	
	//The new game object that it should create 
	public GameObject newCell; 
	
	//How many new objects it should create 
	public int split = 2; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	//When the herbivore collides with something 
	void OnCollisionEnter2D(Collision2D c){
		//When it collides with an object
		if(c.gameObject.CompareTag(goalTag)){
			Destroy(c.gameObject);
			Vector3 pos = this.transform.position; 

			Instantiate(newCell, new Vector3(pos.x + .5f, pos.y + .5f, 0), this.transform.rotation);
			Instantiate(newCell, new Vector3(pos.x + .5f, pos.y - .5f, 0), this.transform.rotation);
				
			
			
		}
		
		
	}
}
