using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    // Start is called before the first frame update

    public int[] inventory;
    public GameObject[] weaponSlot;

    

    void Start()
    {
        weaponSlot = new GameObject[2];
        inventory = new int[2];

        weaponSlot[0] = GameObject.FindGameObjectWithTag("Secondary");
        weaponSlot[1] = GameObject.FindGameObjectWithTag("Primary");

        /*
         weaponSlot[0] = GameObject.Find("WeaponHolder").transform.Find("Primary").gameObject;
         weaponSlot[1] = GameObject.Find("WeaponHolder").transform.Find("Secondary").gameObject;
         */
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
