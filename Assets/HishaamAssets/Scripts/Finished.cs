using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finished : MonoBehaviour
{
    [SerializeField] private float destroyed;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, destroyed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
