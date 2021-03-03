using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeHealth : MonoBehaviour
{
    [SerializeField] private int slimeHealth;
    [SerializeField] private GameObject damagePoint, damageDisplayPos;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (slimeHealth <= 0)
        {
            gameObject.SetActive(false);
        }
    }

    public void Hurt()
    {
        slimeHealth--;
        Instantiate(damagePoint, damageDisplayPos.transform.position, Quaternion.identity);
    }
}
