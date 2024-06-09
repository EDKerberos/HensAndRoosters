using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Counter : MonoBehaviour
{
    // script to count everything
    public static Counter Instance;

    public TextMeshProUGUI countEggs, countChicks, countHens, countRoosters;
    public int noEggs, noChicks, noHens, noRoosters;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Awake(){
        Instance = this;
    }

    public void countEgg(bool increase){
        if(increase == true){
            noEggs++;
            countEggs.text = "<align=\"center\">" + noEggs.ToString();
        }
        else{
            noEggs--;
            countEggs.text = "<align=\"center\">" + noEggs.ToString();
        }
    }

    public void countChick(bool increase){
        if(increase == true){
            noChicks++;
            countChicks.text = "<align=\"center\">" + noChicks.ToString();
        }
        else{
            noChicks--;
            countChicks.text = "<align=\"center\">" + noChicks.ToString();
        }
    }

    public void countHen(bool increase){
        if(increase == true){
            noHens++;
            countHens.text = "<align=\"center\">" + noHens.ToString();
        }
        else{
            noHens--;
            countHens.text = "<align=\"center\">" + noHens.ToString();
        }
    }

    public void countRooster(bool increase){
        if(increase == true){
            noRoosters++;
            countRoosters.text = "<align=\"center\">" + noRoosters.ToString();
        }
        else{
            noRoosters--;
            countRoosters.text = "<align=\"center\">" + noRoosters.ToString();
        }
    }
}
