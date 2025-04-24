using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriangleAnim : MonoBehaviour
{
    public Animator anim;

    bool front = false;
    bool back = false;

    Vector2 dir;
    Vector3 lastPos;
    private void Update()
    {
        dir =(this.transform.position-lastPos).normalized;
        lastPos=transform.position;
    }
    void FixedUpdate()
    {
        if(!back && dir.y > 0)
        {
            anim.SetBool("back", true);
            anim.SetBool("front", false);
            back = true;
            front = false;
        }

        if (!front && dir.y <= 0)
        {
            anim.SetBool("back", false);
            anim.SetBool("front", true);
            back = false;
            front = true;
        }
    }
}
