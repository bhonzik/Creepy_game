using UnityEngine;
using System.Collections;
using UnityEditor.Experimental.GraphView;

public class Wander : MonoBehaviour
{
    [SerializeField]
    public float Speed = 1;

    Vector3 wayPoint;

    [SerializeField]
    int Range = 10;

    public GameObject body;
    public Transform body2;

    float timer;

    void Start()
    {
        //initialise the target way point
        wander();
    }

    void Update()
    {
        timer += Time.deltaTime;
        // this is called every frame
        // do move code here
        // transform.position += transform.TransformDirection(Vector3.forward) * Speed * Time.deltaTime;
        Rigidbody rb = body.GetComponent<Rigidbody>();
        rb.AddForce(body2.forward * Speed, ForceMode.Impulse);
        if (timer >= 10)
        {
            // when the distance between us and the target is less than 3
            // create a new way point target
            timer = 0;
            wander();
        }
    }

    void wander()
    {
        // does nothing except pick a new destination to go to

        wayPoint = new Vector3(Random.Range(transform.position.x - Range, transform.position.x + Range), 1, Random.Range(transform.position.z - Range, transform.position.z + Range));
        wayPoint.y = 1;
        // don't need to change direction every frame seeing as you walk in a straight line only
        transform.LookAt(wayPoint);
        Debug.Log(wayPoint + " and " + (transform.position - wayPoint).magnitude);
    }
}