// référence : https://www.youtube.com/watch?v=0QWXZDcJEIw

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// [RequireComponent(typeof(Rigidbody2D))]
public class EnemySpiceController : MonoBehaviour
{

    public float _speed;

    public GameObject _impactEffect;

    public PlayerMouvement player;

    public float _rotationSpeed;

    public int _damageToGive;

    public Rigidbody2D _myrigidbody2D;

    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<PlayerMouvement>();

        _myrigidbody2D = this.gameObject.GetComponent<Rigidbody2D>();
    
        if(player.transform.position.x < transform.position.x) {
            _speed = -_speed;
            _rotationSpeed = -_rotationSpeed;
        }
    }

    // Update is called once per frame
    void Update()
    {
        _myrigidbody2D.velocity = new Vector2(_speed, _myrigidbody2D.velocity.y);
        _myrigidbody2D.angularVelocity = _rotationSpeed;

        Instantiate(_impactEffect, transform.position, transform.rotation);
        Destroy(this.gameObject);
    }
}
