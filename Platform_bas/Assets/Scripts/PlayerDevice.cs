using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerDevice : MonoBehaviour
{
    public GameObject player1Prefab;
    public GameObject player2Prefab;

    void Start()
    {
        var p1 = PlayerInput.Instantiate(player1Prefab, controlScheme: "KeyboardWASD", pairWithDevice: Keyboard.current);
        var p2 = PlayerInput.Instantiate(player2Prefab, controlScheme: "KeyboardArrows", pairWithDevice: Keyboard.current);
    }

    void Update()
    {
        
    }
}
