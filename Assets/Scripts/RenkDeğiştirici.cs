using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RenkDeğiştirici : MonoBehaviour
{
    public SpriteRenderer ressam1, ressam2;
    public Color renk1,renk2,renk3,renk4,renk5;
    public AudioSource bitisSes;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Space tuşuna basınca bu olsun
            RenkDegistir(ressam1);
            RenkDegistir(ressam2);



            if (ressam1.color == ressam2.color)
            {
                //Renkler eşitse kazandın
                Debug.Log("Tebrikler");
                bitisSes.Play();    
            }
        }
        
    }

    private void RenkDegistir(SpriteRenderer ressam)
    {
        //Rastgele sayi
        int rastgeleSayi = Random.Range(1, 6);

        switch(rastgeleSayi)
        {
            //Renkleri eşle
            case 1:
                ressam.color = renk1;
                break;
            case 2:
                ressam.color = renk2;
                break;
            case 3:
                ressam.color = renk3;
                break;
            case 4:
                ressam.color = renk4;
                break;
            case 5:
                ressam.color = renk5;
                break;

        }

   
    }
}
