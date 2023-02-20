﻿using System.ComponentModel.DataAnnotations;

namespace Lab2.Models
{
    public class TipCalculator
    {
        [Required(ErrorMessage = "Please enter a meal cost")]
        [Range(0,10000, ErrorMessage = "Cost of the meal should be greater than $0 and less than $10000")]
        public double? MealCost { get; set; }

        public double CalculateTip(double percent)
        {
            if (MealCost.HasValue)
            {
                var tip = MealCost.Value * percent;
                return tip;
            }
            return 0.0;
        }

        
    }


}

