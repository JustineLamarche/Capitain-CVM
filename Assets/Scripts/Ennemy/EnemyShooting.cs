// référence : https://www.youtube.com/watch?v=0QWXZDcJEIw

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{

    [SerializeField]
    private GameObject _spice;

    [SerializeField]
    private Transform _launchPoint;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Instantiate(_spice, _launchPoint.position, _launchPoint.rotation);
    }
}
