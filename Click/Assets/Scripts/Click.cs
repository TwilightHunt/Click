using UnityEngine;
public class Click : MonoBehaviour
{
     static public int coin = 0;

    public void onClick() 
    {
        coin++;
        Destroy(this.gameObject);
    }
}
