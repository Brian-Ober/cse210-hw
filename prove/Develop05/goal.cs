using System;

public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _assignedPoints;

    

    
    
    public int _totalPoints = 0;

   
    public virtual void NewGoal(){
        
    }

    public abstract void Completed();
    

    public abstract void display();
    
    
}