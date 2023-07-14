namespace BMI.Models
{
    public class BMImodel_791
    {

        public decimal? weight_791 { get; set; }

        public decimal? height_791 { get; set; }

        public decimal? CalculateBMI_791()
        {
            decimal? height = 0;
            height = height_791 * height_791;
            decimal? tempbmi = 0;
            tempbmi = weight_791 / height;
            decimal? BMI_791 = tempbmi * 703;
            return BMI_791;
        }
    }
}
