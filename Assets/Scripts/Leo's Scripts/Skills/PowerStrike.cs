using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Skills
{
    public class PowerStrike : MonoBehaviour
    {
        MyInput myInput;
        private Animator anim;
        Rigidbody2D rb2d;

        private bool isPSing;
        private void Start()
        {
            myInput = new MyInput();
            anim = GetComponent<Animator>();
            rb2d = GetComponent<Rigidbody2D>();
        }
        private void Update()
        {
            CastPowerStrike();
        }
        public void PowerStrikeInput(InputAction.CallbackContext context)
        {
            isPSing = context.performed;
            myInput.Player.Attack.performed += ctx => CastPowerStrike();
        }
        private void CastPowerStrike()
        {
            if (Input.GetKeyDown(KeyCode.Y))
            {
                rb2d.velocity = Vector2.zero;
                anim.SetBool("isPSing", true);
                isPSing = true;
                Debug.Log("is Pressing");
            }
            else
            {
                isPSing = false;
                anim.SetBool("isPSing", false);             
            }
        }
    }
}

