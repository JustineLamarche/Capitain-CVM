// référence : https://www.youtube.com/watch?v=0QWXZDcJEIw

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// [RequireComponent(typeof(Rigidbody2D))]
public class EnemySpiceController : MonoBehaviour
{
    [SerializeField]
    public float _speed;

    [SerializeField]
    public GameObject _prefab;

    [SerializeField]
    public PlayerMouvement _player;

    [SerializeField]
    public float _rotationSpeed;

    [SerializeField]
    public int _damageToGive;

    [SerializeField]
    public Rigidbody2D _myrigidbody2D;

    // Start is called before the first frame update
    void Start()
    {
        _player = FindObjectOfType<PlayerMouvement>();

        _myrigidbody2D = this.gameObject.GetComponent<Rigidbody2D>();
    
        if(_player.transform.position.x < transform.position.x) {
            _speed = -_speed;
            _rotationSpeed = -_rotationSpeed;
        }
    }

    // Update is called once per frame
    void Update()
    {
        _myrigidbody2D.velocity = new Vector2(_speed, _myrigidbody2D.velocity.y);
        _myrigidbody2D.angularVelocity = _rotationSpeed;

        Instantiate(_prefab, transform.position, transform.rotation);

    }
}
