using BepInEx;
using UnityEngine;

namespace CavendishCowboy
{
    [BepInPlugin("litttlehawk.CavendishCowboy", "CavendishCowboy", "1.0.0")]
    public class SpeedrunReset : BaseUnityPlugin
    {

        private void Awake()
        {
            Logger.LogInfo("CavendishCowboy is loaded!");
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Tab))
            {
                CallResetTimer();
                ResetLevel();
                Logger.LogInfo("Reset Succsessfully!");
            }
        }

        private void CallResetTimer()
        {
            try
            {
                SpeedRunTimer.ResetTimer();
            }
            catch (System.Exception ex)
            {
                Logger.LogError($"Failed to call SpeedRunTimer.ResetTimer(): {ex}");
            }
        }

        private void ResetLevel()
        {
            try
            {
                LevelSwitch.ChangeScene("Tutorial Level");
            }
            catch (System.Exception ex)
            {
                Logger.LogError($"Failed to call LevelManager.SelectLevel(): {ex}");
            }
        }
    }
}
