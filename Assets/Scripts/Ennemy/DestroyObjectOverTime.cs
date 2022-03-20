// référence : https://www.youtube.com/watch?v=0QWXZDcJEIw

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObjectOverTime : MonoBehaviour
{
    [SerializeField]
    private float _lifetime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _lifetime -= Time.deltaTime;

        if(_lifetime < 0) {
            Destroy(gameObject);
        }
    }
}
