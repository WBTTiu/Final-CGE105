using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HealthManager : MonoBehaviour
{

    //Health
    public static int health = 3;

    public Image[] Hearts;
    public Sprite fullHeart;
    public Sprite EmptyHeart;
    //public Image[] GameStatusScreen;
    public PlayerController Character;
    public EnemyBullet EBullet;
    public EnemyBullet MorBullet;
    public GameObject GameStatusScreen;


    
    private void Start()
    {
        Character.gameObject.SetActive(true);
        EBullet.gameObject.SetActive(true);
        MorBullet.gameObject.SetActive(true);
        //GameStatusScreen[0].enabled = false;
         GameStatusScreen.SetActive(false) ;
    }
    // Update is called once per frame
    void Update()
    {
        foreach(Image img in Hearts)
        {
            img.sprite = EmptyHeart;
        }for (int i = 0; i < health; i++)
        {
            Hearts[i].sprite = fullHeart;
        }
    }
    
    

    //Lose
    private void FixedUpdate()
    {
        if (health <= 0)
        {
            //GameStatusScreen[0].enabled = true;
            GameStatusScreen.SetActive(true);
            //Character.GetComponent<PlayerController>().enabled = false;
            Character.gameObject.SetActive(false);
            EBullet.gameObject.SetActive(false);
            MorBullet.gameObject.SetActive(false);
            //EBullet.GetComponent<EnemyBullet>().enabled = false;
            //MorBullet.GetComponent<EnemyBullet>().enabled = false;
            
        }
    }

    
}
    
    /* void GameOver()
     {
         GameStatusScreen = GetComponent<Image>();
         GameStatusScreen.enabled = true;

     }*/

