using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
  public  void Teleport(string tp)
  {
        SceneManager.LoadScene(tp);
  }    
}
