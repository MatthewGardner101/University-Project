using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class InteractorScript : MonoBehaviour
{
    public LayerMask interactableLayerMask = 8;
    UnityEvent withInteract;
    public GameObject InteractionUI;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;

        if(Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, 2, interactableLayerMask))
        {
            InteractionUI.SetActive(true);
            if (hit.collider.GetComponent<Interactable>() != false) 
            {
                
                withInteract = hit.collider.GetComponent<Interactable>().withInteract;
                if (Input.GetKeyDown(KeyCode.E))
                {
                    withInteract.Invoke();
                }
            }

        }
        else
        {
            InteractionUI.SetActive(false);
        }

        
    }
}
