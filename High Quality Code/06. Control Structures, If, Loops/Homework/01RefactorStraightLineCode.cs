/* 01. Refactor the following class using best practices for organizing straight-line code:
public void Cook() 
public class Chef
{
    private Bowl GetBowl()
    {   
        //... 
    }
    private Carrot GetCarrot()
    {
        //...
    }
    private void Cut(Vegetable potato)
    {
        //...
    }  
    public void Cook()
    {
        Potato potato = GetPotato();
        Carrot carrot = GetCarrot();
        Bowl bowl;
        Peel(potato);
                
        Peel(carrot);
        bowl = GetBowl();
        Cut(potato);
        Cut(carrot);
        bowl.Add(carrot);
                
        bowl.Add(potato);
    }
    private Potato GetPotato()
    {
        //...
    }
} */

namespace Homework
{
    using System;

    public class Chef
    {        
        public void Cook()
        {           
            Potato potato = this.GetPotato();
            Potato peeledPotato = this.Peel(potato);
            Potato cuttedPotato = this.Cut(peeledPotato);
            Bowl bowl = this.GetBowl();
            bowl.Add(cuttedPotato);          

            Carrot carrot = this.GetCarrot();
            Carrot peeledCarrot = this.Peel(carrot);
            Carrot cuttedCarrot = this.Cut(peeledCarrot);
            bowl.Add(cuttedCarrot);  
        }

        private Bowl GetBowl()
        {
            ////... 
        }

        private Carrot GetCarrot()
        {
            ////...
        }

        private Potato GetPotato()
        {
            ////...
        }

        private void Peel(Vegetable vegetable)
        {
            ////...
        }

        private void Cut(Vegetable vegetable)
        {
            ////...
        }
    }
}
