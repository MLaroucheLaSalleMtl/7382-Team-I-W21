using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Skills
{
    public class Bravery : MonoBehaviour
    {
        MyInput myInput;
        private Animator anim;
        Rigidbody2D rb2d;

        private float cooldownTime = 3;
        private float nextCastTime = 0;

        private bool braveryActivated;
        // Start is called before the first frame update
        void Start()
        {
            myInput = new MyInput();
            anim = GetComponent<Animator>();
            rb2d = GetComponent<Rigidbody2D>();
        }

        // Update is called once per frame
        void Update()
        {
            CastBravery();
        }
        public void BraveryInput(InputAction.CallbackContext context)
        {
            braveryActivated = context.performed;
            myInput.Player.Attack.performed += ctx => CastBravery();
        }
        private void CastBravery()
        {
            if (Time.time > nextCastTime)
            {
                if (Input.GetKeyDown(KeyCode.F))
                {
                    rb2d.velocity = Vector2.zero;
                    anim.SetBool("BraveryActivated", true);
                    braveryActivated = true;
                    nextCastTime = Time.time + cooldownTime;
                    Debug.Log("is Pressing F");
                }
            }        
            else
            {
                braveryActivated = false;
                anim.SetBool("BraveryActivated", false);
            }
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.CompareTag("Enemy"))
            {
                collision.GetComponent<PlayerHealth>().InBravery();
            }
        }
    }
}
