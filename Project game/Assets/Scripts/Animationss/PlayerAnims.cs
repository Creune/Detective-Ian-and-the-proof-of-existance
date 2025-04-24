using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnims : MonoBehaviour
{
    public Animator anim;

    bool front=false;
    bool back = false;
    bool lSide = false;
    bool rSide = false;

    void FixedUpdate()
    {
        if (!lSide && Input.GetKeyDown(KeyCode.A) && !Input.GetKeyDown(KeyCode.D))
        {
            this.GetComponent<SpriteRenderer>().flipX = true;
            anim.SetBool("Side", true);
            anim.SetBool("Back", false);
            anim.SetBool("Front", false);
            lSide = true;
            back = false;
            front = false;
            rSide = false;
        }
        if (!rSide && Input.GetKeyDown(KeyCode.D) && !Input.GetKeyDown(KeyCode.A))
        {
            this.GetComponent<SpriteRenderer>().flipX = false;
            anim.SetBool("Side", true);
            anim.SetBool("Back", false);
            anim.SetBool("Front", false);
            lSide = false;
            back = false;
            front = false;
            rSide = true;
        }

        if (!back && Input.GetKeyDown(KeyCode.W) && !Input.GetKeyDown(KeyCode.S))
        {
            this.GetComponent<SpriteRenderer>().flipX = false;
            anim.SetBool("Side", false);
            anim.SetBool("Back", true);
            anim.SetBool("Front", false);
            lSide = false;
            back = true;
            front = false;
            rSide = false;
        }
        if (!front && Input.GetKeyDown(KeyCode.S) && !Input.GetKeyDown(KeyCode.W))
        {
            this.GetComponent<SpriteRenderer>().flipX = false;
            anim.SetBool("Side", false);
            anim.SetBool("Back", false);
            anim.SetBool("Front", true);
            lSide = false;
            back = false;
            front = true;
            rSide = false;
        }
    }
}
