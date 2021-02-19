using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SortingOrder : MonoBehaviour
{
    [SerializeField] private int sortingOrderBase;
    [SerializeField] private int offset;
    [SerializeField] private int scalingOrder;

    private Renderer myRenderer;
    // Start is called before the first frame update
    void Start()
    {
        myRenderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void LateUpdate()
    {
        myRenderer.sortingOrder = (int)(sortingOrderBase - (transform.position.y * scalingOrder) - offset);
    }
}
