using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Skills
{
    public class PowerStrike : MonoBehaviour
    {
        private void Start()
        {

        }
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                GetComponent<ZombieHealth>().Hurt(zombieHurt: 2);
            }
        }
    }
}

