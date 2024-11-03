using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Swing : MonoBehaviour
{
   [SerializeField] private float _force = 10;
   
   private Rigidbody _rigidbody;

   private void Start()
   {
      _rigidbody = GetComponent<Rigidbody>();
   }

   private void Update()
   {
      if (Input.GetKeyUp(KeyCode.Space))
      {
         _rigidbody.AddForce(transform.forward * _force);
      }   
   }
}
