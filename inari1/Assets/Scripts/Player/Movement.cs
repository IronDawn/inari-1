using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;
    public Animator anim;
    public SpriteRenderer visP;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mX = Input.GetAxis("Horizontal");
        float mY = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(speed * mX, speed * mY, 0);
        move *= Time.deltaTime;

        if (mX != 0 || mY != 0)
        {
            anim.SetBool("Moving", true);
        } else
        {
            anim.SetBool("Moving", false);
        }

        if (mX > 0)
        {
            visP.flipX = true;
        }
        else if (mX < 0)
        {
            visP.flipX = false;
        }

        transform.Translate(move);
    }
}
