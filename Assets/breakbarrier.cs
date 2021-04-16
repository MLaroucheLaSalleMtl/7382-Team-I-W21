using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class breakbarrier : MonoBehaviour
{
    public MinotaurHealth minoScr;

    // Start is called before the first frame update
    void Start()
    {
        minoScr = GameObject.Find("Minotaur").GetComponent<MinotaurHealth>();
    }

    // Update is called once per frame
    void Update()
    {
        if(minoScr.minotaurHealth<=0)
        {
            Destroy(gameObject);
        }
    }


}
