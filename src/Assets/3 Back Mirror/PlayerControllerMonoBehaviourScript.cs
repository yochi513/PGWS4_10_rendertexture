using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControllerMonoBehaviourScript : MonoBehaviour
{
    [SerializeField] float FORWARD_ACCELARATION = 30.0f; // 加速
    [SerializeField] float SIDE_ACCELARATION = 1000.0f;
    [SerializeField] float FORWARD_DAMPING = 4.0f; // 自動減速
    [SerializeField] float SIDE_DAMPING = 1.0f;

    float forwardSpeed = 0.0f;
    float sideSpeed = 0.0f;

    void Update()
    {
        var current = Keyboard.current;
        if (current == null) return;

        // 入力取得
        float forwardInput = 0.0f;
        if(current.wKey.isPressed) forwardInput += 1.0f;
        if(current.sKey.isPressed) forwardInput -= 1.0f;
        float sideInput = 0.0f;
        if(current.aKey.isPressed) sideSpeed -= 1.0f;
        if(current.dKey.isPressed) sideSpeed += 1.0f;

        forwardSpeed += forwardInput * FORWARD_ACCELARATION * Time.deltaTime;
        sideSpeed += sideInput * SIDE_ACCELARATION * Time.deltaTime;

        // 移動
        transform.Translate(Vector3.forward * forwardSpeed * Time.deltaTime);
        transform.Rotate(Vector3.up * sideSpeed * Time.deltaTime);

        // 減速
        forwardSpeed -= forwardSpeed * FORWARD_DAMPING * Time.deltaTime;
        sideSpeed -= sideSpeed * SIDE_DAMPING * Time.deltaTime;
    }
}
