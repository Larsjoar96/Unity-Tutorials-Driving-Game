using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner_Enemy : MonoBehaviour
{

    public GameObject Enemy;
    public float spawnTime;
    public float spawnMaxSpeed;
    public float spawnMinSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(spawnTime > 0) 
        {
            spawnTime -= Time.deltaTime;
        }
        else 
        {
            spawnTime = Random.Range(spawnMinSpeed, spawnMaxSpeed);
            Instantiate(Enemy, this.transform.position, this.transform.rotation);

        }
    }
}
