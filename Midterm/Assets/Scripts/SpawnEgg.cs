using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEgg : MonoBehaviour
{
    // script for hen
    private GameObject eggParent;
    public SpawnChick Egg;

    private float x, y, z;
    public float time = 10;
    public float deathTime = 40;

    // Start is called before the first frame update
    void Start()
    {
        eggParent = GameObject.Find("S_EGGS");
        Invoke(nameof(createEgg), time);
        Invoke(nameof(killHen), deathTime);
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    private void createEgg(){
        int noEgg = Random.Range(2, 11);

        for (int i = 0; i < noEgg; i++){
            x = Random.Range (-7, 7);
            y = Random.Range (-3, 7);
            z = Random.Range (0, 360);

            Vector3 spawnLocation = new Vector3(x, y, 0);

            var newEgg = Instantiate(Egg, spawnLocation, Quaternion.Euler(0, 0, z));
            newEgg.transform.parent = eggParent.transform;
            Counter.Instance.countEgg(true);
        }
        
    }

    private void killHen(){
        Counter.Instance.countHen(false);
        Destroy(gameObject);
    }
}
