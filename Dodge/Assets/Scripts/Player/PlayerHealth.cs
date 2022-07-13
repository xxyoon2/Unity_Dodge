using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public void Die()
    {
        // 게임 오브젝트를 삭제시키면 됨
        gameObject.SetActive(false);

        FindObjectOfType<GameManager>().End();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bullet")
        {
            Die();
        }
        
    }
}
