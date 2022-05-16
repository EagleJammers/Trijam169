using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Eating : MonoBehaviour
{
	[SerializeField]
	private Pathfinding self;
	//Goal Target
	public string[] goalTag;
	
	//Knockback 
	public float knockback = 0;

	private bool newborn = true;
	public float scale = 0.2f;

	//The new game object that it should create 
	public GameObject newCell; 
	
	//How many new objects it should create 
	public int split = 2; 
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
		if (newborn)
        {
			this.transform.localScale = Vector3.one * scale;
			newborn = false;
		} else if (scale < 1.0f)
		{
			scale += .001f;
			this.transform.localScale = Vector3.one * scale;
		}


        
    }
	public void setScale()
    {
		scale = 0.2f;
    }
	//When the herbivore collides with something 
	void OnCollisionStay2D(Collision2D c){
		//When it collides with an object
		foreach (string tag in goalTag)
		{
			if (c.gameObject.CompareTag(tag) && scale > 0.8f)
			{

				if (c.gameObject.name == "OmniCell")
				{
					SceneManager.LoadScene("Die");
				}

				Destroy(c.gameObject);
				Vector3 pos = this.transform.position;

				GameObject child1 = Instantiate(newCell, new Vector3(pos.x + .5f, pos.y + .5f, 0), this.transform.rotation);
				child1.GetComponent<Eating>().setScale();
				GameObject child2 = Instantiate(newCell, new Vector3(pos.x + .5f, pos.y - .5f, 0), this.transform.rotation);
				child2.GetComponent<Eating>().setScale();

				self.SetEatCooldown();



			}
		}
		
		
	}
}
