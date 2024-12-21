namespace StarCi.CiFarmSDK.Types.Gameplay.Profile
{
    public class UpdateTutorialRequest
    {
        /// <summary>
        /// Index of the tutorial being updated.
        /// </summary>
        public int TutorialIndex { get; set; }

        /// <summary>
        /// Index of the step being updated within the tutorial.
        /// </summary>
        public int StepIndex { get; set; }
    }

    public class UpdateTutorialResponse
    {
    }
}
