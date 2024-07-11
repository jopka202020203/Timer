using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public int hp = 10;
    public AudioSource audioSource;
    public AudioClip damageSound;

    public void TakeDamage(int damage)
    {
        hp -= damage;
        print("здоровье игрока:"+hp);
        if (hp > 0)
        {
            audioSource.PlayOneShot(damageSound);
        }
        else {

            int sceneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(sceneIndex);
        }


    }
}
