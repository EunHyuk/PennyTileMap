using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FanController : MonoBehaviour
{

    private Rigidbody2D mRigidbody;
    
    [SerializeField]
    private float force;
    
    // Start is called before the first frame update
    void Start()
    {
        mRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Space Key down !");
        }
    }

    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("before addforce ,velocity="+mRigidbody.velocity);
            mRigidbody.AddForce(Vector2.up*force,ForceMode2D.Impulse);
            Debug.Log("after addforce ,velocity="+mRigidbody.velocity);
        }
    }
    
    
}
