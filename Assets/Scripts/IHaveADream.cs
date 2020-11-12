using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IHaveADream : MonoBehaviour
{

    private void Start()
    {

    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        transform.Translate(5 * Time.deltaTime, 0, 0);

    }

    public class First
    {
        public int love;
        public int dope;

        public First()
        {
            love = 1;
            dope = 5;
        }

        First first = new First();

        //irst.
    }


}
