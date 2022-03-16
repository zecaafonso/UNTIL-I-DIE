using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Runanimations : MonoBehaviour
{

    public Animator animator;
    public Camera mainCamera;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("start");
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.LeftShift))
        {
            bool run = animator.GetBool("Run");


            animator.SetBool("Run", true);
        }
        else
        {
            animator.SetBool("Run", false);
        }
        
    }
}
