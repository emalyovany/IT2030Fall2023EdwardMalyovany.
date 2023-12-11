using System.ComponentModel.DataAnnotations;

namespace TipCalculator.Models
{
    public class Calculator
    {
        [Required(ErrorMessage = "Please enter a value for cost of meal.")]
        [Range(0.01, 10000000.0, ErrorMessage = "Cost of meal must be greater than zero.")]
        public double? MealCost { get; set; }

        public double CalculateTip(double percent)
        {
            if (MealCost.HasValue && percent > 0)
            {
                // Assuming percent is passed as a decimal (e.g., 15% is passed as 0.15)
                var tip = MealCost.Value * percent;
                return tip;
            }
            else
            {
                // Return 0 if MealCost is not set or percent is not greater than 0
                return 0;
            }
        }
    }
}
