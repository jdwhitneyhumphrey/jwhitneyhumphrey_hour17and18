using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WKey : MonoBehaviour
{
    public Animator myAnimator;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            myAnimator.SetTrigger("W Key");
        }
    }
}
