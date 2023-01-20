using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGameDoorOpen : MonoBehaviour
{
    [SerializeField] private Animator myDoor = null;

    [SerializeField] private string doorOpen = "Door open";


    EndCount endCount;
    public GameObject player;
    private bool hasOpened = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        endCount = player.GetComponent<EndCount>();
        
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (endCount.completedTasks == 2)
        {
            Debug.Log("Hi");
            if (other.CompareTag("Player"))
            {
                myDoor.Play(doorOpen, 0, 0.0f);
                GetComponent<Collider>().enabled = false;
                GetComponent<AudioSource>().Play();
                

            }
        }

    }
}
