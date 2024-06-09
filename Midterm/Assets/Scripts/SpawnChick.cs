using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnChick : MonoBehaviour
{
    // script for egg
    private GameObject chickParent;
    public SpawnHenRooster Chick;

    private float z;
    public float time = 10;

    // Start is called before the first frame update
    void Start()
    {
        chickParent = GameObject.Find("S_CHICKS");
        Invoke(nameof(createChick), time);
    }

    // Update is called once per frame
    void Update()
    {
        z = Random.Range (0, 360);
    }

    private void createChick(){
        var newChick = Instantiate(Chick, gameObject.transform.position, Quaternion.Euler(0, 0, z));
        newChick.transform.parent = chickParent.transform;
        Counter.Instance.countChick(true);

        Counter.Instance.countEgg(false);
        Destroy(gameObject);
    }
}
