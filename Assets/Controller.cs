using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Scripting.APIUpdating;

public class Controller : MonoBehaviour
{
    [SerializeField]
    CharacterController character;
    public Vector2 moveinput;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void FixedUpdate()
    {
        Vector3 move = transform.right * moveinput.x + transform.forward * moveinput.y;
        character.Move(move * 5f * Time.deltaTime);
    }
    public void OnMove(InputValue value)
    {
        moveinput = value.Get<Vector2>();
    }
}
