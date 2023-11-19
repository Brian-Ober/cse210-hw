using System;

public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _assignedPoints;

    protected string _type;

    public string getType()
    {
        return _type;
    }
    
    public int _totalPoints = 0;

   
    public virtual void NewGoal(string type){
        
    }

    public abstract void Completed();
    

    public abstract void display();
    
    
}