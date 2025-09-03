using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreUI;
    [SerializeField] private GameObject startMenuUI;
    [SerializeField] private GameObject gameOverUI;

    GameManager gm;
    private void Start()
    {
        gm = GameManager.Instance;
        gm.onGameOver.AddListener(ActivateGameOverUI);
    }
    public void ActivateGameOverUI()
    {
        gameOverUI.SetActive(true);
    }

    public void PlayButtonHandler()
    {
        gm.StartGame();
    }
    private void OnGUI()
    {
        scoreUI.text = GameManager.Instance.PrettyScore();
    }
}
