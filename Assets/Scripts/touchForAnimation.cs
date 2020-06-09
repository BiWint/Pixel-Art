using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touchForAnimation : MonoBehaviour
{
    Animator _animator;

    bool isScreenTouched = false;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _animator.SetBool("isScreenTouched", true);
            Invoke("TurnOffAnimatorTool", .01f);
        }
    }

    void TurnOffAnimatorTool()
    {
        _animator.SetBool("isScreenTouched", false);
    }

}
