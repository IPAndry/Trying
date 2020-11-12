using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Targeting : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReactToHit()
    {
        AI behaviour = GetComponent<AI>();
        if (behaviour != null)
        {
            behaviour.SetAlive(false);
        }
        StartCoroutine(Die());
    }

    private IEnumerator Die()
    {
        this.transform.Rotate(-30, 0, 0);

        yield return new WaitForSeconds(1.5f);

        Destroy(this.gameObject);
    }

}
