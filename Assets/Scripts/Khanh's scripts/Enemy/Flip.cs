using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flip : MonoBehaviour
{
    [SerializeField] private Transform player;
    private bool isFlipped;

  public void FacePlayer()
    {
        Vector3 flipping = transform.localScale;
        flipping.z *= -1f;

        if(transform.position.x > player.position.x && isFlipped)
        {
            transform.localScale = flipping;
            transform.Rotate(0, 180, 0);
            isFlipped = false;
        }
        else if(transform.position.x <player.position.x && !isFlipped)
        {
            transform.localScale = flipping;
            transform.Rotate(0, 180, 0);
            isFlipped = true;
        }
    }
}
