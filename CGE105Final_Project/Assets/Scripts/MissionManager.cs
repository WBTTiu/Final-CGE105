using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MissionManager : MonoBehaviour
{

    public static int Blueprint = 0;
    public Image[] Blueprints;
    
    public Sprite fullBP;
    public Sprite EmptyBP;
    //public Image[] GameStatusScreen;
    public GameObject GameStatusScreen;

    public PlayerController Character;
    public EnemyBullet EBullet;
    public EnemyBullet MorBullet;

   

    // Start is called before the first frame update
    void Start()
    {

        Character.gameObject.SetActive(true);
        EBullet.gameObject.SetActive(true);
        MorBullet.gameObject.SetActive(true);
        //GameStatusScreen[0].enabled = false;
        GameStatusScreen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        foreach (Image img in Blueprints)
        {
            img.sprite = EmptyBP;
        }
        for (int i = 0; i < Blueprint; i++)
        {
            Blueprints[i].sprite = fullBP;

        }
    }


    //Win
    private void FixedUpdate()
    {
        if (Blueprint == 3)
        {
            //GameStatusScreen[0].enabled = true;
            GameStatusScreen.SetActive(true);
            Character.gameObject.SetActive(false);
            EBullet.gameObject.SetActive(false);
            MorBullet.gameObject.SetActive(false);
            
        }
    }

}
