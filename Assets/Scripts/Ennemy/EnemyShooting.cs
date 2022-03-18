// référence : https://www.youtube.com/watch?v=0QWXZDcJEIw

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{

    public GameObject spice;

    public Transform launchPoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.localScale.x < 0) {
            Instantiate(spice, launchPoint.position, launchPoint.rotation);
        }

    }
}
