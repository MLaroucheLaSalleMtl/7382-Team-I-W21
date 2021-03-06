using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Skills
{
    public class BloodyFight : MonoBehaviour
    {
        MyInput myInput;
        private Animator anim;
        Rigidbody2D rb2d;

        private float cooldownTime = 4.0f;
        private float nextCastTime = 0f;

        private bool BFActivated;
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
            CastBloodyFight();
        }
        public void PowerStrikeInput(InputAction.CallbackContext context)
        {
            BFActivated = context.performed;
            myInput.Player.Attack.performed += ctx => CastBloodyFight();
        }
        private void CastBloodyFight()
        {
            if (Time.time > nextCastTime)
            {
                if (Input.GetKeyDown(KeyCode.G))
                {
                    rb2d.velocity = Vector2.zero;
                    anim.SetBool("BFActivated", true);
                    BFActivated = true;
                    nextCastTime = Time.time + cooldownTime;
                    Debug.Log("is Pressing G");
                }
            }
            else
            {
                BFActivated = false;
                anim.SetBool("BFActivated", false);
            }
        }
    }
}

