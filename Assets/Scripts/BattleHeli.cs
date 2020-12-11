using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleHeli : MonoBehaviour
{
    public GameObject target;
    public GameObject enemyShotShell;
    public GameObject enemyShellPrefab;
    private int count = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(target.transform);
        if(Vector3.Distance(transform.position, target.transform.position) > 8f)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * 3);
        }
        else
        {
            if(transform.position.y < 6f)
            {
                transform.Translate(Vector3.up * Time.deltaTime * 3);
            }
            count += 1;
            if(count % 300 == 0)
            {
                GameObject enemyShell = Instantiate(enemyShellPrefab, enemyShotShell.transform.position, enemyShotShell.transform.rotation);
                Rigidbody enemyShellRb = enemyShell.GetComponent<Rigidbody>();
                enemyShellRb.AddForce(transform.forward * 100);
            }
        }
    }
}
