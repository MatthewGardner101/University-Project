using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseCount : MonoBehaviour
{
    EndCount endCount;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        endCount = player.GetComponent<EndCount>();
        increaseByOne();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void increaseByOne()
    {
        endCount.completedTasks++;
    }
}
