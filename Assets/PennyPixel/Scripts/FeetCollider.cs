using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeetCollider : MonoBehaviour
{
    [SerializeField]
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("FeetCollider: OnCollisionEnter2D() other="+other);
        if (other.gameObject.layer == 9)
        {
            Debug.Log("Collide with ground!");

//            player.GetComponent<MovementControl>().onGround();
        }
    }

    
}
