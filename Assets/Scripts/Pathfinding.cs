using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pathfinding : MonoBehaviour
{
    public GameObject target;
    public float speed;
    private float offset = -90;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(Vector3.up * Time.deltaTime * speed);
        Vector3 targetPoint = target.transform.position - this.transform.position;
        float angle = Mathf.Atan2(targetPoint.y, targetPoint.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle+offset));
        //this.transform.Translate(speed * Time.deltaTime * goal);

    }
}
