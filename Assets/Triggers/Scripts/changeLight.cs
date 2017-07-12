using UnityEngine;
using System.Collections;

public class changeLight : MonoBehaviour {

    
   
    public GameObject yellowLight;
    public GameObject redLight;
    public GameObject greenLight;
    private vehicleEntered s;
    public GameObject signalTrigger;
    private double enterTime;
    private double exitTime;
    private int count = 0;
    void Start()
    {
        
        s = signalTrigger.GetComponent<vehicleEntered>();
    }
    void Update()
    {

        
        if (s.hasEntered == true)
              {

            if (count == 0)
            {
                enterTime = Time.realtimeSinceStartup;
                yellowLight.SetActive(false);
                redLight.SetActive(true);
                greenLight.SetActive(false);
                exitTime = Time.realtimeSinceStartup;
                count++;
            }
            if(count == 1)
                exitTime = Time.realtimeSinceStartup;
            if (exitTime - enterTime >= 15)
            {
                yellowLight.SetActive(false);
                redLight.SetActive(false);
                greenLight.SetActive(true);
            }
            if(exitTime - enterTime >= 20)
            {
                s.hasEntered = false;
                yellowLight.SetActive(false);
                redLight.SetActive(false);
                greenLight.SetActive(false);
            }
              }
    }
}
