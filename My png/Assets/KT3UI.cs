using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KT3UI : MonoBehaviour
{


    [SerializeField] private GameObject _prefabLevels;
    [SerializeField] private RectTransform root;
    [SerializeField] private int _minStarsCount;
    [SerializeField] private int _maxStarsCount;
    [SerializeField] private int levelCount;
    void Start()
    {
        FillLevelMenu();
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    private void FillLevelMenu()
    {
        for(int i = 0; i < levelCount; i++)
        {
            GameObject levelButton = Instantiate(_prefabLevels, root);
            if(levelButton.TryGetComponent(out LevelButtonView levelButtonView))
            {
                levelButtonView.SetupLevelButton(i + 1, Random.Range(_minStarsCount, _maxStarsCount));
            }
        }
    }
    private void ClearLeverMenu()
    {
        for(int i = 0; i < root.childCount; i++)
        {
            Destroy(root.GetChild(i).gameObject);
        }
    }
    
}
