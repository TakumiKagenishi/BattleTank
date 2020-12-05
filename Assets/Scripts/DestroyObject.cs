﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    [SerializeField]
    private GameObject effectPrefab;
    [SerializeField]
    private GameObject effectPrefab2;
    public int ofjectHP;
    [SerializeField]
    private GameObject[] itemPrefabs;
    [SerializeField]
    private int scoreValue;
    private ScoreManager sm;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Shell"))
        {
            ofjectHP -= 1;
            if(ofjectHP > 0)
            {
                Destroy(other.gameObject);
                GameObject effect = Instantiate(effectPrefab, other.transform.position, Quaternion.identity);
                Destroy(effect, 2.0f);
            }
            
            else
            {
                Destroy(other.gameObject);
                GameObject effect2 = Instantiate(effectPrefab2, other.transform.position, Quaternion.identity);
                Destroy(effect2, 2.0f);
                Destroy(this.gameObject);
                int itemNumber = Random.Range(0, itemPrefabs.Length);
                Vector3 pos = transform.position;
                if (itemPrefabs.Length != 0)
                {
                    Instantiate(itemPrefabs[itemNumber], new Vector3(pos.x, pos.y + 0.6f, pos.z), Quaternion.identity);
                }
                sm.AddScore(scoreValue);
            }
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        sm = GameObject.Find("ScoreLabel").GetComponent<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
