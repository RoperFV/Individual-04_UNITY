using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMotion : MonoBehaviour
{
    public Vector3 targetPostition;

  

    private Vector3 destination;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        destination.x = targetPostition.x;
        destination.z = targetPostition.z;
        destination.y = 0;


        transform.LookAt(destination);

        transform.position = Vector3.MoveTowards(transform.position, destination.transform.position, .05);
    }
}
