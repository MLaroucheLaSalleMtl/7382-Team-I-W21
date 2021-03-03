using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class EnemyDetector : MonoBehaviour
{
    private List<GameObject> _enemyInRange;

    [SerializeField] private string layerToDetect;
    // Start is called before the first frame update
    void Start()
    {
        if (layerToDetect == "")
        {
            layerToDetect = "Enemy";
        }
        _enemyInRange = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < _enemyInRange.Count; i++)
        {
            if (_enemyInRange[i])
            {
                _enemyInRange.RemoveAt(i);
            }
        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer(layerToDetect))
        {
            if (!_enemyInRange.Contains(other.gameObject))
            {
                _enemyInRange.Add(other.gameObject);
            }
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer(layerToDetect))
        {
            _enemyInRange.Remove(other.gameObject);
        }
    }
}
