using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knock : MonoBehaviour
{
    public int knockNumber;

    [SerializeField] private GameObject Lights;
    [SerializeField] private GameObject Woman;

    [SerializeField] private AudioSource soundSource;
    [SerializeField] private AudioClip soundKnock;
    [SerializeField] private AudioClip loudKnock;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        print(knockNumber);
        if (knockNumber == 3)
        {
            StartCoroutine(LoudKnock());
            StartCoroutine(LightOff());

        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown("e"))
        {
            StartCoroutine(QuietKnock());
        }    
    }

    IEnumerator QuietKnock()
    {

        soundSource.PlayOneShot(soundKnock);
        knockNumber++;
        yield return new WaitForSeconds(3);
    }

    IEnumerator LoudKnock()
    {
        knockNumber++;
        yield return new WaitForSeconds(3);
        soundSource.PlayOneShot(loudKnock);

    }

    IEnumerator LightOff()
    {
        yield return new WaitForSeconds(4);
        Lights.SetActive(false);
        Woman.SetActive(false);
    }
}
