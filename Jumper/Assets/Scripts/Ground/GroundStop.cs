using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundStop : MonoBehaviour
{
    public Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void Stop()
    {
        anim.enabled = false;
    }
}
