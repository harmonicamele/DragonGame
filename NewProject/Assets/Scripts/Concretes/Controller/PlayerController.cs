using NewProject.Movements;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace NewProject.Controller  //klasörleme için kullandık.ve ulaşılmayı önledik
{
    public class PlayerController : MonoBehaviour
    {

        Jump _Jump; //Jumpı çağırdık
        Rigidbody2D _rb;
        PcInputController _input; //ınputları çağırdık
        AtesEtme AtesEtme;
        AudioSource audio;
        bool MouseClicked;
     
       
        private void Awake()
        {
            _rb = GetComponent<Rigidbody2D>();
            _Jump = GetComponent<Jump>();
            _input = new PcInputController();
            AtesEtme = GetComponent<AtesEtme>();
            audio = GetComponent<AudioSource>();
        }
        private void Update()
        {

            if (_input.LeftMouseClick)
            {
                MouseClicked = true;
            }
            if (_input.RightMouseClick )
            {
                AtesEtme.atesAction();
            }
        }

        private void FixedUpdate()
        {
            if (MouseClicked )
            {
                _Jump.JumpAction(_rb);
                audio.Play();

                MouseClicked = false;   //tekrar yere dusmesi için
            }
        }
        

    }
}

