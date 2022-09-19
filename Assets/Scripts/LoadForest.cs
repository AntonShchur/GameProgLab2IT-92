
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadForest : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            SceneManager.LoadScene("Forest");
        }
    }
}
