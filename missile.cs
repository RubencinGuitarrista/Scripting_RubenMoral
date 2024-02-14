using System.Collections;
using System.Collections.Generic;  
using UnityEngine;

public class missile : MonoBehaviour
{
  void Start(){
    transform.position += transform.forward *speed * Time.deltaTime;
    Destroy(gameObject, 3);
  }
  void Destroy(GameObject turtle){
      
  }
}
