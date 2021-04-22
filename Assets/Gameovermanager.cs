using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class Gameovermanager : MonoBehaviour
{
    [SerializeField]
    private Text textHighScore = null;// 변수는 무조건 소문자
    private void Start()
    {
        textHighScore.text = string.Format("Highscore\n {0}", PlayerPrefs.GetInt("Highscore", 500));

    }


    public void OnClickRetry()
    {
        SceneManager.LoadScene("Main");
    }
}
