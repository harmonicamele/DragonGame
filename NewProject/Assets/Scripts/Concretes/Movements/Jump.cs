using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NewProject.Movements
{
    public class Jump : MonoBehaviour
    {
        [SerializeField] float JumpForce = 100f; 

        public void JumpAction(Rigidbody2D rb)
        {
            rb.velocity = Vector2.zero;  
            rb.AddForce(Vector2.up * JumpForce);
        }

    }

}
