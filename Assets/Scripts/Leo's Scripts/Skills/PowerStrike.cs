using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Skills
{
    public class PowerStrike : MonoBehaviour
    {
        private Animator anim;
        private void Start()
        {
            anim = GetComponent<Animator>();
        }
        private void Update()
        {
            CastPowerStrike();
        }
        void CastPowerStrike()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                GetComponent<ZombieHealth>().Hurt(zombieHurt: 2);
                anim.SetBool("isAttacking", true);
            }
        }
    }
}

