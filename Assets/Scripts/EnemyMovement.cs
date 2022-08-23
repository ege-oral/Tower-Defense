using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    [SerializeField] List<Waypoint> path = new List<Waypoint>();
    [SerializeField] float waitTime = 1f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DisplayPath());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator DisplayPath()
    {
        foreach(Waypoint waypoint in path)
        {

            transform.position = new Vector3(waypoint.transform.position.x, 10f, waypoint.transform.position.z); 
            print(transform.position);
            yield return new WaitForSeconds(waitTime);
        }
    }
}