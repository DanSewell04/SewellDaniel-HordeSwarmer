using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public float attackRange = 5f;
    public LayerMask attackLayer;

    void Update()
    {
       
        if (Input.GetMouseButtonDown(0))
        {
            Attack();
        }
    }

    void Attack()
    {
       
        if (gameObject.CompareTag("Gun"))
        {
            
            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.forward, out hit, attackRange, attackLayer))
            {
                
                if (hit.collider.CompareTag("Enemy"))
                {
                    
                    Debug.Log("Enemy Hit!");

                    
                }
            }
        }
    }
}

