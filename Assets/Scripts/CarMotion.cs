using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Vuforia;

public class CarMotion : MonoBehaviour
{
    public GameObject imageTracked;

    public float speed;


    private Vector3 lastPosition;


    private Vector3 destination;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //bool tracked = isTrackingMarker();

        Vector3 direction = imageTracked.transform.position - transform.position;
        direction = direction.normalized * Time.deltaTime * speed;

        float distance = Vector3.Distance(transform.position, imageTracked.transform.position);
        transform.position = transform.position + Vector3.ClampMagnitude(direction, distance);

   
    }
    /*
     * 
     *  Cannot get the tracked status to work
     *  
    private bool isTrackingMarker()
    {
        var imageTarget = imageTracked;
        var trackable = imageTarget.GetComponent<TrackableBehaviour>();
        var status = trackable.CurrentStatus;
        if (TrackableBehaviour.CurrentStatus)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    */
}

