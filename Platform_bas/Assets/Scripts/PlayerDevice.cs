using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerDevice : MonoBehaviour
{
    public GameObject player1Prefab;
    public GameObject player2Prefab;
    // Start is called before the first frame update
    void Start()
    {
        var p1 = PlayerInput.Instantiate(player1Prefab, controlScheme: "KeyboardWASD", pairWithDevice: Keyboard.current);
        var p2 = PlayerInput.Instantiate(player2Prefab, controlScheme: "KeyboardArrows", pairWithDevice: Keyboard.current);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
