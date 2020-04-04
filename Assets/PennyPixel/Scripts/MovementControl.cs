using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UIElements;

public class MovementControl : MonoBehaviour
{

    private Animator mAnimator;
    private Rigidbody2D mPlayerBody;
    [SerializeField]
    private float force = 3;

    private const string STR_JUMPING = "jumping";
    private bool mOnGround = false;
    private bool mJumpForceAdded = false;//是否施加了弹跳力

    [SerializeField]
    private GameObject mSheldon;

    [SerializeField] private float jumpSpeed;

    // Start is called before the first frame update
    void Start()
    {
        mPlayerBody = GetComponent<Rigidbody2D>();
        mAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Update() : Space Key down. Time.deltaTime="+Time.deltaTime);
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            mJumpForceAdded = false;
        }
    }
    
    

    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !mJumpForceAdded)
        {
            // key-space down
            Debug.Log("before addforce mPlayerBody's velocity is " + mPlayerBody.velocity+", Time.deltaTime="+Time.deltaTime);
            mPlayerBody.AddForce(Vector3.up * force,ForceMode2D.Impulse);
            
            {
                Vector2 current = mPlayerBody.velocity;
                
                mPlayerBody.velocity = new Vector2(current.x, jumpSpeed);
            }
            
            mJumpForceAdded = true;
            mOnGround = false;
            mAnimator.SetBool(STR_JUMPING, true);
            Debug.Log("after addforce mPlayerBody's velocity is " + mPlayerBody.velocity);
        }
    }
    


    public void onGround()
    {
        mOnGround = true;
        mAnimator.SetBool(STR_JUMPING,false);
    }
}
