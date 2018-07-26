using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterBase : MonoBehaviour
{
    public float g_moveSpeed = 15f;
    public float g_JumpPower = 3000f;
    public Rigidbody rigidbody;

    void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Move();

        if(Input.GetButtonDown("Jump"))
        {
            Jump();
        }
    }

    /// <summary>
    /// 移動
    /// </summary>
    protected virtual void Move()
    {
        float x = Input.GetAxis("Horizontal") * g_moveSpeed;
        float z = Input.GetAxis("Vertical") * g_moveSpeed;

        Debug.Log(x + " : " + z);

        rigidbody.AddForce(x, 0, z, ForceMode.Force);
    }

    /// <summary>
    /// ジャンプ
    /// </summary>
    protected virtual void Jump()
    {
        Debug.Log("Jump");
        rigidbody.AddForce(Vector3.up * g_JumpPower, ForceMode.Force);
    }

    /// <summary>
    /// 回避
    /// </summary>
    protected virtual void Avoidance()
    {

    }

    /// <summary>
    /// 通常攻撃
    /// </summary>
    protected virtual void NormalAttack()
    {

    }

    /// <summary>
    /// チャージアタック
    /// </summary>
    protected virtual void ChargeAttack()
    {

    }

    /// <summary>
    /// 奥義
    /// </summary>
    protected virtual void FatalAttack()
    {

    }

    /// <summary>
    /// ノックバック
    /// </summary>
    /// <param name="impulsePower"></param>
    public virtual void ReceiveImpulse(float impulsePower)
    {
        rigidbody.AddForce((Vector3.forward * -1) * impulsePower, ForceMode.Impulse);
    }


}
