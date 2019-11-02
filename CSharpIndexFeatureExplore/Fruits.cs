using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace CSharpIndexFeatureExplore
{
    public enum FoodType 
    {
        JUNK =0,
        GO =1, 
        GROW =2
    }

    public class Food
    {
        private Dictionary<FoodType, string[]> foodCollection;

        public Food()
        {
            foodCollection = new Dictionary<FoodType, string[]>
            {
                { FoodType.JUNK, new string[] { "Potato Chips", "Sweet Potato Chips"} },
                { FoodType.GO, new string[] { "Sweet Potatoes", "Rice", "Pasta", "Bread" } },
                { FoodType.GROW, new string[] { "Chicken", "Eggs", "Fish", "Meat" } }
            };
        }

        public int FruitsLength { get; set; }

        [IndexerName("FoodPyramid")]
        public string[] this[FoodType index, string foodType = ""]
        {
            get 
            { 
                return foodCollection[index]; 
            }
            
            set 
            {
                if(!Enum.GetNames(typeof(FoodType)).Any( f => f == foodType))
                {
                    throw new ApplicationException("Food type not available");
                }

                foodCollection[index] = value;
            } 
        }
    }
}
