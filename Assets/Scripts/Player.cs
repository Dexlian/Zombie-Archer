using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public LayerMask enemyMask;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Shoot");

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100f, enemyMask))
            {
                Debug.Log(hit.collider);

                GameObject hitTarget = hit.collider.gameObject;

                Destroy(hitTarget);
            }
        }
    }
}
