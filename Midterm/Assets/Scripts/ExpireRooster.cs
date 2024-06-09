using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExpireRooster : MonoBehaviour
{
    //script for rooster
    public float deathTime = 40;

    // Start is called before the first frame update
    void Start()
    {
        Invoke(nameof(killRooster), deathTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void killRooster(){
        Counter.Instance.countRooster(false);
        Destroy(gameObject);
    }
}
