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
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch.position);

            switch (touch.phase)
            {
                case TouchPhase.Began:
                    if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                    {
                        isScreenTouched = true;
                    }
                    break;
            }
        }

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
