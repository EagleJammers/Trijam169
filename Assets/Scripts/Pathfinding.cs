using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pathfinding : MonoBehaviour
{
    [SerializeField]
    private bool isCarnivore;
    
    private GameObject target;

    public float speed;
    private float offset = -90;
    
    // Start is called before the first frame update
    void Start()
    {
        findTarget();
    }

    // Update is called once per frame
    void Update()
    {

            findTarget();

            this.transform.Translate(Vector3.up * Time.deltaTime * speed);
            Vector3 targetPoint = target.transform.position - this.transform.position;
            float angle = Mathf.Atan2(targetPoint.y, targetPoint.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle + offset));

        
        //this.transform.Translate(speed * Time.deltaTime * goal);

    }

    void findTarget()
    {
        if (isCarnivore)
        {
            GameObject[] potentialTargets = GameObject.FindGameObjectsWithTag("Herb");
            if (potentialTargets.Length == 0) { return; }
            Vector3 lowestMagnitude = Vector3.one*9999;
            GameObject closest;

            foreach(GameObject target in potentialTargets)
            {
                Vector3 distanceToTarget = (target.transform.position - this.transform.position);
                if (distanceToTarget.magnitude < lowestMagnitude.magnitude)
                {
                    lowestMagnitude = distanceToTarget;
                    closest = target;
                    this.target = target;
                }
                
            }



        }
        else
        {
            GameObject[] potentialTargets = GameObject.FindGameObjectsWithTag("Plant");
            if (potentialTargets.Length == 0) { return; }
            Vector3 lowestMagnitude = Vector3.one * 9999;
            GameObject closest;
            foreach (GameObject target in potentialTargets)
            {
                Vector3 distanceToTarget = (target.transform.position - this.transform.position);
                if (distanceToTarget.magnitude < lowestMagnitude.magnitude)
                {
                    lowestMagnitude = distanceToTarget;
                    closest = target;
                    this.target = target;
                }

            }

        }
    }
}
