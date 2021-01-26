using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NewProject.Movements
{
    public class Mover : MonoBehaviour
    {
        [SerializeField] float moveSpeed = 5f;
        [SerializeField] DirectionEnum direction ;
        Rigidbody2D rb;
        private void Awake()
        {
            rb = GetComponent<Rigidbody2D>();
        }
        private void Start()
        {
            
            rb.velocity = SelectedNewDirection() * moveSpeed;      
        }
        private Vector2  SelectedNewDirection()  
        {
            Vector2 SelectedDirection;
            if (direction==DirectionEnum.Left)
            {
                SelectedDirection = Vector2.left; 
            }
            else
            {
                SelectedDirection = Vector2.right; 
            }
            return SelectedDirection;
        }
    }

}
