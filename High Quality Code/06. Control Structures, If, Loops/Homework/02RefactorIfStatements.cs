/* 02. Refactor the following if statements:
Potato potato;
////... 
if (potato != null)
   if(!potato.HasNotBeenPeeled && !potato.IsRotten)
   Cook(potato);

 if (x >= MIN_X && (x =< MAX_X && ((MAX_Y >= y && MIN_Y <= y) && !shouldNotVisitCell)))
{
   VisitCell();
} */

namespace Homework
{
    using System;

    public class RefactorIfStatements
    {
        public void Cook()
        {
            Potato potato;
            ////... 
            if (potato == null)
            {
                throw new ArgumentNullException("There are no potatoes!");
            }
            else if (potato.IsPeeled && potato.IsEdible)
            {
                this.Cook(potato);
            }
            else
            {
                throw new ArgumentException("The potato can not be cooked!");
            }
        }

        public void GoToCell() 
        {
            bool isXInRange = MIN_X <= x && x <= MAX_X;
            bool isYInRange = MIN_Y <= y && y <= MAX_Y;
            if (isXInRange && isYInRange && canVisitCell)
            {
                VisitCell();
            }
        }
    }
}