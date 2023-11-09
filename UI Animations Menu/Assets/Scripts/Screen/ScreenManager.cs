using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ebac.Core.Singleton;

namespace Screens
{
    public class ScreenManager : Singleton<ScreenManager>
    {
        public List<ScreenBase> screenBases;
        public List<GameObject> objs;

        public ScreenType startScreen = ScreenType.Painel;

        private ScreenBase _currentScreen;

        //wpublic Vector3 vec;

        private void Start()
        {
            /*transform.Scale(2);
            gameObject.Scale(2);*/
            //screenBases.GetRandom();

            objs.GetRandom();

            HideAll();
            ShowByType(startScreen);
        }

        private void GetRandom()
        {
            Random.Range(0, screenBases.Count);
        }

        public void ShowByType(ScreenType type)
        {
            if (_currentScreen != null) _currentScreen.Hide();

            var nextScreen = screenBases.Find(i => i.screenType == type);

            nextScreen.Show();
            _currentScreen = nextScreen;

        }

        public void HideAll()
        {
            screenBases.ForEach(i => i.Hide());
        }
    }

}
