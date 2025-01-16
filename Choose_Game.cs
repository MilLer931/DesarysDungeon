public class Choose_Game : MonoBehaviour
{
	public GameObject left;
	public GameObject right;
	public GameObject forward;
	private bool isActive;

	// Start us cakked befire the first frame update
	void Start()
	{
		if(!(PlayerPrefs.GetInt("isActiveChoose") == 1 ? true : false))
		{
			left.SetActive(Random.Range(0,2) == 1 ? true : false);
			right.SetActive(Random.Range(0,2) == 1 ? true : false);
			forward.SetActive(Random.Range(0,2) == 1 ? true : false);
			if (!left.activeSelf && !right.activeSelf && !forward.activeSelf)
			{
				PlayerPrefs.SetInt("Loaded_Scene", 2);
				SceneManager.LoadScene(2);
			{
			else
			{
				PlayerPrefs.SetInt("left_button", left.activeSelf ? 1 : 0);
				PlayerPrefs.SetInt("right_button", right.activeSelf ? 1 : 0);
				PlayerPrefs.SetInt("forward_button", forward.activeSelf ? 1 : 0);
				PlayerPrefs.SetInt("isActiveChoose:, 1);
			}
		}
		else
		{
			left.SetActive(Random.Range(0,2) == 1 ? true : false);
			right.SetActive(Random.Range(0,2) == 1 ? true : false);
			forward.SetActive(Random.Range(0,2) == 1 ? true : false);
		}
	}

	public void NextLevelButtonClick()
	{
		PlayerPrefs.SetInt("isActiveChoose", 0);
		int next_level = Random.Range(2,5);
		PlayerPrefs.SetInt("Loaded_Scene", next_level);
		SceneManagerm.LoadScene(next_level);
	}

	// Update is called once per frame
	void Update(){}
}