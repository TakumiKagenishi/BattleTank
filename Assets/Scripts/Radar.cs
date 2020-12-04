using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Radar : MonoBehaviour
{
    [SerializeField]
    private Transform target;
    private void OnTriggerStay(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            transform.root.LookAt(target);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
