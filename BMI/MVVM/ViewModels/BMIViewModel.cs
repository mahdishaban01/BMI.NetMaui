namespace BMI.MVVM.ViewModels
{
    public class BMIViewModel
    {
        public Models.BMI BMI { get; set; }

        public BMIViewModel()
        {
            BMI = new Models.BMI
            {
                Height = 180,
                Weight = 55
            };
        }
    }
}
