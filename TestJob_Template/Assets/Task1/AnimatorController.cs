using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorController : MonoBehaviour
{
    private Animator animator;
    
    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void SwitchWind()
    {
        bool isWind = !animator.GetBool("isWind");
        animator.SetBool("isWind", isWind);
    }
}
