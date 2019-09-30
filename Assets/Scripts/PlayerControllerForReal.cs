using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerForReal : MonoBehaviour
{
    
    Animator anim;
    
    
    void Start()
    { 
        anim = GetComponent<Animator>(); 
    }

 
    void Update()
    { 
        if (anim == null) return;
        var x = Input.GetAxis("Horizontal");
        var y = Input.GetAxis("Vertical");

        Move(x, y);
        Attack();
    }

    private void Move(float x, float y)
    {
        anim.SetFloat("hSpeed", x);
        anim.SetFloat("vSpeed", y);

    }

    private void Attack()
    {
        if (Input.GetButtonDown("Rpunch"))
        {
            anim.SetTrigger("Rpunch");
        }

        if (Input.GetButtonDown("Lpunch"))
        {
            anim.SetTrigger("Lpunch");
        }

        if (Input.GetButtonDown("Ultra"))
        {
            anim.SetTrigger("Ultra");
        }
    }
    private void FixedUpdate()
    {
       // Attack();
    }
}
