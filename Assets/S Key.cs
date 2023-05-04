using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SKey : MonoBehaviour
{
    public Animator myAnimator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.S))
        {
            myAnimator.SetTrigger("S Key");
        }
    }
}
