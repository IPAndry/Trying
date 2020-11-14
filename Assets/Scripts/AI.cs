﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour
{
    public const float baseSpeed = 3.0f;

    public float speed = 3.0f;
    public float obstacleRange = 5.0f;

    private bool _alive;

    [SerializeField] private GameObject fireBall;
    private GameObject _fireball;

    void Awake()
    {
        Messenger<float>.AddListener(GameEvent.SPEED_CHANGED, OnSpeedChanged);    
    }

    private void OnDestroy()
    {
        Messenger<float>.RemoveListener(GameEvent.SPEED_CHANGED, OnSpeedChanged);        
    }

    // Start is called before the first frame update
    void Start()
    {
        _alive = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (_alive)
        {
            transform.Translate(0, 0, speed * Time.deltaTime);

            Ray ray = new Ray(transform.position, transform.forward);
            RaycastHit hit;

            if (Physics.SphereCast(ray, 0.75f, out hit))
            {
                GameObject hitObject = hit.transform.gameObject;
                if (hitObject.GetComponent<Character>())
                {
                    if (_fireball == null)
                    {
                        _fireball = Instantiate(fireBall) as GameObject;
                        _fireball.transform.position = transform.TransformPoint(Vector3.forward * 1.5f);
                        _fireball.transform.rotation = transform.rotation;
                    }
                }
                else if (hit.distance < obstacleRange)
                {
                    float angle = Random.Range(-110, 110);
                    transform.Rotate(0, angle, 0);
                }
            }
        }
    }

    public void SetAlive(bool alive)
    {
        _alive = alive;
    }

    private void OnSpeedChanged(float value)
    {
        speed = baseSpeed * value;
    }    
}
