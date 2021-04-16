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

        private float cooldownTime = 2.0f;
        private float nextCastTime = 0f;

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
        public void CastPowerStrike()
        {//Press button Space to cast the spell
            if (Time.time > nextCastTime)
            {
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    rb2d.velocity = Vector2.zero;
                    anim.SetBool("isPSing", true);
                    isPSing = true;
                    nextCastTime = Time.time + cooldownTime;
                    Debug.Log("is Pressing Space");
                }
            }           
            else
            {
                isPSing = false;
                anim.SetBool("isPSing", false);             
            }
        }
    }
}

