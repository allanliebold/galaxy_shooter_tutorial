using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
  
    void Update () {
      // If other is laser, destroy this (and the laser too)
        
      // If other is player, damage or kill player
    }
    
    void Movement () {
        // move down
        // move left and right    
    }
    
    void Death () {
        // destroy enemy on collision with player shot or with player object
    }
    
    void KillPlayer() {
        // collide with player, call player.Death()
        // and destroy enemy object
    }
}
