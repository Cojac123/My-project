

using Unity.VisualScripting;
using UnityEngine;

public class Charactersheet : MonoBehaviour
{
    [SerializeField] string charactername = "Darwin.";
    [SerializeField] int proficiencybonus = 2;
    [SerializeField][Range(-5, 5)] int STR = 0;
    [SerializeField][Range(-5,5)] int DEX = 0;
    [SerializeField] bool finesseweapon;
    [SerializeField] int hitmodifier;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int diceroll = Random.Range(1, 20 + 1);
        int hitroll = 0;
        
        //Variables
        Debug.Log(charactername);
        Debug.Log(diceroll);
        Debug.Log(proficiencybonus);
        if (finesseweapon) 
        { 
          if (STR > DEX) 
            {
                hitroll = diceroll + STR + proficiencybonus;
            
            }
          else
            {
                hitroll = diceroll + DEX + proficiencybonus;
            }
        {
        else 
        {
            hitmodifier = STR + proficiencybonus;
        }

        }
        // Print charcater details and hit modifier
        Debug.Log(charactername + "'s hit modifier is " + (hitmodifier >= 0 ? "+" : "") + hitmodifier);

        int enemyAC = diceroll + hitmodifier;

        Debug.Log("Enemy AC is + enemyAC");
        Debug.Log(charactername + "rolled a " + diceroll);

        if (hitroll >= enemyAC) 
        {
            Debug.Log("Enemy is hit!");
        }
        else 
        {
            Debug.Log("Enemy is missed!");
        }
        }
        Debug.Log(hitroll);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
