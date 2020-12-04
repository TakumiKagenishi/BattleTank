using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPItem : MonoBehaviour
{
    [SerializeField]
    private GameObject effectPrefab;
    [SerializeField]
    private AudioClip getSound;
    private TankHelth th;
    private int reward = 3;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            th = GameObject.Find("Tank").GetComponent<TankHelth>();
            th.AddHP(reward);
            Destroy(gameObject);
            GameObject effect = Instantiate(effectPrefab, transform.position, Quaternion.identity);
            Destroy(effect, 0.5f);
            AudioSource.PlayClipAtPoint(getSound, transform.position);
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
