
namespace YG
{
    [System.Serializable]
    public class SavesYG
    {
        public bool isFirstSession = true;
        public string language = "ru";
        public bool feedbackDone;
        public bool promptDone;

        // Ваши сохранения
        public int savedCompletedLevels = 1;
        public float savedSoundsVolume = 0.7f;
        public float cameraViewValue;
    }
}
