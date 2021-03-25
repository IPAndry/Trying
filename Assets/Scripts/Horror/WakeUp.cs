using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WakeUp : MonoBehaviour
{
    [SerializeField] private GameObject playerCamera;
    [SerializeField] private GameObject wakeupCamera;
    
    // Start is called before the first frame update
    void Start()
    {
        playerCamera.SetActive(false);
        wakeupCamera.SetActive(true);

        StartCoroutine(LittleWait());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator LittleWait()
    {
        yield return new WaitForSeconds(10.0f);

        print("Done");
        playerCamera.SetActive(true);
        wakeupCamera.SetActive(false);

    }
}
