using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnHenRooster : MonoBehaviour
{
    // script for chick
    private GameObject henParent, roosterParent;
    public SpawnEgg Hen;
    public ExpireRooster Rooster;

    private float z;
    public float time = 10;

    // Start is called before the first frame update
    void Start()
    {
        henParent = GameObject.Find("S_HENS");
        roosterParent = GameObject.Find("S_ROOSTERS");
        Invoke(nameof(createHenRooster), time);
    }

    // Update is called once per frame
    void Update()
    {
        z = Random.Range (0, 360);
    }

    private void createHenRooster(){
        int randomizer = Random.Range (0,2);

        if (Counter.Instance.noHens == 0){
            randomizer = 1;
        }

        if(randomizer == 1){
            var newHen = Instantiate(Hen, gameObject.transform.position, Quaternion.Euler(0, 0, z));
            newHen.transform.parent = henParent.transform;
            Counter.Instance.countHen(true);
        }
        else{
            var newRooster = Instantiate(Rooster, gameObject.transform.position, Quaternion.Euler(0, 0, z));
            newRooster.transform.parent = roosterParent.transform;
            Counter.Instance.countRooster(true);
        }

        Counter.Instance.countChick(false);
        Destroy(gameObject);
    }

    
}
